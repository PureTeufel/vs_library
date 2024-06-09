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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Save = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FinishCount = new System.Windows.Forms.NumericUpDown();
            this.CycleTimes = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DoublePos52 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.DoublePos51 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.DoublePos50 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.DoublePos49 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.DoublePos48 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.DoublePos47 = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.DoublePos46 = new System.Windows.Forms.TextBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.DoublePos45 = new System.Windows.Forms.TextBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.DoublePos44 = new System.Windows.Forms.TextBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.DoublePos43 = new System.Windows.Forms.TextBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.DoublePos42 = new System.Windows.Forms.TextBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.DoublePos41 = new System.Windows.Forms.TextBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.DoublePos40 = new System.Windows.Forms.TextBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.DoublePos39 = new System.Windows.Forms.TextBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.DoublePos38 = new System.Windows.Forms.TextBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.DoublePos37 = new System.Windows.Forms.TextBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.DoublePos36 = new System.Windows.Forms.TextBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.DoublePos35 = new System.Windows.Forms.TextBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.DoublePos34 = new System.Windows.Forms.TextBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.DoublePos33 = new System.Windows.Forms.TextBox();
            this.Seat1 = new System.Windows.Forms.ComboBox();
            this.DoublePos32 = new System.Windows.Forms.TextBox();
            this.Seat2 = new System.Windows.Forms.ComboBox();
            this.DoublePos31 = new System.Windows.Forms.TextBox();
            this.Seat3 = new System.Windows.Forms.ComboBox();
            this.DoublePos30 = new System.Windows.Forms.TextBox();
            this.Seat4 = new System.Windows.Forms.ComboBox();
            this.DoublePos29 = new System.Windows.Forms.TextBox();
            this.Seat5 = new System.Windows.Forms.ComboBox();
            this.DoublePos28 = new System.Windows.Forms.TextBox();
            this.Seat6 = new System.Windows.Forms.ComboBox();
            this.DoublePos27 = new System.Windows.Forms.TextBox();
            this.Seat7 = new System.Windows.Forms.ComboBox();
            this.DoublePos26 = new System.Windows.Forms.TextBox();
            this.Seat8 = new System.Windows.Forms.ComboBox();
            this.DoublePos25 = new System.Windows.Forms.TextBox();
            this.Seat9 = new System.Windows.Forms.ComboBox();
            this.DoublePos24 = new System.Windows.Forms.TextBox();
            this.Seat10 = new System.Windows.Forms.ComboBox();
            this.DoublePos23 = new System.Windows.Forms.TextBox();
            this.Seat11 = new System.Windows.Forms.ComboBox();
            this.DoublePos22 = new System.Windows.Forms.TextBox();
            this.Seat12 = new System.Windows.Forms.ComboBox();
            this.DoublePos21 = new System.Windows.Forms.TextBox();
            this.Seat13 = new System.Windows.Forms.ComboBox();
            this.DoublePos20 = new System.Windows.Forms.TextBox();
            this.Seat14 = new System.Windows.Forms.ComboBox();
            this.DoublePos19 = new System.Windows.Forms.TextBox();
            this.Seat15 = new System.Windows.Forms.ComboBox();
            this.DoublePos18 = new System.Windows.Forms.TextBox();
            this.Seat16 = new System.Windows.Forms.ComboBox();
            this.DoublePos17 = new System.Windows.Forms.TextBox();
            this.Seat17 = new System.Windows.Forms.ComboBox();
            this.DoublePos16 = new System.Windows.Forms.TextBox();
            this.Seat18 = new System.Windows.Forms.ComboBox();
            this.DoublePos15 = new System.Windows.Forms.TextBox();
            this.Seat19 = new System.Windows.Forms.ComboBox();
            this.DoublePos14 = new System.Windows.Forms.TextBox();
            this.Seat20 = new System.Windows.Forms.ComboBox();
            this.DoublePos13 = new System.Windows.Forms.TextBox();
            this.Motor1 = new System.Windows.Forms.ComboBox();
            this.DoublePos12 = new System.Windows.Forms.TextBox();
            this.Motor2 = new System.Windows.Forms.ComboBox();
            this.DoublePos11 = new System.Windows.Forms.TextBox();
            this.Motor3 = new System.Windows.Forms.ComboBox();
            this.DoublePos10 = new System.Windows.Forms.TextBox();
            this.Motor4 = new System.Windows.Forms.ComboBox();
            this.DoublePos9 = new System.Windows.Forms.TextBox();
            this.Motor5 = new System.Windows.Forms.ComboBox();
            this.DoublePos8 = new System.Windows.Forms.TextBox();
            this.Motor6 = new System.Windows.Forms.ComboBox();
            this.DoublePos7 = new System.Windows.Forms.TextBox();
            this.Motor7 = new System.Windows.Forms.ComboBox();
            this.DoublePos6 = new System.Windows.Forms.TextBox();
            this.Motor8 = new System.Windows.Forms.ComboBox();
            this.DoublePos5 = new System.Windows.Forms.TextBox();
            this.Motor9 = new System.Windows.Forms.ComboBox();
            this.DoublePos4 = new System.Windows.Forms.TextBox();
            this.Motor10 = new System.Windows.Forms.ComboBox();
            this.DoublePos3 = new System.Windows.Forms.TextBox();
            this.Motor11 = new System.Windows.Forms.ComboBox();
            this.DoublePos2 = new System.Windows.Forms.TextBox();
            this.Motor12 = new System.Windows.Forms.ComboBox();
            this.DoublePos1 = new System.Windows.Forms.TextBox();
            this.Motor13 = new System.Windows.Forms.ComboBox();
            this.Pos1 = new System.Windows.Forms.NumericUpDown();
            this.Motor14 = new System.Windows.Forms.ComboBox();
            this.SecRwRtStMassStrsHMI2RReq = new System.Windows.Forms.ComboBox();
            this.Motor15 = new System.Windows.Forms.ComboBox();
            this.SecRwRtStMassMdHMI2RReq = new System.Windows.Forms.ComboBox();
            this.Motor16 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Motor17 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Motor18 = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.R3_HeatOFF = new System.Windows.Forms.RadioButton();
            this.R3_Heat3 = new System.Windows.Forms.RadioButton();
            this.R3_Heat2 = new System.Windows.Forms.RadioButton();
            this.R3_Heat1 = new System.Windows.Forms.RadioButton();
            this.Motor19 = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.R3_VentOFF = new System.Windows.Forms.RadioButton();
            this.R3_Vent3 = new System.Windows.Forms.RadioButton();
            this.R3_Vent2 = new System.Windows.Forms.RadioButton();
            this.R3_Vent1 = new System.Windows.Forms.RadioButton();
            this.Motor20 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.L3_HeatOFF = new System.Windows.Forms.RadioButton();
            this.L3_Heat3 = new System.Windows.Forms.RadioButton();
            this.L3_Heat2 = new System.Windows.Forms.RadioButton();
            this.L3_Heat1 = new System.Windows.Forms.RadioButton();
            this.Start1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.L3_VentOFF = new System.Windows.Forms.RadioButton();
            this.L3_Vent3 = new System.Windows.Forms.RadioButton();
            this.L3_Vent2 = new System.Windows.Forms.RadioButton();
            this.L3_Vent1 = new System.Windows.Forms.RadioButton();
            this.Start2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.R2_HeatOFF = new System.Windows.Forms.RadioButton();
            this.R2_Heat3 = new System.Windows.Forms.RadioButton();
            this.R2_Heat2 = new System.Windows.Forms.RadioButton();
            this.R2_Heat1 = new System.Windows.Forms.RadioButton();
            this.Start3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.R2_VentOFF = new System.Windows.Forms.RadioButton();
            this.R2_Vent3 = new System.Windows.Forms.RadioButton();
            this.R2_Vent2 = new System.Windows.Forms.RadioButton();
            this.R2_Vent1 = new System.Windows.Forms.RadioButton();
            this.Start4 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PA_VentOFF = new System.Windows.Forms.RadioButton();
            this.PA_Vent3 = new System.Windows.Forms.RadioButton();
            this.PA_Vent2 = new System.Windows.Forms.RadioButton();
            this.PA_Vent1 = new System.Windows.Forms.RadioButton();
            this.Start5 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PA_HeatOFF = new System.Windows.Forms.RadioButton();
            this.PA_Heat3 = new System.Windows.Forms.RadioButton();
            this.PA_Heat2 = new System.Windows.Forms.RadioButton();
            this.PA_Heat1 = new System.Windows.Forms.RadioButton();
            this.Start6 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DR_VentOFF = new System.Windows.Forms.RadioButton();
            this.DR_Vent3 = new System.Windows.Forms.RadioButton();
            this.DR_Vent2 = new System.Windows.Forms.RadioButton();
            this.DR_Vent1 = new System.Windows.Forms.RadioButton();
            this.Start7 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DR_HeatOFF = new System.Windows.Forms.RadioButton();
            this.DR_Heat3 = new System.Windows.Forms.RadioButton();
            this.DR_Heat2 = new System.Windows.Forms.RadioButton();
            this.DR_Heat1 = new System.Windows.Forms.RadioButton();
            this.Start8 = new System.Windows.Forms.NumericUpDown();
            this.Pos52 = new System.Windows.Forms.NumericUpDown();
            this.Start9 = new System.Windows.Forms.NumericUpDown();
            this.Stay52 = new System.Windows.Forms.NumericUpDown();
            this.Start10 = new System.Windows.Forms.NumericUpDown();
            this.Finish52 = new System.Windows.Forms.NumericUpDown();
            this.Start11 = new System.Windows.Forms.NumericUpDown();
            this.Start52 = new System.Windows.Forms.NumericUpDown();
            this.Start12 = new System.Windows.Forms.NumericUpDown();
            this.Motor52 = new System.Windows.Forms.ComboBox();
            this.Start13 = new System.Windows.Forms.NumericUpDown();
            this.Seat52 = new System.Windows.Forms.ComboBox();
            this.Start14 = new System.Windows.Forms.NumericUpDown();
            this.checkBox52 = new System.Windows.Forms.CheckBox();
            this.Start15 = new System.Windows.Forms.NumericUpDown();
            this.Pos51 = new System.Windows.Forms.NumericUpDown();
            this.Start16 = new System.Windows.Forms.NumericUpDown();
            this.Stay51 = new System.Windows.Forms.NumericUpDown();
            this.Start17 = new System.Windows.Forms.NumericUpDown();
            this.Finish51 = new System.Windows.Forms.NumericUpDown();
            this.Start18 = new System.Windows.Forms.NumericUpDown();
            this.Start51 = new System.Windows.Forms.NumericUpDown();
            this.Start19 = new System.Windows.Forms.NumericUpDown();
            this.Motor51 = new System.Windows.Forms.ComboBox();
            this.Start20 = new System.Windows.Forms.NumericUpDown();
            this.Seat51 = new System.Windows.Forms.ComboBox();
            this.Finish1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox51 = new System.Windows.Forms.CheckBox();
            this.Finish2 = new System.Windows.Forms.NumericUpDown();
            this.Pos50 = new System.Windows.Forms.NumericUpDown();
            this.Finish3 = new System.Windows.Forms.NumericUpDown();
            this.Stay50 = new System.Windows.Forms.NumericUpDown();
            this.Finish4 = new System.Windows.Forms.NumericUpDown();
            this.Finish50 = new System.Windows.Forms.NumericUpDown();
            this.Finish5 = new System.Windows.Forms.NumericUpDown();
            this.Start50 = new System.Windows.Forms.NumericUpDown();
            this.Finish6 = new System.Windows.Forms.NumericUpDown();
            this.Motor50 = new System.Windows.Forms.ComboBox();
            this.Finish7 = new System.Windows.Forms.NumericUpDown();
            this.Seat50 = new System.Windows.Forms.ComboBox();
            this.Finish8 = new System.Windows.Forms.NumericUpDown();
            this.checkBox50 = new System.Windows.Forms.CheckBox();
            this.Finish9 = new System.Windows.Forms.NumericUpDown();
            this.Pos49 = new System.Windows.Forms.NumericUpDown();
            this.Finish10 = new System.Windows.Forms.NumericUpDown();
            this.Stay49 = new System.Windows.Forms.NumericUpDown();
            this.Finish11 = new System.Windows.Forms.NumericUpDown();
            this.Finish49 = new System.Windows.Forms.NumericUpDown();
            this.Finish12 = new System.Windows.Forms.NumericUpDown();
            this.Start49 = new System.Windows.Forms.NumericUpDown();
            this.Finish13 = new System.Windows.Forms.NumericUpDown();
            this.Motor49 = new System.Windows.Forms.ComboBox();
            this.Finish14 = new System.Windows.Forms.NumericUpDown();
            this.Seat49 = new System.Windows.Forms.ComboBox();
            this.Finish15 = new System.Windows.Forms.NumericUpDown();
            this.checkBox49 = new System.Windows.Forms.CheckBox();
            this.Finish16 = new System.Windows.Forms.NumericUpDown();
            this.Pos48 = new System.Windows.Forms.NumericUpDown();
            this.Finish17 = new System.Windows.Forms.NumericUpDown();
            this.Stay48 = new System.Windows.Forms.NumericUpDown();
            this.Finish18 = new System.Windows.Forms.NumericUpDown();
            this.Finish48 = new System.Windows.Forms.NumericUpDown();
            this.Finish19 = new System.Windows.Forms.NumericUpDown();
            this.Start48 = new System.Windows.Forms.NumericUpDown();
            this.Finish20 = new System.Windows.Forms.NumericUpDown();
            this.Motor48 = new System.Windows.Forms.ComboBox();
            this.Stay1 = new System.Windows.Forms.NumericUpDown();
            this.Seat48 = new System.Windows.Forms.ComboBox();
            this.Stay2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox48 = new System.Windows.Forms.CheckBox();
            this.Stay3 = new System.Windows.Forms.NumericUpDown();
            this.Pos47 = new System.Windows.Forms.NumericUpDown();
            this.Stay4 = new System.Windows.Forms.NumericUpDown();
            this.Stay47 = new System.Windows.Forms.NumericUpDown();
            this.Stay5 = new System.Windows.Forms.NumericUpDown();
            this.Finish47 = new System.Windows.Forms.NumericUpDown();
            this.Stay6 = new System.Windows.Forms.NumericUpDown();
            this.Start47 = new System.Windows.Forms.NumericUpDown();
            this.Stay7 = new System.Windows.Forms.NumericUpDown();
            this.Motor47 = new System.Windows.Forms.ComboBox();
            this.Stay8 = new System.Windows.Forms.NumericUpDown();
            this.Seat47 = new System.Windows.Forms.ComboBox();
            this.Stay9 = new System.Windows.Forms.NumericUpDown();
            this.checkBox47 = new System.Windows.Forms.CheckBox();
            this.Stay10 = new System.Windows.Forms.NumericUpDown();
            this.Pos46 = new System.Windows.Forms.NumericUpDown();
            this.Stay11 = new System.Windows.Forms.NumericUpDown();
            this.Pos45 = new System.Windows.Forms.NumericUpDown();
            this.Stay12 = new System.Windows.Forms.NumericUpDown();
            this.Pos44 = new System.Windows.Forms.NumericUpDown();
            this.Stay13 = new System.Windows.Forms.NumericUpDown();
            this.Pos43 = new System.Windows.Forms.NumericUpDown();
            this.Stay14 = new System.Windows.Forms.NumericUpDown();
            this.Pos42 = new System.Windows.Forms.NumericUpDown();
            this.Stay15 = new System.Windows.Forms.NumericUpDown();
            this.Pos41 = new System.Windows.Forms.NumericUpDown();
            this.Stay16 = new System.Windows.Forms.NumericUpDown();
            this.Pos40 = new System.Windows.Forms.NumericUpDown();
            this.Stay17 = new System.Windows.Forms.NumericUpDown();
            this.Pos39 = new System.Windows.Forms.NumericUpDown();
            this.Stay18 = new System.Windows.Forms.NumericUpDown();
            this.Pos38 = new System.Windows.Forms.NumericUpDown();
            this.Stay19 = new System.Windows.Forms.NumericUpDown();
            this.Pos37 = new System.Windows.Forms.NumericUpDown();
            this.Stay20 = new System.Windows.Forms.NumericUpDown();
            this.Pos36 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.Pos35 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.Pos34 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.Pos33 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.Pos32 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.Pos31 = new System.Windows.Forms.NumericUpDown();
            this.Pos2 = new System.Windows.Forms.NumericUpDown();
            this.Pos30 = new System.Windows.Forms.NumericUpDown();
            this.Pos3 = new System.Windows.Forms.NumericUpDown();
            this.Pos29 = new System.Windows.Forms.NumericUpDown();
            this.Pos4 = new System.Windows.Forms.NumericUpDown();
            this.Pos28 = new System.Windows.Forms.NumericUpDown();
            this.Pos5 = new System.Windows.Forms.NumericUpDown();
            this.Pos27 = new System.Windows.Forms.NumericUpDown();
            this.Pos6 = new System.Windows.Forms.NumericUpDown();
            this.Stay46 = new System.Windows.Forms.NumericUpDown();
            this.Pos7 = new System.Windows.Forms.NumericUpDown();
            this.Stay45 = new System.Windows.Forms.NumericUpDown();
            this.Pos8 = new System.Windows.Forms.NumericUpDown();
            this.Stay44 = new System.Windows.Forms.NumericUpDown();
            this.Pos9 = new System.Windows.Forms.NumericUpDown();
            this.Stay43 = new System.Windows.Forms.NumericUpDown();
            this.Pos10 = new System.Windows.Forms.NumericUpDown();
            this.Stay42 = new System.Windows.Forms.NumericUpDown();
            this.Pos11 = new System.Windows.Forms.NumericUpDown();
            this.Stay41 = new System.Windows.Forms.NumericUpDown();
            this.Pos12 = new System.Windows.Forms.NumericUpDown();
            this.Stay40 = new System.Windows.Forms.NumericUpDown();
            this.Pos13 = new System.Windows.Forms.NumericUpDown();
            this.Stay39 = new System.Windows.Forms.NumericUpDown();
            this.Pos14 = new System.Windows.Forms.NumericUpDown();
            this.Stay38 = new System.Windows.Forms.NumericUpDown();
            this.Pos15 = new System.Windows.Forms.NumericUpDown();
            this.Stay37 = new System.Windows.Forms.NumericUpDown();
            this.Pos16 = new System.Windows.Forms.NumericUpDown();
            this.Stay36 = new System.Windows.Forms.NumericUpDown();
            this.Pos17 = new System.Windows.Forms.NumericUpDown();
            this.Stay35 = new System.Windows.Forms.NumericUpDown();
            this.Pos18 = new System.Windows.Forms.NumericUpDown();
            this.Stay34 = new System.Windows.Forms.NumericUpDown();
            this.Pos19 = new System.Windows.Forms.NumericUpDown();
            this.Stay33 = new System.Windows.Forms.NumericUpDown();
            this.Pos20 = new System.Windows.Forms.NumericUpDown();
            this.Stay32 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.Stay31 = new System.Windows.Forms.NumericUpDown();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.Stay30 = new System.Windows.Forms.NumericUpDown();
            this.Seat21 = new System.Windows.Forms.ComboBox();
            this.Stay29 = new System.Windows.Forms.NumericUpDown();
            this.Motor21 = new System.Windows.Forms.ComboBox();
            this.Stay28 = new System.Windows.Forms.NumericUpDown();
            this.Start21 = new System.Windows.Forms.NumericUpDown();
            this.Stay27 = new System.Windows.Forms.NumericUpDown();
            this.Finish21 = new System.Windows.Forms.NumericUpDown();
            this.Finish46 = new System.Windows.Forms.NumericUpDown();
            this.Stay21 = new System.Windows.Forms.NumericUpDown();
            this.Finish45 = new System.Windows.Forms.NumericUpDown();
            this.Pos21 = new System.Windows.Forms.NumericUpDown();
            this.Finish44 = new System.Windows.Forms.NumericUpDown();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.Finish43 = new System.Windows.Forms.NumericUpDown();
            this.Seat22 = new System.Windows.Forms.ComboBox();
            this.Finish42 = new System.Windows.Forms.NumericUpDown();
            this.Motor22 = new System.Windows.Forms.ComboBox();
            this.Finish41 = new System.Windows.Forms.NumericUpDown();
            this.Start22 = new System.Windows.Forms.NumericUpDown();
            this.Finish40 = new System.Windows.Forms.NumericUpDown();
            this.Finish22 = new System.Windows.Forms.NumericUpDown();
            this.Finish39 = new System.Windows.Forms.NumericUpDown();
            this.Stay22 = new System.Windows.Forms.NumericUpDown();
            this.Finish38 = new System.Windows.Forms.NumericUpDown();
            this.Pos22 = new System.Windows.Forms.NumericUpDown();
            this.Finish37 = new System.Windows.Forms.NumericUpDown();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.Finish36 = new System.Windows.Forms.NumericUpDown();
            this.Seat23 = new System.Windows.Forms.ComboBox();
            this.Finish35 = new System.Windows.Forms.NumericUpDown();
            this.Motor23 = new System.Windows.Forms.ComboBox();
            this.Finish34 = new System.Windows.Forms.NumericUpDown();
            this.Start23 = new System.Windows.Forms.NumericUpDown();
            this.Finish33 = new System.Windows.Forms.NumericUpDown();
            this.Finish23 = new System.Windows.Forms.NumericUpDown();
            this.Finish32 = new System.Windows.Forms.NumericUpDown();
            this.Stay23 = new System.Windows.Forms.NumericUpDown();
            this.Finish31 = new System.Windows.Forms.NumericUpDown();
            this.Pos23 = new System.Windows.Forms.NumericUpDown();
            this.Finish30 = new System.Windows.Forms.NumericUpDown();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.Finish29 = new System.Windows.Forms.NumericUpDown();
            this.Seat24 = new System.Windows.Forms.ComboBox();
            this.Finish28 = new System.Windows.Forms.NumericUpDown();
            this.Motor24 = new System.Windows.Forms.ComboBox();
            this.Finish27 = new System.Windows.Forms.NumericUpDown();
            this.Start24 = new System.Windows.Forms.NumericUpDown();
            this.Start46 = new System.Windows.Forms.NumericUpDown();
            this.Finish24 = new System.Windows.Forms.NumericUpDown();
            this.Start45 = new System.Windows.Forms.NumericUpDown();
            this.Stay24 = new System.Windows.Forms.NumericUpDown();
            this.Start44 = new System.Windows.Forms.NumericUpDown();
            this.Pos24 = new System.Windows.Forms.NumericUpDown();
            this.Start43 = new System.Windows.Forms.NumericUpDown();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.Start42 = new System.Windows.Forms.NumericUpDown();
            this.Seat25 = new System.Windows.Forms.ComboBox();
            this.Start41 = new System.Windows.Forms.NumericUpDown();
            this.Motor25 = new System.Windows.Forms.ComboBox();
            this.Start40 = new System.Windows.Forms.NumericUpDown();
            this.Start25 = new System.Windows.Forms.NumericUpDown();
            this.Start39 = new System.Windows.Forms.NumericUpDown();
            this.Finish25 = new System.Windows.Forms.NumericUpDown();
            this.Start38 = new System.Windows.Forms.NumericUpDown();
            this.Stay25 = new System.Windows.Forms.NumericUpDown();
            this.Start37 = new System.Windows.Forms.NumericUpDown();
            this.Pos25 = new System.Windows.Forms.NumericUpDown();
            this.Start36 = new System.Windows.Forms.NumericUpDown();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.Start35 = new System.Windows.Forms.NumericUpDown();
            this.Seat26 = new System.Windows.Forms.ComboBox();
            this.Start34 = new System.Windows.Forms.NumericUpDown();
            this.Motor26 = new System.Windows.Forms.ComboBox();
            this.Start33 = new System.Windows.Forms.NumericUpDown();
            this.Start26 = new System.Windows.Forms.NumericUpDown();
            this.Start32 = new System.Windows.Forms.NumericUpDown();
            this.Finish26 = new System.Windows.Forms.NumericUpDown();
            this.Start31 = new System.Windows.Forms.NumericUpDown();
            this.Stay26 = new System.Windows.Forms.NumericUpDown();
            this.Start30 = new System.Windows.Forms.NumericUpDown();
            this.Pos26 = new System.Windows.Forms.NumericUpDown();
            this.Start29 = new System.Windows.Forms.NumericUpDown();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.Start28 = new System.Windows.Forms.NumericUpDown();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.Start27 = new System.Windows.Forms.NumericUpDown();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.Motor46 = new System.Windows.Forms.ComboBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.Motor45 = new System.Windows.Forms.ComboBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.Motor44 = new System.Windows.Forms.ComboBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.Motor43 = new System.Windows.Forms.ComboBox();
            this.checkBox33 = new System.Windows.Forms.CheckBox();
            this.Motor42 = new System.Windows.Forms.ComboBox();
            this.checkBox34 = new System.Windows.Forms.CheckBox();
            this.Motor41 = new System.Windows.Forms.ComboBox();
            this.checkBox35 = new System.Windows.Forms.CheckBox();
            this.Motor40 = new System.Windows.Forms.ComboBox();
            this.checkBox36 = new System.Windows.Forms.CheckBox();
            this.Motor39 = new System.Windows.Forms.ComboBox();
            this.checkBox37 = new System.Windows.Forms.CheckBox();
            this.Motor38 = new System.Windows.Forms.ComboBox();
            this.checkBox38 = new System.Windows.Forms.CheckBox();
            this.Motor37 = new System.Windows.Forms.ComboBox();
            this.checkBox39 = new System.Windows.Forms.CheckBox();
            this.Motor36 = new System.Windows.Forms.ComboBox();
            this.checkBox40 = new System.Windows.Forms.CheckBox();
            this.Motor35 = new System.Windows.Forms.ComboBox();
            this.checkBox41 = new System.Windows.Forms.CheckBox();
            this.Motor34 = new System.Windows.Forms.ComboBox();
            this.checkBox42 = new System.Windows.Forms.CheckBox();
            this.Motor33 = new System.Windows.Forms.ComboBox();
            this.checkBox43 = new System.Windows.Forms.CheckBox();
            this.Motor32 = new System.Windows.Forms.ComboBox();
            this.checkBox44 = new System.Windows.Forms.CheckBox();
            this.Motor31 = new System.Windows.Forms.ComboBox();
            this.checkBox45 = new System.Windows.Forms.CheckBox();
            this.Motor30 = new System.Windows.Forms.ComboBox();
            this.checkBox46 = new System.Windows.Forms.CheckBox();
            this.Motor29 = new System.Windows.Forms.ComboBox();
            this.Seat27 = new System.Windows.Forms.ComboBox();
            this.Motor28 = new System.Windows.Forms.ComboBox();
            this.Seat28 = new System.Windows.Forms.ComboBox();
            this.Motor27 = new System.Windows.Forms.ComboBox();
            this.Seat29 = new System.Windows.Forms.ComboBox();
            this.Seat46 = new System.Windows.Forms.ComboBox();
            this.Seat30 = new System.Windows.Forms.ComboBox();
            this.Seat45 = new System.Windows.Forms.ComboBox();
            this.Seat31 = new System.Windows.Forms.ComboBox();
            this.Seat44 = new System.Windows.Forms.ComboBox();
            this.Seat32 = new System.Windows.Forms.ComboBox();
            this.Seat43 = new System.Windows.Forms.ComboBox();
            this.Seat33 = new System.Windows.Forms.ComboBox();
            this.Seat42 = new System.Windows.Forms.ComboBox();
            this.Seat34 = new System.Windows.Forms.ComboBox();
            this.Seat41 = new System.Windows.Forms.ComboBox();
            this.Seat35 = new System.Windows.Forms.ComboBox();
            this.Seat40 = new System.Windows.Forms.ComboBox();
            this.Seat36 = new System.Windows.Forms.ComboBox();
            this.Seat39 = new System.Windows.Forms.ComboBox();
            this.Seat37 = new System.Windows.Forms.ComboBox();
            this.Seat38 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3R_ThdRwRtStBkwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3R_ThdRwRtStFrwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3R_ThdRRtStExpdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3R_AcsMdExtRtRclSwActv = new System.Windows.Forms.CheckBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3L_ThdRwStBkReclnUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3L_ThdRStBkwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3L_ThdRStFrwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3L_ThdRStExpdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_3L_AcsMdExtRclSwActv = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.SecRwLtStVntDtyCycl = new System.Windows.Forms.CheckBox();
            this.SecRwLtStHtDtyCycl = new System.Windows.Forms.CheckBox();
            this.L_SecRwLtStArmScrnHMI2LReq = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStLgrstDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStLgrstUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStBkReclnDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStBkReclnUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStBkwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2L_SecRwStFrwdSwActv = new System.Windows.Forms.CheckBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.SecRwRtStVntDtyCycl = new System.Windows.Forms.CheckBox();
            this.SecRwRtStHtDtyCycl = new System.Windows.Forms.CheckBox();
            this.R_SecRwRtStArmScrnHMI2RReq = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStLgrstDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStLgrstUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStBkReclnDnwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStBkReclnUpwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStBkwdSwActv = new System.Windows.Forms.CheckBox();
            this.SPS_2R_SecRwStFrwdSwActv = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.RtStFtDnwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.RtStFtUpwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.R_ReclineRrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.R_ReclineFrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.R_CushRrDwnCustSeltn = new System.Windows.Forms.CheckBox();
            this.R_CushRrUpCustSeltn = new System.Windows.Forms.CheckBox();
            this.R_CushFrtDwnCustSeltn = new System.Windows.Forms.CheckBox();
            this.R_CushFrtUpCustSeltn = new System.Windows.Forms.CheckBox();
            this.R_SeatRrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.R_SeatFrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.LtStFtDnwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.LtStFtUpwdHMI2LReq = new System.Windows.Forms.CheckBox();
            this.L_ReclineRrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_ReclineFrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_CushRrDwnCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_CushRrUpCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_CushFrtDwnCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_CushFrtUpCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_SeatRrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.L_SeatFrwdCustSeltn = new System.Windows.Forms.CheckBox();
            this.StatusBar.SuspendLayout();
            this.TransmitPopup.SuspendLayout();
            this.ReceivePopup.SuspendLayout();
            this.StandardBar.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinishCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CycleTimes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pos1)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start1)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start5)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start6)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start7)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start27)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
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
            this.StatusBar.Size = new System.Drawing.Size(1224, 22);
            this.StatusBar.TabIndex = 6;
            this.StatusBar.Text = "statusStrip1";
            // 
            // SB_LIN_Connect
            // 
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
            this.StandardBar.Size = new System.Drawing.Size(1224, 27);
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
            this.MM_LIN.Size = new System.Drawing.Size(71, 21);
            this.MM_LIN.Text = "&LIN/CAN";
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
            this.MainMenu.Size = new System.Drawing.Size(1224, 25);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 675);
            this.panel1.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Save);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.Pause);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.FinishCount);
            this.splitContainer1.Panel1.Controls.Add(this.CycleTimes);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.textBox5);
            this.splitContainer1.Panel1.Controls.Add(this.textBox4);
            this.splitContainer1.Panel1.Controls.Add(this.textBox3);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1224, 675);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(786, 111);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 23;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(670, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "清零";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(670, 44);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 20;
            this.Pause.Text = "暂停";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(526, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(526, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "当前时间";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "试验开始时间";
            // 
            // FinishCount
            // 
            this.FinishCount.Location = new System.Drawing.Point(441, 35);
            this.FinishCount.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.FinishCount.Name = "FinishCount";
            this.FinishCount.Size = new System.Drawing.Size(88, 22);
            this.FinishCount.TabIndex = 14;
            // 
            // CycleTimes
            // 
            this.CycleTimes.Location = new System.Drawing.Point(338, 35);
            this.CycleTimes.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.CycleTimes.Name = "CycleTimes";
            this.CycleTimes.Size = new System.Drawing.Size(88, 22);
            this.CycleTimes.TabIndex = 13;
            this.CycleTimes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "已完成次数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "循环次数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "湿度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "温度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "环境参数";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(215, 126);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(94, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "SGM458";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "试验样品";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "实验名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1224, 509);
            this.tabControl1.TabIndex = 437;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.DoublePos52);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.DoublePos51);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.DoublePos50);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.DoublePos49);
            this.tabPage1.Controls.Add(this.checkBox5);
            this.tabPage1.Controls.Add(this.DoublePos48);
            this.tabPage1.Controls.Add(this.checkBox6);
            this.tabPage1.Controls.Add(this.DoublePos47);
            this.tabPage1.Controls.Add(this.checkBox7);
            this.tabPage1.Controls.Add(this.DoublePos46);
            this.tabPage1.Controls.Add(this.checkBox8);
            this.tabPage1.Controls.Add(this.DoublePos45);
            this.tabPage1.Controls.Add(this.checkBox9);
            this.tabPage1.Controls.Add(this.DoublePos44);
            this.tabPage1.Controls.Add(this.checkBox10);
            this.tabPage1.Controls.Add(this.DoublePos43);
            this.tabPage1.Controls.Add(this.checkBox11);
            this.tabPage1.Controls.Add(this.DoublePos42);
            this.tabPage1.Controls.Add(this.checkBox12);
            this.tabPage1.Controls.Add(this.DoublePos41);
            this.tabPage1.Controls.Add(this.checkBox13);
            this.tabPage1.Controls.Add(this.DoublePos40);
            this.tabPage1.Controls.Add(this.checkBox14);
            this.tabPage1.Controls.Add(this.DoublePos39);
            this.tabPage1.Controls.Add(this.checkBox15);
            this.tabPage1.Controls.Add(this.DoublePos38);
            this.tabPage1.Controls.Add(this.checkBox16);
            this.tabPage1.Controls.Add(this.DoublePos37);
            this.tabPage1.Controls.Add(this.checkBox17);
            this.tabPage1.Controls.Add(this.DoublePos36);
            this.tabPage1.Controls.Add(this.checkBox18);
            this.tabPage1.Controls.Add(this.DoublePos35);
            this.tabPage1.Controls.Add(this.checkBox19);
            this.tabPage1.Controls.Add(this.DoublePos34);
            this.tabPage1.Controls.Add(this.checkBox20);
            this.tabPage1.Controls.Add(this.DoublePos33);
            this.tabPage1.Controls.Add(this.Seat1);
            this.tabPage1.Controls.Add(this.DoublePos32);
            this.tabPage1.Controls.Add(this.Seat2);
            this.tabPage1.Controls.Add(this.DoublePos31);
            this.tabPage1.Controls.Add(this.Seat3);
            this.tabPage1.Controls.Add(this.DoublePos30);
            this.tabPage1.Controls.Add(this.Seat4);
            this.tabPage1.Controls.Add(this.DoublePos29);
            this.tabPage1.Controls.Add(this.Seat5);
            this.tabPage1.Controls.Add(this.DoublePos28);
            this.tabPage1.Controls.Add(this.Seat6);
            this.tabPage1.Controls.Add(this.DoublePos27);
            this.tabPage1.Controls.Add(this.Seat7);
            this.tabPage1.Controls.Add(this.DoublePos26);
            this.tabPage1.Controls.Add(this.Seat8);
            this.tabPage1.Controls.Add(this.DoublePos25);
            this.tabPage1.Controls.Add(this.Seat9);
            this.tabPage1.Controls.Add(this.DoublePos24);
            this.tabPage1.Controls.Add(this.Seat10);
            this.tabPage1.Controls.Add(this.DoublePos23);
            this.tabPage1.Controls.Add(this.Seat11);
            this.tabPage1.Controls.Add(this.DoublePos22);
            this.tabPage1.Controls.Add(this.Seat12);
            this.tabPage1.Controls.Add(this.DoublePos21);
            this.tabPage1.Controls.Add(this.Seat13);
            this.tabPage1.Controls.Add(this.DoublePos20);
            this.tabPage1.Controls.Add(this.Seat14);
            this.tabPage1.Controls.Add(this.DoublePos19);
            this.tabPage1.Controls.Add(this.Seat15);
            this.tabPage1.Controls.Add(this.DoublePos18);
            this.tabPage1.Controls.Add(this.Seat16);
            this.tabPage1.Controls.Add(this.DoublePos17);
            this.tabPage1.Controls.Add(this.Seat17);
            this.tabPage1.Controls.Add(this.DoublePos16);
            this.tabPage1.Controls.Add(this.Seat18);
            this.tabPage1.Controls.Add(this.DoublePos15);
            this.tabPage1.Controls.Add(this.Seat19);
            this.tabPage1.Controls.Add(this.DoublePos14);
            this.tabPage1.Controls.Add(this.Seat20);
            this.tabPage1.Controls.Add(this.DoublePos13);
            this.tabPage1.Controls.Add(this.Motor1);
            this.tabPage1.Controls.Add(this.DoublePos12);
            this.tabPage1.Controls.Add(this.Motor2);
            this.tabPage1.Controls.Add(this.DoublePos11);
            this.tabPage1.Controls.Add(this.Motor3);
            this.tabPage1.Controls.Add(this.DoublePos10);
            this.tabPage1.Controls.Add(this.Motor4);
            this.tabPage1.Controls.Add(this.DoublePos9);
            this.tabPage1.Controls.Add(this.Motor5);
            this.tabPage1.Controls.Add(this.DoublePos8);
            this.tabPage1.Controls.Add(this.Motor6);
            this.tabPage1.Controls.Add(this.DoublePos7);
            this.tabPage1.Controls.Add(this.Motor7);
            this.tabPage1.Controls.Add(this.DoublePos6);
            this.tabPage1.Controls.Add(this.Motor8);
            this.tabPage1.Controls.Add(this.DoublePos5);
            this.tabPage1.Controls.Add(this.Motor9);
            this.tabPage1.Controls.Add(this.DoublePos4);
            this.tabPage1.Controls.Add(this.Motor10);
            this.tabPage1.Controls.Add(this.DoublePos3);
            this.tabPage1.Controls.Add(this.Motor11);
            this.tabPage1.Controls.Add(this.DoublePos2);
            this.tabPage1.Controls.Add(this.Motor12);
            this.tabPage1.Controls.Add(this.DoublePos1);
            this.tabPage1.Controls.Add(this.Motor13);
            this.tabPage1.Controls.Add(this.Pos1);
            this.tabPage1.Controls.Add(this.Motor14);
            this.tabPage1.Controls.Add(this.SecRwRtStMassStrsHMI2RReq);
            this.tabPage1.Controls.Add(this.Motor15);
            this.tabPage1.Controls.Add(this.SecRwRtStMassMdHMI2RReq);
            this.tabPage1.Controls.Add(this.Motor16);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.Motor17);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.Motor18);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.Motor19);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.Motor20);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.Start1);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.Start2);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.Start3);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.Start4);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.Start5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.Start6);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.Start7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Start8);
            this.tabPage1.Controls.Add(this.Pos52);
            this.tabPage1.Controls.Add(this.Start9);
            this.tabPage1.Controls.Add(this.Stay52);
            this.tabPage1.Controls.Add(this.Start10);
            this.tabPage1.Controls.Add(this.Finish52);
            this.tabPage1.Controls.Add(this.Start11);
            this.tabPage1.Controls.Add(this.Start52);
            this.tabPage1.Controls.Add(this.Start12);
            this.tabPage1.Controls.Add(this.Motor52);
            this.tabPage1.Controls.Add(this.Start13);
            this.tabPage1.Controls.Add(this.Seat52);
            this.tabPage1.Controls.Add(this.Start14);
            this.tabPage1.Controls.Add(this.checkBox52);
            this.tabPage1.Controls.Add(this.Start15);
            this.tabPage1.Controls.Add(this.Pos51);
            this.tabPage1.Controls.Add(this.Start16);
            this.tabPage1.Controls.Add(this.Stay51);
            this.tabPage1.Controls.Add(this.Start17);
            this.tabPage1.Controls.Add(this.Finish51);
            this.tabPage1.Controls.Add(this.Start18);
            this.tabPage1.Controls.Add(this.Start51);
            this.tabPage1.Controls.Add(this.Start19);
            this.tabPage1.Controls.Add(this.Motor51);
            this.tabPage1.Controls.Add(this.Start20);
            this.tabPage1.Controls.Add(this.Seat51);
            this.tabPage1.Controls.Add(this.Finish1);
            this.tabPage1.Controls.Add(this.checkBox51);
            this.tabPage1.Controls.Add(this.Finish2);
            this.tabPage1.Controls.Add(this.Pos50);
            this.tabPage1.Controls.Add(this.Finish3);
            this.tabPage1.Controls.Add(this.Stay50);
            this.tabPage1.Controls.Add(this.Finish4);
            this.tabPage1.Controls.Add(this.Finish50);
            this.tabPage1.Controls.Add(this.Finish5);
            this.tabPage1.Controls.Add(this.Start50);
            this.tabPage1.Controls.Add(this.Finish6);
            this.tabPage1.Controls.Add(this.Motor50);
            this.tabPage1.Controls.Add(this.Finish7);
            this.tabPage1.Controls.Add(this.Seat50);
            this.tabPage1.Controls.Add(this.Finish8);
            this.tabPage1.Controls.Add(this.checkBox50);
            this.tabPage1.Controls.Add(this.Finish9);
            this.tabPage1.Controls.Add(this.Pos49);
            this.tabPage1.Controls.Add(this.Finish10);
            this.tabPage1.Controls.Add(this.Stay49);
            this.tabPage1.Controls.Add(this.Finish11);
            this.tabPage1.Controls.Add(this.Finish49);
            this.tabPage1.Controls.Add(this.Finish12);
            this.tabPage1.Controls.Add(this.Start49);
            this.tabPage1.Controls.Add(this.Finish13);
            this.tabPage1.Controls.Add(this.Motor49);
            this.tabPage1.Controls.Add(this.Finish14);
            this.tabPage1.Controls.Add(this.Seat49);
            this.tabPage1.Controls.Add(this.Finish15);
            this.tabPage1.Controls.Add(this.checkBox49);
            this.tabPage1.Controls.Add(this.Finish16);
            this.tabPage1.Controls.Add(this.Pos48);
            this.tabPage1.Controls.Add(this.Finish17);
            this.tabPage1.Controls.Add(this.Stay48);
            this.tabPage1.Controls.Add(this.Finish18);
            this.tabPage1.Controls.Add(this.Finish48);
            this.tabPage1.Controls.Add(this.Finish19);
            this.tabPage1.Controls.Add(this.Start48);
            this.tabPage1.Controls.Add(this.Finish20);
            this.tabPage1.Controls.Add(this.Motor48);
            this.tabPage1.Controls.Add(this.Stay1);
            this.tabPage1.Controls.Add(this.Seat48);
            this.tabPage1.Controls.Add(this.Stay2);
            this.tabPage1.Controls.Add(this.checkBox48);
            this.tabPage1.Controls.Add(this.Stay3);
            this.tabPage1.Controls.Add(this.Pos47);
            this.tabPage1.Controls.Add(this.Stay4);
            this.tabPage1.Controls.Add(this.Stay47);
            this.tabPage1.Controls.Add(this.Stay5);
            this.tabPage1.Controls.Add(this.Finish47);
            this.tabPage1.Controls.Add(this.Stay6);
            this.tabPage1.Controls.Add(this.Start47);
            this.tabPage1.Controls.Add(this.Stay7);
            this.tabPage1.Controls.Add(this.Motor47);
            this.tabPage1.Controls.Add(this.Stay8);
            this.tabPage1.Controls.Add(this.Seat47);
            this.tabPage1.Controls.Add(this.Stay9);
            this.tabPage1.Controls.Add(this.checkBox47);
            this.tabPage1.Controls.Add(this.Stay10);
            this.tabPage1.Controls.Add(this.Pos46);
            this.tabPage1.Controls.Add(this.Stay11);
            this.tabPage1.Controls.Add(this.Pos45);
            this.tabPage1.Controls.Add(this.Stay12);
            this.tabPage1.Controls.Add(this.Pos44);
            this.tabPage1.Controls.Add(this.Stay13);
            this.tabPage1.Controls.Add(this.Pos43);
            this.tabPage1.Controls.Add(this.Stay14);
            this.tabPage1.Controls.Add(this.Pos42);
            this.tabPage1.Controls.Add(this.Stay15);
            this.tabPage1.Controls.Add(this.Pos41);
            this.tabPage1.Controls.Add(this.Stay16);
            this.tabPage1.Controls.Add(this.Pos40);
            this.tabPage1.Controls.Add(this.Stay17);
            this.tabPage1.Controls.Add(this.Pos39);
            this.tabPage1.Controls.Add(this.Stay18);
            this.tabPage1.Controls.Add(this.Pos38);
            this.tabPage1.Controls.Add(this.Stay19);
            this.tabPage1.Controls.Add(this.Pos37);
            this.tabPage1.Controls.Add(this.Stay20);
            this.tabPage1.Controls.Add(this.Pos36);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.Pos35);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.Pos34);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.Pos33);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.Pos32);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.Pos31);
            this.tabPage1.Controls.Add(this.Pos2);
            this.tabPage1.Controls.Add(this.Pos30);
            this.tabPage1.Controls.Add(this.Pos3);
            this.tabPage1.Controls.Add(this.Pos29);
            this.tabPage1.Controls.Add(this.Pos4);
            this.tabPage1.Controls.Add(this.Pos28);
            this.tabPage1.Controls.Add(this.Pos5);
            this.tabPage1.Controls.Add(this.Pos27);
            this.tabPage1.Controls.Add(this.Pos6);
            this.tabPage1.Controls.Add(this.Stay46);
            this.tabPage1.Controls.Add(this.Pos7);
            this.tabPage1.Controls.Add(this.Stay45);
            this.tabPage1.Controls.Add(this.Pos8);
            this.tabPage1.Controls.Add(this.Stay44);
            this.tabPage1.Controls.Add(this.Pos9);
            this.tabPage1.Controls.Add(this.Stay43);
            this.tabPage1.Controls.Add(this.Pos10);
            this.tabPage1.Controls.Add(this.Stay42);
            this.tabPage1.Controls.Add(this.Pos11);
            this.tabPage1.Controls.Add(this.Stay41);
            this.tabPage1.Controls.Add(this.Pos12);
            this.tabPage1.Controls.Add(this.Stay40);
            this.tabPage1.Controls.Add(this.Pos13);
            this.tabPage1.Controls.Add(this.Stay39);
            this.tabPage1.Controls.Add(this.Pos14);
            this.tabPage1.Controls.Add(this.Stay38);
            this.tabPage1.Controls.Add(this.Pos15);
            this.tabPage1.Controls.Add(this.Stay37);
            this.tabPage1.Controls.Add(this.Pos16);
            this.tabPage1.Controls.Add(this.Stay36);
            this.tabPage1.Controls.Add(this.Pos17);
            this.tabPage1.Controls.Add(this.Stay35);
            this.tabPage1.Controls.Add(this.Pos18);
            this.tabPage1.Controls.Add(this.Stay34);
            this.tabPage1.Controls.Add(this.Pos19);
            this.tabPage1.Controls.Add(this.Stay33);
            this.tabPage1.Controls.Add(this.Pos20);
            this.tabPage1.Controls.Add(this.Stay32);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.Stay31);
            this.tabPage1.Controls.Add(this.checkBox21);
            this.tabPage1.Controls.Add(this.Stay30);
            this.tabPage1.Controls.Add(this.Seat21);
            this.tabPage1.Controls.Add(this.Stay29);
            this.tabPage1.Controls.Add(this.Motor21);
            this.tabPage1.Controls.Add(this.Stay28);
            this.tabPage1.Controls.Add(this.Start21);
            this.tabPage1.Controls.Add(this.Stay27);
            this.tabPage1.Controls.Add(this.Finish21);
            this.tabPage1.Controls.Add(this.Finish46);
            this.tabPage1.Controls.Add(this.Stay21);
            this.tabPage1.Controls.Add(this.Finish45);
            this.tabPage1.Controls.Add(this.Pos21);
            this.tabPage1.Controls.Add(this.Finish44);
            this.tabPage1.Controls.Add(this.checkBox22);
            this.tabPage1.Controls.Add(this.Finish43);
            this.tabPage1.Controls.Add(this.Seat22);
            this.tabPage1.Controls.Add(this.Finish42);
            this.tabPage1.Controls.Add(this.Motor22);
            this.tabPage1.Controls.Add(this.Finish41);
            this.tabPage1.Controls.Add(this.Start22);
            this.tabPage1.Controls.Add(this.Finish40);
            this.tabPage1.Controls.Add(this.Finish22);
            this.tabPage1.Controls.Add(this.Finish39);
            this.tabPage1.Controls.Add(this.Stay22);
            this.tabPage1.Controls.Add(this.Finish38);
            this.tabPage1.Controls.Add(this.Pos22);
            this.tabPage1.Controls.Add(this.Finish37);
            this.tabPage1.Controls.Add(this.checkBox23);
            this.tabPage1.Controls.Add(this.Finish36);
            this.tabPage1.Controls.Add(this.Seat23);
            this.tabPage1.Controls.Add(this.Finish35);
            this.tabPage1.Controls.Add(this.Motor23);
            this.tabPage1.Controls.Add(this.Finish34);
            this.tabPage1.Controls.Add(this.Start23);
            this.tabPage1.Controls.Add(this.Finish33);
            this.tabPage1.Controls.Add(this.Finish23);
            this.tabPage1.Controls.Add(this.Finish32);
            this.tabPage1.Controls.Add(this.Stay23);
            this.tabPage1.Controls.Add(this.Finish31);
            this.tabPage1.Controls.Add(this.Pos23);
            this.tabPage1.Controls.Add(this.Finish30);
            this.tabPage1.Controls.Add(this.checkBox24);
            this.tabPage1.Controls.Add(this.Finish29);
            this.tabPage1.Controls.Add(this.Seat24);
            this.tabPage1.Controls.Add(this.Finish28);
            this.tabPage1.Controls.Add(this.Motor24);
            this.tabPage1.Controls.Add(this.Finish27);
            this.tabPage1.Controls.Add(this.Start24);
            this.tabPage1.Controls.Add(this.Start46);
            this.tabPage1.Controls.Add(this.Finish24);
            this.tabPage1.Controls.Add(this.Start45);
            this.tabPage1.Controls.Add(this.Stay24);
            this.tabPage1.Controls.Add(this.Start44);
            this.tabPage1.Controls.Add(this.Pos24);
            this.tabPage1.Controls.Add(this.Start43);
            this.tabPage1.Controls.Add(this.checkBox25);
            this.tabPage1.Controls.Add(this.Start42);
            this.tabPage1.Controls.Add(this.Seat25);
            this.tabPage1.Controls.Add(this.Start41);
            this.tabPage1.Controls.Add(this.Motor25);
            this.tabPage1.Controls.Add(this.Start40);
            this.tabPage1.Controls.Add(this.Start25);
            this.tabPage1.Controls.Add(this.Start39);
            this.tabPage1.Controls.Add(this.Finish25);
            this.tabPage1.Controls.Add(this.Start38);
            this.tabPage1.Controls.Add(this.Stay25);
            this.tabPage1.Controls.Add(this.Start37);
            this.tabPage1.Controls.Add(this.Pos25);
            this.tabPage1.Controls.Add(this.Start36);
            this.tabPage1.Controls.Add(this.checkBox26);
            this.tabPage1.Controls.Add(this.Start35);
            this.tabPage1.Controls.Add(this.Seat26);
            this.tabPage1.Controls.Add(this.Start34);
            this.tabPage1.Controls.Add(this.Motor26);
            this.tabPage1.Controls.Add(this.Start33);
            this.tabPage1.Controls.Add(this.Start26);
            this.tabPage1.Controls.Add(this.Start32);
            this.tabPage1.Controls.Add(this.Finish26);
            this.tabPage1.Controls.Add(this.Start31);
            this.tabPage1.Controls.Add(this.Stay26);
            this.tabPage1.Controls.Add(this.Start30);
            this.tabPage1.Controls.Add(this.Pos26);
            this.tabPage1.Controls.Add(this.Start29);
            this.tabPage1.Controls.Add(this.checkBox27);
            this.tabPage1.Controls.Add(this.Start28);
            this.tabPage1.Controls.Add(this.checkBox28);
            this.tabPage1.Controls.Add(this.Start27);
            this.tabPage1.Controls.Add(this.checkBox29);
            this.tabPage1.Controls.Add(this.Motor46);
            this.tabPage1.Controls.Add(this.checkBox30);
            this.tabPage1.Controls.Add(this.Motor45);
            this.tabPage1.Controls.Add(this.checkBox31);
            this.tabPage1.Controls.Add(this.Motor44);
            this.tabPage1.Controls.Add(this.checkBox32);
            this.tabPage1.Controls.Add(this.Motor43);
            this.tabPage1.Controls.Add(this.checkBox33);
            this.tabPage1.Controls.Add(this.Motor42);
            this.tabPage1.Controls.Add(this.checkBox34);
            this.tabPage1.Controls.Add(this.Motor41);
            this.tabPage1.Controls.Add(this.checkBox35);
            this.tabPage1.Controls.Add(this.Motor40);
            this.tabPage1.Controls.Add(this.checkBox36);
            this.tabPage1.Controls.Add(this.Motor39);
            this.tabPage1.Controls.Add(this.checkBox37);
            this.tabPage1.Controls.Add(this.Motor38);
            this.tabPage1.Controls.Add(this.checkBox38);
            this.tabPage1.Controls.Add(this.Motor37);
            this.tabPage1.Controls.Add(this.checkBox39);
            this.tabPage1.Controls.Add(this.Motor36);
            this.tabPage1.Controls.Add(this.checkBox40);
            this.tabPage1.Controls.Add(this.Motor35);
            this.tabPage1.Controls.Add(this.checkBox41);
            this.tabPage1.Controls.Add(this.Motor34);
            this.tabPage1.Controls.Add(this.checkBox42);
            this.tabPage1.Controls.Add(this.Motor33);
            this.tabPage1.Controls.Add(this.checkBox43);
            this.tabPage1.Controls.Add(this.Motor32);
            this.tabPage1.Controls.Add(this.checkBox44);
            this.tabPage1.Controls.Add(this.Motor31);
            this.tabPage1.Controls.Add(this.checkBox45);
            this.tabPage1.Controls.Add(this.Motor30);
            this.tabPage1.Controls.Add(this.checkBox46);
            this.tabPage1.Controls.Add(this.Motor29);
            this.tabPage1.Controls.Add(this.Seat27);
            this.tabPage1.Controls.Add(this.Motor28);
            this.tabPage1.Controls.Add(this.Seat28);
            this.tabPage1.Controls.Add(this.Motor27);
            this.tabPage1.Controls.Add(this.Seat29);
            this.tabPage1.Controls.Add(this.Seat46);
            this.tabPage1.Controls.Add(this.Seat30);
            this.tabPage1.Controls.Add(this.Seat45);
            this.tabPage1.Controls.Add(this.Seat31);
            this.tabPage1.Controls.Add(this.Seat44);
            this.tabPage1.Controls.Add(this.Seat32);
            this.tabPage1.Controls.Add(this.Seat43);
            this.tabPage1.Controls.Add(this.Seat33);
            this.tabPage1.Controls.Add(this.Seat42);
            this.tabPage1.Controls.Add(this.Seat34);
            this.tabPage1.Controls.Add(this.Seat41);
            this.tabPage1.Controls.Add(this.Seat35);
            this.tabPage1.Controls.Add(this.Seat40);
            this.tabPage1.Controls.Add(this.Seat36);
            this.tabPage1.Controls.Add(this.Seat39);
            this.tabPage1.Controls.Add(this.Seat37);
            this.tabPage1.Controls.Add(this.Seat38);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1216, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "循环";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DoublePos52
            // 
            this.DoublePos52.Enabled = false;
            this.DoublePos52.Location = new System.Drawing.Point(596, 1146);
            this.DoublePos52.Name = "DoublePos52";
            this.DoublePos52.Size = new System.Drawing.Size(56, 22);
            this.DoublePos52.TabIndex = 436;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // DoublePos51
            // 
            this.DoublePos51.Enabled = false;
            this.DoublePos51.Location = new System.Drawing.Point(596, 1124);
            this.DoublePos51.Name = "DoublePos51";
            this.DoublePos51.Size = new System.Drawing.Size(56, 22);
            this.DoublePos51.TabIndex = 435;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 69);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(32, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // DoublePos50
            // 
            this.DoublePos50.Enabled = false;
            this.DoublePos50.Location = new System.Drawing.Point(596, 1102);
            this.DoublePos50.Name = "DoublePos50";
            this.DoublePos50.Size = new System.Drawing.Size(56, 22);
            this.DoublePos50.TabIndex = 434;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 91);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(32, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // DoublePos49
            // 
            this.DoublePos49.Enabled = false;
            this.DoublePos49.Location = new System.Drawing.Point(596, 1080);
            this.DoublePos49.Name = "DoublePos49";
            this.DoublePos49.Size = new System.Drawing.Size(56, 22);
            this.DoublePos49.TabIndex = 433;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 113);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(32, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // DoublePos48
            // 
            this.DoublePos48.Enabled = false;
            this.DoublePos48.Location = new System.Drawing.Point(596, 1058);
            this.DoublePos48.Name = "DoublePos48";
            this.DoublePos48.Size = new System.Drawing.Size(56, 22);
            this.DoublePos48.TabIndex = 432;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 135);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(32, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "6";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // DoublePos47
            // 
            this.DoublePos47.Enabled = false;
            this.DoublePos47.Location = new System.Drawing.Point(596, 1036);
            this.DoublePos47.Name = "DoublePos47";
            this.DoublePos47.Size = new System.Drawing.Size(56, 22);
            this.DoublePos47.TabIndex = 431;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 157);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(32, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "7";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // DoublePos46
            // 
            this.DoublePos46.Enabled = false;
            this.DoublePos46.Location = new System.Drawing.Point(596, 1014);
            this.DoublePos46.Name = "DoublePos46";
            this.DoublePos46.Size = new System.Drawing.Size(56, 22);
            this.DoublePos46.TabIndex = 430;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(6, 179);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(32, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "8";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // DoublePos45
            // 
            this.DoublePos45.Enabled = false;
            this.DoublePos45.Location = new System.Drawing.Point(596, 992);
            this.DoublePos45.Name = "DoublePos45";
            this.DoublePos45.Size = new System.Drawing.Size(56, 22);
            this.DoublePos45.TabIndex = 429;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(6, 201);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(32, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "9";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // DoublePos44
            // 
            this.DoublePos44.Enabled = false;
            this.DoublePos44.Location = new System.Drawing.Point(596, 970);
            this.DoublePos44.Name = "DoublePos44";
            this.DoublePos44.Size = new System.Drawing.Size(56, 22);
            this.DoublePos44.TabIndex = 428;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(6, 223);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(38, 17);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "10";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // DoublePos43
            // 
            this.DoublePos43.Enabled = false;
            this.DoublePos43.Location = new System.Drawing.Point(596, 948);
            this.DoublePos43.Name = "DoublePos43";
            this.DoublePos43.Size = new System.Drawing.Size(56, 22);
            this.DoublePos43.TabIndex = 427;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(6, 245);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(38, 17);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "11";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // DoublePos42
            // 
            this.DoublePos42.Enabled = false;
            this.DoublePos42.Location = new System.Drawing.Point(596, 926);
            this.DoublePos42.Name = "DoublePos42";
            this.DoublePos42.Size = new System.Drawing.Size(56, 22);
            this.DoublePos42.TabIndex = 426;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(6, 267);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(38, 17);
            this.checkBox12.TabIndex = 11;
            this.checkBox12.Text = "12";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // DoublePos41
            // 
            this.DoublePos41.Enabled = false;
            this.DoublePos41.Location = new System.Drawing.Point(596, 904);
            this.DoublePos41.Name = "DoublePos41";
            this.DoublePos41.Size = new System.Drawing.Size(56, 22);
            this.DoublePos41.TabIndex = 425;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(6, 289);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(38, 17);
            this.checkBox13.TabIndex = 12;
            this.checkBox13.Text = "13";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // DoublePos40
            // 
            this.DoublePos40.Enabled = false;
            this.DoublePos40.Location = new System.Drawing.Point(596, 882);
            this.DoublePos40.Name = "DoublePos40";
            this.DoublePos40.Size = new System.Drawing.Size(56, 22);
            this.DoublePos40.TabIndex = 424;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(6, 311);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(38, 17);
            this.checkBox14.TabIndex = 13;
            this.checkBox14.Text = "14";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // DoublePos39
            // 
            this.DoublePos39.Enabled = false;
            this.DoublePos39.Location = new System.Drawing.Point(596, 860);
            this.DoublePos39.Name = "DoublePos39";
            this.DoublePos39.Size = new System.Drawing.Size(56, 22);
            this.DoublePos39.TabIndex = 423;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(6, 333);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(38, 17);
            this.checkBox15.TabIndex = 14;
            this.checkBox15.Text = "15";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // DoublePos38
            // 
            this.DoublePos38.Enabled = false;
            this.DoublePos38.Location = new System.Drawing.Point(596, 838);
            this.DoublePos38.Name = "DoublePos38";
            this.DoublePos38.Size = new System.Drawing.Size(56, 22);
            this.DoublePos38.TabIndex = 422;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(6, 355);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(38, 17);
            this.checkBox16.TabIndex = 15;
            this.checkBox16.Text = "16";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
            // 
            // DoublePos37
            // 
            this.DoublePos37.Enabled = false;
            this.DoublePos37.Location = new System.Drawing.Point(596, 816);
            this.DoublePos37.Name = "DoublePos37";
            this.DoublePos37.Size = new System.Drawing.Size(56, 22);
            this.DoublePos37.TabIndex = 421;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(6, 377);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(38, 17);
            this.checkBox17.TabIndex = 16;
            this.checkBox17.Text = "17";
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.checkBox17_CheckedChanged);
            // 
            // DoublePos36
            // 
            this.DoublePos36.Enabled = false;
            this.DoublePos36.Location = new System.Drawing.Point(596, 794);
            this.DoublePos36.Name = "DoublePos36";
            this.DoublePos36.Size = new System.Drawing.Size(56, 22);
            this.DoublePos36.TabIndex = 420;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(6, 399);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(38, 17);
            this.checkBox18.TabIndex = 17;
            this.checkBox18.Text = "18";
            this.checkBox18.UseVisualStyleBackColor = true;
            this.checkBox18.CheckedChanged += new System.EventHandler(this.checkBox18_CheckedChanged);
            // 
            // DoublePos35
            // 
            this.DoublePos35.Enabled = false;
            this.DoublePos35.Location = new System.Drawing.Point(596, 772);
            this.DoublePos35.Name = "DoublePos35";
            this.DoublePos35.Size = new System.Drawing.Size(56, 22);
            this.DoublePos35.TabIndex = 419;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(6, 421);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(38, 17);
            this.checkBox19.TabIndex = 18;
            this.checkBox19.Text = "19";
            this.checkBox19.UseVisualStyleBackColor = true;
            this.checkBox19.CheckedChanged += new System.EventHandler(this.checkBox19_CheckedChanged);
            // 
            // DoublePos34
            // 
            this.DoublePos34.Enabled = false;
            this.DoublePos34.Location = new System.Drawing.Point(596, 750);
            this.DoublePos34.Name = "DoublePos34";
            this.DoublePos34.Size = new System.Drawing.Size(56, 22);
            this.DoublePos34.TabIndex = 418;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(6, 443);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(38, 17);
            this.checkBox20.TabIndex = 19;
            this.checkBox20.Text = "20";
            this.checkBox20.UseVisualStyleBackColor = true;
            this.checkBox20.CheckedChanged += new System.EventHandler(this.checkBox20_CheckedChanged);
            // 
            // DoublePos33
            // 
            this.DoublePos33.Enabled = false;
            this.DoublePos33.Location = new System.Drawing.Point(596, 728);
            this.DoublePos33.Name = "DoublePos33";
            this.DoublePos33.Size = new System.Drawing.Size(56, 22);
            this.DoublePos33.TabIndex = 417;
            // 
            // Seat1
            // 
            this.Seat1.FormattingEnabled = true;
            this.Seat1.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat1.Location = new System.Drawing.Point(90, 23);
            this.Seat1.Name = "Seat1";
            this.Seat1.Size = new System.Drawing.Size(61, 21);
            this.Seat1.TabIndex = 20;
            // 
            // DoublePos32
            // 
            this.DoublePos32.Enabled = false;
            this.DoublePos32.Location = new System.Drawing.Point(596, 706);
            this.DoublePos32.Name = "DoublePos32";
            this.DoublePos32.Size = new System.Drawing.Size(56, 22);
            this.DoublePos32.TabIndex = 416;
            // 
            // Seat2
            // 
            this.Seat2.FormattingEnabled = true;
            this.Seat2.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat2.Location = new System.Drawing.Point(90, 45);
            this.Seat2.Name = "Seat2";
            this.Seat2.Size = new System.Drawing.Size(61, 21);
            this.Seat2.TabIndex = 21;
            // 
            // DoublePos31
            // 
            this.DoublePos31.Enabled = false;
            this.DoublePos31.Location = new System.Drawing.Point(596, 684);
            this.DoublePos31.Name = "DoublePos31";
            this.DoublePos31.Size = new System.Drawing.Size(56, 22);
            this.DoublePos31.TabIndex = 415;
            // 
            // Seat3
            // 
            this.Seat3.FormattingEnabled = true;
            this.Seat3.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat3.Location = new System.Drawing.Point(90, 67);
            this.Seat3.Name = "Seat3";
            this.Seat3.Size = new System.Drawing.Size(61, 21);
            this.Seat3.TabIndex = 22;
            // 
            // DoublePos30
            // 
            this.DoublePos30.Enabled = false;
            this.DoublePos30.Location = new System.Drawing.Point(596, 662);
            this.DoublePos30.Name = "DoublePos30";
            this.DoublePos30.Size = new System.Drawing.Size(56, 22);
            this.DoublePos30.TabIndex = 414;
            // 
            // Seat4
            // 
            this.Seat4.FormattingEnabled = true;
            this.Seat4.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat4.Location = new System.Drawing.Point(90, 89);
            this.Seat4.Name = "Seat4";
            this.Seat4.Size = new System.Drawing.Size(61, 21);
            this.Seat4.TabIndex = 23;
            // 
            // DoublePos29
            // 
            this.DoublePos29.Enabled = false;
            this.DoublePos29.Location = new System.Drawing.Point(596, 640);
            this.DoublePos29.Name = "DoublePos29";
            this.DoublePos29.Size = new System.Drawing.Size(56, 22);
            this.DoublePos29.TabIndex = 413;
            // 
            // Seat5
            // 
            this.Seat5.FormattingEnabled = true;
            this.Seat5.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat5.Location = new System.Drawing.Point(90, 111);
            this.Seat5.Name = "Seat5";
            this.Seat5.Size = new System.Drawing.Size(61, 21);
            this.Seat5.TabIndex = 24;
            // 
            // DoublePos28
            // 
            this.DoublePos28.Enabled = false;
            this.DoublePos28.Location = new System.Drawing.Point(596, 618);
            this.DoublePos28.Name = "DoublePos28";
            this.DoublePos28.Size = new System.Drawing.Size(56, 22);
            this.DoublePos28.TabIndex = 412;
            // 
            // Seat6
            // 
            this.Seat6.FormattingEnabled = true;
            this.Seat6.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat6.Location = new System.Drawing.Point(90, 133);
            this.Seat6.Name = "Seat6";
            this.Seat6.Size = new System.Drawing.Size(61, 21);
            this.Seat6.TabIndex = 25;
            // 
            // DoublePos27
            // 
            this.DoublePos27.Enabled = false;
            this.DoublePos27.Location = new System.Drawing.Point(596, 596);
            this.DoublePos27.Name = "DoublePos27";
            this.DoublePos27.Size = new System.Drawing.Size(56, 22);
            this.DoublePos27.TabIndex = 411;
            // 
            // Seat7
            // 
            this.Seat7.FormattingEnabled = true;
            this.Seat7.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat7.Location = new System.Drawing.Point(90, 155);
            this.Seat7.Name = "Seat7";
            this.Seat7.Size = new System.Drawing.Size(61, 21);
            this.Seat7.TabIndex = 26;
            // 
            // DoublePos26
            // 
            this.DoublePos26.Enabled = false;
            this.DoublePos26.Location = new System.Drawing.Point(596, 573);
            this.DoublePos26.Name = "DoublePos26";
            this.DoublePos26.Size = new System.Drawing.Size(56, 22);
            this.DoublePos26.TabIndex = 410;
            // 
            // Seat8
            // 
            this.Seat8.FormattingEnabled = true;
            this.Seat8.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat8.Location = new System.Drawing.Point(90, 177);
            this.Seat8.Name = "Seat8";
            this.Seat8.Size = new System.Drawing.Size(61, 21);
            this.Seat8.TabIndex = 27;
            // 
            // DoublePos25
            // 
            this.DoublePos25.Enabled = false;
            this.DoublePos25.Location = new System.Drawing.Point(596, 551);
            this.DoublePos25.Name = "DoublePos25";
            this.DoublePos25.Size = new System.Drawing.Size(56, 22);
            this.DoublePos25.TabIndex = 409;
            // 
            // Seat9
            // 
            this.Seat9.FormattingEnabled = true;
            this.Seat9.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat9.Location = new System.Drawing.Point(90, 199);
            this.Seat9.Name = "Seat9";
            this.Seat9.Size = new System.Drawing.Size(61, 21);
            this.Seat9.TabIndex = 28;
            // 
            // DoublePos24
            // 
            this.DoublePos24.Enabled = false;
            this.DoublePos24.Location = new System.Drawing.Point(596, 529);
            this.DoublePos24.Name = "DoublePos24";
            this.DoublePos24.Size = new System.Drawing.Size(56, 22);
            this.DoublePos24.TabIndex = 408;
            // 
            // Seat10
            // 
            this.Seat10.FormattingEnabled = true;
            this.Seat10.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat10.Location = new System.Drawing.Point(90, 221);
            this.Seat10.Name = "Seat10";
            this.Seat10.Size = new System.Drawing.Size(61, 21);
            this.Seat10.TabIndex = 29;
            // 
            // DoublePos23
            // 
            this.DoublePos23.Enabled = false;
            this.DoublePos23.Location = new System.Drawing.Point(596, 507);
            this.DoublePos23.Name = "DoublePos23";
            this.DoublePos23.Size = new System.Drawing.Size(56, 22);
            this.DoublePos23.TabIndex = 407;
            // 
            // Seat11
            // 
            this.Seat11.FormattingEnabled = true;
            this.Seat11.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat11.Location = new System.Drawing.Point(90, 243);
            this.Seat11.Name = "Seat11";
            this.Seat11.Size = new System.Drawing.Size(61, 21);
            this.Seat11.TabIndex = 30;
            // 
            // DoublePos22
            // 
            this.DoublePos22.Enabled = false;
            this.DoublePos22.Location = new System.Drawing.Point(596, 485);
            this.DoublePos22.Name = "DoublePos22";
            this.DoublePos22.Size = new System.Drawing.Size(56, 22);
            this.DoublePos22.TabIndex = 406;
            // 
            // Seat12
            // 
            this.Seat12.FormattingEnabled = true;
            this.Seat12.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat12.Location = new System.Drawing.Point(90, 265);
            this.Seat12.Name = "Seat12";
            this.Seat12.Size = new System.Drawing.Size(61, 21);
            this.Seat12.TabIndex = 31;
            // 
            // DoublePos21
            // 
            this.DoublePos21.Enabled = false;
            this.DoublePos21.Location = new System.Drawing.Point(596, 463);
            this.DoublePos21.Name = "DoublePos21";
            this.DoublePos21.Size = new System.Drawing.Size(56, 22);
            this.DoublePos21.TabIndex = 405;
            // 
            // Seat13
            // 
            this.Seat13.FormattingEnabled = true;
            this.Seat13.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat13.Location = new System.Drawing.Point(90, 287);
            this.Seat13.Name = "Seat13";
            this.Seat13.Size = new System.Drawing.Size(61, 21);
            this.Seat13.TabIndex = 32;
            // 
            // DoublePos20
            // 
            this.DoublePos20.Enabled = false;
            this.DoublePos20.Location = new System.Drawing.Point(596, 441);
            this.DoublePos20.Name = "DoublePos20";
            this.DoublePos20.Size = new System.Drawing.Size(56, 22);
            this.DoublePos20.TabIndex = 404;
            // 
            // Seat14
            // 
            this.Seat14.FormattingEnabled = true;
            this.Seat14.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat14.Location = new System.Drawing.Point(90, 309);
            this.Seat14.Name = "Seat14";
            this.Seat14.Size = new System.Drawing.Size(61, 21);
            this.Seat14.TabIndex = 33;
            // 
            // DoublePos19
            // 
            this.DoublePos19.Enabled = false;
            this.DoublePos19.Location = new System.Drawing.Point(596, 419);
            this.DoublePos19.Name = "DoublePos19";
            this.DoublePos19.Size = new System.Drawing.Size(56, 22);
            this.DoublePos19.TabIndex = 403;
            // 
            // Seat15
            // 
            this.Seat15.FormattingEnabled = true;
            this.Seat15.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat15.Location = new System.Drawing.Point(90, 331);
            this.Seat15.Name = "Seat15";
            this.Seat15.Size = new System.Drawing.Size(61, 21);
            this.Seat15.TabIndex = 34;
            // 
            // DoublePos18
            // 
            this.DoublePos18.Enabled = false;
            this.DoublePos18.Location = new System.Drawing.Point(596, 397);
            this.DoublePos18.Name = "DoublePos18";
            this.DoublePos18.Size = new System.Drawing.Size(56, 22);
            this.DoublePos18.TabIndex = 402;
            // 
            // Seat16
            // 
            this.Seat16.FormattingEnabled = true;
            this.Seat16.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat16.Location = new System.Drawing.Point(90, 353);
            this.Seat16.Name = "Seat16";
            this.Seat16.Size = new System.Drawing.Size(61, 21);
            this.Seat16.TabIndex = 35;
            // 
            // DoublePos17
            // 
            this.DoublePos17.Enabled = false;
            this.DoublePos17.Location = new System.Drawing.Point(596, 375);
            this.DoublePos17.Name = "DoublePos17";
            this.DoublePos17.Size = new System.Drawing.Size(56, 22);
            this.DoublePos17.TabIndex = 401;
            // 
            // Seat17
            // 
            this.Seat17.FormattingEnabled = true;
            this.Seat17.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat17.Location = new System.Drawing.Point(90, 375);
            this.Seat17.Name = "Seat17";
            this.Seat17.Size = new System.Drawing.Size(61, 21);
            this.Seat17.TabIndex = 36;
            // 
            // DoublePos16
            // 
            this.DoublePos16.Enabled = false;
            this.DoublePos16.Location = new System.Drawing.Point(596, 353);
            this.DoublePos16.Name = "DoublePos16";
            this.DoublePos16.Size = new System.Drawing.Size(56, 22);
            this.DoublePos16.TabIndex = 400;
            // 
            // Seat18
            // 
            this.Seat18.FormattingEnabled = true;
            this.Seat18.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat18.Location = new System.Drawing.Point(90, 397);
            this.Seat18.Name = "Seat18";
            this.Seat18.Size = new System.Drawing.Size(61, 21);
            this.Seat18.TabIndex = 37;
            // 
            // DoublePos15
            // 
            this.DoublePos15.Enabled = false;
            this.DoublePos15.Location = new System.Drawing.Point(596, 331);
            this.DoublePos15.Name = "DoublePos15";
            this.DoublePos15.Size = new System.Drawing.Size(56, 22);
            this.DoublePos15.TabIndex = 399;
            // 
            // Seat19
            // 
            this.Seat19.FormattingEnabled = true;
            this.Seat19.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat19.Location = new System.Drawing.Point(90, 419);
            this.Seat19.Name = "Seat19";
            this.Seat19.Size = new System.Drawing.Size(61, 21);
            this.Seat19.TabIndex = 38;
            // 
            // DoublePos14
            // 
            this.DoublePos14.Enabled = false;
            this.DoublePos14.Location = new System.Drawing.Point(596, 309);
            this.DoublePos14.Name = "DoublePos14";
            this.DoublePos14.Size = new System.Drawing.Size(56, 22);
            this.DoublePos14.TabIndex = 398;
            // 
            // Seat20
            // 
            this.Seat20.FormattingEnabled = true;
            this.Seat20.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat20.Location = new System.Drawing.Point(90, 441);
            this.Seat20.Name = "Seat20";
            this.Seat20.Size = new System.Drawing.Size(61, 21);
            this.Seat20.TabIndex = 39;
            // 
            // DoublePos13
            // 
            this.DoublePos13.Enabled = false;
            this.DoublePos13.Location = new System.Drawing.Point(596, 287);
            this.DoublePos13.Name = "DoublePos13";
            this.DoublePos13.Size = new System.Drawing.Size(56, 22);
            this.DoublePos13.TabIndex = 397;
            // 
            // Motor1
            // 
            this.Motor1.FormattingEnabled = true;
            this.Motor1.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor1.Location = new System.Drawing.Point(157, 23);
            this.Motor1.Name = "Motor1";
            this.Motor1.Size = new System.Drawing.Size(74, 21);
            this.Motor1.TabIndex = 40;
            // 
            // DoublePos12
            // 
            this.DoublePos12.Enabled = false;
            this.DoublePos12.Location = new System.Drawing.Point(596, 265);
            this.DoublePos12.Name = "DoublePos12";
            this.DoublePos12.Size = new System.Drawing.Size(56, 22);
            this.DoublePos12.TabIndex = 396;
            // 
            // Motor2
            // 
            this.Motor2.FormattingEnabled = true;
            this.Motor2.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor2.Location = new System.Drawing.Point(157, 45);
            this.Motor2.Name = "Motor2";
            this.Motor2.Size = new System.Drawing.Size(74, 21);
            this.Motor2.TabIndex = 41;
            // 
            // DoublePos11
            // 
            this.DoublePos11.Enabled = false;
            this.DoublePos11.Location = new System.Drawing.Point(596, 243);
            this.DoublePos11.Name = "DoublePos11";
            this.DoublePos11.Size = new System.Drawing.Size(56, 22);
            this.DoublePos11.TabIndex = 395;
            // 
            // Motor3
            // 
            this.Motor3.FormattingEnabled = true;
            this.Motor3.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor3.Location = new System.Drawing.Point(157, 67);
            this.Motor3.Name = "Motor3";
            this.Motor3.Size = new System.Drawing.Size(74, 21);
            this.Motor3.TabIndex = 42;
            // 
            // DoublePos10
            // 
            this.DoublePos10.Enabled = false;
            this.DoublePos10.Location = new System.Drawing.Point(596, 221);
            this.DoublePos10.Name = "DoublePos10";
            this.DoublePos10.Size = new System.Drawing.Size(56, 22);
            this.DoublePos10.TabIndex = 394;
            // 
            // Motor4
            // 
            this.Motor4.FormattingEnabled = true;
            this.Motor4.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor4.Location = new System.Drawing.Point(157, 89);
            this.Motor4.Name = "Motor4";
            this.Motor4.Size = new System.Drawing.Size(74, 21);
            this.Motor4.TabIndex = 43;
            // 
            // DoublePos9
            // 
            this.DoublePos9.Enabled = false;
            this.DoublePos9.Location = new System.Drawing.Point(596, 199);
            this.DoublePos9.Name = "DoublePos9";
            this.DoublePos9.Size = new System.Drawing.Size(56, 22);
            this.DoublePos9.TabIndex = 393;
            // 
            // Motor5
            // 
            this.Motor5.FormattingEnabled = true;
            this.Motor5.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor5.Location = new System.Drawing.Point(157, 111);
            this.Motor5.Name = "Motor5";
            this.Motor5.Size = new System.Drawing.Size(74, 21);
            this.Motor5.TabIndex = 44;
            // 
            // DoublePos8
            // 
            this.DoublePos8.Enabled = false;
            this.DoublePos8.Location = new System.Drawing.Point(596, 177);
            this.DoublePos8.Name = "DoublePos8";
            this.DoublePos8.Size = new System.Drawing.Size(56, 22);
            this.DoublePos8.TabIndex = 392;
            // 
            // Motor6
            // 
            this.Motor6.FormattingEnabled = true;
            this.Motor6.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor6.Location = new System.Drawing.Point(157, 133);
            this.Motor6.Name = "Motor6";
            this.Motor6.Size = new System.Drawing.Size(74, 21);
            this.Motor6.TabIndex = 45;
            // 
            // DoublePos7
            // 
            this.DoublePos7.Enabled = false;
            this.DoublePos7.Location = new System.Drawing.Point(596, 155);
            this.DoublePos7.Name = "DoublePos7";
            this.DoublePos7.Size = new System.Drawing.Size(56, 22);
            this.DoublePos7.TabIndex = 391;
            // 
            // Motor7
            // 
            this.Motor7.FormattingEnabled = true;
            this.Motor7.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor7.Location = new System.Drawing.Point(157, 155);
            this.Motor7.Name = "Motor7";
            this.Motor7.Size = new System.Drawing.Size(74, 21);
            this.Motor7.TabIndex = 46;
            // 
            // DoublePos6
            // 
            this.DoublePos6.Enabled = false;
            this.DoublePos6.Location = new System.Drawing.Point(596, 133);
            this.DoublePos6.Name = "DoublePos6";
            this.DoublePos6.Size = new System.Drawing.Size(56, 22);
            this.DoublePos6.TabIndex = 390;
            // 
            // Motor8
            // 
            this.Motor8.FormattingEnabled = true;
            this.Motor8.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor8.Location = new System.Drawing.Point(157, 177);
            this.Motor8.Name = "Motor8";
            this.Motor8.Size = new System.Drawing.Size(74, 21);
            this.Motor8.TabIndex = 47;
            // 
            // DoublePos5
            // 
            this.DoublePos5.Enabled = false;
            this.DoublePos5.Location = new System.Drawing.Point(596, 111);
            this.DoublePos5.Name = "DoublePos5";
            this.DoublePos5.Size = new System.Drawing.Size(56, 22);
            this.DoublePos5.TabIndex = 389;
            // 
            // Motor9
            // 
            this.Motor9.FormattingEnabled = true;
            this.Motor9.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor9.Location = new System.Drawing.Point(157, 199);
            this.Motor9.Name = "Motor9";
            this.Motor9.Size = new System.Drawing.Size(74, 21);
            this.Motor9.TabIndex = 48;
            // 
            // DoublePos4
            // 
            this.DoublePos4.Enabled = false;
            this.DoublePos4.Location = new System.Drawing.Point(596, 89);
            this.DoublePos4.Name = "DoublePos4";
            this.DoublePos4.Size = new System.Drawing.Size(56, 22);
            this.DoublePos4.TabIndex = 388;
            // 
            // Motor10
            // 
            this.Motor10.FormattingEnabled = true;
            this.Motor10.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor10.Location = new System.Drawing.Point(157, 221);
            this.Motor10.Name = "Motor10";
            this.Motor10.Size = new System.Drawing.Size(74, 21);
            this.Motor10.TabIndex = 49;
            // 
            // DoublePos3
            // 
            this.DoublePos3.Enabled = false;
            this.DoublePos3.Location = new System.Drawing.Point(596, 67);
            this.DoublePos3.Name = "DoublePos3";
            this.DoublePos3.Size = new System.Drawing.Size(56, 22);
            this.DoublePos3.TabIndex = 387;
            // 
            // Motor11
            // 
            this.Motor11.FormattingEnabled = true;
            this.Motor11.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor11.Location = new System.Drawing.Point(157, 243);
            this.Motor11.Name = "Motor11";
            this.Motor11.Size = new System.Drawing.Size(74, 21);
            this.Motor11.TabIndex = 50;
            // 
            // DoublePos2
            // 
            this.DoublePos2.Enabled = false;
            this.DoublePos2.Location = new System.Drawing.Point(596, 45);
            this.DoublePos2.Name = "DoublePos2";
            this.DoublePos2.Size = new System.Drawing.Size(56, 22);
            this.DoublePos2.TabIndex = 386;
            // 
            // Motor12
            // 
            this.Motor12.FormattingEnabled = true;
            this.Motor12.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor12.Location = new System.Drawing.Point(157, 265);
            this.Motor12.Name = "Motor12";
            this.Motor12.Size = new System.Drawing.Size(74, 21);
            this.Motor12.TabIndex = 51;
            // 
            // DoublePos1
            // 
            this.DoublePos1.Enabled = false;
            this.DoublePos1.Location = new System.Drawing.Point(596, 23);
            this.DoublePos1.Name = "DoublePos1";
            this.DoublePos1.Size = new System.Drawing.Size(56, 22);
            this.DoublePos1.TabIndex = 385;
            // 
            // Motor13
            // 
            this.Motor13.FormattingEnabled = true;
            this.Motor13.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor13.Location = new System.Drawing.Point(157, 287);
            this.Motor13.Name = "Motor13";
            this.Motor13.Size = new System.Drawing.Size(74, 21);
            this.Motor13.TabIndex = 52;
            // 
            // Pos1
            // 
            this.Pos1.Location = new System.Drawing.Point(531, 24);
            this.Pos1.Maximum = new decimal(new int[] {
            103,
            0,
            0,
            0});
            this.Pos1.Name = "Pos1";
            this.Pos1.Size = new System.Drawing.Size(52, 22);
            this.Pos1.TabIndex = 384;
            // 
            // Motor14
            // 
            this.Motor14.FormattingEnabled = true;
            this.Motor14.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor14.Location = new System.Drawing.Point(157, 309);
            this.Motor14.Name = "Motor14";
            this.Motor14.Size = new System.Drawing.Size(74, 21);
            this.Motor14.TabIndex = 53;
            // 
            // SecRwRtStMassStrsHMI2RReq
            // 
            this.SecRwRtStMassStrsHMI2RReq.FormattingEnabled = true;
            this.SecRwRtStMassStrsHMI2RReq.Items.AddRange(new object[] {
            "0=No Action",
            "1=Massage Stress Level 1",
            "2=Massage Stress Level 2",
            "3=Massage Stress Level 3",
            "4=Massage off"});
            this.SecRwRtStMassStrsHMI2RReq.Location = new System.Drawing.Point(764, 473);
            this.SecRwRtStMassStrsHMI2RReq.Name = "SecRwRtStMassStrsHMI2RReq";
            this.SecRwRtStMassStrsHMI2RReq.Size = new System.Drawing.Size(136, 21);
            this.SecRwRtStMassStrsHMI2RReq.TabIndex = 383;
            this.SecRwRtStMassStrsHMI2RReq.SelectedIndexChanged += new System.EventHandler(this.SecRwRtStMassStrsHMI2RReq_SelectedIndexChanged);
            // 
            // Motor15
            // 
            this.Motor15.FormattingEnabled = true;
            this.Motor15.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor15.Location = new System.Drawing.Point(157, 331);
            this.Motor15.Name = "Motor15";
            this.Motor15.Size = new System.Drawing.Size(74, 21);
            this.Motor15.TabIndex = 54;
            // 
            // SecRwRtStMassMdHMI2RReq
            // 
            this.SecRwRtStMassMdHMI2RReq.FormattingEnabled = true;
            this.SecRwRtStMassMdHMI2RReq.Items.AddRange(new object[] {
            "0=No Action; ",
            "1=Massage Mode 1",
            "2=Massage Mode 2",
            "3=Massage Mode 3",
            "4=Massage Mode 4",
            "5=Massage Mode 5 ",
            "6=Massage Mode 6 ",
            "7=Massage Mode 7",
            "8=Massage Mode 8"});
            this.SecRwRtStMassMdHMI2RReq.Location = new System.Drawing.Point(765, 437);
            this.SecRwRtStMassMdHMI2RReq.Name = "SecRwRtStMassMdHMI2RReq";
            this.SecRwRtStMassMdHMI2RReq.Size = new System.Drawing.Size(135, 21);
            this.SecRwRtStMassMdHMI2RReq.TabIndex = 382;
            this.SecRwRtStMassMdHMI2RReq.SelectedIndexChanged += new System.EventHandler(this.SecRwRtStMassMdHMI2RReq_SelectedIndexChanged);
            // 
            // Motor16
            // 
            this.Motor16.FormattingEnabled = true;
            this.Motor16.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor16.Location = new System.Drawing.Point(157, 353);
            this.Motor16.Name = "Motor16";
            this.Motor16.Size = new System.Drawing.Size(74, 21);
            this.Motor16.TabIndex = 55;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(686, 476);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 381;
            this.label20.Text = "2R按摩强度";
            // 
            // Motor17
            // 
            this.Motor17.FormattingEnabled = true;
            this.Motor17.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor17.Location = new System.Drawing.Point(157, 375);
            this.Motor17.Name = "Motor17";
            this.Motor17.Size = new System.Drawing.Size(74, 21);
            this.Motor17.TabIndex = 56;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(687, 440);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 380;
            this.label19.Text = "2R按摩模式";
            // 
            // Motor18
            // 
            this.Motor18.FormattingEnabled = true;
            this.Motor18.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor18.Location = new System.Drawing.Point(157, 397);
            this.Motor18.Name = "Motor18";
            this.Motor18.Size = new System.Drawing.Size(74, 21);
            this.Motor18.TabIndex = 57;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.R3_HeatOFF);
            this.groupBox9.Controls.Add(this.R3_Heat3);
            this.groupBox9.Controls.Add(this.R3_Heat2);
            this.groupBox9.Controls.Add(this.R3_Heat1);
            this.groupBox9.Location = new System.Drawing.Point(681, 350);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(194, 75);
            this.groupBox9.TabIndex = 379;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "3R加热";
            // 
            // R3_HeatOFF
            // 
            this.R3_HeatOFF.AutoSize = true;
            this.R3_HeatOFF.Location = new System.Drawing.Point(101, 48);
            this.R3_HeatOFF.Name = "R3_HeatOFF";
            this.R3_HeatOFF.Size = new System.Drawing.Size(46, 17);
            this.R3_HeatOFF.TabIndex = 7;
            this.R3_HeatOFF.TabStop = true;
            this.R3_HeatOFF.Text = "OFF";
            this.R3_HeatOFF.UseVisualStyleBackColor = true;
            this.R3_HeatOFF.CheckedChanged += new System.EventHandler(this.R3_HeatOFF_CheckedChanged);
            // 
            // R3_Heat3
            // 
            this.R3_Heat3.AutoSize = true;
            this.R3_Heat3.Location = new System.Drawing.Point(22, 48);
            this.R3_Heat3.Name = "R3_Heat3";
            this.R3_Heat3.Size = new System.Drawing.Size(44, 17);
            this.R3_Heat3.TabIndex = 6;
            this.R3_Heat3.TabStop = true;
            this.R3_Heat3.Text = "3档";
            this.R3_Heat3.UseVisualStyleBackColor = true;
            this.R3_Heat3.CheckedChanged += new System.EventHandler(this.R3_Heat3_CheckedChanged);
            // 
            // R3_Heat2
            // 
            this.R3_Heat2.AutoSize = true;
            this.R3_Heat2.Location = new System.Drawing.Point(101, 21);
            this.R3_Heat2.Name = "R3_Heat2";
            this.R3_Heat2.Size = new System.Drawing.Size(44, 17);
            this.R3_Heat2.TabIndex = 5;
            this.R3_Heat2.TabStop = true;
            this.R3_Heat2.Text = "2档";
            this.R3_Heat2.UseVisualStyleBackColor = true;
            this.R3_Heat2.CheckedChanged += new System.EventHandler(this.R3_Heat2_CheckedChanged);
            // 
            // R3_Heat1
            // 
            this.R3_Heat1.AutoSize = true;
            this.R3_Heat1.Location = new System.Drawing.Point(22, 21);
            this.R3_Heat1.Name = "R3_Heat1";
            this.R3_Heat1.Size = new System.Drawing.Size(44, 17);
            this.R3_Heat1.TabIndex = 4;
            this.R3_Heat1.TabStop = true;
            this.R3_Heat1.Text = "1档";
            this.R3_Heat1.UseVisualStyleBackColor = true;
            this.R3_Heat1.CheckedChanged += new System.EventHandler(this.R3_Heat1_CheckedChanged);
            // 
            // Motor19
            // 
            this.Motor19.FormattingEnabled = true;
            this.Motor19.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor19.Location = new System.Drawing.Point(157, 419);
            this.Motor19.Name = "Motor19";
            this.Motor19.Size = new System.Drawing.Size(74, 21);
            this.Motor19.TabIndex = 58;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.R3_VentOFF);
            this.groupBox10.Controls.Add(this.R3_Vent3);
            this.groupBox10.Controls.Add(this.R3_Vent2);
            this.groupBox10.Controls.Add(this.R3_Vent1);
            this.groupBox10.Location = new System.Drawing.Point(890, 350);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(194, 75);
            this.groupBox10.TabIndex = 378;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "3R通风";
            // 
            // R3_VentOFF
            // 
            this.R3_VentOFF.AutoSize = true;
            this.R3_VentOFF.Location = new System.Drawing.Point(99, 48);
            this.R3_VentOFF.Name = "R3_VentOFF";
            this.R3_VentOFF.Size = new System.Drawing.Size(46, 17);
            this.R3_VentOFF.TabIndex = 7;
            this.R3_VentOFF.TabStop = true;
            this.R3_VentOFF.Text = "OFF";
            this.R3_VentOFF.UseVisualStyleBackColor = true;
            this.R3_VentOFF.CheckedChanged += new System.EventHandler(this.R3_VentOFF_CheckedChanged);
            // 
            // R3_Vent3
            // 
            this.R3_Vent3.AutoSize = true;
            this.R3_Vent3.Location = new System.Drawing.Point(20, 48);
            this.R3_Vent3.Name = "R3_Vent3";
            this.R3_Vent3.Size = new System.Drawing.Size(44, 17);
            this.R3_Vent3.TabIndex = 6;
            this.R3_Vent3.TabStop = true;
            this.R3_Vent3.Text = "3档";
            this.R3_Vent3.UseVisualStyleBackColor = true;
            this.R3_Vent3.CheckedChanged += new System.EventHandler(this.R3_Vent3_CheckedChanged);
            // 
            // R3_Vent2
            // 
            this.R3_Vent2.AutoSize = true;
            this.R3_Vent2.Location = new System.Drawing.Point(99, 21);
            this.R3_Vent2.Name = "R3_Vent2";
            this.R3_Vent2.Size = new System.Drawing.Size(44, 17);
            this.R3_Vent2.TabIndex = 5;
            this.R3_Vent2.TabStop = true;
            this.R3_Vent2.Text = "2档";
            this.R3_Vent2.UseVisualStyleBackColor = true;
            this.R3_Vent2.CheckedChanged += new System.EventHandler(this.R3_Vent2_CheckedChanged);
            // 
            // R3_Vent1
            // 
            this.R3_Vent1.AutoSize = true;
            this.R3_Vent1.Location = new System.Drawing.Point(20, 21);
            this.R3_Vent1.Name = "R3_Vent1";
            this.R3_Vent1.Size = new System.Drawing.Size(44, 17);
            this.R3_Vent1.TabIndex = 4;
            this.R3_Vent1.TabStop = true;
            this.R3_Vent1.Text = "1档";
            this.R3_Vent1.UseVisualStyleBackColor = true;
            this.R3_Vent1.CheckedChanged += new System.EventHandler(this.R3_Vent1_CheckedChanged);
            // 
            // Motor20
            // 
            this.Motor20.FormattingEnabled = true;
            this.Motor20.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor20.Location = new System.Drawing.Point(157, 441);
            this.Motor20.Name = "Motor20";
            this.Motor20.Size = new System.Drawing.Size(74, 21);
            this.Motor20.TabIndex = 59;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.L3_HeatOFF);
            this.groupBox7.Controls.Add(this.L3_Heat3);
            this.groupBox7.Controls.Add(this.L3_Heat2);
            this.groupBox7.Controls.Add(this.L3_Heat1);
            this.groupBox7.Location = new System.Drawing.Point(681, 269);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(194, 75);
            this.groupBox7.TabIndex = 377;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "3L加热";
            // 
            // L3_HeatOFF
            // 
            this.L3_HeatOFF.AutoSize = true;
            this.L3_HeatOFF.Location = new System.Drawing.Point(101, 48);
            this.L3_HeatOFF.Name = "L3_HeatOFF";
            this.L3_HeatOFF.Size = new System.Drawing.Size(46, 17);
            this.L3_HeatOFF.TabIndex = 7;
            this.L3_HeatOFF.TabStop = true;
            this.L3_HeatOFF.Text = "OFF";
            this.L3_HeatOFF.UseVisualStyleBackColor = true;
            this.L3_HeatOFF.CheckedChanged += new System.EventHandler(this.L3_HeatOFF_CheckedChanged);
            // 
            // L3_Heat3
            // 
            this.L3_Heat3.AutoSize = true;
            this.L3_Heat3.Location = new System.Drawing.Point(22, 48);
            this.L3_Heat3.Name = "L3_Heat3";
            this.L3_Heat3.Size = new System.Drawing.Size(44, 17);
            this.L3_Heat3.TabIndex = 6;
            this.L3_Heat3.TabStop = true;
            this.L3_Heat3.Text = "3档";
            this.L3_Heat3.UseVisualStyleBackColor = true;
            this.L3_Heat3.CheckedChanged += new System.EventHandler(this.L3_Heat3_CheckedChanged);
            // 
            // L3_Heat2
            // 
            this.L3_Heat2.AutoSize = true;
            this.L3_Heat2.Location = new System.Drawing.Point(101, 21);
            this.L3_Heat2.Name = "L3_Heat2";
            this.L3_Heat2.Size = new System.Drawing.Size(44, 17);
            this.L3_Heat2.TabIndex = 5;
            this.L3_Heat2.TabStop = true;
            this.L3_Heat2.Text = "2档";
            this.L3_Heat2.UseVisualStyleBackColor = true;
            this.L3_Heat2.CheckedChanged += new System.EventHandler(this.L3_Heat2_CheckedChanged);
            // 
            // L3_Heat1
            // 
            this.L3_Heat1.AutoSize = true;
            this.L3_Heat1.Location = new System.Drawing.Point(22, 21);
            this.L3_Heat1.Name = "L3_Heat1";
            this.L3_Heat1.Size = new System.Drawing.Size(44, 17);
            this.L3_Heat1.TabIndex = 4;
            this.L3_Heat1.TabStop = true;
            this.L3_Heat1.Text = "1档";
            this.L3_Heat1.UseVisualStyleBackColor = true;
            this.L3_Heat1.CheckedChanged += new System.EventHandler(this.L3_Heat1_CheckedChanged);
            // 
            // Start1
            // 
            this.Start1.Location = new System.Drawing.Point(265, 24);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(52, 22);
            this.Start1.TabIndex = 60;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.L3_VentOFF);
            this.groupBox8.Controls.Add(this.L3_Vent3);
            this.groupBox8.Controls.Add(this.L3_Vent2);
            this.groupBox8.Controls.Add(this.L3_Vent1);
            this.groupBox8.Location = new System.Drawing.Point(890, 269);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(194, 75);
            this.groupBox8.TabIndex = 376;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "3L通风";
            // 
            // L3_VentOFF
            // 
            this.L3_VentOFF.AutoSize = true;
            this.L3_VentOFF.Location = new System.Drawing.Point(99, 48);
            this.L3_VentOFF.Name = "L3_VentOFF";
            this.L3_VentOFF.Size = new System.Drawing.Size(46, 17);
            this.L3_VentOFF.TabIndex = 7;
            this.L3_VentOFF.TabStop = true;
            this.L3_VentOFF.Text = "OFF";
            this.L3_VentOFF.UseVisualStyleBackColor = true;
            this.L3_VentOFF.CheckedChanged += new System.EventHandler(this.L3_VentOFF_CheckedChanged);
            // 
            // L3_Vent3
            // 
            this.L3_Vent3.AutoSize = true;
            this.L3_Vent3.Location = new System.Drawing.Point(20, 48);
            this.L3_Vent3.Name = "L3_Vent3";
            this.L3_Vent3.Size = new System.Drawing.Size(44, 17);
            this.L3_Vent3.TabIndex = 6;
            this.L3_Vent3.TabStop = true;
            this.L3_Vent3.Text = "3档";
            this.L3_Vent3.UseVisualStyleBackColor = true;
            this.L3_Vent3.CheckedChanged += new System.EventHandler(this.L3_Vent3_CheckedChanged);
            // 
            // L3_Vent2
            // 
            this.L3_Vent2.AutoSize = true;
            this.L3_Vent2.Location = new System.Drawing.Point(99, 21);
            this.L3_Vent2.Name = "L3_Vent2";
            this.L3_Vent2.Size = new System.Drawing.Size(44, 17);
            this.L3_Vent2.TabIndex = 5;
            this.L3_Vent2.TabStop = true;
            this.L3_Vent2.Text = "2档";
            this.L3_Vent2.UseVisualStyleBackColor = true;
            this.L3_Vent2.CheckedChanged += new System.EventHandler(this.L3_Vent2_CheckedChanged);
            // 
            // L3_Vent1
            // 
            this.L3_Vent1.AutoSize = true;
            this.L3_Vent1.Location = new System.Drawing.Point(20, 21);
            this.L3_Vent1.Name = "L3_Vent1";
            this.L3_Vent1.Size = new System.Drawing.Size(44, 17);
            this.L3_Vent1.TabIndex = 4;
            this.L3_Vent1.TabStop = true;
            this.L3_Vent1.Text = "1档";
            this.L3_Vent1.UseVisualStyleBackColor = true;
            this.L3_Vent1.CheckedChanged += new System.EventHandler(this.L3_Vent1_CheckedChanged);
            // 
            // Start2
            // 
            this.Start2.Location = new System.Drawing.Point(265, 46);
            this.Start2.Name = "Start2";
            this.Start2.Size = new System.Drawing.Size(52, 22);
            this.Start2.TabIndex = 61;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.R2_HeatOFF);
            this.groupBox6.Controls.Add(this.R2_Heat3);
            this.groupBox6.Controls.Add(this.R2_Heat2);
            this.groupBox6.Controls.Add(this.R2_Heat1);
            this.groupBox6.Location = new System.Drawing.Point(681, 188);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(194, 75);
            this.groupBox6.TabIndex = 375;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "2R加热";
            // 
            // R2_HeatOFF
            // 
            this.R2_HeatOFF.AutoSize = true;
            this.R2_HeatOFF.Location = new System.Drawing.Point(101, 48);
            this.R2_HeatOFF.Name = "R2_HeatOFF";
            this.R2_HeatOFF.Size = new System.Drawing.Size(46, 17);
            this.R2_HeatOFF.TabIndex = 7;
            this.R2_HeatOFF.TabStop = true;
            this.R2_HeatOFF.Text = "OFF";
            this.R2_HeatOFF.UseVisualStyleBackColor = true;
            this.R2_HeatOFF.CheckedChanged += new System.EventHandler(this.R2_HeatOFF_CheckedChanged);
            // 
            // R2_Heat3
            // 
            this.R2_Heat3.AutoSize = true;
            this.R2_Heat3.Location = new System.Drawing.Point(22, 48);
            this.R2_Heat3.Name = "R2_Heat3";
            this.R2_Heat3.Size = new System.Drawing.Size(44, 17);
            this.R2_Heat3.TabIndex = 6;
            this.R2_Heat3.TabStop = true;
            this.R2_Heat3.Text = "3档";
            this.R2_Heat3.UseVisualStyleBackColor = true;
            this.R2_Heat3.CheckedChanged += new System.EventHandler(this.R2_Heat3_CheckedChanged);
            // 
            // R2_Heat2
            // 
            this.R2_Heat2.AutoSize = true;
            this.R2_Heat2.Location = new System.Drawing.Point(101, 21);
            this.R2_Heat2.Name = "R2_Heat2";
            this.R2_Heat2.Size = new System.Drawing.Size(44, 17);
            this.R2_Heat2.TabIndex = 5;
            this.R2_Heat2.TabStop = true;
            this.R2_Heat2.Text = "2档";
            this.R2_Heat2.UseVisualStyleBackColor = true;
            this.R2_Heat2.CheckedChanged += new System.EventHandler(this.R2_Heat2_CheckedChanged);
            // 
            // R2_Heat1
            // 
            this.R2_Heat1.AutoSize = true;
            this.R2_Heat1.Location = new System.Drawing.Point(22, 21);
            this.R2_Heat1.Name = "R2_Heat1";
            this.R2_Heat1.Size = new System.Drawing.Size(44, 17);
            this.R2_Heat1.TabIndex = 4;
            this.R2_Heat1.TabStop = true;
            this.R2_Heat1.Text = "1档";
            this.R2_Heat1.UseVisualStyleBackColor = true;
            this.R2_Heat1.CheckedChanged += new System.EventHandler(this.R2_Heat1_CheckedChanged);
            // 
            // Start3
            // 
            this.Start3.Location = new System.Drawing.Point(265, 68);
            this.Start3.Name = "Start3";
            this.Start3.Size = new System.Drawing.Size(52, 22);
            this.Start3.TabIndex = 62;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.R2_VentOFF);
            this.groupBox5.Controls.Add(this.R2_Vent3);
            this.groupBox5.Controls.Add(this.R2_Vent2);
            this.groupBox5.Controls.Add(this.R2_Vent1);
            this.groupBox5.Location = new System.Drawing.Point(890, 188);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 75);
            this.groupBox5.TabIndex = 374;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "2R通风";
            // 
            // R2_VentOFF
            // 
            this.R2_VentOFF.AutoSize = true;
            this.R2_VentOFF.Location = new System.Drawing.Point(99, 48);
            this.R2_VentOFF.Name = "R2_VentOFF";
            this.R2_VentOFF.Size = new System.Drawing.Size(46, 17);
            this.R2_VentOFF.TabIndex = 7;
            this.R2_VentOFF.TabStop = true;
            this.R2_VentOFF.Text = "OFF";
            this.R2_VentOFF.UseVisualStyleBackColor = true;
            this.R2_VentOFF.CheckedChanged += new System.EventHandler(this.R2_VentOFF_CheckedChanged);
            // 
            // R2_Vent3
            // 
            this.R2_Vent3.AutoSize = true;
            this.R2_Vent3.Location = new System.Drawing.Point(20, 48);
            this.R2_Vent3.Name = "R2_Vent3";
            this.R2_Vent3.Size = new System.Drawing.Size(44, 17);
            this.R2_Vent3.TabIndex = 6;
            this.R2_Vent3.TabStop = true;
            this.R2_Vent3.Text = "3档";
            this.R2_Vent3.UseVisualStyleBackColor = true;
            this.R2_Vent3.CheckedChanged += new System.EventHandler(this.R2_Vent3_CheckedChanged);
            // 
            // R2_Vent2
            // 
            this.R2_Vent2.AutoSize = true;
            this.R2_Vent2.Location = new System.Drawing.Point(99, 21);
            this.R2_Vent2.Name = "R2_Vent2";
            this.R2_Vent2.Size = new System.Drawing.Size(44, 17);
            this.R2_Vent2.TabIndex = 5;
            this.R2_Vent2.TabStop = true;
            this.R2_Vent2.Text = "2档";
            this.R2_Vent2.UseVisualStyleBackColor = true;
            this.R2_Vent2.CheckedChanged += new System.EventHandler(this.R2_Vent2_CheckedChanged);
            // 
            // R2_Vent1
            // 
            this.R2_Vent1.AutoSize = true;
            this.R2_Vent1.Location = new System.Drawing.Point(20, 21);
            this.R2_Vent1.Name = "R2_Vent1";
            this.R2_Vent1.Size = new System.Drawing.Size(44, 17);
            this.R2_Vent1.TabIndex = 4;
            this.R2_Vent1.TabStop = true;
            this.R2_Vent1.Text = "1档";
            this.R2_Vent1.UseVisualStyleBackColor = true;
            this.R2_Vent1.CheckedChanged += new System.EventHandler(this.R2_Vent1_CheckedChanged);
            // 
            // Start4
            // 
            this.Start4.Location = new System.Drawing.Point(265, 90);
            this.Start4.Name = "Start4";
            this.Start4.Size = new System.Drawing.Size(52, 22);
            this.Start4.TabIndex = 63;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PA_VentOFF);
            this.groupBox4.Controls.Add(this.PA_Vent3);
            this.groupBox4.Controls.Add(this.PA_Vent2);
            this.groupBox4.Controls.Add(this.PA_Vent1);
            this.groupBox4.Location = new System.Drawing.Point(890, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 75);
            this.groupBox4.TabIndex = 373;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "副驾通风";
            // 
            // PA_VentOFF
            // 
            this.PA_VentOFF.AutoSize = true;
            this.PA_VentOFF.Location = new System.Drawing.Point(99, 48);
            this.PA_VentOFF.Name = "PA_VentOFF";
            this.PA_VentOFF.Size = new System.Drawing.Size(46, 17);
            this.PA_VentOFF.TabIndex = 7;
            this.PA_VentOFF.TabStop = true;
            this.PA_VentOFF.Text = "OFF";
            this.PA_VentOFF.UseVisualStyleBackColor = true;
            this.PA_VentOFF.CheckedChanged += new System.EventHandler(this.PA_VentOFF_CheckedChanged);
            // 
            // PA_Vent3
            // 
            this.PA_Vent3.AutoSize = true;
            this.PA_Vent3.Location = new System.Drawing.Point(20, 48);
            this.PA_Vent3.Name = "PA_Vent3";
            this.PA_Vent3.Size = new System.Drawing.Size(44, 17);
            this.PA_Vent3.TabIndex = 6;
            this.PA_Vent3.TabStop = true;
            this.PA_Vent3.Text = "3档";
            this.PA_Vent3.UseVisualStyleBackColor = true;
            this.PA_Vent3.CheckedChanged += new System.EventHandler(this.PA_Vent3_CheckedChanged);
            // 
            // PA_Vent2
            // 
            this.PA_Vent2.AutoSize = true;
            this.PA_Vent2.Location = new System.Drawing.Point(99, 21);
            this.PA_Vent2.Name = "PA_Vent2";
            this.PA_Vent2.Size = new System.Drawing.Size(44, 17);
            this.PA_Vent2.TabIndex = 5;
            this.PA_Vent2.TabStop = true;
            this.PA_Vent2.Text = "2档";
            this.PA_Vent2.UseVisualStyleBackColor = true;
            this.PA_Vent2.CheckedChanged += new System.EventHandler(this.PA_Vent2_CheckedChanged);
            // 
            // PA_Vent1
            // 
            this.PA_Vent1.AutoSize = true;
            this.PA_Vent1.Location = new System.Drawing.Point(20, 21);
            this.PA_Vent1.Name = "PA_Vent1";
            this.PA_Vent1.Size = new System.Drawing.Size(44, 17);
            this.PA_Vent1.TabIndex = 4;
            this.PA_Vent1.TabStop = true;
            this.PA_Vent1.Text = "1档";
            this.PA_Vent1.UseVisualStyleBackColor = true;
            this.PA_Vent1.CheckedChanged += new System.EventHandler(this.PA_Vent1_CheckedChanged);
            // 
            // Start5
            // 
            this.Start5.Location = new System.Drawing.Point(265, 112);
            this.Start5.Name = "Start5";
            this.Start5.Size = new System.Drawing.Size(52, 22);
            this.Start5.TabIndex = 64;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PA_HeatOFF);
            this.groupBox3.Controls.Add(this.PA_Heat3);
            this.groupBox3.Controls.Add(this.PA_Heat2);
            this.groupBox3.Controls.Add(this.PA_Heat1);
            this.groupBox3.Location = new System.Drawing.Point(890, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 78);
            this.groupBox3.TabIndex = 372;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "副驾加热";
            // 
            // PA_HeatOFF
            // 
            this.PA_HeatOFF.AutoSize = true;
            this.PA_HeatOFF.Location = new System.Drawing.Point(99, 50);
            this.PA_HeatOFF.Name = "PA_HeatOFF";
            this.PA_HeatOFF.Size = new System.Drawing.Size(46, 17);
            this.PA_HeatOFF.TabIndex = 7;
            this.PA_HeatOFF.TabStop = true;
            this.PA_HeatOFF.Text = "OFF";
            this.PA_HeatOFF.UseVisualStyleBackColor = true;
            this.PA_HeatOFF.CheckedChanged += new System.EventHandler(this.PA_HeatOFF_CheckedChanged);
            // 
            // PA_Heat3
            // 
            this.PA_Heat3.AutoSize = true;
            this.PA_Heat3.Location = new System.Drawing.Point(20, 50);
            this.PA_Heat3.Name = "PA_Heat3";
            this.PA_Heat3.Size = new System.Drawing.Size(44, 17);
            this.PA_Heat3.TabIndex = 6;
            this.PA_Heat3.TabStop = true;
            this.PA_Heat3.Text = "3档";
            this.PA_Heat3.UseVisualStyleBackColor = true;
            this.PA_Heat3.CheckedChanged += new System.EventHandler(this.PA_Heat3_CheckedChanged);
            // 
            // PA_Heat2
            // 
            this.PA_Heat2.AutoSize = true;
            this.PA_Heat2.Location = new System.Drawing.Point(99, 23);
            this.PA_Heat2.Name = "PA_Heat2";
            this.PA_Heat2.Size = new System.Drawing.Size(44, 17);
            this.PA_Heat2.TabIndex = 5;
            this.PA_Heat2.TabStop = true;
            this.PA_Heat2.Text = "2档";
            this.PA_Heat2.UseVisualStyleBackColor = true;
            this.PA_Heat2.CheckedChanged += new System.EventHandler(this.PA_Heat2_CheckedChanged);
            // 
            // PA_Heat1
            // 
            this.PA_Heat1.AutoSize = true;
            this.PA_Heat1.Location = new System.Drawing.Point(20, 23);
            this.PA_Heat1.Name = "PA_Heat1";
            this.PA_Heat1.Size = new System.Drawing.Size(44, 17);
            this.PA_Heat1.TabIndex = 4;
            this.PA_Heat1.TabStop = true;
            this.PA_Heat1.Text = "1档";
            this.PA_Heat1.UseVisualStyleBackColor = true;
            this.PA_Heat1.CheckedChanged += new System.EventHandler(this.PA_Heat1_CheckedChanged);
            // 
            // Start6
            // 
            this.Start6.Location = new System.Drawing.Point(265, 134);
            this.Start6.Name = "Start6";
            this.Start6.Size = new System.Drawing.Size(52, 22);
            this.Start6.TabIndex = 65;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DR_VentOFF);
            this.groupBox2.Controls.Add(this.DR_Vent3);
            this.groupBox2.Controls.Add(this.DR_Vent2);
            this.groupBox2.Controls.Add(this.DR_Vent1);
            this.groupBox2.Location = new System.Drawing.Point(681, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 75);
            this.groupBox2.TabIndex = 371;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "主驾通风";
            // 
            // DR_VentOFF
            // 
            this.DR_VentOFF.AutoSize = true;
            this.DR_VentOFF.Location = new System.Drawing.Point(101, 48);
            this.DR_VentOFF.Name = "DR_VentOFF";
            this.DR_VentOFF.Size = new System.Drawing.Size(46, 17);
            this.DR_VentOFF.TabIndex = 7;
            this.DR_VentOFF.TabStop = true;
            this.DR_VentOFF.Text = "OFF";
            this.DR_VentOFF.UseVisualStyleBackColor = true;
            this.DR_VentOFF.CheckedChanged += new System.EventHandler(this.DR_VentOFF_CheckedChanged);
            // 
            // DR_Vent3
            // 
            this.DR_Vent3.AutoSize = true;
            this.DR_Vent3.Location = new System.Drawing.Point(22, 48);
            this.DR_Vent3.Name = "DR_Vent3";
            this.DR_Vent3.Size = new System.Drawing.Size(44, 17);
            this.DR_Vent3.TabIndex = 6;
            this.DR_Vent3.TabStop = true;
            this.DR_Vent3.Text = "3档";
            this.DR_Vent3.UseVisualStyleBackColor = true;
            this.DR_Vent3.CheckedChanged += new System.EventHandler(this.DR_Vent3_CheckedChanged);
            // 
            // DR_Vent2
            // 
            this.DR_Vent2.AutoSize = true;
            this.DR_Vent2.Location = new System.Drawing.Point(101, 21);
            this.DR_Vent2.Name = "DR_Vent2";
            this.DR_Vent2.Size = new System.Drawing.Size(44, 17);
            this.DR_Vent2.TabIndex = 5;
            this.DR_Vent2.TabStop = true;
            this.DR_Vent2.Text = "2档";
            this.DR_Vent2.UseVisualStyleBackColor = true;
            this.DR_Vent2.CheckedChanged += new System.EventHandler(this.DR_Vent2_CheckedChanged);
            // 
            // DR_Vent1
            // 
            this.DR_Vent1.AutoSize = true;
            this.DR_Vent1.Location = new System.Drawing.Point(22, 21);
            this.DR_Vent1.Name = "DR_Vent1";
            this.DR_Vent1.Size = new System.Drawing.Size(44, 17);
            this.DR_Vent1.TabIndex = 4;
            this.DR_Vent1.TabStop = true;
            this.DR_Vent1.Text = "1档";
            this.DR_Vent1.UseVisualStyleBackColor = true;
            this.DR_Vent1.CheckedChanged += new System.EventHandler(this.DR_Vent1_CheckedChanged);
            // 
            // Start7
            // 
            this.Start7.Location = new System.Drawing.Point(265, 156);
            this.Start7.Name = "Start7";
            this.Start7.Size = new System.Drawing.Size(52, 22);
            this.Start7.TabIndex = 66;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DR_HeatOFF);
            this.groupBox1.Controls.Add(this.DR_Heat3);
            this.groupBox1.Controls.Add(this.DR_Heat2);
            this.groupBox1.Controls.Add(this.DR_Heat1);
            this.groupBox1.Location = new System.Drawing.Point(681, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 78);
            this.groupBox1.TabIndex = 370;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主驾加热";
            // 
            // DR_HeatOFF
            // 
            this.DR_HeatOFF.AutoSize = true;
            this.DR_HeatOFF.Location = new System.Drawing.Point(101, 50);
            this.DR_HeatOFF.Name = "DR_HeatOFF";
            this.DR_HeatOFF.Size = new System.Drawing.Size(46, 17);
            this.DR_HeatOFF.TabIndex = 3;
            this.DR_HeatOFF.TabStop = true;
            this.DR_HeatOFF.Text = "OFF";
            this.DR_HeatOFF.UseVisualStyleBackColor = true;
            this.DR_HeatOFF.CheckedChanged += new System.EventHandler(this.DR_HeatOFF_CheckedChanged);
            // 
            // DR_Heat3
            // 
            this.DR_Heat3.AutoSize = true;
            this.DR_Heat3.Location = new System.Drawing.Point(22, 50);
            this.DR_Heat3.Name = "DR_Heat3";
            this.DR_Heat3.Size = new System.Drawing.Size(44, 17);
            this.DR_Heat3.TabIndex = 2;
            this.DR_Heat3.TabStop = true;
            this.DR_Heat3.Text = "3档";
            this.DR_Heat3.UseVisualStyleBackColor = true;
            this.DR_Heat3.CheckedChanged += new System.EventHandler(this.DR_Heat3_CheckedChanged);
            // 
            // DR_Heat2
            // 
            this.DR_Heat2.AutoSize = true;
            this.DR_Heat2.Location = new System.Drawing.Point(101, 23);
            this.DR_Heat2.Name = "DR_Heat2";
            this.DR_Heat2.Size = new System.Drawing.Size(44, 17);
            this.DR_Heat2.TabIndex = 1;
            this.DR_Heat2.TabStop = true;
            this.DR_Heat2.Text = "2档";
            this.DR_Heat2.UseVisualStyleBackColor = true;
            this.DR_Heat2.CheckedChanged += new System.EventHandler(this.DR_Heat2_CheckedChanged);
            // 
            // DR_Heat1
            // 
            this.DR_Heat1.AutoSize = true;
            this.DR_Heat1.Location = new System.Drawing.Point(22, 23);
            this.DR_Heat1.Name = "DR_Heat1";
            this.DR_Heat1.Size = new System.Drawing.Size(44, 17);
            this.DR_Heat1.TabIndex = 0;
            this.DR_Heat1.TabStop = true;
            this.DR_Heat1.Text = "1档";
            this.DR_Heat1.UseVisualStyleBackColor = true;
            this.DR_Heat1.CheckedChanged += new System.EventHandler(this.DR_Heat1_CheckedChanged);
            // 
            // Start8
            // 
            this.Start8.Location = new System.Drawing.Point(265, 178);
            this.Start8.Name = "Start8";
            this.Start8.Size = new System.Drawing.Size(52, 22);
            this.Start8.TabIndex = 67;
            // 
            // Pos52
            // 
            this.Pos52.Enabled = false;
            this.Pos52.Location = new System.Drawing.Point(531, 1147);
            this.Pos52.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos52.Name = "Pos52";
            this.Pos52.Size = new System.Drawing.Size(52, 22);
            this.Pos52.TabIndex = 369;
            // 
            // Start9
            // 
            this.Start9.Location = new System.Drawing.Point(265, 200);
            this.Start9.Name = "Start9";
            this.Start9.Size = new System.Drawing.Size(52, 22);
            this.Start9.TabIndex = 68;
            // 
            // Stay52
            // 
            this.Stay52.Location = new System.Drawing.Point(400, 1147);
            this.Stay52.Name = "Stay52";
            this.Stay52.Size = new System.Drawing.Size(52, 22);
            this.Stay52.TabIndex = 368;
            // 
            // Start10
            // 
            this.Start10.Location = new System.Drawing.Point(265, 222);
            this.Start10.Name = "Start10";
            this.Start10.Size = new System.Drawing.Size(52, 22);
            this.Start10.TabIndex = 69;
            // 
            // Finish52
            // 
            this.Finish52.Location = new System.Drawing.Point(333, 1147);
            this.Finish52.Name = "Finish52";
            this.Finish52.Size = new System.Drawing.Size(52, 22);
            this.Finish52.TabIndex = 367;
            // 
            // Start11
            // 
            this.Start11.Location = new System.Drawing.Point(265, 244);
            this.Start11.Name = "Start11";
            this.Start11.Size = new System.Drawing.Size(52, 22);
            this.Start11.TabIndex = 70;
            // 
            // Start52
            // 
            this.Start52.Location = new System.Drawing.Point(265, 1147);
            this.Start52.Name = "Start52";
            this.Start52.Size = new System.Drawing.Size(52, 22);
            this.Start52.TabIndex = 366;
            // 
            // Start12
            // 
            this.Start12.Location = new System.Drawing.Point(265, 266);
            this.Start12.Name = "Start12";
            this.Start12.Size = new System.Drawing.Size(52, 22);
            this.Start12.TabIndex = 71;
            // 
            // Motor52
            // 
            this.Motor52.FormattingEnabled = true;
            this.Motor52.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor52.Location = new System.Drawing.Point(157, 1146);
            this.Motor52.Name = "Motor52";
            this.Motor52.Size = new System.Drawing.Size(74, 21);
            this.Motor52.TabIndex = 365;
            // 
            // Start13
            // 
            this.Start13.Location = new System.Drawing.Point(265, 288);
            this.Start13.Name = "Start13";
            this.Start13.Size = new System.Drawing.Size(52, 22);
            this.Start13.TabIndex = 72;
            // 
            // Seat52
            // 
            this.Seat52.FormattingEnabled = true;
            this.Seat52.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat52.Location = new System.Drawing.Point(90, 1146);
            this.Seat52.Name = "Seat52";
            this.Seat52.Size = new System.Drawing.Size(61, 21);
            this.Seat52.TabIndex = 364;
            // 
            // Start14
            // 
            this.Start14.Location = new System.Drawing.Point(265, 310);
            this.Start14.Name = "Start14";
            this.Start14.Size = new System.Drawing.Size(52, 22);
            this.Start14.TabIndex = 73;
            // 
            // checkBox52
            // 
            this.checkBox52.AutoSize = true;
            this.checkBox52.Location = new System.Drawing.Point(6, 1148);
            this.checkBox52.Name = "checkBox52";
            this.checkBox52.Size = new System.Drawing.Size(38, 17);
            this.checkBox52.TabIndex = 363;
            this.checkBox52.Text = "52";
            this.checkBox52.UseVisualStyleBackColor = true;
            this.checkBox52.CheckedChanged += new System.EventHandler(this.checkBox52_CheckedChanged);
            // 
            // Start15
            // 
            this.Start15.Location = new System.Drawing.Point(265, 332);
            this.Start15.Name = "Start15";
            this.Start15.Size = new System.Drawing.Size(52, 22);
            this.Start15.TabIndex = 74;
            // 
            // Pos51
            // 
            this.Pos51.Enabled = false;
            this.Pos51.Location = new System.Drawing.Point(531, 1125);
            this.Pos51.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos51.Name = "Pos51";
            this.Pos51.Size = new System.Drawing.Size(52, 22);
            this.Pos51.TabIndex = 362;
            // 
            // Start16
            // 
            this.Start16.Location = new System.Drawing.Point(265, 354);
            this.Start16.Name = "Start16";
            this.Start16.Size = new System.Drawing.Size(52, 22);
            this.Start16.TabIndex = 75;
            // 
            // Stay51
            // 
            this.Stay51.Location = new System.Drawing.Point(400, 1125);
            this.Stay51.Name = "Stay51";
            this.Stay51.Size = new System.Drawing.Size(52, 22);
            this.Stay51.TabIndex = 361;
            // 
            // Start17
            // 
            this.Start17.Location = new System.Drawing.Point(265, 376);
            this.Start17.Name = "Start17";
            this.Start17.Size = new System.Drawing.Size(52, 22);
            this.Start17.TabIndex = 76;
            // 
            // Finish51
            // 
            this.Finish51.Location = new System.Drawing.Point(333, 1125);
            this.Finish51.Name = "Finish51";
            this.Finish51.Size = new System.Drawing.Size(52, 22);
            this.Finish51.TabIndex = 360;
            // 
            // Start18
            // 
            this.Start18.Location = new System.Drawing.Point(265, 398);
            this.Start18.Name = "Start18";
            this.Start18.Size = new System.Drawing.Size(52, 22);
            this.Start18.TabIndex = 77;
            // 
            // Start51
            // 
            this.Start51.Location = new System.Drawing.Point(265, 1125);
            this.Start51.Name = "Start51";
            this.Start51.Size = new System.Drawing.Size(52, 22);
            this.Start51.TabIndex = 359;
            // 
            // Start19
            // 
            this.Start19.Location = new System.Drawing.Point(265, 420);
            this.Start19.Name = "Start19";
            this.Start19.Size = new System.Drawing.Size(52, 22);
            this.Start19.TabIndex = 78;
            // 
            // Motor51
            // 
            this.Motor51.FormattingEnabled = true;
            this.Motor51.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor51.Location = new System.Drawing.Point(157, 1124);
            this.Motor51.Name = "Motor51";
            this.Motor51.Size = new System.Drawing.Size(74, 21);
            this.Motor51.TabIndex = 358;
            // 
            // Start20
            // 
            this.Start20.Location = new System.Drawing.Point(265, 442);
            this.Start20.Name = "Start20";
            this.Start20.Size = new System.Drawing.Size(52, 22);
            this.Start20.TabIndex = 79;
            // 
            // Seat51
            // 
            this.Seat51.FormattingEnabled = true;
            this.Seat51.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat51.Location = new System.Drawing.Point(90, 1124);
            this.Seat51.Name = "Seat51";
            this.Seat51.Size = new System.Drawing.Size(61, 21);
            this.Seat51.TabIndex = 357;
            // 
            // Finish1
            // 
            this.Finish1.Location = new System.Drawing.Point(333, 24);
            this.Finish1.Name = "Finish1";
            this.Finish1.Size = new System.Drawing.Size(52, 22);
            this.Finish1.TabIndex = 80;
            this.Finish1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox51
            // 
            this.checkBox51.AutoSize = true;
            this.checkBox51.Location = new System.Drawing.Point(6, 1126);
            this.checkBox51.Name = "checkBox51";
            this.checkBox51.Size = new System.Drawing.Size(38, 17);
            this.checkBox51.TabIndex = 356;
            this.checkBox51.Text = "51";
            this.checkBox51.UseVisualStyleBackColor = true;
            this.checkBox51.CheckedChanged += new System.EventHandler(this.checkBox51_CheckedChanged);
            // 
            // Finish2
            // 
            this.Finish2.Location = new System.Drawing.Point(333, 46);
            this.Finish2.Name = "Finish2";
            this.Finish2.Size = new System.Drawing.Size(52, 22);
            this.Finish2.TabIndex = 81;
            this.Finish2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Pos50
            // 
            this.Pos50.Enabled = false;
            this.Pos50.Location = new System.Drawing.Point(531, 1103);
            this.Pos50.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos50.Name = "Pos50";
            this.Pos50.Size = new System.Drawing.Size(52, 22);
            this.Pos50.TabIndex = 355;
            // 
            // Finish3
            // 
            this.Finish3.Location = new System.Drawing.Point(333, 68);
            this.Finish3.Name = "Finish3";
            this.Finish3.Size = new System.Drawing.Size(52, 22);
            this.Finish3.TabIndex = 82;
            // 
            // Stay50
            // 
            this.Stay50.Location = new System.Drawing.Point(400, 1103);
            this.Stay50.Name = "Stay50";
            this.Stay50.Size = new System.Drawing.Size(52, 22);
            this.Stay50.TabIndex = 354;
            // 
            // Finish4
            // 
            this.Finish4.Location = new System.Drawing.Point(333, 90);
            this.Finish4.Name = "Finish4";
            this.Finish4.Size = new System.Drawing.Size(52, 22);
            this.Finish4.TabIndex = 83;
            // 
            // Finish50
            // 
            this.Finish50.Location = new System.Drawing.Point(333, 1103);
            this.Finish50.Name = "Finish50";
            this.Finish50.Size = new System.Drawing.Size(52, 22);
            this.Finish50.TabIndex = 353;
            // 
            // Finish5
            // 
            this.Finish5.Location = new System.Drawing.Point(333, 112);
            this.Finish5.Name = "Finish5";
            this.Finish5.Size = new System.Drawing.Size(52, 22);
            this.Finish5.TabIndex = 84;
            // 
            // Start50
            // 
            this.Start50.Location = new System.Drawing.Point(265, 1103);
            this.Start50.Name = "Start50";
            this.Start50.Size = new System.Drawing.Size(52, 22);
            this.Start50.TabIndex = 352;
            // 
            // Finish6
            // 
            this.Finish6.Location = new System.Drawing.Point(333, 134);
            this.Finish6.Name = "Finish6";
            this.Finish6.Size = new System.Drawing.Size(52, 22);
            this.Finish6.TabIndex = 85;
            // 
            // Motor50
            // 
            this.Motor50.FormattingEnabled = true;
            this.Motor50.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor50.Location = new System.Drawing.Point(157, 1102);
            this.Motor50.Name = "Motor50";
            this.Motor50.Size = new System.Drawing.Size(74, 21);
            this.Motor50.TabIndex = 351;
            // 
            // Finish7
            // 
            this.Finish7.Location = new System.Drawing.Point(333, 156);
            this.Finish7.Name = "Finish7";
            this.Finish7.Size = new System.Drawing.Size(52, 22);
            this.Finish7.TabIndex = 86;
            // 
            // Seat50
            // 
            this.Seat50.FormattingEnabled = true;
            this.Seat50.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat50.Location = new System.Drawing.Point(90, 1102);
            this.Seat50.Name = "Seat50";
            this.Seat50.Size = new System.Drawing.Size(61, 21);
            this.Seat50.TabIndex = 350;
            // 
            // Finish8
            // 
            this.Finish8.Location = new System.Drawing.Point(333, 178);
            this.Finish8.Name = "Finish8";
            this.Finish8.Size = new System.Drawing.Size(52, 22);
            this.Finish8.TabIndex = 87;
            // 
            // checkBox50
            // 
            this.checkBox50.AutoSize = true;
            this.checkBox50.Location = new System.Drawing.Point(6, 1104);
            this.checkBox50.Name = "checkBox50";
            this.checkBox50.Size = new System.Drawing.Size(38, 17);
            this.checkBox50.TabIndex = 349;
            this.checkBox50.Text = "50";
            this.checkBox50.UseVisualStyleBackColor = true;
            this.checkBox50.CheckedChanged += new System.EventHandler(this.checkBox50_CheckedChanged);
            // 
            // Finish9
            // 
            this.Finish9.Location = new System.Drawing.Point(333, 200);
            this.Finish9.Name = "Finish9";
            this.Finish9.Size = new System.Drawing.Size(52, 22);
            this.Finish9.TabIndex = 88;
            // 
            // Pos49
            // 
            this.Pos49.Enabled = false;
            this.Pos49.Location = new System.Drawing.Point(531, 1081);
            this.Pos49.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos49.Name = "Pos49";
            this.Pos49.Size = new System.Drawing.Size(52, 22);
            this.Pos49.TabIndex = 348;
            // 
            // Finish10
            // 
            this.Finish10.Location = new System.Drawing.Point(333, 222);
            this.Finish10.Name = "Finish10";
            this.Finish10.Size = new System.Drawing.Size(52, 22);
            this.Finish10.TabIndex = 89;
            // 
            // Stay49
            // 
            this.Stay49.Location = new System.Drawing.Point(400, 1081);
            this.Stay49.Name = "Stay49";
            this.Stay49.Size = new System.Drawing.Size(52, 22);
            this.Stay49.TabIndex = 347;
            // 
            // Finish11
            // 
            this.Finish11.Location = new System.Drawing.Point(333, 244);
            this.Finish11.Name = "Finish11";
            this.Finish11.Size = new System.Drawing.Size(52, 22);
            this.Finish11.TabIndex = 90;
            // 
            // Finish49
            // 
            this.Finish49.Location = new System.Drawing.Point(333, 1081);
            this.Finish49.Name = "Finish49";
            this.Finish49.Size = new System.Drawing.Size(52, 22);
            this.Finish49.TabIndex = 346;
            // 
            // Finish12
            // 
            this.Finish12.Location = new System.Drawing.Point(333, 266);
            this.Finish12.Name = "Finish12";
            this.Finish12.Size = new System.Drawing.Size(52, 22);
            this.Finish12.TabIndex = 91;
            // 
            // Start49
            // 
            this.Start49.Location = new System.Drawing.Point(265, 1081);
            this.Start49.Name = "Start49";
            this.Start49.Size = new System.Drawing.Size(52, 22);
            this.Start49.TabIndex = 345;
            // 
            // Finish13
            // 
            this.Finish13.Location = new System.Drawing.Point(333, 288);
            this.Finish13.Name = "Finish13";
            this.Finish13.Size = new System.Drawing.Size(52, 22);
            this.Finish13.TabIndex = 92;
            // 
            // Motor49
            // 
            this.Motor49.FormattingEnabled = true;
            this.Motor49.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor49.Location = new System.Drawing.Point(157, 1080);
            this.Motor49.Name = "Motor49";
            this.Motor49.Size = new System.Drawing.Size(74, 21);
            this.Motor49.TabIndex = 344;
            // 
            // Finish14
            // 
            this.Finish14.Location = new System.Drawing.Point(333, 310);
            this.Finish14.Name = "Finish14";
            this.Finish14.Size = new System.Drawing.Size(52, 22);
            this.Finish14.TabIndex = 93;
            // 
            // Seat49
            // 
            this.Seat49.FormattingEnabled = true;
            this.Seat49.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat49.Location = new System.Drawing.Point(90, 1080);
            this.Seat49.Name = "Seat49";
            this.Seat49.Size = new System.Drawing.Size(61, 21);
            this.Seat49.TabIndex = 343;
            // 
            // Finish15
            // 
            this.Finish15.Location = new System.Drawing.Point(333, 332);
            this.Finish15.Name = "Finish15";
            this.Finish15.Size = new System.Drawing.Size(52, 22);
            this.Finish15.TabIndex = 94;
            // 
            // checkBox49
            // 
            this.checkBox49.AutoSize = true;
            this.checkBox49.Location = new System.Drawing.Point(6, 1082);
            this.checkBox49.Name = "checkBox49";
            this.checkBox49.Size = new System.Drawing.Size(38, 17);
            this.checkBox49.TabIndex = 342;
            this.checkBox49.Text = "49";
            this.checkBox49.UseVisualStyleBackColor = true;
            this.checkBox49.CheckedChanged += new System.EventHandler(this.checkBox49_CheckedChanged);
            // 
            // Finish16
            // 
            this.Finish16.Location = new System.Drawing.Point(333, 354);
            this.Finish16.Name = "Finish16";
            this.Finish16.Size = new System.Drawing.Size(52, 22);
            this.Finish16.TabIndex = 95;
            // 
            // Pos48
            // 
            this.Pos48.Enabled = false;
            this.Pos48.Location = new System.Drawing.Point(531, 1059);
            this.Pos48.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos48.Name = "Pos48";
            this.Pos48.Size = new System.Drawing.Size(52, 22);
            this.Pos48.TabIndex = 341;
            // 
            // Finish17
            // 
            this.Finish17.Location = new System.Drawing.Point(333, 376);
            this.Finish17.Name = "Finish17";
            this.Finish17.Size = new System.Drawing.Size(52, 22);
            this.Finish17.TabIndex = 96;
            // 
            // Stay48
            // 
            this.Stay48.Location = new System.Drawing.Point(400, 1059);
            this.Stay48.Name = "Stay48";
            this.Stay48.Size = new System.Drawing.Size(52, 22);
            this.Stay48.TabIndex = 340;
            // 
            // Finish18
            // 
            this.Finish18.Location = new System.Drawing.Point(333, 398);
            this.Finish18.Name = "Finish18";
            this.Finish18.Size = new System.Drawing.Size(52, 22);
            this.Finish18.TabIndex = 97;
            // 
            // Finish48
            // 
            this.Finish48.Location = new System.Drawing.Point(333, 1059);
            this.Finish48.Name = "Finish48";
            this.Finish48.Size = new System.Drawing.Size(52, 22);
            this.Finish48.TabIndex = 339;
            // 
            // Finish19
            // 
            this.Finish19.Location = new System.Drawing.Point(333, 420);
            this.Finish19.Name = "Finish19";
            this.Finish19.Size = new System.Drawing.Size(52, 22);
            this.Finish19.TabIndex = 98;
            // 
            // Start48
            // 
            this.Start48.Location = new System.Drawing.Point(265, 1059);
            this.Start48.Name = "Start48";
            this.Start48.Size = new System.Drawing.Size(52, 22);
            this.Start48.TabIndex = 338;
            // 
            // Finish20
            // 
            this.Finish20.Location = new System.Drawing.Point(333, 442);
            this.Finish20.Name = "Finish20";
            this.Finish20.Size = new System.Drawing.Size(52, 22);
            this.Finish20.TabIndex = 99;
            // 
            // Motor48
            // 
            this.Motor48.FormattingEnabled = true;
            this.Motor48.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor48.Location = new System.Drawing.Point(157, 1058);
            this.Motor48.Name = "Motor48";
            this.Motor48.Size = new System.Drawing.Size(74, 21);
            this.Motor48.TabIndex = 337;
            // 
            // Stay1
            // 
            this.Stay1.Location = new System.Drawing.Point(400, 24);
            this.Stay1.Name = "Stay1";
            this.Stay1.Size = new System.Drawing.Size(52, 22);
            this.Stay1.TabIndex = 100;
            // 
            // Seat48
            // 
            this.Seat48.FormattingEnabled = true;
            this.Seat48.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat48.Location = new System.Drawing.Point(90, 1058);
            this.Seat48.Name = "Seat48";
            this.Seat48.Size = new System.Drawing.Size(61, 21);
            this.Seat48.TabIndex = 336;
            // 
            // Stay2
            // 
            this.Stay2.Location = new System.Drawing.Point(400, 46);
            this.Stay2.Name = "Stay2";
            this.Stay2.Size = new System.Drawing.Size(52, 22);
            this.Stay2.TabIndex = 101;
            // 
            // checkBox48
            // 
            this.checkBox48.AutoSize = true;
            this.checkBox48.Location = new System.Drawing.Point(6, 1060);
            this.checkBox48.Name = "checkBox48";
            this.checkBox48.Size = new System.Drawing.Size(38, 17);
            this.checkBox48.TabIndex = 335;
            this.checkBox48.Text = "48";
            this.checkBox48.UseVisualStyleBackColor = true;
            this.checkBox48.CheckedChanged += new System.EventHandler(this.checkBox48_CheckedChanged);
            // 
            // Stay3
            // 
            this.Stay3.Location = new System.Drawing.Point(400, 68);
            this.Stay3.Name = "Stay3";
            this.Stay3.Size = new System.Drawing.Size(52, 22);
            this.Stay3.TabIndex = 102;
            // 
            // Pos47
            // 
            this.Pos47.Enabled = false;
            this.Pos47.Location = new System.Drawing.Point(531, 1037);
            this.Pos47.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos47.Name = "Pos47";
            this.Pos47.Size = new System.Drawing.Size(52, 22);
            this.Pos47.TabIndex = 334;
            // 
            // Stay4
            // 
            this.Stay4.Location = new System.Drawing.Point(400, 90);
            this.Stay4.Name = "Stay4";
            this.Stay4.Size = new System.Drawing.Size(52, 22);
            this.Stay4.TabIndex = 103;
            // 
            // Stay47
            // 
            this.Stay47.Location = new System.Drawing.Point(400, 1037);
            this.Stay47.Name = "Stay47";
            this.Stay47.Size = new System.Drawing.Size(52, 22);
            this.Stay47.TabIndex = 333;
            // 
            // Stay5
            // 
            this.Stay5.Location = new System.Drawing.Point(400, 112);
            this.Stay5.Name = "Stay5";
            this.Stay5.Size = new System.Drawing.Size(52, 22);
            this.Stay5.TabIndex = 104;
            // 
            // Finish47
            // 
            this.Finish47.Location = new System.Drawing.Point(333, 1037);
            this.Finish47.Name = "Finish47";
            this.Finish47.Size = new System.Drawing.Size(52, 22);
            this.Finish47.TabIndex = 332;
            // 
            // Stay6
            // 
            this.Stay6.Location = new System.Drawing.Point(400, 134);
            this.Stay6.Name = "Stay6";
            this.Stay6.Size = new System.Drawing.Size(52, 22);
            this.Stay6.TabIndex = 105;
            // 
            // Start47
            // 
            this.Start47.Location = new System.Drawing.Point(265, 1037);
            this.Start47.Name = "Start47";
            this.Start47.Size = new System.Drawing.Size(52, 22);
            this.Start47.TabIndex = 331;
            // 
            // Stay7
            // 
            this.Stay7.Location = new System.Drawing.Point(400, 156);
            this.Stay7.Name = "Stay7";
            this.Stay7.Size = new System.Drawing.Size(52, 22);
            this.Stay7.TabIndex = 106;
            // 
            // Motor47
            // 
            this.Motor47.FormattingEnabled = true;
            this.Motor47.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor47.Location = new System.Drawing.Point(157, 1036);
            this.Motor47.Name = "Motor47";
            this.Motor47.Size = new System.Drawing.Size(74, 21);
            this.Motor47.TabIndex = 330;
            // 
            // Stay8
            // 
            this.Stay8.Location = new System.Drawing.Point(400, 178);
            this.Stay8.Name = "Stay8";
            this.Stay8.Size = new System.Drawing.Size(52, 22);
            this.Stay8.TabIndex = 107;
            // 
            // Seat47
            // 
            this.Seat47.FormattingEnabled = true;
            this.Seat47.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat47.Location = new System.Drawing.Point(90, 1036);
            this.Seat47.Name = "Seat47";
            this.Seat47.Size = new System.Drawing.Size(61, 21);
            this.Seat47.TabIndex = 329;
            // 
            // Stay9
            // 
            this.Stay9.Location = new System.Drawing.Point(400, 200);
            this.Stay9.Name = "Stay9";
            this.Stay9.Size = new System.Drawing.Size(52, 22);
            this.Stay9.TabIndex = 108;
            // 
            // checkBox47
            // 
            this.checkBox47.AutoSize = true;
            this.checkBox47.Location = new System.Drawing.Point(6, 1038);
            this.checkBox47.Name = "checkBox47";
            this.checkBox47.Size = new System.Drawing.Size(38, 17);
            this.checkBox47.TabIndex = 328;
            this.checkBox47.Text = "47";
            this.checkBox47.UseVisualStyleBackColor = true;
            this.checkBox47.CheckedChanged += new System.EventHandler(this.checkBox47_CheckedChanged);
            // 
            // Stay10
            // 
            this.Stay10.Location = new System.Drawing.Point(400, 222);
            this.Stay10.Name = "Stay10";
            this.Stay10.Size = new System.Drawing.Size(52, 22);
            this.Stay10.TabIndex = 109;
            // 
            // Pos46
            // 
            this.Pos46.Enabled = false;
            this.Pos46.Location = new System.Drawing.Point(531, 1015);
            this.Pos46.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos46.Name = "Pos46";
            this.Pos46.Size = new System.Drawing.Size(52, 22);
            this.Pos46.TabIndex = 327;
            // 
            // Stay11
            // 
            this.Stay11.Location = new System.Drawing.Point(400, 244);
            this.Stay11.Name = "Stay11";
            this.Stay11.Size = new System.Drawing.Size(52, 22);
            this.Stay11.TabIndex = 110;
            // 
            // Pos45
            // 
            this.Pos45.Enabled = false;
            this.Pos45.Location = new System.Drawing.Point(531, 993);
            this.Pos45.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos45.Name = "Pos45";
            this.Pos45.Size = new System.Drawing.Size(52, 22);
            this.Pos45.TabIndex = 326;
            // 
            // Stay12
            // 
            this.Stay12.Location = new System.Drawing.Point(400, 266);
            this.Stay12.Name = "Stay12";
            this.Stay12.Size = new System.Drawing.Size(52, 22);
            this.Stay12.TabIndex = 111;
            // 
            // Pos44
            // 
            this.Pos44.Enabled = false;
            this.Pos44.Location = new System.Drawing.Point(531, 971);
            this.Pos44.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos44.Name = "Pos44";
            this.Pos44.Size = new System.Drawing.Size(52, 22);
            this.Pos44.TabIndex = 325;
            // 
            // Stay13
            // 
            this.Stay13.Location = new System.Drawing.Point(400, 288);
            this.Stay13.Name = "Stay13";
            this.Stay13.Size = new System.Drawing.Size(52, 22);
            this.Stay13.TabIndex = 112;
            // 
            // Pos43
            // 
            this.Pos43.Enabled = false;
            this.Pos43.Location = new System.Drawing.Point(531, 949);
            this.Pos43.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos43.Name = "Pos43";
            this.Pos43.Size = new System.Drawing.Size(52, 22);
            this.Pos43.TabIndex = 324;
            // 
            // Stay14
            // 
            this.Stay14.Location = new System.Drawing.Point(400, 310);
            this.Stay14.Name = "Stay14";
            this.Stay14.Size = new System.Drawing.Size(52, 22);
            this.Stay14.TabIndex = 113;
            // 
            // Pos42
            // 
            this.Pos42.Enabled = false;
            this.Pos42.Location = new System.Drawing.Point(531, 927);
            this.Pos42.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos42.Name = "Pos42";
            this.Pos42.Size = new System.Drawing.Size(52, 22);
            this.Pos42.TabIndex = 323;
            // 
            // Stay15
            // 
            this.Stay15.Location = new System.Drawing.Point(400, 332);
            this.Stay15.Name = "Stay15";
            this.Stay15.Size = new System.Drawing.Size(52, 22);
            this.Stay15.TabIndex = 114;
            // 
            // Pos41
            // 
            this.Pos41.Enabled = false;
            this.Pos41.Location = new System.Drawing.Point(531, 905);
            this.Pos41.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos41.Name = "Pos41";
            this.Pos41.Size = new System.Drawing.Size(52, 22);
            this.Pos41.TabIndex = 322;
            // 
            // Stay16
            // 
            this.Stay16.Location = new System.Drawing.Point(400, 354);
            this.Stay16.Name = "Stay16";
            this.Stay16.Size = new System.Drawing.Size(52, 22);
            this.Stay16.TabIndex = 115;
            // 
            // Pos40
            // 
            this.Pos40.Enabled = false;
            this.Pos40.Location = new System.Drawing.Point(531, 883);
            this.Pos40.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos40.Name = "Pos40";
            this.Pos40.Size = new System.Drawing.Size(52, 22);
            this.Pos40.TabIndex = 321;
            // 
            // Stay17
            // 
            this.Stay17.Location = new System.Drawing.Point(400, 376);
            this.Stay17.Name = "Stay17";
            this.Stay17.Size = new System.Drawing.Size(52, 22);
            this.Stay17.TabIndex = 116;
            // 
            // Pos39
            // 
            this.Pos39.Enabled = false;
            this.Pos39.Location = new System.Drawing.Point(531, 861);
            this.Pos39.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos39.Name = "Pos39";
            this.Pos39.Size = new System.Drawing.Size(52, 22);
            this.Pos39.TabIndex = 320;
            // 
            // Stay18
            // 
            this.Stay18.Location = new System.Drawing.Point(400, 398);
            this.Stay18.Name = "Stay18";
            this.Stay18.Size = new System.Drawing.Size(52, 22);
            this.Stay18.TabIndex = 117;
            // 
            // Pos38
            // 
            this.Pos38.Enabled = false;
            this.Pos38.Location = new System.Drawing.Point(531, 839);
            this.Pos38.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos38.Name = "Pos38";
            this.Pos38.Size = new System.Drawing.Size(52, 22);
            this.Pos38.TabIndex = 319;
            // 
            // Stay19
            // 
            this.Stay19.Location = new System.Drawing.Point(400, 420);
            this.Stay19.Name = "Stay19";
            this.Stay19.Size = new System.Drawing.Size(52, 22);
            this.Stay19.TabIndex = 118;
            // 
            // Pos37
            // 
            this.Pos37.Enabled = false;
            this.Pos37.Location = new System.Drawing.Point(531, 817);
            this.Pos37.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos37.Name = "Pos37";
            this.Pos37.Size = new System.Drawing.Size(52, 22);
            this.Pos37.TabIndex = 318;
            // 
            // Stay20
            // 
            this.Stay20.Location = new System.Drawing.Point(400, 442);
            this.Stay20.Name = "Stay20";
            this.Stay20.Size = new System.Drawing.Size(52, 22);
            this.Stay20.TabIndex = 119;
            // 
            // Pos36
            // 
            this.Pos36.Enabled = false;
            this.Pos36.Location = new System.Drawing.Point(531, 795);
            this.Pos36.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos36.Name = "Pos36";
            this.Pos36.Size = new System.Drawing.Size(52, 22);
            this.Pos36.TabIndex = 317;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 120;
            this.label13.Text = "座椅";
            // 
            // Pos35
            // 
            this.Pos35.Enabled = false;
            this.Pos35.Location = new System.Drawing.Point(531, 773);
            this.Pos35.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos35.Name = "Pos35";
            this.Pos35.Size = new System.Drawing.Size(52, 22);
            this.Pos35.TabIndex = 316;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(171, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 121;
            this.label14.Text = "电机";
            // 
            // Pos34
            // 
            this.Pos34.Enabled = false;
            this.Pos34.Location = new System.Drawing.Point(531, 751);
            this.Pos34.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos34.Name = "Pos34";
            this.Pos34.Size = new System.Drawing.Size(52, 22);
            this.Pos34.TabIndex = 315;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(262, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 122;
            this.label15.Text = "起始位置";
            // 
            // Pos33
            // 
            this.Pos33.Enabled = false;
            this.Pos33.Location = new System.Drawing.Point(531, 729);
            this.Pos33.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos33.Name = "Pos33";
            this.Pos33.Size = new System.Drawing.Size(52, 22);
            this.Pos33.TabIndex = 314;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(330, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 123;
            this.label16.Text = "目标位置";
            // 
            // Pos32
            // 
            this.Pos32.Enabled = false;
            this.Pos32.Location = new System.Drawing.Point(531, 707);
            this.Pos32.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos32.Name = "Pos32";
            this.Pos32.Size = new System.Drawing.Size(52, 22);
            this.Pos32.TabIndex = 313;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(397, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 124;
            this.label17.Text = "停留时间";
            // 
            // Pos31
            // 
            this.Pos31.Enabled = false;
            this.Pos31.Location = new System.Drawing.Point(531, 685);
            this.Pos31.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos31.Name = "Pos31";
            this.Pos31.Size = new System.Drawing.Size(52, 22);
            this.Pos31.TabIndex = 312;
            // 
            // Pos2
            // 
            this.Pos2.Enabled = false;
            this.Pos2.Location = new System.Drawing.Point(531, 46);
            this.Pos2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos2.Name = "Pos2";
            this.Pos2.Size = new System.Drawing.Size(52, 22);
            this.Pos2.TabIndex = 126;
            // 
            // Pos30
            // 
            this.Pos30.Enabled = false;
            this.Pos30.Location = new System.Drawing.Point(531, 663);
            this.Pos30.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos30.Name = "Pos30";
            this.Pos30.Size = new System.Drawing.Size(52, 22);
            this.Pos30.TabIndex = 311;
            // 
            // Pos3
            // 
            this.Pos3.Enabled = false;
            this.Pos3.Location = new System.Drawing.Point(531, 68);
            this.Pos3.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos3.Name = "Pos3";
            this.Pos3.Size = new System.Drawing.Size(52, 22);
            this.Pos3.TabIndex = 127;
            // 
            // Pos29
            // 
            this.Pos29.Enabled = false;
            this.Pos29.Location = new System.Drawing.Point(531, 641);
            this.Pos29.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos29.Name = "Pos29";
            this.Pos29.Size = new System.Drawing.Size(52, 22);
            this.Pos29.TabIndex = 310;
            // 
            // Pos4
            // 
            this.Pos4.Enabled = false;
            this.Pos4.Location = new System.Drawing.Point(531, 90);
            this.Pos4.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos4.Name = "Pos4";
            this.Pos4.Size = new System.Drawing.Size(52, 22);
            this.Pos4.TabIndex = 128;
            // 
            // Pos28
            // 
            this.Pos28.Enabled = false;
            this.Pos28.Location = new System.Drawing.Point(531, 619);
            this.Pos28.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos28.Name = "Pos28";
            this.Pos28.Size = new System.Drawing.Size(52, 22);
            this.Pos28.TabIndex = 309;
            // 
            // Pos5
            // 
            this.Pos5.Enabled = false;
            this.Pos5.Location = new System.Drawing.Point(531, 112);
            this.Pos5.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos5.Name = "Pos5";
            this.Pos5.Size = new System.Drawing.Size(52, 22);
            this.Pos5.TabIndex = 129;
            // 
            // Pos27
            // 
            this.Pos27.Enabled = false;
            this.Pos27.Location = new System.Drawing.Point(531, 597);
            this.Pos27.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos27.Name = "Pos27";
            this.Pos27.Size = new System.Drawing.Size(52, 22);
            this.Pos27.TabIndex = 308;
            // 
            // Pos6
            // 
            this.Pos6.Enabled = false;
            this.Pos6.Location = new System.Drawing.Point(531, 134);
            this.Pos6.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos6.Name = "Pos6";
            this.Pos6.Size = new System.Drawing.Size(52, 22);
            this.Pos6.TabIndex = 130;
            // 
            // Stay46
            // 
            this.Stay46.Location = new System.Drawing.Point(400, 1015);
            this.Stay46.Name = "Stay46";
            this.Stay46.Size = new System.Drawing.Size(52, 22);
            this.Stay46.TabIndex = 307;
            // 
            // Pos7
            // 
            this.Pos7.Enabled = false;
            this.Pos7.Location = new System.Drawing.Point(531, 156);
            this.Pos7.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos7.Name = "Pos7";
            this.Pos7.Size = new System.Drawing.Size(52, 22);
            this.Pos7.TabIndex = 131;
            // 
            // Stay45
            // 
            this.Stay45.Location = new System.Drawing.Point(400, 993);
            this.Stay45.Name = "Stay45";
            this.Stay45.Size = new System.Drawing.Size(52, 22);
            this.Stay45.TabIndex = 306;
            // 
            // Pos8
            // 
            this.Pos8.Enabled = false;
            this.Pos8.Location = new System.Drawing.Point(531, 178);
            this.Pos8.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos8.Name = "Pos8";
            this.Pos8.Size = new System.Drawing.Size(52, 22);
            this.Pos8.TabIndex = 132;
            // 
            // Stay44
            // 
            this.Stay44.Location = new System.Drawing.Point(400, 971);
            this.Stay44.Name = "Stay44";
            this.Stay44.Size = new System.Drawing.Size(52, 22);
            this.Stay44.TabIndex = 305;
            // 
            // Pos9
            // 
            this.Pos9.Enabled = false;
            this.Pos9.Location = new System.Drawing.Point(531, 200);
            this.Pos9.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos9.Name = "Pos9";
            this.Pos9.Size = new System.Drawing.Size(52, 22);
            this.Pos9.TabIndex = 133;
            // 
            // Stay43
            // 
            this.Stay43.Location = new System.Drawing.Point(400, 949);
            this.Stay43.Name = "Stay43";
            this.Stay43.Size = new System.Drawing.Size(52, 22);
            this.Stay43.TabIndex = 304;
            // 
            // Pos10
            // 
            this.Pos10.Enabled = false;
            this.Pos10.Location = new System.Drawing.Point(531, 222);
            this.Pos10.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos10.Name = "Pos10";
            this.Pos10.Size = new System.Drawing.Size(52, 22);
            this.Pos10.TabIndex = 134;
            // 
            // Stay42
            // 
            this.Stay42.Location = new System.Drawing.Point(400, 927);
            this.Stay42.Name = "Stay42";
            this.Stay42.Size = new System.Drawing.Size(52, 22);
            this.Stay42.TabIndex = 303;
            // 
            // Pos11
            // 
            this.Pos11.Enabled = false;
            this.Pos11.Location = new System.Drawing.Point(531, 244);
            this.Pos11.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos11.Name = "Pos11";
            this.Pos11.Size = new System.Drawing.Size(52, 22);
            this.Pos11.TabIndex = 135;
            // 
            // Stay41
            // 
            this.Stay41.Location = new System.Drawing.Point(400, 905);
            this.Stay41.Name = "Stay41";
            this.Stay41.Size = new System.Drawing.Size(52, 22);
            this.Stay41.TabIndex = 302;
            // 
            // Pos12
            // 
            this.Pos12.Enabled = false;
            this.Pos12.Location = new System.Drawing.Point(531, 266);
            this.Pos12.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos12.Name = "Pos12";
            this.Pos12.Size = new System.Drawing.Size(52, 22);
            this.Pos12.TabIndex = 136;
            // 
            // Stay40
            // 
            this.Stay40.Location = new System.Drawing.Point(400, 883);
            this.Stay40.Name = "Stay40";
            this.Stay40.Size = new System.Drawing.Size(52, 22);
            this.Stay40.TabIndex = 301;
            // 
            // Pos13
            // 
            this.Pos13.Enabled = false;
            this.Pos13.Location = new System.Drawing.Point(531, 288);
            this.Pos13.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos13.Name = "Pos13";
            this.Pos13.Size = new System.Drawing.Size(52, 22);
            this.Pos13.TabIndex = 137;
            // 
            // Stay39
            // 
            this.Stay39.Location = new System.Drawing.Point(400, 861);
            this.Stay39.Name = "Stay39";
            this.Stay39.Size = new System.Drawing.Size(52, 22);
            this.Stay39.TabIndex = 300;
            // 
            // Pos14
            // 
            this.Pos14.Enabled = false;
            this.Pos14.Location = new System.Drawing.Point(531, 310);
            this.Pos14.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos14.Name = "Pos14";
            this.Pos14.Size = new System.Drawing.Size(52, 22);
            this.Pos14.TabIndex = 138;
            // 
            // Stay38
            // 
            this.Stay38.Location = new System.Drawing.Point(400, 839);
            this.Stay38.Name = "Stay38";
            this.Stay38.Size = new System.Drawing.Size(52, 22);
            this.Stay38.TabIndex = 299;
            // 
            // Pos15
            // 
            this.Pos15.Enabled = false;
            this.Pos15.Location = new System.Drawing.Point(531, 332);
            this.Pos15.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos15.Name = "Pos15";
            this.Pos15.Size = new System.Drawing.Size(52, 22);
            this.Pos15.TabIndex = 139;
            // 
            // Stay37
            // 
            this.Stay37.Location = new System.Drawing.Point(400, 817);
            this.Stay37.Name = "Stay37";
            this.Stay37.Size = new System.Drawing.Size(52, 22);
            this.Stay37.TabIndex = 298;
            // 
            // Pos16
            // 
            this.Pos16.Enabled = false;
            this.Pos16.Location = new System.Drawing.Point(531, 354);
            this.Pos16.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos16.Name = "Pos16";
            this.Pos16.Size = new System.Drawing.Size(52, 22);
            this.Pos16.TabIndex = 140;
            // 
            // Stay36
            // 
            this.Stay36.Location = new System.Drawing.Point(400, 795);
            this.Stay36.Name = "Stay36";
            this.Stay36.Size = new System.Drawing.Size(52, 22);
            this.Stay36.TabIndex = 297;
            // 
            // Pos17
            // 
            this.Pos17.Enabled = false;
            this.Pos17.Location = new System.Drawing.Point(531, 376);
            this.Pos17.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos17.Name = "Pos17";
            this.Pos17.Size = new System.Drawing.Size(52, 22);
            this.Pos17.TabIndex = 141;
            // 
            // Stay35
            // 
            this.Stay35.Location = new System.Drawing.Point(400, 773);
            this.Stay35.Name = "Stay35";
            this.Stay35.Size = new System.Drawing.Size(52, 22);
            this.Stay35.TabIndex = 296;
            // 
            // Pos18
            // 
            this.Pos18.Enabled = false;
            this.Pos18.Location = new System.Drawing.Point(531, 398);
            this.Pos18.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos18.Name = "Pos18";
            this.Pos18.Size = new System.Drawing.Size(52, 22);
            this.Pos18.TabIndex = 142;
            // 
            // Stay34
            // 
            this.Stay34.Location = new System.Drawing.Point(400, 751);
            this.Stay34.Name = "Stay34";
            this.Stay34.Size = new System.Drawing.Size(52, 22);
            this.Stay34.TabIndex = 295;
            // 
            // Pos19
            // 
            this.Pos19.Enabled = false;
            this.Pos19.Location = new System.Drawing.Point(531, 420);
            this.Pos19.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos19.Name = "Pos19";
            this.Pos19.Size = new System.Drawing.Size(52, 22);
            this.Pos19.TabIndex = 143;
            // 
            // Stay33
            // 
            this.Stay33.Location = new System.Drawing.Point(400, 729);
            this.Stay33.Name = "Stay33";
            this.Stay33.Size = new System.Drawing.Size(52, 22);
            this.Stay33.TabIndex = 294;
            // 
            // Pos20
            // 
            this.Pos20.Enabled = false;
            this.Pos20.Location = new System.Drawing.Point(531, 442);
            this.Pos20.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos20.Name = "Pos20";
            this.Pos20.Size = new System.Drawing.Size(52, 22);
            this.Pos20.TabIndex = 144;
            // 
            // Stay32
            // 
            this.Stay32.Location = new System.Drawing.Point(400, 707);
            this.Stay32.Name = "Stay32";
            this.Stay32.Size = new System.Drawing.Size(52, 22);
            this.Stay32.TabIndex = 293;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(528, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 145;
            this.label18.Text = "当前位置";
            // 
            // Stay31
            // 
            this.Stay31.Location = new System.Drawing.Point(400, 685);
            this.Stay31.Name = "Stay31";
            this.Stay31.Size = new System.Drawing.Size(52, 22);
            this.Stay31.TabIndex = 292;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(6, 465);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(38, 17);
            this.checkBox21.TabIndex = 146;
            this.checkBox21.Text = "21";
            this.checkBox21.UseVisualStyleBackColor = true;
            this.checkBox21.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
            // 
            // Stay30
            // 
            this.Stay30.Location = new System.Drawing.Point(400, 663);
            this.Stay30.Name = "Stay30";
            this.Stay30.Size = new System.Drawing.Size(52, 22);
            this.Stay30.TabIndex = 291;
            // 
            // Seat21
            // 
            this.Seat21.FormattingEnabled = true;
            this.Seat21.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat21.Location = new System.Drawing.Point(90, 463);
            this.Seat21.Name = "Seat21";
            this.Seat21.Size = new System.Drawing.Size(61, 21);
            this.Seat21.TabIndex = 147;
            // 
            // Stay29
            // 
            this.Stay29.Location = new System.Drawing.Point(400, 641);
            this.Stay29.Name = "Stay29";
            this.Stay29.Size = new System.Drawing.Size(52, 22);
            this.Stay29.TabIndex = 290;
            // 
            // Motor21
            // 
            this.Motor21.FormattingEnabled = true;
            this.Motor21.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor21.Location = new System.Drawing.Point(157, 463);
            this.Motor21.Name = "Motor21";
            this.Motor21.Size = new System.Drawing.Size(74, 21);
            this.Motor21.TabIndex = 148;
            // 
            // Stay28
            // 
            this.Stay28.Location = new System.Drawing.Point(400, 619);
            this.Stay28.Name = "Stay28";
            this.Stay28.Size = new System.Drawing.Size(52, 22);
            this.Stay28.TabIndex = 289;
            // 
            // Start21
            // 
            this.Start21.Location = new System.Drawing.Point(265, 464);
            this.Start21.Name = "Start21";
            this.Start21.Size = new System.Drawing.Size(52, 22);
            this.Start21.TabIndex = 149;
            // 
            // Stay27
            // 
            this.Stay27.Location = new System.Drawing.Point(400, 597);
            this.Stay27.Name = "Stay27";
            this.Stay27.Size = new System.Drawing.Size(52, 22);
            this.Stay27.TabIndex = 288;
            // 
            // Finish21
            // 
            this.Finish21.Location = new System.Drawing.Point(333, 464);
            this.Finish21.Name = "Finish21";
            this.Finish21.Size = new System.Drawing.Size(52, 22);
            this.Finish21.TabIndex = 150;
            // 
            // Finish46
            // 
            this.Finish46.Location = new System.Drawing.Point(333, 1015);
            this.Finish46.Name = "Finish46";
            this.Finish46.Size = new System.Drawing.Size(52, 22);
            this.Finish46.TabIndex = 287;
            // 
            // Stay21
            // 
            this.Stay21.Location = new System.Drawing.Point(400, 464);
            this.Stay21.Name = "Stay21";
            this.Stay21.Size = new System.Drawing.Size(52, 22);
            this.Stay21.TabIndex = 151;
            // 
            // Finish45
            // 
            this.Finish45.Location = new System.Drawing.Point(333, 993);
            this.Finish45.Name = "Finish45";
            this.Finish45.Size = new System.Drawing.Size(52, 22);
            this.Finish45.TabIndex = 286;
            // 
            // Pos21
            // 
            this.Pos21.Enabled = false;
            this.Pos21.Location = new System.Drawing.Point(531, 464);
            this.Pos21.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos21.Name = "Pos21";
            this.Pos21.Size = new System.Drawing.Size(52, 22);
            this.Pos21.TabIndex = 152;
            // 
            // Finish44
            // 
            this.Finish44.Location = new System.Drawing.Point(333, 971);
            this.Finish44.Name = "Finish44";
            this.Finish44.Size = new System.Drawing.Size(52, 22);
            this.Finish44.TabIndex = 285;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(6, 487);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(38, 17);
            this.checkBox22.TabIndex = 153;
            this.checkBox22.Text = "22";
            this.checkBox22.UseVisualStyleBackColor = true;
            this.checkBox22.CheckedChanged += new System.EventHandler(this.checkBox22_CheckedChanged);
            // 
            // Finish43
            // 
            this.Finish43.Location = new System.Drawing.Point(333, 949);
            this.Finish43.Name = "Finish43";
            this.Finish43.Size = new System.Drawing.Size(52, 22);
            this.Finish43.TabIndex = 284;
            // 
            // Seat22
            // 
            this.Seat22.FormattingEnabled = true;
            this.Seat22.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat22.Location = new System.Drawing.Point(90, 485);
            this.Seat22.Name = "Seat22";
            this.Seat22.Size = new System.Drawing.Size(61, 21);
            this.Seat22.TabIndex = 154;
            // 
            // Finish42
            // 
            this.Finish42.Location = new System.Drawing.Point(333, 927);
            this.Finish42.Name = "Finish42";
            this.Finish42.Size = new System.Drawing.Size(52, 22);
            this.Finish42.TabIndex = 283;
            // 
            // Motor22
            // 
            this.Motor22.FormattingEnabled = true;
            this.Motor22.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor22.Location = new System.Drawing.Point(157, 485);
            this.Motor22.Name = "Motor22";
            this.Motor22.Size = new System.Drawing.Size(74, 21);
            this.Motor22.TabIndex = 155;
            // 
            // Finish41
            // 
            this.Finish41.Location = new System.Drawing.Point(333, 905);
            this.Finish41.Name = "Finish41";
            this.Finish41.Size = new System.Drawing.Size(52, 22);
            this.Finish41.TabIndex = 282;
            // 
            // Start22
            // 
            this.Start22.Location = new System.Drawing.Point(265, 486);
            this.Start22.Name = "Start22";
            this.Start22.Size = new System.Drawing.Size(52, 22);
            this.Start22.TabIndex = 156;
            // 
            // Finish40
            // 
            this.Finish40.Location = new System.Drawing.Point(333, 883);
            this.Finish40.Name = "Finish40";
            this.Finish40.Size = new System.Drawing.Size(52, 22);
            this.Finish40.TabIndex = 281;
            // 
            // Finish22
            // 
            this.Finish22.Location = new System.Drawing.Point(333, 486);
            this.Finish22.Name = "Finish22";
            this.Finish22.Size = new System.Drawing.Size(52, 22);
            this.Finish22.TabIndex = 157;
            // 
            // Finish39
            // 
            this.Finish39.Location = new System.Drawing.Point(333, 861);
            this.Finish39.Name = "Finish39";
            this.Finish39.Size = new System.Drawing.Size(52, 22);
            this.Finish39.TabIndex = 280;
            // 
            // Stay22
            // 
            this.Stay22.Location = new System.Drawing.Point(400, 486);
            this.Stay22.Name = "Stay22";
            this.Stay22.Size = new System.Drawing.Size(52, 22);
            this.Stay22.TabIndex = 158;
            // 
            // Finish38
            // 
            this.Finish38.Location = new System.Drawing.Point(333, 839);
            this.Finish38.Name = "Finish38";
            this.Finish38.Size = new System.Drawing.Size(52, 22);
            this.Finish38.TabIndex = 279;
            // 
            // Pos22
            // 
            this.Pos22.Enabled = false;
            this.Pos22.Location = new System.Drawing.Point(531, 486);
            this.Pos22.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos22.Name = "Pos22";
            this.Pos22.Size = new System.Drawing.Size(52, 22);
            this.Pos22.TabIndex = 159;
            // 
            // Finish37
            // 
            this.Finish37.Location = new System.Drawing.Point(333, 817);
            this.Finish37.Name = "Finish37";
            this.Finish37.Size = new System.Drawing.Size(52, 22);
            this.Finish37.TabIndex = 278;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(6, 509);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(38, 17);
            this.checkBox23.TabIndex = 160;
            this.checkBox23.Text = "23";
            this.checkBox23.UseVisualStyleBackColor = true;
            this.checkBox23.CheckedChanged += new System.EventHandler(this.checkBox23_CheckedChanged);
            // 
            // Finish36
            // 
            this.Finish36.Location = new System.Drawing.Point(333, 795);
            this.Finish36.Name = "Finish36";
            this.Finish36.Size = new System.Drawing.Size(52, 22);
            this.Finish36.TabIndex = 277;
            // 
            // Seat23
            // 
            this.Seat23.FormattingEnabled = true;
            this.Seat23.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat23.Location = new System.Drawing.Point(90, 507);
            this.Seat23.Name = "Seat23";
            this.Seat23.Size = new System.Drawing.Size(61, 21);
            this.Seat23.TabIndex = 161;
            // 
            // Finish35
            // 
            this.Finish35.Location = new System.Drawing.Point(333, 773);
            this.Finish35.Name = "Finish35";
            this.Finish35.Size = new System.Drawing.Size(52, 22);
            this.Finish35.TabIndex = 276;
            // 
            // Motor23
            // 
            this.Motor23.FormattingEnabled = true;
            this.Motor23.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor23.Location = new System.Drawing.Point(157, 507);
            this.Motor23.Name = "Motor23";
            this.Motor23.Size = new System.Drawing.Size(74, 21);
            this.Motor23.TabIndex = 162;
            // 
            // Finish34
            // 
            this.Finish34.Location = new System.Drawing.Point(333, 751);
            this.Finish34.Name = "Finish34";
            this.Finish34.Size = new System.Drawing.Size(52, 22);
            this.Finish34.TabIndex = 275;
            // 
            // Start23
            // 
            this.Start23.Location = new System.Drawing.Point(265, 508);
            this.Start23.Name = "Start23";
            this.Start23.Size = new System.Drawing.Size(52, 22);
            this.Start23.TabIndex = 163;
            // 
            // Finish33
            // 
            this.Finish33.Location = new System.Drawing.Point(333, 729);
            this.Finish33.Name = "Finish33";
            this.Finish33.Size = new System.Drawing.Size(52, 22);
            this.Finish33.TabIndex = 274;
            // 
            // Finish23
            // 
            this.Finish23.Location = new System.Drawing.Point(333, 508);
            this.Finish23.Name = "Finish23";
            this.Finish23.Size = new System.Drawing.Size(52, 22);
            this.Finish23.TabIndex = 164;
            // 
            // Finish32
            // 
            this.Finish32.Location = new System.Drawing.Point(333, 707);
            this.Finish32.Name = "Finish32";
            this.Finish32.Size = new System.Drawing.Size(52, 22);
            this.Finish32.TabIndex = 273;
            // 
            // Stay23
            // 
            this.Stay23.Location = new System.Drawing.Point(400, 508);
            this.Stay23.Name = "Stay23";
            this.Stay23.Size = new System.Drawing.Size(52, 22);
            this.Stay23.TabIndex = 165;
            // 
            // Finish31
            // 
            this.Finish31.Location = new System.Drawing.Point(333, 685);
            this.Finish31.Name = "Finish31";
            this.Finish31.Size = new System.Drawing.Size(52, 22);
            this.Finish31.TabIndex = 272;
            // 
            // Pos23
            // 
            this.Pos23.Enabled = false;
            this.Pos23.Location = new System.Drawing.Point(531, 508);
            this.Pos23.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos23.Name = "Pos23";
            this.Pos23.Size = new System.Drawing.Size(52, 22);
            this.Pos23.TabIndex = 166;
            // 
            // Finish30
            // 
            this.Finish30.Location = new System.Drawing.Point(333, 663);
            this.Finish30.Name = "Finish30";
            this.Finish30.Size = new System.Drawing.Size(52, 22);
            this.Finish30.TabIndex = 271;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Location = new System.Drawing.Point(6, 531);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(38, 17);
            this.checkBox24.TabIndex = 167;
            this.checkBox24.Text = "24";
            this.checkBox24.UseVisualStyleBackColor = true;
            this.checkBox24.CheckedChanged += new System.EventHandler(this.checkBox24_CheckedChanged);
            // 
            // Finish29
            // 
            this.Finish29.Location = new System.Drawing.Point(333, 641);
            this.Finish29.Name = "Finish29";
            this.Finish29.Size = new System.Drawing.Size(52, 22);
            this.Finish29.TabIndex = 270;
            // 
            // Seat24
            // 
            this.Seat24.FormattingEnabled = true;
            this.Seat24.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat24.Location = new System.Drawing.Point(90, 529);
            this.Seat24.Name = "Seat24";
            this.Seat24.Size = new System.Drawing.Size(61, 21);
            this.Seat24.TabIndex = 168;
            // 
            // Finish28
            // 
            this.Finish28.Location = new System.Drawing.Point(333, 619);
            this.Finish28.Name = "Finish28";
            this.Finish28.Size = new System.Drawing.Size(52, 22);
            this.Finish28.TabIndex = 269;
            // 
            // Motor24
            // 
            this.Motor24.FormattingEnabled = true;
            this.Motor24.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor24.Location = new System.Drawing.Point(157, 529);
            this.Motor24.Name = "Motor24";
            this.Motor24.Size = new System.Drawing.Size(74, 21);
            this.Motor24.TabIndex = 169;
            // 
            // Finish27
            // 
            this.Finish27.Location = new System.Drawing.Point(333, 597);
            this.Finish27.Name = "Finish27";
            this.Finish27.Size = new System.Drawing.Size(52, 22);
            this.Finish27.TabIndex = 268;
            this.Finish27.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Start24
            // 
            this.Start24.Location = new System.Drawing.Point(265, 530);
            this.Start24.Name = "Start24";
            this.Start24.Size = new System.Drawing.Size(52, 22);
            this.Start24.TabIndex = 170;
            // 
            // Start46
            // 
            this.Start46.Location = new System.Drawing.Point(265, 1015);
            this.Start46.Name = "Start46";
            this.Start46.Size = new System.Drawing.Size(52, 22);
            this.Start46.TabIndex = 267;
            // 
            // Finish24
            // 
            this.Finish24.Location = new System.Drawing.Point(333, 530);
            this.Finish24.Name = "Finish24";
            this.Finish24.Size = new System.Drawing.Size(52, 22);
            this.Finish24.TabIndex = 171;
            // 
            // Start45
            // 
            this.Start45.Location = new System.Drawing.Point(265, 993);
            this.Start45.Name = "Start45";
            this.Start45.Size = new System.Drawing.Size(52, 22);
            this.Start45.TabIndex = 266;
            // 
            // Stay24
            // 
            this.Stay24.Location = new System.Drawing.Point(400, 530);
            this.Stay24.Name = "Stay24";
            this.Stay24.Size = new System.Drawing.Size(52, 22);
            this.Stay24.TabIndex = 172;
            // 
            // Start44
            // 
            this.Start44.Location = new System.Drawing.Point(265, 971);
            this.Start44.Name = "Start44";
            this.Start44.Size = new System.Drawing.Size(52, 22);
            this.Start44.TabIndex = 265;
            // 
            // Pos24
            // 
            this.Pos24.Enabled = false;
            this.Pos24.Location = new System.Drawing.Point(531, 530);
            this.Pos24.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos24.Name = "Pos24";
            this.Pos24.Size = new System.Drawing.Size(52, 22);
            this.Pos24.TabIndex = 173;
            // 
            // Start43
            // 
            this.Start43.Location = new System.Drawing.Point(265, 949);
            this.Start43.Name = "Start43";
            this.Start43.Size = new System.Drawing.Size(52, 22);
            this.Start43.TabIndex = 264;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Location = new System.Drawing.Point(6, 553);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(38, 17);
            this.checkBox25.TabIndex = 174;
            this.checkBox25.Text = "25";
            this.checkBox25.UseVisualStyleBackColor = true;
            this.checkBox25.CheckedChanged += new System.EventHandler(this.checkBox25_CheckedChanged);
            // 
            // Start42
            // 
            this.Start42.Location = new System.Drawing.Point(265, 927);
            this.Start42.Name = "Start42";
            this.Start42.Size = new System.Drawing.Size(52, 22);
            this.Start42.TabIndex = 263;
            // 
            // Seat25
            // 
            this.Seat25.FormattingEnabled = true;
            this.Seat25.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat25.Location = new System.Drawing.Point(90, 551);
            this.Seat25.Name = "Seat25";
            this.Seat25.Size = new System.Drawing.Size(61, 21);
            this.Seat25.TabIndex = 175;
            // 
            // Start41
            // 
            this.Start41.Location = new System.Drawing.Point(265, 905);
            this.Start41.Name = "Start41";
            this.Start41.Size = new System.Drawing.Size(52, 22);
            this.Start41.TabIndex = 262;
            // 
            // Motor25
            // 
            this.Motor25.FormattingEnabled = true;
            this.Motor25.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor25.Location = new System.Drawing.Point(157, 551);
            this.Motor25.Name = "Motor25";
            this.Motor25.Size = new System.Drawing.Size(74, 21);
            this.Motor25.TabIndex = 176;
            // 
            // Start40
            // 
            this.Start40.Location = new System.Drawing.Point(265, 883);
            this.Start40.Name = "Start40";
            this.Start40.Size = new System.Drawing.Size(52, 22);
            this.Start40.TabIndex = 261;
            // 
            // Start25
            // 
            this.Start25.Location = new System.Drawing.Point(265, 552);
            this.Start25.Name = "Start25";
            this.Start25.Size = new System.Drawing.Size(52, 22);
            this.Start25.TabIndex = 177;
            // 
            // Start39
            // 
            this.Start39.Location = new System.Drawing.Point(265, 861);
            this.Start39.Name = "Start39";
            this.Start39.Size = new System.Drawing.Size(52, 22);
            this.Start39.TabIndex = 260;
            // 
            // Finish25
            // 
            this.Finish25.Location = new System.Drawing.Point(333, 552);
            this.Finish25.Name = "Finish25";
            this.Finish25.Size = new System.Drawing.Size(52, 22);
            this.Finish25.TabIndex = 178;
            // 
            // Start38
            // 
            this.Start38.Location = new System.Drawing.Point(265, 839);
            this.Start38.Name = "Start38";
            this.Start38.Size = new System.Drawing.Size(52, 22);
            this.Start38.TabIndex = 259;
            // 
            // Stay25
            // 
            this.Stay25.Location = new System.Drawing.Point(400, 552);
            this.Stay25.Name = "Stay25";
            this.Stay25.Size = new System.Drawing.Size(52, 22);
            this.Stay25.TabIndex = 179;
            // 
            // Start37
            // 
            this.Start37.Location = new System.Drawing.Point(265, 817);
            this.Start37.Name = "Start37";
            this.Start37.Size = new System.Drawing.Size(52, 22);
            this.Start37.TabIndex = 258;
            // 
            // Pos25
            // 
            this.Pos25.Enabled = false;
            this.Pos25.Location = new System.Drawing.Point(531, 552);
            this.Pos25.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos25.Name = "Pos25";
            this.Pos25.Size = new System.Drawing.Size(52, 22);
            this.Pos25.TabIndex = 180;
            // 
            // Start36
            // 
            this.Start36.Location = new System.Drawing.Point(265, 795);
            this.Start36.Name = "Start36";
            this.Start36.Size = new System.Drawing.Size(52, 22);
            this.Start36.TabIndex = 257;
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Location = new System.Drawing.Point(6, 575);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(38, 17);
            this.checkBox26.TabIndex = 181;
            this.checkBox26.Text = "26";
            this.checkBox26.UseVisualStyleBackColor = true;
            this.checkBox26.CheckedChanged += new System.EventHandler(this.checkBox26_CheckedChanged);
            // 
            // Start35
            // 
            this.Start35.Location = new System.Drawing.Point(265, 773);
            this.Start35.Name = "Start35";
            this.Start35.Size = new System.Drawing.Size(52, 22);
            this.Start35.TabIndex = 256;
            // 
            // Seat26
            // 
            this.Seat26.FormattingEnabled = true;
            this.Seat26.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat26.Location = new System.Drawing.Point(90, 573);
            this.Seat26.Name = "Seat26";
            this.Seat26.Size = new System.Drawing.Size(61, 21);
            this.Seat26.TabIndex = 182;
            // 
            // Start34
            // 
            this.Start34.Location = new System.Drawing.Point(265, 751);
            this.Start34.Name = "Start34";
            this.Start34.Size = new System.Drawing.Size(52, 22);
            this.Start34.TabIndex = 255;
            // 
            // Motor26
            // 
            this.Motor26.FormattingEnabled = true;
            this.Motor26.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor26.Location = new System.Drawing.Point(157, 573);
            this.Motor26.Name = "Motor26";
            this.Motor26.Size = new System.Drawing.Size(74, 21);
            this.Motor26.TabIndex = 183;
            // 
            // Start33
            // 
            this.Start33.Location = new System.Drawing.Point(265, 729);
            this.Start33.Name = "Start33";
            this.Start33.Size = new System.Drawing.Size(52, 22);
            this.Start33.TabIndex = 254;
            // 
            // Start26
            // 
            this.Start26.Location = new System.Drawing.Point(265, 574);
            this.Start26.Name = "Start26";
            this.Start26.Size = new System.Drawing.Size(52, 22);
            this.Start26.TabIndex = 184;
            // 
            // Start32
            // 
            this.Start32.Location = new System.Drawing.Point(265, 707);
            this.Start32.Name = "Start32";
            this.Start32.Size = new System.Drawing.Size(52, 22);
            this.Start32.TabIndex = 253;
            // 
            // Finish26
            // 
            this.Finish26.Location = new System.Drawing.Point(333, 574);
            this.Finish26.Name = "Finish26";
            this.Finish26.Size = new System.Drawing.Size(52, 22);
            this.Finish26.TabIndex = 185;
            // 
            // Start31
            // 
            this.Start31.Location = new System.Drawing.Point(265, 685);
            this.Start31.Name = "Start31";
            this.Start31.Size = new System.Drawing.Size(52, 22);
            this.Start31.TabIndex = 252;
            // 
            // Stay26
            // 
            this.Stay26.Location = new System.Drawing.Point(400, 574);
            this.Stay26.Name = "Stay26";
            this.Stay26.Size = new System.Drawing.Size(52, 22);
            this.Stay26.TabIndex = 186;
            // 
            // Start30
            // 
            this.Start30.Location = new System.Drawing.Point(265, 663);
            this.Start30.Name = "Start30";
            this.Start30.Size = new System.Drawing.Size(52, 22);
            this.Start30.TabIndex = 251;
            // 
            // Pos26
            // 
            this.Pos26.Enabled = false;
            this.Pos26.Location = new System.Drawing.Point(531, 574);
            this.Pos26.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Pos26.Name = "Pos26";
            this.Pos26.Size = new System.Drawing.Size(52, 22);
            this.Pos26.TabIndex = 187;
            // 
            // Start29
            // 
            this.Start29.Location = new System.Drawing.Point(265, 641);
            this.Start29.Name = "Start29";
            this.Start29.Size = new System.Drawing.Size(52, 22);
            this.Start29.TabIndex = 250;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(6, 598);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(38, 17);
            this.checkBox27.TabIndex = 188;
            this.checkBox27.Text = "27";
            this.checkBox27.UseVisualStyleBackColor = true;
            this.checkBox27.CheckedChanged += new System.EventHandler(this.checkBox27_CheckedChanged);
            // 
            // Start28
            // 
            this.Start28.Location = new System.Drawing.Point(265, 619);
            this.Start28.Name = "Start28";
            this.Start28.Size = new System.Drawing.Size(52, 22);
            this.Start28.TabIndex = 249;
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Location = new System.Drawing.Point(6, 620);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(38, 17);
            this.checkBox28.TabIndex = 189;
            this.checkBox28.Text = "28";
            this.checkBox28.UseVisualStyleBackColor = true;
            this.checkBox28.CheckedChanged += new System.EventHandler(this.checkBox28_CheckedChanged);
            // 
            // Start27
            // 
            this.Start27.Location = new System.Drawing.Point(265, 597);
            this.Start27.Name = "Start27";
            this.Start27.Size = new System.Drawing.Size(52, 22);
            this.Start27.TabIndex = 248;
            this.Start27.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Location = new System.Drawing.Point(6, 642);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(38, 17);
            this.checkBox29.TabIndex = 190;
            this.checkBox29.Text = "29";
            this.checkBox29.UseVisualStyleBackColor = true;
            this.checkBox29.CheckedChanged += new System.EventHandler(this.checkBox29_CheckedChanged);
            // 
            // Motor46
            // 
            this.Motor46.FormattingEnabled = true;
            this.Motor46.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor46.Location = new System.Drawing.Point(157, 1014);
            this.Motor46.Name = "Motor46";
            this.Motor46.Size = new System.Drawing.Size(74, 21);
            this.Motor46.TabIndex = 247;
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Location = new System.Drawing.Point(6, 664);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(38, 17);
            this.checkBox30.TabIndex = 191;
            this.checkBox30.Text = "30";
            this.checkBox30.UseVisualStyleBackColor = true;
            this.checkBox30.CheckedChanged += new System.EventHandler(this.checkBox30_CheckedChanged);
            // 
            // Motor45
            // 
            this.Motor45.FormattingEnabled = true;
            this.Motor45.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor45.Location = new System.Drawing.Point(157, 992);
            this.Motor45.Name = "Motor45";
            this.Motor45.Size = new System.Drawing.Size(74, 21);
            this.Motor45.TabIndex = 246;
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Location = new System.Drawing.Point(6, 686);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(38, 17);
            this.checkBox31.TabIndex = 192;
            this.checkBox31.Text = "31";
            this.checkBox31.UseVisualStyleBackColor = true;
            this.checkBox31.CheckedChanged += new System.EventHandler(this.checkBox31_CheckedChanged);
            // 
            // Motor44
            // 
            this.Motor44.FormattingEnabled = true;
            this.Motor44.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor44.Location = new System.Drawing.Point(157, 970);
            this.Motor44.Name = "Motor44";
            this.Motor44.Size = new System.Drawing.Size(74, 21);
            this.Motor44.TabIndex = 245;
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.Location = new System.Drawing.Point(6, 708);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(38, 17);
            this.checkBox32.TabIndex = 193;
            this.checkBox32.Text = "32";
            this.checkBox32.UseVisualStyleBackColor = true;
            this.checkBox32.CheckedChanged += new System.EventHandler(this.checkBox32_CheckedChanged);
            // 
            // Motor43
            // 
            this.Motor43.FormattingEnabled = true;
            this.Motor43.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor43.Location = new System.Drawing.Point(157, 948);
            this.Motor43.Name = "Motor43";
            this.Motor43.Size = new System.Drawing.Size(74, 21);
            this.Motor43.TabIndex = 244;
            // 
            // checkBox33
            // 
            this.checkBox33.AutoSize = true;
            this.checkBox33.Location = new System.Drawing.Point(6, 730);
            this.checkBox33.Name = "checkBox33";
            this.checkBox33.Size = new System.Drawing.Size(38, 17);
            this.checkBox33.TabIndex = 194;
            this.checkBox33.Text = "33";
            this.checkBox33.UseVisualStyleBackColor = true;
            this.checkBox33.CheckedChanged += new System.EventHandler(this.checkBox33_CheckedChanged);
            // 
            // Motor42
            // 
            this.Motor42.FormattingEnabled = true;
            this.Motor42.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor42.Location = new System.Drawing.Point(157, 926);
            this.Motor42.Name = "Motor42";
            this.Motor42.Size = new System.Drawing.Size(74, 21);
            this.Motor42.TabIndex = 243;
            // 
            // checkBox34
            // 
            this.checkBox34.AutoSize = true;
            this.checkBox34.Location = new System.Drawing.Point(6, 752);
            this.checkBox34.Name = "checkBox34";
            this.checkBox34.Size = new System.Drawing.Size(38, 17);
            this.checkBox34.TabIndex = 195;
            this.checkBox34.Text = "34";
            this.checkBox34.UseVisualStyleBackColor = true;
            this.checkBox34.CheckedChanged += new System.EventHandler(this.checkBox34_CheckedChanged);
            // 
            // Motor41
            // 
            this.Motor41.FormattingEnabled = true;
            this.Motor41.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor41.Location = new System.Drawing.Point(157, 904);
            this.Motor41.Name = "Motor41";
            this.Motor41.Size = new System.Drawing.Size(74, 21);
            this.Motor41.TabIndex = 242;
            // 
            // checkBox35
            // 
            this.checkBox35.AutoSize = true;
            this.checkBox35.Location = new System.Drawing.Point(6, 774);
            this.checkBox35.Name = "checkBox35";
            this.checkBox35.Size = new System.Drawing.Size(38, 17);
            this.checkBox35.TabIndex = 196;
            this.checkBox35.Text = "35";
            this.checkBox35.UseVisualStyleBackColor = true;
            this.checkBox35.CheckedChanged += new System.EventHandler(this.checkBox35_CheckedChanged);
            // 
            // Motor40
            // 
            this.Motor40.FormattingEnabled = true;
            this.Motor40.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor40.Location = new System.Drawing.Point(157, 882);
            this.Motor40.Name = "Motor40";
            this.Motor40.Size = new System.Drawing.Size(74, 21);
            this.Motor40.TabIndex = 241;
            // 
            // checkBox36
            // 
            this.checkBox36.AutoSize = true;
            this.checkBox36.Location = new System.Drawing.Point(6, 796);
            this.checkBox36.Name = "checkBox36";
            this.checkBox36.Size = new System.Drawing.Size(38, 17);
            this.checkBox36.TabIndex = 197;
            this.checkBox36.Text = "36";
            this.checkBox36.UseVisualStyleBackColor = true;
            this.checkBox36.CheckedChanged += new System.EventHandler(this.checkBox36_CheckedChanged);
            // 
            // Motor39
            // 
            this.Motor39.FormattingEnabled = true;
            this.Motor39.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor39.Location = new System.Drawing.Point(157, 860);
            this.Motor39.Name = "Motor39";
            this.Motor39.Size = new System.Drawing.Size(74, 21);
            this.Motor39.TabIndex = 240;
            // 
            // checkBox37
            // 
            this.checkBox37.AutoSize = true;
            this.checkBox37.Location = new System.Drawing.Point(6, 818);
            this.checkBox37.Name = "checkBox37";
            this.checkBox37.Size = new System.Drawing.Size(38, 17);
            this.checkBox37.TabIndex = 198;
            this.checkBox37.Text = "37";
            this.checkBox37.UseVisualStyleBackColor = true;
            this.checkBox37.CheckedChanged += new System.EventHandler(this.checkBox37_CheckedChanged);
            // 
            // Motor38
            // 
            this.Motor38.FormattingEnabled = true;
            this.Motor38.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor38.Location = new System.Drawing.Point(157, 838);
            this.Motor38.Name = "Motor38";
            this.Motor38.Size = new System.Drawing.Size(74, 21);
            this.Motor38.TabIndex = 239;
            // 
            // checkBox38
            // 
            this.checkBox38.AutoSize = true;
            this.checkBox38.Location = new System.Drawing.Point(6, 840);
            this.checkBox38.Name = "checkBox38";
            this.checkBox38.Size = new System.Drawing.Size(38, 17);
            this.checkBox38.TabIndex = 199;
            this.checkBox38.Text = "38";
            this.checkBox38.UseVisualStyleBackColor = true;
            this.checkBox38.CheckedChanged += new System.EventHandler(this.checkBox38_CheckedChanged);
            // 
            // Motor37
            // 
            this.Motor37.FormattingEnabled = true;
            this.Motor37.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor37.Location = new System.Drawing.Point(157, 816);
            this.Motor37.Name = "Motor37";
            this.Motor37.Size = new System.Drawing.Size(74, 21);
            this.Motor37.TabIndex = 238;
            // 
            // checkBox39
            // 
            this.checkBox39.AutoSize = true;
            this.checkBox39.Location = new System.Drawing.Point(6, 862);
            this.checkBox39.Name = "checkBox39";
            this.checkBox39.Size = new System.Drawing.Size(38, 17);
            this.checkBox39.TabIndex = 200;
            this.checkBox39.Text = "39";
            this.checkBox39.UseVisualStyleBackColor = true;
            this.checkBox39.CheckedChanged += new System.EventHandler(this.checkBox39_CheckedChanged);
            // 
            // Motor36
            // 
            this.Motor36.FormattingEnabled = true;
            this.Motor36.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor36.Location = new System.Drawing.Point(157, 794);
            this.Motor36.Name = "Motor36";
            this.Motor36.Size = new System.Drawing.Size(74, 21);
            this.Motor36.TabIndex = 237;
            // 
            // checkBox40
            // 
            this.checkBox40.AutoSize = true;
            this.checkBox40.Location = new System.Drawing.Point(6, 884);
            this.checkBox40.Name = "checkBox40";
            this.checkBox40.Size = new System.Drawing.Size(38, 17);
            this.checkBox40.TabIndex = 201;
            this.checkBox40.Text = "40";
            this.checkBox40.UseVisualStyleBackColor = true;
            this.checkBox40.CheckedChanged += new System.EventHandler(this.checkBox40_CheckedChanged);
            // 
            // Motor35
            // 
            this.Motor35.FormattingEnabled = true;
            this.Motor35.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor35.Location = new System.Drawing.Point(157, 772);
            this.Motor35.Name = "Motor35";
            this.Motor35.Size = new System.Drawing.Size(74, 21);
            this.Motor35.TabIndex = 236;
            // 
            // checkBox41
            // 
            this.checkBox41.AutoSize = true;
            this.checkBox41.Location = new System.Drawing.Point(6, 906);
            this.checkBox41.Name = "checkBox41";
            this.checkBox41.Size = new System.Drawing.Size(38, 17);
            this.checkBox41.TabIndex = 202;
            this.checkBox41.Text = "41";
            this.checkBox41.UseVisualStyleBackColor = true;
            this.checkBox41.CheckedChanged += new System.EventHandler(this.checkBox41_CheckedChanged);
            // 
            // Motor34
            // 
            this.Motor34.FormattingEnabled = true;
            this.Motor34.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor34.Location = new System.Drawing.Point(157, 750);
            this.Motor34.Name = "Motor34";
            this.Motor34.Size = new System.Drawing.Size(74, 21);
            this.Motor34.TabIndex = 235;
            // 
            // checkBox42
            // 
            this.checkBox42.AutoSize = true;
            this.checkBox42.Location = new System.Drawing.Point(6, 928);
            this.checkBox42.Name = "checkBox42";
            this.checkBox42.Size = new System.Drawing.Size(38, 17);
            this.checkBox42.TabIndex = 203;
            this.checkBox42.Text = "42";
            this.checkBox42.UseVisualStyleBackColor = true;
            this.checkBox42.CheckedChanged += new System.EventHandler(this.checkBox42_CheckedChanged);
            // 
            // Motor33
            // 
            this.Motor33.FormattingEnabled = true;
            this.Motor33.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor33.Location = new System.Drawing.Point(157, 728);
            this.Motor33.Name = "Motor33";
            this.Motor33.Size = new System.Drawing.Size(74, 21);
            this.Motor33.TabIndex = 234;
            // 
            // checkBox43
            // 
            this.checkBox43.AutoSize = true;
            this.checkBox43.Location = new System.Drawing.Point(6, 950);
            this.checkBox43.Name = "checkBox43";
            this.checkBox43.Size = new System.Drawing.Size(38, 17);
            this.checkBox43.TabIndex = 204;
            this.checkBox43.Text = "43";
            this.checkBox43.UseVisualStyleBackColor = true;
            this.checkBox43.CheckedChanged += new System.EventHandler(this.checkBox43_CheckedChanged);
            // 
            // Motor32
            // 
            this.Motor32.FormattingEnabled = true;
            this.Motor32.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor32.Location = new System.Drawing.Point(157, 706);
            this.Motor32.Name = "Motor32";
            this.Motor32.Size = new System.Drawing.Size(74, 21);
            this.Motor32.TabIndex = 233;
            // 
            // checkBox44
            // 
            this.checkBox44.AutoSize = true;
            this.checkBox44.Location = new System.Drawing.Point(6, 972);
            this.checkBox44.Name = "checkBox44";
            this.checkBox44.Size = new System.Drawing.Size(38, 17);
            this.checkBox44.TabIndex = 205;
            this.checkBox44.Text = "44";
            this.checkBox44.UseVisualStyleBackColor = true;
            this.checkBox44.CheckedChanged += new System.EventHandler(this.checkBox44_CheckedChanged);
            // 
            // Motor31
            // 
            this.Motor31.FormattingEnabled = true;
            this.Motor31.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor31.Location = new System.Drawing.Point(157, 684);
            this.Motor31.Name = "Motor31";
            this.Motor31.Size = new System.Drawing.Size(74, 21);
            this.Motor31.TabIndex = 232;
            // 
            // checkBox45
            // 
            this.checkBox45.AutoSize = true;
            this.checkBox45.Location = new System.Drawing.Point(6, 994);
            this.checkBox45.Name = "checkBox45";
            this.checkBox45.Size = new System.Drawing.Size(38, 17);
            this.checkBox45.TabIndex = 206;
            this.checkBox45.Text = "45";
            this.checkBox45.UseVisualStyleBackColor = true;
            this.checkBox45.CheckedChanged += new System.EventHandler(this.checkBox45_CheckedChanged);
            // 
            // Motor30
            // 
            this.Motor30.FormattingEnabled = true;
            this.Motor30.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor30.Location = new System.Drawing.Point(157, 662);
            this.Motor30.Name = "Motor30";
            this.Motor30.Size = new System.Drawing.Size(74, 21);
            this.Motor30.TabIndex = 231;
            // 
            // checkBox46
            // 
            this.checkBox46.AutoSize = true;
            this.checkBox46.Location = new System.Drawing.Point(6, 1016);
            this.checkBox46.Name = "checkBox46";
            this.checkBox46.Size = new System.Drawing.Size(38, 17);
            this.checkBox46.TabIndex = 207;
            this.checkBox46.Text = "46";
            this.checkBox46.UseVisualStyleBackColor = true;
            this.checkBox46.CheckedChanged += new System.EventHandler(this.checkBox46_CheckedChanged);
            // 
            // Motor29
            // 
            this.Motor29.FormattingEnabled = true;
            this.Motor29.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor29.Location = new System.Drawing.Point(157, 640);
            this.Motor29.Name = "Motor29";
            this.Motor29.Size = new System.Drawing.Size(74, 21);
            this.Motor29.TabIndex = 230;
            // 
            // Seat27
            // 
            this.Seat27.FormattingEnabled = true;
            this.Seat27.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat27.Location = new System.Drawing.Point(90, 596);
            this.Seat27.Name = "Seat27";
            this.Seat27.Size = new System.Drawing.Size(61, 21);
            this.Seat27.TabIndex = 208;
            // 
            // Motor28
            // 
            this.Motor28.FormattingEnabled = true;
            this.Motor28.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor28.Location = new System.Drawing.Point(157, 618);
            this.Motor28.Name = "Motor28";
            this.Motor28.Size = new System.Drawing.Size(74, 21);
            this.Motor28.TabIndex = 229;
            // 
            // Seat28
            // 
            this.Seat28.FormattingEnabled = true;
            this.Seat28.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat28.Location = new System.Drawing.Point(90, 618);
            this.Seat28.Name = "Seat28";
            this.Seat28.Size = new System.Drawing.Size(61, 21);
            this.Seat28.TabIndex = 209;
            // 
            // Motor27
            // 
            this.Motor27.FormattingEnabled = true;
            this.Motor27.Items.AddRange(new object[] {
            "靠背",
            "坐垫翻折",
            "滑道",
            "腿托",
            "横移",
            "脚蹬",
            "前高调",
            "高调",
            "扶手屏",
            "腰托",
            "按摩",
            "加热",
            "通风"});
            this.Motor27.Location = new System.Drawing.Point(157, 596);
            this.Motor27.Name = "Motor27";
            this.Motor27.Size = new System.Drawing.Size(74, 21);
            this.Motor27.TabIndex = 228;
            // 
            // Seat29
            // 
            this.Seat29.FormattingEnabled = true;
            this.Seat29.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat29.Location = new System.Drawing.Point(90, 640);
            this.Seat29.Name = "Seat29";
            this.Seat29.Size = new System.Drawing.Size(61, 21);
            this.Seat29.TabIndex = 210;
            // 
            // Seat46
            // 
            this.Seat46.FormattingEnabled = true;
            this.Seat46.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat46.Location = new System.Drawing.Point(90, 1014);
            this.Seat46.Name = "Seat46";
            this.Seat46.Size = new System.Drawing.Size(61, 21);
            this.Seat46.TabIndex = 227;
            // 
            // Seat30
            // 
            this.Seat30.FormattingEnabled = true;
            this.Seat30.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat30.Location = new System.Drawing.Point(90, 662);
            this.Seat30.Name = "Seat30";
            this.Seat30.Size = new System.Drawing.Size(61, 21);
            this.Seat30.TabIndex = 211;
            // 
            // Seat45
            // 
            this.Seat45.FormattingEnabled = true;
            this.Seat45.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat45.Location = new System.Drawing.Point(90, 992);
            this.Seat45.Name = "Seat45";
            this.Seat45.Size = new System.Drawing.Size(61, 21);
            this.Seat45.TabIndex = 226;
            // 
            // Seat31
            // 
            this.Seat31.FormattingEnabled = true;
            this.Seat31.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat31.Location = new System.Drawing.Point(90, 684);
            this.Seat31.Name = "Seat31";
            this.Seat31.Size = new System.Drawing.Size(61, 21);
            this.Seat31.TabIndex = 212;
            // 
            // Seat44
            // 
            this.Seat44.FormattingEnabled = true;
            this.Seat44.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat44.Location = new System.Drawing.Point(90, 970);
            this.Seat44.Name = "Seat44";
            this.Seat44.Size = new System.Drawing.Size(61, 21);
            this.Seat44.TabIndex = 225;
            // 
            // Seat32
            // 
            this.Seat32.FormattingEnabled = true;
            this.Seat32.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat32.Location = new System.Drawing.Point(90, 706);
            this.Seat32.Name = "Seat32";
            this.Seat32.Size = new System.Drawing.Size(61, 21);
            this.Seat32.TabIndex = 213;
            // 
            // Seat43
            // 
            this.Seat43.FormattingEnabled = true;
            this.Seat43.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat43.Location = new System.Drawing.Point(90, 948);
            this.Seat43.Name = "Seat43";
            this.Seat43.Size = new System.Drawing.Size(61, 21);
            this.Seat43.TabIndex = 224;
            // 
            // Seat33
            // 
            this.Seat33.FormattingEnabled = true;
            this.Seat33.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat33.Location = new System.Drawing.Point(90, 728);
            this.Seat33.Name = "Seat33";
            this.Seat33.Size = new System.Drawing.Size(61, 21);
            this.Seat33.TabIndex = 214;
            // 
            // Seat42
            // 
            this.Seat42.FormattingEnabled = true;
            this.Seat42.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat42.Location = new System.Drawing.Point(90, 926);
            this.Seat42.Name = "Seat42";
            this.Seat42.Size = new System.Drawing.Size(61, 21);
            this.Seat42.TabIndex = 223;
            // 
            // Seat34
            // 
            this.Seat34.FormattingEnabled = true;
            this.Seat34.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat34.Location = new System.Drawing.Point(90, 750);
            this.Seat34.Name = "Seat34";
            this.Seat34.Size = new System.Drawing.Size(61, 21);
            this.Seat34.TabIndex = 215;
            // 
            // Seat41
            // 
            this.Seat41.FormattingEnabled = true;
            this.Seat41.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat41.Location = new System.Drawing.Point(90, 904);
            this.Seat41.Name = "Seat41";
            this.Seat41.Size = new System.Drawing.Size(61, 21);
            this.Seat41.TabIndex = 222;
            // 
            // Seat35
            // 
            this.Seat35.FormattingEnabled = true;
            this.Seat35.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat35.Location = new System.Drawing.Point(90, 772);
            this.Seat35.Name = "Seat35";
            this.Seat35.Size = new System.Drawing.Size(61, 21);
            this.Seat35.TabIndex = 216;
            // 
            // Seat40
            // 
            this.Seat40.FormattingEnabled = true;
            this.Seat40.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat40.Location = new System.Drawing.Point(90, 882);
            this.Seat40.Name = "Seat40";
            this.Seat40.Size = new System.Drawing.Size(61, 21);
            this.Seat40.TabIndex = 221;
            // 
            // Seat36
            // 
            this.Seat36.FormattingEnabled = true;
            this.Seat36.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat36.Location = new System.Drawing.Point(90, 794);
            this.Seat36.Name = "Seat36";
            this.Seat36.Size = new System.Drawing.Size(61, 21);
            this.Seat36.TabIndex = 217;
            // 
            // Seat39
            // 
            this.Seat39.FormattingEnabled = true;
            this.Seat39.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat39.Location = new System.Drawing.Point(90, 860);
            this.Seat39.Name = "Seat39";
            this.Seat39.Size = new System.Drawing.Size(61, 21);
            this.Seat39.TabIndex = 220;
            // 
            // Seat37
            // 
            this.Seat37.FormattingEnabled = true;
            this.Seat37.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat37.Location = new System.Drawing.Point(90, 816);
            this.Seat37.Name = "Seat37";
            this.Seat37.Size = new System.Drawing.Size(61, 21);
            this.Seat37.TabIndex = 218;
            // 
            // Seat38
            // 
            this.Seat38.FormattingEnabled = true;
            this.Seat38.Items.AddRange(new object[] {
            "主驾",
            "副驾",
            "二排左",
            "二排右",
            "三排左",
            "三排右"});
            this.Seat38.Location = new System.Drawing.Point(90, 838);
            this.Seat38.Name = "Seat38";
            this.Seat38.Size = new System.Drawing.Size(61, 21);
            this.Seat38.TabIndex = 219;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox16);
            this.tabPage2.Controls.Add(this.groupBox15);
            this.tabPage2.Controls.Add(this.groupBox13);
            this.tabPage2.Controls.Add(this.groupBox14);
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1216, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "控制";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv);
            this.groupBox16.Controls.Add(this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv);
            this.groupBox16.Controls.Add(this.SPS_3R_ThdRwRtStBkwdSwActv);
            this.groupBox16.Controls.Add(this.SPS_3R_ThdRwRtStFrwdSwActv);
            this.groupBox16.Controls.Add(this.SPS_3R_ThdRRtStExpdSwActv);
            this.groupBox16.Controls.Add(this.SPS_3R_AcsMdExtRtRclSwActv);
            this.groupBox16.Location = new System.Drawing.Point(262, 189);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(259, 186);
            this.groupBox16.TabIndex = 17;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "SPS_3R_Req_MSG-0x27";
            // 
            // SPS_3R_ThdRwRtStBkReclnDnwdSwActv
            // 
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.AutoSize = true;
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.Location = new System.Drawing.Point(14, 149);
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.Name = "SPS_3R_ThdRwRtStBkReclnDnwdSwActv";
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.TabIndex = 5;
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.Text = "靠背向后";
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3R_ThdRwRtStBkReclnDnwdSwActv_CheckedChanged);
            // 
            // SPS_3R_ThdRwRtStBkReclnUpwdSwActv
            // 
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.AutoSize = true;
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.Location = new System.Drawing.Point(14, 126);
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.Name = "SPS_3R_ThdRwRtStBkReclnUpwdSwActv";
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.TabIndex = 4;
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.Text = "靠背向前";
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3R_ThdRwRtStBkReclnUpwdSwActv_CheckedChanged);
            // 
            // SPS_3R_ThdRwRtStBkwdSwActv
            // 
            this.SPS_3R_ThdRwRtStBkwdSwActv.AutoSize = true;
            this.SPS_3R_ThdRwRtStBkwdSwActv.Location = new System.Drawing.Point(14, 103);
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
            this.SPS_3R_ThdRwRtStFrwdSwActv.Location = new System.Drawing.Point(14, 80);
            this.SPS_3R_ThdRwRtStFrwdSwActv.Name = "SPS_3R_ThdRwRtStFrwdSwActv";
            this.SPS_3R_ThdRwRtStFrwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_3R_ThdRwRtStFrwdSwActv.TabIndex = 2;
            this.SPS_3R_ThdRwRtStFrwdSwActv.Text = "水平向前";
            this.SPS_3R_ThdRwRtStFrwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3R_ThdRwRtStFrwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3R_ThdRwRtStFrwdSwActv_CheckedChanged);
            // 
            // SPS_3R_ThdRRtStExpdSwActv
            // 
            this.SPS_3R_ThdRRtStExpdSwActv.AutoSize = true;
            this.SPS_3R_ThdRRtStExpdSwActv.Location = new System.Drawing.Point(14, 57);
            this.SPS_3R_ThdRRtStExpdSwActv.Name = "SPS_3R_ThdRRtStExpdSwActv";
            this.SPS_3R_ThdRRtStExpdSwActv.Size = new System.Drawing.Size(104, 17);
            this.SPS_3R_ThdRRtStExpdSwActv.TabIndex = 1;
            this.SPS_3R_ThdRRtStExpdSwActv.Text = "折叠电机向下";
            this.SPS_3R_ThdRRtStExpdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3R_ThdRRtStExpdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3R_ThdRRtStExpdSwActv_CheckedChanged);
            // 
            // SPS_3R_AcsMdExtRtRclSwActv
            // 
            this.SPS_3R_AcsMdExtRtRclSwActv.AutoSize = true;
            this.SPS_3R_AcsMdExtRtRclSwActv.Location = new System.Drawing.Point(14, 34);
            this.SPS_3R_AcsMdExtRtRclSwActv.Name = "SPS_3R_AcsMdExtRtRclSwActv";
            this.SPS_3R_AcsMdExtRtRclSwActv.Size = new System.Drawing.Size(104, 17);
            this.SPS_3R_AcsMdExtRtRclSwActv.TabIndex = 0;
            this.SPS_3R_AcsMdExtRtRclSwActv.Text = "折叠电机向上";
            this.SPS_3R_AcsMdExtRtRclSwActv.UseVisualStyleBackColor = true;
            this.SPS_3R_AcsMdExtRtRclSwActv.CheckedChanged += new System.EventHandler(this.SPS_3R_AcsMdExtRtRclSwActv_CheckedChanged);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.SPS_3L_ThdRwStBkReclnDnwdSwActv);
            this.groupBox15.Controls.Add(this.SPS_3L_ThdRwStBkReclnUpwdSwActv);
            this.groupBox15.Controls.Add(this.SPS_3L_ThdRStBkwdSwActv);
            this.groupBox15.Controls.Add(this.SPS_3L_ThdRStFrwdSwActv);
            this.groupBox15.Controls.Add(this.SPS_3L_ThdRStExpdSwActv);
            this.groupBox15.Controls.Add(this.SPS_3L_AcsMdExtRclSwActv);
            this.groupBox15.Location = new System.Drawing.Point(8, 189);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(248, 186);
            this.groupBox15.TabIndex = 16;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "SPS_3L_Req_MSG-0x15";
            // 
            // SPS_3L_ThdRwStBkReclnDnwdSwActv
            // 
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv.AutoSize = true;
            this.SPS_3L_ThdRwStBkReclnDnwdSwActv.Location = new System.Drawing.Point(13, 149);
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
            this.SPS_3L_ThdRwStBkReclnUpwdSwActv.Location = new System.Drawing.Point(13, 126);
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
            this.SPS_3L_ThdRStBkwdSwActv.Location = new System.Drawing.Point(13, 103);
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
            this.SPS_3L_ThdRStFrwdSwActv.Location = new System.Drawing.Point(13, 80);
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
            this.SPS_3L_ThdRStExpdSwActv.Location = new System.Drawing.Point(13, 57);
            this.SPS_3L_ThdRStExpdSwActv.Name = "SPS_3L_ThdRStExpdSwActv";
            this.SPS_3L_ThdRStExpdSwActv.Size = new System.Drawing.Size(104, 17);
            this.SPS_3L_ThdRStExpdSwActv.TabIndex = 1;
            this.SPS_3L_ThdRStExpdSwActv.Text = "折叠电机向下";
            this.SPS_3L_ThdRStExpdSwActv.UseVisualStyleBackColor = true;
            this.SPS_3L_ThdRStExpdSwActv.CheckedChanged += new System.EventHandler(this.SPS_3L_ThdRStExpdSwActv_CheckedChanged);
            // 
            // SPS_3L_AcsMdExtRclSwActv
            // 
            this.SPS_3L_AcsMdExtRclSwActv.AutoSize = true;
            this.SPS_3L_AcsMdExtRclSwActv.Location = new System.Drawing.Point(13, 34);
            this.SPS_3L_AcsMdExtRclSwActv.Name = "SPS_3L_AcsMdExtRclSwActv";
            this.SPS_3L_AcsMdExtRclSwActv.Size = new System.Drawing.Size(104, 17);
            this.SPS_3L_AcsMdExtRclSwActv.TabIndex = 0;
            this.SPS_3L_AcsMdExtRclSwActv.Text = "折叠电机向上";
            this.SPS_3L_AcsMdExtRclSwActv.UseVisualStyleBackColor = true;
            this.SPS_3L_AcsMdExtRclSwActv.CheckedChanged += new System.EventHandler(this.SPS_3L_AcsMdExtRclSwActv_CheckedChanged);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.SecRwLtStVntDtyCycl);
            this.groupBox13.Controls.Add(this.SecRwLtStHtDtyCycl);
            this.groupBox13.Controls.Add(this.L_SecRwLtStArmScrnHMI2LReq);
            this.groupBox13.Controls.Add(this.SPS_2L_SecRwStLgrstDnwdSwActv);
            this.groupBox13.Controls.Add(this.SPS_2L_SecRwStLgrstUpwdSwActv);
            this.groupBox13.Controls.Add(this.SPS_2L_SecRwStBkReclnDnwdSwActv);
            this.groupBox13.Controls.Add(this.SPS_2L_SecRwStBkReclnUpwdSwActv);
            this.groupBox13.Controls.Add(this.SPS_2L_SecRwStBkwdSwActv);
            this.groupBox13.Controls.Add(this.SPS_2L_SecRwStFrwdSwActv);
            this.groupBox13.Location = new System.Drawing.Point(527, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(235, 281);
            this.groupBox13.TabIndex = 14;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "SPS_2L_Req_MSG-0x21";
            // 
            // SecRwLtStVntDtyCycl
            // 
            this.SecRwLtStVntDtyCycl.AutoSize = true;
            this.SecRwLtStVntDtyCycl.Location = new System.Drawing.Point(16, 249);
            this.SecRwLtStVntDtyCycl.Name = "SecRwLtStVntDtyCycl";
            this.SecRwLtStVntDtyCycl.Size = new System.Drawing.Size(52, 17);
            this.SecRwLtStVntDtyCycl.TabIndex = 12;
            this.SecRwLtStVntDtyCycl.Text = "通风";
            this.SecRwLtStVntDtyCycl.UseVisualStyleBackColor = true;
            // 
            // SecRwLtStHtDtyCycl
            // 
            this.SecRwLtStHtDtyCycl.AutoSize = true;
            this.SecRwLtStHtDtyCycl.Location = new System.Drawing.Point(16, 221);
            this.SecRwLtStHtDtyCycl.Name = "SecRwLtStHtDtyCycl";
            this.SecRwLtStHtDtyCycl.Size = new System.Drawing.Size(52, 17);
            this.SecRwLtStHtDtyCycl.TabIndex = 11;
            this.SecRwLtStHtDtyCycl.Text = "加热";
            this.SecRwLtStHtDtyCycl.UseVisualStyleBackColor = true;
            // 
            // L_SecRwLtStArmScrnHMI2LReq
            // 
            this.L_SecRwLtStArmScrnHMI2LReq.AutoSize = true;
            this.L_SecRwLtStArmScrnHMI2LReq.Location = new System.Drawing.Point(16, 193);
            this.L_SecRwLtStArmScrnHMI2LReq.Name = "L_SecRwLtStArmScrnHMI2LReq";
            this.L_SecRwLtStArmScrnHMI2LReq.Size = new System.Drawing.Size(78, 17);
            this.L_SecRwLtStArmScrnHMI2LReq.TabIndex = 10;
            this.L_SecRwLtStArmScrnHMI2LReq.Text = "扶手控制";
            this.L_SecRwLtStArmScrnHMI2LReq.UseVisualStyleBackColor = true;
            this.L_SecRwLtStArmScrnHMI2LReq.CheckedChanged += new System.EventHandler(this.L_SecRwLtStArmScrnHMI2LReq_CheckedChanged);
            // 
            // SPS_2L_SecRwStLgrstDnwdSwActv
            // 
            this.SPS_2L_SecRwStLgrstDnwdSwActv.AutoSize = true;
            this.SPS_2L_SecRwStLgrstDnwdSwActv.Location = new System.Drawing.Point(16, 165);
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
            this.SPS_2L_SecRwStLgrstUpwdSwActv.Location = new System.Drawing.Point(16, 137);
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
            this.SPS_2L_SecRwStBkReclnDnwdSwActv.Location = new System.Drawing.Point(16, 109);
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
            this.SPS_2L_SecRwStBkReclnUpwdSwActv.Location = new System.Drawing.Point(16, 81);
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
            this.SPS_2L_SecRwStBkwdSwActv.Location = new System.Drawing.Point(16, 53);
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
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.SecRwRtStVntDtyCycl);
            this.groupBox14.Controls.Add(this.SecRwRtStHtDtyCycl);
            this.groupBox14.Controls.Add(this.R_SecRwRtStArmScrnHMI2RReq);
            this.groupBox14.Controls.Add(this.SPS_2R_SecRwStLgrstDnwdSwActv);
            this.groupBox14.Controls.Add(this.SPS_2R_SecRwStLgrstUpwdSwActv);
            this.groupBox14.Controls.Add(this.SPS_2R_SecRwStBkReclnDnwdSwActv);
            this.groupBox14.Controls.Add(this.SPS_2R_SecRwStBkReclnUpwdSwActv);
            this.groupBox14.Controls.Add(this.SPS_2R_SecRwStBkwdSwActv);
            this.groupBox14.Controls.Add(this.SPS_2R_SecRwStFrwdSwActv);
            this.groupBox14.Location = new System.Drawing.Point(768, 8);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(225, 279);
            this.groupBox14.TabIndex = 15;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "SPS_2R_Req_MSG-0x11";
            // 
            // SecRwRtStVntDtyCycl
            // 
            this.SecRwRtStVntDtyCycl.AutoSize = true;
            this.SecRwRtStVntDtyCycl.Location = new System.Drawing.Point(6, 249);
            this.SecRwRtStVntDtyCycl.Name = "SecRwRtStVntDtyCycl";
            this.SecRwRtStVntDtyCycl.Size = new System.Drawing.Size(52, 17);
            this.SecRwRtStVntDtyCycl.TabIndex = 12;
            this.SecRwRtStVntDtyCycl.Text = "通风";
            this.SecRwRtStVntDtyCycl.UseVisualStyleBackColor = true;
            // 
            // SecRwRtStHtDtyCycl
            // 
            this.SecRwRtStHtDtyCycl.AutoSize = true;
            this.SecRwRtStHtDtyCycl.Location = new System.Drawing.Point(6, 221);
            this.SecRwRtStHtDtyCycl.Name = "SecRwRtStHtDtyCycl";
            this.SecRwRtStHtDtyCycl.Size = new System.Drawing.Size(52, 17);
            this.SecRwRtStHtDtyCycl.TabIndex = 11;
            this.SecRwRtStHtDtyCycl.Text = "加热";
            this.SecRwRtStHtDtyCycl.UseVisualStyleBackColor = true;
            // 
            // R_SecRwRtStArmScrnHMI2RReq
            // 
            this.R_SecRwRtStArmScrnHMI2RReq.AutoSize = true;
            this.R_SecRwRtStArmScrnHMI2RReq.Location = new System.Drawing.Point(6, 193);
            this.R_SecRwRtStArmScrnHMI2RReq.Name = "R_SecRwRtStArmScrnHMI2RReq";
            this.R_SecRwRtStArmScrnHMI2RReq.Size = new System.Drawing.Size(78, 17);
            this.R_SecRwRtStArmScrnHMI2RReq.TabIndex = 10;
            this.R_SecRwRtStArmScrnHMI2RReq.Text = "扶手控制";
            this.R_SecRwRtStArmScrnHMI2RReq.UseVisualStyleBackColor = true;
            this.R_SecRwRtStArmScrnHMI2RReq.CheckedChanged += new System.EventHandler(this.R_SecRwRtStArmScrnHMI2RReq_CheckedChanged);
            // 
            // SPS_2R_SecRwStLgrstDnwdSwActv
            // 
            this.SPS_2R_SecRwStLgrstDnwdSwActv.AutoSize = true;
            this.SPS_2R_SecRwStLgrstDnwdSwActv.Location = new System.Drawing.Point(6, 165);
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
            this.SPS_2R_SecRwStLgrstUpwdSwActv.Location = new System.Drawing.Point(6, 137);
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
            this.SPS_2R_SecRwStBkReclnDnwdSwActv.Location = new System.Drawing.Point(6, 109);
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
            this.SPS_2R_SecRwStBkReclnUpwdSwActv.Location = new System.Drawing.Point(6, 81);
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
            this.SPS_2R_SecRwStBkwdSwActv.Location = new System.Drawing.Point(6, 53);
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
            this.SPS_2R_SecRwStFrwdSwActv.Location = new System.Drawing.Point(6, 23);
            this.SPS_2R_SecRwStFrwdSwActv.Name = "SPS_2R_SecRwStFrwdSwActv";
            this.SPS_2R_SecRwStFrwdSwActv.Size = new System.Drawing.Size(78, 17);
            this.SPS_2R_SecRwStFrwdSwActv.TabIndex = 0;
            this.SPS_2R_SecRwStFrwdSwActv.Text = "水平向前";
            this.SPS_2R_SecRwStFrwdSwActv.UseVisualStyleBackColor = true;
            this.SPS_2R_SecRwStFrwdSwActv.CheckedChanged += new System.EventHandler(this.SPS_2R_SecRwStFrwdSwActv_CheckedChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.RtStFtDnwdHMI2LReq);
            this.groupBox12.Controls.Add(this.RtStFtUpwdHMI2LReq);
            this.groupBox12.Controls.Add(this.R_ReclineRrwdCustSeltn);
            this.groupBox12.Controls.Add(this.R_ReclineFrwdCustSeltn);
            this.groupBox12.Controls.Add(this.R_CushRrDwnCustSeltn);
            this.groupBox12.Controls.Add(this.R_CushRrUpCustSeltn);
            this.groupBox12.Controls.Add(this.R_CushFrtDwnCustSeltn);
            this.groupBox12.Controls.Add(this.R_CushFrtUpCustSeltn);
            this.groupBox12.Controls.Add(this.R_SeatRrwdCustSeltn);
            this.groupBox12.Controls.Add(this.R_SeatFrwdCustSeltn);
            this.groupBox12.Location = new System.Drawing.Point(262, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(259, 177);
            this.groupBox12.TabIndex = 12;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "SPS_CODR_Req_MSG-0x17";
            // 
            // RtStFtDnwdHMI2LReq
            // 
            this.RtStFtDnwdHMI2LReq.AutoSize = true;
            this.RtStFtDnwdHMI2LReq.Location = new System.Drawing.Point(160, 98);
            this.RtStFtDnwdHMI2LReq.Name = "RtStFtDnwdHMI2LReq";
            this.RtStFtDnwdHMI2LReq.Size = new System.Drawing.Size(78, 17);
            this.RtStFtDnwdHMI2LReq.TabIndex = 17;
            this.RtStFtDnwdHMI2LReq.Text = "脚蹬向下";
            this.RtStFtDnwdHMI2LReq.UseVisualStyleBackColor = true;
            this.RtStFtDnwdHMI2LReq.CheckedChanged += new System.EventHandler(this.RtStFtDnwdHMI2LReq_CheckedChanged);
            // 
            // RtStFtUpwdHMI2LReq
            // 
            this.RtStFtUpwdHMI2LReq.AutoSize = true;
            this.RtStFtUpwdHMI2LReq.Location = new System.Drawing.Point(160, 72);
            this.RtStFtUpwdHMI2LReq.Name = "RtStFtUpwdHMI2LReq";
            this.RtStFtUpwdHMI2LReq.Size = new System.Drawing.Size(78, 17);
            this.RtStFtUpwdHMI2LReq.TabIndex = 16;
            this.RtStFtUpwdHMI2LReq.Text = "脚蹬向上";
            this.RtStFtUpwdHMI2LReq.UseVisualStyleBackColor = true;
            this.RtStFtUpwdHMI2LReq.CheckedChanged += new System.EventHandler(this.RtStFtUpwdHMI2LReq_CheckedChanged);
            // 
            // R_ReclineRrwdCustSeltn
            // 
            this.R_ReclineRrwdCustSeltn.AutoSize = true;
            this.R_ReclineRrwdCustSeltn.Location = new System.Drawing.Point(160, 47);
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
            this.R_ReclineFrwdCustSeltn.Location = new System.Drawing.Point(160, 22);
            this.R_ReclineFrwdCustSeltn.Name = "R_ReclineFrwdCustSeltn";
            this.R_ReclineFrwdCustSeltn.Size = new System.Drawing.Size(78, 17);
            this.R_ReclineFrwdCustSeltn.TabIndex = 9;
            this.R_ReclineFrwdCustSeltn.Text = "靠背向前";
            this.R_ReclineFrwdCustSeltn.UseVisualStyleBackColor = true;
            this.R_ReclineFrwdCustSeltn.CheckedChanged += new System.EventHandler(this.R_ReclineFrwdCustSeltn_CheckedChanged);
            // 
            // R_CushRrDwnCustSeltn
            // 
            this.R_CushRrDwnCustSeltn.AutoSize = true;
            this.R_CushRrDwnCustSeltn.Location = new System.Drawing.Point(16, 145);
            this.R_CushRrDwnCustSeltn.Name = "R_CushRrDwnCustSeltn";
            this.R_CushRrDwnCustSeltn.Size = new System.Drawing.Size(91, 17);
            this.R_CushRrDwnCustSeltn.TabIndex = 6;
            this.R_CushRrDwnCustSeltn.Text = "后提升向下";
            this.R_CushRrDwnCustSeltn.UseVisualStyleBackColor = true;
            this.R_CushRrDwnCustSeltn.CheckedChanged += new System.EventHandler(this.R_CushRrDwnCustSeltn_CheckedChanged);
            // 
            // R_CushRrUpCustSeltn
            // 
            this.R_CushRrUpCustSeltn.AutoSize = true;
            this.R_CushRrUpCustSeltn.Location = new System.Drawing.Point(16, 120);
            this.R_CushRrUpCustSeltn.Name = "R_CushRrUpCustSeltn";
            this.R_CushRrUpCustSeltn.Size = new System.Drawing.Size(91, 17);
            this.R_CushRrUpCustSeltn.TabIndex = 5;
            this.R_CushRrUpCustSeltn.Text = "后提升向上";
            this.R_CushRrUpCustSeltn.UseVisualStyleBackColor = true;
            this.R_CushRrUpCustSeltn.CheckedChanged += new System.EventHandler(this.R_CushRrUpCustSeltn_CheckedChanged);
            // 
            // R_CushFrtDwnCustSeltn
            // 
            this.R_CushFrtDwnCustSeltn.AutoSize = true;
            this.R_CushFrtDwnCustSeltn.Location = new System.Drawing.Point(16, 97);
            this.R_CushFrtDwnCustSeltn.Name = "R_CushFrtDwnCustSeltn";
            this.R_CushFrtDwnCustSeltn.Size = new System.Drawing.Size(91, 17);
            this.R_CushFrtDwnCustSeltn.TabIndex = 3;
            this.R_CushFrtDwnCustSeltn.Text = "前提升向下";
            this.R_CushFrtDwnCustSeltn.UseVisualStyleBackColor = true;
            this.R_CushFrtDwnCustSeltn.CheckedChanged += new System.EventHandler(this.R_CushFrtDwnCustSeltn_CheckedChanged);
            // 
            // R_CushFrtUpCustSeltn
            // 
            this.R_CushFrtUpCustSeltn.AutoSize = true;
            this.R_CushFrtUpCustSeltn.Location = new System.Drawing.Point(16, 72);
            this.R_CushFrtUpCustSeltn.Name = "R_CushFrtUpCustSeltn";
            this.R_CushFrtUpCustSeltn.Size = new System.Drawing.Size(91, 17);
            this.R_CushFrtUpCustSeltn.TabIndex = 2;
            this.R_CushFrtUpCustSeltn.Text = "前提升向上";
            this.R_CushFrtUpCustSeltn.UseVisualStyleBackColor = true;
            this.R_CushFrtUpCustSeltn.CheckedChanged += new System.EventHandler(this.R_CushFrtUpCustSeltn_CheckedChanged);
            // 
            // R_SeatRrwdCustSeltn
            // 
            this.R_SeatRrwdCustSeltn.AutoSize = true;
            this.R_SeatRrwdCustSeltn.Location = new System.Drawing.Point(16, 47);
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
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.LtStFtDnwdHMI2LReq);
            this.groupBox11.Controls.Add(this.LtStFtUpwdHMI2LReq);
            this.groupBox11.Controls.Add(this.L_ReclineRrwdCustSeltn);
            this.groupBox11.Controls.Add(this.L_ReclineFrwdCustSeltn);
            this.groupBox11.Controls.Add(this.L_CushRrDwnCustSeltn);
            this.groupBox11.Controls.Add(this.L_CushRrUpCustSeltn);
            this.groupBox11.Controls.Add(this.L_CushFrtDwnCustSeltn);
            this.groupBox11.Controls.Add(this.L_CushFrtUpCustSeltn);
            this.groupBox11.Controls.Add(this.L_SeatRrwdCustSeltn);
            this.groupBox11.Controls.Add(this.L_SeatFrwdCustSeltn);
            this.groupBox11.Location = new System.Drawing.Point(8, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(248, 177);
            this.groupBox11.TabIndex = 11;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "SPS_DR_Req_MSG-0x31";
            // 
            // LtStFtDnwdHMI2LReq
            // 
            this.LtStFtDnwdHMI2LReq.AutoSize = true;
            this.LtStFtDnwdHMI2LReq.Location = new System.Drawing.Point(142, 99);
            this.LtStFtDnwdHMI2LReq.Name = "LtStFtDnwdHMI2LReq";
            this.LtStFtDnwdHMI2LReq.Size = new System.Drawing.Size(78, 17);
            this.LtStFtDnwdHMI2LReq.TabIndex = 17;
            this.LtStFtDnwdHMI2LReq.Text = "脚蹬向下";
            this.LtStFtDnwdHMI2LReq.UseVisualStyleBackColor = true;
            this.LtStFtDnwdHMI2LReq.CheckedChanged += new System.EventHandler(this.LtStFtDnwdHMI2LReq_CheckedChanged);
            // 
            // LtStFtUpwdHMI2LReq
            // 
            this.LtStFtUpwdHMI2LReq.AutoSize = true;
            this.LtStFtUpwdHMI2LReq.Location = new System.Drawing.Point(142, 72);
            this.LtStFtUpwdHMI2LReq.Name = "LtStFtUpwdHMI2LReq";
            this.LtStFtUpwdHMI2LReq.Size = new System.Drawing.Size(78, 17);
            this.LtStFtUpwdHMI2LReq.TabIndex = 16;
            this.LtStFtUpwdHMI2LReq.Text = "脚蹬向上";
            this.LtStFtUpwdHMI2LReq.UseVisualStyleBackColor = true;
            this.LtStFtUpwdHMI2LReq.CheckedChanged += new System.EventHandler(this.LtStFtUpwdHMI2LReq_CheckedChanged);
            // 
            // L_ReclineRrwdCustSeltn
            // 
            this.L_ReclineRrwdCustSeltn.AutoSize = true;
            this.L_ReclineRrwdCustSeltn.Location = new System.Drawing.Point(142, 47);
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
            this.L_ReclineFrwdCustSeltn.Location = new System.Drawing.Point(142, 22);
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
            this.L_CushRrDwnCustSeltn.Location = new System.Drawing.Point(13, 145);
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
            this.L_CushRrUpCustSeltn.Location = new System.Drawing.Point(13, 120);
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
            this.L_CushFrtDwnCustSeltn.Location = new System.Drawing.Point(13, 97);
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
            this.L_CushFrtUpCustSeltn.Location = new System.Drawing.Point(13, 72);
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
            this.L_SeatRrwdCustSeltn.Location = new System.Drawing.Point(13, 47);
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
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StandardBar);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGM458";
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
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FinishCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CycleTimes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pos1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stay26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start27)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown FinishCount;
        private System.Windows.Forms.NumericUpDown CycleTimes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Stay20;
        private System.Windows.Forms.NumericUpDown Stay19;
        private System.Windows.Forms.NumericUpDown Stay18;
        private System.Windows.Forms.NumericUpDown Stay17;
        private System.Windows.Forms.NumericUpDown Stay16;
        private System.Windows.Forms.NumericUpDown Stay15;
        private System.Windows.Forms.NumericUpDown Stay14;
        private System.Windows.Forms.NumericUpDown Stay13;
        private System.Windows.Forms.NumericUpDown Stay12;
        private System.Windows.Forms.NumericUpDown Stay11;
        private System.Windows.Forms.NumericUpDown Stay10;
        private System.Windows.Forms.NumericUpDown Stay9;
        private System.Windows.Forms.NumericUpDown Stay8;
        private System.Windows.Forms.NumericUpDown Stay7;
        private System.Windows.Forms.NumericUpDown Stay6;
        private System.Windows.Forms.NumericUpDown Stay5;
        private System.Windows.Forms.NumericUpDown Stay4;
        private System.Windows.Forms.NumericUpDown Stay3;
        private System.Windows.Forms.NumericUpDown Stay2;
        private System.Windows.Forms.NumericUpDown Stay1;
        private System.Windows.Forms.NumericUpDown Finish20;
        private System.Windows.Forms.NumericUpDown Finish19;
        private System.Windows.Forms.NumericUpDown Finish18;
        private System.Windows.Forms.NumericUpDown Finish17;
        private System.Windows.Forms.NumericUpDown Finish16;
        private System.Windows.Forms.NumericUpDown Finish15;
        private System.Windows.Forms.NumericUpDown Finish14;
        private System.Windows.Forms.NumericUpDown Finish13;
        private System.Windows.Forms.NumericUpDown Finish12;
        private System.Windows.Forms.NumericUpDown Finish11;
        private System.Windows.Forms.NumericUpDown Finish10;
        private System.Windows.Forms.NumericUpDown Finish9;
        private System.Windows.Forms.NumericUpDown Finish8;
        private System.Windows.Forms.NumericUpDown Finish7;
        private System.Windows.Forms.NumericUpDown Finish6;
        private System.Windows.Forms.NumericUpDown Finish5;
        private System.Windows.Forms.NumericUpDown Finish4;
        private System.Windows.Forms.NumericUpDown Finish3;
        private System.Windows.Forms.NumericUpDown Finish2;
        private System.Windows.Forms.NumericUpDown Finish1;
        private System.Windows.Forms.NumericUpDown Start20;
        private System.Windows.Forms.NumericUpDown Start19;
        private System.Windows.Forms.NumericUpDown Start18;
        private System.Windows.Forms.NumericUpDown Start17;
        private System.Windows.Forms.NumericUpDown Start16;
        private System.Windows.Forms.NumericUpDown Start15;
        private System.Windows.Forms.NumericUpDown Start14;
        private System.Windows.Forms.NumericUpDown Start13;
        private System.Windows.Forms.NumericUpDown Start12;
        private System.Windows.Forms.NumericUpDown Start11;
        private System.Windows.Forms.NumericUpDown Start10;
        private System.Windows.Forms.NumericUpDown Start9;
        private System.Windows.Forms.NumericUpDown Start8;
        private System.Windows.Forms.NumericUpDown Start7;
        private System.Windows.Forms.NumericUpDown Start6;
        private System.Windows.Forms.NumericUpDown Start5;
        private System.Windows.Forms.NumericUpDown Start4;
        private System.Windows.Forms.NumericUpDown Start3;
        private System.Windows.Forms.NumericUpDown Start2;
        private System.Windows.Forms.NumericUpDown Start1;
        private System.Windows.Forms.ComboBox Motor20;
        private System.Windows.Forms.ComboBox Motor19;
        private System.Windows.Forms.ComboBox Motor18;
        private System.Windows.Forms.ComboBox Motor17;
        private System.Windows.Forms.ComboBox Motor16;
        private System.Windows.Forms.ComboBox Motor15;
        private System.Windows.Forms.ComboBox Motor14;
        private System.Windows.Forms.ComboBox Motor13;
        private System.Windows.Forms.ComboBox Motor12;
        private System.Windows.Forms.ComboBox Motor11;
        private System.Windows.Forms.ComboBox Motor10;
        private System.Windows.Forms.ComboBox Motor9;
        private System.Windows.Forms.ComboBox Motor8;
        private System.Windows.Forms.ComboBox Motor7;
        private System.Windows.Forms.ComboBox Motor6;
        private System.Windows.Forms.ComboBox Motor5;
        private System.Windows.Forms.ComboBox Motor4;
        private System.Windows.Forms.ComboBox Motor3;
        private System.Windows.Forms.ComboBox Motor2;
        private System.Windows.Forms.ComboBox Motor1;
        private System.Windows.Forms.ComboBox Seat20;
        private System.Windows.Forms.ComboBox Seat19;
        private System.Windows.Forms.ComboBox Seat18;
        private System.Windows.Forms.ComboBox Seat17;
        private System.Windows.Forms.ComboBox Seat16;
        private System.Windows.Forms.ComboBox Seat15;
        private System.Windows.Forms.ComboBox Seat14;
        private System.Windows.Forms.ComboBox Seat13;
        private System.Windows.Forms.ComboBox Seat12;
        private System.Windows.Forms.ComboBox Seat11;
        private System.Windows.Forms.ComboBox Seat10;
        private System.Windows.Forms.ComboBox Seat9;
        private System.Windows.Forms.ComboBox Seat8;
        private System.Windows.Forms.ComboBox Seat7;
        private System.Windows.Forms.ComboBox Seat6;
        private System.Windows.Forms.ComboBox Seat5;
        private System.Windows.Forms.ComboBox Seat4;
        private System.Windows.Forms.ComboBox Seat3;
        private System.Windows.Forms.ComboBox Seat2;
        private System.Windows.Forms.ComboBox Seat1;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown Pos20;
        private System.Windows.Forms.NumericUpDown Pos19;
        private System.Windows.Forms.NumericUpDown Pos18;
        private System.Windows.Forms.NumericUpDown Pos17;
        private System.Windows.Forms.NumericUpDown Pos16;
        private System.Windows.Forms.NumericUpDown Pos15;
        private System.Windows.Forms.NumericUpDown Pos14;
        private System.Windows.Forms.NumericUpDown Pos13;
        private System.Windows.Forms.NumericUpDown Pos12;
        private System.Windows.Forms.NumericUpDown Pos11;
        private System.Windows.Forms.NumericUpDown Pos10;
        private System.Windows.Forms.NumericUpDown Pos9;
        private System.Windows.Forms.NumericUpDown Pos8;
        private System.Windows.Forms.NumericUpDown Pos7;
        private System.Windows.Forms.NumericUpDown Pos6;
        private System.Windows.Forms.NumericUpDown Pos5;
        private System.Windows.Forms.NumericUpDown Pos4;
        private System.Windows.Forms.NumericUpDown Pos3;
        private System.Windows.Forms.NumericUpDown Pos2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown Pos24;
        private System.Windows.Forms.NumericUpDown Stay24;
        private System.Windows.Forms.NumericUpDown Finish24;
        private System.Windows.Forms.NumericUpDown Start24;
        private System.Windows.Forms.ComboBox Motor24;
        private System.Windows.Forms.ComboBox Seat24;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.NumericUpDown Pos23;
        private System.Windows.Forms.NumericUpDown Stay23;
        private System.Windows.Forms.NumericUpDown Finish23;
        private System.Windows.Forms.NumericUpDown Start23;
        private System.Windows.Forms.ComboBox Motor23;
        private System.Windows.Forms.ComboBox Seat23;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.NumericUpDown Pos22;
        private System.Windows.Forms.NumericUpDown Stay22;
        private System.Windows.Forms.NumericUpDown Finish22;
        private System.Windows.Forms.NumericUpDown Start22;
        private System.Windows.Forms.ComboBox Motor22;
        private System.Windows.Forms.ComboBox Seat22;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.NumericUpDown Pos21;
        private System.Windows.Forms.NumericUpDown Stay21;
        private System.Windows.Forms.NumericUpDown Finish21;
        private System.Windows.Forms.NumericUpDown Start21;
        private System.Windows.Forms.ComboBox Motor21;
        private System.Windows.Forms.ComboBox Seat21;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.NumericUpDown Pos52;
        private System.Windows.Forms.NumericUpDown Stay52;
        private System.Windows.Forms.NumericUpDown Finish52;
        private System.Windows.Forms.NumericUpDown Start52;
        private System.Windows.Forms.ComboBox Motor52;
        private System.Windows.Forms.ComboBox Seat52;
        private System.Windows.Forms.CheckBox checkBox52;
        private System.Windows.Forms.NumericUpDown Pos51;
        private System.Windows.Forms.NumericUpDown Stay51;
        private System.Windows.Forms.NumericUpDown Finish51;
        private System.Windows.Forms.NumericUpDown Start51;
        private System.Windows.Forms.ComboBox Motor51;
        private System.Windows.Forms.ComboBox Seat51;
        private System.Windows.Forms.CheckBox checkBox51;
        private System.Windows.Forms.NumericUpDown Pos50;
        private System.Windows.Forms.NumericUpDown Stay50;
        private System.Windows.Forms.NumericUpDown Finish50;
        private System.Windows.Forms.NumericUpDown Start50;
        private System.Windows.Forms.ComboBox Motor50;
        private System.Windows.Forms.ComboBox Seat50;
        private System.Windows.Forms.CheckBox checkBox50;
        private System.Windows.Forms.NumericUpDown Pos49;
        private System.Windows.Forms.NumericUpDown Stay49;
        private System.Windows.Forms.NumericUpDown Finish49;
        private System.Windows.Forms.NumericUpDown Start49;
        private System.Windows.Forms.ComboBox Motor49;
        private System.Windows.Forms.ComboBox Seat49;
        private System.Windows.Forms.CheckBox checkBox49;
        private System.Windows.Forms.NumericUpDown Pos48;
        private System.Windows.Forms.NumericUpDown Stay48;
        private System.Windows.Forms.NumericUpDown Finish48;
        private System.Windows.Forms.NumericUpDown Start48;
        private System.Windows.Forms.ComboBox Motor48;
        private System.Windows.Forms.ComboBox Seat48;
        private System.Windows.Forms.CheckBox checkBox48;
        private System.Windows.Forms.NumericUpDown Pos47;
        private System.Windows.Forms.NumericUpDown Stay47;
        private System.Windows.Forms.NumericUpDown Finish47;
        private System.Windows.Forms.NumericUpDown Start47;
        private System.Windows.Forms.ComboBox Motor47;
        private System.Windows.Forms.ComboBox Seat47;
        private System.Windows.Forms.CheckBox checkBox47;
        private System.Windows.Forms.NumericUpDown Pos46;
        private System.Windows.Forms.NumericUpDown Pos45;
        private System.Windows.Forms.NumericUpDown Pos44;
        private System.Windows.Forms.NumericUpDown Pos43;
        private System.Windows.Forms.NumericUpDown Pos42;
        private System.Windows.Forms.NumericUpDown Pos41;
        private System.Windows.Forms.NumericUpDown Pos40;
        private System.Windows.Forms.NumericUpDown Pos39;
        private System.Windows.Forms.NumericUpDown Pos38;
        private System.Windows.Forms.NumericUpDown Pos37;
        private System.Windows.Forms.NumericUpDown Pos36;
        private System.Windows.Forms.NumericUpDown Pos35;
        private System.Windows.Forms.NumericUpDown Pos34;
        private System.Windows.Forms.NumericUpDown Pos33;
        private System.Windows.Forms.NumericUpDown Pos32;
        private System.Windows.Forms.NumericUpDown Pos31;
        private System.Windows.Forms.NumericUpDown Pos30;
        private System.Windows.Forms.NumericUpDown Pos29;
        private System.Windows.Forms.NumericUpDown Pos28;
        private System.Windows.Forms.NumericUpDown Pos27;
        private System.Windows.Forms.NumericUpDown Stay46;
        private System.Windows.Forms.NumericUpDown Stay45;
        private System.Windows.Forms.NumericUpDown Stay44;
        private System.Windows.Forms.NumericUpDown Stay43;
        private System.Windows.Forms.NumericUpDown Stay42;
        private System.Windows.Forms.NumericUpDown Stay41;
        private System.Windows.Forms.NumericUpDown Stay40;
        private System.Windows.Forms.NumericUpDown Stay39;
        private System.Windows.Forms.NumericUpDown Stay38;
        private System.Windows.Forms.NumericUpDown Stay37;
        private System.Windows.Forms.NumericUpDown Stay36;
        private System.Windows.Forms.NumericUpDown Stay35;
        private System.Windows.Forms.NumericUpDown Stay34;
        private System.Windows.Forms.NumericUpDown Stay33;
        private System.Windows.Forms.NumericUpDown Stay32;
        private System.Windows.Forms.NumericUpDown Stay31;
        private System.Windows.Forms.NumericUpDown Stay30;
        private System.Windows.Forms.NumericUpDown Stay29;
        private System.Windows.Forms.NumericUpDown Stay28;
        private System.Windows.Forms.NumericUpDown Stay27;
        private System.Windows.Forms.NumericUpDown Finish46;
        private System.Windows.Forms.NumericUpDown Finish45;
        private System.Windows.Forms.NumericUpDown Finish44;
        private System.Windows.Forms.NumericUpDown Finish43;
        private System.Windows.Forms.NumericUpDown Finish42;
        private System.Windows.Forms.NumericUpDown Finish41;
        private System.Windows.Forms.NumericUpDown Finish40;
        private System.Windows.Forms.NumericUpDown Finish39;
        private System.Windows.Forms.NumericUpDown Finish38;
        private System.Windows.Forms.NumericUpDown Finish37;
        private System.Windows.Forms.NumericUpDown Finish36;
        private System.Windows.Forms.NumericUpDown Finish35;
        private System.Windows.Forms.NumericUpDown Finish34;
        private System.Windows.Forms.NumericUpDown Finish33;
        private System.Windows.Forms.NumericUpDown Finish32;
        private System.Windows.Forms.NumericUpDown Finish31;
        private System.Windows.Forms.NumericUpDown Finish30;
        private System.Windows.Forms.NumericUpDown Finish29;
        private System.Windows.Forms.NumericUpDown Finish28;
        private System.Windows.Forms.NumericUpDown Finish27;
        private System.Windows.Forms.NumericUpDown Start46;
        private System.Windows.Forms.NumericUpDown Start45;
        private System.Windows.Forms.NumericUpDown Start44;
        private System.Windows.Forms.NumericUpDown Start43;
        private System.Windows.Forms.NumericUpDown Start42;
        private System.Windows.Forms.NumericUpDown Start41;
        private System.Windows.Forms.NumericUpDown Start40;
        private System.Windows.Forms.NumericUpDown Start39;
        private System.Windows.Forms.NumericUpDown Start38;
        private System.Windows.Forms.NumericUpDown Start37;
        private System.Windows.Forms.NumericUpDown Start36;
        private System.Windows.Forms.NumericUpDown Start35;
        private System.Windows.Forms.NumericUpDown Start34;
        private System.Windows.Forms.NumericUpDown Start33;
        private System.Windows.Forms.NumericUpDown Start32;
        private System.Windows.Forms.NumericUpDown Start31;
        private System.Windows.Forms.NumericUpDown Start30;
        private System.Windows.Forms.NumericUpDown Start29;
        private System.Windows.Forms.NumericUpDown Start28;
        private System.Windows.Forms.NumericUpDown Start27;
        private System.Windows.Forms.ComboBox Motor46;
        private System.Windows.Forms.ComboBox Motor45;
        private System.Windows.Forms.ComboBox Motor44;
        private System.Windows.Forms.ComboBox Motor43;
        private System.Windows.Forms.ComboBox Motor42;
        private System.Windows.Forms.ComboBox Motor41;
        private System.Windows.Forms.ComboBox Motor40;
        private System.Windows.Forms.ComboBox Motor39;
        private System.Windows.Forms.ComboBox Motor38;
        private System.Windows.Forms.ComboBox Motor37;
        private System.Windows.Forms.ComboBox Motor36;
        private System.Windows.Forms.ComboBox Motor35;
        private System.Windows.Forms.ComboBox Motor34;
        private System.Windows.Forms.ComboBox Motor33;
        private System.Windows.Forms.ComboBox Motor32;
        private System.Windows.Forms.ComboBox Motor31;
        private System.Windows.Forms.ComboBox Motor30;
        private System.Windows.Forms.ComboBox Motor29;
        private System.Windows.Forms.ComboBox Motor28;
        private System.Windows.Forms.ComboBox Motor27;
        private System.Windows.Forms.ComboBox Seat46;
        private System.Windows.Forms.ComboBox Seat45;
        private System.Windows.Forms.ComboBox Seat44;
        private System.Windows.Forms.ComboBox Seat43;
        private System.Windows.Forms.ComboBox Seat42;
        private System.Windows.Forms.ComboBox Seat41;
        private System.Windows.Forms.ComboBox Seat40;
        private System.Windows.Forms.ComboBox Seat39;
        private System.Windows.Forms.ComboBox Seat38;
        private System.Windows.Forms.ComboBox Seat37;
        private System.Windows.Forms.ComboBox Seat36;
        private System.Windows.Forms.ComboBox Seat35;
        private System.Windows.Forms.ComboBox Seat34;
        private System.Windows.Forms.ComboBox Seat33;
        private System.Windows.Forms.ComboBox Seat32;
        private System.Windows.Forms.ComboBox Seat31;
        private System.Windows.Forms.ComboBox Seat30;
        private System.Windows.Forms.ComboBox Seat29;
        private System.Windows.Forms.ComboBox Seat28;
        private System.Windows.Forms.ComboBox Seat27;
        private System.Windows.Forms.CheckBox checkBox46;
        private System.Windows.Forms.CheckBox checkBox45;
        private System.Windows.Forms.CheckBox checkBox44;
        private System.Windows.Forms.CheckBox checkBox43;
        private System.Windows.Forms.CheckBox checkBox42;
        private System.Windows.Forms.CheckBox checkBox41;
        private System.Windows.Forms.CheckBox checkBox40;
        private System.Windows.Forms.CheckBox checkBox39;
        private System.Windows.Forms.CheckBox checkBox38;
        private System.Windows.Forms.CheckBox checkBox37;
        private System.Windows.Forms.CheckBox checkBox36;
        private System.Windows.Forms.CheckBox checkBox35;
        private System.Windows.Forms.CheckBox checkBox34;
        private System.Windows.Forms.CheckBox checkBox33;
        private System.Windows.Forms.CheckBox checkBox32;
        private System.Windows.Forms.CheckBox checkBox31;
        private System.Windows.Forms.CheckBox checkBox30;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.NumericUpDown Pos26;
        private System.Windows.Forms.NumericUpDown Stay26;
        private System.Windows.Forms.NumericUpDown Finish26;
        private System.Windows.Forms.NumericUpDown Start26;
        private System.Windows.Forms.ComboBox Motor26;
        private System.Windows.Forms.ComboBox Seat26;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.NumericUpDown Pos25;
        private System.Windows.Forms.NumericUpDown Stay25;
        private System.Windows.Forms.NumericUpDown Finish25;
        private System.Windows.Forms.NumericUpDown Start25;
        private System.Windows.Forms.ComboBox Motor25;
        private System.Windows.Forms.ComboBox Seat25;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton R3_HeatOFF;
        private System.Windows.Forms.RadioButton R3_Heat3;
        private System.Windows.Forms.RadioButton R3_Heat2;
        private System.Windows.Forms.RadioButton R3_Heat1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton R3_VentOFF;
        private System.Windows.Forms.RadioButton R3_Vent3;
        private System.Windows.Forms.RadioButton R3_Vent2;
        private System.Windows.Forms.RadioButton R3_Vent1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton L3_HeatOFF;
        private System.Windows.Forms.RadioButton L3_Heat3;
        private System.Windows.Forms.RadioButton L3_Heat2;
        private System.Windows.Forms.RadioButton L3_Heat1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton L3_VentOFF;
        private System.Windows.Forms.RadioButton L3_Vent3;
        private System.Windows.Forms.RadioButton L3_Vent2;
        private System.Windows.Forms.RadioButton L3_Vent1;
        private System.Windows.Forms.RadioButton R2_HeatOFF;
        private System.Windows.Forms.RadioButton R2_Heat3;
        private System.Windows.Forms.RadioButton R2_Heat2;
        private System.Windows.Forms.RadioButton R2_Heat1;
        private System.Windows.Forms.RadioButton R2_VentOFF;
        private System.Windows.Forms.RadioButton R2_Vent3;
        private System.Windows.Forms.RadioButton R2_Vent2;
        private System.Windows.Forms.RadioButton R2_Vent1;
        private System.Windows.Forms.RadioButton PA_VentOFF;
        private System.Windows.Forms.RadioButton PA_Vent3;
        private System.Windows.Forms.RadioButton PA_Vent2;
        private System.Windows.Forms.RadioButton PA_Vent1;
        private System.Windows.Forms.RadioButton PA_HeatOFF;
        private System.Windows.Forms.RadioButton PA_Heat3;
        private System.Windows.Forms.RadioButton PA_Heat2;
        private System.Windows.Forms.RadioButton PA_Heat1;
        private System.Windows.Forms.RadioButton DR_VentOFF;
        private System.Windows.Forms.RadioButton DR_Vent3;
        private System.Windows.Forms.RadioButton DR_Vent2;
        private System.Windows.Forms.RadioButton DR_Vent1;
        private System.Windows.Forms.RadioButton DR_HeatOFF;
        private System.Windows.Forms.RadioButton DR_Heat3;
        private System.Windows.Forms.RadioButton DR_Heat2;
        private System.Windows.Forms.RadioButton DR_Heat1;
        private System.Windows.Forms.ComboBox SecRwRtStMassStrsHMI2RReq;
        private System.Windows.Forms.ComboBox SecRwRtStMassMdHMI2RReq;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown Pos1;
        private System.Windows.Forms.TextBox DoublePos52;
        private System.Windows.Forms.TextBox DoublePos51;
        private System.Windows.Forms.TextBox DoublePos50;
        private System.Windows.Forms.TextBox DoublePos49;
        private System.Windows.Forms.TextBox DoublePos48;
        private System.Windows.Forms.TextBox DoublePos47;
        private System.Windows.Forms.TextBox DoublePos46;
        private System.Windows.Forms.TextBox DoublePos45;
        private System.Windows.Forms.TextBox DoublePos44;
        private System.Windows.Forms.TextBox DoublePos43;
        private System.Windows.Forms.TextBox DoublePos42;
        private System.Windows.Forms.TextBox DoublePos41;
        private System.Windows.Forms.TextBox DoublePos40;
        private System.Windows.Forms.TextBox DoublePos39;
        private System.Windows.Forms.TextBox DoublePos38;
        private System.Windows.Forms.TextBox DoublePos37;
        private System.Windows.Forms.TextBox DoublePos36;
        private System.Windows.Forms.TextBox DoublePos35;
        private System.Windows.Forms.TextBox DoublePos34;
        private System.Windows.Forms.TextBox DoublePos33;
        private System.Windows.Forms.TextBox DoublePos32;
        private System.Windows.Forms.TextBox DoublePos31;
        private System.Windows.Forms.TextBox DoublePos30;
        private System.Windows.Forms.TextBox DoublePos29;
        private System.Windows.Forms.TextBox DoublePos28;
        private System.Windows.Forms.TextBox DoublePos27;
        private System.Windows.Forms.TextBox DoublePos26;
        private System.Windows.Forms.TextBox DoublePos25;
        private System.Windows.Forms.TextBox DoublePos24;
        private System.Windows.Forms.TextBox DoublePos23;
        private System.Windows.Forms.TextBox DoublePos22;
        private System.Windows.Forms.TextBox DoublePos21;
        private System.Windows.Forms.TextBox DoublePos20;
        private System.Windows.Forms.TextBox DoublePos19;
        private System.Windows.Forms.TextBox DoublePos18;
        private System.Windows.Forms.TextBox DoublePos17;
        private System.Windows.Forms.TextBox DoublePos16;
        private System.Windows.Forms.TextBox DoublePos15;
        private System.Windows.Forms.TextBox DoublePos14;
        private System.Windows.Forms.TextBox DoublePos13;
        private System.Windows.Forms.TextBox DoublePos12;
        private System.Windows.Forms.TextBox DoublePos11;
        private System.Windows.Forms.TextBox DoublePos10;
        private System.Windows.Forms.TextBox DoublePos9;
        private System.Windows.Forms.TextBox DoublePos8;
        private System.Windows.Forms.TextBox DoublePos7;
        private System.Windows.Forms.TextBox DoublePos6;
        private System.Windows.Forms.TextBox DoublePos5;
        private System.Windows.Forms.TextBox DoublePos4;
        private System.Windows.Forms.TextBox DoublePos3;
        private System.Windows.Forms.TextBox DoublePos2;
        private System.Windows.Forms.TextBox DoublePos1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.CheckBox SPS_3R_ThdRwRtStBkReclnDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3R_ThdRwRtStBkReclnUpwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3R_ThdRwRtStBkwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3R_ThdRwRtStFrwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3R_ThdRRtStExpdSwActv;
        private System.Windows.Forms.CheckBox SPS_3R_AcsMdExtRtRclSwActv;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.CheckBox SPS_3L_ThdRwStBkReclnDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3L_ThdRwStBkReclnUpwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3L_ThdRStBkwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3L_ThdRStFrwdSwActv;
        private System.Windows.Forms.CheckBox SPS_3L_ThdRStExpdSwActv;
        private System.Windows.Forms.CheckBox SPS_3L_AcsMdExtRclSwActv;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox SecRwLtStVntDtyCycl;
        private System.Windows.Forms.CheckBox SecRwLtStHtDtyCycl;
        private System.Windows.Forms.CheckBox L_SecRwLtStArmScrnHMI2LReq;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStLgrstDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStLgrstUpwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStBkReclnDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStBkReclnUpwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStBkwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2L_SecRwStFrwdSwActv;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.CheckBox SecRwRtStVntDtyCycl;
        private System.Windows.Forms.CheckBox SecRwRtStHtDtyCycl;
        private System.Windows.Forms.CheckBox R_SecRwRtStArmScrnHMI2RReq;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStLgrstDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStLgrstUpwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStBkReclnDnwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStBkReclnUpwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStBkwdSwActv;
        private System.Windows.Forms.CheckBox SPS_2R_SecRwStFrwdSwActv;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox RtStFtDnwdHMI2LReq;
        private System.Windows.Forms.CheckBox RtStFtUpwdHMI2LReq;
        private System.Windows.Forms.CheckBox R_ReclineRrwdCustSeltn;
        private System.Windows.Forms.CheckBox R_ReclineFrwdCustSeltn;
        private System.Windows.Forms.CheckBox R_CushRrDwnCustSeltn;
        private System.Windows.Forms.CheckBox R_CushRrUpCustSeltn;
        private System.Windows.Forms.CheckBox R_CushFrtDwnCustSeltn;
        private System.Windows.Forms.CheckBox R_CushFrtUpCustSeltn;
        private System.Windows.Forms.CheckBox R_SeatRrwdCustSeltn;
        private System.Windows.Forms.CheckBox R_SeatFrwdCustSeltn;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox LtStFtDnwdHMI2LReq;
        private System.Windows.Forms.CheckBox LtStFtUpwdHMI2LReq;
        private System.Windows.Forms.CheckBox L_ReclineRrwdCustSeltn;
        private System.Windows.Forms.CheckBox L_ReclineFrwdCustSeltn;
        private System.Windows.Forms.CheckBox L_CushRrDwnCustSeltn;
        private System.Windows.Forms.CheckBox L_CushRrUpCustSeltn;
        private System.Windows.Forms.CheckBox L_CushFrtDwnCustSeltn;
        private System.Windows.Forms.CheckBox L_CushFrtUpCustSeltn;
        private System.Windows.Forms.CheckBox L_SeatRrwdCustSeltn;
        private System.Windows.Forms.CheckBox L_SeatFrwdCustSeltn;
        private System.Windows.Forms.Button Save;
    }
}

