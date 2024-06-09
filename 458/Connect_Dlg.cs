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
    public partial class ConnectDlg : Form
    {
        public ConnectDlg()
        {
            InitializeComponent();
        }

        private void lvHardware_SelectedIndexChanged(object sender, EventArgs e)
        {
            ushort lhHw = 0;

            // Only if one ListView Item is selected.
            if (lvHardware.SelectedItems.Count > 0)
                // Get the assigned hardware handle from the ListView Item.
                lhHw = (ushort)lvHardware.SelectedItems[0].Tag;

            // If the hardware handle is valid
            // the User can click the OK Button to connect.
            btnOk.Enabled = lhHw != 0;
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Escape)
                DialogResult = DialogResult.Cancel;
            if (((Keys)e.KeyChar == Keys.Enter)&&(btnOk.Enabled))
                DialogResult = DialogResult.OK;
        }

    }
}
