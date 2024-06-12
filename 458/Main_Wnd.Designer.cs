namespace PLinView
{
    partial class MainWnd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWnd));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.SB_LIN_Connect = new System.Windows.Forms.ToolStripStatusLabel();
            this.SB_LIN_Channel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SB_LIN_Mode = new System.Windows.Forms.ToolStripStatusLabel();
            this.SB_LIN_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.SB_LIN_Overruns = new System.Windows.Forms.ToolStripStatusLabel();
            this.TransmitPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PM_Transmit_New = new System.Windows.Forms.ToolStripMenuItem();
            this.PM_Transmit_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.PM_Transmit_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.PM_Transmit_ClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceivePopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PM_Tools_SelfReceive = new System.Windows.Forms.ToolStripMenuItem();
            this.PM_Receive_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.TB_File_New = new System.Windows.Forms.ToolStripButton();
            this.TB_File_Open = new System.Windows.Forms.ToolStripButton();
            this.TB_File_Save = new System.Windows.Forms.ToolStripButton();
            this.TB_File_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TB_LIN_Connect = new System.Windows.Forms.ToolStripButton();
            this.TB_LIN_Reset = new System.Windows.Forms.ToolStripButton();
            this.TB_Transmit_AddNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TB_Help_Contents = new System.Windows.Forms.ToolStripButton();
            this.TB_Help_About = new System.Windows.Forms.ToolStripButton();
            this.StandardBar = new System.Windows.Forms.ToolStrip();
            this.Can_connect = new System.Windows.Forms.ToolStripButton();
            this.MM_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MM_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MM_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_LIN = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_LIN_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_LIN_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_LIN_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MM_LIN_GoToSleep = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_LIN_WakeUp = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Transmit = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Transmit_New = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Transmit_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Transmit_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Transmit_ClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Transmit_Send = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Tools_ResetGFT = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Help_Contents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Row1L_Heat_Req = new System.Windows.Forms.TextBox();
            this.Row1L_Vent_Req = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.L_CushCloseSeltn = new System.Windows.Forms.CheckBox();
            this.L_CushOpenSeltn = new System.Windows.Forms.CheckBox();
            this.L_ReclineRrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_ReclineFrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_CushRrDwnCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_CushRrUpCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_CushFrtDwnCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_CushFrtUpCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_SeatRrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_SeatFrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Row1R_Heat_Req = new System.Windows.Forms.TextBox();
            this.Row1R_Vent_Req = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.R_CushCloseSeltn = new System.Windows.Forms.CheckBox();
            this.R_CushOpenSeltn = new System.Windows.Forms.CheckBox();
            this.R_ReclineRrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.R_ReclineFrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.R_SeatRrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.R_SeatFrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SecRwLtStHtDtyCycl = new System.Windows.Forms.TextBox();
            this.SecRwLtStVntDtyCycl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SPS_2L_SecRwStZgvyDownSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStZgvyUpSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStLgextInSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStLgextOutSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStLgrstDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStLgrstUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStBkReclnDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStBkReclnUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStBkwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStFrwdSwActv = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SecRwRtStHtDtyCycl = new System.Windows.Forms.TextBox();
            this.SecRwRtStVntDtyCycl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SPS_2R_SecRwStZgvyDownSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStZgvyUpSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStLgextInSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStLgextOutSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStLgrstDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStLgrstUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStBkReclnDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStBkReclnUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStBkwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStFrwdSwActv = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3L_ThdRwStBkReclnUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3L_ThdRStBkwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3L_ThdRStFrwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3L_ThdRStExpdSwActv = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SPS_3R_ThdRRtStExpdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3R_ThdRwRtStBkwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3R_ThdRwRtStFrwdSwActv = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.Row1L_Heat_Vent_Status = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DrvStCshnFrntUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.DrvStBkReclnUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.DrvStFrwdBkwdPos = new System.Windows.Forms.TextBox();
            this.DrvStBkReclnUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.DrvStBkReclnUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.DrvStFrwdBkwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.DrvStFrwdBkwdPosV = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DrvStCshnRrUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.DrvStCshnRrUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.DrvStCshnRrUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.DrvStCshnFrntUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.Row1R_Heat_Vent_Status = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.PassStBkReclnUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.PassStFrwdBkwdPos = new System.Windows.Forms.TextBox();
            this.PassStBkReclnUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.PassStBkReclnUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.PassStFrwdBkwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.PassStFrwdBkwdPosV = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.SecRwRtStHtVntDtyCyclStat = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SecRwRtStLgExtOutInSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.SecRwRtStLgExtOutInPosV = new System.Windows.Forms.Label();
            this.SecRwRtStLgexInOutPos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SecRwRtStBkReclnUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.SecRwRtStFrwdBkwdPos = new System.Windows.Forms.TextBox();
            this.SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.SecRwRtStBkReclnUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SecRwRtStFrwdBkwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.SecRwRtStFrwdBkwdPosV = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.SecRwRtStCshnFrntUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.SecRwRtStCshnFrntUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.SecRwRtStLgrstUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.SecRwRtStLgrstUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.SecRwLtStHtVntDtyCyclStat = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.SecRwLtStLgExtOutInSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.SecRwLtStLgExtOutInPosV = new System.Windows.Forms.Label();
            this.SecRwLtStLgexInOutPos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SecRwLtStBkReclnUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.SecRwLtStFrwdBkwdPos = new System.Windows.Forms.TextBox();
            this.SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.SecRwLtStBkReclnUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SecRwLtStFrwdBkwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.SecRwLtStFrwdBkwdPosV = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.SecRwLtStCshnFrntUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.SecRwLtStCshnFrntUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.SecRwLtStLgrstUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.SecRwLtStLgrstUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.ThdRwRtStBkReclnUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.ThdRwRtStFrwdBkwdPos = new System.Windows.Forms.TextBox();
            this.ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.ThdRwRtStBkReclnUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.ThdRwRtStFrwdBkwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.ThdRwRtStFrwdBkwdPosV = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.ThdRwRtStCshnFldUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.ThdRwRtStCshnFldUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.ThdRwLtStBkReclnUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.ThdRwLtStFrwdBkwdPos = new System.Windows.Forms.TextBox();
            this.ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.ThdRwLtStBkReclnUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ThdRwLtStFrwdBkwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.ThdRwLtStFrwdBkwdPosV = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd = new System.Windows.Forms.Label();
            this.ThdRwLtStCshnFldUpwdDnwdPosV = new System.Windows.Forms.Label();
            this.ThdRwLtStCshnFldUpwdDnwdPos = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SecRwRtStChldLkLReq = new System.Windows.Forms.CheckBox();
            this.RcvyMdHMI2RRclReq = new System.Windows.Forms.CheckBox();
            this.AcsMdExtMdHMI2RRclReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStMassStrsHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStMassMdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStLmbrHMI2RReq = new System.Windows.Forms.CheckBox();
            this.BosSWStBkReclnDnwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.BosSWStBkReclnUpwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.BosSWBkwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.BosSWFrwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStFtDnwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStFtUpwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.VIPMdHMI2RRclReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStArmScrnHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStMemHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStHdrstDnwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStHdrstUpwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStRtwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStLtwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStLgrstDnwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStLgrstUpwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStBkReclnDnwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStBkReclnUpwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStBkwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwRtStFrwdHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStChldLkLReq = new System.Windows.Forms.CheckBox();
            this.RcvyMdHMI2LRclReq = new System.Windows.Forms.CheckBox();
            this.AcsMdExtMdHMI2LRclReq = new System.Windows.Forms.CheckBox();
            this.VIPMdHMI2LRclReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStArmScrnHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStFtDnwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStFtUpwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStMassStrsHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStMassMdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStLmbrHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStMemHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStHdrstDnwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStHdrstUpwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStRtwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStLtwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStLgrstDnwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStLgrstUpwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStBkReclnDnwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStBkReclnUpwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStBkwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SecRwLtStFrwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cycle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.StatusBar.SuspendLayout();
            this.TransmitPopup.SuspendLayout();
            this.ReceivePopup.SuspendLayout();
            this.StandardBar.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SB_LIN_Connect,
            this.SB_LIN_Channel,
            this.SB_LIN_Mode,
            this.SB_LIN_Status,
            this.SB_LIN_Overruns});
            this.StatusBar.Location = new System.Drawing.Point(0, 727);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1369, 22);
            this.StatusBar.TabIndex = 6;
            this.StatusBar.Text = "statusStrip1";
            // 
            // SB_LIN_Connect
            // 
            this.SB_LIN_Connect.BackColor = System.Drawing.SystemColors.Control;
            this.SB_LIN_Connect.ForeColor = System.Drawing.Color.Red;
            this.SB_LIN_Connect.Name = "SB_LIN_Connect";
            this.SB_LIN_Connect.Size = new System.Drawing.Size(94, 17);
            this.SB_LIN_Connect.Text = "Not connected";
            this.SB_LIN_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SB_LIN_Connect.DoubleClick += new System.EventHandler(this.LIN_Connect);
            // 
            // SB_LIN_Channel
            // 
            this.SB_LIN_Channel.ForeColor = System.Drawing.Color.Red;
            this.SB_LIN_Channel.Name = "SB_LIN_Channel";
            this.SB_LIN_Channel.Size = new System.Drawing.Size(0, 17);
            // 
            // SB_LIN_Mode
            // 
            this.SB_LIN_Mode.ForeColor = System.Drawing.Color.Red;
            this.SB_LIN_Mode.Name = "SB_LIN_Mode";
            this.SB_LIN_Mode.Size = new System.Drawing.Size(0, 17);
            // 
            // SB_LIN_Status
            // 
            this.SB_LIN_Status.ForeColor = System.Drawing.Color.Red;
            this.SB_LIN_Status.Name = "SB_LIN_Status";
            this.SB_LIN_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // SB_LIN_Overruns
            // 
            this.SB_LIN_Overruns.Name = "SB_LIN_Overruns";
            this.SB_LIN_Overruns.Size = new System.Drawing.Size(0, 17);
            // 
            // TransmitPopup
            // 
            this.TransmitPopup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TransmitPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PM_Transmit_New,
            this.PM_Transmit_Edit,
            this.PM_Transmit_Delete,
            this.PM_Transmit_ClearAll});
            this.TransmitPopup.Name = "XmtPopup";
            this.TransmitPopup.Size = new System.Drawing.Size(207, 108);
            // 
            // PM_Transmit_New
            // 
            this.PM_Transmit_New.Image = global::PLinView.Properties.Resources.FrameNew;
            this.PM_Transmit_New.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.PM_Transmit_New.Name = "PM_Transmit_New";
            this.PM_Transmit_New.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.PM_Transmit_New.Size = new System.Drawing.Size(206, 26);
            this.PM_Transmit_New.Text = "&New...";
            this.PM_Transmit_New.Click += new System.EventHandler(this.Transmit_AddNew);
            // 
            // PM_Transmit_Edit
            // 
            this.PM_Transmit_Edit.Enabled = false;
            this.PM_Transmit_Edit.Name = "PM_Transmit_Edit";
            this.PM_Transmit_Edit.Size = new System.Drawing.Size(206, 26);
            this.PM_Transmit_Edit.Text = "&Edit...";
            // 
            // PM_Transmit_Delete
            // 
            this.PM_Transmit_Delete.Enabled = false;
            this.PM_Transmit_Delete.Name = "PM_Transmit_Delete";
            this.PM_Transmit_Delete.ShortcutKeyDisplayString = "";
            this.PM_Transmit_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.PM_Transmit_Delete.Size = new System.Drawing.Size(206, 26);
            this.PM_Transmit_Delete.Text = "&Delete";
            // 
            // PM_Transmit_ClearAll
            // 
            this.PM_Transmit_ClearAll.Name = "PM_Transmit_ClearAll";
            this.PM_Transmit_ClearAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.PM_Transmit_ClearAll.Size = new System.Drawing.Size(206, 26);
            this.PM_Transmit_ClearAll.Text = "&Clear all";
            // 
            // ReceivePopup
            // 
            this.ReceivePopup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ReceivePopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PM_Tools_SelfReceive,
            this.PM_Receive_Delete});
            this.ReceivePopup.Name = "ReceivePopup";
            this.ReceivePopup.Size = new System.Drawing.Size(159, 48);
            // 
            // PM_Tools_SelfReceive
            // 
            this.PM_Tools_SelfReceive.Checked = true;
            this.PM_Tools_SelfReceive.CheckOnClick = true;
            this.PM_Tools_SelfReceive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PM_Tools_SelfReceive.Name = "PM_Tools_SelfReceive";
            this.PM_Tools_SelfReceive.Size = new System.Drawing.Size(158, 22);
            this.PM_Tools_SelfReceive.Text = "Self Receive";
            this.PM_Tools_SelfReceive.Click += new System.EventHandler(this.Tools_SelfReceive);
            // 
            // PM_Receive_Delete
            // 
            this.PM_Receive_Delete.Name = "PM_Receive_Delete";
            this.PM_Receive_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.PM_Receive_Delete.Size = new System.Drawing.Size(158, 22);
            this.PM_Receive_Delete.Text = "&Delete";
            this.PM_Receive_Delete.Click += new System.EventHandler(this.Receive_Delete);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 500;
            this.MainTimer.Tick += new System.EventHandler(this.OnMainTimerTick);
            // 
            // TB_File_New
            // 
            this.TB_File_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_File_New.Image = ((System.Drawing.Image)(resources.GetObject("TB_File_New.Image")));
            this.TB_File_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_File_New.Name = "TB_File_New";
            this.TB_File_New.Size = new System.Drawing.Size(24, 24);
            this.TB_File_New.Text = "New";
            this.TB_File_New.Click += new System.EventHandler(this.File_New);
            // 
            // TB_File_Open
            // 
            this.TB_File_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_File_Open.Image = ((System.Drawing.Image)(resources.GetObject("TB_File_Open.Image")));
            this.TB_File_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_File_Open.Name = "TB_File_Open";
            this.TB_File_Open.Size = new System.Drawing.Size(24, 24);
            this.TB_File_Open.Text = "Open";
            // 
            // TB_File_Save
            // 
            this.TB_File_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_File_Save.Image = global::PLinView.Properties.Resources.FileSave;
            this.TB_File_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_File_Save.Name = "TB_File_Save";
            this.TB_File_Save.Size = new System.Drawing.Size(24, 24);
            this.TB_File_Save.Text = "Save";
            this.TB_File_Save.Click += new System.EventHandler(this.File_Save);
            // 
            // TB_File_Exit
            // 
            this.TB_File_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_File_Exit.Image = ((System.Drawing.Image)(resources.GetObject("TB_File_Exit.Image")));
            this.TB_File_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_File_Exit.Name = "TB_File_Exit";
            this.TB_File_Exit.Size = new System.Drawing.Size(24, 24);
            this.TB_File_Exit.Text = "Exit";
            this.TB_File_Exit.Click += new System.EventHandler(this.File_Exit);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // TB_LIN_Connect
            // 
            this.TB_LIN_Connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_LIN_Connect.Image = ((System.Drawing.Image)(resources.GetObject("TB_LIN_Connect.Image")));
            this.TB_LIN_Connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_LIN_Connect.Name = "TB_LIN_Connect";
            this.TB_LIN_Connect.Size = new System.Drawing.Size(24, 24);
            this.TB_LIN_Connect.Text = "Connect";
            this.TB_LIN_Connect.Click += new System.EventHandler(this.LIN_Connect);
            // 
            // TB_LIN_Reset
            // 
            this.TB_LIN_Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_LIN_Reset.Image = ((System.Drawing.Image)(resources.GetObject("TB_LIN_Reset.Image")));
            this.TB_LIN_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_LIN_Reset.Name = "TB_LIN_Reset";
            this.TB_LIN_Reset.Size = new System.Drawing.Size(24, 24);
            this.TB_LIN_Reset.Text = "Reset";
            this.TB_LIN_Reset.Click += new System.EventHandler(this.LIN_Reset);
            // 
            // TB_Transmit_AddNew
            // 
            this.TB_Transmit_AddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_Transmit_AddNew.Image = ((System.Drawing.Image)(resources.GetObject("TB_Transmit_AddNew.Image")));
            this.TB_Transmit_AddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_Transmit_AddNew.Name = "TB_Transmit_AddNew";
            this.TB_Transmit_AddNew.Size = new System.Drawing.Size(24, 24);
            this.TB_Transmit_AddNew.Text = "New Frame";
            this.TB_Transmit_AddNew.Click += new System.EventHandler(this.Transmit_AddNew);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // TB_Help_Contents
            // 
            this.TB_Help_Contents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_Help_Contents.Image = global::PLinView.Properties.Resources.HelpContents;
            this.TB_Help_Contents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_Help_Contents.Name = "TB_Help_Contents";
            this.TB_Help_Contents.Size = new System.Drawing.Size(24, 24);
            this.TB_Help_Contents.Text = "PLIN-View Help";
            // 
            // TB_Help_About
            // 
            this.TB_Help_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_Help_About.Image = global::PLinView.Properties.Resources.HelpAbout;
            this.TB_Help_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_Help_About.Name = "TB_Help_About";
            this.TB_Help_About.Size = new System.Drawing.Size(24, 24);
            this.TB_Help_About.Text = "About";
            this.TB_Help_About.Click += new System.EventHandler(this.Help_About);
            // 
            // StandardBar
            // 
            this.StandardBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StandardBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TB_File_New,
            this.TB_File_Open,
            this.TB_File_Save,
            this.TB_File_Exit,
            this.toolStripSeparator1,
            this.TB_LIN_Connect,
            this.Can_connect,
            this.TB_LIN_Reset,
            this.TB_Transmit_AddNew,
            this.toolStripSeparator2,
            this.TB_Help_Contents,
            this.TB_Help_About});
            this.StandardBar.Location = new System.Drawing.Point(0, 25);
            this.StandardBar.Name = "StandardBar";
            this.StandardBar.Size = new System.Drawing.Size(1369, 27);
            this.StandardBar.TabIndex = 9;
            this.StandardBar.Text = "toolStrip1";
            // 
            // Can_connect
            // 
            this.Can_connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Can_connect.Image = global::PLinView.Properties.Resources.Connect;
            this.Can_connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Can_connect.Name = "Can_connect";
            this.Can_connect.Size = new System.Drawing.Size(24, 24);
            this.Can_connect.Text = "Can_Connect";
            this.Can_connect.Click += new System.EventHandler(this.Can_connect_Click);
            // 
            // MM_File
            // 
            this.MM_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MM_File_New,
            this.toolStripMenuItem1,
            this.MM_File_Open,
            this.MM_File_Save,
            this.MM_File_SaveAs,
            this.toolStripMenuItem4,
            this.MM_File_Exit});
            this.MM_File.Name = "MM_File";
            this.MM_File.Size = new System.Drawing.Size(39, 21);
            this.MM_File.Text = "&File";
            // 
            // MM_File_New
            // 
            this.MM_File_New.Image = global::PLinView.Properties.Resources.FileNew;
            this.MM_File_New.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.MM_File_New.Name = "MM_File_New";
            this.MM_File_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MM_File_New.Size = new System.Drawing.Size(168, 26);
            this.MM_File_New.Text = "&New";
            this.MM_File_New.Click += new System.EventHandler(this.File_New);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // MM_File_Open
            // 
            this.MM_File_Open.Image = global::PLinView.Properties.Resources.FileOpen;
            this.MM_File_Open.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.MM_File_Open.Name = "MM_File_Open";
            this.MM_File_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MM_File_Open.Size = new System.Drawing.Size(168, 26);
            this.MM_File_Open.Text = "&Open...";
            // 
            // MM_File_Save
            // 
            this.MM_File_Save.Image = global::PLinView.Properties.Resources.FileSave;
            this.MM_File_Save.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.MM_File_Save.Name = "MM_File_Save";
            this.MM_File_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MM_File_Save.Size = new System.Drawing.Size(168, 26);
            this.MM_File_Save.Text = "&Save";
            this.MM_File_Save.Click += new System.EventHandler(this.File_Save);
            // 
            // MM_File_SaveAs
            // 
            this.MM_File_SaveAs.Image = global::PLinView.Properties.Resources.FileSaveAs;
            this.MM_File_SaveAs.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.MM_File_SaveAs.Name = "MM_File_SaveAs";
            this.MM_File_SaveAs.Size = new System.Drawing.Size(168, 26);
            this.MM_File_SaveAs.Text = "Save &As...";
            this.MM_File_SaveAs.Click += new System.EventHandler(this.File_SaveAs);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(165, 6);
            // 
            // MM_File_Exit
            // 
            this.MM_File_Exit.Image = global::PLinView.Properties.Resources.ApplicationExit;
            this.MM_File_Exit.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.MM_File_Exit.Name = "MM_File_Exit";
            this.MM_File_Exit.Size = new System.Drawing.Size(168, 26);
            this.MM_File_Exit.Text = "&Exit";
            this.MM_File_Exit.Click += new System.EventHandler(this.File_Exit);
            // 
            // MM_LIN
            // 
            this.MM_LIN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MM_LIN_Connect,
            this.MM_LIN_Disconnect,
            this.MM_LIN_Reset,
            this.toolStripMenuItem3,
            this.MM_LIN_GoToSleep,
            this.MM_LIN_WakeUp});
            this.MM_LIN.Name = "MM_LIN";
            this.MM_LIN.Size = new System.Drawing.Size(63, 21);
            this.MM_LIN.Text = "&Lin/Can";
            // 
            // MM_LIN_Connect
            // 
            this.MM_LIN_Connect.Image = global::PLinView.Properties.Resources.Connect;
            this.MM_LIN_Connect.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.MM_LIN_Connect.Name = "MM_LIN_Connect";
            this.MM_LIN_Connect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MM_LIN_Connect.Size = new System.Drawing.Size(181, 26);
            this.MM_LIN_Connect.Text = "&Connect...";
            this.MM_LIN_Connect.Click += new System.EventHandler(this.LIN_Connect);
            // 
            // MM_LIN_Disconnect
            // 
            this.MM_LIN_Disconnect.Name = "MM_LIN_Disconnect";
            this.MM_LIN_Disconnect.Size = new System.Drawing.Size(181, 26);
            this.MM_LIN_Disconnect.Text = "&Disconnect";
            this.MM_LIN_Disconnect.Click += new System.EventHandler(this.LIN_Disconnect);
            // 
            // MM_LIN_Reset
            // 
            this.MM_LIN_Reset.Image = global::PLinView.Properties.Resources.LINReset;
            this.MM_LIN_Reset.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.MM_LIN_Reset.Name = "MM_LIN_Reset";
            this.MM_LIN_Reset.Size = new System.Drawing.Size(181, 26);
            this.MM_LIN_Reset.Text = "&Reset";
            this.MM_LIN_Reset.Click += new System.EventHandler(this.LIN_Reset);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(178, 6);
            // 
            // MM_LIN_GoToSleep
            // 
            this.MM_LIN_GoToSleep.Name = "MM_LIN_GoToSleep";
            this.MM_LIN_GoToSleep.Size = new System.Drawing.Size(181, 26);
            this.MM_LIN_GoToSleep.Text = "&Got to Sleep";
            this.MM_LIN_GoToSleep.Click += new System.EventHandler(this.LIN_GoToSleep);
            // 
            // MM_LIN_WakeUp
            // 
            this.MM_LIN_WakeUp.Name = "MM_LIN_WakeUp";
            this.MM_LIN_WakeUp.Size = new System.Drawing.Size(181, 26);
            this.MM_LIN_WakeUp.Text = "&Wake Up";
            this.MM_LIN_WakeUp.Click += new System.EventHandler(this.LIN_WakeUp);
            // 
            // MM_Transmit
            // 
            this.MM_Transmit.BackColor = System.Drawing.SystemColors.Control;
            this.MM_Transmit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MM_Transmit_New,
            this.MM_Transmit_Edit,
            this.MM_Transmit_Delete,
            this.MM_Transmit_ClearAll,
            this.MM_Transmit_Send});
            this.MM_Transmit.Name = "MM_Transmit";
            this.MM_Transmit.Size = new System.Drawing.Size(70, 21);
            this.MM_Transmit.Text = "&Transmit";
            // 
            // MM_Transmit_New
            // 
            this.MM_Transmit_New.Image = global::PLinView.Properties.Resources.FrameNew;
            this.MM_Transmit_New.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.MM_Transmit_New.Name = "MM_Transmit_New";
            this.MM_Transmit_New.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.MM_Transmit_New.Size = new System.Drawing.Size(206, 26);
            this.MM_Transmit_New.Text = "&New...";
            this.MM_Transmit_New.Click += new System.EventHandler(this.Transmit_AddNew);
            // 
            // MM_Transmit_Edit
            // 
            this.MM_Transmit_Edit.Enabled = false;
            this.MM_Transmit_Edit.Name = "MM_Transmit_Edit";
            this.MM_Transmit_Edit.Size = new System.Drawing.Size(206, 26);
            this.MM_Transmit_Edit.Text = "&Edit...";
            // 
            // MM_Transmit_Delete
            // 
            this.MM_Transmit_Delete.Enabled = false;
            this.MM_Transmit_Delete.Name = "MM_Transmit_Delete";
            this.MM_Transmit_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.MM_Transmit_Delete.Size = new System.Drawing.Size(206, 26);
            this.MM_Transmit_Delete.Text = "&Delete";
            // 
            // MM_Transmit_ClearAll
            // 
            this.MM_Transmit_ClearAll.Name = "MM_Transmit_ClearAll";
            this.MM_Transmit_ClearAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.MM_Transmit_ClearAll.Size = new System.Drawing.Size(206, 26);
            this.MM_Transmit_ClearAll.Text = "&Clear all";
            // 
            // MM_Transmit_Send
            // 
            this.MM_Transmit_Send.Name = "MM_Transmit_Send";
            this.MM_Transmit_Send.ShortcutKeyDisplayString = "Space";
            this.MM_Transmit_Send.Size = new System.Drawing.Size(206, 26);
            this.MM_Transmit_Send.Text = "&Send";
            // 
            // MM_Tools
            // 
            this.MM_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MM_Tools_ResetGFT});
            this.MM_Tools.Name = "MM_Tools";
            this.MM_Tools.Size = new System.Drawing.Size(52, 21);
            this.MM_Tools.Text = "&Tools";
            // 
            // MM_Tools_ResetGFT
            // 
            this.MM_Tools_ResetGFT.Name = "MM_Tools_ResetGFT";
            this.MM_Tools_ResetGFT.Size = new System.Drawing.Size(134, 22);
            this.MM_Tools_ResetGFT.Text = "&Reset GFT";
            this.MM_Tools_ResetGFT.Click += new System.EventHandler(this.Tools_ResetGFT);
            // 
            // MM_Help
            // 
            this.MM_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MM_Help_Contents,
            this.toolStripMenuItem2,
            this.toolStripMenuItem5,
            this.MM_Help_About});
            this.MM_Help.Name = "MM_Help";
            this.MM_Help.Size = new System.Drawing.Size(47, 21);
            this.MM_Help.Text = "&Help";
            // 
            // MM_Help_Contents
            // 
            this.MM_Help_Contents.Image = global::PLinView.Properties.Resources.HelpContents;
            this.MM_Help_Contents.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.MM_Help_Contents.Name = "MM_Help_Contents";
            this.MM_Help_Contents.Size = new System.Drawing.Size(195, 26);
            this.MM_Help_Contents.Text = "PLIN-View Help";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(195, 26);
            this.toolStripMenuItem5.Text = "Author:Liaicang,IMS";
            // 
            // MM_Help_About
            // 
            this.MM_Help_About.Image = global::PLinView.Properties.Resources.HelpAbout;
            this.MM_Help_About.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.MM_Help_About.Name = "MM_Help_About";
            this.MM_Help_About.Size = new System.Drawing.Size(195, 26);
            this.MM_Help_About.Text = "&About...";
            this.MM_Help_About.Click += new System.EventHandler(this.Help_About);
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MM_File,
            this.MM_LIN,
            this.MM_Transmit,
            this.MM_Tools,
            this.MM_Help});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1369, 25);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Row1L_Heat_Req);
            this.groupBox1.Controls.Add(this.Row1L_Vent_Req);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.L_CushCloseSeltn);
            this.groupBox1.Controls.Add(this.L_CushOpenSeltn);
            this.groupBox1.Controls.Add(this.L_ReclineRrwdCustSeltn);
            this.groupBox1.Controls.Add(this.L_ReclineFrwdCustSeltn);
            this.groupBox1.Controls.Add(this.L_CushRrDwnCustSeltn);
            this.groupBox1.Controls.Add(this.L_CushRrUpCustSeltn);
            this.groupBox1.Controls.Add(this.L_CushFrtDwnCustSeltn);
            this.groupBox1.Controls.Add(this.L_CushFrtUpCustSeltn);
            this.groupBox1.Controls.Add(this.L_SeatRrwdCustSeltn);
            this.groupBox1.Controls.Add(this.L_SeatFrwdCustSeltn);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 291);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SPS_DR_Req_MSG-0x31";
            // 
            // Row1L_Heat_Req
            // 
            this.Row1L_Heat_Req.Location = new System.Drawing.Point(188, 25);
            this.Row1L_Heat_Req.Name = "Row1L_Heat_Req";
            this.Row1L_Heat_Req.Size = new System.Drawing.Size(100, 22);
            this.Row1L_Heat_Req.TabIndex = 40;
            this.Row1L_Heat_Req.TextChanged += new System.EventHandler(this.Row1L_Heat_Req_TextChanged);
            // 
            // Row1L_Vent_Req
            // 
            this.Row1L_Vent_Req.Location = new System.Drawing.Point(188, 56);
            this.Row1L_Vent_Req.Name = "Row1L_Vent_Req";
            this.Row1L_Vent_Req.Size = new System.Drawing.Size(100, 22);
            this.Row1L_Vent_Req.TabIndex = 39;
            this.Row1L_Vent_Req.TextChanged += new System.EventHandler(this.Row1L_Vent_Req_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(149, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "通风";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(149, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "加热";
            // 
            // L_CushCloseSeltn
            // 
            this.L_CushCloseSeltn.AutoSize = true;
            this.L_CushCloseSeltn.Location = new System.Drawing.Point(13, 238);
            this.L_CushCloseSeltn.Name = "L_CushCloseSeltn";
            this.L_CushCloseSeltn.Size = new System.Drawing.Size(78, 17);
            this.L_CushCloseSeltn.TabIndex = 12;
            this.L_CushCloseSeltn.Text = "坐垫收起";
            this.L_CushCloseSeltn.UseVisualStyleBackColor = true;
            this.L_CushCloseSeltn.CheckedChanged += new System.EventHandler(this.L_CushCloseSeltn_CheckedChanged);
            // 
            // L_CushOpenSeltn
            // 
            this.L_CushOpenSeltn.AutoSize = true;
            this.L_CushOpenSeltn.Location = new System.Drawing.Point(13, 214);
            this.L_CushOpenSeltn.Name = "L_CushOpenSeltn";
            this.L_CushOpenSeltn.Size = new System.Drawing.Size(78, 17);
            this.L_CushOpenSeltn.TabIndex = 11;
            this.L_CushOpenSeltn.Text = "坐垫展开";
            this.L_CushOpenSeltn.UseVisualStyleBackColor = true;
            this.L_CushOpenSeltn.CheckedChanged += new System.EventHandler(this.L_CushOpenSeltn_CheckedChanged);
            // 
            // L_ReclineRrwdCustSeltn
            // 
            this.L_ReclineRrwdCustSeltn.AutoSize = true;
            this.L_ReclineRrwdCustSeltn.Location = new System.Drawing.Point(13, 94);
            this.L_ReclineRrwdCustSeltn.Name = "L_ReclineRrwdCustSeltn";
            this.L_ReclineRrwdCustSeltn.Size = new System.Drawing.Size(78, 17);
            this.L_ReclineRrwdCustSeltn.TabIndex = 10;
            this.L_ReclineRrwdCustSeltn.Text = "靠背向后";
            this.L_ReclineRrwdCustSeltn.UseVisualStyleBackColor = true;
            this.L_ReclineRrwdCustSeltn.CheckedChanged += new System.EventHandler(this.L_ReclineRrwdCustSeltn_CheckedChanged);
            // 
            // L_ReclineFrwdCustSeltn
            // 
            this.L_ReclineFrwdCustSeltn.AutoSize = true;
            this.L_ReclineFrwdCustSeltn.Location = new System.Drawing.Point(13, 70);
            this.L_ReclineFrwdCustSeltn.Name = "L_ReclineFrwdCustSeltn";
            this.L_ReclineFrwdCustSeltn.Size = new System.Drawing.Size(78, 17);
            this.L_ReclineFrwdCustSeltn.TabIndex = 9;
            this.L_ReclineFrwdCustSeltn.Text = "靠背向前";
            this.L_ReclineFrwdCustSeltn.UseVisualStyleBackColor = true;
            this.L_ReclineFrwdCustSeltn.CheckedChanged += new System.EventHandler(this.L_ReclineFrwdCustSeltn_CheckedChanged);
            // 
            // L_CushRrDwnCustSeltn
            // 
            this.L_CushRrDwnCustSeltn.AutoSize = true;
            this.L_CushRrDwnCustSeltn.Location = new System.Drawing.Point(13, 190);
            this.L_CushRrDwnCustSeltn.Name = "L_CushRrDwnCustSeltn";
            this.L_CushRrDwnCustSeltn.Size = new System.Drawing.Size(91, 17);
            this.L_CushRrDwnCustSeltn.TabIndex = 6;
            this.L_CushRrDwnCustSeltn.Text = "后提升向下";
            this.L_CushRrDwnCustSeltn.UseVisualStyleBackColor = true;
            this.L_CushRrDwnCustSeltn.CheckedChanged += new System.EventHandler(this.L_CushRrDwnCustSeltn_CheckedChanged);
            // 
            // L_CushRrUpCustSeltn
            // 
            this.L_CushRrUpCustSeltn.AutoSize = true;
            this.L_CushRrUpCustSeltn.Location = new System.Drawing.Point(13, 166);
            this.L_CushRrUpCustSeltn.Name = "L_CushRrUpCustSeltn";
            this.L_CushRrUpCustSeltn.Size = new System.Drawing.Size(91, 17);
            this.L_CushRrUpCustSeltn.TabIndex = 5;
            this.L_CushRrUpCustSeltn.Text = "后提升向上";
            this.L_CushRrUpCustSeltn.UseVisualStyleBackColor = true;
            this.L_CushRrUpCustSeltn.CheckedChanged += new System.EventHandler(this.L_CushRrUpCustSeltn_CheckedChanged);
            // 
            // L_CushFrtDwnCustSeltn
            // 
            this.L_CushFrtDwnCustSeltn.AutoSize = true;
            this.L_CushFrtDwnCustSeltn.Location = new System.Drawing.Point(13, 142);
            this.L_CushFrtDwnCustSeltn.Name = "L_CushFrtDwnCustSeltn";
            this.L_CushFrtDwnCustSeltn.Size = new System.Drawing.Size(91, 17);
            this.L_CushFrtDwnCustSeltn.TabIndex = 3;
            this.L_CushFrtDwnCustSeltn.Text = "前提升向下";
            this.L_CushFrtDwnCustSeltn.UseVisualStyleBackColor = true;
            this.L_CushFrtDwnCustSeltn.CheckedChanged += new System.EventHandler(this.L_CushFrtDwnCustSeltn_CheckedChanged);
            // 
            // L_CushFrtUpCustSeltn
            // 
            this.L_CushFrtUpCustSeltn.AutoSize = true;
            this.L_CushFrtUpCustSeltn.Location = new System.Drawing.Point(13, 118);
            this.L_CushFrtUpCustSeltn.Name = "L_CushFrtUpCustSeltn";
            this.L_CushFrtUpCustSeltn.Size = new System.Drawing.Size(91, 17);
            this.L_CushFrtUpCustSeltn.TabIndex = 2;
            this.L_CushFrtUpCustSeltn.Text = "前提升向上";
            this.L_CushFrtUpCustSeltn.UseVisualStyleBackColor = true;
            this.L_CushFrtUpCustSeltn.CheckedChanged += new System.EventHandler(this.L_CushFrtUpCustSeltn_CheckedChanged);
            // 
            // L_SeatRrwdCustSeltn
            // 
            this.L_SeatRrwdCustSeltn.AutoSize = true;
            this.L_SeatRrwdCustSeltn.Location = new System.Drawing.Point(13, 46);
            this.L_SeatRrwdCustSeltn.Name = "L_SeatRrwdCustSeltn";
            this.L_SeatRrwdCustSeltn.Size = new System.Drawing.Size(78, 17);
            this.L_SeatRrwdCustSeltn.TabIndex = 1;
            this.L_SeatRrwdCustSeltn.Text = "水平向后";
            this.L_SeatRrwdCustSeltn.UseVisualStyleBackColor = true;
            this.L_SeatRrwdCustSeltn.CheckedChanged += new System.EventHandler(this.L_SeatRrwdCustSeltn_CheckedChanged);
            // 
            // L_SeatFrwdCustSeltn
            // 
            this.L_SeatFrwdCustSeltn.AutoSize = true;
            this.L_SeatFrwdCustSeltn.Location = new System.Drawing.Point(13, 22);
            this.L_SeatFrwdCustSeltn.Name = "L_SeatFrwdCustSeltn";
            this.L_SeatFrwdCustSeltn.Size = new System.Drawing.Size(78, 17);
            this.L_SeatFrwdCustSeltn.TabIndex = 0;
            this.L_SeatFrwdCustSeltn.Text = "水平向前";
            this.L_SeatFrwdCustSeltn.UseVisualStyleBackColor = true;
            this.L_SeatFrwdCustSeltn.CheckedChanged += new System.EventHandler(this.L_SeatFrwdCustSeltn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Row1R_Heat_Req);
            this.groupBox2.Controls.Add(this.Row1R_Vent_Req);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.R_CushCloseSeltn);
            this.groupBox2.Controls.Add(this.R_CushOpenSeltn);
            this.groupBox2.Controls.Add(this.R_ReclineRrwdCustSeltn);
            this.groupBox2.Controls.Add(this.R_ReclineFrwdCustSeltn);
            this.groupBox2.Controls.Add(this.R_SeatRrwdCustSeltn);
            this.groupBox2.Controls.Add(this.R_SeatFrwdCustSeltn);
            this.groupBox2.Location = new System.Drawing.Point(3, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 287);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SPS_CODR_Req_MSG-0x17";
            // 
            // Row1R_Heat_Req
            // 
            this.Row1R_Heat_Req.Location = new System.Drawing.Point(191, 26);
            this.Row1R_Heat_Req.Name = "Row1R_Heat_Req";
            this.Row1R_Heat_Req.Size = new System.Drawing.Size(100, 22);
            this.Row1R_Heat_Req.TabIndex = 40;
            this.Row1R_Heat_Req.TextChanged += new System.EventHandler(this.Row1R_Heat_Req_TextChanged);
            // 
            // Row1R_Vent_Req
            // 
            this.Row1R_Vent_Req.Location = new System.Drawing.Point(191, 57);
            this.Row1R_Vent_Req.Name = "Row1R_Vent_Req";
            this.Row1R_Vent_Req.Size = new System.Drawing.Size(100, 22);
            this.Row1R_Vent_Req.TabIndex = 39;
            this.Row1R_Vent_Req.TextChanged += new System.EventHandler(this.Row1R_Vent_Req_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(152, 61);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "通风";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(152, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 13);
            this.label26.TabIndex = 37;
            this.label26.Text = "加热";
            // 
            // R_CushCloseSeltn
            // 
            this.R_CushCloseSeltn.AutoSize = true;
            this.R_CushCloseSeltn.Location = new System.Drawing.Point(16, 132);
            this.R_CushCloseSeltn.Name = "R_CushCloseSeltn";
            this.R_CushCloseSeltn.Size = new System.Drawing.Size(78, 17);
            this.R_CushCloseSeltn.TabIndex = 12;
            this.R_CushCloseSeltn.Text = "坐垫收起";
            this.R_CushCloseSeltn.UseVisualStyleBackColor = true;
            this.R_CushCloseSeltn.CheckedChanged += new System.EventHandler(this.R_CushCloseSeltn_CheckedChanged);
            // 
            // R_CushOpenSeltn
            // 
            this.R_CushOpenSeltn.AutoSize = true;
            this.R_CushOpenSeltn.Location = new System.Drawing.Point(16, 110);
            this.R_CushOpenSeltn.Name = "R_CushOpenSeltn";
            this.R_CushOpenSeltn.Size = new System.Drawing.Size(78, 17);
            this.R_CushOpenSeltn.TabIndex = 11;
            this.R_CushOpenSeltn.Text = "坐垫展开";
            this.R_CushOpenSeltn.UseVisualStyleBackColor = true;
            this.R_CushOpenSeltn.CheckedChanged += new System.EventHandler(this.R_CushOpenSeltn_CheckedChanged);
            // 
            // R_ReclineRrwdCustSeltn
            // 
            this.R_ReclineRrwdCustSeltn.AutoSize = true;
            this.R_ReclineRrwdCustSeltn.Location = new System.Drawing.Point(16, 88);
            this.R_ReclineRrwdCustSeltn.Name = "R_ReclineRrwdCustSeltn";
            this.R_ReclineRrwdCustSeltn.Size = new System.Drawing.Size(78, 17);
            this.R_ReclineRrwdCustSeltn.TabIndex = 10;
            this.R_ReclineRrwdCustSeltn.Text = "靠背向后";
            this.R_ReclineRrwdCustSeltn.UseVisualStyleBackColor = true;
            this.R_ReclineRrwdCustSeltn.CheckedChanged += new System.EventHandler(this.R_ReclineRrwdCustSeltn_CheckedChanged);
            // 
            // R_ReclineFrwdCustSeltn
            // 
            this.R_ReclineFrwdCustSeltn.AutoSize = true;
            this.R_ReclineFrwdCustSeltn.Location = new System.Drawing.Point(16, 66);
            this.R_ReclineFrwdCustSeltn.Name = "R_ReclineFrwdCustSeltn";
            this.R_ReclineFrwdCustSeltn.Size = new System.Drawing.Size(78, 17);
            this.R_ReclineFrwdCustSeltn.TabIndex = 9;
            this.R_ReclineFrwdCustSeltn.Text = "靠背向前";
            this.R_ReclineFrwdCustSeltn.UseVisualStyleBackColor = true;
            this.R_ReclineFrwdCustSeltn.CheckedChanged += new System.EventHandler(this.R_ReclineFrwdCustSeltn_CheckedChanged);
            // 
            // R_SeatRrwdCustSeltn
            // 
            this.R_SeatRrwdCustSeltn.AutoSize = true;
            this.R_SeatRrwdCustSeltn.Location = new System.Drawing.Point(16, 44);
            this.R_SeatRrwdCustSeltn.Name = "R_SeatRrwdCustSeltn";
            this.R_SeatRrwdCustSeltn.Size = new System.Drawing.Size(78, 17);
            this.R_SeatRrwdCustSeltn.TabIndex = 1;
            this.R_SeatRrwdCustSeltn.Text = "水平向后";
            this.R_SeatRrwdCustSeltn.UseVisualStyleBackColor = true;
            this.R_SeatRrwdCustSeltn.CheckedChanged += new System.EventHandler(this.R_SeatRrwdCustSeltn_CheckedChanged);
            // 
            // R_SeatFrwdCustSeltn
            // 
            this.R_SeatFrwdCustSeltn.AutoSize = true;
            this.R_SeatFrwdCustSeltn.Location = new System.Drawing.Point(16, 22);
            this.R_SeatFrwdCustSeltn.Name = "R_SeatFrwdCustSeltn";
            this.R_SeatFrwdCustSeltn.Size = new System.Drawing.Size(78, 17);
            this.R_SeatFrwdCustSeltn.TabIndex = 0;
            this.R_SeatFrwdCustSeltn.Text = "水平向前";
            this.R_SeatFrwdCustSeltn.UseVisualStyleBackColor = true;
            this.R_SeatFrwdCustSeltn.CheckedChanged += new System.EventHandler(this.R_SeatFrwdCustSeltn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SecRwLtStHtDtyCycl);
            this.groupBox3.Controls.Add(this.SecRwLtStVntDtyCycl);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.SPS_2L_SecRwStZgvyDownSwActv);
            this.groupBox3.Controls.Add(this.SPS_2L_SecRwStZgvyUpSwActv);
            this.groupBox3.Controls.Add(this.SPS_2L_SecRwStLgextInSwActv);
            this.groupBox3.Controls.Add(this.SPS_2L_SecRwStLgextOutSwActv);
            this.groupBox3.Controls.Add(this.SPS_2L_SecRwStLgrstDnwdSwActv);
            this.groupBox3.Controls.Add(this.SPS_2L_SecRwStLgrstUpwdSwActv);
            this.groupBox3.Controls.Add(this.SPS_2L_SecRwStBkReclnDnwdSwActv);
            this.groupBox3.Controls.Add(this.SPS_2L_SecRwStBkReclnUpwdSwActv);
            this.groupBox3.Controls.Add(this.SPS_2L_SecRwStBkwdSwActv);
            this.groupBox3.Controls.Add(this.SPS_2L_SecRwStFrwdSwActv);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 562);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SPS_2L_Req_MSG-0x21";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // SecRwLtStHtDtyCycl
            // 
            this.SecRwLtStHtDtyCycl.Location = new System.Drawing.Point(52, 330);
            this.SecRwLtStHtDtyCycl.Name = "SecRwLtStHtDtyCycl";
            this.SecRwLtStHtDtyCycl.Size = new System.Drawing.Size(100, 22);
            this.SecRwLtStHtDtyCycl.TabIndex = 36;
            this.SecRwLtStHtDtyCycl.TextChanged += new System.EventHandler(this.SecRwLtStHtDtyCycl_TextChanged);
            // 
            // SecRwLtStVntDtyCycl
            // 
            this.SecRwLtStVntDtyCycl.Location = new System.Drawing.Point(52, 361);
            this.SecRwLtStVntDtyCycl.Name = "SecRwLtStVntDtyCycl";
            this.SecRwLtStVntDtyCycl.Size = new System.Drawing.Size(100, 22);
            this.SecRwLtStVntDtyCycl.TabIndex = 35;
            this.SecRwLtStVntDtyCycl.TextChanged += new System.EventHandler(this.SecRwLtStVntDtyCycl_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "通风";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "加热";
            // 
            // SPS_2L_SecRwStZgvyDownSwActv
            // 
            this.SPS_2L_SecRwStZgvyDownSwActv.AutoSize = true;
            this.SPS_2L_SecRwStZgvyDownSwActv.Location = new System.Drawing.Point(16, 259);
            this.SPS_2L_SecRwStZgvyDownSwActv.Name = "SPS_2L_SecRwStZgvyDownSwActv";
            this.SPS_2L_SecRwStZgvyDownSwActv.Size = new System.Drawing.Size(91, 17);
            this.SPS_2L_SecRwStZgvyDownSwActv.TabIndex = 22;
            this.SPS_2L_SecRwStZgvyDownSwActv.Text = "零重力向下";
            this.SPS_2L_SecRwStZgvyDownSwActv.UseVisualStyleBackColor = true;
            this.SPS_2L_SecRwStZgvyDownSwActv.CheckedChanged += new System.EventHandler(this.SPS_2L_SecRwStZgvyDownSwActv_CheckedChanged);
            // 
            // SPS_2L_SecRwStZgvyUpSwActv
            // 
            this.SPS_2L_SecRwStZgvyUpSwActv.AutoSize = true;
            this.SPS_2L_SecRwStZgvyUpSwActv.Location = new System.Drawing.Point(16, 233);
            this.SPS_2L_SecRwStZgvyUpSwActv.Name = "SPS_2L_SecRwStZgvyUpSwActv";
            this.SPS_2L_SecRwStZgvyUpSwActv.Size = new System.Drawing.Size(91, 17);
            this.SPS_2L_SecRwStZgvyUpSwActv.TabIndex = 21;
            this.SPS_2L_SecRwStZgvyUpSwActv.Text = "零重力向上";
            this.SPS_2L_SecRwStZgvyUpSwActv.UseVisualStyleBackColor = true;
            this.SPS_2L_SecRwStZgvyUpSwActv.CheckedChanged += new System.EventHandler(this.SPS_2L_SecRwStZgvyUpSwActv_CheckedChanged);
            // 
            // SPS_2L_SecRwStLgextInSwActv
            // 
            this.SPS_2L_SecRwStLgextInSwActv.AutoSize = true;
            this.SPS_2L_SecRwStLgextInSwActv.Location = new System.Drawing.Point(16, 205);
            this.SPS_2L_SecRwStLgextInSwActv.Name = "SPS_2L_SecRwStLgextInSwActv";
            this.SPS_2L_SecRwStLgextInSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2L_SecRwStLgextInSwActv.TabIndex = 20;
            this.SPS_2L_SecRwStLgextInSwActv.Text = "腿托收回";
            this.SPS_2L_SecRwStLgextInSwActv.UseVisualStyleBackColor = true;
            this.SPS_2L_SecRwStLgextInSwActv.CheckedChanged += new System.EventHandler(this.SPS_2L_SecRwStLgextInSwActv_CheckedChanged);
            // 
            // SPS_2L_SecRwStLgextOutSwActv
            // 
            this.SPS_2L_SecRwStLgextOutSwActv.AutoSize = true;
            this.SPS_2L_SecRwStLgextOutSwActv.Location = new System.Drawing.Point(16, 179);
            this.SPS_2L_SecRwStLgextOutSwActv.Name = "SPS_2L_SecRwStLgextOutSwActv";
            this.SPS_2L_SecRwStLgextOutSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2L_SecRwStLgextOutSwActv.TabIndex = 19;
            this.SPS_2L_SecRwStLgextOutSwActv.Text = "腿托伸出";
            this.SPS_2L_SecRwStLgextOutSwActv.UseVisualStyleBackColor = true;
            this.SPS_2L_SecRwStLgextOutSwActv.CheckedChanged += new System.EventHandler(this.SPS_2L_SecRwStLgextOutSwActv_CheckedChanged);
            // 
            // SPS_2L_SecRwStLgrstDnwdSwActv
            // 
            this.SPS_2L_SecRwStLgrstDnwdSwActv.AutoSize = true;
            this.SPS_2L_SecRwStLgrstDnwdSwActv.Location = new System.Drawing.Point(16, 155);
            this.SPS_2L_SecRwStLgrstDnwdSwActv.Name = "SPS_2L_SecRwStLgrstDnwdSwActv";
            this.SPS_2L_SecRwStLgrstDnwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2L_SecRwStLgrstDnwdSwActv.TabIndex = 5;
            this.SPS_2L_SecRwStLgrstDnwdSwActv.Text = "腿托向下";
            this.SPS_2L_SecRwStLgrstDnwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2L_SecRwStLgrstDnwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2L_SecRwStLgrstDnwdSwActv_CheckedChanged);
            // 
            // SPS_2L_SecRwStLgrstUpwdSwActv
            // 
            this.SPS_2L_SecRwStLgrstUpwdSwActv.AutoSize = true;
            this.SPS_2L_SecRwStLgrstUpwdSwActv.Location = new System.Drawing.Point(16, 129);
            this.SPS_2L_SecRwStLgrstUpwdSwActv.Name = "SPS_2L_SecRwStLgrstUpwdSwActv";
            this.SPS_2L_SecRwStLgrstUpwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2L_SecRwStLgrstUpwdSwActv.TabIndex = 4;
            this.SPS_2L_SecRwStLgrstUpwdSwActv.Text = "腿托向上";
            this.SPS_2L_SecRwStLgrstUpwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2L_SecRwStLgrstUpwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2L_SecRwStLgrstUpwdSwActv_CheckedChanged);
            // 
            // SPS_2L_SecRwStBkReclnDnwdSwActv
            // 
            this.SPS_2L_SecRwStBkReclnDnwdSwActv.AutoSize = true;
            this.SPS_2L_SecRwStBkReclnDnwdSwActv.Location = new System.Drawing.Point(16, 103);
            this.SPS_2L_SecRwStBkReclnDnwdSwActv.Name = "SPS_2L_SecRwStBkReclnDnwdSwActv";
            this.SPS_2L_SecRwStBkReclnDnwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2L_SecRwStBkReclnDnwdSwActv.TabIndex = 3;
            this.SPS_2L_SecRwStBkReclnDnwdSwActv.Text = "靠背向后";
            this.SPS_2L_SecRwStBkReclnDnwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2L_SecRwStBkReclnDnwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2L_SecRwStBkReclnDnwdSwActv_CheckedChanged);
            // 
            // SPS_2L_SecRwStBkReclnUpwdSwActv
            // 
            this.SPS_2L_SecRwStBkReclnUpwdSwActv.AutoSize = true;
            this.SPS_2L_SecRwStBkReclnUpwdSwActv.Location = new System.Drawing.Point(16, 77);
            this.SPS_2L_SecRwStBkReclnUpwdSwActv.Name = "SPS_2L_SecRwStBkReclnUpwdSwActv";
            this.SPS_2L_SecRwStBkReclnUpwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2L_SecRwStBkReclnUpwdSwActv.TabIndex = 2;
            this.SPS_2L_SecRwStBkReclnUpwdSwActv.Text = "靠背向前";
            this.SPS_2L_SecRwStBkReclnUpwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2L_SecRwStBkReclnUpwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2L_SecRwStBkReclnUpwdSwActv_CheckedChanged);
            // 
            // SPS_2L_SecRwStBkwdSwActv
            // 
            this.SPS_2L_SecRwStBkwdSwActv.AutoSize = true;
            this.SPS_2L_SecRwStBkwdSwActv.Location = new System.Drawing.Point(16, 51);
            this.SPS_2L_SecRwStBkwdSwActv.Name = "SPS_2L_SecRwStBkwdSwActv";
            this.SPS_2L_SecRwStBkwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2L_SecRwStBkwdSwActv.TabIndex = 1;
            this.SPS_2L_SecRwStBkwdSwActv.Text = "水平向后";
            this.SPS_2L_SecRwStBkwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2L_SecRwStBkwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2L_SecRwStBkwdSwActv_CheckedChanged);
            // 
            // SPS_2L_SecRwStFrwdSwActv
            // 
            this.SPS_2L_SecRwStFrwdSwActv.AutoSize = true;
            this.SPS_2L_SecRwStFrwdSwActv.Location = new System.Drawing.Point(16, 25);
            this.SPS_2L_SecRwStFrwdSwActv.Name = "SPS_2L_SecRwStFrwdSwActv";
            this.SPS_2L_SecRwStFrwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2L_SecRwStFrwdSwActv.TabIndex = 0;
            this.SPS_2L_SecRwStFrwdSwActv.Text = "水平向前";
            this.SPS_2L_SecRwStFrwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2L_SecRwStFrwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2L_SecRwStFrwdSwActv_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SecRwRtStHtDtyCycl);
            this.groupBox4.Controls.Add(this.SecRwRtStVntDtyCycl);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.SPS_2R_SecRwStZgvyDownSwActv);
            this.groupBox4.Controls.Add(this.SPS_2R_SecRwStZgvyUpSwActv);
            this.groupBox4.Controls.Add(this.SPS_2R_SecRwStLgextInSwActv);
            this.groupBox4.Controls.Add(this.SPS_2R_SecRwStLgextOutSwActv);
            this.groupBox4.Controls.Add(this.SPS_2R_SecRwStLgrstDnwdSwActv);
            this.groupBox4.Controls.Add(this.SPS_2R_SecRwStLgrstUpwdSwActv);
            this.groupBox4.Controls.Add(this.SPS_2R_SecRwStBkReclnDnwdSwActv);
            this.groupBox4.Controls.Add(this.SPS_2R_SecRwStBkReclnUpwdSwActv);
            this.groupBox4.Controls.Add(this.SPS_2R_SecRwStBkwdSwActv);
            this.groupBox4.Controls.Add(this.SPS_2R_SecRwStFrwdSwActv);
            this.groupBox4.Location = new System.Drawing.Point(247, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 562);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SPS_2R_Req_MSG-0x11";
            // 
            // SecRwRtStHtDtyCycl
            // 
            this.SecRwRtStHtDtyCycl.Location = new System.Drawing.Point(57, 334);
            this.SecRwRtStHtDtyCycl.Name = "SecRwRtStHtDtyCycl";
            this.SecRwRtStHtDtyCycl.Size = new System.Drawing.Size(100, 22);
            this.SecRwRtStHtDtyCycl.TabIndex = 40;
            this.SecRwRtStHtDtyCycl.TextChanged += new System.EventHandler(this.SecRwRtStHtDtyCycl_TextChanged);
            // 
            // SecRwRtStVntDtyCycl
            // 
            this.SecRwRtStVntDtyCycl.Location = new System.Drawing.Point(57, 365);
            this.SecRwRtStVntDtyCycl.Name = "SecRwRtStVntDtyCycl";
            this.SecRwRtStVntDtyCycl.Size = new System.Drawing.Size(100, 22);
            this.SecRwRtStVntDtyCycl.TabIndex = 39;
            this.SecRwRtStVntDtyCycl.TextChanged += new System.EventHandler(this.SecRwRtStVntDtyCycl_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "通风";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "加热";
            // 
            // SPS_2R_SecRwStZgvyDownSwActv
            // 
            this.SPS_2R_SecRwStZgvyDownSwActv.AutoSize = true;
            this.SPS_2R_SecRwStZgvyDownSwActv.Location = new System.Drawing.Point(6, 259);
            this.SPS_2R_SecRwStZgvyDownSwActv.Name = "SPS_2R_SecRwStZgvyDownSwActv";
            this.SPS_2R_SecRwStZgvyDownSwActv.Size = new System.Drawing.Size(91, 17);
            this.SPS_2R_SecRwStZgvyDownSwActv.TabIndex = 20;
            this.SPS_2R_SecRwStZgvyDownSwActv.Text = "零重力向下";
            this.SPS_2R_SecRwStZgvyDownSwActv.UseVisualStyleBackColor = true;
            this.SPS_2R_SecRwStZgvyDownSwActv.CheckedChanged += new System.EventHandler(this.SPS_2R_SecRwStZgvyDownSwActv_CheckedChanged);
            // 
            // SPS_2R_SecRwStZgvyUpSwActv
            // 
            this.SPS_2R_SecRwStZgvyUpSwActv.AutoSize = true;
            this.SPS_2R_SecRwStZgvyUpSwActv.Location = new System.Drawing.Point(6, 233);
            this.SPS_2R_SecRwStZgvyUpSwActv.Name = "SPS_2R_SecRwStZgvyUpSwActv";
            this.SPS_2R_SecRwStZgvyUpSwActv.Size = new System.Drawing.Size(91, 17);
            this.SPS_2R_SecRwStZgvyUpSwActv.TabIndex = 19;
            this.SPS_2R_SecRwStZgvyUpSwActv.Text = "零重力向上";
            this.SPS_2R_SecRwStZgvyUpSwActv.UseVisualStyleBackColor = true;
            this.SPS_2R_SecRwStZgvyUpSwActv.CheckedChanged += new System.EventHandler(this.SPS_2R_SecRwStZgvyUpSwActv_CheckedChanged);
            // 
            // SPS_2R_SecRwStLgextInSwActv
            // 
            this.SPS_2R_SecRwStLgextInSwActv.AutoSize = true;
            this.SPS_2R_SecRwStLgextInSwActv.Location = new System.Drawing.Point(6, 207);
            this.SPS_2R_SecRwStLgextInSwActv.Name = "SPS_2R_SecRwStLgextInSwActv";
            this.SPS_2R_SecRwStLgextInSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2R_SecRwStLgextInSwActv.TabIndex = 18;
            this.SPS_2R_SecRwStLgextInSwActv.Text = "腿托收回";
            this.SPS_2R_SecRwStLgextInSwActv.UseVisualStyleBackColor = true;
            this.SPS_2R_SecRwStLgextInSwActv.CheckedChanged += new System.EventHandler(this.SPS_2R_SecRwStLgextInSwActv_CheckedChanged);
            // 
            // SPS_2R_SecRwStLgextOutSwActv
            // 
            this.SPS_2R_SecRwStLgextOutSwActv.AutoSize = true;
            this.SPS_2R_SecRwStLgextOutSwActv.Location = new System.Drawing.Point(6, 181);
            this.SPS_2R_SecRwStLgextOutSwActv.Name = "SPS_2R_SecRwStLgextOutSwActv";
            this.SPS_2R_SecRwStLgextOutSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2R_SecRwStLgextOutSwActv.TabIndex = 17;
            this.SPS_2R_SecRwStLgextOutSwActv.Text = "腿托伸出";
            this.SPS_2R_SecRwStLgextOutSwActv.UseVisualStyleBackColor = true;
            this.SPS_2R_SecRwStLgextOutSwActv.CheckedChanged += new System.EventHandler(this.SPS_2R_SecRwStLgextOutSwActv_CheckedChanged);
            // 
            // SPS_2R_SecRwStLgrstDnwdSwActv
            // 
            this.SPS_2R_SecRwStLgrstDnwdSwActv.AutoSize = true;
            this.SPS_2R_SecRwStLgrstDnwdSwActv.Location = new System.Drawing.Point(6, 155);
            this.SPS_2R_SecRwStLgrstDnwdSwActv.Name = "SPS_2R_SecRwStLgrstDnwdSwActv";
            this.SPS_2R_SecRwStLgrstDnwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2R_SecRwStLgrstDnwdSwActv.TabIndex = 5;
            this.SPS_2R_SecRwStLgrstDnwdSwActv.Text = "腿托向下";
            this.SPS_2R_SecRwStLgrstDnwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2R_SecRwStLgrstDnwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2R_SecRwStLgrstDnwdSwActv_CheckedChanged);
            // 
            // SPS_2R_SecRwStLgrstUpwdSwActv
            // 
            this.SPS_2R_SecRwStLgrstUpwdSwActv.AutoSize = true;
            this.SPS_2R_SecRwStLgrstUpwdSwActv.Location = new System.Drawing.Point(6, 129);
            this.SPS_2R_SecRwStLgrstUpwdSwActv.Name = "SPS_2R_SecRwStLgrstUpwdSwActv";
            this.SPS_2R_SecRwStLgrstUpwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2R_SecRwStLgrstUpwdSwActv.TabIndex = 4;
            this.SPS_2R_SecRwStLgrstUpwdSwActv.Text = "腿托向上";
            this.SPS_2R_SecRwStLgrstUpwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2R_SecRwStLgrstUpwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2R_SecRwStLgrstUpwdSwActv_CheckedChanged);
            // 
            // SPS_2R_SecRwStBkReclnDnwdSwActv
            // 
            this.SPS_2R_SecRwStBkReclnDnwdSwActv.AutoSize = true;
            this.SPS_2R_SecRwStBkReclnDnwdSwActv.Location = new System.Drawing.Point(6, 103);
            this.SPS_2R_SecRwStBkReclnDnwdSwActv.Name = "SPS_2R_SecRwStBkReclnDnwdSwActv";
            this.SPS_2R_SecRwStBkReclnDnwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2R_SecRwStBkReclnDnwdSwActv.TabIndex = 3;
            this.SPS_2R_SecRwStBkReclnDnwdSwActv.Text = "靠背向后";
            this.SPS_2R_SecRwStBkReclnDnwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2R_SecRwStBkReclnDnwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2R_SecRwStBkReclnDnwdSwActv_CheckedChanged);
            // 
            // SPS_2R_SecRwStBkReclnUpwdSwActv
            // 
            this.SPS_2R_SecRwStBkReclnUpwdSwActv.AutoSize = true;
            this.SPS_2R_SecRwStBkReclnUpwdSwActv.Location = new System.Drawing.Point(6, 77);
            this.SPS_2R_SecRwStBkReclnUpwdSwActv.Name = "SPS_2R_SecRwStBkReclnUpwdSwActv";
            this.SPS_2R_SecRwStBkReclnUpwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2R_SecRwStBkReclnUpwdSwActv.TabIndex = 2;
            this.SPS_2R_SecRwStBkReclnUpwdSwActv.Text = "靠背向前";
            this.SPS_2R_SecRwStBkReclnUpwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2R_SecRwStBkReclnUpwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2R_SecRwStBkReclnUpwdSwActv_CheckedChanged);
            // 
            // SPS_2R_SecRwStBkwdSwActv
            // 
            this.SPS_2R_SecRwStBkwdSwActv.AutoSize = true;
            this.SPS_2R_SecRwStBkwdSwActv.Location = new System.Drawing.Point(6, 51);
            this.SPS_2R_SecRwStBkwdSwActv.Name = "SPS_2R_SecRwStBkwdSwActv";
            this.SPS_2R_SecRwStBkwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2R_SecRwStBkwdSwActv.TabIndex = 1;
            this.SPS_2R_SecRwStBkwdSwActv.Text = "水平向后";
            this.SPS_2R_SecRwStBkwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2R_SecRwStBkwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2R_SecRwStBkwdSwActv_CheckedChanged);
            // 
            // SPS_2R_SecRwStFrwdSwActv
            // 
            this.SPS_2R_SecRwStFrwdSwActv.AutoSize = true;
            this.SPS_2R_SecRwStFrwdSwActv.Location = new System.Drawing.Point(6, 25);
            this.SPS_2R_SecRwStFrwdSwActv.Name = "SPS_2R_SecRwStFrwdSwActv";
            this.SPS_2R_SecRwStFrwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2R_SecRwStFrwdSwActv.TabIndex = 0;
            this.SPS_2R_SecRwStFrwdSwActv.Text = "水平向前";
            this.SPS_2R_SecRwStFrwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2R_SecRwStFrwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2R_SecRwStFrwdSwActv_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SPS_3L_ThdRwStBkReclnDnwdSwActv);
            this.groupBox5.Controls.Add(this.SPS_3L_ThdRwStBkReclnUpwdSwActv);
            this.groupBox5.Controls.Add(this.SPS_3L_ThdRStBkwdSwActv);
            this.groupBox5.Controls.Add(this.SPS_3L_ThdRStFrwdSwActv);
            this.groupBox5.Controls.Add(this.SPS_3L_ThdRStExpdSwActv);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 258);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SPS_3L_Req_MSG-0x15";
            // 
            // SPS_3L_ThdRwStBkReclnDnwdSwActv
            // 
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv.AutoSize = true;
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv.Location = new System.Drawing.Point(14, 138);
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv.Name = "SPS_3L_ThdRwStBkReclnDnwdSwActv";
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv.TabIndex = 5;
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv.Text = "靠背向后";
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3L_ThdRwStBkReclnDnwdSwActv_CheckedChanged);
            // 
            // SPS_3L_ThdRwStBkReclnUpwdSwActv
            // 
            this.SPS_3L_ThdRwStBkReclnUpwdSwActv.AutoSize = true;
            this.SPS_3L_ThdRwStBkReclnUpwdSwActv.Location = new System.Drawing.Point(14, 99);
            this.SPS_3L_ThdRwStBkReclnUpwdSwActv.Name = "SPS_3L_ThdRwStBkReclnUpwdSwActv";
            this.SPS_3L_ThdRwStBkReclnUpwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_3L_ThdRwStBkReclnUpwdSwActv.TabIndex = 4;
            this.SPS_3L_ThdRwStBkReclnUpwdSwActv.Text = "靠背向前";
            this.SPS_3L_ThdRwStBkReclnUpwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3L_ThdRwStBkReclnUpwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3L_ThdRwStBkReclnUpwdSwActv_CheckedChanged);
            // 
            // SPS_3L_ThdRStBkwdSwActv
            // 
            this.SPS_3L_ThdRStBkwdSwActv.AutoSize = true;
            this.SPS_3L_ThdRStBkwdSwActv.Location = new System.Drawing.Point(14, 60);
            this.SPS_3L_ThdRStBkwdSwActv.Name = "SPS_3L_ThdRStBkwdSwActv";
            this.SPS_3L_ThdRStBkwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_3L_ThdRStBkwdSwActv.TabIndex = 3;
            this.SPS_3L_ThdRStBkwdSwActv.Text = "水平向后";
            this.SPS_3L_ThdRStBkwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3L_ThdRStBkwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3L_ThdRStBkwdSwActv_CheckedChanged);
            // 
            // SPS_3L_ThdRStFrwdSwActv
            // 
            this.SPS_3L_ThdRStFrwdSwActv.AutoSize = true;
            this.SPS_3L_ThdRStFrwdSwActv.Location = new System.Drawing.Point(14, 21);
            this.SPS_3L_ThdRStFrwdSwActv.Name = "SPS_3L_ThdRStFrwdSwActv";
            this.SPS_3L_ThdRStFrwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_3L_ThdRStFrwdSwActv.TabIndex = 2;
            this.SPS_3L_ThdRStFrwdSwActv.Text = "水平向前";
            this.SPS_3L_ThdRStFrwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3L_ThdRStFrwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3L_ThdRStFrwdSwActv_CheckedChanged);
            // 
            // SPS_3L_ThdRStExpdSwActv
            // 
            this.SPS_3L_ThdRStExpdSwActv.AutoSize = true;
            this.SPS_3L_ThdRStExpdSwActv.Location = new System.Drawing.Point(14, 177);
            this.SPS_3L_ThdRStExpdSwActv.Name = "SPS_3L_ThdRStExpdSwActv";
            this.SPS_3L_ThdRStExpdSwActv.Size = new System.Drawing.Size(73, 17);
            this.SPS_3L_ThdRStExpdSwActv.TabIndex = 1;
            this.SPS_3L_ThdRStExpdSwActv.Text = "OTF电机";
            this.SPS_3L_ThdRStExpdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3L_ThdRStExpdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3L_ThdRStExpdSwActv_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.SPS_3R_ThdRRtStExpdSwActv);
            this.groupBox6.Controls.Add(this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv);
            this.groupBox6.Controls.Add(this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv);
            this.groupBox6.Controls.Add(this.SPS_3R_ThdRwRtStBkwdSwActv);
            this.groupBox6.Controls.Add(this.SPS_3R_ThdRwRtStFrwdSwActv);
            this.groupBox6.Location = new System.Drawing.Point(6, 270);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(259, 258);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SPS_3R_Req_MSG-0x27";
            // 
            // SPS_3R_ThdRRtStExpdSwActv
            // 
            this.SPS_3R_ThdRRtStExpdSwActv.AutoSize = true;
            this.SPS_3R_ThdRRtStExpdSwActv.Location = new System.Drawing.Point(14, 182);
            this.SPS_3R_ThdRRtStExpdSwActv.Name = "SPS_3R_ThdRRtStExpdSwActv";
            this.SPS_3R_ThdRRtStExpdSwActv.Size = new System.Drawing.Size(73, 17);
            this.SPS_3R_ThdRRtStExpdSwActv.TabIndex = 7;
            this.SPS_3R_ThdRRtStExpdSwActv.Text = "OTF电机";
            this.SPS_3R_ThdRRtStExpdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3R_ThdRRtStExpdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3R_ThdRRtStExpdSwActv_CheckedChanged);
            // 
            // SPS_3R_ThdRwRtStBkReclnDnwdSwActv
            // 
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.AutoSize = true;
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.Location = new System.Drawing.Point(14, 142);
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.Name = "SPS_3R_ThdRwRtStBkReclnDnwdSwActv";
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.Size = new System.Drawing.Size(104, 17);
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.TabIndex = 6;
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.Text = "靠背电机向后";
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv_CheckedChanged);
            // 
            // SPS_3R_ThdRwRtStBkReclnUpwdSwActv
            // 
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.AutoSize = true;
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.Location = new System.Drawing.Point(14, 102);
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.Name = "SPS_3R_ThdRwRtStBkReclnUpwdSwActv";
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.Size = new System.Drawing.Size(104, 17);
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.TabIndex = 5;
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.Text = "靠背电机向前";
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv_CheckedChanged_1);
            // 
            // SPS_3R_ThdRwRtStBkwdSwActv
            // 
            this.SPS_3R_ThdRwRtStBkwdSwActv.AutoSize = true;
            this.SPS_3R_ThdRwRtStBkwdSwActv.Location = new System.Drawing.Point(14, 61);
            this.SPS_3R_ThdRwRtStBkwdSwActv.Name = "SPS_3R_ThdRwRtStBkwdSwActv";
            this.SPS_3R_ThdRwRtStBkwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_3R_ThdRwRtStBkwdSwActv.TabIndex = 3;
            this.SPS_3R_ThdRwRtStBkwdSwActv.Text = "水平向后";
            this.SPS_3R_ThdRwRtStBkwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3R_ThdRwRtStBkwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3R_ThdRwRtStBkwdSwActv_CheckedChanged);
            // 
            // SPS_3R_ThdRwRtStFrwdSwActv
            // 
            this.SPS_3R_ThdRwRtStFrwdSwActv.AutoSize = true;
            this.SPS_3R_ThdRwRtStFrwdSwActv.Location = new System.Drawing.Point(14, 21);
            this.SPS_3R_ThdRwRtStFrwdSwActv.Name = "SPS_3R_ThdRwRtStFrwdSwActv";
            this.SPS_3R_ThdRwRtStFrwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_3R_ThdRwRtStFrwdSwActv.TabIndex = 2;
            this.SPS_3R_ThdRwRtStFrwdSwActv.Text = "水平向前";
            this.SPS_3R_ThdRwRtStFrwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3R_ThdRwRtStFrwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3R_ThdRwRtStFrwdSwActv_CheckedChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox16);
            this.groupBox10.Controls.Add(this.DrvStCshnFrntUpwdDnwdPos);
            this.groupBox10.Controls.Add(this.DrvStBkReclnUpwdDnwdPos);
            this.groupBox10.Controls.Add(this.DrvStFrwdBkwdPos);
            this.groupBox10.Controls.Add(this.DrvStBkReclnUpwdDnwdSnsrHmPosLrnd);
            this.groupBox10.Controls.Add(this.DrvStBkReclnUpwdDnwdPosV);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.DrvStFrwdBkwdSnsrHmPosLrnd);
            this.groupBox10.Controls.Add(this.DrvStFrwdBkwdPosV);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.DrvStCshnRrUpwdDnwdPos);
            this.groupBox10.Controls.Add(this.DrvStCshnRrUpwdDnwdSnsrHmPosLrnd);
            this.groupBox10.Controls.Add(this.DrvStCshnRrUpwdDnwdPosV);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd);
            this.groupBox10.Controls.Add(this.DrvStCshnFrntUpwdDnwdPosV);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Location = new System.Drawing.Point(322, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(801, 291);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "DR";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.Row1L_Heat_Vent_Status);
            this.groupBox16.Controls.Add(this.label14);
            this.groupBox16.Location = new System.Drawing.Point(458, 21);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(296, 66);
            this.groupBox16.TabIndex = 36;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "通风加热";
            // 
            // Row1L_Heat_Vent_Status
            // 
            this.Row1L_Heat_Vent_Status.Enabled = false;
            this.Row1L_Heat_Vent_Status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row1L_Heat_Vent_Status.FormattingEnabled = true;
            this.Row1L_Heat_Vent_Status.Items.AddRange(new object[] {
            "0=状态未知",
            "1=预备中",
            "2=加热中",
            "3=通风中",
            "4=错误"});
            this.Row1L_Heat_Vent_Status.Location = new System.Drawing.Point(111, 25);
            this.Row1L_Heat_Vent_Status.Name = "Row1L_Heat_Vent_Status";
            this.Row1L_Heat_Vent_Status.Size = new System.Drawing.Size(169, 25);
            this.Row1L_Heat_Vent_Status.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "通风加热状态";
            // 
            // DrvStCshnFrntUpwdDnwdPos
            // 
            this.DrvStCshnFrntUpwdDnwdPos.Enabled = false;
            this.DrvStCshnFrntUpwdDnwdPos.Location = new System.Drawing.Point(117, 91);
            this.DrvStCshnFrntUpwdDnwdPos.Name = "DrvStCshnFrntUpwdDnwdPos";
            this.DrvStCshnFrntUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.DrvStCshnFrntUpwdDnwdPos.TabIndex = 35;
            // 
            // DrvStBkReclnUpwdDnwdPos
            // 
            this.DrvStBkReclnUpwdDnwdPos.Enabled = false;
            this.DrvStBkReclnUpwdDnwdPos.Location = new System.Drawing.Point(117, 54);
            this.DrvStBkReclnUpwdDnwdPos.Name = "DrvStBkReclnUpwdDnwdPos";
            this.DrvStBkReclnUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.DrvStBkReclnUpwdDnwdPos.TabIndex = 34;
            // 
            // DrvStFrwdBkwdPos
            // 
            this.DrvStFrwdBkwdPos.Enabled = false;
            this.DrvStFrwdBkwdPos.Location = new System.Drawing.Point(117, 17);
            this.DrvStFrwdBkwdPos.Name = "DrvStFrwdBkwdPos";
            this.DrvStFrwdBkwdPos.Size = new System.Drawing.Size(66, 22);
            this.DrvStFrwdBkwdPos.TabIndex = 33;
            // 
            // DrvStBkReclnUpwdDnwdSnsrHmPosLrnd
            // 
            this.DrvStBkReclnUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.DrvStBkReclnUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(332, 59);
            this.DrvStBkReclnUpwdDnwdSnsrHmPosLrnd.Name = "DrvStBkReclnUpwdDnwdSnsrHmPosLrnd";
            this.DrvStBkReclnUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.DrvStBkReclnUpwdDnwdSnsrHmPosLrnd.TabIndex = 29;
            this.DrvStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // DrvStBkReclnUpwdDnwdPosV
            // 
            this.DrvStBkReclnUpwdDnwdPosV.AutoSize = true;
            this.DrvStBkReclnUpwdDnwdPosV.Location = new System.Drawing.Point(217, 59);
            this.DrvStBkReclnUpwdDnwdPosV.Name = "DrvStBkReclnUpwdDnwdPosV";
            this.DrvStBkReclnUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.DrvStBkReclnUpwdDnwdPosV.TabIndex = 28;
            this.DrvStBkReclnUpwdDnwdPosV.Text = "位置有效性";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 59);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 13);
            this.label30.TabIndex = 27;
            this.label30.Text = "靠背位置";
            // 
            // DrvStFrwdBkwdSnsrHmPosLrnd
            // 
            this.DrvStFrwdBkwdSnsrHmPosLrnd.AutoSize = true;
            this.DrvStFrwdBkwdSnsrHmPosLrnd.Location = new System.Drawing.Point(332, 22);
            this.DrvStFrwdBkwdSnsrHmPosLrnd.Name = "DrvStFrwdBkwdSnsrHmPosLrnd";
            this.DrvStFrwdBkwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.DrvStFrwdBkwdSnsrHmPosLrnd.TabIndex = 26;
            this.DrvStFrwdBkwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // DrvStFrwdBkwdPosV
            // 
            this.DrvStFrwdBkwdPosV.AutoSize = true;
            this.DrvStFrwdBkwdPosV.Location = new System.Drawing.Point(217, 22);
            this.DrvStFrwdBkwdPosV.Name = "DrvStFrwdBkwdPosV";
            this.DrvStFrwdBkwdPosV.Size = new System.Drawing.Size(72, 13);
            this.DrvStFrwdBkwdPosV.TabIndex = 25;
            this.DrvStFrwdBkwdPosV.Text = "位置有效性";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "水平位置";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // DrvStCshnRrUpwdDnwdPos
            // 
            this.DrvStCshnRrUpwdDnwdPos.Enabled = false;
            this.DrvStCshnRrUpwdDnwdPos.Location = new System.Drawing.Point(117, 128);
            this.DrvStCshnRrUpwdDnwdPos.Name = "DrvStCshnRrUpwdDnwdPos";
            this.DrvStCshnRrUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.DrvStCshnRrUpwdDnwdPos.TabIndex = 23;
            // 
            // DrvStCshnRrUpwdDnwdSnsrHmPosLrnd
            // 
            this.DrvStCshnRrUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.DrvStCshnRrUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(332, 133);
            this.DrvStCshnRrUpwdDnwdSnsrHmPosLrnd.Name = "DrvStCshnRrUpwdDnwdSnsrHmPosLrnd";
            this.DrvStCshnRrUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.DrvStCshnRrUpwdDnwdSnsrHmPosLrnd.TabIndex = 22;
            this.DrvStCshnRrUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // DrvStCshnRrUpwdDnwdPosV
            // 
            this.DrvStCshnRrUpwdDnwdPosV.AutoSize = true;
            this.DrvStCshnRrUpwdDnwdPosV.Location = new System.Drawing.Point(217, 133);
            this.DrvStCshnRrUpwdDnwdPosV.Name = "DrvStCshnRrUpwdDnwdPosV";
            this.DrvStCshnRrUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.DrvStCshnRrUpwdDnwdPosV.TabIndex = 21;
            this.DrvStCshnRrUpwdDnwdPosV.Text = "位置有效性";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "后提升位置";
            // 
            // DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd
            // 
            this.DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(332, 96);
            this.DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd.Name = "DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd";
            this.DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd.TabIndex = 19;
            this.DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // DrvStCshnFrntUpwdDnwdPosV
            // 
            this.DrvStCshnFrntUpwdDnwdPosV.AutoSize = true;
            this.DrvStCshnFrntUpwdDnwdPosV.Location = new System.Drawing.Point(217, 96);
            this.DrvStCshnFrntUpwdDnwdPosV.Name = "DrvStCshnFrntUpwdDnwdPosV";
            this.DrvStCshnFrntUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.DrvStCshnFrntUpwdDnwdPosV.TabIndex = 18;
            this.DrvStCshnFrntUpwdDnwdPosV.Text = "位置有效性";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "前提升位置";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox17);
            this.groupBox11.Controls.Add(this.PassStBkReclnUpwdDnwdPos);
            this.groupBox11.Controls.Add(this.PassStFrwdBkwdPos);
            this.groupBox11.Controls.Add(this.PassStBkReclnUpwdDnwdSnsrHmPosLrnd);
            this.groupBox11.Controls.Add(this.PassStBkReclnUpwdDnwdPosV);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.PassStFrwdBkwdSnsrHmPosLrnd);
            this.groupBox11.Controls.Add(this.PassStFrwdBkwdPosV);
            this.groupBox11.Controls.Add(this.label25);
            this.groupBox11.Location = new System.Drawing.Point(322, 303);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(801, 277);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "CODR";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.Row1R_Heat_Vent_Status);
            this.groupBox17.Controls.Add(this.label18);
            this.groupBox17.Location = new System.Drawing.Point(458, 19);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(296, 66);
            this.groupBox17.TabIndex = 37;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "通风加热";
            // 
            // Row1R_Heat_Vent_Status
            // 
            this.Row1R_Heat_Vent_Status.Enabled = false;
            this.Row1R_Heat_Vent_Status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row1R_Heat_Vent_Status.FormattingEnabled = true;
            this.Row1R_Heat_Vent_Status.Items.AddRange(new object[] {
            "0=状态未知",
            "1=预备中",
            "2=加热中",
            "3=通风中",
            "4=错误"});
            this.Row1R_Heat_Vent_Status.Location = new System.Drawing.Point(111, 24);
            this.Row1R_Heat_Vent_Status.Name = "Row1R_Heat_Vent_Status";
            this.Row1R_Heat_Vent_Status.Size = new System.Drawing.Size(169, 25);
            this.Row1R_Heat_Vent_Status.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "通风加热状态";
            // 
            // PassStBkReclnUpwdDnwdPos
            // 
            this.PassStBkReclnUpwdDnwdPos.Enabled = false;
            this.PassStBkReclnUpwdDnwdPos.Location = new System.Drawing.Point(108, 54);
            this.PassStBkReclnUpwdDnwdPos.Name = "PassStBkReclnUpwdDnwdPos";
            this.PassStBkReclnUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.PassStBkReclnUpwdDnwdPos.TabIndex = 31;
            // 
            // PassStFrwdBkwdPos
            // 
            this.PassStFrwdBkwdPos.Enabled = false;
            this.PassStFrwdBkwdPos.Location = new System.Drawing.Point(108, 15);
            this.PassStFrwdBkwdPos.Name = "PassStFrwdBkwdPos";
            this.PassStFrwdBkwdPos.Size = new System.Drawing.Size(66, 22);
            this.PassStFrwdBkwdPos.TabIndex = 30;
            // 
            // PassStBkReclnUpwdDnwdSnsrHmPosLrnd
            // 
            this.PassStBkReclnUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.PassStBkReclnUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(332, 59);
            this.PassStBkReclnUpwdDnwdSnsrHmPosLrnd.Name = "PassStBkReclnUpwdDnwdSnsrHmPosLrnd";
            this.PassStBkReclnUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.PassStBkReclnUpwdDnwdSnsrHmPosLrnd.TabIndex = 29;
            this.PassStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // PassStBkReclnUpwdDnwdPosV
            // 
            this.PassStBkReclnUpwdDnwdPosV.AutoSize = true;
            this.PassStBkReclnUpwdDnwdPosV.Location = new System.Drawing.Point(217, 59);
            this.PassStBkReclnUpwdDnwdPosV.Name = "PassStBkReclnUpwdDnwdPosV";
            this.PassStBkReclnUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.PassStBkReclnUpwdDnwdPosV.TabIndex = 28;
            this.PassStBkReclnUpwdDnwdPosV.Text = "位置有效性";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 59);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 13);
            this.label28.TabIndex = 27;
            this.label28.Text = "靠背位置";
            // 
            // PassStFrwdBkwdSnsrHmPosLrnd
            // 
            this.PassStFrwdBkwdSnsrHmPosLrnd.AutoSize = true;
            this.PassStFrwdBkwdSnsrHmPosLrnd.Location = new System.Drawing.Point(332, 20);
            this.PassStFrwdBkwdSnsrHmPosLrnd.Name = "PassStFrwdBkwdSnsrHmPosLrnd";
            this.PassStFrwdBkwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.PassStFrwdBkwdSnsrHmPosLrnd.TabIndex = 26;
            this.PassStFrwdBkwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // PassStFrwdBkwdPosV
            // 
            this.PassStFrwdBkwdPosV.AutoSize = true;
            this.PassStFrwdBkwdPosV.Location = new System.Drawing.Point(217, 20);
            this.PassStFrwdBkwdPosV.Name = "PassStFrwdBkwdPosV";
            this.PassStFrwdBkwdPosV.Size = new System.Drawing.Size(72, 13);
            this.PassStFrwdBkwdPosV.TabIndex = 25;
            this.PassStFrwdBkwdPosV.Text = "位置有效性";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "水平位置";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1362, 623);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1354, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "前排";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1354, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "中排";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.SecRwRtStHtVntDtyCyclStat);
            this.groupBox12.Controls.Add(this.label19);
            this.groupBox12.Controls.Add(this.SecRwRtStLgExtOutInSnsrHmPosLrnd);
            this.groupBox12.Controls.Add(this.SecRwRtStLgExtOutInPosV);
            this.groupBox12.Controls.Add(this.SecRwRtStLgexInOutPos);
            this.groupBox12.Controls.Add(this.label10);
            this.groupBox12.Controls.Add(this.SecRwRtStBkReclnUpwdDnwdPos);
            this.groupBox12.Controls.Add(this.SecRwRtStFrwdBkwdPos);
            this.groupBox12.Controls.Add(this.SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd);
            this.groupBox12.Controls.Add(this.SecRwRtStBkReclnUpwdDnwdPosV);
            this.groupBox12.Controls.Add(this.label8);
            this.groupBox12.Controls.Add(this.SecRwRtStFrwdBkwdSnsrHmPosLrnd);
            this.groupBox12.Controls.Add(this.SecRwRtStFrwdBkwdPosV);
            this.groupBox12.Controls.Add(this.label17);
            this.groupBox12.Controls.Add(this.SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd);
            this.groupBox12.Controls.Add(this.SecRwRtStCshnFrntUpwdDnwdPosV);
            this.groupBox12.Controls.Add(this.SecRwRtStCshnFrntUpwdDnwdPos);
            this.groupBox12.Controls.Add(this.label31);
            this.groupBox12.Controls.Add(this.SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd);
            this.groupBox12.Controls.Add(this.SecRwRtStLgrstUpwdDnwdPosV);
            this.groupBox12.Controls.Add(this.SecRwRtStLgrstUpwdDnwdPos);
            this.groupBox12.Controls.Add(this.label36);
            this.groupBox12.Location = new System.Drawing.Point(478, 291);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(834, 277);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "2R";
            // 
            // SecRwRtStHtVntDtyCyclStat
            // 
            this.SecRwRtStHtVntDtyCyclStat.Enabled = false;
            this.SecRwRtStHtVntDtyCyclStat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecRwRtStHtVntDtyCyclStat.FormattingEnabled = true;
            this.SecRwRtStHtVntDtyCyclStat.Items.AddRange(new object[] {
            "0=状态未知",
            "1=预备中",
            "2=加热中",
            "3=通风中",
            "4=错误"});
            this.SecRwRtStHtVntDtyCyclStat.Location = new System.Drawing.Point(626, 12);
            this.SecRwRtStHtVntDtyCyclStat.Name = "SecRwRtStHtVntDtyCyclStat";
            this.SecRwRtStHtVntDtyCyclStat.Size = new System.Drawing.Size(169, 25);
            this.SecRwRtStHtVntDtyCyclStat.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(509, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 17);
            this.label19.TabIndex = 36;
            this.label19.Text = "通风加热状态";
            // 
            // SecRwRtStLgExtOutInSnsrHmPosLrnd
            // 
            this.SecRwRtStLgExtOutInSnsrHmPosLrnd.AutoSize = true;
            this.SecRwRtStLgExtOutInSnsrHmPosLrnd.Location = new System.Drawing.Point(367, 146);
            this.SecRwRtStLgExtOutInSnsrHmPosLrnd.Name = "SecRwRtStLgExtOutInSnsrHmPosLrnd";
            this.SecRwRtStLgExtOutInSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.SecRwRtStLgExtOutInSnsrHmPosLrnd.TabIndex = 35;
            this.SecRwRtStLgExtOutInSnsrHmPosLrnd.Text = "学习状态";
            // 
            // SecRwRtStLgExtOutInPosV
            // 
            this.SecRwRtStLgExtOutInPosV.AutoSize = true;
            this.SecRwRtStLgExtOutInPosV.Location = new System.Drawing.Point(258, 146);
            this.SecRwRtStLgExtOutInPosV.Name = "SecRwRtStLgExtOutInPosV";
            this.SecRwRtStLgExtOutInPosV.Size = new System.Drawing.Size(72, 13);
            this.SecRwRtStLgExtOutInPosV.TabIndex = 34;
            this.SecRwRtStLgExtOutInPosV.Text = "位置有效性";
            // 
            // SecRwRtStLgexInOutPos
            // 
            this.SecRwRtStLgexInOutPos.Enabled = false;
            this.SecRwRtStLgexInOutPos.Location = new System.Drawing.Point(155, 141);
            this.SecRwRtStLgexInOutPos.Name = "SecRwRtStLgexInOutPos";
            this.SecRwRtStLgexInOutPos.Size = new System.Drawing.Size(66, 22);
            this.SecRwRtStLgexInOutPos.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "腿托延申电机位置";
            // 
            // SecRwRtStBkReclnUpwdDnwdPos
            // 
            this.SecRwRtStBkReclnUpwdDnwdPos.Enabled = false;
            this.SecRwRtStBkReclnUpwdDnwdPos.Location = new System.Drawing.Point(155, 57);
            this.SecRwRtStBkReclnUpwdDnwdPos.Name = "SecRwRtStBkReclnUpwdDnwdPos";
            this.SecRwRtStBkReclnUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.SecRwRtStBkReclnUpwdDnwdPos.TabIndex = 31;
            // 
            // SecRwRtStFrwdBkwdPos
            // 
            this.SecRwRtStFrwdBkwdPos.Enabled = false;
            this.SecRwRtStFrwdBkwdPos.Location = new System.Drawing.Point(155, 15);
            this.SecRwRtStFrwdBkwdPos.Name = "SecRwRtStFrwdBkwdPos";
            this.SecRwRtStFrwdBkwdPos.Size = new System.Drawing.Size(66, 22);
            this.SecRwRtStFrwdBkwdPos.TabIndex = 30;
            // 
            // SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd
            // 
            this.SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(367, 62);
            this.SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Name = "SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd";
            this.SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.TabIndex = 29;
            this.SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // SecRwRtStBkReclnUpwdDnwdPosV
            // 
            this.SecRwRtStBkReclnUpwdDnwdPosV.AutoSize = true;
            this.SecRwRtStBkReclnUpwdDnwdPosV.Location = new System.Drawing.Point(258, 62);
            this.SecRwRtStBkReclnUpwdDnwdPosV.Name = "SecRwRtStBkReclnUpwdDnwdPosV";
            this.SecRwRtStBkReclnUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.SecRwRtStBkReclnUpwdDnwdPosV.TabIndex = 28;
            this.SecRwRtStBkReclnUpwdDnwdPosV.Text = "位置有效性";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "靠背电机位置";
            // 
            // SecRwRtStFrwdBkwdSnsrHmPosLrnd
            // 
            this.SecRwRtStFrwdBkwdSnsrHmPosLrnd.AutoSize = true;
            this.SecRwRtStFrwdBkwdSnsrHmPosLrnd.Location = new System.Drawing.Point(367, 20);
            this.SecRwRtStFrwdBkwdSnsrHmPosLrnd.Name = "SecRwRtStFrwdBkwdSnsrHmPosLrnd";
            this.SecRwRtStFrwdBkwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.SecRwRtStFrwdBkwdSnsrHmPosLrnd.TabIndex = 26;
            this.SecRwRtStFrwdBkwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // SecRwRtStFrwdBkwdPosV
            // 
            this.SecRwRtStFrwdBkwdPosV.AutoSize = true;
            this.SecRwRtStFrwdBkwdPosV.Location = new System.Drawing.Point(258, 20);
            this.SecRwRtStFrwdBkwdPosV.Name = "SecRwRtStFrwdBkwdPosV";
            this.SecRwRtStFrwdBkwdPosV.Size = new System.Drawing.Size(72, 13);
            this.SecRwRtStFrwdBkwdPosV.TabIndex = 25;
            this.SecRwRtStFrwdBkwdPosV.Text = "位置有效性";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "水平电机位置";
            // 
            // SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd
            // 
            this.SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(367, 189);
            this.SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Name = "SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd";
            this.SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd.TabIndex = 19;
            this.SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // SecRwRtStCshnFrntUpwdDnwdPosV
            // 
            this.SecRwRtStCshnFrntUpwdDnwdPosV.AutoSize = true;
            this.SecRwRtStCshnFrntUpwdDnwdPosV.Location = new System.Drawing.Point(258, 189);
            this.SecRwRtStCshnFrntUpwdDnwdPosV.Name = "SecRwRtStCshnFrntUpwdDnwdPosV";
            this.SecRwRtStCshnFrntUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.SecRwRtStCshnFrntUpwdDnwdPosV.TabIndex = 18;
            this.SecRwRtStCshnFrntUpwdDnwdPosV.Text = "位置有效性";
            // 
            // SecRwRtStCshnFrntUpwdDnwdPos
            // 
            this.SecRwRtStCshnFrntUpwdDnwdPos.Enabled = false;
            this.SecRwRtStCshnFrntUpwdDnwdPos.Location = new System.Drawing.Point(155, 184);
            this.SecRwRtStCshnFrntUpwdDnwdPos.Name = "SecRwRtStCshnFrntUpwdDnwdPos";
            this.SecRwRtStCshnFrntUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.SecRwRtStCshnFrntUpwdDnwdPos.TabIndex = 17;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 189);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 13);
            this.label31.TabIndex = 16;
            this.label31.Text = "零重力位置";
            // 
            // SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd
            // 
            this.SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(367, 105);
            this.SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd.Name = "SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd";
            this.SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd.TabIndex = 15;
            this.SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // SecRwRtStLgrstUpwdDnwdPosV
            // 
            this.SecRwRtStLgrstUpwdDnwdPosV.AutoSize = true;
            this.SecRwRtStLgrstUpwdDnwdPosV.Location = new System.Drawing.Point(258, 105);
            this.SecRwRtStLgrstUpwdDnwdPosV.Name = "SecRwRtStLgrstUpwdDnwdPosV";
            this.SecRwRtStLgrstUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.SecRwRtStLgrstUpwdDnwdPosV.TabIndex = 14;
            this.SecRwRtStLgrstUpwdDnwdPosV.Text = "位置有效性";
            // 
            // SecRwRtStLgrstUpwdDnwdPos
            // 
            this.SecRwRtStLgrstUpwdDnwdPos.Enabled = false;
            this.SecRwRtStLgrstUpwdDnwdPos.Location = new System.Drawing.Point(155, 100);
            this.SecRwRtStLgrstUpwdDnwdPos.Name = "SecRwRtStLgrstUpwdDnwdPos";
            this.SecRwRtStLgrstUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.SecRwRtStLgrstUpwdDnwdPos.TabIndex = 13;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(7, 105);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(111, 13);
            this.label36.TabIndex = 12;
            this.label36.Text = "腿托折叠电机位置";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.SecRwLtStHtVntDtyCyclStat);
            this.groupBox9.Controls.Add(this.label37);
            this.groupBox9.Controls.Add(this.SecRwLtStLgExtOutInSnsrHmPosLrnd);
            this.groupBox9.Controls.Add(this.SecRwLtStLgExtOutInPosV);
            this.groupBox9.Controls.Add(this.SecRwLtStLgexInOutPos);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Controls.Add(this.SecRwLtStBkReclnUpwdDnwdPos);
            this.groupBox9.Controls.Add(this.SecRwLtStFrwdBkwdPos);
            this.groupBox9.Controls.Add(this.SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd);
            this.groupBox9.Controls.Add(this.SecRwLtStBkReclnUpwdDnwdPosV);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.SecRwLtStFrwdBkwdSnsrHmPosLrnd);
            this.groupBox9.Controls.Add(this.SecRwLtStFrwdBkwdPosV);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd);
            this.groupBox9.Controls.Add(this.SecRwLtStCshnFrntUpwdDnwdPosV);
            this.groupBox9.Controls.Add(this.SecRwLtStCshnFrntUpwdDnwdPos);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd);
            this.groupBox9.Controls.Add(this.SecRwLtStLgrstUpwdDnwdPosV);
            this.groupBox9.Controls.Add(this.SecRwLtStLgrstUpwdDnwdPos);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Location = new System.Drawing.Point(478, 8);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(834, 277);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "2L";
            // 
            // SecRwLtStHtVntDtyCyclStat
            // 
            this.SecRwLtStHtVntDtyCyclStat.Enabled = false;
            this.SecRwLtStHtVntDtyCyclStat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecRwLtStHtVntDtyCyclStat.FormattingEnabled = true;
            this.SecRwLtStHtVntDtyCyclStat.Items.AddRange(new object[] {
            "0=状态未知",
            "1=预备中",
            "2=加热中",
            "3=通风中",
            "4=错误"});
            this.SecRwLtStHtVntDtyCyclStat.Location = new System.Drawing.Point(626, 15);
            this.SecRwLtStHtVntDtyCyclStat.Name = "SecRwLtStHtVntDtyCyclStat";
            this.SecRwLtStHtVntDtyCyclStat.Size = new System.Drawing.Size(169, 25);
            this.SecRwLtStHtVntDtyCyclStat.TabIndex = 1;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(509, 20);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(104, 17);
            this.label37.TabIndex = 0;
            this.label37.Text = "通风加热状态";
            // 
            // SecRwLtStLgExtOutInSnsrHmPosLrnd
            // 
            this.SecRwLtStLgExtOutInSnsrHmPosLrnd.AutoSize = true;
            this.SecRwLtStLgExtOutInSnsrHmPosLrnd.Location = new System.Drawing.Point(367, 138);
            this.SecRwLtStLgExtOutInSnsrHmPosLrnd.Name = "SecRwLtStLgExtOutInSnsrHmPosLrnd";
            this.SecRwLtStLgExtOutInSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.SecRwLtStLgExtOutInSnsrHmPosLrnd.TabIndex = 35;
            this.SecRwLtStLgExtOutInSnsrHmPosLrnd.Text = "学习状态";
            // 
            // SecRwLtStLgExtOutInPosV
            // 
            this.SecRwLtStLgExtOutInPosV.AutoSize = true;
            this.SecRwLtStLgExtOutInPosV.Location = new System.Drawing.Point(258, 138);
            this.SecRwLtStLgExtOutInPosV.Name = "SecRwLtStLgExtOutInPosV";
            this.SecRwLtStLgExtOutInPosV.Size = new System.Drawing.Size(72, 13);
            this.SecRwLtStLgExtOutInPosV.TabIndex = 34;
            this.SecRwLtStLgExtOutInPosV.Text = "位置有效性";
            // 
            // SecRwLtStLgexInOutPos
            // 
            this.SecRwLtStLgexInOutPos.Enabled = false;
            this.SecRwLtStLgexInOutPos.Location = new System.Drawing.Point(155, 133);
            this.SecRwLtStLgexInOutPos.Name = "SecRwLtStLgexInOutPos";
            this.SecRwLtStLgexInOutPos.Size = new System.Drawing.Size(66, 22);
            this.SecRwLtStLgexInOutPos.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "腿托延申电机位置";
            // 
            // SecRwLtStBkReclnUpwdDnwdPos
            // 
            this.SecRwLtStBkReclnUpwdDnwdPos.Enabled = false;
            this.SecRwLtStBkReclnUpwdDnwdPos.Location = new System.Drawing.Point(155, 54);
            this.SecRwLtStBkReclnUpwdDnwdPos.Name = "SecRwLtStBkReclnUpwdDnwdPos";
            this.SecRwLtStBkReclnUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.SecRwLtStBkReclnUpwdDnwdPos.TabIndex = 31;
            // 
            // SecRwLtStFrwdBkwdPos
            // 
            this.SecRwLtStFrwdBkwdPos.Enabled = false;
            this.SecRwLtStFrwdBkwdPos.Location = new System.Drawing.Point(155, 15);
            this.SecRwLtStFrwdBkwdPos.Name = "SecRwLtStFrwdBkwdPos";
            this.SecRwLtStFrwdBkwdPos.Size = new System.Drawing.Size(66, 22);
            this.SecRwLtStFrwdBkwdPos.TabIndex = 30;
            // 
            // SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd
            // 
            this.SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(367, 59);
            this.SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Name = "SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd";
            this.SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.TabIndex = 29;
            this.SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // SecRwLtStBkReclnUpwdDnwdPosV
            // 
            this.SecRwLtStBkReclnUpwdDnwdPosV.AutoSize = true;
            this.SecRwLtStBkReclnUpwdDnwdPosV.Location = new System.Drawing.Point(258, 59);
            this.SecRwLtStBkReclnUpwdDnwdPosV.Name = "SecRwLtStBkReclnUpwdDnwdPosV";
            this.SecRwLtStBkReclnUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.SecRwLtStBkReclnUpwdDnwdPosV.TabIndex = 28;
            this.SecRwLtStBkReclnUpwdDnwdPosV.Text = "位置有效性";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "靠背电机位置";
            // 
            // SecRwLtStFrwdBkwdSnsrHmPosLrnd
            // 
            this.SecRwLtStFrwdBkwdSnsrHmPosLrnd.AutoSize = true;
            this.SecRwLtStFrwdBkwdSnsrHmPosLrnd.Location = new System.Drawing.Point(367, 20);
            this.SecRwLtStFrwdBkwdSnsrHmPosLrnd.Name = "SecRwLtStFrwdBkwdSnsrHmPosLrnd";
            this.SecRwLtStFrwdBkwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.SecRwLtStFrwdBkwdSnsrHmPosLrnd.TabIndex = 26;
            this.SecRwLtStFrwdBkwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // SecRwLtStFrwdBkwdPosV
            // 
            this.SecRwLtStFrwdBkwdPosV.AutoSize = true;
            this.SecRwLtStFrwdBkwdPosV.Location = new System.Drawing.Point(258, 20);
            this.SecRwLtStFrwdBkwdPosV.Name = "SecRwLtStFrwdBkwdPosV";
            this.SecRwLtStFrwdBkwdPosV.Size = new System.Drawing.Size(72, 13);
            this.SecRwLtStFrwdBkwdPosV.TabIndex = 25;
            this.SecRwLtStFrwdBkwdPosV.Text = "位置有效性";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "水平电机位置";
            // 
            // SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd
            // 
            this.SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(367, 179);
            this.SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Name = "SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd";
            this.SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd.TabIndex = 19;
            this.SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // SecRwLtStCshnFrntUpwdDnwdPosV
            // 
            this.SecRwLtStCshnFrntUpwdDnwdPosV.AutoSize = true;
            this.SecRwLtStCshnFrntUpwdDnwdPosV.Location = new System.Drawing.Point(258, 179);
            this.SecRwLtStCshnFrntUpwdDnwdPosV.Name = "SecRwLtStCshnFrntUpwdDnwdPosV";
            this.SecRwLtStCshnFrntUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.SecRwLtStCshnFrntUpwdDnwdPosV.TabIndex = 18;
            this.SecRwLtStCshnFrntUpwdDnwdPosV.Text = "位置有效性";
            // 
            // SecRwLtStCshnFrntUpwdDnwdPos
            // 
            this.SecRwLtStCshnFrntUpwdDnwdPos.Enabled = false;
            this.SecRwLtStCshnFrntUpwdDnwdPos.Location = new System.Drawing.Point(155, 174);
            this.SecRwLtStCshnFrntUpwdDnwdPos.Name = "SecRwLtStCshnFrntUpwdDnwdPos";
            this.SecRwLtStCshnFrntUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.SecRwLtStCshnFrntUpwdDnwdPos.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 179);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "零重力位置";
            // 
            // SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd
            // 
            this.SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(367, 97);
            this.SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd.Name = "SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd";
            this.SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd.TabIndex = 15;
            this.SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // SecRwLtStLgrstUpwdDnwdPosV
            // 
            this.SecRwLtStLgrstUpwdDnwdPosV.AutoSize = true;
            this.SecRwLtStLgrstUpwdDnwdPosV.Location = new System.Drawing.Point(258, 97);
            this.SecRwLtStLgrstUpwdDnwdPosV.Name = "SecRwLtStLgrstUpwdDnwdPosV";
            this.SecRwLtStLgrstUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.SecRwLtStLgrstUpwdDnwdPosV.TabIndex = 14;
            this.SecRwLtStLgrstUpwdDnwdPosV.Text = "位置有效性";
            // 
            // SecRwLtStLgrstUpwdDnwdPos
            // 
            this.SecRwLtStLgrstUpwdDnwdPos.Enabled = false;
            this.SecRwLtStLgrstUpwdDnwdPos.Location = new System.Drawing.Point(155, 92);
            this.SecRwLtStLgrstUpwdDnwdPos.Name = "SecRwLtStLgrstUpwdDnwdPos";
            this.SecRwLtStLgrstUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.SecRwLtStLgrstUpwdDnwdPos.TabIndex = 13;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 97);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(111, 13);
            this.label29.TabIndex = 12;
            this.label29.Text = "腿托折叠电机位置";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox14);
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1354, 597);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "后排";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.ThdRwRtStBkReclnUpwdDnwdPos);
            this.groupBox14.Controls.Add(this.ThdRwRtStFrwdBkwdPos);
            this.groupBox14.Controls.Add(this.ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd);
            this.groupBox14.Controls.Add(this.ThdRwRtStBkReclnUpwdDnwdPosV);
            this.groupBox14.Controls.Add(this.label33);
            this.groupBox14.Controls.Add(this.ThdRwRtStFrwdBkwdSnsrHmPosLrnd);
            this.groupBox14.Controls.Add(this.ThdRwRtStFrwdBkwdPosV);
            this.groupBox14.Controls.Add(this.label44);
            this.groupBox14.Controls.Add(this.ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd);
            this.groupBox14.Controls.Add(this.ThdRwRtStCshnFldUpwdDnwdPosV);
            this.groupBox14.Controls.Add(this.ThdRwRtStCshnFldUpwdDnwdPos);
            this.groupBox14.Controls.Add(this.label48);
            this.groupBox14.Location = new System.Drawing.Point(281, 123);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(846, 111);
            this.groupBox14.TabIndex = 4;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "3R";
            // 
            // ThdRwRtStBkReclnUpwdDnwdPos
            // 
            this.ThdRwRtStBkReclnUpwdDnwdPos.Enabled = false;
            this.ThdRwRtStBkReclnUpwdDnwdPos.Location = new System.Drawing.Point(116, 45);
            this.ThdRwRtStBkReclnUpwdDnwdPos.Name = "ThdRwRtStBkReclnUpwdDnwdPos";
            this.ThdRwRtStBkReclnUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.ThdRwRtStBkReclnUpwdDnwdPos.TabIndex = 31;
            // 
            // ThdRwRtStFrwdBkwdPos
            // 
            this.ThdRwRtStFrwdBkwdPos.Enabled = false;
            this.ThdRwRtStFrwdBkwdPos.Location = new System.Drawing.Point(116, 17);
            this.ThdRwRtStFrwdBkwdPos.Name = "ThdRwRtStFrwdBkwdPos";
            this.ThdRwRtStFrwdBkwdPos.Size = new System.Drawing.Size(66, 22);
            this.ThdRwRtStFrwdBkwdPos.TabIndex = 30;
            // 
            // ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd
            // 
            this.ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(306, 48);
            this.ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Name = "ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd";
            this.ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.TabIndex = 29;
            this.ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // ThdRwRtStBkReclnUpwdDnwdPosV
            // 
            this.ThdRwRtStBkReclnUpwdDnwdPosV.AutoSize = true;
            this.ThdRwRtStBkReclnUpwdDnwdPosV.Location = new System.Drawing.Point(209, 48);
            this.ThdRwRtStBkReclnUpwdDnwdPosV.Name = "ThdRwRtStBkReclnUpwdDnwdPosV";
            this.ThdRwRtStBkReclnUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.ThdRwRtStBkReclnUpwdDnwdPosV.TabIndex = 28;
            this.ThdRwRtStBkReclnUpwdDnwdPosV.Text = "位置有效性";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 48);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(85, 13);
            this.label33.TabIndex = 27;
            this.label33.Text = "靠背电机位置";
            // 
            // ThdRwRtStFrwdBkwdSnsrHmPosLrnd
            // 
            this.ThdRwRtStFrwdBkwdSnsrHmPosLrnd.AutoSize = true;
            this.ThdRwRtStFrwdBkwdSnsrHmPosLrnd.Location = new System.Drawing.Point(306, 20);
            this.ThdRwRtStFrwdBkwdSnsrHmPosLrnd.Name = "ThdRwRtStFrwdBkwdSnsrHmPosLrnd";
            this.ThdRwRtStFrwdBkwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.ThdRwRtStFrwdBkwdSnsrHmPosLrnd.TabIndex = 26;
            this.ThdRwRtStFrwdBkwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // ThdRwRtStFrwdBkwdPosV
            // 
            this.ThdRwRtStFrwdBkwdPosV.AutoSize = true;
            this.ThdRwRtStFrwdBkwdPosV.Location = new System.Drawing.Point(209, 20);
            this.ThdRwRtStFrwdBkwdPosV.Name = "ThdRwRtStFrwdBkwdPosV";
            this.ThdRwRtStFrwdBkwdPosV.Size = new System.Drawing.Size(72, 13);
            this.ThdRwRtStFrwdBkwdPosV.TabIndex = 25;
            this.ThdRwRtStFrwdBkwdPosV.Text = "位置有效性";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 20);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(85, 13);
            this.label44.TabIndex = 24;
            this.label44.Text = "水平电机位置";
            // 
            // ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd
            // 
            this.ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd.AutoSize = true;
            this.ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd.Location = new System.Drawing.Point(307, 76);
            this.ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd.Name = "ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd";
            this.ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd.TabIndex = 19;
            this.ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // ThdRwRtStCshnFldUpwdDnwdPosV
            // 
            this.ThdRwRtStCshnFldUpwdDnwdPosV.AutoSize = true;
            this.ThdRwRtStCshnFldUpwdDnwdPosV.Location = new System.Drawing.Point(210, 76);
            this.ThdRwRtStCshnFldUpwdDnwdPosV.Name = "ThdRwRtStCshnFldUpwdDnwdPosV";
            this.ThdRwRtStCshnFldUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.ThdRwRtStCshnFldUpwdDnwdPosV.TabIndex = 18;
            this.ThdRwRtStCshnFldUpwdDnwdPosV.Text = "位置有效性";
            // 
            // ThdRwRtStCshnFldUpwdDnwdPos
            // 
            this.ThdRwRtStCshnFldUpwdDnwdPos.Enabled = false;
            this.ThdRwRtStCshnFldUpwdDnwdPos.Location = new System.Drawing.Point(116, 73);
            this.ThdRwRtStCshnFldUpwdDnwdPos.Name = "ThdRwRtStCshnFldUpwdDnwdPos";
            this.ThdRwRtStCshnFldUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.ThdRwRtStCshnFldUpwdDnwdPos.TabIndex = 17;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(7, 76);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(85, 13);
            this.label48.TabIndex = 16;
            this.label48.Text = "折叠电机位置";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.ThdRwLtStBkReclnUpwdDnwdPos);
            this.groupBox13.Controls.Add(this.ThdRwLtStFrwdBkwdPos);
            this.groupBox13.Controls.Add(this.ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd);
            this.groupBox13.Controls.Add(this.ThdRwLtStBkReclnUpwdDnwdPosV);
            this.groupBox13.Controls.Add(this.label11);
            this.groupBox13.Controls.Add(this.ThdRwLtStFrwdBkwdSnsrHmPosLrnd);
            this.groupBox13.Controls.Add(this.ThdRwLtStFrwdBkwdPosV);
            this.groupBox13.Controls.Add(this.label22);
            this.groupBox13.Controls.Add(this.ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd);
            this.groupBox13.Controls.Add(this.ThdRwLtStCshnFldUpwdDnwdPosV);
            this.groupBox13.Controls.Add(this.ThdRwLtStCshnFldUpwdDnwdPos);
            this.groupBox13.Controls.Add(this.label39);
            this.groupBox13.Location = new System.Drawing.Point(281, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(846, 111);
            this.groupBox13.TabIndex = 3;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "3L";
            // 
            // ThdRwLtStBkReclnUpwdDnwdPos
            // 
            this.ThdRwLtStBkReclnUpwdDnwdPos.Enabled = false;
            this.ThdRwLtStBkReclnUpwdDnwdPos.Location = new System.Drawing.Point(117, 45);
            this.ThdRwLtStBkReclnUpwdDnwdPos.Name = "ThdRwLtStBkReclnUpwdDnwdPos";
            this.ThdRwLtStBkReclnUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.ThdRwLtStBkReclnUpwdDnwdPos.TabIndex = 31;
            // 
            // ThdRwLtStFrwdBkwdPos
            // 
            this.ThdRwLtStFrwdBkwdPos.Enabled = false;
            this.ThdRwLtStFrwdBkwdPos.Location = new System.Drawing.Point(117, 15);
            this.ThdRwLtStFrwdBkwdPos.Name = "ThdRwLtStFrwdBkwdPos";
            this.ThdRwLtStFrwdBkwdPos.Size = new System.Drawing.Size(66, 22);
            this.ThdRwLtStFrwdBkwdPos.TabIndex = 30;
            // 
            // ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd
            // 
            this.ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(307, 50);
            this.ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Name = "ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd";
            this.ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.TabIndex = 29;
            this.ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // ThdRwLtStBkReclnUpwdDnwdPosV
            // 
            this.ThdRwLtStBkReclnUpwdDnwdPosV.AutoSize = true;
            this.ThdRwLtStBkReclnUpwdDnwdPosV.Location = new System.Drawing.Point(209, 50);
            this.ThdRwLtStBkReclnUpwdDnwdPosV.Name = "ThdRwLtStBkReclnUpwdDnwdPosV";
            this.ThdRwLtStBkReclnUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.ThdRwLtStBkReclnUpwdDnwdPosV.TabIndex = 28;
            this.ThdRwLtStBkReclnUpwdDnwdPosV.Text = "位置有效性";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "靠背电机位置";
            // 
            // ThdRwLtStFrwdBkwdSnsrHmPosLrnd
            // 
            this.ThdRwLtStFrwdBkwdSnsrHmPosLrnd.AutoSize = true;
            this.ThdRwLtStFrwdBkwdSnsrHmPosLrnd.Location = new System.Drawing.Point(307, 20);
            this.ThdRwLtStFrwdBkwdSnsrHmPosLrnd.Name = "ThdRwLtStFrwdBkwdSnsrHmPosLrnd";
            this.ThdRwLtStFrwdBkwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.ThdRwLtStFrwdBkwdSnsrHmPosLrnd.TabIndex = 26;
            this.ThdRwLtStFrwdBkwdSnsrHmPosLrnd.Text = "学习状态";
            // 
            // ThdRwLtStFrwdBkwdPosV
            // 
            this.ThdRwLtStFrwdBkwdPosV.AutoSize = true;
            this.ThdRwLtStFrwdBkwdPosV.Location = new System.Drawing.Point(209, 20);
            this.ThdRwLtStFrwdBkwdPosV.Name = "ThdRwLtStFrwdBkwdPosV";
            this.ThdRwLtStFrwdBkwdPosV.Size = new System.Drawing.Size(72, 13);
            this.ThdRwLtStFrwdBkwdPosV.TabIndex = 25;
            this.ThdRwLtStFrwdBkwdPosV.Text = "位置有效性";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "水平电机位置";
            // 
            // ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd
            // 
            this.ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd.AutoSize = true;
            this.ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd.Location = new System.Drawing.Point(307, 79);
            this.ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd.Name = "ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd";
            this.ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd.Size = new System.Drawing.Size(59, 13);
            this.ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd.TabIndex = 19;
            this.ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd.Text = "学习状态";
            this.ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd.Click += new System.EventHandler(this.ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd_Click);
            // 
            // ThdRwLtStCshnFldUpwdDnwdPosV
            // 
            this.ThdRwLtStCshnFldUpwdDnwdPosV.AutoSize = true;
            this.ThdRwLtStCshnFldUpwdDnwdPosV.Location = new System.Drawing.Point(209, 79);
            this.ThdRwLtStCshnFldUpwdDnwdPosV.Name = "ThdRwLtStCshnFldUpwdDnwdPosV";
            this.ThdRwLtStCshnFldUpwdDnwdPosV.Size = new System.Drawing.Size(72, 13);
            this.ThdRwLtStCshnFldUpwdDnwdPosV.TabIndex = 18;
            this.ThdRwLtStCshnFldUpwdDnwdPosV.Text = "位置有效性";
            // 
            // ThdRwLtStCshnFldUpwdDnwdPos
            // 
            this.ThdRwLtStCshnFldUpwdDnwdPos.Enabled = false;
            this.ThdRwLtStCshnFldUpwdDnwdPos.Location = new System.Drawing.Point(117, 74);
            this.ThdRwLtStCshnFldUpwdDnwdPos.Name = "ThdRwLtStCshnFldUpwdDnwdPos";
            this.ThdRwLtStCshnFldUpwdDnwdPos.Size = new System.Drawing.Size(66, 22);
            this.ThdRwLtStCshnFldUpwdDnwdPos.TabIndex = 17;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 79);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(85, 13);
            this.label39.TabIndex = 16;
            this.label39.Text = "折叠电机位置";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBox2);
            this.tabPage4.Controls.Add(this.SecRwRtStChldLkLReq);
            this.tabPage4.Controls.Add(this.RcvyMdHMI2RRclReq);
            this.tabPage4.Controls.Add(this.AcsMdExtMdHMI2RRclReq);
            this.tabPage4.Controls.Add(this.SecRwRtStMassStrsHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStMassMdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStLmbrHMI2RReq);
            this.tabPage4.Controls.Add(this.BosSWStBkReclnDnwdHMI2RReq);
            this.tabPage4.Controls.Add(this.BosSWStBkReclnUpwdHMI2RReq);
            this.tabPage4.Controls.Add(this.BosSWBkwdHMI2RReq);
            this.tabPage4.Controls.Add(this.BosSWFrwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStFtDnwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStFtUpwdHMI2RReq);
            this.tabPage4.Controls.Add(this.VIPMdHMI2RRclReq);
            this.tabPage4.Controls.Add(this.SecRwRtStArmScrnHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStMemHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStHdrstDnwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStHdrstUpwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStRtwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStLtwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStLgrstDnwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStLgrstUpwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStBkReclnDnwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStBkReclnUpwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStBkwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwRtStFrwdHMI2RReq);
            this.tabPage4.Controls.Add(this.SecRwLtStChldLkLReq);
            this.tabPage4.Controls.Add(this.RcvyMdHMI2LRclReq);
            this.tabPage4.Controls.Add(this.AcsMdExtMdHMI2LRclReq);
            this.tabPage4.Controls.Add(this.VIPMdHMI2LRclReq);
            this.tabPage4.Controls.Add(this.SecRwLtStArmScrnHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStFtDnwdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStFtUpwdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStMassStrsHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStMassMdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStLmbrHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStMemHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStHdrstDnwdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStHdrstUpwdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStRtwdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStLtwdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStLgrstDnwdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStLgrstUpwdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStBkReclnDnwdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStBkReclnUpwdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStBkwdHMI2LReq);
            this.tabPage4.Controls.Add(this.SecRwLtStFrwdHMI2LReq);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1354, 597);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "中排驱动";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 17);
            this.checkBox2.TabIndex = 46;
            this.checkBox2.Text = "发送";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // SecRwRtStChldLkLReq
            // 
            this.SecRwRtStChldLkLReq.AutoSize = true;
            this.SecRwRtStChldLkLReq.Location = new System.Drawing.Point(878, 429);
            this.SecRwRtStChldLkLReq.Name = "SecRwRtStChldLkLReq";
            this.SecRwRtStChldLkLReq.Size = new System.Drawing.Size(296, 17);
            this.SecRwRtStChldLkLReq.TabIndex = 45;
            this.SecRwRtStChldLkLReq.Text = "Second Row Right Seat Child Restraint Lock Request";
            this.SecRwRtStChldLkLReq.UseVisualStyleBackColor = true;
            this.SecRwRtStChldLkLReq.CheckedChanged += new System.EventHandler(this.SecRwRtStChldLkLReq_CheckedChanged);
            // 
            // RcvyMdHMI2RRclReq
            // 
            this.RcvyMdHMI2RRclReq.AutoSize = true;
            this.RcvyMdHMI2RRclReq.Location = new System.Drawing.Point(878, 387);
            this.RcvyMdHMI2RRclReq.Name = "RcvyMdHMI2RRclReq";
            this.RcvyMdHMI2RRclReq.Size = new System.Drawing.Size(224, 17);
            this.RcvyMdHMI2RRclReq.TabIndex = 44;
            this.RcvyMdHMI2RRclReq.Text = "Recovery Mode HMI_2R Recall Request";
            this.RcvyMdHMI2RRclReq.UseVisualStyleBackColor = true;
            this.RcvyMdHMI2RRclReq.CheckedChanged += new System.EventHandler(this.RcvyMdHMI2RRclReq_CheckedChanged);
            // 
            // AcsMdExtMdHMI2RRclReq
            // 
            this.AcsMdExtMdHMI2RRclReq.AutoSize = true;
            this.AcsMdExtMdHMI2RRclReq.Location = new System.Drawing.Point(878, 345);
            this.AcsMdExtMdHMI2RRclReq.Name = "AcsMdExtMdHMI2RRclReq";
            this.AcsMdExtMdHMI2RRclReq.Size = new System.Drawing.Size(222, 17);
            this.AcsMdExtMdHMI2RRclReq.TabIndex = 43;
            this.AcsMdExtMdHMI2RRclReq.Text = "Easy Exit Mode HMI_2R Recall Request";
            this.AcsMdExtMdHMI2RRclReq.UseVisualStyleBackColor = true;
            this.AcsMdExtMdHMI2RRclReq.CheckedChanged += new System.EventHandler(this.AcsMdExtMdHMI2RRclReq_CheckedChanged);
            // 
            // SecRwRtStMassStrsHMI2RReq
            // 
            this.SecRwRtStMassStrsHMI2RReq.AutoSize = true;
            this.SecRwRtStMassStrsHMI2RReq.Location = new System.Drawing.Point(878, 303);
            this.SecRwRtStMassStrsHMI2RReq.Name = "SecRwRtStMassStrsHMI2RReq";
            this.SecRwRtStMassStrsHMI2RReq.Size = new System.Drawing.Size(314, 17);
            this.SecRwRtStMassStrsHMI2RReq.TabIndex = 42;
            this.SecRwRtStMassStrsHMI2RReq.Text = "Second Row Right Seat Massage Stress HMI_2R Request";
            this.SecRwRtStMassStrsHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStMassStrsHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStMassStrsHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStMassMdHMI2RReq
            // 
            this.SecRwRtStMassMdHMI2RReq.AutoSize = true;
            this.SecRwRtStMassMdHMI2RReq.Location = new System.Drawing.Point(878, 261);
            this.SecRwRtStMassMdHMI2RReq.Name = "SecRwRtStMassMdHMI2RReq";
            this.SecRwRtStMassMdHMI2RReq.Size = new System.Drawing.Size(314, 17);
            this.SecRwRtStMassMdHMI2RReq.TabIndex = 41;
            this.SecRwRtStMassMdHMI2RReq.Text = "Second Row Right Seat Massage Mode HMI_2R Request";
            this.SecRwRtStMassMdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStMassMdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStMassMdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStLmbrHMI2RReq
            // 
            this.SecRwRtStLmbrHMI2RReq.AutoSize = true;
            this.SecRwRtStLmbrHMI2RReq.Location = new System.Drawing.Point(878, 219);
            this.SecRwRtStLmbrHMI2RReq.Name = "SecRwRtStLmbrHMI2RReq";
            this.SecRwRtStLmbrHMI2RReq.Size = new System.Drawing.Size(274, 17);
            this.SecRwRtStLmbrHMI2RReq.TabIndex = 40;
            this.SecRwRtStLmbrHMI2RReq.Text = "Second Row Right Seat Lumbar HMI_2R Request";
            this.SecRwRtStLmbrHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStLmbrHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStLmbrHMI2RReq_CheckedChanged);
            // 
            // BosSWStBkReclnDnwdHMI2RReq
            // 
            this.BosSWStBkReclnDnwdHMI2RReq.AutoSize = true;
            this.BosSWStBkReclnDnwdHMI2RReq.Location = new System.Drawing.Point(878, 177);
            this.BosSWStBkReclnDnwdHMI2RReq.Name = "BosSWStBkReclnDnwdHMI2RReq";
            this.BosSWStBkReclnDnwdHMI2RReq.Size = new System.Drawing.Size(300, 17);
            this.BosSWStBkReclnDnwdHMI2RReq.TabIndex = 39;
            this.BosSWStBkReclnDnwdHMI2RReq.Text = "Boss Button Back Recline Downward HMI_2R Request";
            this.BosSWStBkReclnDnwdHMI2RReq.UseVisualStyleBackColor = true;
            this.BosSWStBkReclnDnwdHMI2RReq.CheckedChanged += new System.EventHandler(this.BosSWStBkReclnDnwdHMI2RReq_CheckedChanged);
            // 
            // BosSWStBkReclnUpwdHMI2RReq
            // 
            this.BosSWStBkReclnUpwdHMI2RReq.AutoSize = true;
            this.BosSWStBkReclnUpwdHMI2RReq.Location = new System.Drawing.Point(878, 135);
            this.BosSWStBkReclnUpwdHMI2RReq.Name = "BosSWStBkReclnUpwdHMI2RReq";
            this.BosSWStBkReclnUpwdHMI2RReq.Size = new System.Drawing.Size(284, 17);
            this.BosSWStBkReclnUpwdHMI2RReq.TabIndex = 38;
            this.BosSWStBkReclnUpwdHMI2RReq.Text = "Boss Button Back Recline Upward HMI_2R Request";
            this.BosSWStBkReclnUpwdHMI2RReq.UseVisualStyleBackColor = true;
            this.BosSWStBkReclnUpwdHMI2RReq.CheckedChanged += new System.EventHandler(this.BosSWStBkReclnUpwdHMI2RReq_CheckedChanged);
            // 
            // BosSWBkwdHMI2RReq
            // 
            this.BosSWBkwdHMI2RReq.AutoSize = true;
            this.BosSWBkwdHMI2RReq.Location = new System.Drawing.Point(878, 93);
            this.BosSWBkwdHMI2RReq.Name = "BosSWBkwdHMI2RReq";
            this.BosSWBkwdHMI2RReq.Size = new System.Drawing.Size(226, 17);
            this.BosSWBkwdHMI2RReq.TabIndex = 37;
            this.BosSWBkwdHMI2RReq.Text = "Boss Button Backward HMI_2R Request";
            this.BosSWBkwdHMI2RReq.UseVisualStyleBackColor = true;
            this.BosSWBkwdHMI2RReq.CheckedChanged += new System.EventHandler(this.BosSWBkwdHMI2RReq_CheckedChanged);
            // 
            // BosSWFrwdHMI2RReq
            // 
            this.BosSWFrwdHMI2RReq.AutoSize = true;
            this.BosSWFrwdHMI2RReq.Location = new System.Drawing.Point(878, 51);
            this.BosSWFrwdHMI2RReq.Name = "BosSWFrwdHMI2RReq";
            this.BosSWFrwdHMI2RReq.Size = new System.Drawing.Size(220, 17);
            this.BosSWFrwdHMI2RReq.TabIndex = 36;
            this.BosSWFrwdHMI2RReq.Text = "Boss Button Forward HMI_2R Request";
            this.BosSWFrwdHMI2RReq.UseVisualStyleBackColor = true;
            this.BosSWFrwdHMI2RReq.CheckedChanged += new System.EventHandler(this.BosSWFrwdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStFtDnwdHMI2RReq
            // 
            this.SecRwRtStFtDnwdHMI2RReq.AutoSize = true;
            this.SecRwRtStFtDnwdHMI2RReq.Location = new System.Drawing.Point(878, 9);
            this.SecRwRtStFtDnwdHMI2RReq.Name = "SecRwRtStFtDnwdHMI2RReq";
            this.SecRwRtStFtDnwdHMI2RReq.Size = new System.Drawing.Size(339, 17);
            this.SecRwRtStFtDnwdHMI2RReq.TabIndex = 35;
            this.SecRwRtStFtDnwdHMI2RReq.Text = "Second Row Right Seat Footrest Downward HMI_2R Request";
            this.SecRwRtStFtDnwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStFtDnwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStFtDnwdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStFtUpwdHMI2RReq
            // 
            this.SecRwRtStFtUpwdHMI2RReq.AutoSize = true;
            this.SecRwRtStFtUpwdHMI2RReq.Location = new System.Drawing.Point(498, 438);
            this.SecRwRtStFtUpwdHMI2RReq.Name = "SecRwRtStFtUpwdHMI2RReq";
            this.SecRwRtStFtUpwdHMI2RReq.Size = new System.Drawing.Size(323, 17);
            this.SecRwRtStFtUpwdHMI2RReq.TabIndex = 34;
            this.SecRwRtStFtUpwdHMI2RReq.Text = "Second Row Right Seat Footrest Upward HMI_2R Request";
            this.SecRwRtStFtUpwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStFtUpwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStFtUpwdHMI2RReq_CheckedChanged);
            // 
            // VIPMdHMI2RRclReq
            // 
            this.VIPMdHMI2RRclReq.AutoSize = true;
            this.VIPMdHMI2RRclReq.Location = new System.Drawing.Point(498, 405);
            this.VIPMdHMI2RRclReq.Name = "VIPMdHMI2RRclReq";
            this.VIPMdHMI2RRclReq.Size = new System.Drawing.Size(195, 17);
            this.VIPMdHMI2RRclReq.TabIndex = 33;
            this.VIPMdHMI2RRclReq.Text = "VIP Mode HMI_2R Recall Request";
            this.VIPMdHMI2RRclReq.UseVisualStyleBackColor = true;
            this.VIPMdHMI2RRclReq.CheckedChanged += new System.EventHandler(this.VIPMdHMI2RRclReq_CheckedChanged);
            // 
            // SecRwRtStArmScrnHMI2RReq
            // 
            this.SecRwRtStArmScrnHMI2RReq.AutoSize = true;
            this.SecRwRtStArmScrnHMI2RReq.Location = new System.Drawing.Point(498, 372);
            this.SecRwRtStArmScrnHMI2RReq.Name = "SecRwRtStArmScrnHMI2RReq";
            this.SecRwRtStArmScrnHMI2RReq.Size = new System.Drawing.Size(357, 17);
            this.SecRwRtStArmScrnHMI2RReq.TabIndex = 32;
            this.SecRwRtStArmScrnHMI2RReq.Text = "Second Row Right Seat Armrest Screen Position HMI_2R Request";
            this.SecRwRtStArmScrnHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStArmScrnHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStArmScrnHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStMemHMI2RReq
            // 
            this.SecRwRtStMemHMI2RReq.AutoSize = true;
            this.SecRwRtStMemHMI2RReq.Location = new System.Drawing.Point(498, 339);
            this.SecRwRtStMemHMI2RReq.Name = "SecRwRtStMemHMI2RReq";
            this.SecRwRtStMemHMI2RReq.Size = new System.Drawing.Size(277, 17);
            this.SecRwRtStMemHMI2RReq.TabIndex = 31;
            this.SecRwRtStMemHMI2RReq.Text = "Second Row Right Seat Memory HMI_2R Request";
            this.SecRwRtStMemHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStMemHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStMemHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStHdrstDnwdHMI2RReq
            // 
            this.SecRwRtStHdrstDnwdHMI2RReq.AutoSize = true;
            this.SecRwRtStHdrstDnwdHMI2RReq.Location = new System.Drawing.Point(498, 306);
            this.SecRwRtStHdrstDnwdHMI2RReq.Name = "SecRwRtStHdrstDnwdHMI2RReq";
            this.SecRwRtStHdrstDnwdHMI2RReq.Size = new System.Drawing.Size(342, 17);
            this.SecRwRtStHdrstDnwdHMI2RReq.TabIndex = 30;
            this.SecRwRtStHdrstDnwdHMI2RReq.Text = "Second Row Right Seat Headrest Downward HMI_2R Request";
            this.SecRwRtStHdrstDnwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStHdrstDnwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStHdrstDnwdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStHdrstUpwdHMI2RReq
            // 
            this.SecRwRtStHdrstUpwdHMI2RReq.AutoSize = true;
            this.SecRwRtStHdrstUpwdHMI2RReq.Location = new System.Drawing.Point(498, 273);
            this.SecRwRtStHdrstUpwdHMI2RReq.Name = "SecRwRtStHdrstUpwdHMI2RReq";
            this.SecRwRtStHdrstUpwdHMI2RReq.Size = new System.Drawing.Size(326, 17);
            this.SecRwRtStHdrstUpwdHMI2RReq.TabIndex = 29;
            this.SecRwRtStHdrstUpwdHMI2RReq.Text = "Second Row Right Seat Headrest Upward HMI_2R Request";
            this.SecRwRtStHdrstUpwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStHdrstUpwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStHdrstUpwdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStRtwdHMI2RReq
            // 
            this.SecRwRtStRtwdHMI2RReq.AutoSize = true;
            this.SecRwRtStRtwdHMI2RReq.Location = new System.Drawing.Point(498, 240);
            this.SecRwRtStRtwdHMI2RReq.Name = "SecRwRtStRtwdHMI2RReq";
            this.SecRwRtStRtwdHMI2RReq.Size = new System.Drawing.Size(290, 17);
            this.SecRwRtStRtwdHMI2RReq.TabIndex = 28;
            this.SecRwRtStRtwdHMI2RReq.Text = "Second Row Right Seat Rightward HMI_2R Request";
            this.SecRwRtStRtwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStRtwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStRtwdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStLtwdHMI2RReq
            // 
            this.SecRwRtStLtwdHMI2RReq.AutoSize = true;
            this.SecRwRtStLtwdHMI2RReq.Location = new System.Drawing.Point(498, 207);
            this.SecRwRtStLtwdHMI2RReq.Name = "SecRwRtStLtwdHMI2RReq";
            this.SecRwRtStLtwdHMI2RReq.Size = new System.Drawing.Size(284, 17);
            this.SecRwRtStLtwdHMI2RReq.TabIndex = 27;
            this.SecRwRtStLtwdHMI2RReq.Text = "Second Row Right Seat Leftward  HMI_2R Request";
            this.SecRwRtStLtwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStLtwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStLtwdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStLgrstDnwdHMI2RReq
            // 
            this.SecRwRtStLgrstDnwdHMI2RReq.AutoSize = true;
            this.SecRwRtStLgrstDnwdHMI2RReq.Location = new System.Drawing.Point(498, 174);
            this.SecRwRtStLgrstDnwdHMI2RReq.Name = "SecRwRtStLgrstDnwdHMI2RReq";
            this.SecRwRtStLgrstDnwdHMI2RReq.Size = new System.Drawing.Size(333, 17);
            this.SecRwRtStLgrstDnwdHMI2RReq.TabIndex = 26;
            this.SecRwRtStLgrstDnwdHMI2RReq.Text = "Second Row Right Seat Legrest Downward HMI_2R Request";
            this.SecRwRtStLgrstDnwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStLgrstDnwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStLgrstDnwdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStLgrstUpwdHMI2RReq
            // 
            this.SecRwRtStLgrstUpwdHMI2RReq.AutoSize = true;
            this.SecRwRtStLgrstUpwdHMI2RReq.Location = new System.Drawing.Point(498, 141);
            this.SecRwRtStLgrstUpwdHMI2RReq.Name = "SecRwRtStLgrstUpwdHMI2RReq";
            this.SecRwRtStLgrstUpwdHMI2RReq.Size = new System.Drawing.Size(317, 17);
            this.SecRwRtStLgrstUpwdHMI2RReq.TabIndex = 25;
            this.SecRwRtStLgrstUpwdHMI2RReq.Text = "Second Row Right Seat Legrest Upward HMI_2R Request";
            this.SecRwRtStLgrstUpwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStLgrstUpwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStLgrstUpwdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStBkReclnDnwdHMI2RReq
            // 
            this.SecRwRtStBkReclnDnwdHMI2RReq.AutoSize = true;
            this.SecRwRtStBkReclnDnwdHMI2RReq.Location = new System.Drawing.Point(498, 108);
            this.SecRwRtStBkReclnDnwdHMI2RReq.Name = "SecRwRtStBkReclnDnwdHMI2RReq";
            this.SecRwRtStBkReclnDnwdHMI2RReq.Size = new System.Drawing.Size(359, 17);
            this.SecRwRtStBkReclnDnwdHMI2RReq.TabIndex = 24;
            this.SecRwRtStBkReclnDnwdHMI2RReq.Text = "Second Row Right Seat Back Recline Downward HMI_2R Request";
            this.SecRwRtStBkReclnDnwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStBkReclnDnwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStBkReclnDnwdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStBkReclnUpwdHMI2RReq
            // 
            this.SecRwRtStBkReclnUpwdHMI2RReq.AutoSize = true;
            this.SecRwRtStBkReclnUpwdHMI2RReq.Location = new System.Drawing.Point(498, 75);
            this.SecRwRtStBkReclnUpwdHMI2RReq.Name = "SecRwRtStBkReclnUpwdHMI2RReq";
            this.SecRwRtStBkReclnUpwdHMI2RReq.Size = new System.Drawing.Size(343, 17);
            this.SecRwRtStBkReclnUpwdHMI2RReq.TabIndex = 23;
            this.SecRwRtStBkReclnUpwdHMI2RReq.Text = "Second Row Right Seat Back Recline Upward HMI_2R Request";
            this.SecRwRtStBkReclnUpwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStBkReclnUpwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStBkReclnUpwdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStBkwdHMI2RReq
            // 
            this.SecRwRtStBkwdHMI2RReq.AutoSize = true;
            this.SecRwRtStBkwdHMI2RReq.Location = new System.Drawing.Point(498, 42);
            this.SecRwRtStBkwdHMI2RReq.Name = "SecRwRtStBkwdHMI2RReq";
            this.SecRwRtStBkwdHMI2RReq.Size = new System.Drawing.Size(285, 17);
            this.SecRwRtStBkwdHMI2RReq.TabIndex = 22;
            this.SecRwRtStBkwdHMI2RReq.Text = "Second Row Right Seat Backward HMI_2R Request";
            this.SecRwRtStBkwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStBkwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStBkwdHMI2RReq_CheckedChanged);
            // 
            // SecRwRtStFrwdHMI2RReq
            // 
            this.SecRwRtStFrwdHMI2RReq.AutoSize = true;
            this.SecRwRtStFrwdHMI2RReq.Location = new System.Drawing.Point(498, 9);
            this.SecRwRtStFrwdHMI2RReq.Name = "SecRwRtStFrwdHMI2RReq";
            this.SecRwRtStFrwdHMI2RReq.Size = new System.Drawing.Size(279, 17);
            this.SecRwRtStFrwdHMI2RReq.TabIndex = 21;
            this.SecRwRtStFrwdHMI2RReq.Text = "Second Row Right Seat Forward HMI_2R Request";
            this.SecRwRtStFrwdHMI2RReq.UseVisualStyleBackColor = true;
            this.SecRwRtStFrwdHMI2RReq.CheckedChanged += new System.EventHandler(this.SecRwRtStFrwdHMI2RReq_CheckedChanged);
            // 
            // SecRwLtStChldLkLReq
            // 
            this.SecRwLtStChldLkLReq.AutoSize = true;
            this.SecRwLtStChldLkLReq.Location = new System.Drawing.Point(19, 575);
            this.SecRwLtStChldLkLReq.Name = "SecRwLtStChldLkLReq";
            this.SecRwLtStChldLkLReq.Size = new System.Drawing.Size(287, 17);
            this.SecRwLtStChldLkLReq.TabIndex = 20;
            this.SecRwLtStChldLkLReq.Text = "Second Row Left Seat Child Restraint Lock Request";
            this.SecRwLtStChldLkLReq.UseVisualStyleBackColor = true;
            this.SecRwLtStChldLkLReq.CheckedChanged += new System.EventHandler(this.SecRwLtStChldLkLReq_CheckedChanged);
            // 
            // RcvyMdHMI2LRclReq
            // 
            this.RcvyMdHMI2LRclReq.AutoSize = true;
            this.RcvyMdHMI2LRclReq.Location = new System.Drawing.Point(19, 548);
            this.RcvyMdHMI2LRclReq.Name = "RcvyMdHMI2LRclReq";
            this.RcvyMdHMI2LRclReq.Size = new System.Drawing.Size(222, 17);
            this.RcvyMdHMI2LRclReq.TabIndex = 19;
            this.RcvyMdHMI2LRclReq.Text = "Recovery Mode HMI_2L Recall Request";
            this.RcvyMdHMI2LRclReq.UseVisualStyleBackColor = true;
            this.RcvyMdHMI2LRclReq.CheckedChanged += new System.EventHandler(this.RcvyMdHMI2LRclReq_CheckedChanged);
            // 
            // AcsMdExtMdHMI2LRclReq
            // 
            this.AcsMdExtMdHMI2LRclReq.AutoSize = true;
            this.AcsMdExtMdHMI2LRclReq.Location = new System.Drawing.Point(19, 521);
            this.AcsMdExtMdHMI2LRclReq.Name = "AcsMdExtMdHMI2LRclReq";
            this.AcsMdExtMdHMI2LRclReq.Size = new System.Drawing.Size(220, 17);
            this.AcsMdExtMdHMI2LRclReq.TabIndex = 18;
            this.AcsMdExtMdHMI2LRclReq.Text = "Easy Exit Mode HMI_2L Recall Request";
            this.AcsMdExtMdHMI2LRclReq.UseVisualStyleBackColor = true;
            this.AcsMdExtMdHMI2LRclReq.CheckedChanged += new System.EventHandler(this.AcsMdExtMdHMI2LRclReq_CheckedChanged);
            // 
            // VIPMdHMI2LRclReq
            // 
            this.VIPMdHMI2LRclReq.AutoSize = true;
            this.VIPMdHMI2LRclReq.Location = new System.Drawing.Point(19, 494);
            this.VIPMdHMI2LRclReq.Name = "VIPMdHMI2LRclReq";
            this.VIPMdHMI2LRclReq.Size = new System.Drawing.Size(193, 17);
            this.VIPMdHMI2LRclReq.TabIndex = 17;
            this.VIPMdHMI2LRclReq.Text = "VIP Mode HMI_2L Recall Request";
            this.VIPMdHMI2LRclReq.UseVisualStyleBackColor = true;
            this.VIPMdHMI2LRclReq.CheckedChanged += new System.EventHandler(this.VIPMdHMI2LRclReq_CheckedChanged);
            // 
            // SecRwLtStArmScrnHMI2LReq
            // 
            this.SecRwLtStArmScrnHMI2LReq.AutoSize = true;
            this.SecRwLtStArmScrnHMI2LReq.Location = new System.Drawing.Point(19, 467);
            this.SecRwLtStArmScrnHMI2LReq.Name = "SecRwLtStArmScrnHMI2LReq";
            this.SecRwLtStArmScrnHMI2LReq.Size = new System.Drawing.Size(346, 17);
            this.SecRwLtStArmScrnHMI2LReq.TabIndex = 16;
            this.SecRwLtStArmScrnHMI2LReq.Text = "Second Row Left Seat Armrest Screen Position HMI_2L Request";
            this.SecRwLtStArmScrnHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStArmScrnHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStArmScrnHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStFtDnwdHMI2LReq
            // 
            this.SecRwLtStFtDnwdHMI2LReq.AutoSize = true;
            this.SecRwLtStFtDnwdHMI2LReq.Location = new System.Drawing.Point(19, 440);
            this.SecRwLtStFtDnwdHMI2LReq.Name = "SecRwLtStFtDnwdHMI2LReq";
            this.SecRwLtStFtDnwdHMI2LReq.Size = new System.Drawing.Size(328, 17);
            this.SecRwLtStFtDnwdHMI2LReq.TabIndex = 15;
            this.SecRwLtStFtDnwdHMI2LReq.Text = "Second Row Left Seat Footrest Downward HMI_2L Request";
            this.SecRwLtStFtDnwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStFtDnwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStFtDnwdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStFtUpwdHMI2LReq
            // 
            this.SecRwLtStFtUpwdHMI2LReq.AutoSize = true;
            this.SecRwLtStFtUpwdHMI2LReq.Location = new System.Drawing.Point(19, 413);
            this.SecRwLtStFtUpwdHMI2LReq.Name = "SecRwLtStFtUpwdHMI2LReq";
            this.SecRwLtStFtUpwdHMI2LReq.Size = new System.Drawing.Size(312, 17);
            this.SecRwLtStFtUpwdHMI2LReq.TabIndex = 14;
            this.SecRwLtStFtUpwdHMI2LReq.Text = "Second Row Left Seat Footrest Upward HMI_2L Request";
            this.SecRwLtStFtUpwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStFtUpwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStFtUpwdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStMassStrsHMI2LReq
            // 
            this.SecRwLtStMassStrsHMI2LReq.AutoSize = true;
            this.SecRwLtStMassStrsHMI2LReq.Location = new System.Drawing.Point(19, 386);
            this.SecRwLtStMassStrsHMI2LReq.Name = "SecRwLtStMassStrsHMI2LReq";
            this.SecRwLtStMassStrsHMI2LReq.Size = new System.Drawing.Size(303, 17);
            this.SecRwLtStMassStrsHMI2LReq.TabIndex = 13;
            this.SecRwLtStMassStrsHMI2LReq.Text = "Second Row Left Seat Massage Stress HMI_2L Request";
            this.SecRwLtStMassStrsHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStMassStrsHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStMassStrsHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStMassMdHMI2LReq
            // 
            this.SecRwLtStMassMdHMI2LReq.AutoSize = true;
            this.SecRwLtStMassMdHMI2LReq.Location = new System.Drawing.Point(19, 359);
            this.SecRwLtStMassMdHMI2LReq.Name = "SecRwLtStMassMdHMI2LReq";
            this.SecRwLtStMassMdHMI2LReq.Size = new System.Drawing.Size(303, 17);
            this.SecRwLtStMassMdHMI2LReq.TabIndex = 12;
            this.SecRwLtStMassMdHMI2LReq.Text = "Second Row Left Seat Massage Mode HMI_2L Request";
            this.SecRwLtStMassMdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStMassMdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStMassMdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStLmbrHMI2LReq
            // 
            this.SecRwLtStLmbrHMI2LReq.AutoSize = true;
            this.SecRwLtStLmbrHMI2LReq.Location = new System.Drawing.Point(19, 332);
            this.SecRwLtStLmbrHMI2LReq.Name = "SecRwLtStLmbrHMI2LReq";
            this.SecRwLtStLmbrHMI2LReq.Size = new System.Drawing.Size(263, 17);
            this.SecRwLtStLmbrHMI2LReq.TabIndex = 11;
            this.SecRwLtStLmbrHMI2LReq.Text = "Second Row Left Seat Lumbar HMI_2L Request";
            this.SecRwLtStLmbrHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStLmbrHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStLmbrHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStMemHMI2LReq
            // 
            this.SecRwLtStMemHMI2LReq.AutoSize = true;
            this.SecRwLtStMemHMI2LReq.Location = new System.Drawing.Point(19, 305);
            this.SecRwLtStMemHMI2LReq.Name = "SecRwLtStMemHMI2LReq";
            this.SecRwLtStMemHMI2LReq.Size = new System.Drawing.Size(266, 17);
            this.SecRwLtStMemHMI2LReq.TabIndex = 10;
            this.SecRwLtStMemHMI2LReq.Text = "Second Row Left Seat Memory HMI_2L Request";
            this.SecRwLtStMemHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStMemHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStMemHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStHdrstDnwdHMI2LReq
            // 
            this.SecRwLtStHdrstDnwdHMI2LReq.AutoSize = true;
            this.SecRwLtStHdrstDnwdHMI2LReq.Location = new System.Drawing.Point(19, 278);
            this.SecRwLtStHdrstDnwdHMI2LReq.Name = "SecRwLtStHdrstDnwdHMI2LReq";
            this.SecRwLtStHdrstDnwdHMI2LReq.Size = new System.Drawing.Size(331, 17);
            this.SecRwLtStHdrstDnwdHMI2LReq.TabIndex = 9;
            this.SecRwLtStHdrstDnwdHMI2LReq.Text = "Second Row Left Seat Headrest Downward HMI_2L Request";
            this.SecRwLtStHdrstDnwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStHdrstDnwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStHdrstDnwdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStHdrstUpwdHMI2LReq
            // 
            this.SecRwLtStHdrstUpwdHMI2LReq.AutoSize = true;
            this.SecRwLtStHdrstUpwdHMI2LReq.Location = new System.Drawing.Point(19, 251);
            this.SecRwLtStHdrstUpwdHMI2LReq.Name = "SecRwLtStHdrstUpwdHMI2LReq";
            this.SecRwLtStHdrstUpwdHMI2LReq.Size = new System.Drawing.Size(315, 17);
            this.SecRwLtStHdrstUpwdHMI2LReq.TabIndex = 8;
            this.SecRwLtStHdrstUpwdHMI2LReq.Text = "Second Row Left Seat Headrest Upward HMI_2L Request";
            this.SecRwLtStHdrstUpwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStHdrstUpwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStHdrstUpwdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStRtwdHMI2LReq
            // 
            this.SecRwLtStRtwdHMI2LReq.AutoSize = true;
            this.SecRwLtStRtwdHMI2LReq.Location = new System.Drawing.Point(19, 224);
            this.SecRwLtStRtwdHMI2LReq.Name = "SecRwLtStRtwdHMI2LReq";
            this.SecRwLtStRtwdHMI2LReq.Size = new System.Drawing.Size(279, 17);
            this.SecRwLtStRtwdHMI2LReq.TabIndex = 7;
            this.SecRwLtStRtwdHMI2LReq.Text = "Second Row Left Seat Rightward HMI_2L Request";
            this.SecRwLtStRtwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStRtwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStRtwdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStLtwdHMI2LReq
            // 
            this.SecRwLtStLtwdHMI2LReq.AutoSize = true;
            this.SecRwLtStLtwdHMI2LReq.Location = new System.Drawing.Point(19, 197);
            this.SecRwLtStLtwdHMI2LReq.Name = "SecRwLtStLtwdHMI2LReq";
            this.SecRwLtStLtwdHMI2LReq.Size = new System.Drawing.Size(270, 17);
            this.SecRwLtStLtwdHMI2LReq.TabIndex = 6;
            this.SecRwLtStLtwdHMI2LReq.Text = "Second Row Left Seat Leftward HMI_2L Request";
            this.SecRwLtStLtwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStLtwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStLtwdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStLgrstDnwdHMI2LReq
            // 
            this.SecRwLtStLgrstDnwdHMI2LReq.AutoSize = true;
            this.SecRwLtStLgrstDnwdHMI2LReq.Location = new System.Drawing.Point(19, 170);
            this.SecRwLtStLgrstDnwdHMI2LReq.Name = "SecRwLtStLgrstDnwdHMI2LReq";
            this.SecRwLtStLgrstDnwdHMI2LReq.Size = new System.Drawing.Size(322, 17);
            this.SecRwLtStLgrstDnwdHMI2LReq.TabIndex = 5;
            this.SecRwLtStLgrstDnwdHMI2LReq.Text = "Second Row Left Seat Legrest Downward HMI_2L Request";
            this.SecRwLtStLgrstDnwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStLgrstDnwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStLgrstDnwdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStLgrstUpwdHMI2LReq
            // 
            this.SecRwLtStLgrstUpwdHMI2LReq.AutoSize = true;
            this.SecRwLtStLgrstUpwdHMI2LReq.Location = new System.Drawing.Point(19, 143);
            this.SecRwLtStLgrstUpwdHMI2LReq.Name = "SecRwLtStLgrstUpwdHMI2LReq";
            this.SecRwLtStLgrstUpwdHMI2LReq.Size = new System.Drawing.Size(306, 17);
            this.SecRwLtStLgrstUpwdHMI2LReq.TabIndex = 4;
            this.SecRwLtStLgrstUpwdHMI2LReq.Text = "Second Row Left Seat Legrest Upward HMI_2L Request";
            this.SecRwLtStLgrstUpwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStLgrstUpwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStLgrstUpwdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStBkReclnDnwdHMI2LReq
            // 
            this.SecRwLtStBkReclnDnwdHMI2LReq.AutoSize = true;
            this.SecRwLtStBkReclnDnwdHMI2LReq.Location = new System.Drawing.Point(19, 116);
            this.SecRwLtStBkReclnDnwdHMI2LReq.Name = "SecRwLtStBkReclnDnwdHMI2LReq";
            this.SecRwLtStBkReclnDnwdHMI2LReq.Size = new System.Drawing.Size(348, 17);
            this.SecRwLtStBkReclnDnwdHMI2LReq.TabIndex = 3;
            this.SecRwLtStBkReclnDnwdHMI2LReq.Text = "Second Row Left Seat Back Recline Downward HMI_2L Request";
            this.SecRwLtStBkReclnDnwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStBkReclnDnwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStBkReclnDnwdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStBkReclnUpwdHMI2LReq
            // 
            this.SecRwLtStBkReclnUpwdHMI2LReq.AutoSize = true;
            this.SecRwLtStBkReclnUpwdHMI2LReq.Location = new System.Drawing.Point(19, 89);
            this.SecRwLtStBkReclnUpwdHMI2LReq.Name = "SecRwLtStBkReclnUpwdHMI2LReq";
            this.SecRwLtStBkReclnUpwdHMI2LReq.Size = new System.Drawing.Size(332, 17);
            this.SecRwLtStBkReclnUpwdHMI2LReq.TabIndex = 2;
            this.SecRwLtStBkReclnUpwdHMI2LReq.Text = "Second Row Left Seat Back Recline Upward HMI_2L Request";
            this.SecRwLtStBkReclnUpwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStBkReclnUpwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStBkReclnUpwdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStBkwdHMI2LReq
            // 
            this.SecRwLtStBkwdHMI2LReq.AutoSize = true;
            this.SecRwLtStBkwdHMI2LReq.Location = new System.Drawing.Point(19, 62);
            this.SecRwLtStBkwdHMI2LReq.Name = "SecRwLtStBkwdHMI2LReq";
            this.SecRwLtStBkwdHMI2LReq.Size = new System.Drawing.Size(274, 17);
            this.SecRwLtStBkwdHMI2LReq.TabIndex = 1;
            this.SecRwLtStBkwdHMI2LReq.Text = "Second Row Left Seat Backward HMI_2L Request";
            this.SecRwLtStBkwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStBkwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStBkwdHMI2LReq_CheckedChanged);
            // 
            // SecRwLtStFrwdHMI2LReq
            // 
            this.SecRwLtStFrwdHMI2LReq.AutoSize = true;
            this.SecRwLtStFrwdHMI2LReq.Location = new System.Drawing.Point(19, 35);
            this.SecRwLtStFrwdHMI2LReq.Name = "SecRwLtStFrwdHMI2LReq";
            this.SecRwLtStFrwdHMI2LReq.Size = new System.Drawing.Size(268, 17);
            this.SecRwLtStFrwdHMI2LReq.TabIndex = 0;
            this.SecRwLtStFrwdHMI2LReq.Text = "Second Row Left Seat Forward HMI_2L Request";
            this.SecRwLtStFrwdHMI2LReq.UseVisualStyleBackColor = true;
            this.SecRwLtStFrwdHMI2LReq.CheckedChanged += new System.EventHandler(this.SecRwLtStFrwdHMI2LReq_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1354, 597);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "诊断服务";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 698);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Hexadecimal = true;
            this.numericUpDown1.Location = new System.Drawing.Point(84, 699);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 22);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            1592,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 683);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID";
            // 
            // cycle
            // 
            this.cycle.Location = new System.Drawing.Point(185, 698);
            this.cycle.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cycle.Name = "cycle";
            this.cycle.Size = new System.Drawing.Size(82, 22);
            this.cycle.TabIndex = 22;
            this.cycle.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 682);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "周期(ms)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 704);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1369, 749);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cycle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StandardBar);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "557";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWnd_FormClosing);
            this.Shown += new System.EventHandler(this.MainWnd_Shown);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.TransmitPopup.ResumeLayout(false);
            this.ReceivePopup.ResumeLayout(false);
            this.StandardBar.ResumeLayout(false);
            this.StandardBar.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ContextMenuStrip TransmitPopup;
        private System.Windows.Forms.ToolStripMenuItem PM_Transmit_New;
        private System.Windows.Forms.ToolStripMenuItem PM_Transmit_Edit;
        private System.Windows.Forms.ToolStripMenuItem PM_Transmit_Delete;
        private System.Windows.Forms.ToolStripMenuItem PM_Transmit_ClearAll;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.ToolStripStatusLabel SB_LIN_Connect;
        private System.Windows.Forms.ToolStripStatusLabel SB_LIN_Status;
        private System.Windows.Forms.ToolStripStatusLabel SB_LIN_Mode;
        private System.Windows.Forms.ToolStripStatusLabel SB_LIN_Channel;
        private System.Windows.Forms.ContextMenuStrip ReceivePopup;
        private System.Windows.Forms.ToolStripMenuItem PM_Tools_SelfReceive;
        private System.Windows.Forms.ToolStripStatusLabel SB_LIN_Overruns;
        private System.Windows.Forms.ToolStripMenuItem PM_Receive_Delete;
        private System.Windows.Forms.ToolStripButton TB_File_New;
        private System.Windows.Forms.ToolStripButton TB_File_Open;
        private System.Windows.Forms.ToolStripButton TB_File_Save;
        private System.Windows.Forms.ToolStripButton TB_File_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TB_LIN_Connect;
        private System.Windows.Forms.ToolStripButton TB_LIN_Reset;
        private System.Windows.Forms.ToolStripButton TB_Transmit_AddNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TB_Help_Contents;
        private System.Windows.Forms.ToolStripButton TB_Help_About;
        private System.Windows.Forms.ToolStrip StandardBar;
        private System.Windows.Forms.ToolStripMenuItem MM_File;
        private System.Windows.Forms.ToolStripMenuItem MM_File_New;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MM_File_Open;
        private System.Windows.Forms.ToolStripMenuItem MM_File_Save;
        private System.Windows.Forms.ToolStripMenuItem MM_File_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MM_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem MM_LIN;
        private System.Windows.Forms.ToolStripMenuItem MM_LIN_Connect;
        private System.Windows.Forms.ToolStripMenuItem MM_LIN_Disconnect;
        private System.Windows.Forms.ToolStripMenuItem MM_LIN_Reset;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MM_LIN_GoToSleep;
        private System.Windows.Forms.ToolStripMenuItem MM_LIN_WakeUp;
        private System.Windows.Forms.ToolStripMenuItem MM_Transmit;
        private System.Windows.Forms.ToolStripMenuItem MM_Transmit_New;
        private System.Windows.Forms.ToolStripMenuItem MM_Transmit_Edit;
        private System.Windows.Forms.ToolStripMenuItem MM_Transmit_Delete;
        private System.Windows.Forms.ToolStripMenuItem MM_Transmit_ClearAll;
        private System.Windows.Forms.ToolStripMenuItem MM_Transmit_Send;
        private System.Windows.Forms.ToolStripMenuItem MM_Tools;
        private System.Windows.Forms.ToolStripMenuItem MM_Tools_ResetGFT;
        private System.Windows.Forms.ToolStripMenuItem MM_Help;
        private System.Windows.Forms.ToolStripMenuItem MM_Help_Contents;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem MM_Help_About;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripButton Can_connect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox L_ReclineRrwdCustSeltn;
        private System.Windows.Forms.CheckBox L_ReclineFrwdCustSeltn;
        private System.Windows.Forms.CheckBox L_CushRrDwnCustSeltn;
        private System.Windows.Forms.CheckBox L_CushRrUpCustSeltn;
        private System.Windows.Forms.CheckBox L_CushFrtDwnCustSeltn;
        private System.Windows.Forms.CheckBox L_CushFrtUpCustSeltn;
        private System.Windows.Forms.CheckBox L_SeatRrwdCustSeltn;
        private System.Windows.Forms.CheckBox L_SeatFrwdCustSeltn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox R_ReclineRrwdCustSeltn;
        private System.Windows.Forms.CheckBox R_ReclineFrwdCustSeltn;
        private System.Windows.Forms.CheckBox R_SeatRrwdCustSeltn;
        private System.Windows.Forms.CheckBox R_SeatFrwdCustSeltn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStLgrstDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStLgrstUpwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStBkReclnDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStBkReclnUpwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStBkwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStFrwdSwActv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStLgrstDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStLgrstUpwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStBkReclnDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStBkReclnUpwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStBkwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStFrwdSwActv;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox SPS_3L_ThdRwStBkReclnDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3L_ThdRwStBkReclnUpwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3L_ThdRStBkwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3L_ThdRStFrwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3L_ThdRStExpdSwActv;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox SPS_3R_ThdRwRtStBkwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3R_ThdRwRtStFrwdSwActv;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label DrvStCshnRrUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label DrvStCshnRrUpwdDnwdPosV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label DrvStCshnFrntUpwdDnwdPosV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DrvStCshnRrUpwdDnwdPos;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox PassStBkReclnUpwdDnwdPos;
        private System.Windows.Forms.TextBox PassStFrwdBkwdPos;
        private System.Windows.Forms.Label PassStBkReclnUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label PassStBkReclnUpwdDnwdPosV;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label PassStFrwdBkwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label PassStFrwdBkwdPosV;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox SecRwLtStBkReclnUpwdDnwdPos;
        private System.Windows.Forms.TextBox SecRwLtStFrwdBkwdPos;
        private System.Windows.Forms.Label SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label SecRwLtStBkReclnUpwdDnwdPosV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SecRwLtStFrwdBkwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label SecRwLtStFrwdBkwdPosV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label SecRwLtStCshnFrntUpwdDnwdPosV;
        private System.Windows.Forms.TextBox SecRwLtStCshnFrntUpwdDnwdPos;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label SecRwLtStLgrstUpwdDnwdPosV;
        private System.Windows.Forms.TextBox SecRwLtStLgrstUpwdDnwdPos;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox SecRwRtStBkReclnUpwdDnwdPos;
        private System.Windows.Forms.TextBox SecRwRtStFrwdBkwdPos;
        private System.Windows.Forms.Label SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label SecRwRtStBkReclnUpwdDnwdPosV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SecRwRtStFrwdBkwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label SecRwRtStFrwdBkwdPosV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label SecRwRtStCshnFrntUpwdDnwdPosV;
        private System.Windows.Forms.TextBox SecRwRtStCshnFrntUpwdDnwdPos;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label SecRwRtStLgrstUpwdDnwdPosV;
        private System.Windows.Forms.TextBox SecRwRtStLgrstUpwdDnwdPos;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox ThdRwRtStBkReclnUpwdDnwdPos;
        private System.Windows.Forms.TextBox ThdRwRtStFrwdBkwdPos;
        private System.Windows.Forms.Label ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label ThdRwRtStBkReclnUpwdDnwdPosV;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label ThdRwRtStFrwdBkwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label ThdRwRtStFrwdBkwdPosV;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label ThdRwRtStCshnFldUpwdDnwdPosV;
        private System.Windows.Forms.TextBox ThdRwRtStCshnFldUpwdDnwdPos;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox ThdRwLtStBkReclnUpwdDnwdPos;
        private System.Windows.Forms.TextBox ThdRwLtStFrwdBkwdPos;
        private System.Windows.Forms.Label ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label ThdRwLtStBkReclnUpwdDnwdPosV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ThdRwLtStFrwdBkwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label ThdRwLtStFrwdBkwdPosV;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label ThdRwLtStCshnFldUpwdDnwdPosV;
        private System.Windows.Forms.TextBox ThdRwLtStCshnFldUpwdDnwdPos;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox SecRwLtStChldLkLReq;
        private System.Windows.Forms.CheckBox RcvyMdHMI2LRclReq;
        private System.Windows.Forms.CheckBox AcsMdExtMdHMI2LRclReq;
        private System.Windows.Forms.CheckBox VIPMdHMI2LRclReq;
        private System.Windows.Forms.CheckBox SecRwLtStArmScrnHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStFtDnwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStFtUpwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStMassStrsHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStMassMdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStLmbrHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStMemHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStHdrstDnwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStHdrstUpwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStRtwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStLtwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStLgrstDnwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStLgrstUpwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStBkReclnDnwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStBkReclnUpwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStBkwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwLtStFrwdHMI2LReq;
        private System.Windows.Forms.CheckBox SecRwRtStChldLkLReq;
        private System.Windows.Forms.CheckBox RcvyMdHMI2RRclReq;
        private System.Windows.Forms.CheckBox AcsMdExtMdHMI2RRclReq;
        private System.Windows.Forms.CheckBox SecRwRtStMassStrsHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStMassMdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStLmbrHMI2RReq;
        private System.Windows.Forms.CheckBox BosSWStBkReclnDnwdHMI2RReq;
        private System.Windows.Forms.CheckBox BosSWStBkReclnUpwdHMI2RReq;
        private System.Windows.Forms.CheckBox BosSWBkwdHMI2RReq;
        private System.Windows.Forms.CheckBox BosSWFrwdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStFtDnwdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStFtUpwdHMI2RReq;
        private System.Windows.Forms.CheckBox VIPMdHMI2RRclReq;
        private System.Windows.Forms.CheckBox SecRwRtStArmScrnHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStMemHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStHdrstDnwdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStHdrstUpwdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStRtwdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStLtwdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStLgrstDnwdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStLgrstUpwdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStBkReclnDnwdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStBkReclnUpwdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStBkwdHMI2RReq;
        private System.Windows.Forms.CheckBox SecRwRtStFrwdHMI2RReq;
        private System.Windows.Forms.TextBox DrvStBkReclnUpwdDnwdPos;
        private System.Windows.Forms.TextBox DrvStFrwdBkwdPos;
        private System.Windows.Forms.Label DrvStBkReclnUpwdDnwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label DrvStBkReclnUpwdDnwdPosV;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label DrvStFrwdBkwdSnsrHmPosLrnd;
        private System.Windows.Forms.Label DrvStFrwdBkwdPosV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox SecRwLtStHtVntDtyCyclStat;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.CheckBox L_CushCloseSeltn;
        private System.Windows.Forms.CheckBox L_CushOpenSeltn;
        private System.Windows.Forms.CheckBox R_CushCloseSeltn;
        private System.Windows.Forms.CheckBox R_CushOpenSeltn;
        private System.Windows.Forms.TextBox DrvStCshnFrntUpwdDnwdPos;
        private System.Windows.Forms.Label SecRwLtStLgExtOutInSnsrHmPosLrnd;
        private System.Windows.Forms.Label SecRwLtStLgExtOutInPosV;
        private System.Windows.Forms.TextBox SecRwLtStLgexInOutPos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStZgvyDownSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStZgvyUpSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStLgextInSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStLgextOutSwActv;
        private System.Windows.Forms.Label SecRwRtStLgExtOutInSnsrHmPosLrnd;
        private System.Windows.Forms.Label SecRwRtStLgExtOutInPosV;
        private System.Windows.Forms.TextBox SecRwRtStLgexInOutPos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ComboBox Row1L_Heat_Vent_Status;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.ComboBox Row1R_Heat_Vent_Status;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox SecRwRtStHtVntDtyCyclStat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStLgextInSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStLgextOutSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStZgvyDownSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStZgvyUpSwActv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SecRwLtStVntDtyCycl;
        private System.Windows.Forms.TextBox SecRwLtStHtDtyCycl;
        private System.Windows.Forms.TextBox SecRwRtStHtDtyCycl;
        private System.Windows.Forms.TextBox SecRwRtStVntDtyCycl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Row1L_Heat_Req;
        private System.Windows.Forms.TextBox Row1L_Vent_Req;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Row1R_Heat_Req;
        private System.Windows.Forms.TextBox Row1R_Vent_Req;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox SPS_3R_ThdRRtStExpdSwActv;
        private System.Windows.Forms.CheckBox SPS_3R_ThdRwRtStBkReclnDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3R_ThdRwRtStBkReclnUpwdSwActv;
    }
}

