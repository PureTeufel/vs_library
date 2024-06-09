// Copyright (C) 2009 PEAK-System Technik GmbH.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.ComponentModel;
using System.Threading;
using System.Diagnostics;

namespace PLinView
{
    #region Event Parameter Definitionen
    
    /// <summary>
    /// Represent a event class for property change events.
    /// </summary>
    internal class PropertyChangeEventArg: System.EventArgs
    {
        /// <summary>
        /// Type of property to change.
        /// </summary>
        internal EProperty Type;
        /// <summary>
        /// New value for the property.
        /// </summary>
        internal int Value;
        /// <summary>
        /// Boolean value to indicate if the property can be set.
        /// </summary>
        internal bool Allowed;
    }
    
    /// <summary>
    /// Represent a event class for frame received events.
    /// </summary>
    internal class FrameReceivedEventArgs : System.EventArgs
    {
        /*/// <summary>
        /// Received LIN-Frame as CCustomFrame object.
        /// </summary>
        internal CCustomFrame RcvFrame;
        /// <summary>
        /// Boolean to indicate if the received LIN-Frame is a new one.
        /// </summary>
        internal bool IsNewOne;
        /// <summary>
        /// Readed error flags from a received LIN frame
        /// </summary>
        internal PLinApi.TLINMsgErrors ErrorFlags;*/
        internal SReceivedFrame[] Frames;
        internal int ReceivedCount;
    }
    
    #endregion

    #region Delegate Definition
    
    /// <summary>
    /// Declares the delegate function of the property change event.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A PropertyChangeEventArg that contains the event data.</param>
    internal delegate void PropertyChangeEventHandler(Object sender, PropertyChangeEventArg e);
    /// <summary>
    /// Declares the delegate function of the frame received event.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A FrameReceivedEventArgs that contains the event data.</param>
    internal delegate void FrameReceivedEventHandler(Object sender, FrameReceivedEventArgs e);
    
    #endregion

    #region Structure Definition

    internal struct SReceivedFrame
    {
        /// <summary>
        /// Received LIN-Frame as CCustomFrame object.
        /// </summary>
        internal CCustomFrame RcvFrame;
        /// <summary>
        /// Boolean to indicate if the received LIN-Frame is a new one.
        /// </summary>
        internal bool IsNewOne;
        /// <summary>
        /// Readed error flags from a received LIN frame
        /// </summary>
        internal Peak.Lin.TLINMsgErrors ErrorFlags;
    }
    
    #endregion

    #region CDispatch Class
    /// <summary>
    /// Represent a Dispatch class that can be inherited by
    /// other classes they want to dispatch messages to
    /// another class or object.
    /// </summary>
    class CDispatch
    {
        #region Attibuts
        /// <summary>
        /// The owner of the dispatch class.
        /// </summary>
        protected ISynchronizeInvoke m_pOwner;
        /// <summary>
        /// Indicate if the owner is set.
        /// </summary>
        protected Boolean m_fSynchronized;
        #endregion

        #region Methods
        /// <summary>
        /// Make the choise how should be referenced an event according with the selcetd 
        /// environment (if will be direct invoked or added to the invoke list of a 
        /// synchronization control
        /// </summary>
        /// <param name="ToDispatch">The delegate to be invoked</param>
        /// <param name="parameters">the parameters of the given delegate</param>
        protected void DispatchEvent(Delegate ToDispatch, object[] parameters)
        {
            try
            {
                if (ToDispatch != null)
                {
                    if (m_fSynchronized)
                        if (m_pOwner.InvokeRequired)
                        {
                            m_pOwner.Invoke(ToDispatch, parameters);
                            return;
                        }
                    ToDispatch.DynamicInvoke(parameters);
                }
            }
            catch (Exception Ex)
            {
                throw (new Exception(string.Format("Error dispatching event: \"{0}\".  Error Message: \"{1}\"", ToDispatch.Method.Name, Ex.Message)));
            }
        }
        /// <summary>
        /// Constructor to create a base class which can dispatch message like
        /// events through different threads.
        /// </summary>
        internal CDispatch()
        {
            // In the base class the attibuts can be null.
            m_pOwner = null;
            m_fSynchronized = false;
        }
        #endregion
    }

    #endregion

    #region CFrameDefinition Class
    /// <summary>
    /// Represent the global Definition of a LIN-Frame.
    /// </summary>
    internal class CFrameDefinition
    {
        #region Attributes
        internal object m_pParent;
        /// <summary>
        /// LIN-Frame Identifier
        /// </summary>
        internal int m_nID;
        /// <summary>
        /// Datalength of the LIN-Frame
        /// </summary>
        internal int m_nLength;
        /// <summary>
        /// Type of the Checksum Calculation
        /// </summary>
        /// <remarks>
        /// 0 means Classic Checksum Calculation
        /// 1 means Enhanced Checksum Calculation
        /// </remarks>
        internal int m_nChecksumType;
        /// <summary>
        /// The m_bDirection of the LIN-Frame
        /// </summary>
        /// <remarks>
        /// 0 means diabled
        /// 1 means Publisher
        /// 2 means Subscriber
        /// 3 means Subscriber with auto length
        /// </remarks>
        internal byte m_bDirection;
        /// <summary>
        /// Is the protected LIN-Frame m_nID
        /// </summary>
        internal int m_nProtectedID;
        /// <summary>
        /// Is the Description Name of the LIN-Frame.
        /// Reserved for future implementation.
        /// </summary>
        internal string m_sName;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the Frame-ID as integer value.
        /// </summary>
        internal int IdAsInt
        {
            get { return m_nID; }
        }
        /// <summary>
        /// Gets the Frame-ID as byte value.
        /// </summary>
        internal byte IdAsByte
        {
            get { return Convert.ToByte(m_nID); }
        }
        /// <summary>
        /// Gets the Protected Frame-ID as integer value.
        /// This value includes the parity of the LIN-Frame.
        /// </summary>
        internal int ProtectedIdAsInt
        {
            get { return m_nProtectedID; }
        }

        [DisplayName("ID")]
        [Category("ReadOnly")]
        [Description("Defines a LIN-Frame identifier of the Frame definition and can be between 00h and 3Fh.")]
        public String ID
        {
            get { return String.Format("{0:X2}h", m_nID); }
        }

        [DisplayName("Length")]
        [Category("Changeable")]
        [Description("Defines the length of the LIN-Frame definition.")]
        public int Length
        {
            get { return m_nLength; }
            set
            {
                if (m_nLength != value)
                {
                    bool fAllowed = true;
                    ((CGlobalFrameTable)m_pParent).CallPropertyChangeHandler(this, EProperty.Length, value, ref fAllowed);
                    if (fAllowed == true)
                        m_nLength = value;
                }
            }
        }

        [DisplayName("Checksum Type")]
        [Category("Changeable")]
        [Description("Defines the type for the checksum calculation of the LIN-Frame definition and can be classic, enhanced or auto.")]
        public EChecksumType ChecksumType
        {
            get { return (EChecksumType)m_nChecksumType; }
            set
            {
                if (m_nChecksumType != (int)value)
                {
                    bool fAllowed = true;
                    ((CGlobalFrameTable)m_pParent).CallPropertyChangeHandler(this, EProperty.ChecksumType, (int)value, ref fAllowed);
                    if (fAllowed == true)
                        m_nChecksumType = (int)value;
                }
            }
        }

        [DisplayName("Direction")]
        [Category("Changeable")]
        [Description("Defines the direction of the LIN-Frame definition and can be publisher or subscriber. Default is subscriber.")]
        public EDirection Direction
        {
            get { return (EDirection)m_bDirection; }
            set
            {
                if (m_bDirection != (byte)value)
                {
                    bool fAllowed = true;
                    ((CGlobalFrameTable)m_pParent).CallPropertyChangeHandler(this, EProperty.Direction, (int)value, ref fAllowed);
                    if (fAllowed == true)
                        m_bDirection = (byte)value;
                }
            }
        }

        [DisplayName("Protected ID")]
        [Category("ReadOnly")]
        [Description("Defines the protected LIN-Frame identifier.")]
        public String ProtectedID
        {
            get { return String.Format("{0:X2}h", m_nProtectedID); }
        }
        #endregion
    }
    #endregion

    #region CGlobalFrameTable Class
    /// <summary>
    /// Represents a collection of supported CFrameDefinition objects.
    /// </summary>
    internal class CGlobalFrameTable : CDispatch
    {
        #region Attibuts
        /// <summary>
        /// Collection of all Frame Definition
        /// </summary>
        private List<CFrameDefinition> m_lFrameDefinitions;
        #endregion

        #region Methods
        /// <summary>
        /// Constructor to create the global LIN-Frame Definition Table.
        /// </summary>
        /// <param name="AOwner">
        /// The window based parent of the CGlobalFrameTable for optional output.
        /// It is needed if the parent want to know before at least one Property
        /// of a Frame definition will be change by the CGlobalFrameTable.
        /// </param>
        internal CGlobalFrameTable(ISynchronizeInvoke AOwner)
        {
            try
            {
                // Initialize the inherited attributes from the
                // base class CDispatch.
                m_pOwner = AOwner;
                m_fSynchronized = m_pOwner != null;
                // Create a list to handle the CFrameDefinition objects.
                m_lFrameDefinitions = new List<CFrameDefinition>(64);
                // Create all CFrameDefinition objects and set
                // them values to default. The length values is
                // set to LIN 1.2.
                // Default values:
                // - Direction = SubscriberAutoLength
                // - ChecksumType = Auto
                // - Length = see inside the loop.
                for (int i = 0; i < 64; i++)
                {
                    // From Frame-ID 0 to 31 set the length 2.
                    if ((i >= 0x00) && (i <= 0x1F))
                        AddFrameDefinition(i, 2, 3, 3);
                    // From Frame-ID 32 to 47 set the length 4.
                    else if ((i >= 0x20) && (i <= 0x2F))
                        AddFrameDefinition(i, 4, 3, 3);
                    // From Frame-ID 48 to 63 set the length 8.
                    if ((i >= 0x30) && (i <= 0x3F))
                        AddFrameDefinition(i, 8, 3, 3);
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Destructor to destroy the global LIN-Frame Definition Table
        /// </summary>
        ~CGlobalFrameTable()
        {
            // Nothing defined.
        }

        /// <summary>
        /// Adds an CFrameDefinition object to the end of the CGlobalFrameTable.
        /// </summary>
        /// <param name="AFrameDefinition">The CFrameDefinition object to be added to the end of the CGlobalFrameTable.</param>
        /// <returns>Returns the Index of position in the list.</returns>
        private int AddFrameDefinition(CFrameDefinition AFrameDefinition)
        {
            // Check the parameter at first.
            if (AFrameDefinition == null)
                // Delivered object invalid. Do not add it.
                return -1;
            else
                // Add the delivered object (CFrameDefinition) to the list.
                m_lFrameDefinitions.Add(AFrameDefinition);
            // Return the position of the new added object.
            // It should be added at the end so the position
            // must be the last entry in the list.
            return m_lFrameDefinitions.Count - 1;
        }

        /// <summary>
        /// Adds an CFrameDefinition object with the defined values to the end of the CGlobalFrameTable.
        /// </summary>
        /// <param name="AId">The Frame ID of the CFrameDefinition object to be added to the end of the CGlobalFrameTable.</param>
        /// <param name="ALength">The Frame Length of the CFrameDefinition object to be added to the end of the CGlobalFrameTable.</param>
        /// <param name="AChecksumType">The Frame Checksum Type of the CFrameDefinition object to be added to the end of the CGlobalFrameTable.</param>
        /// <param name="ADirection">The Frame Direction of the CFrameDefinition object to be added to the end of the CGlobalFrameTable.</param>
        /// <returns>Returns the Index of position in the list.</returns>
        private int AddFrameDefinition(int AId, int ALength, int AChecksumType, byte ADirection)
        {
            // Check the Frame-ID for adding.
            // Only ID's from 0 to 63 are allowed to add.
            if ((AId < 0) && (AId > 63))
                // ID is invalid. Do not add it.
                return -1;
            else
            {
                // The delivered Frame-ID is valid.
                CFrameDefinition lFD;
                byte lbID;
                
                // Create a Frame Definition object.
                // and assigned the delivered values to it.
                lFD = new CFrameDefinition();
                lFD.m_pParent = this;
                lFD.m_nID = AId;
                lFD.m_nLength = ALength;
                lFD.m_nChecksumType = AChecksumType;
                lFD.m_bDirection = ADirection;
                // Calculate the Protected-ID with
                // the delivered Frame-ID.
                lbID = Convert.ToByte(AId);
                Peak.Lin.PLinApi.GetPID(ref lbID);
                // Assign the calculated Protected-ID.
                lFD.m_nProtectedID = lbID;
                // Add the created object to the list.
                m_lFrameDefinitions.Add(lFD);
            }
            // Return the position of the new added object.
            // It should be added at the end so the position
            // must be the last entry in the list.
            return m_lFrameDefinitions.Count - 1;
        }

        /// <summary>
        /// Refreshs the definition values of the CFrameDefinition object at position AIdx in the CGlobalFrameTable.
        /// </summary>
        /// <param name="AIdx">The zero-based index of the CFrameDefintion object to refesh.</param>
        /// <param name="ALength">The length value of the CFrameDefintion object to refresh.</param>
        /// <param name="AChecksumType">The checksum type value of the CFrameDefintion object to refresh.</param>
        /// <param name="ADirection">The direction value of the CFrameDefintion object to refresh.</param>
        private void UpdateFrameDefinition(int AIdx, int ALength, int AChecksumType, byte ADirection)
        {
            // Check the index of the Frame Definition object to be update.
            if ((AIdx >= 0) && (AIdx < m_lFrameDefinitions.Count))
            {
                // The index is valid.
                CFrameDefinition lFD;
                // Get the Frame Definition object.
                lFD = m_lFrameDefinitions[AIdx];
                // Update the value of the
                // Frame Definition object.
                lFD.m_nLength = ALength;
                lFD.m_nChecksumType = AChecksumType;
                lFD.m_bDirection = ADirection;
            }
        }

        /// <summary>
        /// Remove the first occurrence of a specific CFrameDefinition object from the CGlobalFrameTable.
        /// </summary>
        /// <param name="Item">The CFrameDefinition object to remove from the CGlobalFrameTable.</param>
        private void RemoveFrameDefinition(int Item)
        {
            // Remove the Frame Definition object
            // from the list at position Item.
            m_lFrameDefinitions.RemoveAt(Item);
        }

        /// <summary>
        /// Removes all elements from the CGlobalFrameTable.
        /// </summary>
        private void Clear()
        {
            // Remove all Frame Definition objects from the list.
            m_lFrameDefinitions.RemoveRange(0, m_lFrameDefinitions.Count);
        }

        /// <summary>
        /// Sets all CFrameDefinition objects in the CGlobalFrameTable to default values.
        /// </summary>
        internal void Reset()
        {
            // Each Frame Definition objects in the List
            // update with default value.
            for (int i = 0; i < 64; i++)
            {
                // from Frame-ID 0 to 31
                if ((i >= 0x00) && (i <= 0x1F))
                    UpdateFrameDefinition(i, 2, 3, 3);
                // from Frame-ID 32 to 47
                else if ((i >= 0x20) && (i <= 0x2F))
                    UpdateFrameDefinition(i, 4, 3, 3);
                // from Frame-ID 48 to 63
                if ((i >= 0x30) && (i <= 0x3F))
                    UpdateFrameDefinition(i, 8, 3, 3);
            }
        }

        /// <summary>
        /// Sets all CFrameDefinition objects in the CGlobalFrameTable to default
        /// length and sets to the specified Direction and Checksum type. 
        /// </summary>
        /// <param name="ADir">The Direction to set in all object.</param>
        /// <param name="ACheck">The Checksum Typ to set in all objects.</param>
        internal void Reset(EDirection ADir, EChecksumType ACheck)
        {
            // Each Frame Definition objects in the List
            // update with default value.
            for (int i = 0; i < 64; i++)
            {
                // from Frame-ID 0 to 31
                if ((i >= 0x00) && (i <= 0x1F))
                    UpdateFrameDefinition(i, 2, (int)ACheck, (byte)ADir);
                // from Frame-ID 32 to 47
                else if ((i >= 0x20) && (i <= 0x2F))
                    UpdateFrameDefinition(i, 4, (int)ACheck, (byte)ADir);
                // from Frame-ID 48 to 63
                if ((i >= 0x30) && (i <= 0x3F))
                    UpdateFrameDefinition(i, 8, (int)ACheck, (byte)ADir);
            }
        }

        /// <summary>
        /// Retrieves the index within the CGlobalFrameTable of the specified item.
        /// </summary>
        /// <param name="Item">An object representing the item to locate in the CGlobalFrameTable.</param>
        /// <returns>The index of the specified item.</returns>
        internal int IndexOf(CFrameDefinition Item)
        {
            // Get the index of Item in the list. 
            return m_lFrameDefinitions.IndexOf(Item);
        }

        /// <summary>
        /// Retrieves the index within the CGlobalFrameTable of the specified Frame-ID.
        /// </summary>
        /// <param name="AId">A zero-based Integer representing the Frame-ID to locate in the CGlobalFrameTable</param>
        /// <returns>The index of the specified Frame-ID.</returns>
        internal int IndexOf(int AID)
        {
            int i, nCnt;

            // Get the count of objects in the list.
            nCnt = m_lFrameDefinitions.Count;
            // Search in the list.
            for (i = 0; i < nCnt; i++)
            {
                // If the Frame-ID is found.
                if (m_lFrameDefinitions[i].m_nID == AID)
                    return i; // Return the index.
            }
            // Frame-ID not found in the list and
            // return an invalid index.
            return -1;
        }

        /// <summary>
        /// Retrieves the index within the CGlobalFrameTable of the specified Frame-PID.
        /// </summary>
        /// <param name="APID">A zero-based Integer representing the Frame-PID to locate in the CGlobalFrameTable</param>
        /// <returns>The index of the specified Frame-PID.</returns>
        internal int ProtectedIndexOf(int APID)
        {
            int i, nCnt;

            // Get the count of objects in the list.
            nCnt = m_lFrameDefinitions.Count;
            // Search in the list.
            for (i = 0; i < nCnt; i++)
            {
                // If the Frame-ID is found.
                if (m_lFrameDefinitions[i].m_nProtectedID == APID)
                    return i; // Return the index.
            }
            // Protected-ID not found in the list and
            // return an invalid index.
            return -1;
        }

        /// <summary>
        /// Reads data from the XML reader document to assigning the elements in the CGlobalFrameTable.
        /// </summary>
        /// <param name="ADoc">XML reader document to get the data for the elements.</param>
        /// <returns>Returns true if the XML document readed successfull. Otherwise false.</returns>
        internal bool ReadData(System.Xml.XmlReader ADoc)
        {
            int i, nCnt = 0;
            string S;
            string[] sSubStr;
            System.Xml.XmlDocument lDoc;
            System.Xml.XmlReader child;
            System.Xml.XmlNode lNode;
            int nId, nLen, nCheck;
            byte bDir;

            // Check the delivered reader object.
            if (ADoc != null)
            {
                // Go to XML start tag "GFT".
                ADoc.ReadToFollowing("GFT");
                if (ADoc.HasAttributes)
                {
                    // If the start tag has attributes
                    // than read the "Entries" attribut.
                    S = ADoc.GetAttribute("Entries");
                    nCnt = Convert.ToInt32(S);
                }

                // Create a new XML document.
                lDoc = new System.Xml.XmlDocument();

                // Read the sub entries from
                // the current tag.
                child = ADoc.ReadSubtree();
                child.MoveToContent();

                // Assign the readed entries to
                // a XML Node to read each child nodes.
                lNode = lDoc.ReadNode(child);

                // If the node has child nodes.
                if (lNode.HasChildNodes)
                {
                    // The child count must be the same
                    // like the count readed some lines before.
                    if (lNode.ChildNodes.Count == nCnt)
                    {
                        // Read each child node.
                        for (i = 0; i < nCnt; i++)
                        {
                            // Set default values
                            // before reading.
                            if ((i >= 0x00) && (i <= 0x1F))
                                nLen = 2;
                            else if ((i >= 0x20) && (i <= 0x2F))
                                nLen = 4;
                            else if ((i >= 0x30) && (i <= 0x3F))
                                nLen = 8;
                            else
                                nLen = 0;
                            nCheck = 1;
                            bDir = 0;
                            
                            // Read the text inside child node tag.
                            S = lNode.ChildNodes[i].InnerText;
                            // Split the readed text.
                            sSubStr = S.Split(new char[] { ',' });
                            // Frame-ID
                            if (sSubStr.GetLength(0) >= 1)
                                nId = Convert.ToInt32(sSubStr[0]);
                            // Length
                            if (sSubStr.GetLength(0) >= 2)
                                nLen = Convert.ToInt32(sSubStr[1]);
                            // ChecksumType
                            if (sSubStr.GetLength(0) >= 3)
                                nCheck = Convert.ToInt32(sSubStr[2]);
                            // Direction
                            if (sSubStr.GetLength(0) <= 4)
                                bDir = Convert.ToByte(sSubStr[3]);
                            // Update the Frame Definition object
                            // with the readed data values.
                            UpdateFrameDefinition(i, nLen, nCheck, bDir);
                        }
                        // Reading successfull.
                        return true;
                    }
                }
                // Reading not successfull.
                return false;
            }
            // Reading not successfull.
            return false;
        }

        /// <summary>
        /// Write the Data assigned with the elements in the CGlobalFrameTable into the XML writer document.
        /// </summary>
        /// <param name="ADoc">XML writer document to hold the data from the elements.</param>
        /// <returns></returns>
        internal bool WriteData(ref System.Xml.XmlWriter ADoc)
        {
            int i, nCnt;

            // Check the delivered writer object.
            if (ADoc != null)
            {
                // Write the start tag "GFT".
                ADoc.WriteStartElement("GFT");
                // Get the count of Frame Definition object.
                nCnt = m_lFrameDefinitions.Count;
                // Write the count as attribut of start tag.
                ADoc.WriteAttributeString("Entries", nCnt.ToString());
                // For each Frame Definition object.
                for (i = 0; i < nCnt; i++)
                {
                    // Write the start tag "Definition".
                    ADoc.WriteStartElement("Definition");
                    
                    // Write the values of one Frame Definition object
                    // as text separated with "," between the tags.
                    ADoc.WriteValue(m_lFrameDefinitions[i].m_nID);
                    ADoc.WriteValue(",");
                    ADoc.WriteValue(m_lFrameDefinitions[i].m_nLength);
                    ADoc.WriteValue(",");
                    ADoc.WriteValue(m_lFrameDefinitions[i].m_nChecksumType);
                    ADoc.WriteValue(",");
                    ADoc.WriteValue(m_lFrameDefinitions[i].m_bDirection);

                    // Write the stop tag of "Definition".
                    ADoc.WriteEndElement();
                }
                // Write the stop tag of "GFT".
                ADoc.WriteEndElement();
                // Writing successfull.
                return true;
            }
            // Writing not successfull.
            return false;
        }

        #endregion

        #region Properties
        /// <summary>
        /// </summary>
        /// <param name="Index">The zero-based index of the CFrameDefinition to get or set.</param>
        internal CFrameDefinition this[int Index]
        {
            get
            {
                return m_lFrameDefinitions[Index];
            }
            set
            {
                m_lFrameDefinitions[Index] = value;
            }
        }
        /// <summary>
        /// Gets the number of CFrameDefinition objects actually contained in the CGlobalFrameTable.
        /// </summary>
        internal int Count
        {
            get { return m_lFrameDefinitions.Count; }
        }
        #endregion

        #region Events

        public PropertyChangeEventHandler OnPropertyChange = null;
        internal void CallPropertyChangeHandler(object sender, EProperty AType, int AValue, ref bool AAllowed)
        {
            // Check Event Handler at first.
            if (OnPropertyChange != null)
            {
                // The Event Handler is assigned.
                // Create the EventArg object.
                PropertyChangeEventArg pArg = new PropertyChangeEventArg();
                // Assign the parameter values to
                // EventArg object.
                pArg.Type = AType;
                pArg.Value = AValue;
                pArg.Allowed = AAllowed;
                // Call the event.
                DispatchEvent(OnPropertyChange, new object[] { sender, pArg });
                // Check if the reference parameter "Allowed"
                // was set from the process the validate
                // the event.
                AAllowed = pArg.Allowed;
            }
        }

        #endregion
    }
    #endregion

    #region CCustomFrame Class
    /// <summary>
    /// Represents a custom defintion of a LIN-Frame based on a CFrameDefinition object located in the CGlobalFrameTable.
    /// </summary>
    internal class CCustomFrame : CFrameDefinition
    {
        #region Attributes
        /// <summary>
        /// Kind of CCustomFrame
        /// [Transmit / Receive]
        /// </summary>
        private ECustomFrameKind m_eKind;
        /// <summary>
        /// Data of the frame [0 - 8]
        /// </summary>
        /// <remarks></remarks>
        private byte[] m_aData;
        /// <summary>
        /// Frame Checksum
        /// </summary>
        private byte m_bChecksum;
        /// <summary>
        /// Last Period in Milliseconds of the LIN-Frame.
        /// </summary>
        //private byte m_bFrameType;
        private UInt64 m_qwLastPeriod;
        /// <summary>
        /// Period in Milliseconds of the LIN-Frame.
        /// </summary>
        /// <remarks>For the transmit, 0 means no periodical transmission of LIN-Frame.</remarks>
        private UInt64 m_qwPeriod;
        /// <summary>
        /// Represents the Count of received or transmitted LIN-Frames.
        /// </summary>
        private UInt32 m_dwCount;
        #endregion

        #region Methods
        /// <summary>
        /// Constructor of CCustomFrame to create a custom LIN-Frame based on CFrameDefiniton object.
        /// </summary>
        /// <param name="ADefinition">Represents the CFrameDefinition object to be based the LIN-Frame.</param>
        /// <param name="AKind">Represents the Kind of CCustomFrame to be define in base on CFrameDefinition.</param>
        internal CCustomFrame(CFrameDefinition ADefinition, ECustomFrameKind AKind)
        {
            // Assign the attributes from the 
            // Definition Frame object to the
            // inherited class attibuts.
            m_nID = ADefinition.m_nID;
            m_nLength = ADefinition.m_nLength;
            m_nChecksumType = ADefinition.m_nChecksumType;
            m_bDirection = ADefinition.m_bDirection;
            m_nProtectedID = ADefinition.m_nProtectedID;
            m_sName = ADefinition.m_sName;
            // Assign the Kind of Custom Frame.
            m_eKind = AKind;
            m_bChecksum = 0;
            // Set the other attributes to
            // default values.
            m_qwLastPeriod = 0;
            m_qwPeriod = 0;
            m_dwCount = 0;
            // Create the data bytes.
            m_aData = new byte[8];
        }

        /// <summary>
        /// Destructor of CCustomFrame to destroy the LIN-Frame.
        /// </summary>
        ~CCustomFrame()
        {
            // Nothing implemented yet.
        }

        #endregion

        /// <summary>
        /// Clones the object to the specified CCustomFrame object.
        /// </summary>
        /// <param name="AFrame">The CCustomFrame object that is the destination
        /// objects cloned from the current CCustomFrame.</param>
        internal void CloneTo(ref CCustomFrame AFrame)
        {
            if (AFrame == null)
                AFrame = new CCustomFrame(this, m_eKind);
            AFrame.m_nID = m_nID;
            AFrame.m_nLength = m_nLength;
            AFrame.m_nChecksumType = m_nChecksumType;
            AFrame.m_bChecksum = m_bChecksum;
            AFrame.m_bDirection = m_bDirection;
            AFrame.m_nProtectedID = m_nProtectedID;
            AFrame.m_sName = m_sName;
            // Assign the Kind of Custom Frame.
            AFrame.m_eKind = m_eKind;
            AFrame.m_bChecksum = m_bChecksum;
            // Set the other attributes to
            // default values.
            AFrame.m_qwLastPeriod = m_qwLastPeriod;
            AFrame.m_qwPeriod = m_qwPeriod;
            AFrame.m_dwCount = m_dwCount;
            // Create the data bytes.
            m_aData.CopyTo(AFrame.m_aData, 0);
        }

        #region Properties
        /// <summary>
        /// Gets the Frame-ID of the CCustomFrame object as hexadecimal string.
        /// </summary>
        internal String IdAsString
        {
            get { return String.Format("{0:X2}h",m_nID); }
        }
        
        /// <summary>
        /// Gets the Frame-Data of the CCustomFrame object as hexadecimal string.
        /// </summary>
        internal String DataAsString
        {
            get
            {
                String sResult = "";
                if (m_eKind == ECustomFrameKind.Transmit)
                {
                    for (int i = 0; i < m_nLength; i++)
                    {
                        if(m_bDirection == (byte)EDirection.Publisher)
                            sResult = sResult + String.Format("{0:X2} ", m_aData[i]);
                        else
                            sResult = sResult + "-- ";
                    }
                }
                else
                {
                    for (int i = 0; i < m_nLength; i++)
                        sResult = sResult + String.Format("{0:X2} ", m_aData[i]);
                }
                return sResult;
            }
        }

        /// <summary>
        /// Gets or sets the Frame-Data of the CCustomFrame object as byte values.
        /// </summary>
        internal byte[] Data
        {
            get { return m_aData; }
            set { m_aData = value; }
        }

        /// <summary>
        /// Get the Frame-Direction of the CCustomFrame object as string.
        /// </summary>
        internal String DirectionAsString
        {
            get { return ((EDirection)m_bDirection).ToString(); }
        }

        /// <summary>
        /// Get the Checksum of the CCustomFrame object as string.
        /// </summary>
        internal String ChecksumAsString
        {
            get
            {
                String sResult;
                sResult = String.Format("{0:X2}h", m_bChecksum);
                return sResult;
            }
        }

        /// <summary>
        /// Gets or sets the Checksum of the CCustomFrame object.
        /// </summary>
        internal byte Checksum
        {
            get { return m_bChecksum; }
            set { m_bChecksum = value; }
        }

        /// <summary>
        /// Gets the time delay between the last two LIN-Frames in milliseconds as string.
        /// </summary>
        internal String PeriodAsString
        {
            get 
            {
                if (m_qwPeriod == m_qwLastPeriod)
                    return "";
                else
                    return Convert.ToString(m_qwPeriod - m_qwLastPeriod);
            }
        }

        /// <summary>
        /// Gets or sets the time delay between the last two LIN-Frames in milliseconds.
        /// </summary>
        internal UInt64 Period
        {
            get { return m_qwPeriod - m_qwLastPeriod; }
            set 
            {
                if (m_qwPeriod > 0)
                    m_qwLastPeriod = m_qwPeriod;
                else
                    m_qwLastPeriod = value;
                m_qwPeriod = value;
            }
        }

        /// <summary>
        /// Gets the count of received or transmitted LIN-Frames as string.
        /// </summary>
        internal String CountAsString
        {
            get { return Convert.ToString(m_dwCount); }
        }

        /// <summary>
        /// Gets or sets the count of received or transmitted LIN-Frames.
        /// </summary>
        internal UInt32 Count
        {
            get { return m_dwCount; }
            set { m_dwCount = value; }
        }
        #endregion
    }
    #endregion

    #region CCustomFrameList Class
    /// <summary>
    /// Represents the base collection of CCustomFrame objects.
    /// </summary>
    internal class CCustomFrameList : CDispatch
    {
        #region Attibuts
        
        /// <summary>
        /// Object of the Global Frame Table
        /// </summary>
        protected CGlobalFrameTable m_pDefinition;
        /// <summary>
        /// Collection of User defined Transmit Frames
        /// </summary>
        protected List<CCustomFrame> m_plCustomFrames;
        /// <summary>
        /// Thread object to handle receiving LIN frames.
        /// </summary>
        protected Thread m_pThread;
        /// <summary>
        /// Boolean to indicate if the Thread is running.
        /// </summary>
        protected Boolean m_fRunning;
        /// <summary>
        /// Time object
        /// </summary>
        protected Stopwatch m_swTime;
        
        #endregion

        #region Methods

        /// <summary>
        /// Constuctor of the CCustomFrameList class.
        /// </summary>
        internal CCustomFrameList()
        {
            // Initialize the member attributes.
            m_pThread = null;
            m_pOwner = null;
            m_fSynchronized = false;
            m_pDefinition = null;
            m_plCustomFrames = null;
        }

        /// <summary>
        /// Destuctor of the CCustomFrameList class.
        /// </summary>
        ~CCustomFrameList()
        {
            // Nothing implemented yet.
        }

        /// <summary>
        /// Removes all elements from the List.
        /// </summary>
        internal virtual void Clear()
        {
            // Only virtual in this class.
            // No implementation needed here.
        }

        /// <summary>
        /// Searches for the specified object and returns the zero-based index of the
        /// first occurrence within the entire List.
        /// </summary>
        /// <param name="AFrame">The object to locate in the List.</param>
        /// <returns>
        /// The zero-based index of the first occurrence of item within the entire List,
        /// if found; otherwise, –1.
        /// </returns>
        internal int IndexOf(CCustomFrame AFrame)
        {
            // Get the index of the delivered Custom Frame
            // from the list and return it.
            // Because the object AFrame was cloned with
            // the function "CloneTo" from the list
            // here it must be search for the right
            // index in the list.
            for (int i = 0; i < m_plCustomFrames.Count; i++)
            {
                if ((m_plCustomFrames[i].m_nID == AFrame.m_nID)
                  && (m_plCustomFrames[i].m_nProtectedID == AFrame.m_nProtectedID))
                    return i;
            }
            return -1;
        }
        
        #endregion

        #region Properties
        /// <summary>
        /// </summary>
        /// <param name="Index">The zero-based index of the CCustomFrame to get or set.</param>
        internal CCustomFrame this[int Index]
        {
            get
            {
                return m_plCustomFrames[Index];   
            }
            set
            {
                m_plCustomFrames[Index] = value;
            }
        }

        /// <summary>
        /// Gets the number of CCustomFrame objects actually contained in the CCustomFrameList.
        /// </summary>
        public int Count
        {
            get { return m_plCustomFrames.Count; }
        }
        #endregion
    }
    #endregion

    #region CRcvFrameList Class
    /// <summary>
    /// Represents the collection of CCustomFrame objects that will be received on the LIN-Bus.
    /// </summary>
    internal class CRcvFrameList : CCustomFrameList
    {
        #region Attributes
        /// <summary>
        /// Boolean to indicate if the publisher LIN frame
        /// should be received by this class in the master mode.
        /// In the slave mode of the hardware this boolean
        /// has no effect.
        /// </summary>
        private Boolean m_fSelfReceive;
        #endregion

        #region Methods
        /// <summary>
        /// Constructor of CRcvFrameList to create a receive list of LIN-frames.
        /// </summary>
        /// <param name="AOwner">
        /// The window based parent of the CRcvFrameList for optional output.
        /// It is needed if the parent want to know when at least one LIN-Frame
        /// was received by the CRcvFrameList.
        /// </param>
        /// <param name="ADefinition">The Global Frame Table created by the owner
        /// of CRcvFrameList.</param>
        internal CRcvFrameList(ISynchronizeInvoke AOwner, CGlobalFrameTable ADefinition)
        {
            // Initialize the self receive attribut
            m_fSelfReceive = true;
            // Initialize the inherited attributes from CDispatch
            m_pOwner = AOwner;
            m_fSynchronized = AOwner != null;
            // Assign the Owner Definition that indicate the Global Frame Table.
            m_pDefinition = ADefinition;
            // Initialize the list to handle all Custom Frame objects.
            m_plCustomFrames = new List<CCustomFrame>(0);
            // Create and initialize the threading
            ThreadStart threadDelegate = new ThreadStart(Execute);
            m_pThread = new Thread(threadDelegate);
            m_pThread.Priority = ThreadPriority.Normal;
            m_pThread.IsBackground = true;
            // Initialize the other member attributes.
            m_fRunning = true;
            m_swTime = new Stopwatch();
            m_swTime.Reset();
        }

        /// <summary>
        /// Destructor of CRcvFrameList to destroy the receive list of LIN-frames.
        /// </summary>
        ~CRcvFrameList()
        {
            // Check if the receiving thread
            // is running already.
            if ((m_pThread != null)
                && (m_pThread.IsAlive))
            {
                // Set the value so that the thread execute routine
                // knows that it should be finished.
                m_fRunning = false;
                m_pThread.Abort();
                // Try to stop the thread and wait 5 seconds.
                if (!m_pThread.Join(5000))
                    throw new Exception("Can not destory the Receive Thread!");
                m_pThread = null;
                m_swTime.Stop();
                m_swTime = null;
            }
        }

        /// <summary>
        /// Remove the first occurrence of a specific CCustomFrame object from the CRcvFrameList.
        /// </summary>
        /// <param name="Item">The CCustomFrame object to remove from the CRcvFrameList.</param>
        /// <returns>Returns true if the remove was succeesfull. Otherwise returns false.</returns>
        internal bool RemoveFrame(int Item)
        {
            lock (m_plCustomFrames)
            {
                if ((Item < 0) || (Item > m_plCustomFrames.Count - 1))
                    return false;

                m_plCustomFrames.RemoveAt(Item);
                return true;
            }
        }

        /// <summary>
        /// Removes all elements from the CRcvFrameList.
        /// </summary>
        internal override void Clear()
        {
            // Lock the list object.
            // If another Function of this class
            // want be access also with lock to
            // this object it have to wait until
            // the look is finished here.
            lock (m_plCustomFrames)
            {
                // Remove all received Custom Frame objects
                // from the list.
                m_plCustomFrames.Clear();
            }
        }

        /// <summary>
        /// Starts or resumes the monitoring for receiving LIN-Frames.
        /// </summary>
        internal void StartWatching()
        {
            // Check the current state of the receiving thread.
            if((m_pThread.ThreadState & System.Threading.ThreadState.Unstarted) == System.Threading.ThreadState.Unstarted)
            {
                // The thread was not started before.
                // Now it can be start.
                m_swTime.Start();
                m_pThread.Start();
            }
            else
            {
                // The thread was started and suspended
                // before. Now it can be resume.
                m_swTime.Start();
            }   
        }

        /// <summary>
        /// Suspends the monitoring for receiving LIN-Frames.
        /// </summary>
        internal void StopWatching()
        {
            // Check the current state of the receiving thread.
            if (m_pThread.ThreadState == System.Threading.ThreadState.Running)
            {
                m_swTime.Stop();
                m_swTime.Reset();
            }
        }

        /// <summary>
        /// Retrieves the index within the CRcvFrameList of the specified Frame-PID.
        /// </summary>
        /// <param name="APID">A zero-based Integer representing the Frame-PID to locate in the CRcvFrameList</param>
        /// <returns>The index of the specified Frame-PID.</returns>
        internal int ProtectedIndexOf(int APID)
        {
            int i, nCnt;

            // Get the count of Custom Frame object
            // in the list.
            nCnt = m_plCustomFrames.Count;
            for (i = 0; i < nCnt; i++)
            {
                // If the search Protected-ID is found.
                if (m_plCustomFrames[i].m_nProtectedID == APID)
                    return i; // Return the index.
            }
            // Return an invalid index.
            return -1;
        }

        /// <summary>
        /// Receiving thread procedure. It handles with the received LIN-Frames
        /// and call an event if a LIN-Frame was received.
        /// </summary>
        internal void Execute()
        {
            Peak.Lin.TLINRcvMsg lpMsg;
            SReceivedFrame[] laFrames;
            CFrameDefinition lFD;
            CCustomFrame lCF;
            int i, nCnt, nIdx, nDefIdx;

            lpMsg = new Peak.Lin.TLINRcvMsg();
            laFrames = new SReceivedFrame[50];
            try
            {
                // While the Thread is running.
                while (m_fRunning)
                {
                    i = 0;
                    nCnt = 0;
                    while (Peak.Lin.TLINError.errOK == Peak.Lin.PLinApi.Read(ClientHandle, out lpMsg))
                    {
                        // If at least one Frame is received by the LinApi.
                        // Check if the received frame is a standard type.
                        // If it is not a standard type than ignore it.
                        if (lpMsg.Type != Peak.Lin.TLINMsgType.mstStandard)
                            continue;
                        // lock the Frame list and look for an entry to update
                        // or have to create a new one.
                        lock (m_plCustomFrames)
                        {
                            lCF = null;
                            // Look for an entry with the Frame-ID
                            nIdx = ProtectedIndexOf(lpMsg.FrameId);
                            if (nIdx < 0)
                            {
                                // There is not entry in the list
                                // so it have to create a new one.
                                // Search for the Definition
                                nDefIdx = m_pDefinition.ProtectedIndexOf(lpMsg.FrameId);
                                if (nDefIdx >= 0)
                                {
                                    // If the Defintion found in the Global Frame Table
                                    // get the object.
                                    lFD = m_pDefinition[nDefIdx];
                                    // Check if Self Receive is enabled
                                    if ((m_fSelfReceive == false) &&
                                       (lFD.m_bDirection == (byte)lpMsg.Direction) &&
                                       (lFD.m_bDirection == (byte)EDirection.Publisher))
                                    {
                                        // Self Receive is disabled.
                                        // Do not add the received frame.
                                        lCF = null;
                                    }
                                    else
                                    {
                                        // Self Receive is enabled.
                                        // create a new Custom Frame based on the
                                        // Frame Defintion that was found and assign the value.
                                        lCF = new CCustomFrame(m_pDefinition[nDefIdx], ECustomFrameKind.Receive);
                                        lCF.m_nLength = lpMsg.Length;
                                        lpMsg.Data.CopyTo(lCF.Data, 0);
                                        lCF.Period = Convert.ToUInt64(lpMsg.TimeStamp / 1000);
                                        lCF.m_bDirection = (byte)lpMsg.Direction;
                                        lCF.m_nChecksumType = (int)lpMsg.ChecksumType;
                                        lCF.Checksum = lpMsg.Checksum;
                                        lCF.Count++;
                                        m_plCustomFrames.Add(lCF);
                                    }
                                }
                            }
                            else
                            {
                                // If an entry was found in the Frame list
                                // get this entry.
                                lCF = m_plCustomFrames[nIdx];
                                // Check if Self Receive is enabled
                                // CCustomFrame was defined in base on CFrameDefinition
                                // so we know here the direction of the Definition.
                                if ((m_fSelfReceive == false) &&
                                   (lCF.m_bDirection == (byte)lpMsg.Direction) &&
                                   (lCF.m_bDirection == (byte)EDirection.Publisher))
                                {
                                    // Self Receive is disabled.
                                    // Do not add the received frame.
                                    lCF = null;
                                }
                                else
                                {
                                    // Self Receive is enabled.
                                    // Edit the founded frame with the
                                    // Data from the received frame.
                                    lCF.m_nLength = lpMsg.Length;
                                    lpMsg.Data.CopyTo(lCF.Data, 0);
                                    lCF.Period = Convert.ToUInt64(lpMsg.TimeStamp / 1000);
                                    lCF.m_bDirection = (byte)lpMsg.Direction;
                                    lCF.m_nChecksumType = (int)lpMsg.ChecksumType;
                                    lCF.Checksum = lpMsg.Checksum;
                                    lCF.Count++;
                                }
                            }
                        }
                        // If the Custom frame was created
                        if (lCF != null)
                        {
                            lCF.CloneTo(ref laFrames[i].RcvFrame);
                            laFrames[i].IsNewOne = nIdx < 0;
                            laFrames[i].ErrorFlags = lpMsg.ErrorFlags;
                            nCnt++;
                            if (i == 49)
                                break;
                            else
                                i++;
                        }
                    }
                    if (nCnt > 0)
                        // Try to call the receive event with the new data.
                        CallFrameReceivedHandler(laFrames, nCnt);
                    // No LIN-Frames was received so sleep for
                    // a short time before try to read again.
                    Thread.Sleep(20);
                }
            }
            catch { }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets a CCustomFrame object from the CRcvFrameList.
        /// </summary>
        internal CCustomFrameList Item
        {
            get
            {
                return this;
            }
        }
        internal Boolean SelfReceive
        {
            get { return m_fSelfReceive; }
            set
            {
                lock (m_plCustomFrames)
                {
                    m_fSelfReceive = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets the LIN client handle in the receive list.
        /// </summary>
        internal byte ClientHandle { get; set; }
        
        #endregion

        #region Events
        /// <summary>
        /// This event occurs if a LIN-Frame will be received from the PCAN-LIN Hardware.
        /// </summary>
        internal event FrameReceivedEventHandler OnReceived;
        
        /// <summary>
        /// Calls the event OnReceived if it is assigned.
        /// </summary>
        /// <param name="AFrames">Represents a list of the received LIN-Frames.</param>
        /// <param name="ACount">Indicate the number of received LIN-Frames.</param>
        private void CallFrameReceivedHandler(SReceivedFrame[] AFrames, int ACount)
        {
            if (OnReceived != null)
            {
                FrameReceivedEventArgs rArg;
                rArg = new FrameReceivedEventArgs();
                rArg.Frames = AFrames;
                rArg.ReceivedCount = ACount;
                DispatchEvent(OnReceived, new object[] { this, rArg });
            }
        }
        #endregion
    }
    #endregion

    #region CXmtFrameList Class
    /// <summary>
    /// Represents the collection of CCustomFrame objects that could be transmitted on the LIN-Bus.
    /// </summary>
    internal class CXmtFrameList : CCustomFrameList
    {
        #region Methods
        /// <summary>
        /// Constructor of CXmtFrameList to create a transmit list of LIN-frames
        /// </summary>
        /// <param name="ADefinition">The Global Frame Table created by the owner
        /// of CXmtFrameList.</param>
        internal CXmtFrameList(CGlobalFrameTable ADefinition)
        {
            m_pDefinition = ADefinition;
            m_plCustomFrames = new List<CCustomFrame>(0);
        }

        /// <summary>
        /// Destructor of CXmtFrameList to destroy the transmit list of LIN-frames.
        /// </summary>
        ~CXmtFrameList()
        {
            Clear();
            m_plCustomFrames = null;
        }

        /// <summary>
        /// Adds an CCustomFrame to the end of the CXmtFrameList.
        /// </summary>
        /// <param name="AFrame">The base definition for the CCustomFrame object to be added to the end of the CXmtFrameList.</param>
        /// <returns>Returns the Index of position in the list.</returns>
        internal int AddFrame(CFrameDefinition AFrame)
        {
            CCustomFrame CF;
            CF = new CCustomFrame(AFrame, ECustomFrameKind.Transmit);
            m_plCustomFrames.Add(CF);
            return m_plCustomFrames.Count - 1;
        }

        /// <summary>
        /// Updates the values from the CFrameDefintion object in the CCustomFrame.
        /// </summary>
        /// <param name="AFrame">The base definition to update the CCustomFrame object.</param>
        /// <param name="updatedFrames">
        /// Returns an array of the index of the CCustomFrame
        /// objects that was updated by the function.
        /// </param>
        internal int UpdateFrame(CFrameDefinition AFrame, out int[] updatedFrames)
        {
            int i, nCnt, nRetCnt;

            nCnt = m_plCustomFrames.Count;
            updatedFrames = new int[0];
            nRetCnt = 0;
            for (i = 0; i < nCnt; i++)
            {
                if (m_plCustomFrames[i].ID == AFrame.ID)
                {
                    m_plCustomFrames[i].m_nLength = AFrame.m_nLength;
                    m_plCustomFrames[i].m_nChecksumType = AFrame.m_nChecksumType;
                    m_plCustomFrames[i].m_bDirection = AFrame.m_bDirection;
                    nRetCnt++;
                    updatedFrames = new int[nRetCnt];
                    updatedFrames[nRetCnt - 1] = i;
                }
            }
            return nRetCnt;

        }

        /// <summary>
        /// Remove the first occurrence of a specific CCustomFrame object from the CXmtFrameList.
        /// </summary>
        /// <param name="Item">The CCustomFrame object to remove from the CXmtFrameList.</param>
        /// <returns>Returns true if the remove was succeesfull. Otherwise returns false.</returns>
        internal bool RemoveFrame(int Item)
        {
            if ((Item < 0) || (Item > m_plCustomFrames.Count - 1))
                return false;

            m_plCustomFrames.RemoveAt(Item);
            return true;
        }

        /// <summary>
        /// Removes all elements from the CXmtFrameList.
        /// </summary>
        internal override void Clear()
        {
            while (m_plCustomFrames.Count > 0)
                RemoveFrame(m_plCustomFrames.Count - 1);
        }

        /// <summary>
        /// Sets the counter of all elements from the CXmtFrameList
        /// to default value (0).
        /// </summary>
        internal void ClearCounter()
        {
            for (int i = 0; i < m_plCustomFrames.Count; i++)
                ((CCustomFrame)m_plCustomFrames[i]).Count = 0;
        }

        /// <summary>
        /// Checks if any CCustomFrame object within the CXmtFrameList is defined based on AFrame.
        /// </summary>
        /// <param name="AFrame">The CFrameDefinition for which CXmtFrameList should be search.</param>
        /// <returns>Returns true if at least one CCustomFrame object is defined based on AFrame. Otherwise false.</returns>
        internal bool AnyUsedBy(CFrameDefinition AFrame)
        {
            int i, nCnt;
            bool fAnyUse = false;
            CCustomFrame lCF;
            
            nCnt = m_plCustomFrames.Count;
            for (i = 0; i < nCnt; i++)
            {
                lCF = m_plCustomFrames[i];
                fAnyUse = fAnyUse || (lCF.m_nID == AFrame.m_nID);
            }
            return fAnyUse;
        }

        /// <summary>
        /// Reads data from the XML reader document to assigning the elements in the CXmtFrameList.
        /// </summary>
        /// <param name="ADoc">XML reader document to get the data for the elements.</param>
        /// <returns>Returns true if the XML document readed successfull. Otherwise false.</returns>
        internal bool ReadData(System.Xml.XmlReader ADoc)
        {
            int i, nCnt = 0;
            int j, nCnt2, nLen;
            string S;
            string[] sSubStr;
            System.Xml.XmlDocument lDoc;
            System.Xml.XmlReader child;
            System.Xml.XmlNode lNode;
            System.Xml.XmlNode cNode;
            int nIdx;
            byte[] lbData;
            CCustomFrame lCF;

            if (ADoc != null)
            {
                ADoc.ReadToFollowing("XMT-Frames");
                if (ADoc.HasAttributes)
                {
                    S = ADoc.GetAttribute("Entries");
                    nCnt = Convert.ToInt32(S);
                }

                lDoc = new System.Xml.XmlDocument();

                child = ADoc.ReadSubtree();
                child.MoveToContent();

                lNode = lDoc.ReadNode(child);

                if (lNode.HasChildNodes)
                {
                    if (lNode.ChildNodes.Count == nCnt)
                    {
                        // Each node child is a Frame
                        for (i = 0; i < nCnt; i++)
                        {
                            // Init the index
                            nIdx = -1;

                            cNode = lNode.ChildNodes[i].FirstChild;
                            // Read text from Node "Frame"
                            S = cNode.InnerText;
                            sSubStr = S.Split(new char[] { ',' });
                            // Get the index for the Frame.
                            // This is the index of the Frame Definition
                            // in the Global Frame Table which the
                            // Transmit Frame was defined based on.
                            if (sSubStr.GetLength(0) >= 1)
                                nIdx = Convert.ToInt32(sSubStr[0]);
                            
                            // Read text from Node "Data" in node "Frame"
                            cNode = lNode.ChildNodes[i].LastChild;
                            S = cNode.InnerText;
                            sSubStr = S.Split(new char[] { ',' });
                            nCnt2 = sSubStr.Length;
                            lbData = new byte[8];
                            if (nCnt2 > 0)
                            {
                                // Each sub strings are values of the Frame.
                                for (j = 0; j < nCnt2; j++)
                                {
                                    // The first one is the length of the Frame.
                                    if (j == 0)
                                        nLen = Convert.ToInt32(sSubStr[j]);
                                    // The rest are the data bytes of the Frame.
                                    else
                                        lbData[j - 1] = Convert.ToByte(sSubStr[j],16);
                                }
                            }
                            if(nIdx >= 0)
                            {
                                // Only if the index is valid
                                // add the a new Frame with readed values.
                                lCF = new CCustomFrame(m_pDefinition[nIdx], ECustomFrameKind.Transmit);
                                lCF.Data = lbData;
                                m_plCustomFrames.Add(lCF);
                            }
                        }
                        return true;
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Write the Data assigned with the elements in the CXmtFrameList into the XML writer document.
        /// </summary>
        /// <param name="ADoc">XML writer document to hold the data from the elements.</param>
        /// <returns></returns>
        internal bool WriteData(ref System.Xml.XmlWriter ADoc)
        {
            int i, nCnt, nIdx;
            int j, nLen;
            string S;

            if (ADoc != null)
            {
                ADoc.WriteStartElement("XMT-Frames");
                nCnt = m_plCustomFrames.Count;
                ADoc.WriteAttributeString("Entries", nCnt.ToString());
                // Each Frames from the Transmit List.
                for (i = 0; i < nCnt; i++)
                {
                    // Write the Frame[i]
                    ADoc.WriteStartElement("Frame");
                    // Get and write the index of Frame-ID.
                    nIdx = m_pDefinition.IndexOf(m_plCustomFrames[i].m_nID);
                    ADoc.WriteValue(nIdx);
                    ADoc.WriteStartElement("Data");
                    // Get and write the length of the Frame.
                    nLen = m_plCustomFrames[i].Length;
                    ADoc.WriteValue(nLen);
                    ADoc.WriteValue(",");
                    S = "";
                    // Each data bytes of the Frame.
                    for (j = 0; j < nLen; j++)
                    {
                        // Get the data byte j
                        S = String.Format("{0:X2}", m_plCustomFrames[i].Data[j]);
                        // Write the data byte j
                        ADoc.WriteValue(S);
                        if (j < nLen - 1)
                            ADoc.WriteValue(",");
                    }
                    ADoc.WriteEndElement();
                    ADoc.WriteEndElement();
                }
                ADoc.WriteEndElement();
                return true;
            }
            return false;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Gets a CCustomFrame object from the CXmtFrameList.
        /// </summary>
        internal CCustomFrameList Item
        {
            get { return this; }
        }
        #endregion
    }
    #endregion

    #region Enums

    /// <summary>
    /// Respresents the enumerate values of LIN-frame direction.
    /// </summary>
    internal enum EDirection
    {
        /// <summary>
        /// Direction disabled
        /// </summary>
        Disabled = 0,
        /// <summary>
        /// Direction is publisher
        /// </summary>
        Publisher = 1,
        /// <summary>
        /// Direction is subscriber
        /// </summary>
        Subscriber = 2,
        /// <summary>
        /// Direction is subscriber ( detect Length)
        /// </summary>
        SubscriberAutoLength = 3,
    }

    /// <summary>
    /// Represents the enumerate values of LIN-frame type of checksum.
    /// </summary>
    internal enum EChecksumType
    {
        /// <summary>
        /// Classic checksum
        /// </summary>
        Classic = 1,
        /// <summary>
        /// Enhanced checksum
        /// </summary>
        Enhanced = 2,
        /// <summary>
        /// Automatic checksum
        /// </summary>
        Auto = 3,
    }

    /// <summary>
    /// Represents the enumerate values of the property kind from the
    /// CFrameDefinition object.
    /// </summary>
    internal enum EProperty
    {
        /// <summary>
        /// Length property
        /// </summary>
        Length=0,
        /// <summary>
        /// Checksum type property
        /// </summary>
        ChecksumType=1,
        /// <summary>
        /// Direction property
        /// </summary>
        Direction=2,
    }

    /// <summary>
    /// Represents the enumerate value of the kind of CCustomFrame object.
    /// </summary>
    internal enum ECustomFrameKind
    {
        /// <summary>
        /// CCustomFrame object is defined as transmit or published data frame.
        /// </summary>
        Transmit=0,
        /// <summary>
        /// CCustomFrame object is defined by receiving a LIN frame.
        /// </summary>
        Receive=1,
    }

    #endregion
}
