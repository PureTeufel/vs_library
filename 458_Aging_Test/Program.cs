//********************************************************************
// PLin-View
// 
// LIN-Monitor sample application
//
// This sample application demonstrate how to use the PLIN-API.
//
// The sample includes following source code files:
// - Main_Wnd.cs: Implements the main window of the graphic user
//                interface (GUI).
//
// - LIN_Impl.cs: Implements the interface classes between the
//                PLIN-API and the GUI.
//                Following classes are defined:
//                => CFrameDefinition
//                   The definition of the basic LIN-frame used
//                   in the CGlobalFrameTable class.
//                => CCustomFrame
//                   The advanced definition of the LIN-frame
//                   derived from CFrameDefinition used in
//                   CRcvFrameList or CXmtFrameList.
//                => CCustomFrameList
//                   Implements the basic collection class to
//                   manage all transmit or receive objects
//                   (CCustomFrame) and provides the basic
//                   functionality.
//                => CRcvFrameList
//                   Implements the collection class to manage
//                   all received LIN-frames (CCustomFrame) derived
//                   from CCustomFrameList.
//                => CXmtFrameList
//                   Implements the collection class to manage
//                   all transmission or puplish LIN-frames
//                   (CCustomFrame) derived from CCustomFrameList.
//                => CGlobalFrameTable
//                   Implements a global collection class to manage
//                   all possible LIN-frame definition.
//                   
// - Connect_Dlg.cs: Implements a dialog window to connect with
//                   a LIN-hardware.
//
// - Frame_Dlg.cs: Implements the dialog window to add or edit
//                 LIN-frames.
//
// - About_Dlg.cs: Implements the dialog window to show some
//                 information about the application.
//
// Copyright (C) 2009 PEAK-System Technik GmbH.  All rights reserved.
//********************************************************************

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PLinView
{
    static class Program
    {
        internal static MainWnd m_pMainW;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m_pMainW = new MainWnd();
            Application.Run(m_pMainW);
        }
    }
}
