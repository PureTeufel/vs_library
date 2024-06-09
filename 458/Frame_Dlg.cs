// Copyright (C) 2009 PEAK-System Technik GmbH.  All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLinView
{
    public partial class FrameDlg : Form
    {
        #region Attibuts
        private CGlobalFrameTable m_pGFT;
        private CXmtFrameList m_pXmtFrames;
        private object[] m_lDataFields;
        private int m_nFrameIdx;
        private bool m_fCreateFrame;
        private Peak.Lin.TLINHardwareMode m_HwMode;
        #endregion

        #region Methods

        #region Private
        /// <summary>
        /// Fill the ComboBox with the all possible Frame-IDs
        /// from the Global Frame Table.
        /// </summary>
        /// <param name="AGFT">The Global Frame Table.</param>
        private void FillIdCombo(CGlobalFrameTable AGFT)
        {
            int i, nCnt;
            string S;
            
            // Remove all element from the ComboBox.
            cbIDs.Items.Clear();
            // Get the count of the Frame Definition objects
            // in the Global Frame Table.
            nCnt = AGFT.Count;
            // Each Frame Definition objects
            for (i = 0; i < nCnt; i++)
            {
                if (m_HwMode == Peak.Lin.TLINHardwareMode.modMaster)
                {
                    // If the Hardware is initialize as Master
                    // all kind of Direction allowed for transmit
                    // or update.
                    // If the direction is disabled than continue
                    // and do NOT add it to the ComboBox.
                    if (AGFT[i].Direction == EDirection.Disabled)
                        continue;
                }
                else
                {
                    // If the Hardware is initialize as Slave
                    // only the Direction Publisher allowed for
                    // update.
                    // If another Direction as Publisher than
                    // continue and do NOT add it to the ComboBox.
                    if (AGFT[i].Direction != EDirection.Publisher)
                        continue;
                }
                // Add the Frame-ID from the Frame Definition
                // object to the ComboBox.
                S = AGFT[i].ID;
                cbIDs.Items.Add(S);
            }
        }

        /// <summary>
        /// Refreshs the edit controls and information labels
        /// on the Dialog with the data from the delivered
        /// Frame Definition.
        /// </summary>
        /// <param name="AFD">The Frame Definition.</param>
        private void RefreshControls(CFrameDefinition AFD)
        {
            int i, nLen;
            string S;
            bool lfIsPublisher;
            bool lfIsDef;

            // Check the delivered Frame Definition
            // object at first.
            if (AFD != null)
            {
                // Check the direction of the Frame Definition
                lfIsPublisher = AFD.Direction == EDirection.Publisher;
                // Check the Type of the Frame Definition object
                // It can be CFrameDefinition or CCustomFrame objects
                // because the CCustomFrame is inherited from CFrameDefinition
                // and it had the same Properties.
                lfIsDef = AFD.GetType().Name == "CFrameDefinition";
                // Get the length (data bytes) of Frame Definition.
                nLen = AFD.Length;
                // Each bytes of Frame.
                for (i = 0; i < nLen; i++)
                {
                    // If the delivered object is a CCustomFrame
                    // it has also the data property.
                    if (!lfIsDef)
                    {
                        // Assign the values from CCustomFrame.Data
                        // to the edit controls.
                        S = String.Format("{0:X2}", ((CCustomFrame)AFD).Data[i]);
                        ((TextBox)m_lDataFields[i]).Text = S;
                    }
                    // The edit controls are only writeable if the
                    // direction of the Frame is Publisher.
                    ((TextBox)m_lDataFields[i]).Enabled = lfIsPublisher;
                    ((TextBox)m_lDataFields[i]).Visible = true;
                }
                // Each other edit controls
                for (i = nLen; i < 8; i++)
                {
                    // Do not show and diable.
                    ((TextBox)m_lDataFields[i]).Enabled = false;
                    ((TextBox)m_lDataFields[i]).Visible = false;
                }
                // Read the Definition values from the Frame
                lbPID.Text = AFD.ProtectedID;
                lbDirect.Text = AFD.Direction.ToString();
                lbLen.Text = nLen.ToString();
                lbCheck.Text = AFD.ChecksumType.ToString();
            }
        }

        /// <summary>
        /// Refreshs the controls of the dialog window
        /// with the values of the frame with the specified
        /// index position.
        /// </summary>
        /// <param name="Index">Specified the index of the frame
        /// that values have to show on the dialog.</param>
        private void DoSelect(int Index)
        {
            int nId,nIdx;
            string S;

            if (Index >= 0)
            {
                // If the index is valid
                // read the Text of the ComboBox.
                S = cbIDs.Text;
                // Remove the character 'h' from
                // the end of the text (Frame-ID).
                S = S.Substring(0, S.Length - 1);
                // Convert into decimal value.
                nId = Convert.ToInt32(S, 16);
                // Get the index of the Frame-ID in
                // the Global Frame Table.
                nIdx = m_pGFT.IndexOf(nId);
                // If the index is invalid than return.
                if (nIdx < 0)
                    return;
                // Refresh the controls on the Dialog
                // with the values of the Frame Definition.
                RefreshControls(m_pGFT[nIdx]);
            }
            else
            {
                // Do diable all data edit fields.
                for (nIdx = 0; nIdx < 8; nIdx++)
                    ((TextBox)m_lDataFields[nIdx]).Enabled = false;
            }
        }

        private void FrameDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool fError = false;
            int nIdx, nLen, nID;
            byte bValue;
            string S;

            if (DialogResult == DialogResult.OK)
            {
                // If the user close the Dialog
                // with the OK Button then check
                // if the frame have to create.
                if (m_fCreateFrame)
                {
                    // Create the Frame.
                    // Get the selected index.
                    nIdx = cbIDs.SelectedIndex;
                    if (nIdx >= 0)
                    {
                        // If the selected index is valid
                        // than get the text (Frame-ID)
                        // from selection.
                        S = cbIDs.Items[nIdx].ToString();
                        // Delete the 'h' from the text.
                        S = S.Substring(0, S.Length - 1);
                        // Convert the hex value to decimal.
                        nID = Convert.ToInt32(S, 16);
                        // Find the Frame-ID in the Global
                        // Frame Table.
                        nIdx = m_pGFT.IndexOf(nID);
                        if(nIdx >= 0)
                            // If the ID was found in the Table
                            // than create a new Custom Frame based
                            // on the Frame Definition.
                            m_nFrameIdx = m_pXmtFrames.AddFrame(m_pGFT[nIdx]);
                    }
                }
                if(m_nFrameIdx >= 0)
                {
                    // If the frame have not to create or
                    // it was created and the index of
                    // the Custom Frame is knowing.
                    
                    // Get the Length of the Custom Frame.
                    nLen = m_pXmtFrames.Item[m_nFrameIdx].Length;
                    // Each byte in the Custom Frame.
                    for (int i = 0; i < nLen; i++)
                    {
                        try
                        {
                            // Try to read the value from the edit control.
                            // The value have to be in hexadecimal format.
                            bValue = Convert.ToByte(((TextBox)m_lDataFields[i]).Text, 16);
                        }
                        catch
                        {
                            // If the value have an invalid format
                            // than initialize to 0.
                            bValue = 0;
                        }
                        // Assign the readed value to the Custom Frame Data.
                        m_pXmtFrames.Item[m_nFrameIdx].Data[i] = bValue;
                    }
                }
                else // Error occurs.
                    fError = true;
            }
            // If an error occurs do not allow to close the Dialog.
            e.Cancel = fError;
        }

        private void cbIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected index from the
            // ComboBox of IDs.
            DoSelect(cbIDs.SelectedIndex);
        }

        private void FrameDlg_Shown(object sender, EventArgs e)
        {
            // If the frame will be edit.
            if ((m_fCreateFrame == false) && (m_nFrameIdx >= 0))
            {
                int i;
                String S;

                // Read the Frame-ID of the Custom Frame
                // as String from the Transmit List.
                S = m_pXmtFrames.Item[m_nFrameIdx].ID;
                // Find the position of the Frame-ID
                // in the list of ComboBox.
                i = cbIDs.Items.IndexOf(S);
                // Set the select index of the ComboBox
                // to the position of the Frame-ID.
                cbIDs.SelectedIndex = i;
                // Refresh the Dialog controls with
                // the values of the Custom Frame.
                RefreshControls(m_pXmtFrames.Item[m_nFrameIdx]);
            }
            // The ID ComboBox should only be enable
            // if the frame have to create.
            // If the frame will be edit the Frame-ID
            // can not change.
            cbIDs.Enabled = m_fCreateFrame;
            if (!m_fCreateFrame)
                SelectNextControl(cbIDs, true, true, false, true);
            // If at least one Frame-ID is available to transmit
            // select the first one in the ComboBox.
            else if (cbIDs.Items.Count > 0)
                cbIDs.SelectedIndex = 0;
            // Set to default
            else
                DoSelect(-1);
        }

        private void Data_Changed(object sender, EventArgs e)
        {
            TextBox leData;

            leData = ((TextBox)sender);
            if (leData.TextLength == 2)
                SelectNextControl(leData, true, true, false, true);
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Escape)
                DialogResult = DialogResult.Cancel;
            if ((Keys)e.KeyChar == Keys.Enter)
                DialogResult = DialogResult.OK;
        }

        #endregion

        #region Internal

        /// <summary>
        /// Constructor to create a Frame Dialog Window.
        /// </summary>
        /// <param name="AGFT">The Global Frame Table object.</param>
        /// <param name="AXmtFrames">The Transmit List object.</param>
        /// <param name="mode">The LIN hardware mode.</param>
        internal FrameDlg(CGlobalFrameTable AGFT, CXmtFrameList AXmtFrames, Peak.Lin.TLINHardwareMode mode)
        {
            // Initialize the components on the formular.
            InitializeComponent();
            // Initialize the attributes.
            m_HwMode = mode;
            FillIdCombo(AGFT);
            m_pGFT = AGFT;
            m_pXmtFrames = AXmtFrames;
            m_lDataFields = new object[8];
            m_lDataFields[0] = eData1;
            m_lDataFields[1] = eData2;
            m_lDataFields[2] = eData3;
            m_lDataFields[3] = eData4;
            m_lDataFields[4] = eData5;
            m_lDataFields[5] = eData6;
            m_lDataFields[6] = eData7;
            m_lDataFields[7] = eData8;
            m_nFrameIdx = -1;
            m_fCreateFrame = false;
            lbPID.Text = "";
            lbDirect.Text = "";
            lbLen.Text = "";
            lbCheck.Text = "";
        }

        /// <summary>
        /// Shows the Frame Dialog Window modal to create or edit a LIN frame
        /// and wait for closing Window.
        /// Returns the DialogResult of the Dialog Window.
        /// </summary>
        /// <param name="owner">The Owner Window of the Dialog Window.</param>
        /// <param name="index">Zero-based integer of the position of the LIN frame to edit in the Transmit List.
        /// If a new LIN frame should create it can be -1. </param>
        /// <param name="create">Indicates if a LIN frame should create or edit an existing LIN frame.</param>
        /// <returns>Returns the DialogResult of the Dialog Window.</returns>
        internal DialogResult ShowDialogEx(IWin32Window owner, ref int index, bool create)
        {
            DialogResult retValue;

            m_fCreateFrame = create;
            m_nFrameIdx = index;
            // Show the Dialog now and wait for return.
            retValue = ShowDialog(owner);
            index = m_nFrameIdx;
            return retValue;
        }

        #endregion

        #endregion

    }
}
