// Copyright (C) 2009 PEAK-System Technik GmbH.  All rights reserved.

using Peak.Can.Basic;
using PLinView.Properties;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text;

namespace PLinView
{
    public partial class MainWnd : Form
    {

        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceCounter(ref long x);
        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceFrequency(ref long x);
        private const ulong FRAME_FILTER_MASK = 0xFFFFFFFFFFFFFFFF;
        private String m_sFileName;
        private Boolean m_fAutomatic;

        /*My definition for some const*/

        const byte SPS_DR_Req_MSG_Index = 0;
        const byte SPS_DR_Req_MSG_Cmd = 0xB1;//0x31

        const byte SPS_CODR_Req_MSG_Index = 1;
        const byte SPS_CODR_Req_MSG_Cmd = 0x97;//0x17

        const byte SPS_2L_Req_MSG_Index = 2;
        const byte SPS_2L_Req_MSG_Cmd = 0x61;//0x21

        const byte SPS_2R_Req_MSG_Index = 3;
        const byte SPS_2R_Req_MSG_Cmd = 0x11;//0x11

        const byte SPS_3L_Req_MSG_Index = 4;
        const byte SPS_3L_Req_MSG_Cmd = 0x55;//0x15

        const byte SPS_3R_Req_MSG_Index = 5;
        const byte SPS_3R_Req_MSG_Cmd = 0xE7;//0x27
        //0x33-35

        const UInt16 DR_Index = 0;
        const UInt16 CODR_Index = 1;
        const UInt16 SecRow_Index = 2;
        const UInt16 TriRow_Index = 3;
        const UInt16 DR_Recall_Index = 4;
        const UInt16 CODR_Recall_Index = 5;
        const UInt16 SR_Recall_Index = 6;
        const UInt16 TR_Recall_Index = 7;
        const UInt16 NetWork_Index = 8;
        const UInt16 FR_HV_Index = 9;
        const UInt16 SR_HV_Index = 10;
        const UInt16 TR_HV_Index = 11;
        const UInt16 SR_MAS_Index = 12;
        const UInt16 Mode1_Index = 13;


        TPCANMsg[] Msg_To_Send = new TPCANMsg[14];
        TPCANMsg TPCANMsg = new TPCANMsg();

        byte Sig429_DrvStHtCshnDtyCycl = 0;
        byte Sig429_DrvStHtBkDtyCycl = 0;
        byte Sig429_DrvStVntDtyCycl = 0;
        byte Sig429_PassStHtCshnDtyCycl = 0;
        byte Sig429_PassStHtBkDtyCycl = 0;
        byte Sig429_PassStVntDtyCycl = 0;

        byte Sig426_SecRwRtStHtCshnDtyCycl = 0;
        byte Sig426_SecRwRtStHtBkDtyCycl = 0;
        byte Sig426_SecRwRtStVntDtyCycl = 0;
        byte Sig426_SecRwLtStHtCshnDtyCycl = 0;
        byte Sig426_SecRwLtStHtBkDtyCycl = 0;
        byte Sig426_SecRwLtStVntDtyCycl = 0;

        byte Sig488_ThdRwRtStHtCshnDtyCycl = 0;
        byte Sig488_ThdRwRtStHtBkDtyCycl = 0;
        byte Sig488_ThdRwRtStVntDtyCycl = 0;
        byte Sig488_ThdRwLtStHtCshnDtyCycl = 0;
        byte Sig488_ThdRwLtStHtBkDtyCycl = 0;
        byte Sig488_ThdRwLtStVntDtyCycl = 0;

        byte Sig383_SecRwRtStMassMdHMI2RReq = 0;
        byte Sig383_SecRwRtStMassStrsHMI2RReq = 0;

        byte Sig_L_SeatFrwdCustSeltn = 0;
        byte Sig_L_SeatRrwdCustSeltn = 0;
        byte Sig_L_CushFrtUpCustSeltn = 0;
        byte Sig_L_CushFrtDwnCustSeltn = 0;
        byte Sig_L_MasgOnOffCustSeltn = 0;
        byte Sig_L_CushRrUpCustSeltn = 0;
        byte Sig_L_CushRrDwnCustSeltn = 0;
        byte Sig_L_StkSeatCustSeltnSts = 0;
        byte Sig_L_SeatCustSelnActSts = 0;
        byte Sig_L_ReclineFrwdCustSeltn = 0;
        byte Sig_L_ReclineRrwdCustSeltn = 0;
        byte Sig_L_LumbFrwdCustSeltn = 0;
        byte Sig_L_LumbRrwdCustSeltn = 0;
        byte Sig_L_LumbUpCustSeltn = 0;
        byte Sig_L_LumbDwnCustSeltn = 0;
        byte Sig_L_StSwAuxCtlFltPrsnt = 0;
        byte Sig_L_LtStFtUpwdHMI2LReq = 0;
        byte Sig_L_LtStFtDnwdHMI2LReq = 0;

        byte Sig_R_SeatFrwdCustSeltn = 0;
        byte Sig_R_SeatRrwdCustSeltn = 0;
        byte Sig_R_CushFrtUpCustSeltn = 0;
        byte Sig_R_CushFrtDwnCustSeltn = 0;
        byte Sig_R_MasgOnOffCustSeltn = 0;
        byte Sig_R_CushRrUpCustSeltn = 0;
        byte Sig_R_CushRrDwnCustSeltn = 0;
        byte Sig_R_StkSeatCustSeltnSts = 0;
        byte Sig_R_SeatCustSelnActSts = 0;
        byte Sig_R_ReclineFrwdCustSeltn = 0;
        byte Sig_R_ReclineRrwdCustSeltn = 0;
        byte Sig_R_LumbFrwdCustSeltn = 0;
        byte Sig_R_LumbRrwdCustSeltn = 0;
        byte Sig_R_LumbUpCustSeltn = 0;
        byte Sig_R_LumbDwnCustSeltn = 0;
        byte Sig_R_StSwAuxCtlFltPrsnt = 0;
        byte Sig_R_RtStFtUpwdHMI2LReq = 0;
        byte Sig_R_RtStFtDnwdHMI2LReq = 0;

        byte Sig_SPS_2L_SecRwStFrwdSwActv = 0;
        byte Sig_SPS_2L_SecRwStBkwdSwActv = 0;
        byte Sig_SPS_2L_SecRwStBkReclnUpwdSwActv = 0;
        byte Sig_SPS_2L_SecRwStBkReclnDnwdSwActv = 0;
        byte Sig_SPS_2L_SecRwStLgrstUpwdSwActv = 0;
        byte Sig_SPS_2L_SecRwStLgrstDnwdSwActv = 0;
        byte Sig_SPS_2L_SecRwStLmbrFrwdSwActv = 0;
        byte Sig_SPS_2L_SecRwStLmbrBkwdSwActv = 0;
        byte Sig_SPS_2L_SecRwStLmbrUpwdSwActv = 0;
        byte Sig_SPS_2L_SecRwStLmbrDnwdSwActv = 0;

        byte Sig_SPS_2R_SecRwStFrwdSwActv = 0;
        byte Sig_SPS_2R_SecRwStBkwdSwActv = 0;
        byte Sig_SPS_2R_SecRwStBkReclnUpwdSwActv = 0;
        byte Sig_SPS_2R_SecRwStBkReclnDnwdSwActv = 0;
        byte Sig_SPS_2R_SecRwStLgrstUpwdSwActv = 0;
        byte Sig_SPS_2R_SecRwStLgrstDnwdSwActv = 0;
        byte Sig_SPS_2R_SecRwStLmbrFrwdSwActv = 0;
        byte Sig_SPS_2R_SecRwStLmbrBkwdSwActv = 0;
        byte Sig_SPS_2R_SecRwStLmbrUpwdSwActv = 0;
        byte Sig_SPS_2R_SecRwStLmbrDnwdSwActv = 0;

        byte Sig_SPS_3L_AcsMdExtRclSwActv = 0;
        byte Sig_SPS_3L_ThdRStExpdSwActv = 0;
        byte Sig_SPS_3L_ThdRStFrwdSwActv = 0;
        byte Sig_SPS_3L_ThdRStBkwdSwActv = 0;
        byte Sig_SPS_3L_ThdRwStBkReclnUpwdSwActv = 0;
        byte Sig_SPS_3L_ThdRwStBkReclnDnwdSwActv = 0;

        byte Sig_SPS_3R_AcsMdExtRtRclSwActv = 0;
        byte Sig_SPS_3R_ThdRRtStExpdSwActv = 0;
        byte Sig_SPS_3R_ThdRwRtStFrwdSwActv = 0;
        byte Sig_SPS_3R_ThdRwRtStBkwdSwActv = 0;
        byte Sig_SPS_3R_ThdRwRtStBkReclnUpwdSwActv = 0;
        byte Sig_SPS_3R_ThdRwRtStBkReclnDnwdSwActv = 0;

        byte Sig_SecRwLtStArmScrnHMI2LReq = 0;
        byte Sig_SecRwRtStArmScrnHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStFtUpwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStFtDnwdHMI2RReq = 0;

        byte DR_HT = 0;
        byte DR_VT = 0;
        byte PA_HT = 0;
        byte PA_VT = 0;
        byte R2_HT = 0;
        byte R2_VT = 0;
        byte L3_HT = 0;
        byte L3_VT = 0;
        byte R3_HT = 0;
        byte R3_VT = 0;

        private struct SeatMotor
        {
            /// <summary>
            /// 11/29-bit message identifier
            /// </summary>
            public uint ID;
            public uint RID;
            /// <summary>
            /// Data of the message (DATA[0]..DATA[7])
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] DATA;
        }

        SeatMotor[,] seatMotors = new SeatMotor[6,12];

        bool start_flag = false;
        bool start_flag_can = false;
        bool start_can_Read = false;
        bool Start_tag = true;
        bool pause_flag = false;
        bool DR_Recall = false;
        bool CODR_Recall = false;
        bool SR_Recall = false;

        byte[] sw_data = new byte[8];
        byte[] hw_data = new byte[8];
        byte[] diag_data = new byte[4];
        byte[] er_data = new byte[8];


        TimeSpan ts1;
        
        DateTime startTime;

        Byte iii = 0;

        

        const bool NotReadData = true;

        TPCANMsg msg = new TPCANMsg();
        TPCANStatus Res;

        UInt32 Stay_counter = 0;
        int Step = 1;
        int[] list = new int[53] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] Origin_List = new int[53] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //Res = PCANBasic.Initialize(PCANBasic.PCAN_USBBUS1, TPCANBaudrate.PCAN_BAUD_500K);


        private CGlobalFrameTable m_pGFT; 

        private CXmtFrameList m_pXmtFrames;

        private CRcvFrameList m_pRcvFrames;

        /// <summary>
        /// Client handle
        /// </summary>
        private byte m_hClient;
        /// <summary>
        /// Hardware handle
        /// </summary>
        private ushort m_hHw;
        /// <summary>
        /// Hardware channel
        /// </summary>
        private ushort m_nHwChannel;
        /// <summary>
        /// LIN Hardware Modus (Master/Slave)
        /// </summary>
        private Peak.Lin.TLINHardwareMode m_HwMode;
        /// <summary>
        /// Client filter mask
        /// </summary>
        private ulong m_lMask;
        /// <summary>
        /// Baudrate Index of Hardware
        /// </summary>
        private ushort m_wBaudrate;
        /// <summary>
        /// Name of connected hardware
        /// </summary>
        private String m_sHardwareName;
        /// <summary>
        /// Last LIN error
        /// </summary>
        private Peak.Lin.TLINError m_LastLINErr;
        /// <summary>
        /// Last LIN hardware mode
        /// </summary>
        private Peak.Lin.TLINHardwareMode m_LINMode;
        /// <summary>
        /// Last LIN hardware state
        /// </summary>
        private Peak.Lin.TLINHardwareState m_LINState;
        /// <summary>
        /// Current count of overruns in the receive queue of the LIN hardware.
        /// </summary>
        private ushort m_wOverruns;

        private void Can_connect_Click(object sender, EventArgs e)
        {
            TPCANStatus Res;
            Res = PCANBasic.Initialize(PCANBasic.PCAN_USBBUS1, TPCANBaudrate.PCAN_BAUD_500K,TPCANType.PCAN_TYPE_ISA,0100,3);
            //Res = PCANLight.Init(HardwareType.USB_1CH, Baudrates.BAUD_250K, FramesType.INIT_TYPE_ST);
            if (Res == TPCANStatus.PCAN_ERROR_OK)
            {
                MessageBox.Show("CAN Init OK, Baudrates is 500K");
                
                
            }
            else
            {
                MessageBox.Show("CAN Init Err, Check cable~!!!");
            }
            
        }

        void delay_10ms()
        {
            long freq = 0;
            long start_Value = 0;
            long stop_Value = 0;
            long n = 0;
            QueryPerformanceFrequency(ref freq);
            long count = freq / 100;
            QueryPerformanceCounter(ref start_Value);
            while (n < count)
            {
                QueryPerformanceCounter(ref stop_Value);
                n = stop_Value - start_Value;
            }
        }

        private void appendData(string path, bool appendFlag, string content)
        {
            if (File.Exists(path))
            {
                StreamWriter sw = new StreamWriter(path, appendFlag);
                sw.WriteLine(content);
                sw.Close();
            }
        }

        void delay_50ms()
        {
            long freq = 0;
            long start_Value = 0;
            long stop_Value = 0;
            long n = 0;
            //a = int.Parse(textBox1.Text);
            QueryPerformanceFrequency(ref freq);
            long count = freq / 32000;
            QueryPerformanceCounter(ref start_Value);
            while (n < count)
            {
                QueryPerformanceCounter(ref stop_Value);
                n = stop_Value - start_Value;
            }
        }

        void timer_func()
        {
            while (start_flag == true)
            {
                if ((iii % 2 == 0))
                {
                    //MyTransimitFunction(E16Msg_Publisher[Pub_0_Index]);
                    
                    
                    if (iii > 100)
                    {
                        iii = 0;
                    }
                    
                }
                if ((iii % 3 == 0))
                {
                    //MyTransimitFunction(E16Msg_Subscriber[Sub_0_Index]);
                    /*if(Lin_receive_counter > 10)
                    {
                        Lin_Busoff.BackColor = Color.Red;
                    }
                    else
                    {
                        Lin_Busoff.BackColor = Color.Transparent;
                    }*/
                }
                delay_10ms();
                iii++;   
            }

        }


        UInt16 timer_counter = 0;
        void timer_func1()
        {
            while (start_flag_can == true)
            {
                delay_10ms();
                timer_counter++;
                if ((timer_counter % 10 == 0) && (pause_flag == false))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref TPCANMsg);
                }
                if ((timer_counter % 10 == 0))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[DR_Index]);
                }
                if ((timer_counter % 10 == 0))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[CODR_Index]);
                }
                if ((timer_counter % 10 == 0))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[SecRow_Index]);
                }
                if ((timer_counter % 10 == 0))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[TriRow_Index]);
                }
                if ((timer_counter % 10 == 0) && (DR_Recall == true))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[DR_Recall_Index]);
                }
                if ((timer_counter % 10 == 0) && (CODR_Recall == true))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[CODR_Recall_Index]);
                }
                if ((timer_counter % 10 == 0) && (SR_Recall == true))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[SR_Recall_Index]);
                }
                if (timer_counter % 10 == 0)
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[NetWork_Index]);
                }
                if (timer_counter % 10 == 0)
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[FR_HV_Index]);
                }
                if (timer_counter % 10 == 0)
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[SR_HV_Index]);
                }
                if (timer_counter % 10 == 0)
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[TR_HV_Index]);
                }
                if (timer_counter % 10 == 0)
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[SR_MAS_Index]);
                }
                if (timer_counter >=20)
                {
                    timer_counter = 0;
                }


                
                
            }

        }

        void timer_func_Read()
        {
            while(start_can_Read == true)
            {
                Res = PCANBasic.Read(PCANBasic.PCAN_USBBUS1, out msg);
                if (Res == TPCANStatus.PCAN_ERROR_OK)
                {
                    if (pause_flag == false)
                    {
                        if ((checkBox1.Checked == true) && (msg.ID == seatMotors[Seat1.SelectedIndex, Motor1.SelectedIndex].RID) && (list[Step] == 1))
                        {
                            
                            DoublePos1.Text = AnalysisSTR(msg, Seat1.SelectedIndex, Motor1.SelectedIndex);
                            Pos1.Value = Analysis(msg, Seat1.SelectedIndex, Motor1.SelectedIndex);
                            if ((Start1.Value != Pos1.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat1.SelectedIndex, (byte)Motor1.SelectedIndex, (uint)Start1.Value);
                            }
                            else if ((Finish1.Value != Pos1.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat1.SelectedIndex, (byte)Motor1.SelectedIndex, (uint)Finish1.Value);
                            }
                            if (Math.Abs(Start1.Value - Pos1.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish1.Value - Pos1.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay1.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;
                                    
                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox2.Checked == true) && (msg.ID == seatMotors[Seat2.SelectedIndex, Motor2.SelectedIndex].RID) && (list[Step] == 2))
                        {
                            
                            DoublePos2.Text = AnalysisSTR(msg, Seat2.SelectedIndex, Motor2.SelectedIndex);
                            Pos2.Value = Analysis(msg, Seat2.SelectedIndex, Motor2.SelectedIndex);
                            if ((Start2.Value != Pos2.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat2.SelectedIndex, (byte)Motor2.SelectedIndex, (uint)Start2.Value);
                            }
                            else if ((Finish2.Value != Pos2.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat2.SelectedIndex, (byte)Motor2.SelectedIndex, (uint)Finish2.Value);
                            }
                            if (Math.Abs(Start2.Value - Pos2.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish2.Value - Pos2.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay2.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox3.Checked == true) && (msg.ID == seatMotors[Seat3.SelectedIndex, Motor3.SelectedIndex].RID) && (list[Step] == 3))
                        {
                            DoublePos3.Text = AnalysisSTR(msg, Seat3.SelectedIndex, Motor3.SelectedIndex);
                            Pos3.Value = Analysis(msg, Seat3.SelectedIndex, Motor3.SelectedIndex);
                            if ((Start3.Value != Pos3.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat3.SelectedIndex, (byte)Motor3.SelectedIndex, (uint)Start3.Value);
                            }
                            else if ((Finish3.Value != Pos3.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat3.SelectedIndex, (byte)Motor3.SelectedIndex, (uint)Finish3.Value);
                            }
                            if (Math.Abs(Start3.Value - Pos3.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish3.Value - Pos3.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay3.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox4.Checked == true) && (msg.ID == seatMotors[Seat4.SelectedIndex, Motor4.SelectedIndex].RID) && (list[Step] == 4))
                        {
                            DoublePos4.Text = AnalysisSTR(msg, Seat4.SelectedIndex, Motor4.SelectedIndex);
                            Pos4.Value = Analysis(msg, Seat4.SelectedIndex, Motor4.SelectedIndex);
                            if ((Start4.Value != Pos4.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat4.SelectedIndex, (byte)Motor4.SelectedIndex, (uint)Start4.Value);
                            }
                            else if ((Finish4.Value != Pos4.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat4.SelectedIndex, (byte)Motor4.SelectedIndex, (uint)Finish4.Value);
                            }
                            if (Math.Abs(Start4.Value - Pos4.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish4.Value - Pos4.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay4.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox5.Checked == true) && (msg.ID == seatMotors[Seat5.SelectedIndex, Motor5.SelectedIndex].RID) && (list[Step] == 5))
                        {
                            DoublePos5.Text = AnalysisSTR(msg, Seat5.SelectedIndex, Motor5.SelectedIndex);
                            Pos5.Value = Analysis(msg, Seat5.SelectedIndex, Motor5.SelectedIndex);
                            if ((Start5.Value != Pos5.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat5.SelectedIndex, (byte)Motor5.SelectedIndex, (uint)Start5.Value);
                            }
                            else if ((Finish5.Value != Pos5.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat5.SelectedIndex, (byte)Motor5.SelectedIndex, (uint)Finish5.Value);
                            }
                            if (Math.Abs(Start5.Value - Pos5.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish5.Value - Pos5.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay5.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox6.Checked == true) && (msg.ID == seatMotors[Seat6.SelectedIndex, Motor6.SelectedIndex].RID) && (list[Step] == 6))
                        {
                            DoublePos6.Text = AnalysisSTR(msg, Seat6.SelectedIndex, Motor6.SelectedIndex);
                            Pos6.Value = Analysis(msg, Seat6.SelectedIndex, Motor6.SelectedIndex);
                            if ((Start6.Value != Pos6.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat6.SelectedIndex, (byte)Motor6.SelectedIndex, (uint)Start6.Value);
                            }
                            else if ((Finish6.Value != Pos6.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat6.SelectedIndex, (byte)Motor6.SelectedIndex, (uint)Finish6.Value);
                            }
                            if (Math.Abs(Start6.Value - Pos6.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish6.Value - Pos6.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay6.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox7.Checked == true) && (msg.ID == seatMotors[Seat7.SelectedIndex, Motor7.SelectedIndex].RID) && (list[Step] == 7))
                        {
                            DoublePos7.Text = AnalysisSTR(msg, Seat7.SelectedIndex, Motor7.SelectedIndex);
                            Pos7.Value = Analysis(msg, Seat7.SelectedIndex, Motor7.SelectedIndex);
                            if ((Start7.Value != Pos7.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat7.SelectedIndex, (byte)Motor7.SelectedIndex, (uint)Start7.Value);
                            }
                            else if ((Finish7.Value != Pos7.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat7.SelectedIndex, (byte)Motor7.SelectedIndex, (uint)Finish7.Value);
                            }
                            if (Math.Abs(Start7.Value - Pos7.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish7.Value - Pos7.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay7.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox8.Checked == true) && (msg.ID == seatMotors[Seat8.SelectedIndex, Motor8.SelectedIndex].RID) && (list[Step] == 8))
                        {
                            DoublePos8.Text = AnalysisSTR(msg, Seat8.SelectedIndex, Motor8.SelectedIndex);
                            Pos8.Value = Analysis(msg, Seat8.SelectedIndex, Motor8.SelectedIndex);
                            if ((Start8.Value != Pos8.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat8.SelectedIndex, (byte)Motor8.SelectedIndex, (uint)Start8.Value);
                            }
                            else if ((Finish8.Value != Pos8.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat8.SelectedIndex, (byte)Motor8.SelectedIndex, (uint)Finish8.Value);
                            }
                            if (Math.Abs(Start8.Value - Pos8.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish8.Value - Pos8.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay8.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox9.Checked == true) && (msg.ID == seatMotors[Seat9.SelectedIndex, Motor9.SelectedIndex].RID) && (list[Step] == 9))
                        {
                            DoublePos9.Text = AnalysisSTR(msg, Seat9.SelectedIndex, Motor9.SelectedIndex);
                            Pos9.Value = Analysis(msg, Seat9.SelectedIndex, Motor9.SelectedIndex);
                            if ((Start9.Value != Pos9.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat9.SelectedIndex, (byte)Motor9.SelectedIndex, (uint)Start9.Value);
                            }
                            else if ((Finish9.Value != Pos9.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat9.SelectedIndex, (byte)Motor9.SelectedIndex, (uint)Finish9.Value);
                            }
                            if (Math.Abs(Start9.Value - Pos9.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish9.Value - Pos9.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay9.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox10.Checked == true) && (msg.ID == seatMotors[Seat10.SelectedIndex, Motor10.SelectedIndex].RID) && (list[Step] == 10))
                        {
                            DoublePos10.Text = AnalysisSTR(msg, Seat10.SelectedIndex, Motor10.SelectedIndex);
                            Pos10.Value = Analysis(msg, Seat10.SelectedIndex, Motor10.SelectedIndex);
                            if ((Start10.Value != Pos10.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat10.SelectedIndex, (byte)Motor10.SelectedIndex, (uint)Start10.Value);
                            }
                            else if ((Finish10.Value != Pos10.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat10.SelectedIndex, (byte)Motor10.SelectedIndex, (uint)Finish10.Value);
                            }
                            if (Math.Abs(Start10.Value - Pos10.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish10.Value - Pos10.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay10.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox11.Checked == true) && (msg.ID == seatMotors[Seat11.SelectedIndex, Motor11.SelectedIndex].RID) && (list[Step] == 11))
                        {
                            DoublePos11.Text = AnalysisSTR(msg, Seat11.SelectedIndex, Motor11.SelectedIndex);
                            Pos11.Value = Analysis(msg, Seat11.SelectedIndex, Motor11.SelectedIndex);
                            if ((Start11.Value != Pos11.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat11.SelectedIndex, (byte)Motor11.SelectedIndex, (uint)Start11.Value);
                            }
                            else if ((Finish11.Value != Pos11.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat11.SelectedIndex, (byte)Motor11.SelectedIndex, (uint)Finish11.Value);
                            }
                            if (Math.Abs(Start11.Value - Pos11.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish11.Value - Pos11.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay11.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox12.Checked == true) && (msg.ID == seatMotors[Seat12.SelectedIndex, Motor12.SelectedIndex].RID) && (list[Step] == 12))
                        {
                            DoublePos12.Text = AnalysisSTR(msg, Seat12.SelectedIndex, Motor12.SelectedIndex);
                            Pos12.Value = Analysis(msg, Seat12.SelectedIndex, Motor12.SelectedIndex);
                            if ((Start12.Value != Pos12.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat12.SelectedIndex, (byte)Motor12.SelectedIndex, (uint)Start12.Value);
                            }
                            else if ((Finish12.Value != Pos12.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat12.SelectedIndex, (byte)Motor12.SelectedIndex, (uint)Finish12.Value);
                            }
                            if (Math.Abs(Start12.Value - Pos12.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish12.Value - Pos12.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay12.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox13.Checked == true) && (msg.ID == seatMotors[Seat13.SelectedIndex, Motor13.SelectedIndex].RID) && (list[Step] == 13))
                        {
                            DoublePos13.Text = AnalysisSTR(msg, Seat13.SelectedIndex, Motor13.SelectedIndex);
                            Pos13.Value = Analysis(msg, Seat13.SelectedIndex, Motor13.SelectedIndex);
                            if ((Start13.Value != Pos13.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat13.SelectedIndex, (byte)Motor13.SelectedIndex, (uint)Start13.Value);
                            }
                            else if ((Finish13.Value != Pos13.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat13.SelectedIndex, (byte)Motor13.SelectedIndex, (uint)Finish13.Value);
                            }
                            if (Math.Abs(Start13.Value - Pos13.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish13.Value - Pos13.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay13.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox14.Checked == true) && (msg.ID == seatMotors[Seat14.SelectedIndex, Motor14.SelectedIndex].RID) && (list[Step] == 14))
                        {
                            DoublePos14.Text = AnalysisSTR(msg, Seat14.SelectedIndex, Motor14.SelectedIndex);
                            Pos14.Value = Analysis(msg, Seat14.SelectedIndex, Motor14.SelectedIndex);
                            if ((Start14.Value != Pos14.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat14.SelectedIndex, (byte)Motor14.SelectedIndex, (uint)Start14.Value);
                            }
                            else if ((Finish14.Value != Pos14.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat14.SelectedIndex, (byte)Motor14.SelectedIndex, (uint)Finish14.Value);
                            }
                            if (Math.Abs(Start14.Value - Pos14.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish14.Value - Pos14.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay14.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox15.Checked == true) && (msg.ID == seatMotors[Seat15.SelectedIndex, Motor15.SelectedIndex].RID) && (list[Step] == 15))
                        {
                            DoublePos15.Text = AnalysisSTR(msg, Seat15.SelectedIndex, Motor15.SelectedIndex);
                            Pos15.Value = Analysis(msg, Seat15.SelectedIndex, Motor15.SelectedIndex);
                            if ((Start15.Value != Pos15.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat15.SelectedIndex, (byte)Motor15.SelectedIndex, (uint)Start15.Value);
                            }
                            else if ((Finish15.Value != Pos15.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat15.SelectedIndex, (byte)Motor15.SelectedIndex, (uint)Finish15.Value);
                            }
                            if (Math.Abs(Start15.Value - Pos15.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish15.Value - Pos15.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay15.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox16.Checked == true) && (msg.ID == seatMotors[Seat16.SelectedIndex, Motor16.SelectedIndex].RID) && (list[Step] == 16))
                        {
                            DoublePos16.Text = AnalysisSTR(msg, Seat16.SelectedIndex, Motor16.SelectedIndex);
                            Pos16.Value = Analysis(msg, Seat16.SelectedIndex, Motor16.SelectedIndex);
                            if ((Start16.Value != Pos16.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat16.SelectedIndex, (byte)Motor16.SelectedIndex, (uint)Start16.Value);
                            }
                            else if ((Finish16.Value != Pos16.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat16.SelectedIndex, (byte)Motor16.SelectedIndex, (uint)Finish16.Value);
                            }
                            if (Math.Abs(Start16.Value - Pos16.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish16.Value - Pos16.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay16.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox17.Checked == true) && (msg.ID == seatMotors[Seat17.SelectedIndex, Motor17.SelectedIndex].RID) && (list[Step] == 17))
                        {
                            DoublePos17.Text = AnalysisSTR(msg, Seat17.SelectedIndex, Motor17.SelectedIndex);
                            Pos17.Value = Analysis(msg, Seat17.SelectedIndex, Motor17.SelectedIndex);
                            if ((Start17.Value != Pos17.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat17.SelectedIndex, (byte)Motor17.SelectedIndex, (uint)Start17.Value);
                            }
                            else if ((Finish17.Value != Pos17.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat17.SelectedIndex, (byte)Motor17.SelectedIndex, (uint)Finish17.Value);
                            }
                            if (Math.Abs(Start17.Value - Pos17.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish17.Value - Pos17.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay17.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox18.Checked == true) && (msg.ID == seatMotors[Seat18.SelectedIndex, Motor18.SelectedIndex].RID) && (list[Step] == 18))
                        {
                            DoublePos18.Text = AnalysisSTR(msg, Seat18.SelectedIndex, Motor18.SelectedIndex);
                            Pos18.Value = Analysis(msg, Seat18.SelectedIndex, Motor18.SelectedIndex);
                            if ((Start18.Value != Pos18.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat18.SelectedIndex, (byte)Motor18.SelectedIndex, (uint)Start18.Value);
                            }
                            else if ((Finish18.Value != Pos18.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat18.SelectedIndex, (byte)Motor18.SelectedIndex, (uint)Finish18.Value);
                            }
                            if (Math.Abs(Start18.Value - Pos18.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish18.Value - Pos18.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();

                                if (Stay18.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox19.Checked == true) && (msg.ID == seatMotors[Seat19.SelectedIndex, Motor19.SelectedIndex].RID) && (list[Step] == 19))
                        {
                            DoublePos19.Text = AnalysisSTR(msg, Seat19.SelectedIndex, Motor19.SelectedIndex);
                            Pos19.Value = Analysis(msg, Seat19.SelectedIndex, Motor19.SelectedIndex);
                            if ((Start19.Value != Pos19.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat19.SelectedIndex, (byte)Motor19.SelectedIndex, (uint)Start19.Value);
                            }
                            else if ((Finish19.Value != Pos19.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat19.SelectedIndex, (byte)Motor19.SelectedIndex, (uint)Finish19.Value);
                            }
                            if (Math.Abs(Start19.Value - Pos19.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish19.Value - Pos19.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();

                                if (Stay19.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox20.Checked == true) && (msg.ID == seatMotors[Seat20.SelectedIndex, Motor20.SelectedIndex].RID) && (list[Step] == 20))
                        {
                            DoublePos20.Text = AnalysisSTR(msg, Seat20.SelectedIndex, Motor20.SelectedIndex);
                            Pos20.Value = Analysis(msg, Seat20.SelectedIndex, Motor20.SelectedIndex);
                            if ((Start20.Value != Pos20.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat20.SelectedIndex, (byte)Motor20.SelectedIndex, (uint)Start20.Value);
                            }
                            else if ((Finish20.Value != Pos20.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat20.SelectedIndex, (byte)Motor20.SelectedIndex, (uint)Finish20.Value);
                            }
                            if (Math.Abs(Start20.Value - Pos20.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish20.Value - Pos20.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();

                                if (Stay20.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox21.Checked == true) && (msg.ID == seatMotors[Seat21.SelectedIndex, Motor21.SelectedIndex].RID) && (list[Step] == 21))
                        {
                            DoublePos21.Text = AnalysisSTR(msg, Seat21.SelectedIndex, Motor21.SelectedIndex);
                            Pos21.Value = Analysis(msg, Seat21.SelectedIndex, Motor21.SelectedIndex);
                            if ((Start21.Value != Pos21.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat21.SelectedIndex, (byte)Motor21.SelectedIndex, (uint)Start21.Value);
                            }
                            else if ((Finish21.Value != Pos21.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat21.SelectedIndex, (byte)Motor21.SelectedIndex, (uint)Finish21.Value);
                            }
                            if (Math.Abs(Start21.Value - Pos21.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish21.Value - Pos21.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();

                                if (Stay21.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox22.Checked == true) && (msg.ID == seatMotors[Seat22.SelectedIndex, Motor22.SelectedIndex].RID) && (list[Step] == 22))
                        {
                            DoublePos22.Text = AnalysisSTR(msg, Seat22.SelectedIndex, Motor22.SelectedIndex);
                            Pos22.Value = Analysis(msg, Seat22.SelectedIndex, Motor22.SelectedIndex);
                            if ((Start22.Value != Pos22.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat22.SelectedIndex, (byte)Motor22.SelectedIndex, (uint)Start22.Value);
                            }
                            else if ((Finish22.Value != Pos22.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat22.SelectedIndex, (byte)Motor22.SelectedIndex, (uint)Finish22.Value);
                            }
                            if (Math.Abs(Start22.Value - Pos22.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish22.Value - Pos22.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();

                                if (Stay22.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox23.Checked == true) && (msg.ID == seatMotors[Seat23.SelectedIndex, Motor23.SelectedIndex].RID) && (list[Step] == 23))
                        {
                            DoublePos23.Text = AnalysisSTR(msg, Seat23.SelectedIndex, Motor23.SelectedIndex);
                            Pos23.Value = Analysis(msg, Seat23.SelectedIndex, Motor23.SelectedIndex);
                            if ((Start23.Value != Pos23.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat23.SelectedIndex, (byte)Motor23.SelectedIndex, (uint)Start23.Value);
                            }
                            else if ((Finish23.Value != Pos23.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat23.SelectedIndex, (byte)Motor23.SelectedIndex, (uint)Finish23.Value);
                            }
                            if (Math.Abs(Start23.Value - Pos23.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish23.Value - Pos23.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();

                                if (Stay23.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox24.Checked == true) && (msg.ID == seatMotors[Seat24.SelectedIndex, Motor24.SelectedIndex].RID) && (list[Step] == 24))
                        {
                            DoublePos24.Text = AnalysisSTR(msg, Seat24.SelectedIndex, Motor24.SelectedIndex);
                            Pos24.Value = Analysis(msg, Seat24.SelectedIndex, Motor24.SelectedIndex);
                            if ((Start24.Value != Pos24.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat24.SelectedIndex, (byte)Motor24.SelectedIndex, (uint)Start24.Value);
                            }
                            else if ((Finish24.Value != Pos24.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat24.SelectedIndex, (byte)Motor24.SelectedIndex, (uint)Finish24.Value);
                            }
                            if (Math.Abs(Start24.Value - Pos24.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish24.Value - Pos24.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();

                                if (Stay24.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox25.Checked == true) && (msg.ID == seatMotors[Seat25.SelectedIndex, Motor25.SelectedIndex].RID) && (list[Step] == 25))
                        {
                            DoublePos25.Text = AnalysisSTR(msg, Seat25.SelectedIndex, Motor25.SelectedIndex);
                            Pos25.Value = Analysis(msg, Seat25.SelectedIndex, Motor25.SelectedIndex);
                            if ((Start25.Value != Pos25.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat25.SelectedIndex, (byte)Motor25.SelectedIndex, (uint)Start25.Value);
                            }
                            else if ((Finish25.Value != Pos25.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat25.SelectedIndex, (byte)Motor25.SelectedIndex, (uint)Finish25.Value);
                            }
                            if (Math.Abs(Start25.Value - Pos25.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish25.Value - Pos25.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();

                                if (Stay25.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox26.Checked == true) && (msg.ID == seatMotors[Seat26.SelectedIndex, Motor26.SelectedIndex].RID) && (list[Step] == 26))
                        {
                            DoublePos26.Text = AnalysisSTR(msg, Seat26.SelectedIndex, Motor26.SelectedIndex);
                            Pos26.Value = Analysis(msg, Seat26.SelectedIndex, Motor26.SelectedIndex);
                            if ((Start26.Value != Pos26.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat26.SelectedIndex, (byte)Motor26.SelectedIndex, (uint)Start26.Value);
                            }
                            else if ((Finish26.Value != Pos26.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat26.SelectedIndex, (byte)Motor26.SelectedIndex, (uint)Finish26.Value);
                            }
                            if (Math.Abs(Start26.Value - Pos26.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish26.Value - Pos26.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();

                                if (Stay26.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox27.Checked == true) && (msg.ID == seatMotors[Seat27.SelectedIndex, Motor27.SelectedIndex].RID) && (list[Step] == 27))
                        {
                            DoublePos27.Text = AnalysisSTR(msg, Seat27.SelectedIndex, Motor27.SelectedIndex);
                            Pos27.Value = Analysis(msg, Seat27.SelectedIndex, Motor27.SelectedIndex);
                            if ((Start27.Value != Pos27.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat27.SelectedIndex, (byte)Motor27.SelectedIndex, (uint)Start27.Value);
                            }
                            else if ((Finish27.Value != Pos27.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat27.SelectedIndex, (byte)Motor27.SelectedIndex, (uint)Finish27.Value);
                            }
                            if (Math.Abs(Start27.Value - Pos27.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish27.Value - Pos27.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();

                                if (Stay27.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox28.Checked == true) && (msg.ID == seatMotors[Seat28.SelectedIndex, Motor28.SelectedIndex].RID) && (list[Step] == 28))
                        {
                            DoublePos28.Text = AnalysisSTR(msg, Seat28.SelectedIndex, Motor28.SelectedIndex);
                            Pos28.Value = Analysis(msg, Seat28.SelectedIndex, Motor28.SelectedIndex);
                            if ((Start28.Value != Pos28.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat28.SelectedIndex, (byte)Motor28.SelectedIndex, (uint)Start28.Value);
                            }
                            else if ((Finish28.Value != Pos28.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat28.SelectedIndex, (byte)Motor28.SelectedIndex, (uint)Finish28.Value);
                            }
                            if (Math.Abs(Start28.Value - Pos28.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish28.Value - Pos28.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();

                                if (Stay28.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox29.Checked == true) && (msg.ID == seatMotors[Seat29.SelectedIndex, Motor29.SelectedIndex].RID) && (list[Step] == 29))
                        {
                            DoublePos29.Text = AnalysisSTR(msg, Seat29.SelectedIndex, Motor29.SelectedIndex);
                            Pos29.Value = Analysis(msg, Seat29.SelectedIndex, Motor29.SelectedIndex);
                            if ((Start29.Value != Pos29.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat29.SelectedIndex, (byte)Motor29.SelectedIndex, (uint)Start29.Value);
                            }
                            else if ((Finish29.Value != Pos29.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat29.SelectedIndex, (byte)Motor29.SelectedIndex, (uint)Finish29.Value);
                            }
                            if (Math.Abs(Start29.Value - Pos29.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish29.Value - Pos29.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay29.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox30.Checked == true) && (msg.ID == seatMotors[Seat30.SelectedIndex, Motor30.SelectedIndex].RID) && (list[Step] == 30))
                        {
                            DoublePos30.Text = AnalysisSTR(msg, Seat30.SelectedIndex, Motor30.SelectedIndex);
                            Pos30.Value = Analysis(msg, Seat30.SelectedIndex, Motor30.SelectedIndex);
                            if ((Start30.Value != Pos30.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat30.SelectedIndex, (byte)Motor30.SelectedIndex, (uint)Start30.Value);
                            }
                            else if ((Finish30.Value != Pos30.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat30.SelectedIndex, (byte)Motor30.SelectedIndex, (uint)Finish30.Value);
                            }
                            if (Math.Abs(Start30.Value - Pos30.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish30.Value - Pos30.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay30.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox31.Checked == true) && (msg.ID == seatMotors[Seat31.SelectedIndex, Motor31.SelectedIndex].RID) && (list[Step] == 31))
                        {
                            DoublePos31.Text = AnalysisSTR(msg, Seat31.SelectedIndex, Motor31.SelectedIndex);
                            Pos31.Value = Analysis(msg, Seat31.SelectedIndex, Motor31.SelectedIndex);
                            if ((Start31.Value != Pos31.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat31.SelectedIndex, (byte)Motor31.SelectedIndex, (uint)Start31.Value);
                            }
                            else if ((Finish31.Value != Pos31.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat31.SelectedIndex, (byte)Motor31.SelectedIndex, (uint)Finish31.Value);
                            }
                            if (Math.Abs(Start31.Value - Pos31.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish31.Value - Pos31.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay31.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox32.Checked == true) && (msg.ID == seatMotors[Seat32.SelectedIndex, Motor32.SelectedIndex].RID) && (list[Step] == 32))
                        {
                            DoublePos32.Text = AnalysisSTR(msg, Seat32.SelectedIndex, Motor32.SelectedIndex);
                            Pos32.Value = Analysis(msg, Seat32.SelectedIndex, Motor32.SelectedIndex);
                            if ((Start32.Value != Pos32.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat32.SelectedIndex, (byte)Motor32.SelectedIndex, (uint)Start32.Value);
                            }
                            else if ((Finish32.Value != Pos32.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat32.SelectedIndex, (byte)Motor32.SelectedIndex, (uint)Finish32.Value);
                            }
                            if (Math.Abs(Start32.Value - Pos32.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish32.Value - Pos32.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay32.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox33.Checked == true) && (msg.ID == seatMotors[Seat33.SelectedIndex, Motor33.SelectedIndex].RID) && (list[Step] == 33))
                        {
                            DoublePos33.Text = AnalysisSTR(msg, Seat33.SelectedIndex, Motor33.SelectedIndex);
                            Pos33.Value = Analysis(msg, Seat33.SelectedIndex, Motor33.SelectedIndex);
                            if ((Start33.Value != Pos33.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat33.SelectedIndex, (byte)Motor33.SelectedIndex, (uint)Start33.Value);
                            }
                            else if ((Finish33.Value != Pos33.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat33.SelectedIndex, (byte)Motor33.SelectedIndex, (uint)Finish33.Value);
                            }
                            if (Math.Abs(Start33.Value - Pos33.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish33.Value - Pos33.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay33.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox34.Checked == true) && (msg.ID == seatMotors[Seat34.SelectedIndex, Motor34.SelectedIndex].RID) && (list[Step] == 34))
                        {
                            DoublePos34.Text = AnalysisSTR(msg, Seat34.SelectedIndex, Motor34.SelectedIndex);
                            Pos34.Value = Analysis(msg, Seat34.SelectedIndex, Motor34.SelectedIndex);
                            if ((Start34.Value != Pos34.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat34.SelectedIndex, (byte)Motor34.SelectedIndex, (uint)Start34.Value);
                            }
                            else if ((Finish34.Value != Pos34.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat34.SelectedIndex, (byte)Motor34.SelectedIndex, (uint)Finish34.Value);
                            }
                            if (Math.Abs(Start34.Value - Pos34.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish34.Value - Pos34.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay34.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox35.Checked == true) && (msg.ID == seatMotors[Seat35.SelectedIndex, Motor35.SelectedIndex].RID) && (list[Step] == 35))
                        {
                            DoublePos35.Text = AnalysisSTR(msg, Seat35.SelectedIndex, Motor35.SelectedIndex);
                            Pos35.Value = Analysis(msg, Seat35.SelectedIndex, Motor35.SelectedIndex);
                            if ((Start35.Value != Pos35.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat35.SelectedIndex, (byte)Motor35.SelectedIndex, (uint)Start35.Value);
                            }
                            else if ((Finish35.Value != Pos35.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat35.SelectedIndex, (byte)Motor35.SelectedIndex, (uint)Finish35.Value);
                            }
                            if (Math.Abs(Start35.Value - Pos35.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish35.Value - Pos35.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay35.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox36.Checked == true) && (msg.ID == seatMotors[Seat36.SelectedIndex, Motor36.SelectedIndex].RID) && (list[Step] == 36))
                        {
                            DoublePos36.Text = AnalysisSTR(msg, Seat36.SelectedIndex, Motor36.SelectedIndex);
                            Pos36.Value = Analysis(msg, Seat36.SelectedIndex, Motor36.SelectedIndex);
                            if ((Start36.Value != Pos36.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat36.SelectedIndex, (byte)Motor36.SelectedIndex, (uint)Start36.Value);
                            }
                            else if ((Finish36.Value != Pos36.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat36.SelectedIndex, (byte)Motor36.SelectedIndex, (uint)Finish36.Value);
                            }
                            if (Math.Abs(Start36.Value - Pos36.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish36.Value - Pos36.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay36.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox37.Checked == true) && (msg.ID == seatMotors[Seat37.SelectedIndex, Motor37.SelectedIndex].RID) && (list[Step] == 37))
                        {
                            DoublePos37.Text = AnalysisSTR(msg, Seat37.SelectedIndex, Motor37.SelectedIndex);
                            Pos37.Value = Analysis(msg, Seat37.SelectedIndex, Motor37.SelectedIndex);
                            if ((Start37.Value != Pos37.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat37.SelectedIndex, (byte)Motor37.SelectedIndex, (uint)Start37.Value);
                            }
                            else if ((Finish37.Value != Pos37.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat37.SelectedIndex, (byte)Motor37.SelectedIndex, (uint)Finish37.Value);
                            }
                            if (Math.Abs(Start37.Value - Pos37.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish37.Value - Pos37.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay37.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox38.Checked == true) && (msg.ID == seatMotors[Seat38.SelectedIndex, Motor38.SelectedIndex].RID) && (list[Step] == 38))
                        {
                            DoublePos38.Text = AnalysisSTR(msg, Seat38.SelectedIndex, Motor38.SelectedIndex);
                            Pos38.Value = Analysis(msg, Seat38.SelectedIndex, Motor38.SelectedIndex);
                            if ((Start38.Value != Pos38.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat38.SelectedIndex, (byte)Motor38.SelectedIndex, (uint)Start38.Value);
                            }
                            else if ((Finish38.Value != Pos38.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat38.SelectedIndex, (byte)Motor38.SelectedIndex, (uint)Finish38.Value);
                            }
                            if (Math.Abs(Start38.Value - Pos38.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish38.Value - Pos38.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay38.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox39.Checked == true) && (msg.ID == seatMotors[Seat39.SelectedIndex, Motor39.SelectedIndex].RID) && (list[Step] == 39))
                        {
                            DoublePos39.Text = AnalysisSTR(msg, Seat39.SelectedIndex, Motor39.SelectedIndex);
                            Pos39.Value = Analysis(msg, Seat39.SelectedIndex, Motor39.SelectedIndex);
                            if ((Start39.Value != Pos39.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat39.SelectedIndex, (byte)Motor39.SelectedIndex, (uint)Start39.Value);
                            }
                            else if ((Finish39.Value != Pos39.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat39.SelectedIndex, (byte)Motor39.SelectedIndex, (uint)Finish39.Value);
                            }
                            if (Math.Abs(Start39.Value - Pos39.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish39.Value - Pos39.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay39.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox40.Checked == true) && (msg.ID == seatMotors[Seat40.SelectedIndex, Motor40.SelectedIndex].RID) && (list[Step] == 40))
                        {
                            DoublePos40.Text = AnalysisSTR(msg, Seat40.SelectedIndex, Motor40.SelectedIndex);
                            Pos40.Value = Analysis(msg, Seat40.SelectedIndex, Motor40.SelectedIndex);
                            if ((Start40.Value != Pos40.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat40.SelectedIndex, (byte)Motor40.SelectedIndex, (uint)Start40.Value);
                            }
                            else if ((Finish40.Value != Pos40.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat40.SelectedIndex, (byte)Motor40.SelectedIndex, (uint)Finish40.Value);
                            }
                            if (Math.Abs(Start40.Value - Pos40.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish40.Value - Pos40.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay40.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox41.Checked == true) && (msg.ID == seatMotors[Seat41.SelectedIndex, Motor41.SelectedIndex].RID) && (list[Step] == 41))
                        {
                            DoublePos41.Text = AnalysisSTR(msg, Seat41.SelectedIndex, Motor41.SelectedIndex);
                            Pos41.Value = Analysis(msg, Seat41.SelectedIndex, Motor41.SelectedIndex);
                            if ((Start41.Value != Pos41.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat41.SelectedIndex, (byte)Motor41.SelectedIndex, (uint)Start41.Value);
                            }
                            else if ((Finish41.Value != Pos41.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat41.SelectedIndex, (byte)Motor41.SelectedIndex, (uint)Finish41.Value);
                            }
                            if (Math.Abs(Start41.Value - Pos41.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish41.Value - Pos41.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay41.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox42.Checked == true) && (msg.ID == seatMotors[Seat42.SelectedIndex, Motor42.SelectedIndex].RID) && (list[Step] == 42))
                        {
                            DoublePos42.Text = AnalysisSTR(msg, Seat42.SelectedIndex, Motor42.SelectedIndex);
                            Pos42.Value = Analysis(msg, Seat42.SelectedIndex, Motor42.SelectedIndex);
                            if ((Start42.Value != Pos42.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat42.SelectedIndex, (byte)Motor42.SelectedIndex, (uint)Start42.Value);
                            }
                            else if ((Finish42.Value != Pos42.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat42.SelectedIndex, (byte)Motor42.SelectedIndex, (uint)Finish42.Value);
                            }
                            if (Math.Abs(Start42.Value - Pos42.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish42.Value - Pos42.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay42.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox43.Checked == true) && (msg.ID == seatMotors[Seat43.SelectedIndex, Motor43.SelectedIndex].RID) && (list[Step] == 43))
                        {
                            DoublePos43.Text = AnalysisSTR(msg, Seat43.SelectedIndex, Motor43.SelectedIndex);
                            Pos43.Value = Analysis(msg, Seat43.SelectedIndex, Motor43.SelectedIndex);
                            if ((Start43.Value != Pos43.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat43.SelectedIndex, (byte)Motor43.SelectedIndex, (uint)Start43.Value);
                            }
                            else if ((Finish43.Value != Pos43.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat43.SelectedIndex, (byte)Motor43.SelectedIndex, (uint)Finish43.Value);
                            }
                            if (Math.Abs(Start43.Value - Pos43.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish43.Value - Pos43.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay43.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox44.Checked == true) && (msg.ID == seatMotors[Seat44.SelectedIndex, Motor44.SelectedIndex].RID) && (list[Step] == 44))
                        {
                            DoublePos44.Text = AnalysisSTR(msg, Seat44.SelectedIndex, Motor44.SelectedIndex);
                            Pos44.Value = Analysis(msg, Seat44.SelectedIndex, Motor44.SelectedIndex);
                            if ((Start44.Value != Pos44.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat44.SelectedIndex, (byte)Motor44.SelectedIndex, (uint)Start44.Value);
                            }
                            else if ((Finish44.Value != Pos44.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat44.SelectedIndex, (byte)Motor44.SelectedIndex, (uint)Finish44.Value);
                            }
                            if (Math.Abs(Start44.Value - Pos44.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish44.Value - Pos44.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay44.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox45.Checked == true) && (msg.ID == seatMotors[Seat45.SelectedIndex, Motor45.SelectedIndex].RID) && (list[Step] == 45))
                        {
                            DoublePos45.Text = AnalysisSTR(msg, Seat45.SelectedIndex, Motor45.SelectedIndex);
                            Pos45.Value = Analysis(msg, Seat45.SelectedIndex, Motor45.SelectedIndex);
                            if ((Start45.Value != Pos45.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat45.SelectedIndex, (byte)Motor45.SelectedIndex, (uint)Start45.Value);
                            }
                            else if ((Finish45.Value != Pos45.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat45.SelectedIndex, (byte)Motor45.SelectedIndex, (uint)Finish45.Value);
                            }
                            if (Math.Abs(Start45.Value - Pos45.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish45.Value - Pos45.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay45.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox46.Checked == true) && (msg.ID == seatMotors[Seat46.SelectedIndex, Motor46.SelectedIndex].RID) && (list[Step] == 46))
                        {
                            DoublePos46.Text = AnalysisSTR(msg, Seat46.SelectedIndex, Motor46.SelectedIndex);
                            Pos46.Value = Analysis(msg, Seat46.SelectedIndex, Motor46.SelectedIndex);
                            if ((Start46.Value != Pos46.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat46.SelectedIndex, (byte)Motor46.SelectedIndex, (uint)Start46.Value);
                            }
                            else if ((Finish46.Value != Pos46.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat46.SelectedIndex, (byte)Motor46.SelectedIndex, (uint)Finish46.Value);
                            }
                            if (Math.Abs(Start46.Value - Pos46.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish46.Value - Pos46.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay46.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox47.Checked == true) && (msg.ID == seatMotors[Seat47.SelectedIndex, Motor47.SelectedIndex].RID) && (list[Step] == 47))
                        {
                            DoublePos47.Text = AnalysisSTR(msg, Seat47.SelectedIndex, Motor47.SelectedIndex);
                            Pos47.Value = Analysis(msg, Seat47.SelectedIndex, Motor47.SelectedIndex);
                            if ((Start47.Value != Pos47.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat47.SelectedIndex, (byte)Motor47.SelectedIndex, (uint)Start47.Value);
                            }
                            else if ((Finish47.Value != Pos47.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat47.SelectedIndex, (byte)Motor47.SelectedIndex, (uint)Finish47.Value);
                            }
                            if (Math.Abs(Start47.Value - Pos47.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish47.Value - Pos47.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay47.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox48.Checked == true) && (msg.ID == seatMotors[Seat48.SelectedIndex, Motor48.SelectedIndex].RID) && (list[Step] == 48))
                        {
                            DoublePos48.Text = AnalysisSTR(msg, Seat48.SelectedIndex, Motor48.SelectedIndex);
                            Pos48.Value = Analysis(msg, Seat48.SelectedIndex, Motor48.SelectedIndex);
                            if ((Start48.Value != Pos48.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat48.SelectedIndex, (byte)Motor48.SelectedIndex, (uint)Start48.Value);
                            }
                            else if ((Finish48.Value != Pos48.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat48.SelectedIndex, (byte)Motor48.SelectedIndex, (uint)Finish48.Value);
                            }
                            if (Math.Abs(Start48.Value - Pos48.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish48.Value - Pos48.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay48.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox49.Checked == true) && (msg.ID == seatMotors[Seat49.SelectedIndex, Motor49.SelectedIndex].RID) && (list[Step] == 49))
                        {
                            DoublePos49.Text = AnalysisSTR(msg, Seat49.SelectedIndex, Motor49.SelectedIndex);
                            Pos49.Value = Analysis(msg, Seat49.SelectedIndex, Motor49.SelectedIndex);
                            if ((Start49.Value != Pos49.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat49.SelectedIndex, (byte)Motor49.SelectedIndex, (uint)Start49.Value);
                            }
                            else if ((Finish49.Value != Pos49.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat49.SelectedIndex, (byte)Motor49.SelectedIndex, (uint)Finish49.Value);
                            }
                            if (Math.Abs(Start49.Value - Pos49.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish49.Value - Pos49.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay49.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox50.Checked == true) && (msg.ID == seatMotors[Seat50.SelectedIndex, Motor50.SelectedIndex].RID) && (list[Step] == 50))
                        {
                            DoublePos50.Text = AnalysisSTR(msg, Seat50.SelectedIndex, Motor50.SelectedIndex);
                            Pos50.Value = Analysis(msg, Seat50.SelectedIndex, Motor50.SelectedIndex);
                            if ((Start50.Value != Pos50.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat50.SelectedIndex, (byte)Motor50.SelectedIndex, (uint)Start50.Value);
                            }
                            else if ((Finish50.Value != Pos50.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat50.SelectedIndex, (byte)Motor50.SelectedIndex, (uint)Finish50.Value);
                            }
                            if (Math.Abs(Start50.Value - Pos50.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish50.Value - Pos50.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay50.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox51.Checked == true) && (msg.ID == seatMotors[Seat51.SelectedIndex, Motor51.SelectedIndex].RID) && (list[Step] == 51))
                        {
                            DoublePos51.Text = AnalysisSTR(msg, Seat51.SelectedIndex, Motor51.SelectedIndex);
                            Pos51.Value = Analysis(msg, Seat51.SelectedIndex, Motor51.SelectedIndex);
                            if ((Start51.Value != Pos51.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat51.SelectedIndex, (byte)Motor51.SelectedIndex, (uint)Start51.Value);
                            }
                            else if ((Finish51.Value != Pos51.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat51.SelectedIndex, (byte)Motor51.SelectedIndex, (uint)Finish51.Value);
                            }
                            if (Math.Abs(Start51.Value - Pos51.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish51.Value - Pos51.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay51.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }
                        if ((checkBox52.Checked == true) && (msg.ID == seatMotors[Seat52.SelectedIndex, Motor52.SelectedIndex].RID) && (list[Step] == 52))
                        {
                            DoublePos52.Text = AnalysisSTR(msg, Seat52.SelectedIndex, Motor52.SelectedIndex);
                            Pos52.Value = Analysis(msg, Seat52.SelectedIndex, Motor52.SelectedIndex);
                            if ((Start52.Value != Pos52.Value) && (Start_tag == true))
                            {
                                Fill_CommandService();
                                SetData((byte)Seat52.SelectedIndex, (byte)Motor52.SelectedIndex, (uint)Start52.Value);
                            }
                            else if ((Finish52.Value != Pos52.Value) && (Start_tag == false))
                            {
                                SetData((byte)Seat52.SelectedIndex, (byte)Motor52.SelectedIndex, (uint)Finish52.Value);
                            }
                            if (Math.Abs(Start52.Value - Pos52.Value) <= 2)
                            {
                                Start_tag = false;
                            }
                            if ((Math.Abs(Finish52.Value - Pos52.Value) <= 2) && (Start_tag == false))
                            {
                                SetRecall();
                                Empty_CommandService();
                                if (Stay52.Value * 1 <= Stay_counter)
                                {
                                    list[Step] = 0;
                                    Stay_counter = 0;
                                    Step++;
                                    Start_tag = true;

                                }
                                Stay_counter++;
                                delay_10ms();
                            }
                        }

                    }

                    if ((list[Step] == 0)&&(start_flag_can == true))
                    {
                        Step++;
                    }
                    if (Step >= 53)
                    {
                        Array.Copy(Origin_List, list, Origin_List.Length);
                        Step = 1;
                        FinishCount.Value++;
                        Start_tag = true;
                    }
                    if (FinishCount.Value == CycleTimes.Value)
                    {
                        start_can_Read = false;
                        button1.Text = "开始";
                        Step = 0;
                    }
                }
            }
            
        }

        private decimal Analysis(TPCANMsg tpCANMsg,int seat,int motor)
        {
            decimal Positiontext = 0;
            switch (seat)
            {
                case 0:
                    if(motor == 2)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[4] & 0xFF) << 4) | (tpCANMsg.DATA[5] & 0xF0) >> 4) * 0.025);
                    }
                    if(motor == 0)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x0F) << 8) | (tpCANMsg.DATA[6])) * 0.025);
                    }
                    if(motor == 3)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[4] & 0x0F) << 8) | (tpCANMsg.DATA[5])) * 0.025);
                    }
                    if (motor == 5)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x0F) << 8) | (tpCANMsg.DATA[2])) * 0.025);
                    }
                    if (motor == 6)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble((tpCANMsg.DATA[4] << 4) | (tpCANMsg.DATA[5] & 0xF0) >> 4) * 0.025);
                    }
                    if (motor == 7)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x0F) << 8) | (tpCANMsg.DATA[6])) * 0.025);
                    }
                    break;
                case 1:
                    if (motor == 2)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[0] & 0xFF) << 4) | ((tpCANMsg.DATA[1] & 0xF0) >> 4)) * 0.025);
                    }
                    if (motor == 0)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 5)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x3F) << 6) | ((tpCANMsg.DATA[6] & 0xFC) >> 2)) * 0.025);
                    }
                    if (motor == 6)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble((((tpCANMsg.DATA[0] & 0xFF) << 4) | (tpCANMsg.DATA[1] & 0xF0) >> 4)) * 0.025);
                    }
                    if (motor == 7)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 3)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x3F) << 6) | ((tpCANMsg.DATA[6] & 0xFC) >> 2)) * 0.025);
                    }
                    break;
                case 3:
                    if (motor == 2)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[0] & 0xFF) << 4) | (tpCANMsg.DATA[1] & 0xF0) >> 4) * 0.025);
                    }
                    if (motor == 0)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 4)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x3F) << 6) | ((tpCANMsg.DATA[6] & 0xFC) >> 2)) * 0.025);
                    }
                    if (motor == 6)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble((((tpCANMsg.DATA[0] & 0xFF) << 4) | (tpCANMsg.DATA[1] & 0xF0) >> 4)) * 0.025);
                    }
                    if (motor == 7)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 3)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x3F) << 6) | ((tpCANMsg.DATA[6] & 0xFC) >> 2)) * 0.025);
                    }
                    break;
                case 4:
                    if (motor == 2)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble((((tpCANMsg.DATA[0] & 0xFF) << 4) | (tpCANMsg.DATA[1] & 0xF0) >> 4)) * 0.025);
                    }
                    if (motor == 0)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 1)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[3] & 0x0F) << 8) | (tpCANMsg.DATA[4])) * 0.025);
                    }
                    break;
                case 5:
                    if (motor == 2)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble((((tpCANMsg.DATA[0] & 0xFF) << 4) | (tpCANMsg.DATA[1] & 0xF0) >> 4)) * 0.025);
                    }
                    if (motor == 0)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 1)
                    {
                        Positiontext = Convert.ToDecimal(Convert.ToDouble(((tpCANMsg.DATA[3] & 0x0F) << 8) | (tpCANMsg.DATA[4])) * 0.025);
                    }
                    break;
            }
            return Positiontext;
        }

        private string AnalysisSTR(TPCANMsg tpCANMsg, int seat, int motor)
        {
            string Positiontext = "0";
            switch (seat)
            {
                case 0:
                    if (motor == 2)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[4] & 0xFF) << 4) | (tpCANMsg.DATA[5] & 0xF0) >> 4) * 0.025);
                    }
                    if (motor == 0)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x0F) << 8) | (tpCANMsg.DATA[6])) * 0.025);
                    }
                    if (motor == 3)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[4] & 0x0F) << 8) | (tpCANMsg.DATA[5])) * 0.025);
                    }
                    if (motor == 5)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x0F) << 8) | (tpCANMsg.DATA[2])) * 0.025);
                    }
                    if (motor == 6)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble((tpCANMsg.DATA[4] << 4) | (tpCANMsg.DATA[5] & 0xF0) >> 4) * 0.025);
                    }
                    if (motor == 7)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x0F) << 8) | (tpCANMsg.DATA[6])) * 0.025);
                    }
                    break;
                case 1:
                    if (motor == 2)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[0] & 0xFF) << 4) | ((tpCANMsg.DATA[1] & 0xF0) >> 4)) * 0.025);
                    }
                    if (motor == 0)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 5)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x3F) << 6) | ((tpCANMsg.DATA[6] & 0xFC) >> 2)) * 0.025);
                    }
                    if (motor == 6)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble((((tpCANMsg.DATA[0] & 0xFF) << 4) | (tpCANMsg.DATA[1] & 0xF0) >> 4)) * 0.025);
                    }
                    if (motor == 7)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 3)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x3F) << 6) | ((tpCANMsg.DATA[6] & 0xFC) >> 2)) * 0.025);
                    }
                    break;
                case 3:
                    if (motor == 2)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[0] & 0xFF) << 4) | (tpCANMsg.DATA[1] & 0x0F)) * 0.025);
                    }
                    if (motor == 0)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 4)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x3F) << 6) | ((tpCANMsg.DATA[6] & 0xFC) >> 2)) * 0.025);
                    }
                    if (motor == 6)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble((((tpCANMsg.DATA[0] & 0xFF) << 4) | (tpCANMsg.DATA[1] & 0xF0) >> 4)) * 0.025);
                    }
                    if (motor == 7)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 3)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[5] & 0x3F) << 6) | ((tpCANMsg.DATA[6] & 0xFC) >> 2)) * 0.025);
                    }
                    break;
                case 4:
                    if (motor == 2)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble((((tpCANMsg.DATA[0] & 0xFF) << 4) | (tpCANMsg.DATA[1] & 0xF0) >> 4)) * 0.025);
                    }
                    if (motor == 0)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 1)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[3] & 0x0F) << 8) | (tpCANMsg.DATA[4])) * 0.025);
                    }
                    break;
                case 5:
                    if (motor == 2)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble((((tpCANMsg.DATA[0] & 0xFF) << 4) | (tpCANMsg.DATA[1] & 0xF0) >> 4)) * 0.025);
                    }
                    if (motor == 0)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[1] & 0x03) << 10) | (tpCANMsg.DATA[2] << 2) | ((tpCANMsg.DATA[3] & 0xC0) >> 6)) * 0.025);
                    }
                    if (motor == 1)
                    {
                        Positiontext = Convert.ToString(Convert.ToDouble(((tpCANMsg.DATA[3] & 0x0F) << 8) | (tpCANMsg.DATA[4])) * 0.025);
                    }
                    break;
            }
            return Positiontext;
        }

        /*************/
        public Peak.Lin.TLINMsg[] Publisher = new Peak.Lin.TLINMsg[8];
        public Peak.Lin.TLINMsg[] Subscriber = new Peak.Lin.TLINMsg[10];
        public Peak.Lin.TLINFrameEntry[] tLINFrameEntry = new Peak.Lin.TLINFrameEntry[6];

        /// <summary>
        /// Constructor of the MainWnd object to create the main window
        /// </summary>
        public MainWnd()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            m_sFileName = "";
            m_fAutomatic = false;
            // Create the Global Frame Table
            m_pGFT = new CGlobalFrameTable(this);            
            // Create the Transmit List
            m_pXmtFrames = new CXmtFrameList(m_pGFT);
            // Create the Receive List
            m_pRcvFrames = new CRcvFrameList(this, m_pGFT);
            m_pRcvFrames.OnReceived += new FrameReceivedEventHandler(FrameReceived);
            // Initialize the LIN attributes
            m_hClient = 0;
            m_hHw = 1;
            m_nHwChannel = 0;
            m_lMask = 0xFFFFFFFFFFFFFFFF;
            m_HwMode = Peak.Lin.TLINHardwareMode.modMaster;
            m_wBaudrate = 19200;
            m_sHardwareName = "";
            m_LINMode = Peak.Lin.TLINHardwareMode.modNone;
            m_LINState = Peak.Lin.TLINHardwareState.hwsNotInitialized;
            m_wOverruns = 0;

            // Register this application with LIN as client.
            m_LastLINErr = Peak.Lin.PLinApi.RegisterClient(Resources.SPLinClientName, Handle, out m_hClient);

            tLINFrameEntry[SPS_DR_Req_MSG_Index].FrameId = 0x31;
            tLINFrameEntry[SPS_DR_Req_MSG_Index].Length = 0x04;
            tLINFrameEntry[SPS_DR_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_DR_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_DR_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            tLINFrameEntry[SPS_CODR_Req_MSG_Index].FrameId = 0x17;
            tLINFrameEntry[SPS_CODR_Req_MSG_Index].Length = 0x04;
            tLINFrameEntry[SPS_CODR_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_CODR_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_CODR_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            tLINFrameEntry[SPS_2L_Req_MSG_Index].FrameId = 0x21;
            tLINFrameEntry[SPS_2L_Req_MSG_Index].Length = 0x05;
            tLINFrameEntry[SPS_2L_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_2L_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_2L_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            tLINFrameEntry[SPS_2R_Req_MSG_Index].FrameId = 0x11;
            tLINFrameEntry[SPS_2R_Req_MSG_Index].Length = 0x05;
            tLINFrameEntry[SPS_2R_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_2R_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_2R_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            tLINFrameEntry[SPS_3L_Req_MSG_Index].FrameId = 0x15;
            tLINFrameEntry[SPS_3L_Req_MSG_Index].Length = 0x03;
            tLINFrameEntry[SPS_3L_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_3L_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_3L_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            tLINFrameEntry[SPS_3R_Req_MSG_Index].FrameId = 0x27;
            tLINFrameEntry[SPS_3R_Req_MSG_Index].Length = 0x03;
            tLINFrameEntry[SPS_3R_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_3R_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_3R_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            Publisher[SPS_DR_Req_MSG_Index].FrameId = 0xB1;
            Publisher[SPS_DR_Req_MSG_Index].Length = 4;
            Publisher[SPS_DR_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_DR_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_DR_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Publisher[SPS_CODR_Req_MSG_Index].FrameId = 0x97;
            Publisher[SPS_CODR_Req_MSG_Index].Length = 0x04;
            Publisher[SPS_CODR_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_CODR_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_CODR_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Publisher[SPS_2L_Req_MSG_Index].FrameId = 0x61;
            Publisher[SPS_2L_Req_MSG_Index].Length = 5;
            Publisher[SPS_2L_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_2L_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_2L_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Publisher[SPS_2R_Req_MSG_Index].FrameId = 0x11;
            Publisher[SPS_2R_Req_MSG_Index].Length = 5;
            Publisher[SPS_2R_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_2R_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_2R_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Publisher[SPS_3L_Req_MSG_Index].FrameId = 0x55;
            Publisher[SPS_3L_Req_MSG_Index].Length = 3;
            Publisher[SPS_3L_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_3L_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_3L_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Publisher[SPS_3R_Req_MSG_Index].FrameId = 0xE7;
            Publisher[SPS_3R_Req_MSG_Index].Length = 3;
            Publisher[SPS_3R_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_3R_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_3R_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            /********Msg for E16Msg_Subscriber**************/

            Msg_To_Send[DR_Index] = new TPCANMsg();
            Msg_To_Send[DR_Index].ID = 0x20E;
            Msg_To_Send[DR_Index].LEN = 7;
            Msg_To_Send[DR_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[DR_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0xFF, 0x3F, 0xC0, 0x00 };

            Msg_To_Send[CODR_Index] = new TPCANMsg();
            Msg_To_Send[CODR_Index].ID = 0x454;
            Msg_To_Send[CODR_Index].LEN = 2;
            Msg_To_Send[CODR_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[CODR_Index].DATA = new byte[8] { 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Msg_To_Send[SecRow_Index] = new TPCANMsg();
            Msg_To_Send[SecRow_Index].ID = 0x3A3;
            Msg_To_Send[SecRow_Index].LEN = 5;
            Msg_To_Send[SecRow_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[SecRow_Index].DATA = new byte[8] { 0xFF, 0xFF, 0xFF, 0xFF, 0xC0, 0x00, 0x00, 0x00 };

            Msg_To_Send[TriRow_Index] = new TPCANMsg();
            Msg_To_Send[TriRow_Index].ID = 0x456;
            Msg_To_Send[TriRow_Index].LEN = 2;
            Msg_To_Send[TriRow_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[TriRow_Index].DATA = new byte[8] { 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Msg_To_Send[DR_Recall_Index] = new TPCANMsg();
            Msg_To_Send[DR_Recall_Index].ID = 0x261;
            Msg_To_Send[DR_Recall_Index].LEN = 7;
            Msg_To_Send[DR_Recall_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[DR_Recall_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            Msg_To_Send[DR_Recall_Index].DATA[6] = 0x80;

            Msg_To_Send[CODR_Recall_Index] = new TPCANMsg();
            Msg_To_Send[CODR_Recall_Index].ID = 0x459;
            Msg_To_Send[CODR_Recall_Index].LEN = 7;
            Msg_To_Send[CODR_Recall_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[CODR_Recall_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            Msg_To_Send[CODR_Recall_Index].DATA[5] = 0x80;

            Msg_To_Send[NetWork_Index] = new TPCANMsg();
            Msg_To_Send[NetWork_Index].ID = 0x638;
            Msg_To_Send[NetWork_Index].LEN = 8;
            Msg_To_Send[NetWork_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[NetWork_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Msg_To_Send[FR_HV_Index] = new TPCANMsg();
            Msg_To_Send[FR_HV_Index].ID = 0x429;
            Msg_To_Send[FR_HV_Index].LEN = 8;
            Msg_To_Send[FR_HV_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[FR_HV_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Msg_To_Send[SR_HV_Index] = new TPCANMsg();
            Msg_To_Send[SR_HV_Index].ID = 0x426;
            Msg_To_Send[SR_HV_Index].LEN = 8;
            Msg_To_Send[SR_HV_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[SR_HV_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Msg_To_Send[TR_HV_Index] = new TPCANMsg();
            Msg_To_Send[TR_HV_Index].ID = 0x488;
            Msg_To_Send[TR_HV_Index].LEN = 8;
            Msg_To_Send[TR_HV_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[TR_HV_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Msg_To_Send[SR_MAS_Index] = new TPCANMsg();
            Msg_To_Send[SR_MAS_Index].ID = 0x383;
            Msg_To_Send[SR_MAS_Index].LEN = 8;
            Msg_To_Send[SR_MAS_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[SR_MAS_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };


            TPCANMsg.LEN = 8;
            TPCANMsg.MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            TPCANMsg.DATA = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

            

            if(!File.Exists(path))
            {
                File.Create(LogFileName).Close();

                StringBuilder strbuilder = new StringBuilder();
                
            }

            string TopRow = "时间" + "\t" + "循环次数" + "\t" + "执行次数" + "\t" + "实验名称" + "\t" + "实验样品" + "\t" + "温度" + "\t" + "湿度" + "\t" + "主驾加热" + "\t" + "主驾通风" + "\t" + "副驾加热" + "\t" + "副驾通风" + "\t" + "2R加热" + "\t" + "2R通风" + "\t" + "3L加热" + "\t" + "3L通风" + "\t" + "3R加热" + "\t" + "3R通风" + "\t" + String_repeat(52, "座椅电机" + "\t" + "起始位置" + "\t" + "目标位置" + "\t" + "停留时间" + "\t");
            appendData(LogFileName, false, TopRow);

            seatMotors[0,0].ID = 0x20F;
            seatMotors[0,2].ID = 0x20F;
            seatMotors[0,3].ID = 0x261;
            seatMotors[0,5].ID = 0x261;
            seatMotors[0,6].ID = 0x210;
            seatMotors[0,7].ID = 0x210;

            seatMotors[0,0].RID = 0x213;
            seatMotors[0,2].RID = 0x213;
            seatMotors[0,3].RID = 0x262;
            seatMotors[0,5].RID = 0x262;
            seatMotors[0,6].RID = 0x214;
            seatMotors[0,7].RID = 0x214;

            seatMotors[1,2].ID = 0x457;
            seatMotors[1,0].ID = 0x457;
            seatMotors[1,5].ID = 0x457;
            seatMotors[1,6].ID = 0x458;
            seatMotors[1,7].ID = 0x458;
            seatMotors[1,3].ID = 0x458;

            seatMotors[1,2].RID = 0x470;
            seatMotors[1,0].RID = 0x470;
            seatMotors[1,5].RID = 0x470;
            seatMotors[1,6].RID = 0x471;
            seatMotors[1,7].RID = 0x471;
            seatMotors[1,3].RID = 0x471;

            seatMotors[3,2].ID = 0x459;
            seatMotors[3,0].ID = 0x459;
            seatMotors[3,4].ID = 0x459;
            seatMotors[3,6].ID = 0x45A;
            seatMotors[3,7].ID = 0x45A;
            seatMotors[3,3].ID = 0x45A;

            seatMotors[3,2].RID = 0x463;
            seatMotors[3,0].RID = 0x463;
            seatMotors[3,4].RID = 0x463;
            seatMotors[3,6].RID = 0x464;
            seatMotors[3,7].RID = 0x464;
            seatMotors[3,3].RID = 0x464;

            seatMotors[4,2].ID = 0x45B;
            seatMotors[4,0].ID = 0x45B;
            seatMotors[4,1].ID = 0x45B;

            seatMotors[4,2].RID = 0x468;
            seatMotors[4,0].RID = 0x468;
            seatMotors[4,1].RID = 0x468;

            seatMotors[5,2].ID = 0x45C;
            seatMotors[5,0].ID = 0x45C;
            seatMotors[5,1].ID = 0x45C;

            seatMotors[5,2].RID = 0x46C;
            seatMotors[5,0].RID = 0x46C;
            seatMotors[5,1].RID = 0x46C;

            start_can_Read = true;
        }

        static string path = System.AppDomain.CurrentDomain.BaseDirectory + "\\";
        string LogFileName = path + "data.xls";

        private void SetData(byte Seat, byte Motor, uint TargetPosHex)
        {
            TPCANMsg.ID = seatMotors[(int)Seat,(int)Motor].ID;
            TPCANMsg.DATA = new byte[8] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            uint TargetPos = (uint)(TargetPosHex / 0.025);
            byte position1;
            byte position2;
            byte position3;
            if (Seat == 0)
            {
                if(Motor == 2)
                {
                    position1 = (byte)((TargetPos >> 4)& 0xFF);
                    position2 = (byte)(((TargetPos) & 0x0F) << 4);
                    TPCANMsg.DATA[4] = position1;
                    TPCANMsg.DATA[5] = (byte)(position2 | 0x0F);
                    DR_Recall = true;
                }
                if(Motor == 0)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[5] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[6] = position2;
                    DR_Recall = true;

                }
                if(Motor == 6)
                {
                    position1 = (byte)((TargetPos >> 4) & 0xFF);
                    position2 = (byte)(TargetPos & 0x0F);
                    TPCANMsg.DATA[4] = position1;
                    TPCANMsg.DATA[5] = (byte)((position2 << 4) | 0x0F);
                    DR_Recall = true;
                }
                if (Motor == 7)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[5] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[6] = position2;
                    DR_Recall = true;
                }
                if (Motor == 3)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[4] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[3] = position2;
                    TPCANMsg.DATA[6] = 0x80;
                }
                if (Motor == 5)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[1] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[2] = position2;
                    TPCANMsg.DATA[6] = 0x80;
                }
            }
            if(Seat == 1)
            {
                if(Motor == 2)
                {
                    position1 = (byte)((TargetPos >> 4) & 0xFF);
                    position2 = (byte)((TargetPos) & 0x0F);
                    TPCANMsg.DATA[0] = position1;
                    TPCANMsg.DATA[1] = (byte)((position2 << 4) | 0x0F);
                    CODR_Recall = true;
                }
                if(Motor == 0)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[1] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[2] = position2;
                    CODR_Recall = true;
                }
                if(Motor == 5)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)(TargetPos & 0xFF);
                    TPCANMsg.DATA[4] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[5] = position2;
                    TPCANMsg.DATA[7] = 0xC0;
                }
                if(Motor == 6)
                {
                    position1 = (byte)((TargetPos >> 4) & 0xFF);
                    position2 = (byte)(TargetPos & 0x0F);
                    TPCANMsg.DATA[0] = position1;
                    TPCANMsg.DATA[1] = (byte)((position2 << 4) | 0x0F);
                    CODR_Recall = true;
                }
                if (Motor == 7)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[1] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[2] = position2;
                    CODR_Recall = true;
                }
                if (Motor == 3)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[4] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[5] = position2;
                    TPCANMsg.DATA[7] = 0xC0;
                }
            }
            if(Seat == 3)
            {
                if(Motor == 2)
                {
                    position1 = (byte)((TargetPos >> 4) & 0xFF);
                    position2 = (byte)((TargetPos) & 0x0F);
                    TPCANMsg.DATA[0] = position1;
                    TPCANMsg.DATA[1] = (byte)((position2 << 4) | 0x0F);
                    TPCANMsg.DATA[6] = 0x80;

                }
                if (Motor == 0)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[1] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[2] = position2;
                    TPCANMsg.DATA[6] = 0x80;
                }
                if (Motor == 4)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[4] = (byte)(position1 |0xF0);
                    TPCANMsg.DATA[5] = position2;
                    TPCANMsg.DATA[6] = 0x80;
                }
                if (Motor == 6)
                {
                    position1 = (byte)((TargetPos >> 4) & 0xFF);
                    position2 = (byte)((TargetPos) & 0x0F);
                    TPCANMsg.DATA[0] = position1;
                    TPCANMsg.DATA[1] = (byte)((position2 << 4) | 0xF0);
                    SR_Recall = true;
                }
                if (Motor == 7)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[1] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[2] = position2;
                    SR_Recall = true;
                }
                if (Motor == 3)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[4] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[5] = position2;
                    SR_Recall = true;
                }
            }
            /*if(Seat == 4)
            {
                if(Motor == 2)
                {
                    position1 = (byte)((TargetPos >> 4) & 0xFF);
                    position2 = (byte)((TargetPos ) & 0x0F);
                    TPCANMsg.DATA[0] = position1;
                    TPCANMsg.DATA[1] = (byte)(position2 << 4);
                    TPCANMsg.DATA[4] = 0x02;
                }
                if (Motor == 0)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)((TargetPos) & 0xFF);
                    TPCANMsg.DATA[1] = position1;
                    TPCANMsg.DATA[2] = position2;
                    TPCANMsg.DATA[4] = 0x02;
                }
                if (Motor == 1)
                {
                    position1 = (byte)((TargetPos >> 4) & 0xFF);
                    position2 = (byte)(TargetPos & 0x0F);
                    TPCANMsg.DATA[3] = position1;
                    TPCANMsg.DATA[4] = (byte)(position2 << 4);
                    TPCANMsg.DATA[4] |= 0x02;
                }
            }*/
            if ((Seat == 5) || (Seat == 4))
            {
                if (Motor == 2)
                {
                    position1 = (byte)((TargetPos >> 4) & 0xFF);
                    position2 = (byte)((TargetPos) & 0x0F);
                    TPCANMsg.DATA[0] = position1;
                    TPCANMsg.DATA[1] = (byte)((position2 << 4) | 0x0F);
                    TPCANMsg.DATA[4] |= 0x02;
                }
                if (Motor == 0)
                {
                    position1 = (byte)((TargetPos >> 8) & 0x0F);
                    position2 = (byte)(TargetPos & 0xFF);
                    TPCANMsg.DATA[1] = (byte)(position1 | 0xF0);
                    TPCANMsg.DATA[2] = position2;
                    TPCANMsg.DATA[4] = 0x02;
                }
                if (Motor == 1)
                {
                    position1 = (byte)((TargetPos >> 4) & 0xFF);
                    position2 = (byte)(TargetPos & 0x0F);
                    TPCANMsg.DATA[3] = position1;
                    TPCANMsg.DATA[4] = (byte)((position2 << 4) | 0x0F);
                    TPCANMsg.DATA[4] |= 0x02;
                }
            }
        }

        private void SetHVdata(Int16 ID)
        {
            switch(ID)
            {
                case 0x429:
                    Msg_To_Send[FR_HV_Index].DATA[0] = Sig429_DrvStHtCshnDtyCycl;
                    Msg_To_Send[FR_HV_Index].DATA[1] = Sig429_DrvStHtBkDtyCycl;
                    Msg_To_Send[FR_HV_Index].DATA[2] = Sig429_DrvStVntDtyCycl;
                    Msg_To_Send[FR_HV_Index].DATA[3] = Sig429_PassStHtCshnDtyCycl;
                    Msg_To_Send[FR_HV_Index].DATA[4] = Sig429_PassStHtBkDtyCycl;
                    Msg_To_Send[FR_HV_Index].DATA[5] = Sig429_PassStVntDtyCycl;
                    break;
                case 0x426:
                    Msg_To_Send[SR_HV_Index].DATA[0] = Sig426_SecRwRtStHtCshnDtyCycl;
                    Msg_To_Send[SR_HV_Index].DATA[1] = Sig426_SecRwRtStHtBkDtyCycl;
                    Msg_To_Send[SR_HV_Index].DATA[2] = Sig426_SecRwRtStVntDtyCycl;
                    Msg_To_Send[SR_HV_Index].DATA[3] = Sig426_SecRwLtStHtCshnDtyCycl;
                    Msg_To_Send[SR_HV_Index].DATA[4] = Sig426_SecRwLtStHtBkDtyCycl;
                    Msg_To_Send[SR_HV_Index].DATA[5] = Sig426_SecRwLtStVntDtyCycl;
                    break;
                case 0x488:
                    Msg_To_Send[TR_HV_Index].DATA[0] = Sig488_ThdRwRtStHtCshnDtyCycl;
                    Msg_To_Send[TR_HV_Index].DATA[1] = Sig488_ThdRwRtStHtBkDtyCycl;
                    Msg_To_Send[TR_HV_Index].DATA[2] = Sig488_ThdRwRtStVntDtyCycl;
                    Msg_To_Send[TR_HV_Index].DATA[3] = Sig488_ThdRwLtStHtCshnDtyCycl;
                    Msg_To_Send[TR_HV_Index].DATA[4] = Sig488_ThdRwLtStHtBkDtyCycl;
                    Msg_To_Send[TR_HV_Index].DATA[5] = Sig488_ThdRwLtStVntDtyCycl;
                    break;
                case 0x382:
                    Msg_To_Send[Mode1_Index].DATA[3] = (byte)((Sig_L_LtStFtUpwdHMI2LReq << 7) | (Sig_L_LtStFtDnwdHMI2LReq << 6) | (Sig_SecRwLtStArmScrnHMI2LReq << 5));
                    break;
                case 0x383:
                    Msg_To_Send[SR_MAS_Index].DATA[1] = (byte)(Sig_SecRwRtStArmScrnHMI2RReq << 2);
                    Msg_To_Send[SR_MAS_Index].DATA[2] = (byte)((Sig383_2R_SecRwRtStFtUpwdHMI2RReq << 7) | (Sig383_2R_SecRwRtStFtDnwdHMI2RReq << 6));
                    Msg_To_Send[SR_MAS_Index].DATA[3] = (byte)((Sig383_SecRwRtStMassMdHMI2RReq << 3) | (Sig383_SecRwRtStMassStrsHMI2RReq));
                    break;
            }
                

        }


        Peak.Lin.TLINError tLINError;
        private void Get_LinData(byte index)
        {
            //Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref lFrameEntry);
            switch (index)
            {

                case 0:
                    {
                        Publisher[SPS_DR_Req_MSG_Index].Data[1] = (byte)((Sig_L_SeatFrwdCustSeltn << 4) | (Sig_L_SeatRrwdCustSeltn << 5) | (Sig_L_CushFrtUpCustSeltn << 6) | (Sig_L_CushFrtDwnCustSeltn << 7));
                        Publisher[SPS_DR_Req_MSG_Index].Data[2] = (byte)((Sig_L_MasgOnOffCustSeltn) | (Sig_L_CushRrUpCustSeltn << 1) | (Sig_L_CushRrDwnCustSeltn << 2) | (Sig_L_StkSeatCustSeltnSts << 3) | (Sig_L_SeatCustSelnActSts << 4) | (Sig_L_ReclineFrwdCustSeltn << 5) | (Sig_L_ReclineRrwdCustSeltn << 6) | (Sig_L_LumbFrwdCustSeltn << 7));
                        Publisher[SPS_DR_Req_MSG_Index].Data[3] = (byte)((Sig_L_LumbRrwdCustSeltn) | (Sig_L_LumbUpCustSeltn << 1) | (Sig_L_LumbDwnCustSeltn << 2) | (Sig_L_StSwAuxCtlFltPrsnt << 3));
                        //Publisher[SPS_DR_Req_MSG_Index].Data[4] = 0x0;
                        Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref tLINFrameEntry[SPS_DR_Req_MSG_Index]);
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, 0x31, 0, Publisher[SPS_DR_Req_MSG_Index].Length, Publisher[SPS_DR_Req_MSG_Index].Data);

                    }
                    break;
                case 1:
                    {
                        Publisher[SPS_CODR_Req_MSG_Index].Data[0] = 0x0;
                        Publisher[SPS_CODR_Req_MSG_Index].Data[1] = (byte)((Sig_R_SeatFrwdCustSeltn << 4) | (Sig_R_SeatRrwdCustSeltn << 5) | (Sig_R_CushFrtUpCustSeltn << 6) | (Sig_R_CushFrtDwnCustSeltn << 7));
                        Publisher[SPS_CODR_Req_MSG_Index].Data[2] = (byte)((Sig_R_MasgOnOffCustSeltn) | (Sig_R_CushRrUpCustSeltn << 1) | (Sig_R_CushRrDwnCustSeltn << 2) | (Sig_R_StkSeatCustSeltnSts << 3) | (Sig_R_SeatCustSelnActSts << 4) | (Sig_R_ReclineFrwdCustSeltn << 5) | (Sig_R_ReclineRrwdCustSeltn << 6) | (Sig_R_LumbFrwdCustSeltn << 7));
                        Publisher[SPS_CODR_Req_MSG_Index].Data[3] = (byte)((Sig_R_LumbRrwdCustSeltn) | (Sig_R_LumbUpCustSeltn << 1) | (Sig_R_LumbDwnCustSeltn << 2) | (Sig_R_StSwAuxCtlFltPrsnt << 3));
                        Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref tLINFrameEntry[SPS_CODR_Req_MSG_Index]);
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, 0x17, 0, Publisher[SPS_CODR_Req_MSG_Index].Length, Publisher[SPS_CODR_Req_MSG_Index].Data);
                    }
                    break;
                case 2:
                    {
                        Publisher[SPS_2L_Req_MSG_Index].Data[0] = 0x0;
                        Publisher[SPS_2L_Req_MSG_Index].Data[1] = 0x0;
                        Publisher[SPS_2L_Req_MSG_Index].Data[2] = (byte)((Sig_SPS_2L_SecRwStFrwdSwActv << 2) | (Sig_SPS_2L_SecRwStBkwdSwActv << 3) | (Sig_SPS_2L_SecRwStBkReclnUpwdSwActv << 4) | (Sig_SPS_2L_SecRwStBkReclnDnwdSwActv << 5) | (Sig_SPS_2L_SecRwStLgrstUpwdSwActv << 6) | (Sig_SPS_2L_SecRwStLgrstDnwdSwActv << 7));
                        Publisher[SPS_2L_Req_MSG_Index].Data[3] = (byte)((Sig_SPS_2L_SecRwStLmbrFrwdSwActv) | (Sig_SPS_2L_SecRwStLmbrBkwdSwActv << 1) | (Sig_SPS_2L_SecRwStLmbrUpwdSwActv << 2) | (Sig_SPS_2L_SecRwStLmbrDnwdSwActv << 3));
                        Publisher[SPS_2L_Req_MSG_Index].Data[4] = 0x0;
                        Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref tLINFrameEntry[SPS_2L_Req_MSG_Index]);
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, 0x21, 0, Publisher[SPS_2L_Req_MSG_Index].Length, Publisher[SPS_2L_Req_MSG_Index].Data);
                    }
                    break;
                case 3:
                    {
                        Publisher[SPS_2R_Req_MSG_Index].Data[0] = 0x0;
                        Publisher[SPS_2R_Req_MSG_Index].Data[1] = 0x0;
                        Publisher[SPS_2R_Req_MSG_Index].Data[2] = (byte)((Sig_SPS_2R_SecRwStFrwdSwActv << 2) | (Sig_SPS_2R_SecRwStBkwdSwActv << 3) | (Sig_SPS_2R_SecRwStBkReclnUpwdSwActv << 4) | (Sig_SPS_2R_SecRwStBkReclnDnwdSwActv << 5) | (Sig_SPS_2R_SecRwStLgrstUpwdSwActv << 6) | (Sig_SPS_2R_SecRwStLgrstDnwdSwActv << 7));
                        Publisher[SPS_2R_Req_MSG_Index].Data[3] = (byte)((Sig_SPS_2R_SecRwStLmbrFrwdSwActv) | (Sig_SPS_2R_SecRwStLmbrBkwdSwActv << 1) | (Sig_SPS_2R_SecRwStLmbrUpwdSwActv << 2) | (Sig_SPS_2R_SecRwStLmbrDnwdSwActv << 3));
                        Publisher[SPS_2R_Req_MSG_Index].Data[4] = 0x0;
                        Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref tLINFrameEntry[SPS_2R_Req_MSG_Index]);
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, 0x11, 0, Publisher[SPS_2R_Req_MSG_Index].Length, Publisher[SPS_2R_Req_MSG_Index].Data);
                    }
                    break;
                case 4:
                    {
                        Publisher[SPS_3L_Req_MSG_Index].Data[0] = 0x0;
                        Publisher[SPS_3L_Req_MSG_Index].Data[1] = 0x0;
                        Publisher[SPS_3L_Req_MSG_Index].Data[2] = (byte)((Sig_SPS_3L_AcsMdExtRclSwActv) | (Sig_SPS_3L_ThdRStExpdSwActv << 1) | (Sig_SPS_3L_ThdRStFrwdSwActv << 2) | (Sig_SPS_3L_ThdRStBkwdSwActv << 3) | (Sig_SPS_3L_ThdRwStBkReclnUpwdSwActv << 4) | (Sig_SPS_3L_ThdRwStBkReclnDnwdSwActv << 5));
                        Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref tLINFrameEntry[SPS_3L_Req_MSG_Index]);
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, 0x15, 0, Publisher[SPS_3L_Req_MSG_Index].Length, Publisher[SPS_3L_Req_MSG_Index].Data);
                    }
                    break;
                case 5:
                    {
                        Publisher[SPS_3R_Req_MSG_Index].Data[0] = 0x0;
                        Publisher[SPS_3R_Req_MSG_Index].Data[1] = 0x0;
                        Publisher[SPS_3R_Req_MSG_Index].Data[2] = (byte)((Sig_SPS_3R_AcsMdExtRtRclSwActv) | (Sig_SPS_3R_ThdRRtStExpdSwActv << 1) | (Sig_SPS_3R_ThdRwRtStFrwdSwActv << 2) | (Sig_SPS_3R_ThdRwRtStBkwdSwActv << 3) | (Sig_SPS_3R_ThdRwRtStBkReclnUpwdSwActv << 4) | (Sig_SPS_3R_ThdRwRtStBkReclnDnwdSwActv << 5));
                        Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref tLINFrameEntry[SPS_3R_Req_MSG_Index]);
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, 0x27, 0, Publisher[SPS_3R_Req_MSG_Index].Length, Publisher[SPS_3R_Req_MSG_Index].Data);
                    }
                    break;
            }
        }

        private void Empty_CommandService()
        {
            Msg_To_Send[DR_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            Msg_To_Send[CODR_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            Msg_To_Send[SecRow_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            Msg_To_Send[TriRow_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        }

        private void Fill_CommandService()
        {
            Msg_To_Send[DR_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0xFF, 0x3F, 0xC0, 0x00 };
            Msg_To_Send[CODR_Index].DATA = new byte[8] { 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            Msg_To_Send[SecRow_Index].DATA = new byte[8] { 0xFF, 0xFF, 0xFF, 0xFF, 0xC0, 0x00, 0x00, 0x00 };
            Msg_To_Send[TriRow_Index].DATA = new byte[8] { 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        }

        private void SetRecall()
        {
            DR_Recall = false;
            CODR_Recall = false;
            SR_Recall = false;
        }

        private string String_repeat(int times, string repeat)
        {
            int i;
            StringBuilder sp = new StringBuilder();
            for (i = 0; i < times; i++)
            {
                sp.Append(repeat);
            }
            return sp.ToString();
        }

        private void MainWnd_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().MaxWorkingSet = (IntPtr)750000;
            PM_Tools_SelfReceive.Checked = m_pRcvFrames.SelfReceive;
            // Show the Connection Dialog
            DoLinConnect();
            // Refresh the menu, toolbar and popup commands
            // depends on the state of LIN connection.
            RefreshCommands(m_hHw != 0, false);
            // Refresh the text of StatusBar
            RefreshStatusBar(m_hHw != 0);
            // Assign the client handle to the Receive List
            // so it can recieve LIN frames.
            m_pRcvFrames.ClientHandle = m_hClient;
            // Start the possibility to receive LIN frames.
            m_pRcvFrames.StartWatching();
            // Start the MainTimer to get periodical LIN status.
            MainTimer.Enabled = true;
            start_flag = true;
            //Thread timer_th = new Thread(timer_func);
            //Thread timer_th1 = new Thread(timer_func1);
            //timer_th.Start();
            //timer_th1.Start();
            //start_flag = true;
        }

        /// <summary>
        /// Occurs before the form is closed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A FormClosingEventArgs that contains the event data.</param>
        private void MainWnd_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Free the Receive List.
            m_pRcvFrames = null;
            // Free the Transmit List.
            m_pXmtFrames = null;
            // Free the Global Frame Table.
            m_pGFT = null;
            // Stop the MainTimer
            MainTimer.Enabled = false;
            if (m_hClient != 0)
            {
                DoLinDisconnect();
                m_hHw = 0;
                // Unregister the application
                Peak.Lin.PLinApi.RemoveClient(m_hClient);
                m_hClient = 0;
            }
            start_flag = false;
            System.Environment.Exit(0);
        }

        private void MyTransimitFunction( Peak.Lin.TLINMsg lMsg)    
        {            
            
             // Calculate the checksum contained with the
             // checksum type that set some line before.
             Peak.Lin.PLinApi.CalculateChecksum(ref lMsg);
             // Try to send the LIN frame message with LIN_Write.
             m_LastLINErr = Peak.Lin.PLinApi.Write(m_hClient, m_hHw, ref lMsg);
          
        }

        private void delay100ms()
        {
            for (int i = 0; i < 5000; i++)
            {
                for (int j = 0; j < 8000; j++)
                { }
            }  
        }

        private void ResetLink()
        {
            DoLinDisconnect();
            int lnCurrBaud, lnMode;
            byte lwHw = 1;
            ushort lwBaud;
            ulong llMask;
            string sErrText;
            sErrText = new string('\0', 255);

            Peak.Lin.TLINHardwareMode lHwMode;
            
                        // The local hardware handle is valid.
                        // Get the current mode of the hardware
                        Peak.Lin.PLinApi.GetHardwareParam(lwHw, Peak.Lin.TLINHardwareParam.hwpMode, out lnMode, 0);
                        // Get the current baudrate of the hardware
                        Peak.Lin.PLinApi.GetHardwareParam(lwHw, Peak.Lin.TLINHardwareParam.hwpBaudrate, out lnCurrBaud, 0);
                        // Try to connect the application client to the
                        // hardware with the local handle.
                        m_LastLINErr = Peak.Lin.PLinApi.ConnectClient(m_hClient, lwHw);
                        if (m_LastLINErr == Peak.Lin.TLINError.errOK)
                        {
                            // If the connection successfull
                            // assign the local handle to the
                            // member handle.
                            m_hHw = lwHw;
                            // Get the selected hardware mode.
                            lHwMode = Peak.Lin.TLINHardwareMode.modMaster;
                           
                            // Get the selected baudrate
                            lwBaud = 10400;
                            // Get the selected hardware channel
                            m_nHwChannel = 1;
                            if (((Peak.Lin.TLINHardwareMode)lnMode == Peak.Lin.TLINHardwareMode.modNone)
                                || (Convert.ToUInt16(lnCurrBaud) != lwBaud))
                            {
                                // Only if the current hardware is not initialize
                                // try to Intialize the hardware with mode and baudrate
                                m_LastLINErr = Peak.Lin.PLinApi.InitializeHardware(m_hClient,
                                    m_hHw, lHwMode, lwBaud);
                            }
                            if (m_LastLINErr == Peak.Lin.TLINError.errOK)
                            {
                                // Assign the Hardware Mode to member attribut
                                m_HwMode = lHwMode;
                                // Assign the baudrate index to member attribut
                                m_wBaudrate = lwBaud;
                                // Get the the client filter mask.
                                llMask = m_lMask;
                                // Set the client filter with the mask.
                                m_LastLINErr = Peak.Lin.PLinApi.SetClientFilter(m_hClient, m_hHw, llMask);
                                if (m_LastLINErr == Peak.Lin.TLINError.errOK)
                                    // Assign the filter mask to attibut.
                                    m_lMask = llMask;                   //Set the name of connected hardware.
                                //m_sHardwareName = lvi.Text;
                                //Read the frame table from the connected hardware.
                                ReadFrameTableFromHw();
                                //Reset the LIN mode and LIN state to default. 
                                m_LINMode = Peak.Lin.TLINHardwareMode.modNone;
                                m_LINState = Peak.Lin.TLINHardwareState.hwsNotInitialized;
                                //Reset the last LIN error code to default.
                                m_LastLINErr = Peak.Lin.TLINError.errOK;
                            }
                            else
                            {
                                // An error occurs while initialize hardware.
                                // Set the member variable to default.
                                m_hHw = 0;
                                m_nHwChannel = 0;
                                m_sHardwareName = "";
                            }
                        }
                        else
                        {
                            // The local hardware handle is invalid
                            // and/or an error occurs while connecting
                            // hardware with client.
                            // Set the member variable to default.
                            m_hHw = 0;
                            m_nHwChannel = 0;
                            m_sHardwareName = "";
                        }
                        
                        // Check if any LIN error code was received.
                        if (m_LastLINErr != Peak.Lin.TLINError.errOK)
                        {
                            // If any error are occured
                            // display the error text in a message box.
                            // 0x00 = Neutral
                            // 0x07 = Language German
                            // 0x09 = Language English
                            Peak.Lin.PLinApi.GetErrorText(m_LastLINErr, 0x09, sErrText, 255);
                            MessageBox.Show(sErrText, Resources.SAppCaptionError);
                        }                
        }


        /// <summary>
        /// Refeshs the 'Enabled' property of some menu, toolbar
        /// and popup menu entries in conjunction with the state of
        /// hardware connection and the possiblity to edit.
        /// </summary>
        /// <param name="HwConnect">State of hardware connection. Set to true if a connection to a LIN-hardware exists. Otherwise this parameter must set to false.</param>
        /// <param name="TransmitEdit">State for add, edit or delete some elements from the transmit list. Set to true if elements can add, edit or delete. Otherwise this parameter must set to false.</param>
        private void RefreshCommands(bool HwConnect, bool TransmitEdit)
        {
            // Refresh the menu, toolbar and popup commands
            // with the parameter HwConnect and TransmitEdit.
            PM_Transmit_New.Enabled = HwConnect;
            PM_Transmit_Edit.Enabled = TransmitEdit;
            PM_Transmit_Delete.Enabled = TransmitEdit;
            PM_Transmit_ClearAll.Enabled = HwConnect;
            MM_Transmit_New.Enabled = HwConnect;
            MM_Transmit_Edit.Enabled = TransmitEdit;
            MM_Transmit_Delete.Enabled = TransmitEdit;
            MM_Transmit_ClearAll.Enabled = HwConnect;
            MM_Transmit_Send.Enabled = HwConnect && TransmitEdit;
            MM_LIN_Disconnect.Enabled = HwConnect;
            MM_LIN_Reset.Enabled = HwConnect;
            MM_LIN_GoToSleep.Enabled = HwConnect;
            MM_LIN_WakeUp.Enabled = HwConnect;
            TB_Transmit_AddNew.Enabled = HwConnect;
            TB_LIN_Reset.Enabled = HwConnect;
            MM_LIN_GoToSleep.Visible = m_HwMode == Peak.Lin.TLINHardwareMode.modMaster;
            MM_LIN_WakeUp.Visible = m_HwMode == Peak.Lin.TLINHardwareMode.modSlave;
        }

        /// <summary>
        /// Refreshs the StatusBar text in conjunction with the state
        /// of hardware connection.
        /// </summary>
        /// <param name="HwConnect">State of hardware connection. Set to true if a connection to a LIN-hardware exists. Otherwise this parameter must set to false.</param>
        private void RefreshStatusBar(bool HwConnect)
        {
            if (HwConnect)
            {
                String sBaudText;
                String sHwChannel;

                // Get the baudrate of the connected hardware.
                sBaudText = Convert.ToString(m_wBaudrate);
                // Get the channel of the connected hardware.
                sHwChannel = Convert.ToString(m_nHwChannel);
                // Hardware connection is valid
                // so refresh the text in the StatusBar
                // with the connection information.
                SB_LIN_Connect.ForeColor = SystemColors.ControlText;
                SB_LIN_Channel.ForeColor = SystemColors.ControlText;
                SB_LIN_Connect.Text = String.Format(Resources.SLINConnectTo, m_sHardwareName, sBaudText);
                SB_LIN_Channel.Text = String.Format(Resources.SLINConnectToCh, sHwChannel);
                SB_LIN_Overruns.Text = String.Format(Resources.SLINStatusOverruns, m_wOverruns);
            }
            else
            {
                // The hardware handle is invalid
                // so refresh the StatusBar text.
                SB_LIN_Connect.ForeColor = Color.Red;
                SB_LIN_Connect.Text = Resources.SLINNotConnected;
                SB_LIN_Channel.Text = "";
                SB_LIN_Mode.Text = "";
                SB_LIN_Status.Text = "";
                SB_LIN_Overruns.Text = "";
            }
        }

        /// <summary>
        /// Reads all values from the frame table of the hardware
        /// and assign it to the CGlobalFrameTable. Also refresh
        /// the Global Frame Table ListView with that values.
        /// </summary>
        private void ReadFrameTableFromHw()
        {
            int i, lnCnt;
            Peak.Lin.TLINFrameEntry lFrameEntry;
            Peak.Lin.TLINError lErr;
            ulong llMask;

            // Create a LIN frame entry object
            lFrameEntry = new Peak.Lin.TLINFrameEntry();
            // Get the count of Frame Definition from the
            // Global Frame Table.
            lnCnt = m_pGFT.Count;
            // Initialize the member attribut for the
            // client mask with 0.
            m_lMask = 0;
            // Each Frame Definition
            for (i = 0; i < lnCnt; i++)
            {
                // Before a frame entry can be read from the
                // hardware it have to set the Frame-ID of the
                // entry who want to get.
                lFrameEntry.FrameId = m_pGFT[i].IdAsByte;
                // Read the information of frame entry from the hardware.
                lErr = Peak.Lin.PLinApi.GetFrameEntry(m_hHw, ref lFrameEntry);
                // Check the result value of the LinApi function call.
                if (lErr == Peak.Lin.TLINError.errOK)
                {
                    // LinApi function call successfull.
                    // Copy the frame entry information to the Frame Definition.
                    m_pGFT[i].m_nLength = Convert.ToInt32(lFrameEntry.Length);
                    m_pGFT[i].m_bDirection = (byte)lFrameEntry.Direction;
                    m_pGFT[i].m_nChecksumType = (int)lFrameEntry.ChecksumType;
                    if (m_pGFT[i].Direction != EDirection.Disabled)
                    {
                        // If the direction not disabled than set the
                        // bit in the client filter mask.
                        llMask = ((ulong)1 << i) & FRAME_FILTER_MASK;
                        m_lMask = m_lMask | llMask;
                    }
                }
            }
            // If the Client and Hardware handles are valid.
            if ((m_hClient != 0) && (m_hHw != 0))
                Peak.Lin.PLinApi.SetClientFilter(m_hClient, m_hHw, m_lMask);
        }

        /// <summary>
        /// Get all values from the CGlobalFrameTable and write it
        /// to the frame table of the hardware.
        /// </summary>
        private void WriteFrameTableToHw()
        {
            int i, lnCnt;
            Peak.Lin.TLINFrameEntry lFrameEntry;

            // If the Client and Hardware handles
            // are invalid than return.
            if ((m_hClient == 0) || (m_hHw == 0))
                return;

            // Create a LIN frame entry object
            lFrameEntry = new Peak.Lin.TLINFrameEntry();
            // Get the count of Frame Definition from the
            // Global Frame Table.
            lnCnt = m_pGFT.Count;
            // Each Frame Definition
            for (i = 0; i < lnCnt; i++)
            {
                // Copy the Frame Definition information to the frame entry.
                lFrameEntry.FrameId = m_pGFT[i].IdAsByte;
                lFrameEntry.Length = (byte)m_pGFT[i].Length;
                lFrameEntry.ChecksumType = (Peak.Lin.TLINChecksumType)m_pGFT[i].ChecksumType;
                lFrameEntry.Direction = (Peak.Lin.TLINDirection)m_pGFT[i].Direction;
                lFrameEntry.Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;
                // Write the information of frame entry to the hardware.
                Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref lFrameEntry);
            }
        }

        /// <summary>
        /// The function is used to refresh all values of the CFrameDefintion
        /// objects in the CGlobalFrameTable to default values (LIN 1.2).
        /// </summary>
        private void DoResetGFT()
        {
            // Check the connection
            if ((m_hClient != 0) && (m_hHw != 0))
            {
                // If the client is connected to a hardware.
                Peak.Lin.TLINError lErr;
                
                // Reset the configuration on the hardware.
                lErr = Peak.Lin.PLinApi.ResetHardwareConfig(m_hClient, m_hHw);
                if (lErr == Peak.Lin.TLINError.errOK)
                {
                    // If the reset successfull than
                    // initialize hardware and read
                    // the frame entries from the hardware
                    // and refresh the Global Frame Table in
                    // the ListView.
                    Peak.Lin.PLinApi.InitializeHardware(m_hClient, m_hHw, m_HwMode, m_wBaudrate);
                    ReadFrameTableFromHw();
                }
            }
            else
            {
                m_pGFT.Reset();
            }
        }

        /// <summary>
        /// Clear the Receive Frames in the CRcvFrameList and clear all elements
        /// in the ListView 'lvReceive'.
        /// </summary>
        private void DoResetRcvFrames()
        {
            m_pRcvFrames.Clear();
            // Clear the Receive ListView.
        }

        /// <summary>
        /// Clear the Transmit Frames in the CXmtFrameList and clear all elements
        /// in the ListView 'lvTransmit'.
        /// </summary>
        private void DoResetXmtFrames()
        {
            // Clear the transmit LIN frames
            // from the Transmit List
            m_pXmtFrames.Clear();
        }

        /// <summary>
        /// Clear the Transmit Frames Counter in the CXmtFrameList and update all elements
        /// in the ListView 'lvTransmit'.
        /// </summary>
        private void DoResetXmtFramesCounter()
        {
            // Refresh the all transmit LIN frames
            // Counter from the Transmit List
            m_pXmtFrames.ClearCounter();
        }

        /// <summary>
        /// Initialize the CGlobalFrameTable with default values and clear the
        /// CRcvFrameList and CXmtFrameList.
        /// </summary>
        private void DoFileNew()
        {
            // Reset the Global Frame Table
            // and the assigned Window Controls.
            DoResetGFT();
            // Reset the Received Frames
            // and the assigned Window Controls.
            DoResetRcvFrames();
            // Reset the Transmit Frames
            // and the assigned Window Controls.
            DoResetXmtFrames();
            m_sFileName = "";
            Text = Resources.SAppCaption;
        }

        /// <summary>
        /// Save the data from CGlobalFrameTable and CXmtFrameList into a XML file.
        /// </summary>
        private void DoSaveFile()
        {
            // If the filename was set before
            // means that the user had opened
            // a file previos time and the
            // file can be write directly.
            // Otherwise it is a new file and
            // the command SaveAs have to call.
            if (m_sFileName == "")
                DoSaveAsFile();
            else
                WriteFile(m_sFileName);
        }

        /// <summary>
        /// Shows an save dialog to select a XML file in which the data from the
        /// CGlobalFrameTable and CXmtFrameList should be written and write the
        /// data into the selected file.
        /// </summary>
        private void DoSaveAsFile()
        {

        }

        /// <summary>
        /// Reads data from a XML file and initialize the CGlobalFrameTable
        /// and CXmtFrameList with the readed data.
        /// </summary>
        /// <param name="FileName">XML file to read for initialization.</param>
        /// <returns>
        /// Returns true if the XML file readed successfull.
        /// Otherwise false.
        /// </returns>
        private bool ReadFile(String FileName)
        {
            XmlReader doc;
            XmlReaderSettings setting = new XmlReaderSettings();
            String S;
            Version lThisVer, lFileVer;
            Peak.Lin.TLINHardwareMode lMode;

            // Initialize the settings to read a XML file.
            setting.ConformanceLevel = ConformanceLevel.Fragment;
            setting.IgnoreWhitespace = true;
            setting.IgnoreComments = true;

            // Create a XML file reader object.
            doc = XmlReader.Create(FileName, setting);
            // Starts the reading of data from a XML file.
            if (doc.Read() == true)
            {
                // Get the version of this application.
                lThisVer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                if (doc.HasAttributes)
                {
                    // If the XML file has an attibut 'Version'
                    // read this information.
                    S = doc.GetAttribute("Version");
                    lFileVer = new Version(S);
                    // If the XML file has an attibut 'HardwareMode'
                    // read this information.
                    S = doc.GetAttribute("HardwareMode");
                    if (S != null)
                        lMode = (Peak.Lin.TLINHardwareMode)Convert.ToInt32(S);
                    else
                        lMode = Peak.Lin.TLINHardwareMode.modNone;
                }
                else
                {
                    // Assign the current version
                    lFileVer = lThisVer;
                    lMode = Peak.Lin.TLINHardwareMode.modNone;
                }

                // Compare the version of the XML file with
                // the version of this application
                if (lThisVer.CompareTo(lFileVer) < 0)
                {
                    // The Version of the file is newer than the application.
                    return false;
                }
                else
                {
                    // The version of the XML file is older or
                    // has the same version that this application.
                    
                    // If the any hardware mode was load from file
                    // and any connection exists already.
                    if ((lMode != Peak.Lin.TLINHardwareMode.modNone)
                    && (m_hHw != 0))
                    {
                        // Create the message box text.
                        S = String.Format(Resources.SDifferentHwModes, System.IO.Path.GetFileName(FileName));
                        // Until the user set the hardware mode to the
                        // hardware mode which was loading.
                        while (lMode != m_HwMode)
                        {
                            DialogResult dRes;
                            dRes = MessageBox.Show(this, S, Resources.SAppCaptionQuestion, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            // Check the confirmation
                            if (dRes == DialogResult.Cancel)
                                // Exit this function and do not loading file.
                                return false;
                            else if (dRes == DialogResult.Yes)
                            {
                                // Try to change hardware mode before loading the file.
                                DoLinConnect();
                                // Refresh the text of StatusBar
                                RefreshStatusBar(m_hHw != 0);
                            }
                            else if (dRes == DialogResult.No)
                                // Irgnore the message and continue the loading.
                                break;
                        }
                    }

                    // Read data into Global Frame Table
                    m_pGFT.ReadData(doc);
                    // Refresh the frame table of the hardware
                    // with the table that readed from file.
                    WriteFrameTableToHw();
                    // Clear the transmit frames from the
                    // Transmit List before read the data
                    // from the XML file.
                    m_pXmtFrames.Clear();
                    // Read data into Transmit List
                    m_pXmtFrames.ReadData(doc);
                }
                // Reading finished successfull.
                return true;
            }
            // Reading NOT finished successfull.
            return false;
        }

        /// <summary>
        /// Writes data from the CGlobalFrameTable and CXmtFrameList into
        /// the XML file.
        /// </summary>
        /// <param name="FileName">XML file to write with data.</param>
        /// <returns>
        /// Returns true if the XML file wrote successfull.
        /// Otherwise false.
        /// </returns>
        private bool WriteFile(String FileName)
        {
            XmlWriter doc;
            XmlWriterSettings setting = new XmlWriterSettings();
            Version lVer;

            // Initialize the settings to write into XML file.
            setting.Indent = true;
            setting.OmitXmlDeclaration = true;
            setting.NewLineOnAttributes = true;

            // Get the version of this application.
            lVer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            try
            {
                // Create a XML file reader object.
                doc = XmlWriter.Create(FileName, setting);
                // Starts of write data
                doc.WriteStartElement("Project");
                // Write the application version as attribut.
                doc.WriteAttributeString("Version", lVer.ToString());
                // Write the hardware mode as attribut.
                doc.WriteAttributeString("HardwareMode", ((int)m_HwMode).ToString());

                // Write data from Global Frame Table
                m_pGFT.WriteData(ref doc);
                // Write data from Transmit List
                m_pXmtFrames.WriteData(ref doc);

                // End of writing data
                doc.WriteEndElement();
                doc.Flush();
                // Writing data finished successfull.
                return true;
            }
            catch
            {
                // If an error occurs
                // writing data NOT finished successfull.
                return false;
            }
        }

        /// <summary>
        /// Shows the connection dialog to select a hardware, baudrate and
        /// client filter and connect to the hardware with the setting values
        /// from the connection dialog.
        /// </summary>
        private bool DoLinConnect()
        {
            byte i;
            int nCurIdx = -1;
            ushort lwHw, lwBaud;
            ushort[] lwHwHandles;
            ushort lwBuffSize, lwCount;
            int lnHwType, lnDevNo, lnChannel, lnMode, lnCurrBaud;
            ulong llMask;
            string sErrText;
            bool fRet;
            ConnectDlg lConnectDlg;
            Peak.Lin.TLINError lLINErr;
            Peak.Lin.TLINHardwareMode lHwMode;
            ListViewItem lvi;

            fRet = false;
            // Create the Connection Dialog
            // Define and initialize local variables and objects.
            lConnectDlg = new ConnectDlg();
            lwHwHandles = new ushort[8];
            lwBuffSize = 8;
            lwCount = 0;
            sErrText = new string('\0', 255);

            // Get all available LIN hardware.
            lLINErr = Peak.Lin.PLinApi.GetAvailableHardware(lwHwHandles, lwBuffSize, out lwCount);

            if (lLINErr == Peak.Lin.TLINError.errOK)
            {
                // If no error occurs
                if (lwCount == 0)
                {
                    // No LIN hardware was found.
                    // Show an empty entry
                    lwHw = 0;
                    lvi = new ListViewItem(Resources.SHardwareNothingFound);
                    lvi.Tag = lwHw;
                    lConnectDlg.lvHardware.Items.Add(lvi);
                }
                // For each founded LIN hardware
                for (i = 0; i < lwCount; i++)
                {
                    // Get the handle of the hardware.
                    lwHw = lwHwHandles[i];
                    // Read the type of the hardware with the handle lwHw.
                    Peak.Lin.PLinApi.GetHardwareParam(lwHw, Peak.Lin.TLINHardwareParam.hwpType, out lnHwType, 0);
                    // Read the device number of the hardware with the handle lwHw.
                    Peak.Lin.PLinApi.GetHardwareParam(lwHw, Peak.Lin.TLINHardwareParam.hwpDeviceNumber, out lnDevNo, 0);
                    // Read the channel number of the hardware with the handle lwHw.
                    Peak.Lin.PLinApi.GetHardwareParam(lwHw, Peak.Lin.TLINHardwareParam.hwpChannelNumber, out lnChannel, 0);
                    // Read the mode of the hardware with the handle lwHw (Master, Slave or None).
                    Peak.Lin.PLinApi.GetHardwareParam(lwHw, Peak.Lin.TLINHardwareParam.hwpMode, out lnMode, 0);

                    // Create a ListView entry
                    // If the hardware type is a knowing hardware
                    // show the name of that in the label of the entry.
                    if (lnHwType == Peak.Lin.PLinApi.LIN_HW_TYPE_USB)
                        lvi = new ListViewItem(Resources.SHardwareTypeLIN);
                    else
                        // Show as unknown hardware
                        lvi = new ListViewItem(Resources.SHardwareTypeUnkown);

                    // Assign the handle of the LIN hardware with a
                    // property of the ListView entry for using later.
                    lvi.Tag = lwHw;
                    // Add the device number to the ListView entry.
                    lvi.SubItems.Add(Convert.ToString(lnDevNo));
                    // Add the channel number to the ListView entry.
                    lvi.SubItems.Add(Convert.ToString(lnChannel));
                    // Add the mode of the hardware to the ListeView entry.
                    if ((Peak.Lin.TLINHardwareMode)lnMode == Peak.Lin.TLINHardwareMode.modSlave)
                        lvi.SubItems.Add(Resources.SHardwareModeSlave);
                    else if ((Peak.Lin.TLINHardwareMode)lnMode == Peak.Lin.TLINHardwareMode.modMaster)
                        lvi.SubItems.Add(Resources.SHardwareModeMaster);
                    else
                        lvi.SubItems.Add(Resources.SHardwareModeNone);

                    // Add the ListView entry to the ListView.
                    lConnectDlg.lvHardware.Items.Add(lvi);
                    if (lwHw == m_hHw)
                        nCurIdx = i;
                }
                if (nCurIdx >= 0)
                    lConnectDlg.lvHardware.Items[nCurIdx].Selected = true;
                // Assign the Hardware mode to the control.
                if (m_HwMode == Peak.Lin.TLINHardwareMode.modMaster)
                    lConnectDlg.cbMode.SelectedIndex = 1;
                else
                    lConnectDlg.cbMode.SelectedIndex = 0;
                // Assign the Baudrate to the Control.
                lConnectDlg.cbBaudrate.Text = m_wBaudrate.ToString();
            }

            // Show the Connection Dialog
            if (lConnectDlg.ShowDialog(this) == DialogResult.OK)
            {
                if (m_hHw != 0)
                {
                    // If a connection to hardware already exits
                    // disconnect this connection at first.
                    if (DoLinDisconnect() == false)  
                        return fRet;
                }
                // Check if any hardware was selected on the dialog.
                if (lConnectDlg.lvHardware.SelectedItems.Count > 0)
                {
                    // Get the selected entry from the ListView.
                    lvi = lConnectDlg.lvHardware.SelectedItems[0];
                    // Read the assigned hardware handle from the entry.
                    lwHw = (ushort)(lvi.Tag);
                    // Check handle
                    if (lwHw != 0)
                    {
                        // The local hardware handle is valid.
                        // Get the current mode of the hardware
                        Peak.Lin.PLinApi.GetHardwareParam(lwHw, Peak.Lin.TLINHardwareParam.hwpMode, out lnMode, 0);
                        // Get the current baudrate of the hardware
                        Peak.Lin.PLinApi.GetHardwareParam(lwHw, Peak.Lin.TLINHardwareParam.hwpBaudrate, out lnCurrBaud, 0);
                        // Try to connect the application client to the
                        // hardware with the local handle.
                        m_LastLINErr = Peak.Lin.PLinApi.ConnectClient(m_hClient, lwHw);
                        if (m_LastLINErr == Peak.Lin.TLINError.errOK)
                        {
                            // If the connection successfull
                            // assign the local handle to the
                            // member handle.
                            m_hHw = lwHw;
                            // Get the selected hardware mode.
                            if (lConnectDlg.cbMode.SelectedIndex == 1)
                                lHwMode = Peak.Lin.TLINHardwareMode.modMaster;
                            else
                                lHwMode = Peak.Lin.TLINHardwareMode.modSlave;
                            // Get the selected baudrate
                            lwBaud = Convert.ToUInt16(lConnectDlg.cbBaudrate.Text);
                            // Get the selected hardware channel
                            m_nHwChannel = Convert.ToUInt16(lvi.SubItems[2].Text);
                            if (((Peak.Lin.TLINHardwareMode)lnMode == Peak.Lin.TLINHardwareMode.modNone)
                                || (Convert.ToUInt16(lnCurrBaud) != lwBaud))
                            {
                                // Only if the current hardware is not initialize
                                // try to Intialize the hardware with mode and baudrate
                                m_LastLINErr = Peak.Lin.PLinApi.InitializeHardware(m_hClient,
                                    m_hHw, lHwMode, lwBaud);
                            }
                            if (m_LastLINErr == Peak.Lin.TLINError.errOK)
                            {
                                // Assign the Hardware Mode to member attribut
                                m_HwMode = lHwMode;
                                // Assign the baudrate index to member attribut
                                m_wBaudrate = lwBaud;
                                // Get the the client filter mask.
                                llMask = m_lMask;
                                // Set the client filter with the mask.
                                m_LastLINErr = Peak.Lin.PLinApi.SetClientFilter(m_hClient, m_hHw, llMask);
                                if (m_LastLINErr == Peak.Lin.TLINError.errOK)
                                    // Assign the filter mask to attibut.
                                    m_lMask = llMask;
                                // Set the name of connected hardware.
                                m_sHardwareName = lvi.Text;
                                // Read the frame table from the connected hardware.
                                ReadFrameTableFromHw();
                                // Reset the LIN mode and LIN state to default. 
                                m_LINMode = Peak.Lin.TLINHardwareMode.modNone;
                                m_LINState = Peak.Lin.TLINHardwareState.hwsNotInitialized;
                                // Reset the last LIN error code to default.
                                m_LastLINErr = Peak.Lin.TLINError.errOK;
                                fRet = true;
                            }
                            else
                            {
                                // An error occurs while initialize hardware.
                                // Set the member variable to default.
                                m_hHw = 0;
                                m_nHwChannel = 0;
                                m_sHardwareName = "";
                                fRet = false;
                            }
                        }
                        else
                        {
                            // The local hardware handle is invalid
                            // and/or an error occurs while connecting
                            // hardware with client.
                            // Set the member variable to default.
                            m_hHw = 0;
                            m_nHwChannel = 0;
                            m_sHardwareName = "";
                            fRet = false;
                        }
                        
                        // Check if any LIN error code was received.
                        if (m_LastLINErr != Peak.Lin.TLINError.errOK)
                        {
                            // If any error are occured
                            // display the error text in a message box.
                            // 0x00 = Neutral
                            // 0x07 = Language German
                            // 0x09 = Language English
                            Peak.Lin.PLinApi.GetErrorText(m_LastLINErr, 0x09, sErrText, 255);
                            MessageBox.Show(sErrText, Resources.SAppCaptionError);
                            fRet = false;
                        }
                    }
                    else // Should never occur
                        m_hHw = 0; // But if it occurs, set handle to default
                }
                else // Should never occur
                    m_hHw = 0; // But if it occurs, set handle to default
            }

            // Check the mode of the Hardware (Master or Slave)
            // and refresh the picture on the left side of the application.
            if (m_HwMode == Peak.Lin.TLINHardwareMode.modMaster)
            {
                //pbTransmit.Image = Resources.XmtText;
                PM_Tools_SelfReceive.Enabled = true;
                PM_Tools_SelfReceive.Visible = true;
                m_pRcvFrames.SelfReceive = true;
                MM_Transmit.Text = Resources.SMMTransmit;
            }
            else if (m_HwMode == Peak.Lin.TLINHardwareMode.modSlave)
            {
                //pbTransmit.Image = Resources.PubText;
                PM_Tools_SelfReceive.Enabled = false;
                PM_Tools_SelfReceive.Visible = false;
                m_pRcvFrames.SelfReceive = true;
                MM_Transmit.Text = Resources.SMMPublish;
            }
            return fRet;
        }

        /// <summary>
        /// Disconnects an existing connection to a LIN hardware and returns
        /// true if disconnect finished succesfull or no connection exists.
        /// Returns false if the current connection can not be disconnected.
        /// </summary>
        /// <returns>
        /// Returns true if the function finished successfull. Otherwise
        /// returns false.
        /// </returns>
        private bool DoLinDisconnect()
        {
            // If the application was registered with LIN as client.
            if (m_hHw != 0)
            {
                // The client was connected to a LIN hardware.
                // Before disconnect from the hardware check
                // the connected clients and determine if the
                // hardware configuration have to reset or not.

                // Initialize the locale variables.
                bool lfOtherClient = false;
                bool lfOwnClient = false;
                byte[] lhClients = new byte[255];

                // Get the connected clients from the LIN hardware.
                m_LastLINErr = Peak.Lin.PLinApi.GetHardwareParam(m_hHw, Peak.Lin.TLINHardwareParam.hwpConnectedClients, lhClients, 255);
                if (m_LastLINErr == Peak.Lin.TLINError.errOK)
                {
                    // No errors !
                    // Check all client handles.
                    for (int i = 0; i < lhClients.Length; i++)
                    {
                        // If client handle is invalid
                        if (lhClients[i] == 0)
                            continue;
                        // Set the boolean to true if the handle isn't the
                        // handle of this application.
                        // Even the boolean is set to true it can never
                        // set to false.
                        lfOtherClient = lfOtherClient || (lhClients[i] != m_hClient);
                        // Set the boolean to true if the handle is the
                        // handle of this application.
                        // Even the boolean is set to true it can never
                        // set to false.
                        lfOwnClient = lfOwnClient || (lhClients[i] == m_hClient);
                    }
                }
                // If another application is also connected to
                // the LIN hardware do not reset the configuration.
                if (lfOtherClient == false)
                {
                    // No other application connected !
                    // Reset the configuration of the LIN hardware.
                    Peak.Lin.PLinApi.ResetHardwareConfig(m_hClient, m_hHw);
                }
                // If this application is connected to the hardware
                // than disconnect the client. Otherwise not.
                if (lfOwnClient == true)
                {
                    // Disconnect if the application was connected to a LIN hardware.
                    m_LastLINErr = Peak.Lin.PLinApi.DisconnectClient(m_hClient, m_hHw);
                    if (m_LastLINErr == Peak.Lin.TLINError.errOK)
                    {
                        m_hHw = 0;
                        // Refresh the StatusBar text.
                        RefreshStatusBar(false);
                        return true;
                    }
                    else
                    {
                        string sErrText = new string('\0', 255);
                        // Error while disconnecting from hardware.
                        Peak.Lin.PLinApi.GetErrorText(m_LastLINErr, 0x09, sErrText, 255);
                        MessageBox.Show(sErrText, Resources.SAppCaptionError);
                        return false;
                    }
                }
                else
                    return true;
            }
            else
                return true;
        }

        /// <summary>
        /// Resets the Client, Hardware, Receive List and the Receive ListView.
        /// </summary>
        private void DoLinReset()
        {
            // Reset all Receive Objects and Controls.
            DoResetRcvFrames();
            // Reset all Counter of the all Transmit Frames.
            DoResetXmtFramesCounter();
            // If the client is registered.
            if (m_hClient > 0)
                m_LastLINErr = Peak.Lin.PLinApi.ResetClient(m_hClient);
            // If the client is registered and
            // is connected to a hardware.
            if ((m_hClient > 0) && (m_hHw > 0))
                m_LastLINErr = Peak.Lin.PLinApi.ResetHardware(m_hClient, m_hHw);
        }

        /// <summary>
        /// Deletes the selected entry from the Receive ListView and
        /// it's assigned LIN frame from the Receive List.
        /// </summary>
        private void DoReceiveDelete()
        {          
        }

        /// <summary>
        /// Opens the Frame Dialog to add a new LIN frame to the Transmit List
        /// creates an entry for the Transmit ListView and assign the
        /// added LIN frame with the entry in the ListView.
        /// </summary>
        private void DoTransmitNew()
        {
            FrameDlg lFrameDlg;
            ListViewItem lvi;
            CCustomFrame lcFrame;
            int nIdx = -1;
            bool lfMustCreate = true;

            // Create the Frame Dialog to add a new LIN frame
            // to the Transmit List.
            lFrameDlg = new FrameDlg(m_pGFT, m_pXmtFrames, m_HwMode);
            lFrameDlg.Text = Resources.SFramesDlgNewCaption;
            // Set the index to -1 because a new LIN frame
            // should be create.
            nIdx = -1;
            // Show the Frame Dialog
            if (lFrameDlg.ShowDialogEx(this, ref nIdx, true) == DialogResult.OK)
            {
                // The returned index is the position of
                // the created LIN frame in the Transmit List.
                if (nIdx >= 0)
                {
                    // The index is valid.
                    // Lock the Transmit ListView for update.
                    //lvTransmit.BeginUpdate();
                    // Get the created LIN frame
                    lcFrame = m_pXmtFrames.Item[nIdx];
                    // if (lvTransmit.Items.Count > 0)
                    {
                        // If there are at least one entry
                        // in the ListView first check if
                        // it is the empty entry or not.
                        // If it is the empty entry with
                        // caption '<empty>' than replace
                        // the values of this entry.
                        // Otherwise a new entry have to create.
                        // lvi = lvTransmit.Items[0];
                        // Check the assigned LIN frame.
                        // No assigned frame (NULL) means empty entry.
                        // Assigned frame (!= NULL) means valid entry.
                        // lfMustCreate = lvi.Tag != null;
                    }
                    // else
                        lvi = null;

                    // A new entry have to create
                    if (lfMustCreate)
                    {
                        // Create a new ListView entry
                        // and assign the values.
                        lvi = new ListViewItem(lcFrame.IdAsString);
                    }
                    else if (lvi != null)
                    {
                        // The entry exits already but the value
                        // can replace by the values from the LIN frame.
                        // It was an emty entry.
                        // Replace the caption text of entry
                        lvi.Text = lcFrame.IdAsString;
                    }
                    
                    // In both cases it have to add all other
                    // values as sub items.
                    lvi.SubItems.Add(lcFrame.Length.ToString());
                    lvi.SubItems.Add(lcFrame.DataAsString);
                    lvi.SubItems.Add(lcFrame.CountAsString);
                    lvi.SubItems.Add(lcFrame.DirectionAsString);
                    lvi.SubItems.Add(lcFrame.ChecksumType.ToString());
                    // Assign the created LIN frame for using later.
                    lvi.Tag = lcFrame;

                    // Only if a new entry have to create
                    if (lfMustCreate) { }
                    // Add the created entry to the ListView.
                    // lvTransmit.Items.Add(lvi);

                    // Unlock and Update the ListView now.
                    // lvTransmit.EndUpdate();
                    // After add a new entry update the Transmit or Publish commands.
                    // RefreshCommands(m_hHw != 0, lvTransmit.SelectedIndices.Count > 0);
                }
            }
        }

        /// <summary>
        /// Checks the last LIN error code which was returned from
        /// a LIN function call and returns if an error code exists.
        /// </summary>
        /// <returns>Returns true if any error code exists. Otherwise returns false.</returns>
        private bool DoCheckLastError()
        {
            // If the last LIN error code was not O.K.
            if (m_LastLINErr != Peak.Lin.TLINError.errOK)
            {
                
                // Check if the hardware handle is valid.
                if (m_LastLINErr == Peak.Lin.TLINError.errIllegalHardware)
                {
                    // The hardware handle is invalid.
                    // Set the class member handle to invalid handle
                    // so that other function does not use this handle
                    // again with LIN functions.
                    m_hHw = 0;
                    // Refresh the menu, toolbar and popup commands
                    // depends on the state of LIN connection.
                    RefreshCommands(false, false);
                    // Refresh the StatusBar text.
                    RefreshStatusBar(false);
                }
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Checks the states of the connected LIN hardware and displays
        /// changes of the states in the StatusBar.
        /// </summary>
        private void DoLINCheckStates()
        {
            Peak.Lin.TLINHardwareStatus lStatus;

            if (m_hHw != 0)
            {
                // The Timer is used to get Status from the LinApi and
                // the LIN-Bus that is connected with the application.
                // When at least one Status (State or Mode) of the LIN-Bus is
                // changed the new state will be display in the StatusBar
                // of the application.

                if (m_fAutomatic == true)
                    return;
                m_fAutomatic = true;

                // Get the current Status from the LIN-Bus.
                m_LastLINErr = Peak.Lin.PLinApi.GetStatus(m_hHw, out lStatus);

                // Check the last Error.
                if (DoCheckLastError() == true)
                {
                    // With the last error code 
                    // this function have to exit.
                    m_fAutomatic = false;
                    return;
                }

                // If the State has been changed.
                if (m_LINState != lStatus.Status)
                {
                    // Inspect the new State and
                    // display the text in the
                    // StatusBar panel 'SB_LIN_Status'.
                    switch (lStatus.Status)
                    {
                        case Peak.Lin.TLINHardwareState.hwsNotInitialized:
                            SB_LIN_Status.ForeColor = Color.Red;
                            SB_LIN_Status.Text = Resources.SLINStatusNotInit;
                            break;
                        case Peak.Lin.TLINHardwareState.hwsAutobaudrate:
                            SB_LIN_Status.ForeColor = SystemColors.ControlText;
                            SB_LIN_Status.Text = Resources.SLINStausBaudDetect;
                            break;
                        case Peak.Lin.TLINHardwareState.hwsActive:
                            SB_LIN_Status.ForeColor = Color.Green;
                            SB_LIN_Status.Text = Resources.SLINStausActive;
                            break;
                        case Peak.Lin.TLINHardwareState.hwsSleep:
                            SB_LIN_Status.ForeColor = SystemColors.ControlText;
                            SB_LIN_Status.Text = Resources.SLINStausSleep;
                            break;
                        case Peak.Lin.TLINHardwareState.hwsShortGround:
                            SB_LIN_Status.ForeColor = Color.Red;
                            SB_LIN_Status.Text = Resources.SLINStausShortGround;
                            break;
                    }
                    // Keep the new state.
                    m_LINState = lStatus.Status;
                }
                // If the Mode has been changed.
                if (m_LINMode != lStatus.Mode)
                {
                    // Inspect the new Mode and
                    // dislay the text in the
                    // StatusBar panel 'SB_LIN_Mode'.
                    switch (lStatus.Mode)
                    {
                        case Peak.Lin.TLINHardwareMode.modNone:
                            SB_LIN_Mode.ForeColor = Color.Red;
                            SB_LIN_Mode.Text = Resources.SLINModeNotInit;
                            break;
                        case Peak.Lin.TLINHardwareMode.modMaster:
                            SB_LIN_Mode.ForeColor = SystemColors.ControlText;
                            SB_LIN_Mode.Text = Resources.SLINModeMaster;
                            break;
                        case Peak.Lin.TLINHardwareMode.modSlave:
                            SB_LIN_Mode.ForeColor = SystemColors.ControlText;
                            SB_LIN_Mode.Text = Resources.SLINModeSlave;
                            break;
                    }
                    // Keep the new Mode.
                    m_LINMode = lStatus.Mode;
                }
                if (m_wOverruns != lStatus.ReceiveBufferOverrun)
                {
                    m_wOverruns = lStatus.ReceiveBufferOverrun;
                    if (m_wOverruns > 0)
                        SB_LIN_Overruns.ForeColor = Color.Red;
                    else
                        SB_LIN_Overruns.ForeColor = SystemColors.ControlText;
                    SB_LIN_Overruns.Text = String.Format(Resources.SLINStatusOverruns, m_wOverruns);
                }
                m_fAutomatic = false;
            }
        }

        /// <summary>
        /// Occurs when the ToolStripItem "File->New" is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void File_New(object sender, EventArgs e)
        {
            // Call the function to create a new file
            // for saving data from Transmit List and
            // Global Frame Table.
            DoFileNew();
        }

        /// <summary>
        /// Occurs when the ToolStripItem "File->Save" is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void File_Save(object sender, EventArgs e)
        {
            // Call the function to save the Transmit List
            // and Global Frame Table into a file.
            DoSaveFile();
        }

        /// <summary>
        /// Occurs when the ToolStripItem "File->SaveAs" is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void File_SaveAs(object sender, EventArgs e)
        {
            // Call the function to open the Save Dialog
            // to locate the file to save the current data.
            DoSaveAsFile();
        }

        /// <summary>
        /// Occurs when the ToolStripItem "File->Exit" is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void File_Exit(object sender, EventArgs e)
        {
            // Exit the application.
            Close();
        }

        /// <summary>
        /// Occurs when the ToolStripItem "LIN->Connect" is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void LIN_Connect(object sender, EventArgs e)
        {
            Peak.Lin.TLINHardwareMode LastMode;
            ushort LastHw;

            // Get the last connected hardware mode and
            // hardware handle for checking after connect.
            LastMode = m_HwMode;
            LastHw = m_hHw;
            // Call the function to show the Connection Dialog.
            DoLinConnect();
            
            // Refresh the menu, toolbar and popup commands.
            RefreshCommands(m_hHw != 0, false);
            // Refresh the text of StatusBar
            RefreshStatusBar(m_hHw != 0);
            // If the hardware mode was changed
            // reset the transmit list.
            if ((LastMode != Peak.Lin.TLINHardwareMode.modNone)
            && (m_HwMode != Peak.Lin.TLINHardwareMode.modNone)
            && (LastMode != m_HwMode))
                DoResetXmtFrames();
            // If the hardware handle was changed
            // reset the transmit list.
            if(LastHw != m_hHw)
                DoResetXmtFrames();
            DoResetRcvFrames();
        }

        /// <summary>
        /// Occurs when the ToolStripItem "LIN->Disconnect" is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void LIN_Disconnect(object sender, EventArgs e)
        {
            // Call the function to show the Connection Dialog.
            DoLinDisconnect();
            // Refresh the menu, toolbar and popup commands.
            RefreshCommands(m_hHw != 0, false);
            // Refresh the text of StatusBar
            RefreshStatusBar(m_hHw != 0);
        }

        /// <summary>
        /// Occurs when the ToolStripItem "LIN->Reset" is clicked.
        /// Resets the client and the hardware if there is a connection.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void LIN_Reset(object sender, EventArgs e)
        {
            // Call the function to reset the LIN connection.
            DoLinReset();
        }

        /// <summary>
        /// Occurs when the ToolStripItem "LIN->GoToSleep" is clicked.
        /// Send the Got to Sleep Command on the LIN bus.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void LIN_GoToSleep(object sender, EventArgs e)
        {
            // Check the handles.
            if ((m_hClient > 0) && (m_hHw > 0))
            {
                // Define a locale Message Structure.
                Peak.Lin.TLINMsg lMsg;
                // Initialize the locale Structure
                // with the value for the sleep command.
                lMsg = new Peak.Lin.TLINMsg();
                // Master Request
                lMsg.FrameId = 0x3C;
                // Get Protected ID
                Peak.Lin.PLinApi.GetPID(ref lMsg.FrameId);
                lMsg.Length = 8;
                lMsg.Direction = Peak.Lin.TLINDirection.dirPublisher;
                lMsg.ChecksumType = Peak.Lin.TLINChecksumType.cstClassic;
                lMsg.Data = new byte[8];
                lMsg.Data[0] = 0; // Must be zero for sleep command.
                lMsg.Data[1] = 0xFF;
                lMsg.Data[2] = 0xFF;
                lMsg.Data[3] = 0xFF;
                lMsg.Data[4] = 0xFF;
                lMsg.Data[5] = 0xFF;
                lMsg.Data[6] = 0xFF;
                lMsg.Data[7] = 0xFF;
                // Calculate the checksum in the
                // Message Structure.
                Peak.Lin.PLinApi.CalculateChecksum(ref lMsg);
                // Send the command on the LIN bus.
                Peak.Lin.PLinApi.Write(m_hClient, m_hHw, ref lMsg);
            }
        }

        /// <summary>
        /// Occurs when the ToolStripItem "LIN->WakeUp" is clicked.
        /// Sends a wake-up message if there is a connection to hardware.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void LIN_WakeUp(object sender, EventArgs e)
        {
            // Check the handles.
            if ((m_hClient > 0) && (m_hHw > 0))
            {
                // If the application is registered as LIN client
                // and connected to a LIN hardware.
                // Try to wake up the LIN Bus system.
                m_LastLINErr = Peak.Lin.PLinApi.XmtWakeUp(m_hClient, m_hHw);
                if (m_LastLINErr != Peak.Lin.TLINError.errOK)
                {
                    // If the wake up failed
                    // show the error message.
                    string sErrText = new string('\0', 255);
                    Peak.Lin.PLinApi.GetErrorText(m_LastLINErr, 0x09, sErrText, 255);
                    MessageBox.Show(sErrText, Resources.SAppCaptionError);
                }
                else
                    DoLINCheckStates();

            }
        }

        /// <summary>
        /// Occurs when the ToolStripItem "PM_Receive_Delete" is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void Receive_Delete(object sender, EventArgs e)
        {
            // Call the function to remove an existing Receive Frame.
            DoReceiveDelete();
        }

        /// <summary>
        /// Occurs when the ToolStripItem "Transmit->New" is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void Transmit_AddNew(object sender, EventArgs e)
        {
            // Call the function to create a new Transmit Frame.
            DoTransmitNew();
        }

        /// <summary>
        /// Occurs when the ToolStripItem "Tools->ResetGFT" is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void Tools_ResetGFT(object sender, EventArgs e)
        {
            DoResetGFT();
        }

        /// <summary>
        /// Orrurs when the ToolStripItem "Tools->SelfReceive" is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void Tools_SelfReceive(object sender, EventArgs e)
        {
            m_pRcvFrames.SelfReceive = PM_Tools_SelfReceive.Checked;
        }

        /// <summary>
        /// Occurs when the ToolStripItem "Help->About" is clicked.
        /// Shows the About Dialog with the assembly information.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void Help_About(object sender, EventArgs e)
        {
            AboutDlg lAboutDlg;

            lAboutDlg = new AboutDlg();
            lAboutDlg.ShowDialog(this);
        }

        /// <summary>
        /// Occurs when the MainTimer interval has elapsed and it is enabled.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void OnMainTimerTick(object sender, EventArgs e)
        {
            DoLINCheckStates();
            label12.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Occurs when a LIN-Frame was received bei the CRcvFrameList.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An FrameReceivedEventArgs that contains the event data.</param>
        /// 
        char[] data;
        byte bt0, bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9, bt10, bt11, bt12, bt13, bt14, bt15;

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat13.Enabled = false;
                Motor13.Enabled = false;
                Stay13.Enabled = false;
                Origin_List[13] = 13;
            }
            else
            {
                Seat13.Enabled = true;
                Motor13.Enabled = true;
                Stay13.Enabled = true;
                Origin_List[13] = 0;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat14.Enabled = false;
                Motor14.Enabled = false;
                Stay14.Enabled = false;
                Origin_List[14] = 14;
            }
            else
            {
                Seat14.Enabled = true;
                Motor14.Enabled = true;
                Stay14.Enabled = true;
                Origin_List[14] = 0;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat15.Enabled = false;
                Motor15.Enabled = false;
                Stay15.Enabled = false;
                Origin_List[15] = 15;
            }
            else
            {
                Seat15.Enabled = true;
                Motor15.Enabled = true;
                Stay15.Enabled = true;
                Origin_List[15] = 0;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat16.Enabled = false;
                Motor16.Enabled = false;
                Stay16.Enabled = false;
                Origin_List[16] = 16;
            }
            else
            {
                Seat16.Enabled = true;
                Motor16.Enabled = true;
                Stay16.Enabled = true;
                Origin_List[16] = 0;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat17.Enabled = false;
                Motor17.Enabled = false;
                Stay17.Enabled = false;
                Origin_List[17] = 17;
            }
            else
            {
                Seat17.Enabled = true;
                Motor17.Enabled = true;
                Stay17.Enabled = true;
                Origin_List[17] = 0;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat18.Enabled = false;
                Motor18.Enabled = false;
                Stay18.Enabled = false;
                Origin_List[18] = 18;
            }
            else
            {
                Seat18.Enabled = true;
                Motor18.Enabled = true;
                Stay18.Enabled = true;
                Origin_List[18] = 0;
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat19.Enabled = false;
                Motor19.Enabled = false;
                Stay19.Enabled = false;
                Origin_List[19] = 19;
            }
            else
            {
                Seat19.Enabled = true;
                Motor19.Enabled = true;
                Stay19.Enabled = true;
                Origin_List[19] = 0;
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat20.Enabled = false;
                Motor20.Enabled = false;
                Stay20.Enabled = false;
                Origin_List[20] = 20;
            }
            else
            {
                Seat20.Enabled = true;
                Motor20.Enabled = true;
                Stay20.Enabled = true;
                Origin_List[20] = 0;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat12.Enabled = false;
                Motor12.Enabled = false;
                Stay12.Enabled = false;
                Origin_List[12] = 12;
            }
            else
            {
                Seat12.Enabled = true;
                Motor12.Enabled = true;
                Stay12.Enabled = true;
                Origin_List[12] = 0;
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if(Pause.Text == "暂停")
            {
                Pause.Text = "继续";
                pause_flag = true;
            }
            else if(Pause.Text == "继续")
            {
                Pause.Text = "暂停";
                pause_flag = false;
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat21.Enabled = false;
                Motor21.Enabled = false;
                Stay21.Enabled = false;
                Origin_List[21] = 21;
            }
            else
            {
                Seat21.Enabled = true;
                Motor21.Enabled = true;
                Stay21.Enabled = true;
                Origin_List[21] = 0;
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat36.Enabled = false;
                Motor36.Enabled = false;
                Stay36.Enabled = false;
                Origin_List[36] = 36;
            }
            else
            {
                Seat36.Enabled = true;
                Motor36.Enabled = true;
                Stay36.Enabled = true;
                Origin_List[36] = 0;
            }
        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox43.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat43.Enabled = false;
                Motor43.Enabled = false;
                Stay43.Enabled = false;
                Origin_List[43] = 43;
            }
            else
            {
                Seat43.Enabled = true;
                Motor43.Enabled = true;
                Stay43.Enabled = true;
                Origin_List[43] = 0;
            }
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox42.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat42.Enabled = false;
                Motor42.Enabled = false;
                Stay42.Enabled = false;
                Origin_List[42] = 42;
            }
            else
            {
                Seat42.Enabled = true;
                Motor42.Enabled = true;
                Stay42.Enabled = true;
                Origin_List[42] = 0;
            }
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox41.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat41.Enabled = false;
                Motor41.Enabled = false;
                Stay41.Enabled = false;
                Origin_List[41] = 41;
            }
            else
            {
                Seat41.Enabled = true;
                Motor41.Enabled = true;
                Stay41.Enabled = true;
                Origin_List[41] = 0;
            }
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat40.Enabled = false;
                Motor40.Enabled = false;
                Stay40.Enabled = false;
                Origin_List[40] = 40;
            }
            else
            {
                Seat40.Enabled = true;
                Motor40.Enabled = true;
                Stay40.Enabled = true;
                Origin_List[40] = 0;
            }
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox39.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat39.Enabled = false;
                Motor39.Enabled = false;
                Stay39.Enabled = false;
                Origin_List[39] = 39;
            }
            else
            {
                Seat39.Enabled = true;
                Motor39.Enabled = true;
                Stay39.Enabled = true;
                Origin_List[39] = 0;
            }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox38.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat38.Enabled = false;
                Motor38.Enabled = false;
                Stay38.Enabled = false;
                Origin_List[38] = 38;
            }
            else
            {
                Seat38.Enabled = true;
                Motor38.Enabled = true;
                Stay38.Enabled = true;
                Origin_List[38] = 0;
            }
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat37.Enabled = false;
                Motor37.Enabled = false;
                Stay37.Enabled = false;
                Origin_List[37] = 37;
            }
            else
            {
                Seat37.Enabled = true;
                Motor37.Enabled = true;
                Stay37.Enabled = true;
                Origin_List[37] = 0;
            }
        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox44.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat44.Enabled = false;
                Motor44.Enabled = false;
                Stay44.Enabled = false;
                Origin_List[44] = 44;
            }
            else
            {
                Seat44.Enabled = true;
                Motor4.Enabled = true;
                Stay44.Enabled = true;
                Origin_List[44] = 0;
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat35.Enabled = false;
                Motor35.Enabled = false;
                Stay35.Enabled = false;
                Origin_List[35] = 35;
            }
            else
            {
                Seat35.Enabled = true;
                Motor35.Enabled = true;
                Stay35.Enabled = true;
                Origin_List[35] = 0;
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat34.Enabled = false;
                Motor34.Enabled = false;
                Stay34.Enabled = false;
                Origin_List[34] = 34;
            }
            else
            {
                Seat34.Enabled = true;
                Motor34.Enabled = true;
                Stay34.Enabled = true;
                Origin_List[34] = 0;
            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat33.Enabled = false;
                Motor33.Enabled = false;
                Stay33.Enabled = false;
                Origin_List[33] = 33;
            }
            else
            {
                Seat33.Enabled = true;
                Motor33.Enabled = true;
                Stay33.Enabled = true;
                Origin_List[33] = 0;
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat32.Enabled = false;
                Motor32.Enabled = false;
                Stay32.Enabled = false;
                Origin_List[32] = 32;
            }
            else
            {
                Seat32.Enabled = true;
                Motor32.Enabled = true;
                Stay32.Enabled = true;
                Origin_List[32] = 0;
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat31.Enabled = false;
                Motor31.Enabled = false;
                Stay31.Enabled = false;
                Origin_List[31] = 31;
            }
            else
            {
                Seat31.Enabled = true;
                Motor31.Enabled = true;
                Stay31.Enabled = true;
                Origin_List[31] = 0;
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat30.Enabled = false;
                Motor30.Enabled = false;
                Stay30.Enabled = false;
                Origin_List[30] = 30;
            }
            else
            {
                Seat30.Enabled = true;
                Motor30.Enabled = true;
                Stay30.Enabled = true;
                Origin_List[30] = 0;
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat29.Enabled = false;
                Motor29.Enabled = false;
                Stay29.Enabled = false;
                Origin_List[29] = 29;
            }
            else
            {
                Seat29.Enabled = true;
                Motor29.Enabled = true;
                Stay29.Enabled = true;
                Origin_List[29] = 0;
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat28.Enabled = false;
                Motor28.Enabled = false;
                Stay28.Enabled = false;
                Origin_List[28] = 28;
            }
            else
            {
                Seat28.Enabled = true;
                Motor28.Enabled = true;
                Stay28.Enabled = true;
                Origin_List[28] = 0;
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat27.Enabled = false;
                Motor27.Enabled = false;
                Stay27.Enabled = false;
                Origin_List[27] = 27;
            }
            else
            {
                Seat27.Enabled = true;
                Motor27.Enabled = true;
                Stay27.Enabled = true;
                Origin_List[27] = 0;
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat26.Enabled = false;
                Motor26.Enabled = false;
                Stay26.Enabled = false;
                Origin_List[26] = 26;
            }
            else
            {
                Seat26.Enabled = true;
                Motor26.Enabled = true;
                Stay26.Enabled = true;
                Origin_List[26] = 0;
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat25.Enabled = false;
                Motor25.Enabled = false;
                Stay25.Enabled = false;
                Origin_List[25] = 25;
            }
            else
            {
                Seat25.Enabled = true;
                Motor25.Enabled = true;
                Stay25.Enabled = true;
                Origin_List[25] = 0;
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat24.Enabled = false;
                Motor24.Enabled = false;
                Stay24.Enabled = false;
                Origin_List[24] = 24;
            }
            else
            {
                Seat24.Enabled = true;
                Motor24.Enabled = true;
                Stay24.Enabled = true;
                Origin_List[24] = 0;
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat23.Enabled = false;
                Motor23.Enabled = false;
                Stay23.Enabled = false;
                Origin_List[23] = 23;
            }
            else
            {
                Seat23.Enabled = true;
                Motor23.Enabled = true;
                Stay23.Enabled = true;
                Origin_List[23] = 0;
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat22.Enabled = false;
                Motor22.Enabled = false;
                Stay22.Enabled = false;
                Origin_List[22] = 22;
            }
            else
            {
                Seat22.Enabled = true;
                Motor22.Enabled = true;
                Stay22.Enabled = true;
                Origin_List[22] = 0;
            }
        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox45.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat45.Enabled = false;
                Motor45.Enabled = false;
                Stay45.Enabled = false;
                Origin_List[45] = 45;
            }
            else
            {
                Seat45.Enabled = true;
                Motor45.Enabled = true;
                Stay45.Enabled = true;
                Origin_List[45] = 0;
            }
        }

        private void checkBox51_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox51.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat51.Enabled = false;
                Motor51.Enabled = false;
                Stay51.Enabled = false;
                Origin_List[51] = 51;
            }
            else
            {
                Seat51.Enabled = true;
                Motor51.Enabled = true;
                Stay51.Enabled = true;
                Origin_List[51] = 0;
            }
        }

        private void checkBox50_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox50.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat50.Enabled = false;
                Motor50.Enabled = false;
                Stay50.Enabled = false;
                Origin_List[50] = 50;
            }
            else
            {
                Seat50.Enabled = true;
                Motor50.Enabled = true;
                Stay50.Enabled = true;
                Origin_List[50] = 0;
            }
        }

        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox49.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat49.Enabled = false;
                Motor49.Enabled = false;
                Stay49.Enabled = false;
                Origin_List[49] = 49;
            }
            else
            {
                Seat49.Enabled = true;
                Motor49.Enabled = true;
                Stay49.Enabled = true;
                Origin_List[49] = 0;
            }
        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox48.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat48.Enabled = false;
                Motor48.Enabled = false;
                Stay48.Enabled = false;
                Origin_List[48] = 48;
            }
            else
            {
                Seat48.Enabled = true;
                Motor48.Enabled = true;
                Stay48.Enabled = true;
                Origin_List[48] = 0;
            }
        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox47.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat47.Enabled = false;
                Motor47.Enabled = false;
                Stay47.Enabled = false;
                Origin_List[47] = 47;
            }
            else
            {
                Seat47.Enabled = true;
                Motor47.Enabled = true;
                Stay47.Enabled = true;
                Origin_List[47] = 0;
            }
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox46.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat46.Enabled = false;
                Motor46.Enabled = false;
                Stay46.Enabled = false;
                Origin_List[46] = 46;
            }
            else
            {
                Seat46.Enabled = true;
                Motor46.Enabled = true;
                Stay46.Enabled = true;
                Origin_List[46] = 0;
            }
        }

        private void checkBox52_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox52.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat52.Enabled = false;
                Motor52.Enabled = false;
                Stay52.Enabled = false;
                Origin_List[52] = 52;
            }
            else
            {
                Seat52.Enabled = true;
                Motor52.Enabled = true;
                Stay52.Enabled = true;
                Origin_List[52] = 0;
            }
        }

        private void DR_Heat1_CheckedChanged(object sender, EventArgs e)
        {
            if(DR_Heat1.Checked)
            {
                Sig429_DrvStHtBkDtyCycl = 0x80;
                Sig429_DrvStHtCshnDtyCycl = 0x80;
            }
            else
            {
                Sig429_DrvStHtBkDtyCycl = 0;
                Sig429_DrvStHtCshnDtyCycl = 0;
            }
            SetHVdata(0x429);
            DR_HT = 1;
        }

        private void DR_Heat3_CheckedChanged(object sender, EventArgs e)
        {
            if (DR_Heat3.Checked)
            {
                Sig429_DrvStHtBkDtyCycl = 0xE6;
                Sig429_DrvStHtCshnDtyCycl = 0xE6;
            }
            else
            {
                Sig429_DrvStHtBkDtyCycl = 0;
                Sig429_DrvStHtCshnDtyCycl = 0;
            }
            SetHVdata(0x429);
            DR_HT = 3;
        }

        private void DR_Heat2_CheckedChanged(object sender, EventArgs e)
        {
            if (DR_Heat2.Checked)
            {
                Sig429_DrvStHtBkDtyCycl = 0xB3;
                Sig429_DrvStHtCshnDtyCycl = 0xB3;
            }
            else
            {
                Sig429_DrvStHtBkDtyCycl = 0;
                Sig429_DrvStHtCshnDtyCycl = 0;
            }
            SetHVdata(0x429);
            DR_HT = 2;
        }

        private void DR_HeatOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (DR_HeatOFF.Checked)
            {
                Sig429_DrvStHtBkDtyCycl = 0x00;
            }
            SetHVdata(0x429);
            DR_HT = 0;
        }

        private void PA_Heat1_CheckedChanged(object sender, EventArgs e)
        {
            if (PA_Heat1.Checked)
            {
                Sig429_PassStHtCshnDtyCycl = 0x80;
                Sig429_PassStHtBkDtyCycl = 0x80;
            }
            else
            {
                Sig429_PassStHtCshnDtyCycl = 0;
                Sig429_PassStHtBkDtyCycl = 0;
            }
            SetHVdata(0x429);
            PA_HT = 1;
        }

        private void PA_Heat3_CheckedChanged(object sender, EventArgs e)
        {
            if (PA_Heat3.Checked)
            {
                Sig429_PassStHtCshnDtyCycl = 0xE6;
                Sig429_PassStHtBkDtyCycl = 0xE6;
            }
            else
            {
                Sig429_PassStHtCshnDtyCycl = 0;
                Sig429_PassStHtBkDtyCycl = 0;
            }
            SetHVdata(0x429);
            PA_HT = 3;
        }

        private void PA_Heat2_CheckedChanged(object sender, EventArgs e)
        {
            if (PA_Heat2.Checked)
            {
                Sig429_PassStHtCshnDtyCycl = 0xB3;
                Sig429_PassStHtBkDtyCycl = 0xB3;
            }
            else
            {
                Sig429_PassStHtCshnDtyCycl = 0;
                Sig429_PassStHtBkDtyCycl = 0;
            }
            SetHVdata(0x429);
            PA_HT = 2;
        }

        private void PA_HeatOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (PA_HeatOFF.Checked)
            {
                Sig429_PassStHtCshnDtyCycl = 0x00;
                Sig429_PassStHtBkDtyCycl = 0x00;
            }
            SetHVdata(0x429);
            PA_HT = 0;
        }

        private void DR_Vent1_CheckedChanged(object sender, EventArgs e)
        {
            if (DR_Vent1.Checked)
            {
                Sig429_DrvStVntDtyCycl = 0xA9;
            }
            else
            {
                Sig429_DrvStVntDtyCycl = 0;
            }
            SetHVdata(0x429);
            DR_VT = 1;
        }

        private void DR_Vent3_CheckedChanged(object sender, EventArgs e)
        {
            if (DR_Vent3.Checked)
            {
                Sig429_DrvStVntDtyCycl = 0xE6;
            }
            else
            {
                Sig429_DrvStVntDtyCycl = 0;
            }
            SetHVdata(0x429);
            DR_VT = 3;
        }

        private void DR_Vent2_CheckedChanged(object sender, EventArgs e)
        {
            if (DR_Vent2.Checked)
            {
                Sig429_DrvStVntDtyCycl = 0xC2;
            }
            else
            {
                Sig429_DrvStVntDtyCycl = 0;
            }
            SetHVdata(0x429);
            DR_VT = 2;
        }

        private void DR_VentOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (DR_VentOFF.Checked)
            {
                Sig429_DrvStVntDtyCycl = 0x00;
            }
            SetHVdata(0x429);
            DR_VT = 0;
        }

        private void PA_Vent1_CheckedChanged(object sender, EventArgs e)
        {
            if (PA_Vent1.Checked)
            {
                Sig429_PassStVntDtyCycl = 0xA9;
            }
            else
            {
                Sig429_PassStVntDtyCycl = 0;
            }
            SetHVdata(0x429);
            PA_VT = 1;
        }

        private void PA_Vent3_CheckedChanged(object sender, EventArgs e)
        {
            if (PA_Vent3.Checked)
            {
                Sig429_PassStVntDtyCycl = 0xE6;
            }
            else
            {
                Sig429_PassStVntDtyCycl = 0;
            }
            SetHVdata(0x429);
            PA_VT = 3;
        }

        private void PA_Vent2_CheckedChanged(object sender, EventArgs e)
        {
            if (PA_Vent2.Checked)
            {
                Sig429_PassStVntDtyCycl = 0xC2;
            }
            else
            {
                Sig429_PassStVntDtyCycl = 0;
            }
            SetHVdata(0x429);
            PA_VT = 2;
        }

        private void PA_VentOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (PA_VentOFF.Checked)
            {
                Sig429_PassStVntDtyCycl = 0x00;
            }
            SetHVdata(0x429);
            PA_VT = 0;
        }

        private void R2_Heat1_CheckedChanged(object sender, EventArgs e)
        {
            if (R2_Heat1.Checked)
            {
                Sig426_SecRwRtStHtCshnDtyCycl = 0x80;
                Sig426_SecRwRtStHtBkDtyCycl = 0x80;
            }
            else
            {
                Sig426_SecRwRtStHtCshnDtyCycl = 0;
                Sig426_SecRwRtStHtBkDtyCycl = 0;
            }
            SetHVdata(0x426);
            R2_HT = 1;
        }

        private void R2_Heat3_CheckedChanged(object sender, EventArgs e)
        {
            if (R2_Heat3.Checked)
            {
                Sig426_SecRwRtStHtCshnDtyCycl = 0xE6;
                Sig426_SecRwRtStHtBkDtyCycl = 0xE6;
            }
            else
            {
                Sig426_SecRwRtStHtCshnDtyCycl = 0;
                Sig426_SecRwRtStHtBkDtyCycl = 0;
            }
            SetHVdata(0x426);
            R2_HT = 3; 
        }

        private void R2_Heat2_CheckedChanged(object sender, EventArgs e)
        {
            if (R2_Heat2.Checked)
            {
                Sig426_SecRwRtStHtCshnDtyCycl = 0xB3;
                Sig426_SecRwRtStHtBkDtyCycl = 0xB3;
            }
            else
            {
                Sig426_SecRwRtStHtCshnDtyCycl = 0;
                Sig426_SecRwRtStHtBkDtyCycl = 0;
            }
            SetHVdata(0x426);
            R2_HT = 2;
        }

        private void R2_HeatOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (R2_HeatOFF.Checked)
            {
                Sig426_SecRwRtStHtCshnDtyCycl = 0x00;
                Sig426_SecRwRtStHtBkDtyCycl = 0x00;
            }
            SetHVdata(0x426);
            R2_HT = 0;
        }

        private void R2_Vent1_CheckedChanged(object sender, EventArgs e)
        {
            if (R2_Vent1.Checked)
            {
                Sig426_SecRwRtStVntDtyCycl = 0xA9;
            }
            else
            {
                Sig426_SecRwRtStVntDtyCycl = 0;
            }
            SetHVdata(0x426);
            R2_VT = 1;
        }

        private void R2_Vent3_CheckedChanged(object sender, EventArgs e)
        {
            if (R2_Vent3.Checked)
            {
                Sig426_SecRwRtStVntDtyCycl = 0xE6;
            }
            else
            {
                Sig426_SecRwRtStVntDtyCycl = 0;
            }
            SetHVdata(0x426);
            R2_VT = 3;
        }

        private void R2_Vent2_CheckedChanged(object sender, EventArgs e)
        {
            if (R2_Vent2.Checked)
            {
                Sig426_SecRwRtStVntDtyCycl = 0xC2;
            }
            else
            {
                Sig426_SecRwRtStVntDtyCycl = 0;
            }
            SetHVdata(0x426);
            R2_VT = 2;
        }

        private void R2_VentOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (R2_VentOFF.Checked)
            {
                Sig426_SecRwRtStVntDtyCycl = 0x00;
            }
            SetHVdata(0x426);
            R2_VT = 0;
        }

        private void L3_Heat1_CheckedChanged(object sender, EventArgs e)
        {
            if (L3_Heat1.Checked)
            {
                Sig488_ThdRwLtStHtCshnDtyCycl = 0x80;
                Sig488_ThdRwLtStHtBkDtyCycl = 0x80;
            }
            else
            {
                Sig488_ThdRwLtStHtCshnDtyCycl = 0;
                Sig488_ThdRwLtStHtBkDtyCycl = 0;
            }
            SetHVdata(0x488);
            L3_HT = 1;
        }

        private void L3_Heat3_CheckedChanged(object sender, EventArgs e)
        {
            if (L3_Heat3.Checked)
            {
                Sig488_ThdRwLtStHtCshnDtyCycl = 0xE6;
                Sig488_ThdRwLtStHtBkDtyCycl = 0xE6;
            }
            else
            {
                Sig488_ThdRwLtStHtCshnDtyCycl = 0;
                Sig488_ThdRwLtStHtBkDtyCycl = 0;
            }
            SetHVdata(0x488);
            L3_HT = 3;
        }

        private void L3_Heat2_CheckedChanged(object sender, EventArgs e)
        {
            if (L3_Heat2.Checked)
            {
                Sig488_ThdRwLtStHtCshnDtyCycl = 0xB3;
                Sig488_ThdRwLtStHtBkDtyCycl = 0xB3;
            }
            else
            {
                Sig488_ThdRwLtStHtCshnDtyCycl = 0;
                Sig488_ThdRwLtStHtBkDtyCycl = 0;
            }
            SetHVdata(0x488);
            L3_HT = 2;
        }

        private void L3_HeatOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (L3_HeatOFF.Checked)
            {
                Sig488_ThdRwLtStHtCshnDtyCycl = 0x00;
                Sig488_ThdRwLtStHtBkDtyCycl = 0x00;
            }
            SetHVdata(0x488);
            L3_HT = 0;
        }

        private void L3_Vent1_CheckedChanged(object sender, EventArgs e)
        {
            if (L3_Vent1.Checked)
            {
                Sig488_ThdRwLtStVntDtyCycl = 0xA9;
            }
            else
            {
                Sig488_ThdRwLtStVntDtyCycl = 0;
            }
            SetHVdata(0x426);
            L3_VT = 1;
        }

        private void L3_Vent3_CheckedChanged(object sender, EventArgs e)
        {
            if (L3_Vent3.Checked)
            {
                Sig488_ThdRwLtStVntDtyCycl = 0xE6;
            }
            else
            {
                Sig488_ThdRwLtStVntDtyCycl = 0;
            }
            SetHVdata(0x426);
            L3_VT = 3;
        }

        private void L3_Vent2_CheckedChanged(object sender, EventArgs e)
        {
            if (L3_Vent2.Checked)
            {
                Sig488_ThdRwLtStVntDtyCycl = 0xC2;
            }
            else
            {
                Sig488_ThdRwLtStVntDtyCycl = 0;
            }
            SetHVdata(0x426);
            L3_VT = 2;
        }

        private void L3_VentOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (L3_VentOFF.Checked)
            {
                Sig488_ThdRwLtStVntDtyCycl = 0x00;
            }
            SetHVdata(0x488);
            L3_VT = 0;
        }

        private void R3_Heat1_CheckedChanged(object sender, EventArgs e)
        {
            if (R3_Heat1.Checked)
            {
                Sig488_ThdRwRtStHtCshnDtyCycl = 0x80;
                Sig488_ThdRwRtStHtBkDtyCycl = 0x80;
            }
            else
            {
                Sig488_ThdRwRtStHtCshnDtyCycl = 0;
                Sig488_ThdRwRtStHtBkDtyCycl = 0;
            }
            SetHVdata(0x488);
            R3_HT = 1;
        }

        private void R3_Heat3_CheckedChanged(object sender, EventArgs e)
        {
            if (R3_Heat3.Checked)
            {
                Sig488_ThdRwRtStHtCshnDtyCycl = 0xE6;
                Sig488_ThdRwRtStHtBkDtyCycl = 0xE6;
            }
            else
            {
                Sig488_ThdRwRtStHtCshnDtyCycl = 0;
                Sig488_ThdRwRtStHtBkDtyCycl = 0;
            }
            SetHVdata(0x488);
            R3_HT = 3;
        }

        private void R3_Heat2_CheckedChanged(object sender, EventArgs e)
        {
            if (R3_Heat2.Checked)
            {
                Sig488_ThdRwRtStHtCshnDtyCycl = 0xB3;
                Sig488_ThdRwRtStHtBkDtyCycl = 0xB3;
            }
            else
            {
                Sig488_ThdRwRtStHtCshnDtyCycl = 0;
                Sig488_ThdRwRtStHtBkDtyCycl = 0;
            }
            SetHVdata(0x488);
            R3_HT = 2;
        }

        private void R3_HeatOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (R3_HeatOFF.Checked)
            {
                Sig488_ThdRwRtStHtCshnDtyCycl = 0x00;
                Sig488_ThdRwRtStHtBkDtyCycl = 0x00;
            }
            SetHVdata(0x488);
            R3_HT = 0;
        }

        private void R3_Vent1_CheckedChanged(object sender, EventArgs e)
        {
            if (R3_Vent1.Checked)
            {
                Sig488_ThdRwRtStVntDtyCycl = 0xA9;
            }
            else
            {
                Sig488_ThdRwRtStVntDtyCycl = 0;
            }
            SetHVdata(0x488);
            R3_VT = 1;
        }

        private void R3_Vent3_CheckedChanged(object sender, EventArgs e)
        {
            if (R3_Vent3.Checked)
            {
                Sig488_ThdRwRtStVntDtyCycl = 0xE6;
            }
            else
            {
                Sig488_ThdRwRtStVntDtyCycl = 0;
            }
            SetHVdata(0x488);
            R3_VT = 3;
        }

        private void R3_Vent2_CheckedChanged(object sender, EventArgs e)
        {
            if (R3_Vent2.Checked)
            {
                Sig488_ThdRwRtStVntDtyCycl = 0xC2;
            }
            else
            {
                Sig488_ThdRwRtStVntDtyCycl = 0;
            }
            SetHVdata(0x488);
            R3_VT = 2;
        }

        private void R3_VentOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (R3_VentOFF.Checked)
            {
                Sig488_ThdRwRtStVntDtyCycl = 0x00;
            }
            SetHVdata(0x488);
            R3_VT = 0;
        }

        private void SecRwRtStMassMdHMI2RReq_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sig383_SecRwRtStMassMdHMI2RReq = (byte)SecRwRtStMassMdHMI2RReq.SelectedIndex;
            SetHVdata(0x383);
        }

        private void SecRwRtStMassStrsHMI2RReq_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sig383_SecRwRtStMassStrsHMI2RReq = (byte)SecRwRtStMassStrsHMI2RReq.SelectedIndex;
            SetHVdata(0x383);
        }

        private void L_SeatFrwdCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (L_SeatFrwdCustSeltn.Checked == true)
            {
                Sig_L_SeatFrwdCustSeltn = 1;
            }
            else
            {
                Sig_L_SeatFrwdCustSeltn = 0;
            }
            Get_LinData(0);
        }

        private void L_SeatRrwdCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (L_SeatRrwdCustSeltn.Checked == true)
            {
                Sig_L_SeatRrwdCustSeltn = 1;
            }
            else
            {
                Sig_L_SeatRrwdCustSeltn = 0;
            }
            Get_LinData(0);
        }

        private void L_CushFrtUpCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (L_CushFrtUpCustSeltn.Checked == true)
            {
                Sig_L_CushFrtUpCustSeltn = 1;
            }
            else
            {
                Sig_L_CushFrtUpCustSeltn = 0;
            }
            Get_LinData(0);
        }

        private void L_CushFrtDwnCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (L_CushFrtDwnCustSeltn.Checked == true)
            {
                Sig_L_CushFrtDwnCustSeltn = 1;
            }
            else
            {
                Sig_L_CushFrtDwnCustSeltn = 0;
            }
            Get_LinData(0);
        }

        private void L_CushRrUpCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (L_CushRrUpCustSeltn.Checked == true)
            {
                Sig_L_CushRrUpCustSeltn = 1;
            }
            else
            {
                Sig_L_CushRrUpCustSeltn = 0;
            }
            Get_LinData(0);
        }

        private void L_CushRrDwnCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (L_CushRrDwnCustSeltn.Checked == true)
            {
                Sig_L_CushRrDwnCustSeltn = 1;
            }
            else
            {
                Sig_L_CushRrDwnCustSeltn = 0;
            }
            Get_LinData(0);
        }

        private void L_ReclineFrwdCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (L_ReclineFrwdCustSeltn.Checked == true)
            {
                Sig_L_ReclineFrwdCustSeltn = 1;
            }
            else
            {
                Sig_L_ReclineFrwdCustSeltn = 0;
            }
            Get_LinData(0);
        }

        private void L_ReclineRrwdCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (L_ReclineRrwdCustSeltn.Checked == true)
            {
                Sig_L_ReclineRrwdCustSeltn = 1;
            }
            else
            {
                Sig_L_ReclineRrwdCustSeltn = 0;
            }
            Get_LinData(0);
        }

        private void LtStFtUpwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (LtStFtUpwdHMI2LReq.Checked == true)
            {
                Sig_L_LtStFtUpwdHMI2LReq = 1;
            }
            else
            {
                Sig_L_LtStFtUpwdHMI2LReq = 0;
            }
            SetHVdata(0x382);
        }

        private void LtStFtDnwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (LtStFtDnwdHMI2LReq.Checked == true)
            {
                Sig_L_LtStFtDnwdHMI2LReq = 1;
            }
            else
            {
                Sig_L_LtStFtDnwdHMI2LReq = 0;
            }
            SetHVdata(0x382);
        }

        private void R_SeatFrwdCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (R_SeatFrwdCustSeltn.Checked == true)
            {
                Sig_R_SeatFrwdCustSeltn = 1;
            }
            else
            {
                Sig_R_SeatFrwdCustSeltn = 0;
            }
            Get_LinData(1);
        }

        private void R_SeatRrwdCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (R_SeatRrwdCustSeltn.Checked == true)
            {
                Sig_R_SeatRrwdCustSeltn = 1;
            }
            else
            {
                Sig_R_SeatRrwdCustSeltn = 0;
            }
            Get_LinData(1);
        }

        private void R_CushFrtUpCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (R_CushFrtUpCustSeltn.Checked == true)
            {
                Sig_R_CushFrtUpCustSeltn = 1;
            }
            else
            {
                Sig_R_CushFrtUpCustSeltn = 0;
            }
            Get_LinData(1);
        }

        private void R_CushFrtDwnCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (R_CushFrtDwnCustSeltn.Checked == true)
            {
                Sig_R_CushFrtDwnCustSeltn = 1;
            }
            else
            {
                Sig_R_CushFrtDwnCustSeltn = 0;
            }
            Get_LinData(1);
        }

        private void R_CushRrUpCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (R_CushRrUpCustSeltn.Checked == true)
            {
                Sig_R_CushRrUpCustSeltn = 1;
            }
            else
            {
                Sig_R_CushRrUpCustSeltn = 0;
            }
            Get_LinData(1);
        }

        private void R_CushRrDwnCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (R_CushRrDwnCustSeltn.Checked == true)
            {
                Sig_R_CushRrDwnCustSeltn = 1;
            }
            else
            {
                Sig_R_CushRrDwnCustSeltn = 0;
            }
            Get_LinData(1);
        }

        private void R_ReclineFrwdCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (R_ReclineFrwdCustSeltn.Checked == true)
            {
                Sig_R_ReclineFrwdCustSeltn = 1;
            }
            else
            {
                Sig_R_ReclineFrwdCustSeltn = 0;
            }
            Get_LinData(1);
        }

        private void R_ReclineRrwdCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if (R_ReclineRrwdCustSeltn.Checked == true)
            {
                Sig_R_ReclineRrwdCustSeltn = 1;
            }
            else
            {
                Sig_R_ReclineRrwdCustSeltn = 0;
            }
            Get_LinData(1);
        }

        private void RtStFtUpwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (RtStFtUpwdHMI2LReq.Checked == true)
            {
                Sig383_2R_SecRwRtStFtUpwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStFtUpwdHMI2RReq = 0;
            }
            SetHVdata(0x383);
        }

        private void RtStFtDnwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (RtStFtDnwdHMI2LReq.Checked == true)
            {
                Sig383_2R_SecRwRtStFtDnwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStFtDnwdHMI2RReq = 0;
            }
            SetHVdata(0x383);
        }

        private void SPS_2L_SecRwStFrwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2L_SecRwStFrwdSwActv.Checked == true)
            {
                Sig_SPS_2L_SecRwStFrwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2L_SecRwStFrwdSwActv = 0;
            }
            Get_LinData(2);
        }

        private void SPS_2L_SecRwStBkwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2L_SecRwStBkwdSwActv.Checked == true)
            {
                Sig_SPS_2L_SecRwStBkwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2L_SecRwStBkwdSwActv = 0;
            }
            Get_LinData(2);
        }

        private void SPS_2L_SecRwStBkReclnUpwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2L_SecRwStBkReclnUpwdSwActv.Checked == true)
            {
                Sig_SPS_2L_SecRwStBkReclnUpwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2L_SecRwStBkReclnUpwdSwActv = 0;
            }
            Get_LinData(2);
        }

        private void SPS_2L_SecRwStBkReclnDnwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2L_SecRwStBkReclnDnwdSwActv.Checked == true)
            {
                Sig_SPS_2L_SecRwStBkReclnDnwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2L_SecRwStBkReclnDnwdSwActv = 0;
            }
            Get_LinData(2);
        }

        private void SPS_2L_SecRwStLgrstUpwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2L_SecRwStLgrstUpwdSwActv.Checked == true)
            {
                Sig_SPS_2L_SecRwStLgrstUpwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2L_SecRwStLgrstUpwdSwActv = 0;
            }
            Get_LinData(2);
        }

        private void SPS_2L_SecRwStLgrstDnwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2L_SecRwStLgrstDnwdSwActv.Checked == true)
            {
                Sig_SPS_2L_SecRwStLgrstDnwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2L_SecRwStLgrstDnwdSwActv = 0;
            }
            Get_LinData(2);
        }

        private void L_SecRwLtStArmScrnHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (L_SecRwLtStArmScrnHMI2LReq.Checked == true)
            {
                Sig_SecRwLtStArmScrnHMI2LReq = 1;
            }
            else
            {
                Sig_SecRwLtStArmScrnHMI2LReq = 0;
            }
            SetHVdata(0x382);
        }

        private void SPS_2R_SecRwStFrwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2R_SecRwStFrwdSwActv.Checked == true)
            {
                Sig_SPS_2R_SecRwStFrwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2R_SecRwStFrwdSwActv = 0;
            }
            Get_LinData(3);
        }

        private void SPS_2R_SecRwStBkwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2R_SecRwStBkwdSwActv.Checked == true)
            {
                Sig_SPS_2R_SecRwStBkwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2R_SecRwStBkwdSwActv = 0;
            }
            Get_LinData(3);
        }

        private void SPS_2R_SecRwStBkReclnUpwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2R_SecRwStBkReclnUpwdSwActv.Checked == true)
            {
                Sig_SPS_2R_SecRwStBkReclnUpwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2R_SecRwStBkReclnUpwdSwActv = 0;
            }
            Get_LinData(3);
        }

        private void SPS_2R_SecRwStBkReclnDnwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2R_SecRwStBkReclnDnwdSwActv.Checked == true)
            {
                Sig_SPS_2R_SecRwStBkReclnDnwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2R_SecRwStBkReclnDnwdSwActv = 0;
            }
            Get_LinData(3);
        }

        private void SPS_2R_SecRwStLgrstUpwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2R_SecRwStLgrstUpwdSwActv.Checked == true)
            {
                Sig_SPS_2R_SecRwStLgrstUpwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2R_SecRwStLgrstUpwdSwActv = 0;
            }
            Get_LinData(3);
        }

        private void SPS_2R_SecRwStLgrstDnwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_2R_SecRwStLgrstDnwdSwActv.Checked == true)
            {
                Sig_SPS_2R_SecRwStLgrstDnwdSwActv = 1;
            }
            else
            {
                Sig_SPS_2R_SecRwStLgrstDnwdSwActv = 0;
            }
            Get_LinData(3);
        }

        private void R_SecRwRtStArmScrnHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (R_SecRwRtStArmScrnHMI2RReq.Checked == true)
            {
                Sig_SecRwRtStArmScrnHMI2RReq = 1;
            }
            else
            {
                Sig_SecRwRtStArmScrnHMI2RReq = 0;
            }
            SetHVdata(0x383);
        }

        private void SPS_3L_AcsMdExtRclSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3L_AcsMdExtRclSwActv.Checked == true)
            {
                Sig_SPS_3L_AcsMdExtRclSwActv = 1;
            }
            else
            {
                Sig_SPS_3L_AcsMdExtRclSwActv = 0;
            }
            Get_LinData(4);
        }

        private void SPS_3L_ThdRStExpdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3L_ThdRStExpdSwActv.Checked == true)
            {
                Sig_SPS_3L_ThdRStExpdSwActv = 1;
            }
            else
            {
                Sig_SPS_3L_ThdRStExpdSwActv = 0;
            }
            Get_LinData(4);
        }

        private void SPS_3L_ThdRStFrwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3L_ThdRStFrwdSwActv.Checked == true)
            {
                Sig_SPS_3L_ThdRStFrwdSwActv = 1;
            }
            else
            {
                Sig_SPS_3L_ThdRStFrwdSwActv = 0;
            }
            Get_LinData(4);
        }

        private void SPS_3L_ThdRStBkwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3L_ThdRStBkwdSwActv.Checked == true)
            {
                Sig_SPS_3L_ThdRStBkwdSwActv = 1;
            }
            else
            {
                Sig_SPS_3L_ThdRStBkwdSwActv = 0;
            }
            Get_LinData(4);
        }

        private void SPS_3L_ThdRwStBkReclnUpwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3L_ThdRwStBkReclnUpwdSwActv.Checked == true)
            {
                Sig_SPS_3L_ThdRwStBkReclnUpwdSwActv = 1;
            }
            else
            {
                Sig_SPS_3L_ThdRwStBkReclnUpwdSwActv = 0;
            }
            Get_LinData(4);
        }

        private void SPS_3L_ThdRwStBkReclnDnwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3L_ThdRwStBkReclnDnwdSwActv.Checked == true)
            {
                Sig_SPS_3L_ThdRwStBkReclnDnwdSwActv = 1;
            }
            else
            {
                Sig_SPS_3L_ThdRwStBkReclnDnwdSwActv = 0;
            }
            Get_LinData(4);
        }

        private void SPS_3R_AcsMdExtRtRclSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3R_AcsMdExtRtRclSwActv.Checked == true)
            {
                Sig_SPS_3R_AcsMdExtRtRclSwActv = 1;
            }
            else
            {
                Sig_SPS_3R_AcsMdExtRtRclSwActv = 0;
            }
            Get_LinData(5);
        }

        private void SPS_3R_ThdRRtStExpdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3R_ThdRRtStExpdSwActv.Checked == true)
            {
                Sig_SPS_3R_ThdRRtStExpdSwActv = 1;
            }
            else
            {
                Sig_SPS_3R_ThdRRtStExpdSwActv = 0;
            }
            Get_LinData(5);
        }

        private void SPS_3R_ThdRwRtStFrwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3R_ThdRwRtStFrwdSwActv.Checked == true)
            {
                Sig_SPS_3R_ThdRwRtStFrwdSwActv = 1;
            }
            else
            {
                Sig_SPS_3R_ThdRwRtStFrwdSwActv = 0;
            }
            Get_LinData(5);
        }

        private void SPS_3R_ThdRwRtStBkwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3R_ThdRwRtStBkwdSwActv.Checked == true)
            {
                Sig_SPS_3R_ThdRwRtStBkwdSwActv = 1;
            }
            else
            {
                Sig_SPS_3R_ThdRwRtStBkwdSwActv = 0;
            }
            Get_LinData(5);
        }

        private void SPS_3R_ThdRwRtStBkReclnUpwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3R_ThdRwRtStBkReclnUpwdSwActv.Checked == true)
            {
                Sig_SPS_3R_ThdRwRtStBkReclnUpwdSwActv = 1;
            }
            else
            {
                Sig_SPS_3R_ThdRwRtStBkReclnUpwdSwActv = 0;
            }
            Get_LinData(5);
        }

        private void SPS_3R_ThdRwRtStBkReclnDnwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            if (SPS_3R_ThdRwRtStBkReclnDnwdSwActv.Checked == true)
            {
                Sig_SPS_3R_ThdRwRtStBkReclnDnwdSwActv = 1;
            }
            else
            {
                Sig_SPS_3R_ThdRwRtStBkReclnDnwdSwActv = 0;
            }
            Get_LinData(5);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string data = label11.Text + "\t" + CycleTimes.Text + "\t" + FinishCount.Text + "\t" + textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text + "\t" + textBox4.Text + "\t" + textBox5.Text + "\t" + DR_HT + "\t" + DR_VT + "\t" + PA_HT + "\t" + PA_VT + "\t" + R2_HT + "\t" + R2_VT + "\t" + L3_HT + "\t" + L3_VT + "\t" + R3_HT + "\t" + R3_VT + "\t" + Seat1.Text + "\t" + Motor1.Text + "\t" + Stay1.Text + "\t" + Seat2.Text + "\t" + Motor2.Text + "\t" + Stay2.Text + "\t" + Seat3.Text + "\t" + Motor3.Text + "\t" + Stay3.Text + "\t" + Seat4.Text + "\t" + Motor4.Text + "\t" + Stay4.Text + "\t" + Seat5.Text + "\t" + Motor5.Text + "\t" + Stay5.Text + "\t" + Seat6.Text + "\t" + Motor6.Text + "\t" + Stay6.Text + "\t" + Seat7.Text + "\t" + Motor7.Text + "\t" + Stay7.Text + "\t" + Seat8.Text + "\t" + Motor8.Text + "\t" + Stay8.Text + "\t" + Seat9.Text + "\t" + Motor9.Text + "\t" + Stay9.Text + "\t" + Seat10.Text + "\t" + Motor10.Text + "\t" + Stay10.Text + "\t" + Seat11.Text + "\t" + Motor11.Text + "\t" + Stay11.Text + "\t" + Seat12.Text + "\t" + Motor12.Text + "\t" + Stay12.Text + "\t" + Seat13.Text + "\t" + Motor13.Text + "\t" + Stay13.Text + "\t" + Seat14.Text + "\t" + Motor14.Text + "\t" + Stay14.Text + "\t" + Seat15.Text + "\t" + Motor15.Text + "\t" + Stay15.Text + "\t" + Seat16.Text + "\t" + Motor16.Text + "\t" + Stay16.Text + "\t" + Seat17.Text + "\t" + Motor17.Text + "\t" + Stay17.Text + "\t" + Seat18.Text + "\t" + Motor18.Text + "\t" + Stay18.Text + "\t" + Seat19.Text + "\t" + Motor19.Text + "\t" + Stay19.Text + "\t" + Seat20.Text + "\t" + Motor20.Text + "\t" + Stay20.Text + "\t" + Seat21.Text + "\t" + Motor21.Text + "\t" + Stay21.Text + "\t" + Seat22.Text + "\t" + Motor22.Text + "\t" + Stay22.Text + "\t" + Seat23.Text + "\t" + Motor23.Text + "\t" + Stay23.Text + "\t" + Seat24.Text + "\t" + Motor24.Text + "\t" + Stay24.Text + "\t" + Seat25.Text + "\t" + Motor25.Text + "\t" + Stay25.Text + "\t" + Seat26.Text + "\t" + Motor26.Text + "\t" + Stay26.Text + "\t" + Seat27.Text + "\t" + Motor27.Text + "\t" + Stay27.Text + "\t" + Seat28.Text + "\t" + Motor28.Text + "\t" + Stay28.Text + "\t" + Seat29.Text + "\t" + Motor29.Text + "\t" + Stay29.Text + "\t" + Seat30.Text + "\t" + Motor30.Text + "\t" + Stay30.Text + "\t" + Seat31.Text + "\t" + Motor31.Text + "\t" + Stay31.Text + "\t" + Seat32.Text + "\t" + Motor32.Text + "\t" + Stay32.Text + "\t" + Seat33.Text + "\t" + Motor33.Text + "\t" + Stay33.Text + "\t" + Seat34.Text + "\t" + Motor34.Text + "\t" + Stay34.Text + "\t" + Seat35.Text + "\t" + Motor35.Text + "\t" + Stay35.Text + "\t" + Seat36.Text + "\t" + Motor36.Text + "\t" + Stay36.Text + "\t" + Seat37.Text + "\t" + Motor37.Text + "\t" + Stay37.Text + "\t" + Seat38.Text + "\t" + Motor38.Text + "\t" + Stay38.Text + "\t" + Seat39.Text + "\t" + Motor39.Text + "\t" + Stay39.Text + "\t" + Seat40.Text + "\t" + Motor40.Text + "\t" + Stay40.Text + "\t" + Seat41.Text + "\t" + Motor41.Text + "\t" + Stay41.Text + "\t" + Seat42.Text + "\t" + Motor42.Text + "\t" + Stay42.Text + "\t" + Seat43.Text + "\t" + Motor43.Text + "\t" + Stay43.Text + "\t" + Seat44.Text + "\t" + Motor44.Text + "\t" + Stay44.Text + "\t" + Seat45.Text + "\t" + Motor45.Text + "\t" + Stay45.Text + "\t" + Seat46.Text + "\t" + Motor46.Text + "\t" + Stay46.Text + "\t" + Seat47.Text + "\t" + Motor47.Text + "\t" + Stay47.Text + "\t" + Seat48.Text + "\t" + Motor48.Text + "\t" + Stay48.Text + "\t" + Seat49.Text + "\t" + Motor49.Text + "\t" + Stay49.Text + "\t" + Seat50.Text + "\t" + Motor50.Text + "\t" + Stay50.Text + "\t" + Seat51.Text + "\t" + Motor51.Text + "\t" + Stay51.Text + "\t" + Seat52.Text + "\t" + Motor52.Text + "\t" + Stay52.Text;
            //string TopRow = "时间" + "\t" + "循环次数" + "\t" + "完成次数" + "\t" + "项目名称" + "\t" + "实验名称" + "\t" + "实验样品" + "\t" + "温度" + "\t" + "湿度" + "\t" + String_repeat(52, "座椅电机" + "\t" + "起始位置" + "\t" + "目标位置" + "\t" + "停留时间" + "\t");
            appendData(LogFileName, true, data);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FinishCount.Value = 0;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            Seat1.Text = "";
            Seat2.Text = "";
            Seat3.Text = "";
            Seat4.Text = "";
            Seat5.Text = "";
            Seat6.Text = "";
            Seat7.Text = "";
            Seat8.Text = "";
            Seat9.Text = "";
            Seat10.Text = "";
            Seat11.Text = "";
            Seat12.Text = "";
            Seat13.Text = "";
            Seat14.Text = "";
            Seat15.Text = "";
            Seat16.Text = "";
            Seat17.Text = "";
            Seat18.Text = "";
            Seat19.Text = "";
            Seat20.Text = "";
            Seat21.Text = "";
            Seat22.Text = "";
            Seat23.Text = "";
            Seat24.Text = "";
            Seat25.Text = "";
            Seat26.Text = "";
            Seat27.Text = "";
            Seat28.Text = "";
            Seat29.Text = "";
            Seat30.Text = "";
            Seat31.Text = "";
            Seat32.Text = "";
            Seat33.Text = "";
            Seat34.Text = "";
            Seat35.Text = "";
            Seat36.Text = "";
            Seat37.Text = "";
            Seat38.Text = "";
            Seat39.Text = "";
            Seat40.Text = "";
            Seat41.Text = "";
            Seat42.Text = "";
            Seat43.Text = "";
            Seat44.Text = "";
            Seat45.Text = "";
            Seat46.Text = "";
            Seat47.Text = "";
            Seat48.Text = "";
            Seat49.Text = "";
            Seat50.Text = "";
            Seat51.Text = "";
            Seat52.Text = "";

            Motor1.Text = "";
            Motor2.Text = "";
            Motor3.Text = "";
            Motor4.Text = "";
            Motor5.Text = "";
            Motor6.Text = "";
            Motor7.Text = "";
            Motor8.Text = "";
            Motor9.Text = "";
            Motor10.Text = "";
            Motor11.Text = "";
            Motor12.Text = "";
            Motor13.Text = "";
            Motor14.Text = "";
            Motor15.Text = "";
            Motor16.Text = "";
            Motor17.Text = "";
            Motor18.Text = "";
            Motor19.Text = "";
            Motor20.Text = "";
            Motor21.Text = "";
            Motor22.Text = "";
            Motor23.Text = "";
            Motor24.Text = "";
            Motor25.Text = "";
            Motor26.Text = "";
            Motor27.Text = "";
            Motor28.Text = "";
            Motor29.Text = "";
            Motor30.Text = "";
            Motor31.Text = "";
            Motor32.Text = "";
            Motor33.Text = "";
            Motor34.Text = "";
            Motor35.Text = "";
            Motor36.Text = "";
            Motor37.Text = "";
            Motor38.Text = "";
            Motor39.Text = "";
            Motor40.Text = "";
            Motor41.Text = "";
            Motor42.Text = "";
            Motor43.Text = "";
            Motor44.Text = "";
            Motor45.Text = "";
            Motor46.Text = "";
            Motor47.Text = "";
            Motor48.Text = "";
            Motor49.Text = "";
            Motor50.Text = "";
            Motor51.Text = "";
            Motor52.Text = "";

            Stay1.Text = "";
            Stay2.Text = "";
            Stay3.Text = "";
            Stay4.Text = "";
            Stay5.Text = "";
            Stay6.Text = "";
            Stay7.Text = "";
            Stay8.Text = "";
            Stay9.Text = "";
            Stay10.Text = "";
            Stay11.Text = "";
            Stay12.Text = "";
            Stay13.Text = "";
            Stay14.Text = "";
            Stay15.Text = "";
            Stay16.Text = "";
            Stay17.Text = "";
            Stay18.Text = "";
            Stay19.Text = "";
            Stay20.Text = "";
            Stay21.Text = "";
            Stay22.Text = "";
            Stay23.Text = "";
            Stay24.Text = "";
            Stay25.Text = "";
            Stay26.Text = "";
            Stay27.Text = "";
            Stay28.Text = "";
            Stay29.Text = "";
            Stay30.Text = "";
            Stay31.Text = "";
            Stay32.Text = "";
            Stay33.Text = "";
            Stay34.Text = "";
            Stay35.Text = "";
            Stay36.Text = "";
            Stay37.Text = "";
            Stay38.Text = "";
            Stay39.Text = "";
            Stay40.Text = "";
            Stay41.Text = "";
            Stay42.Text = "";
            Stay43.Text = "";
            Stay44.Text = "";
            Stay45.Text = "";
            Stay46.Text = "";
            Stay47.Text = "";
            Stay48.Text = "";
            Stay49.Text = "";
            Stay50.Text = "";
            Stay51.Text = "";
            Stay52.Text = "";
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat11.Enabled = false;
                Motor11.Enabled = false;
                Stay11.Enabled = false;
                Origin_List[11] = 11;
            }
            else
            {
                Seat11.Enabled = true;
                Motor11.Enabled = true;
                Stay11.Enabled = true;
                Origin_List[11] = 0;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat10.Enabled = false;
                Motor10.Enabled = false;
                Stay10.Enabled = false;
                Origin_List[10] = 10;
            }
            else
            {
                Seat10.Enabled = true;
                Motor10.Enabled = true;
                Stay10.Enabled = true;
                Origin_List[10] = 0;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat9.Enabled = false;
                Motor9.Enabled = false;
                Stay9.Enabled = false;
                Origin_List[9] = 9;
            }
            else
            {
                Seat9.Enabled = true;
                Motor9.Enabled = true;
                Stay9.Enabled = true;
                Origin_List[9] = 0;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat8.Enabled = false;
                Motor8.Enabled = false;
                Stay8.Enabled = false;
                Origin_List[8] = 8;
            }
            else
            {
                Seat8.Enabled = true;
                Motor8.Enabled = true;
                Stay8.Enabled = true;
                Origin_List[8] = 0;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat7.Enabled = false;
                Motor7.Enabled = false;
                Stay7.Enabled = false;
                Origin_List[7] = 7;
            }
            else
            {
                Seat7.Enabled = true;
                Motor7.Enabled = true;
                Stay7.Enabled = true;
                Origin_List[7] = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat6.Enabled = false;
                Motor6.Enabled = false;
                Stay6.Enabled = false;
                Origin_List[6] = 6;
            }
            else
            {
                Seat6.Enabled = true;
                Motor6.Enabled = true;
                Stay6.Enabled = true;
                Origin_List[6] = 0;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat5.Enabled = false;
                Motor5.Enabled = false;
                Stay5.Enabled = false;
                Origin_List[5] = 5;
            }
            else
            {
                Seat5.Enabled = true;
                Motor5.Enabled = true;
                Stay5.Enabled = true;
                Origin_List[5] = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat4.Enabled = false;
                Motor4.Enabled = false;
                Stay4.Enabled = false;
                Origin_List[4] = 4;
            }
            else
            {
                Seat4.Enabled = true;
                Motor4.Enabled = true;
                Stay4.Enabled = true;
                Origin_List[4] = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat3.Enabled = false;
                Motor3.Enabled = false;
                Stay3.Enabled = false;
                Origin_List[3] = 3;
            }
            else
            {
                Seat3.Enabled = true;
                Motor3.Enabled = true;
                Stay3.Enabled = true;
                Origin_List[3] = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat2.Enabled = false;
                Motor2.Enabled = false;
                Stay2.Enabled = false;
                Origin_List[2] = 2;
            }
            else
            {
                Seat2.Enabled = true;
                Motor2.Enabled = true;
                Stay2.Enabled = true;
                Origin_List[2] = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                //(Seat1.SelectedIndex) * (Motor1.SelectedIndex)
                Seat1.Enabled = false;
                Motor1.Enabled = false;
                Stay1.Enabled = false;
                Origin_List[1] = 1;
            }
            else
            {
                Seat1.Enabled = true;
                Motor1.Enabled = true;
                Stay1.Enabled = true;
                Origin_List[1] = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread can_thread = new Thread(timer_func1);
            Thread can_read = new Thread(timer_func_Read);
            if ((Start1.Value != Pos1.Value) && (Start_tag == true))
            {
                SetData((byte)Seat1.SelectedIndex, (byte)Motor1.SelectedIndex, (uint)Start1.Value);
            }
            if (button1.Text == "开始")
            {
                Array.Copy(Origin_List, list, Origin_List.Length);
                label11.Text = label12.Text;
                start_flag_can = true;
                start_can_Read = true;
                pause_flag = false;
                button1.Text = "停止";
                can_thread.Start();
                can_read.Start();
                
            }
            else if(button1.Text == "停止")
            {
                start_flag_can = false;
                button1.Text = "开始";
                Step = 0;
                can_thread.Abort();
                can_read.Abort();
            }
            
        }




        private void FrameReceived(object sender, FrameReceivedEventArgs e)
        {
            ListViewItem lvi;
            Int32 i, j, nCnt;
            String S;
            String Data;
            nCnt = e.ReceivedCount;
            for (i = 0; i < nCnt; i++)
            {
                // This event handle routine is defined to notice
                // when a LIN-Frame was received by the CRcvFrameList.                           
                // and assign the values.
                lvi = new ListViewItem(e.Frames[i].RcvFrame.ID);
                if (lvi != null)
                // The entry exits already but the value
                // can replace by the values from the LIN frame.
                // It was an emty entry.
                    lvi.Text = e.Frames[i].RcvFrame.ID;

                lvi.SubItems.Add(e.Frames[i].RcvFrame.Length.ToString());
                // Check if the Error "SlaveNotResponding" is received
                if ((e.Frames[i].ErrorFlags & Peak.Lin.TLINMsgErrors.SlaveNOtResponding) == 0)
                    S = e.Frames[i].RcvFrame.DataAsString;
                else
                {
                    // If the Error "SlaveNotResponding" received
                    // than show only "--" as data text.
                    S = "";
                    for (j = 0; j < e.Frames[i].RcvFrame.Length; j++)
                        S = S + "-- ";
                }
                lvi.SubItems.Add(S);
                lvi.SubItems.Add(e.Frames[i].RcvFrame.PeriodAsString);
                lvi.SubItems.Add(e.Frames[i].RcvFrame.CountAsString);
                lvi.SubItems.Add(e.Frames[i].RcvFrame.DirectionAsString);
                if ((int)e.Frames[i].ErrorFlags == 0)
                    lvi.SubItems.Add(Resources.SOk);
                else
                    lvi.SubItems.Add(e.Frames[i].ErrorFlags.ToString());
                lvi.SubItems.Add(e.Frames[i].RcvFrame.ChecksumType.ToString());
                lvi.SubItems.Add(e.Frames[i].RcvFrame.ChecksumAsString);
                lvi.Tag = e.Frames[i].RcvFrame;

                // Update the data of the element in
                // the ListView with the received data.
                //  lvi = lvReceive.Items[nIdx];
                S = e.Frames[i].RcvFrame.Length.ToString();
                if (lvi.SubItems[1].Text != S)
                    lvi.SubItems[1].Text = S;
                if ((e.Frames[i].ErrorFlags & Peak.Lin.TLINMsgErrors.SlaveNOtResponding) == 0)
                    S = e.Frames[i].RcvFrame.DataAsString;
                else
                {
                    S = "";
                    for (j = 0; j < e.Frames[i].RcvFrame.Length; j++)
                        S = S + "-- ";
                }
                Data = S;
                if (lvi.SubItems[2].Text != S)
                {
                    lvi.SubItems[2].Text = S;

                }
                S = e.Frames[i].RcvFrame.PeriodAsString;
                if (lvi.SubItems[3].Text != S)
                    lvi.SubItems[3].Text = S;
                S = e.Frames[i].RcvFrame.CountAsString;
                if (lvi.SubItems[4].Text != S)
                    lvi.SubItems[4].Text = S;
                S = e.Frames[i].RcvFrame.DirectionAsString;
                if (lvi.SubItems[5].Text != S)
                    lvi.SubItems[5].Text = S;

                {
                    string str = lvi.Text.Substring(0, 2);
                    int ID = Convert.ToInt16(str, 16);

                    if ((int)e.Frames[i].ErrorFlags == 0)
                    {
                        lvi.SubItems[6].Text = Resources.SOk;
                        switch (ID)
                        {

                            case 0x73:
                                {
                                    data = Data.ToCharArray();
                                    if (data.Length != 0)
                                    {
                                        bt0 = chkdatachar(data[0]);
                                        bt1 = chkdatachar(data[1]);

                                        bt2 = chkdatachar(data[3]);
                                        bt3 = chkdatachar(data[4]);

                                        bt4 = chkdatachar(data[6]);
                                        bt5 = chkdatachar(data[7]);

                                        bt6 = chkdatachar(data[9]);
                                        bt7 = chkdatachar(data[10]);

                                        bt8 = chkdatachar(data[12]);
                                        bt9 = chkdatachar(data[13]);

                                        bt10 = chkdatachar(data[15]);
                                        bt11 = chkdatachar(data[16]);

                                        bt12 = chkdatachar(data[18]);
                                        bt13 = chkdatachar(data[19]);

                                        bt14 = chkdatachar(data[21]);
                                        bt15 = chkdatachar(data[22]);

                                        sw_data[0] = (byte)((bt0 << 4) | bt1);
                                        sw_data[1] = (byte)((bt2 << 4) | bt3);
                                        sw_data[2] = (byte)((bt4 << 4) | bt5);
                                        sw_data[3] = (byte)((bt6 << 4) | bt7);
                                        sw_data[4] = (byte)((bt8 << 4) | bt9);
                                        sw_data[5] = (byte)((bt10 << 4) | bt11);
                                        sw_data[6] = (byte)((bt12 << 4) | bt13);
                                        sw_data[7] = (byte)((bt14 << 4) | bt15);
                                        string str111 = BitConverter.ToString(sw_data).Replace("-", " ");
                                        textBox1.Text = str111;
                                        
                                        ////////////////////////////////////////////////////解析
                                        
                                        


                                    }
                                }
                                break;

                            case 0xB4:
                                {
                                    data = Data.ToCharArray();

                                    if (data.Length != 0)
                                    {
                                        bt0 = chkdatachar(data[0]);
                                        bt1 = chkdatachar(data[1]);

                                        bt2 = chkdatachar(data[3]);
                                        bt3 = chkdatachar(data[4]);

                                        bt4 = chkdatachar(data[6]);
                                        bt5 = chkdatachar(data[7]);

                                        bt6 = chkdatachar(data[9]);
                                        bt7 = chkdatachar(data[10]);

                                        bt8 = chkdatachar(data[12]);
                                        bt9 = chkdatachar(data[13]);

                                        bt10 = chkdatachar(data[15]);
                                        bt11 = chkdatachar(data[16]);

                                        bt12 = chkdatachar(data[18]);
                                        bt13 = chkdatachar(data[19]);

                                        bt14 = chkdatachar(data[21]);
                                        bt15 = chkdatachar(data[22]);

                                        diag_data[0] = (byte)((bt0 << 4) | bt1);
                                        diag_data[1] = (byte)((bt2 << 4) | bt3);
                                        diag_data[2] = (byte)((bt4 << 4) | bt5);
                                        diag_data[3] = (byte)((bt6 << 4) | bt7);
                                        diag_data[4] = (byte)((bt8 << 4) | bt9);
                                        diag_data[5] = (byte)((bt10 << 4) | bt11);
                                        diag_data[6] = (byte)((bt12 << 4) | bt13);
                                        diag_data[7] = (byte)((bt14 << 4) | bt15);


                                        string str111 = BitConverter.ToString(diag_data).Replace("-", " ");

                                    }

                                    


                                                                             
                                    

                                }
                                break;

                            case 0xF5:
                                {
                                    data = Data.ToCharArray();
                                    if (data.Length != 0)
                                    {
                                        bt0 = chkdatachar(data[0]);
                                        bt1 = chkdatachar(data[1]);

                                        bt2 = chkdatachar(data[3]);
                                        bt3 = chkdatachar(data[4]);

                                        bt4 = chkdatachar(data[6]);
                                        bt5 = chkdatachar(data[7]);

                                        bt6 = chkdatachar(data[9]);
                                        bt7 = chkdatachar(data[10]);

                                        bt8 = chkdatachar(data[12]);
                                        bt9 = chkdatachar(data[13]);

                                        bt10 = chkdatachar(data[15]);
                                        bt11 = chkdatachar(data[16]);

                                        bt12 = chkdatachar(data[18]);
                                        bt13 = chkdatachar(data[19]);

                                        bt14 = chkdatachar(data[21]);
                                        bt15 = chkdatachar(data[22]);

                                        hw_data[0] = (byte)((bt0 << 4) | bt1);
                                        hw_data[1] = (byte)((bt2 << 4) | bt3);
                                        hw_data[2] = (byte)((bt4 << 4) | bt5);
                                        hw_data[3] = (byte)((bt6 << 4) | bt7);
                                        hw_data[4] = (byte)((bt8 << 4) | bt9);
                                        hw_data[5] = (byte)((bt10 << 4) | bt11);
                                        hw_data[6] = (byte)((bt12 << 4) | bt13);
                                        hw_data[7] = (byte)((bt14 << 4) | bt15);
                                        string str111 = BitConverter.ToString(hw_data).Replace("-", " ");
                                        
                                        


                                    }
                                    else
                                    {
                                        //textBox11.Text = "";
                                        //string str111 = BitConverter.ToString(sw_data).Replace("-", " ");
                                        //textBox11.Text = str111;
                                    }
                                }
                                break;
                                
                            default:
                                break;
                                
                        }
                        //MyTransimitFunction(E16Msg_Publisher[Pub_0_Index]);
                    }
                    else
                    {
                        lvi.SubItems[6].Text = e.Frames[i].ErrorFlags.ToString();
                        {
                            
                        }
                    }
                }
                S = e.Frames[i].RcvFrame.ChecksumType.ToString();
                if (lvi.SubItems[7].Text != S)
                    lvi.SubItems[7].Text = S;
                S = e.Frames[i].RcvFrame.ChecksumAsString;
                if (lvi.SubItems[8].Text != S)
                    lvi.SubItems[8].Text = S;
            }
        }

        private byte chkdatachar(char data)
        {
            byte ret = 0;

            if (data >= 'A')
            {
                ret = (byte)(data - 55);
            }

            if ((data >= '0') && (data < 'A'))
            {
                ret = (byte)(data - '0');
            }
            return ret;
        }

        //FileStream file = new FileStream("E:\\test.txt", FileMode.OpenOrCreate);

        /*private void button3_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
        }*/


    }
    public class peakListView : ListView
    {
        public bool DoubleBufferedEx
        {
            get
            {
                return base.DoubleBuffered;
            }
            set
            {
                base.DoubleBuffered = value;
            }
        }
    }
}
