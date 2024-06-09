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

        const UInt16 Mode1_Index = 0;//0x382
        const UInt16 Mode2_Index = 1;//0x383
        const UInt16 NetWork_Index = 2;
        const UInt16 Second_Row_Seat_Heat_Cool_Duty_Cycle_Control = 3;

        TPCANMsg[] Msg_To_Send = new TPCANMsg[6];
        byte[] MsgSend_Data = new byte[50];

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
        byte Sig_SPS_2L_SecRwStLgextUpwdSwActv = 0;
        byte Sig_SPS_2L_SecRwStLgextDnwdSwActv = 0;
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
        byte Sig_SPS_2R_SecRwStLgextUpwdSwActv = 0;
        byte Sig_SPS_2R_SecRwStLgextDnwdSwActv = 0;
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

        byte Sig_SRLSL_HMI2LReq = 0;
        byte Sig_SRLSR_HMI2LReq = 0;
        byte Sig_SRRSL_HMI2RReq = 0;
        byte Sig_SRRSR_HMI2RReq = 0;

        byte Sig382_2L_SecRwLtStFrwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStBkwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStBkReclnUpwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStBkReclnDnwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStLgrstUpwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStLgrstDnwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStLtwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStRtwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStHdrstUpwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStHdrstDnwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStMemHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStLmbrHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStMassMdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStMassStrsHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStFtUpwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStFtDnwdHMI2LReq = 0;
        byte Sig382_2L_SecRwLtStArmScrnHMI2LReq = 0;
        byte Sig382_2L_VIPMdHMI2LRclReq = 0;
        byte Sig382_2L_AcsMdExtMdHMI2LRclReq = 0;
        byte Sig382_2L_RcvyMdHMI2LRclReq = 0;
        byte Sig382_2L_SecRwLtStChldLkLReq = 0;

        byte Sig_SecRwLtStArmScrnHMI2LReq = 0;
        byte Sig_SecRwRtStArmScrnHMI2RReq = 0;

        byte Sig383_2R_SecRwRtStFrwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStBkwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStBkReclnUpwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStBkReclnDnwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStLgrstUpwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStLgrstDnwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStLtwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStRtwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStHdrstUpwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStHdrstDnwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStMemHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStArmScrnHMI2RReq = 0;
        byte Sig383_2R_VIPMdHMI2RRclReq = 0;
        byte Sig383_2R_SecRwRtStFtUpwdHMI2RReq = 0; 
        byte Sig383_2R_SecRwRtStFtDnwdHMI2RReq = 0;
        byte Sig383_2R_BosSWFrwdHMI2RReq = 0;
        byte Sig383_2R_BosSWBkwdHMI2RReq = 0;
        byte Sig383_2R_BosSWStBkReclnUpwdHMI2RReq = 0;
        byte Sig383_2R_BosSWStBkReclnDnwdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStLmbrHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStMassMdHMI2RReq = 0;
        byte Sig383_2R_SecRwRtStMassStrsHMI2RReq = 0;
        byte Sig383_2R_AcsMdExtMdHMI2RRclReq = 0;
        byte Sig383_2R_RcvyMdHMI2RRclReq = 0;
        byte Sig383_2R_SecRwRtStChldLkLReq = 0;

        byte Sig426_SecRwRtStHtCshnDtyCycl = 0;
        byte Sig426_SecRwRtStHtBkDtyCycl = 0;
        byte Sig426_SecRwRtStVntDtyCycl = 0;
        byte Sig426_SecRwLtStHtCshnDtyCycl = 0;
        byte Sig426_SecRwLtStHtBkDtyCycl = 0;
        byte Sig426_SecRwLtStVntDtyCycl = 0;



        bool start_flag = false;

        byte[] sw_data = new byte[8];

        Byte iii = 0;
        int counter_receive = 0;
        TPCANMsg msg = new TPCANMsg();
        TPCANStatus Res;
        //Res = PCANBasic.Initialize(PCANBasic.PCAN_USBBUS1, TPCANBaudrate.PCAN_BAUD_500K);

        private ushort PCANIntrfs;

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
            if(m_nHwChannel == 1)
            {
                PCANIntrfs = PCANBasic.PCAN_USBBUS1;
            }
            else if(m_nHwChannel == 2)
            {
                PCANIntrfs = PCANBasic.PCAN_USBBUS2;
            }
            TPCANStatus Res;
            Res = PCANBasic.Initialize(PCANIntrfs, TPCANBaudrate.PCAN_BAUD_500K, TPCANType.PCAN_TYPE_ISA, 0100, 3);
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

        void timer_Lin()
        {
            while (start_flag == true)
            {
                if (iii % 2 == 0)
                {
                    //MyTransimitFunction(E16Msg_Publisher[Pub_0_Index]);
                }

                delay_10ms();
                iii++;
            }

        }


        UInt16 timer_counter = 0;
        void timer_Can()
        {
            while (start_flag == true)
            {
                delay_10ms();
                timer_counter++;
                if ((timer_counter % 10 == 0) && (checkBox2.Checked == true))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[Mode1_Index]);
                }
                if ((timer_counter % 10 == 1) && (checkBox2.Checked == true))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[Mode2_Index]);
                }
                if ((timer_counter % (cycle.Value/10) ==0) && (checkBox1.Checked == true))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[NetWork_Index]);
                }
                if ((timer_counter % 10 == 1))
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control]);
                }
                if (timer_counter >= 200)
                {
                    timer_counter = 0;
                }
            }
        }

        void timer_CanR()
        {
            while(start_flag == true)
            {
                Res = PCANBasic.Read(PCANBasic.PCAN_USBBUS1, out msg);
                if ((Res == TPCANStatus.PCAN_ERROR_OK)||(Res == TPCANStatus.PCAN_ERROR_QRCVEMPTY))
                {
                    if (msg.ID == 0x262)
                    {
#if DELETE
                        DrvStBlstOtwdInwdPos.Text = Convert.ToString(Convert.ToDouble((((msg.DATA[0] & 0xFF) << 4) | (msg.DATA[1] & 0xF0) >> 4)) * 0.025);
                        DrvStFtUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[1] & 0x0F) << 8) | (msg.DATA[2])) * 0.025);
                        DrvStHdrstUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble((((msg.DATA[3] & 0xFF) << 4) | (msg.DATA[4] & 0xF0) >> 4)) * 0.025);
                        DrvStLgrstUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[4] & 0x0F) << 8) | (msg.DATA[5])) * 0.025);
                        if ((msg.DATA[6] & 0x80) == 0x80)
                        {
                            DrvStBlstOtwdInwdPosV.BackColor = Color.Red;
                            DrvStBlstOtwdInwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            DrvStBlstOtwdInwdPosV.BackColor = Color.Green;
                            DrvStBlstOtwdInwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[6] & 0x40) == 0x40)
                        {
                            DrvStFtUpwdDnwdPosV.BackColor = Color.Red;
                            DrvStFtUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            DrvStFtUpwdDnwdPosV.BackColor = Color.Green;
                            DrvStFtUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[6] & 0x20) == 0x20)
                        {
                            DrvStLgrstUpwdDnwdPosV.BackColor = Color.Red;
                            DrvStLgrstUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            DrvStLgrstUpwdDnwdPosV.BackColor = Color.Green;
                            DrvStLgrstUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[6] & 0x10) == 0x10)
                        {
                            DrvStHdrstUpwdDnwdPosV.BackColor = Color.Red;
                            DrvStHdrstUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            DrvStHdrstUpwdDnwdPosV.BackColor = Color.Green;
                            DrvStHdrstUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[6] & 0x08) == 0x08)
                        {
                            DrvStBlstOtwdInwdSnsrHmPosLrnd.BackColor = Color.Green;
                            DrvStBlstOtwdInwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            DrvStBlstOtwdInwdSnsrHmPosLrnd.BackColor = Color.Red;
                            DrvStBlstOtwdInwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[6] & 0x04) == 0x04)
                        {
                            DrvStFtUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            DrvStFtUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            DrvStFtUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            DrvStFtUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[6] & 0x02) == 0x02)
                        {
                            DrvStHdrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            DrvStHdrstUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            DrvStHdrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            DrvStHdrstUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[6] & 0x01) == 0x01)
                        {
                            DrvStLgrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            DrvStLgrstUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            DrvStLgrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            DrvStLgrstUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }

#endif
                        
                    }//ok1
                    if (msg.ID == 0x213)
                    {
                        DrvStFrwdBkwdPos.Text = Convert.ToString(Convert.ToDouble((msg.DATA[4] << 4) | (msg.DATA[5] & 0xF0) >> 4) * 0.025);
                        DrvStBkReclnUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[5] & 0x0F) << 8) | (msg.DATA[6])) * 0.025);
                        if((msg.DATA[7] & 0x80) == 0x80)
                        {
                            DrvStFrwdBkwdPosV.BackColor = Color.Red;
                            DrvStFrwdBkwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            DrvStFrwdBkwdPosV.BackColor = Color.Green;
                            DrvStFrwdBkwdPosV.Text = "电机有效";
                        }
                        if((msg.DATA[7] & 0x40) == 0x40)
                        {
                            DrvStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Green;
                            DrvStFrwdBkwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            DrvStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Red;
                            DrvStFrwdBkwdSnsrHmPosLrnd.Text = "电机未学习";

                        }
                        if ((msg.DATA[7] & 0x20) == 0x20)
                        {
                            DrvStBkReclnUpwdDnwdPosV.BackColor = Color.Red;
                            DrvStBkReclnUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            DrvStBkReclnUpwdDnwdPosV.BackColor = Color.Green;
                            DrvStBkReclnUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[7] & 0x10) == 0x10)
                        {
                            DrvStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            DrvStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            DrvStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            DrvStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                    }//ok1
                    if (msg.ID == 0x214)
                    {
#if DELETE
                        DrvStCshnFrntUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble((msg.DATA[4] << 4) | (msg.DATA[5] & 0xF0) >> 4) * 0.025);
#endif
                        DrvStCshnRrUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[5] & 0x0F) << 8) | (msg.DATA[6])) * 0.025);
                        if ((msg.DATA[7] & 0x80) == 0x80)
                        {
                            DrvStCshnFrntUpwdDnwdPosV.BackColor = Color.Red;
                            DrvStCshnFrntUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            DrvStCshnFrntUpwdDnwdPosV.BackColor = Color.Green;
                            DrvStCshnFrntUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[7] & 0x40) == 0x40)
                        {
                            DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            DrvStCshnFrntUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[7] & 0x20) == 0x20)
                        {
                            DrvStCshnRrUpwdDnwdPosV.BackColor = Color.Red;
                            DrvStCshnRrUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            DrvStCshnRrUpwdDnwdPosV.BackColor = Color.Green;
                            DrvStCshnRrUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[7] & 0x10) == 0x10)
                        {
                            DrvStCshnRrUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            DrvStCshnRrUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            DrvStCshnRrUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            DrvStCshnRrUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                    }//ok1
                    if (msg.ID == 0x470)
                    {
                        PassStFrwdBkwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[0] & 0xFF) << 4) | ((msg.DATA[1] & 0xF0) >> 4)) * 0.025);
                        PassStBkReclnUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[1] & 0x03) << 10) | (msg.DATA[2] << 2) | ((msg.DATA[3] & 0xC0) >> 6)) * 0.025);

#if DELETE
                        PassStBlstOtwdInwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[3] & 0x0F) << 8) | (msg.DATA[4])) * 0.025);
                        PassStFtUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[5] & 0x3F) << 6) | ((msg.DATA[6] & 0xFC) >> 2)) * 0.025);
#endif
                        if((msg.DATA[1] & 0x08) == 0x08)
                        {
                            PassStFrwdBkwdPosV.BackColor = Color.Red;
                            PassStFrwdBkwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            PassStFrwdBkwdPosV.BackColor = Color.Green;
                            PassStFrwdBkwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[1] & 0x04) == 0x04)
                        {
                            PassStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Green;
                            PassStFrwdBkwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            PassStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Red;
                            PassStFrwdBkwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[3] & 0x20) == 0x20)
                        {
                            PassStBkReclnUpwdDnwdPosV.BackColor = Color.Red;
                            PassStBkReclnUpwdDnwdPosV.Text = "电机无效";

                        }
                        else
                        {
                            PassStBkReclnUpwdDnwdPosV.BackColor = Color.Green;
                            PassStBkReclnUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[3] & 0x10) == 0x10)
                        {
                            PassStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            PassStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            PassStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            PassStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }

#if DELETE
                        if ((msg.DATA[5] & 0x80) == 0x80)
                        {
                            PassStBlstOtwdInwdPosV.BackColor = Color.Red;
                            PassStBlstOtwdInwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            PassStBlstOtwdInwdPosV.BackColor = Color.Green;
                            PassStBlstOtwdInwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[5] & 0x40) == 0x40)
                        {
                            PassStBlstOtwdInwdSnsrHmPosLrnd.BackColor = Color.Green;
                            PassStBlstOtwdInwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            PassStBlstOtwdInwdSnsrHmPosLrnd.BackColor = Color.Red;
                            PassStBlstOtwdInwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[6] & 0x02) == 0x02)
                        {
                            PassStFtUpwdDnwdPosV.BackColor = Color.Red;
                            PassStFtUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            PassStFtUpwdDnwdPosV.BackColor = Color.Green;
                            PassStFtUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[6] & 0x01) == 0x01)
                        {
                            PassStFtUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            PassStFtUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            PassStFtUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            PassStFtUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }

#endif
                    }//ok1
                    if (msg.ID == 0x471)
                    {
                        PassStCshnFrntUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble((((msg.DATA[0] & 0xFF) << 4) | (msg.DATA[1] & 0xF0) >> 4)) * 0.025);
                        PassStCshnRrUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[1] & 0x03) << 10) | (msg.DATA[2] << 2) | ((msg.DATA[3] & 0xC0) >> 6)) * 0.025);
#if DELETE
                        PassStHdrstUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[3] & 0x0F) << 8) | (msg.DATA[4])) * 0.025);
                        PassStLgrstUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[5] & 0x3F) << 6) | ((msg.DATA[6] & 0xFC) >> 2)) * 0.025);
#endif
                        if ((msg.DATA[1] & 0x08) == 0x08)
                        {
                            PassStCshnFrntUpwdDnwdPosV.BackColor = Color.Red;
                            PassStCshnFrntUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            PassStCshnFrntUpwdDnwdPosV.BackColor = Color.Green;
                            PassStCshnFrntUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[1] & 0x04) == 0x04)
                        {
                            PassStCshnFrntUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            PassStCshnFrntUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            PassStCshnFrntUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            PassStCshnFrntUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[3] & 0x20) == 0x20)
                        {
                            PassStCshnRrUpwdDnwdPosV.BackColor = Color.Red;
                            PassStCshnRrUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            PassStCshnRrUpwdDnwdPosV.BackColor = Color.Green;
                            PassStCshnRrUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[3] & 0x10) == 0x10)
                        {
                            PassStCshnRrUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            PassStCshnRrUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            PassStCshnRrUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            PassStCshnRrUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
#if DELETE
                        if ((msg.DATA[5] & 0x80) == 0x80)
                        {
                            PassStHdrstUpwdDnwdPosV.BackColor = Color.Red;
                            PassStHdrstUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            PassStHdrstUpwdDnwdPosV.BackColor = Color.Green;
                            PassStHdrstUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[5] & 0x40) == 0x40)
                        {
                            PassStHdrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            PassStHdrstUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            PassStHdrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            PassStHdrstUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[6] & 0x02) == 0x02)
                        {
                            PassStLgrstUpwdDnwdPosV.BackColor = Color.Red;
                            PassStLgrstUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            PassStLgrstUpwdDnwdPosV.BackColor = Color.Green;
                            PassStLgrstUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[6] & 0x01) == 0x01)
                        {
                            PassStLgrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            PassStLgrstUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            PassStLgrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            PassStLgrstUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
#endif
                    }//ok
                    if (msg.ID == 0x45D)
                    {
                        SecRwLtStFrwdBkwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[0] & 0xFF) << 4) | ((msg.DATA[1] & 0xF0) >> 4)) * 0.025);
                        SecRwLtStBkReclnUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[1] & 0x03) << 10) | (msg.DATA[2] << 2) | ((msg.DATA[3] & 0xC0) >> 6)) * 0.025);
#if DELETE
                        SecRwLtStBlstOtwdInwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[3] & 0x0F) << 8) | (msg.DATA[4])) * 0.025);
                        SecRwLtStLtwdRtwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[5] & 0x3F) << 6) | ((msg.DATA[6] & 0xFC) >> 2)) * 0.025);
#endif
                        if ((msg.DATA[1] & 0x08) == 0x08)
                        {
                            SecRwLtStFrwdBkwdPosV.BackColor = Color.Red;
                            SecRwLtStFrwdBkwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwLtStFrwdBkwdPosV.BackColor = Color.Green;
                            SecRwLtStFrwdBkwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[1] & 0x04) == 0x04)
                        {
                            SecRwLtStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwLtStFrwdBkwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwLtStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwLtStFrwdBkwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[3] & 0x20) == 0x20)
                        {
                            SecRwLtStBkReclnUpwdDnwdPosV.BackColor = Color.Red;
                            SecRwLtStBkReclnUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwLtStBkReclnUpwdDnwdPosV.BackColor = Color.Green;
                            SecRwLtStBkReclnUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[3] & 0x10) == 0x10)
                        {
                            SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
#if DELETE
                        if ((msg.DATA[5] & 0x80) == 0x80)
                        {
                            SecRwLtStBlstOtwdInwdPosV.BackColor = Color.Red;
                            SecRwLtStBlstOtwdInwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwLtStBlstOtwdInwdPosV.BackColor = Color.Green;
                            SecRwLtStBlstOtwdInwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[5] & 0x40) == 0x40)
                        {
                            SecRwLtStBlstOtwdInwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwLtStBlstOtwdInwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwLtStBlstOtwdInwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwLtStBlstOtwdInwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[6] & 0x02) == 0x02)
                        {
                            SecRwLtStLtwdRtwdPosV.BackColor = Color.Red;
                            SecRwLtStLtwdRtwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwLtStLtwdRtwdPosV.BackColor = Color.Green;
                            SecRwLtStLtwdRtwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[6] & 0x01) == 0x01)
                        {
                            SecRwLtStLtwdRtwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwLtStLtwdRtwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwLtStLtwdRtwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwLtStLtwdRtwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
#endif
                    }//ok
                    if (msg.ID == 0x45E)
                    {
                        SecRwLtStCshnFrntUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble((((msg.DATA[0] & 0xFF) << 4) | (msg.DATA[1] & 0xF0) >> 4)) * 0.025);
#if DELETE
                        SecRwLtStCshnRrUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[1] & 0x03) << 10) | (msg.DATA[2] << 2) | ((msg.DATA[3] & 0xC0) >> 6)) * 0.025);

                        SecRwLtStHPassStUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[3] & 0x0F) << 8) | (msg.DATA[4])) * 0.025);
#endif
                        SecRwLtStLgrstUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[5] & 0x3F) << 6) | ((msg.DATA[6] & 0xFC) >> 2)) * 0.025);

                        if ((msg.DATA[1] & 0x08) == 0x08)
                        {
                            SecRwLtStCshnFrntUpwdDnwdPosV.BackColor = Color.Red;
                            SecRwLtStCshnFrntUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwLtStCshnFrntUpwdDnwdPosV.BackColor = Color.Green;
                            SecRwLtStCshnFrntUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[1] & 0x04) == 0x04)
                        {
                            SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwLtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
#if DELETE
                        if ((msg.DATA[3] & 0x20) == 0x20)
                        {
                            SecRwLtStCshnRrUpwdDnwdPosV.BackColor = Color.Red;
                            SecRwLtStCshnRrUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwLtStCshnRrUpwdDnwdPosV.BackColor = Color.Green;
                            SecRwLtStCshnRrUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[3] & 0x10) == 0x10)
                        {
                            SecRwLtStCshnRrUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwLtStCshnRrUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwLtStCshnRrUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwLtStCshnRrUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[5] & 0x80) == 0x80)
                        {
                            SecRwLtStHPassStUpwdDnwdPosV.BackColor = Color.Red;
                            SecRwLtStHPassStUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwLtStHPassStUpwdDnwdPosV.BackColor = Color.Green;
                            SecRwLtStHPassStUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[5] & 0x40) == 0x40)
                        {
                            SecRwLtStUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwLtStUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwLtStUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwLtStUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }

#endif
                        if ((msg.DATA[6] & 0x02) == 0x02)
                        {
                            SecRwLtStLgrstUpwdDnwdPosV.BackColor = Color.Red;
                            SecRwLtStLgrstUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwLtStLgrstUpwdDnwdPosV.BackColor = Color.Green;
                            SecRwLtStLgrstUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[6] & 0x01) == 0x01)
                        {
                            SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwLtStLgrstUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                    }//ok
                    if (msg.ID == 0x463)
                    {
                        SecRwRtStFrwdBkwdPos.Text = Convert.ToString(Convert.ToDouble((((msg.DATA[0] & 0xFF) << 4) | (msg.DATA[1] & 0xF0) >> 4)) * 0.025);
                        SecRwRtStBkReclnUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[1] & 0x03) << 10) | (msg.DATA[2] << 2) | ((msg.DATA[3] & 0xC0) >> 6)) * 0.025);
#if DELETE
                        SecRwRtStBlstOtwdInwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[3] & 0x0F) << 8) | (msg.DATA[4])) * 0.025);
                        SecRwRtStLtwdRtwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[5] & 0x3F) << 6) | ((msg.DATA[6] & 0xFC) >> 2)) * 0.025);
#endif
                        if ((msg.DATA[1] & 0x08) == 0x08)
                        {
                            SecRwRtStFrwdBkwdPosV.BackColor = Color.Red;
                            SecRwRtStFrwdBkwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwRtStFrwdBkwdPosV.BackColor = Color.Green;
                            SecRwRtStFrwdBkwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[1] & 0x04) == 0x04)
                        {
                            SecRwRtStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwRtStFrwdBkwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwRtStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwRtStFrwdBkwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[3] & 0x20) == 0x20)
                        {
                            SecRwRtStBkReclnUpwdDnwdPosV.BackColor = Color.Red;
                            SecRwRtStBkReclnUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwRtStBkReclnUpwdDnwdPosV.BackColor = Color.Green;
                            SecRwRtStBkReclnUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[3] & 0x10) == 0x10)
                        {
                            SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
#if DELETE
                        if ((msg.DATA[5] & 0x80) == 0x80)
                        {
                            SecRwRtStBlstOtwdInwdPosV.BackColor = Color.Red;
                            SecRwRtStBlstOtwdInwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwRtStBlstOtwdInwdPosV.BackColor = Color.Green;
                            SecRwRtStBlstOtwdInwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[5] & 0x40) == 0x40)
                        {
                            SecRwRtStBlstOtwdInwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwRtStBlstOtwdInwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwRtStBlstOtwdInwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwRtStBlstOtwdInwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[6] & 0x02) == 0x02)
                        {
                            SecRwRtStLtwdRtwdPosV.BackColor = Color.Red;
                            SecRwRtStLtwdRtwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwRtStLtwdRtwdPosV.BackColor = Color.Green;
                            SecRwRtStLtwdRtwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[6] & 0x01) == 0x01)
                        {
                            SecRwRtStLtwdRtwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwRtStLtwdRtwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwRtStLtwdRtwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwRtStLtwdRtwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
#endif
                    }
                    if (msg.ID == 0x464)
                    {
                        SecRwRtStCshnFrntUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble((((msg.DATA[0] & 0xFF) << 4) | (msg.DATA[1] & 0xF0) >> 4)) * 0.025);
#if DELETE
                        SecRwRtStCshnRrUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[1] & 0x03) << 10) | (msg.DATA[2] << 2) | ((msg.DATA[3] & 0xC0) >> 6)) * 0.025);

                        SecRwRtStHPassStUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[3] & 0x0F) << 8) | (msg.DATA[4])) * 0.025);
                        SecRwRtStLgrstUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[5] & 0x3F) << 6) | ((msg.DATA[6] & 0xFC) >> 2)) * 0.025);
#endif
                        if ((msg.DATA[1] & 0x08) == 0x08)
                        {
                            SecRwRtStCshnFrntUpwdDnwdPosV.BackColor = Color.Red;
                            SecRwRtStCshnFrntUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwRtStCshnFrntUpwdDnwdPosV.BackColor = Color.Green;
                            SecRwRtStCshnFrntUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[1] & 0x04) == 0x04)
                        {
                            SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwRtStCshnFrntUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
#if DELETE
                        if ((msg.DATA[3] & 0x20) == 0x20)
                        {
                            SecRwRtStCshnRrUpwdDnwdPosV.BackColor = Color.Red;
                            SecRwRtStCshnRrUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwRtStCshnRrUpwdDnwdPosV.BackColor = Color.Green;
                            SecRwRtStCshnRrUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[3] & 0x10) == 0x10)
                        {
                            SecRwRtStCshnRrUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwRtStCshnRrUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwRtStCshnRrUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwRtStCshnRrUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[5] & 0x80) == 0x80)
                        {
                            SecRwRtStHPassStUpwdDnwdPosV.BackColor = Color.Red;
                            SecRwRtStHPassStUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwRtStHPassStUpwdDnwdPosV.BackColor = Color.Green;
                            SecRwRtStHPassStUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[5] & 0x40) == 0x40)
                        {
                            SecRwRtStUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwRtStUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwRtStUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwRtStUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
#endif
                        if ((msg.DATA[6] & 0x02) == 0x02)
                        {
                            SecRwRtStLgrstUpwdDnwdPosV.BackColor = Color.Red;
                            SecRwRtStLgrstUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwRtStLgrstUpwdDnwdPosV.BackColor = Color.Green;
                            SecRwRtStLgrstUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[6] & 0x01) == 0x01)
                        {
                            SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            SecRwRtStLgrstUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                    }
                    if (msg.ID == 0x468)
                    {
                        ThdRwLtStFrwdBkwdPos.Text = Convert.ToString(Convert.ToDouble((((msg.DATA[0] & 0xFF) << 4) | (msg.DATA[1] & 0xF0) >> 4)) * 0.025);
                        ThdRwLtStBkReclnUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[1] & 0x03) << 10) | (msg.DATA[2] << 2) | ((msg.DATA[3] & 0xC0) >> 6)) * 0.025);
                        ThdRwLtStCshnFldUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[3] & 0x0F) << 8) | (msg.DATA[4])) * 0.025);
                        if ((msg.DATA[1] & 0x08) == 0x08)
                        {
                            ThdRwLtStFrwdBkwdPosV.BackColor = Color.Red;
                            ThdRwLtStFrwdBkwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            ThdRwLtStFrwdBkwdPosV.BackColor = Color.Green;
                            ThdRwLtStFrwdBkwdPosV.Text = "电机有效";
                        }
                        if((msg.DATA[1] & 0x04) == 0x04)
                        {
                            ThdRwLtStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Green;
                            ThdRwLtStFrwdBkwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            ThdRwLtStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Red;
                            ThdRwLtStFrwdBkwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if((msg.DATA[3] & 0x20) == 0x20)
                        {
                            ThdRwLtStBkReclnUpwdDnwdPosV.BackColor = Color.Red;
                            ThdRwLtStBkReclnUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            ThdRwLtStBkReclnUpwdDnwdPosV.BackColor = Color.Green;
                            ThdRwLtStBkReclnUpwdDnwdPosV.Text = "电机有效";
                        }
                        if((msg.DATA[3] & 0x10) == 0x10)
                        {
                            ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            ThdRwLtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if((msg.DATA[5] & 0x80) == 0x80)
                        {
                            ThdRwLtStCshnFldUpwdDnwdPosV.BackColor = Color.Red;
                            ThdRwLtStCshnFldUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            ThdRwLtStCshnFldUpwdDnwdPosV.BackColor = Color.Green;
                            ThdRwLtStCshnFldUpwdDnwdPosV.Text = "电机有效";
                        }
                        if((msg.DATA[5] & 0x80) == 0x80)
                        {
                            ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            ThdRwLtStCshnFldUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                    }
                    if (msg.ID == 0x46C)
                    {
                        ThdRwRtStFrwdBkwdPos.Text = Convert.ToString(Convert.ToDouble((((msg.DATA[0] & 0xFF) << 4) | (msg.DATA[1] & 0xF0) >> 4)) * 0.025);
                        ThdRwRtStBkReclnUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[1] & 0x03) << 10) | (msg.DATA[2]) | ((msg.DATA[3] & 0xC0) >> 6)) * 0.025);
                        ThdRwRtStCshnFldUpwdDnwdPos.Text = Convert.ToString(Convert.ToDouble(((msg.DATA[3] & 0x0F) << 8) | (msg.DATA[4])) * 0.025);
                        if ((msg.DATA[1] & 0x08) == 0x08)
                        {
                            ThdRwRtStFrwdBkwdPosV.BackColor = Color.Red;
                            ThdRwRtStFrwdBkwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            ThdRwRtStFrwdBkwdPosV.BackColor = Color.Green;
                            ThdRwRtStFrwdBkwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[1] & 0x04) == 0x04)
                        {
                            ThdRwRtStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Green;
                            ThdRwRtStFrwdBkwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            ThdRwRtStFrwdBkwdSnsrHmPosLrnd.BackColor = Color.Red;
                            ThdRwRtStFrwdBkwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[3] & 0x20) == 0x20)
                        {
                            ThdRwRtStBkReclnUpwdDnwdPosV.BackColor = Color.Red;
                            ThdRwRtStBkReclnUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            ThdRwRtStBkReclnUpwdDnwdPosV.BackColor = Color.Green;
                            ThdRwRtStBkReclnUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[3] & 0x10) == 0x10)
                        {
                            ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Green;
                            ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.BackColor = Color.Red;
                            ThdRwRtStBkReclnUpwdDnwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                        if ((msg.DATA[5] & 0x80) == 0x80)
                        {
                            ThdRwRtStCshnFldUpwdDnwdPosV.BackColor = Color.Red;
                            ThdRwRtStCshnFldUpwdDnwdPosV.Text = "电机无效";
                        }
                        else
                        {
                            ThdRwRtStCshnFldUpwdDnwdPosV.BackColor = Color.Green;
                            ThdRwRtStCshnFldUpwdDnwdPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[5] & 0x40) == 0x40)
                        {
                            ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd.BackColor = Color.Green;
                            ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd.BackColor = Color.Red;
                            ThdRwRtStBlstOtwdInwdSnsrHmPosLrnd.Text = "电机未学习";
                        }
                    }
                    if(msg.ID == 0x227)
                    {
#if DELETE
                        SecRwLtStArmScrnPos.Text = Convert.ToString(Convert.ToDouble((((msg.DATA[0] & 0xFF) << 4) | (msg.DATA[1] & 0xF0) >> 4)) * 0.025);
                        if((msg.DATA[1] & 0x08) == 0x08)
                        {
                            SecRwLtStArmScrnPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwLtStArmScrnPosV.Text = "电机有效";
                        }
                        if((msg.DATA[1] & 0x04) == 0x04)
                        {
                            SecRwLtStArmScrnSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwLtStArmScrnSnsrHmPosLrnd.Text = "电机未学习";
                        }

#endif
                    }
                    if(msg.ID == 0x226)
                    {
#if DELETE
                        SecRwRtStArmScrnPos.Text = Convert.ToString(Convert.ToDouble((((msg.DATA[0] & 0xFF) << 4) | (msg.DATA[1] & 0xF0) >> 4)) * 0.025);
                        if ((msg.DATA[1] & 0x08) == 0x08)
                        {
                            SecRwRtStArmScrnPosV.Text = "电机无效";
                        }
                        else
                        {
                            SecRwRtStArmScrnPosV.Text = "电机有效";
                        }
                        if ((msg.DATA[1] & 0x04) == 0x04)
                        {
                            SecRwRtStArmScrnSnsrHmPosLrnd.Text = "电机已学习";
                        }
                        else
                        {
                            SecRwRtStArmScrnSnsrHmPosLrnd.Text = "电机未学习";
                        }
#endif
                    }
                    if(msg.ID == 0x383)
                    {
                        counter_receive = 0;
                    }
                    else
                    {
                        counter_receive++;
                        if(counter_receive > 10000)
                        {

                        }
                        
                    }
                    if(msg.ID == 0x461)
                    {
                        SecRwLtStHtVntDtyCyclStat.SelectedIndex = (byte)((msg.DATA[0] & 0xF0) >> 4);
                    }
                    if(msg.ID == 0x467)
                    {
                        NotThdRwLtStOccStatMSMSrc.SelectedIndex = (byte)((msg.DATA[1] & 0x0C) >> 2);
                        NotThdRwCtStOccStatMSMSrc.SelectedIndex = (byte)((msg.DATA[1] & 0x03));
                    }
                }
            }
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
            m_pGFT.OnPropertyChange += new PropertyChangeEventHandler(PropertyChange);
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
            m_HwMode = Peak.Lin.TLINHardwareMode.modSlave;
            m_wBaudrate = 10400;
            m_sHardwareName = "";
            m_LINMode = Peak.Lin.TLINHardwareMode.modNone;
            m_LINState = Peak.Lin.TLINHardwareState.hwsNotInitialized;
            m_wOverruns = 0;

            // Register this application with LIN as client.
            m_LastLINErr = Peak.Lin.PLinApi.RegisterClient(Resources.SPLinClientName, Handle, out m_hClient);


            /*E16Msg_Publisher[Pub_0_Index].FrameId = Pub_0_Cmd;
            E16Msg_Publisher[Pub_0_Index].Length = 0x08;
            E16Msg_Publisher[Pub_0_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            E16Msg_Publisher[Pub_0_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            E16Msg_Publisher[Pub_0_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };*/


            /********Msg for E16Msg_Subscriber**************/
            /* DR Seat */
            Publisher[SPS_DR_Req_MSG_Index].FrameId = 0xB1;
            Publisher[SPS_DR_Req_MSG_Index].Length = 5;
            Publisher[SPS_DR_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_DR_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_DR_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            tLINFrameEntry[SPS_DR_Req_MSG_Index].FrameId = 0x31;
            tLINFrameEntry[SPS_DR_Req_MSG_Index].Length = 5;
            tLINFrameEntry[SPS_DR_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_DR_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_DR_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            /* CODR Seat */
            Publisher[SPS_CODR_Req_MSG_Index].FrameId = 0xCF;
            Publisher[SPS_CODR_Req_MSG_Index].Length = 5;
            Publisher[SPS_CODR_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_CODR_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_CODR_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            tLINFrameEntry[SPS_CODR_Req_MSG_Index].FrameId = 0x0F;
            tLINFrameEntry[SPS_CODR_Req_MSG_Index].Length = 5;
            tLINFrameEntry[SPS_CODR_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_CODR_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_CODR_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            /* 2L Seat */
            Publisher[SPS_2L_Req_MSG_Index].FrameId = 0x61;
            Publisher[SPS_2L_Req_MSG_Index].Length = 8;
            Publisher[SPS_2L_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_2L_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_2L_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            tLINFrameEntry[SPS_2L_Req_MSG_Index].FrameId = 0x21;
            tLINFrameEntry[SPS_2L_Req_MSG_Index].Length = 8;
            tLINFrameEntry[SPS_2L_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_2L_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_2L_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            /* 2R Seat */
            Publisher[SPS_2R_Req_MSG_Index].FrameId = 0x17;
            Publisher[SPS_2R_Req_MSG_Index].Length = 8;
            Publisher[SPS_2R_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_2R_Req_MSG_Index].ChecksumType =  Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_2R_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            tLINFrameEntry[SPS_2R_Req_MSG_Index].FrameId = 0x17;
            tLINFrameEntry[SPS_2R_Req_MSG_Index].Length = 8;
            tLINFrameEntry[SPS_2R_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_2R_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_2R_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            /* 3L Seat */
            Publisher[SPS_3L_Req_MSG_Index].FrameId = 0x8B;
            Publisher[SPS_3L_Req_MSG_Index].Length = 3;
            Publisher[SPS_3L_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_3L_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_3L_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            tLINFrameEntry[SPS_3L_Req_MSG_Index].FrameId = 0x0B;
            tLINFrameEntry[SPS_3L_Req_MSG_Index].Length = 3;
            tLINFrameEntry[SPS_3L_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_3L_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_3L_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            /* 3R Seat */
            Publisher[SPS_3R_Req_MSG_Index].FrameId = 0xE7;
            Publisher[SPS_3R_Req_MSG_Index].Length = 3;
            Publisher[SPS_3R_Req_MSG_Index].Direction  = Peak.Lin.TLINDirection.dirPublisher;
            Publisher[SPS_3R_Req_MSG_Index].ChecksumType  = Peak.Lin.TLINChecksumType.cstEnhanced;
            Publisher[SPS_3R_Req_MSG_Index].Data = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            tLINFrameEntry[SPS_3R_Req_MSG_Index].FrameId = 0x27;
            tLINFrameEntry[SPS_3R_Req_MSG_Index].Length = 3;
            tLINFrameEntry[SPS_3R_Req_MSG_Index].Direction = Peak.Lin.TLINDirection.dirPublisher;
            tLINFrameEntry[SPS_3R_Req_MSG_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;
            tLINFrameEntry[SPS_3R_Req_MSG_Index].Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;

            /*E16Msg_Subscriber[Sub_6_Index].FrameId = Sub_6_Cmd;
            E16Msg_Subscriber[Sub_6_Index].Length = 0x08;
            E16Msg_Subscriber[Sub_6_Index].Direction = Peak.Lin.TLINDirection.dirSubscriberAutoLength;
            E16Msg_Subscriber[Sub_6_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;

            E16Msg_Subscriber[Sub_7_Index].FrameId = Sub_7_Cmd;
            E16Msg_Subscriber[Sub_7_Index].Length = 0x08;
            E16Msg_Subscriber[Sub_7_Index].Direction = Peak.Lin.TLINDirection.dirSubscriberAutoLength;
            E16Msg_Subscriber[Sub_7_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;

            E16Msg_Subscriber[Sub_8_Index].FrameId = Sub_8_Cmd;
            E16Msg_Subscriber[Sub_8_Index].Length = 0x08;
            E16Msg_Subscriber[Sub_8_Index].Direction = Peak.Lin.TLINDirection.dirSubscriberAutoLength;
            E16Msg_Subscriber[Sub_8_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;

            // E16Msg_Subscriber[Sub_9_Index].FrameId = Sub_9_Cmd;
            // E16Msg_Subscriber[Sub_9_Index].Length = 0x08;
            // E16Msg_Subscriber[Sub_9_Index].Direction = Peak.Lin.TLINDirection.dirSubscriberAutoLength;
            // E16Msg_Subscriber[Sub_9_Index].ChecksumType = Peak.Lin.TLINChecksumType.cstEnhanced;*/


            Msg_To_Send[Mode1_Index] = new TPCANMsg();
            Msg_To_Send[Mode1_Index].ID = 0x382;
            Msg_To_Send[Mode1_Index].LEN = 8;
            Msg_To_Send[Mode1_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[Mode1_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Msg_To_Send[Mode2_Index] = new TPCANMsg();
            Msg_To_Send[Mode2_Index].ID = 0x383;
            Msg_To_Send[Mode2_Index].LEN = 8;
            Msg_To_Send[Mode2_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[Mode2_Index].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control] = new TPCANMsg();
            Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control].ID = 0x426;
            Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control].LEN = 8;
            Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control].DATA = new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };



        }


        private void MainWnd_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().MaxWorkingSet = (IntPtr)750000;
            PM_Tools_SelfReceive.Checked = m_pRcvFrames.SelfReceive;
            Peak.Lin.PLinApi.IdentifyHardware(m_hHw);
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
            //Thread time_Lin = new Thread(timer_Lin);
            Thread time_Can = new Thread(timer_Can);
            Thread time_CanR = new Thread(timer_CanR);
            //time_Lin.Start();
            time_Can.Start();
            time_CanR.Start();
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

        private void MyTransimitFunction(Peak.Lin.TLINMsg lMsg)
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
                lHwMode = Peak.Lin.TLINHardwareMode.modSlave;

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
                        m_lMask = llMask;
                    //Set the name of connected hardware.
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
            if (LastHw != m_hHw)
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
        }


        /// <summary>
        /// Occurs when a LIN-Frame was received bei the CRcvFrameList.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An FrameReceivedEventArgs that contains the event data.</param>
        /// 
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
                {// The entry exits already but the value
                    // can replace by the values from the LIN frame.
                    // It was an emty entry.
                    lvi.Text = e.Frames[i].RcvFrame.ID;
                   
                }
                
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
                        /*switch (ID)
                        {
                            case 0x31:
                                {
                                    Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hClient, 0x31, 0, 8, E16Msg_Publisher[SPS_DR_Req_MSG_Index].Data);
                                }
                                break;
                            case 0x97:
                                {
                                    MyTransimitFunction(E16Msg_Publisher[SPS_CODR_Req_MSG_Index]);
                                }
                                break;
                            case 0x61:
                                {
                                    MyTransimitFunction(E16Msg_Publisher[SPS_2L_Req_MSG_Index]);
                                }
                                break;
                            case 0x11:
                                {
                                    MyTransimitFunction(E16Msg_Publisher[SPS_2R_Req_MSG_Index]);
                                }
                                break;
                            case 0x55:
                                {
                                    MyTransimitFunction(E16Msg_Publisher[SPS_3L_Req_MSG_Index]);
                                }
                                break;
                            case 0xE7:
                                {
                                    MyTransimitFunction(E16Msg_Publisher[SPS_3R_Req_MSG_Index]);
                                }
                                break;
                            default:
                                break;

                        }*/
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

        /// <summary>
        /// Occurs before a property value of at least one CFrameDefinition object changes.
        /// </summary>
        /// <param name="s">The source of the event</param>
        /// <param name="e">A PropertyValueChangeEventArg that contains the event data.</param>
        private void PropertyChange(object s, PropertyChangeEventArg e)
        {
            CFrameDefinition lFD;
            Peak.Lin.TLINFrameEntry lFrameEntry;
            Peak.Lin.TLINError lErr;
            ulong lMask;

            // Try to get the sender as CFrameDefinition
            lFD = (CFrameDefinition)s;
            // The sender of this event is the CFrameDefinition that
            // property should be change by User.
            if (lFD != null)
            {
                // If data length is to be set, check the value.
                if (e.Type == EProperty.Length)
                    // Only a value between 0 and 8 are valid.
                    e.Allowed = (e.Value >= 0) && (e.Value <= 8);
                // If DO NOT allow then return.
                if (!e.Allowed)
                    return;

                // Only if the hardware was initialized as Slave
                // set the direction of the LIN-Frame.
                // By the Master the direction will be used with
                // the LIN_Write and do not have to set here.
                if (m_HwMode == Peak.Lin.TLINHardwareMode.modSlave)
                {
                    // Temporary set Allowed to false is to easy
                    // return only later.
                    e.Allowed = false;

                    // Create a Frame Entry object to get
                    // and set the direction.
                    lFrameEntry = new Peak.Lin.TLINFrameEntry();
                    // Set the Frame-ID of the Frame to get and set.
                    // The ID have to set before get the entry.
                    lFrameEntry.FrameId = lFD.IdAsByte;
                    // Get the Frame Entry with the Frame-ID from
                    // the Hardware via the LinApi.
                    lErr = Peak.Lin.PLinApi.GetFrameEntry(m_hHw, ref lFrameEntry);
                    // If an error occurs do not allow to change
                    // the property and return.
                    // The Allowed parameter was set some lines before.
                    if (lErr != Peak.Lin.TLINError.errOK)
                        return;
                    // Switch between the different kind of property types.
                    switch (e.Type)
                    {
                        // Direction property should be set
                        case EProperty.Direction:
                            lFrameEntry.Direction = (Peak.Lin.TLINDirection)e.Value;
                            break;
                        // Length property should be set
                        case EProperty.Length:
                            lFrameEntry.Length = Convert.ToByte(e.Value);
                            break;
                        // ChecksumType property should be set
                        case EProperty.ChecksumType:
                            lFrameEntry.ChecksumType = (Peak.Lin.TLINChecksumType)e.Value;
                            break;
                    }
                    lFrameEntry.Flags = Peak.Lin.PLinApi.FRAME_FLAG_RESPONSE_ENABLE;
                    lErr = Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref lFrameEntry);
                    // If an error occurs do not allow to change
                    // the property and return.
                    // The Allowed parameter was set some lines before.
                    if (lErr != Peak.Lin.TLINError.errOK)
                        return;

                    // Temporary set Allowed to true for next check.
                    // The action was successfull on this line.
                    e.Allowed = true;
                }

                // If the property 'Direction' of one
                // CFrameDefinition will be changed,
                // here we need a special request to set
                // the client filter.
                if (e.Type == EProperty.Direction)
                {
                    // If the new value for the property 'Direction'
                    // should NOT be 'Disabled' check first if
                    // the CFrameDefinition is defined already with some
                    // other value then 'Disabled'.
                    if ((Peak.Lin.TLINDirection)e.Value != Peak.Lin.TLINDirection.dirDisabled)
                    {
                        if (lFD.Direction == (EDirection)Peak.Lin.TLINDirection.dirDisabled)
                        {
                            // If the old property of CFrameDefintion
                            // was set to 'Disabled' the new value
                            // means that the Frame-ID have to add to
                            // the client filter by the LinApi.
                            // Set the client filter.
                            // The Filter is a bit mask.
                            lMask = (ulong)1 << lFD.IdAsInt;
                            m_lMask = m_lMask | lMask;
                            lErr = Peak.Lin.PLinApi.SetClientFilter(m_hClient, m_hHw, m_lMask);
                            // Only allow to change the property if the Frame-ID
                            // was added successfull to the Filter.
                            e.Allowed = lErr == Peak.Lin.TLINError.errOK;
                        }
                    }
                    else
                    {
                        // If the value of direction should set on 'disable'
                        // Remove the Frame-ID from the client filter.
                        lMask = (ulong)1 << lFD.IdAsInt;
                        m_lMask = m_lMask & ~lMask;
                        lErr = Peak.Lin.PLinApi.SetClientFilter(m_hClient, m_hHw, m_lMask);
                        // Only allow to change the property if the Frame-ID
                        // was removed successfull from the Filter.
                        e.Allowed = lErr == Peak.Lin.TLINError.errOK;
                    }
                }
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
                        // Publisher[SPS_DR_Req_MSG_Index].Data[0] = 0x0;
                        // Publisher[SPS_DR_Req_MSG_Index].Data[1] = 0x0;
                        Publisher[SPS_DR_Req_MSG_Index].Data[2] = (byte)((Sig_L_SeatFrwdCustSeltn << 4) | (Sig_L_SeatRrwdCustSeltn << 5) | (Sig_L_CushFrtUpCustSeltn << 6) | (Sig_L_CushFrtDwnCustSeltn << 7));
                        Publisher[SPS_DR_Req_MSG_Index].Data[3] = (byte)((Sig_L_MasgOnOffCustSeltn) | (Sig_L_CushRrUpCustSeltn << 1) | (Sig_L_CushRrDwnCustSeltn << 2) | (Sig_L_StkSeatCustSeltnSts << 3) | (Sig_L_SeatCustSelnActSts << 4) | (Sig_L_ReclineFrwdCustSeltn << 5) | (Sig_L_ReclineRrwdCustSeltn << 6) | (Sig_L_LumbFrwdCustSeltn << 7));
                        Publisher[SPS_DR_Req_MSG_Index].Data[4] = (byte)((Sig_L_LumbRrwdCustSeltn) | (Sig_L_LumbUpCustSeltn << 1) | (Sig_L_LumbDwnCustSeltn << 2) | (Sig_L_StSwAuxCtlFltPrsnt << 3));
                        Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref tLINFrameEntry[SPS_DR_Req_MSG_Index]);
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, tLINFrameEntry[SPS_DR_Req_MSG_Index].FrameId, 0, Publisher[SPS_DR_Req_MSG_Index].Length, Publisher[SPS_DR_Req_MSG_Index].Data);   
                    }
                    break;
                case 1:
                    {
                        // Publisher[SPS_CODR_Req_MSG_Index].Data[0] = 0x0;
                        // Publisher[SPS_DR_Req_MSG_Index].Data[1] = 0x0; 
                        Publisher[SPS_CODR_Req_MSG_Index].Data[2] = (byte)((Sig_R_SeatFrwdCustSeltn << 4) | (Sig_R_SeatRrwdCustSeltn << 5) | (Sig_R_CushFrtUpCustSeltn << 6) | (Sig_R_CushFrtDwnCustSeltn << 7));
                        Publisher[SPS_CODR_Req_MSG_Index].Data[3] = (byte)((Sig_R_MasgOnOffCustSeltn) | (Sig_R_CushRrUpCustSeltn << 1) | (Sig_R_CushRrDwnCustSeltn << 2) | (Sig_R_StkSeatCustSeltnSts << 3) | (Sig_R_SeatCustSelnActSts << 4) | (Sig_R_ReclineFrwdCustSeltn << 5) | (Sig_R_ReclineRrwdCustSeltn << 6) | (Sig_R_LumbFrwdCustSeltn << 7));
                        Publisher[SPS_CODR_Req_MSG_Index].Data[4] = (byte)((Sig_R_LumbRrwdCustSeltn) | (Sig_R_LumbUpCustSeltn << 1) | (Sig_R_LumbDwnCustSeltn << 2) | (Sig_R_StSwAuxCtlFltPrsnt << 3));
                        Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref tLINFrameEntry[SPS_CODR_Req_MSG_Index]);
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, tLINFrameEntry[SPS_CODR_Req_MSG_Index].FrameId, 0, Publisher[SPS_CODR_Req_MSG_Index].Length, Publisher[SPS_CODR_Req_MSG_Index].Data);
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
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, tLINFrameEntry[SPS_CODR_Req_MSG_Index].FrameId, 0, Publisher[SPS_2L_Req_MSG_Index].Length, Publisher[SPS_2L_Req_MSG_Index].Data);
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
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, tLINFrameEntry[SPS_2R_Req_MSG_Index].FrameId, 0, Publisher[SPS_2R_Req_MSG_Index].Length, Publisher[SPS_2R_Req_MSG_Index].Data);
                    }
                    break;
                case 4:
                    {
                        Publisher[SPS_3L_Req_MSG_Index].Data[0] = 0x0;
                        Publisher[SPS_3L_Req_MSG_Index].Data[1] = 0x0;
                        Publisher[SPS_3L_Req_MSG_Index].Data[2] = (byte)((Sig_SPS_3L_AcsMdExtRclSwActv) | (Sig_SPS_3L_ThdRStExpdSwActv << 1) | (Sig_SPS_3L_ThdRStFrwdSwActv << 2) | (Sig_SPS_3L_ThdRStBkwdSwActv << 3) | (Sig_SPS_3L_ThdRwStBkReclnUpwdSwActv << 4) | (Sig_SPS_3L_ThdRwStBkReclnDnwdSwActv << 5));
                        Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref tLINFrameEntry[SPS_3L_Req_MSG_Index]);
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, tLINFrameEntry[SPS_3L_Req_MSG_Index].FrameId, 0, Publisher[SPS_3L_Req_MSG_Index].Length, Publisher[SPS_3L_Req_MSG_Index].Data);
                    }
                    break;
                case 5:
                    {
                        Publisher[SPS_3R_Req_MSG_Index].Data[0] = 0x0;
                        Publisher[SPS_3R_Req_MSG_Index].Data[1] = 0x0;
                        Publisher[SPS_3R_Req_MSG_Index].Data[2] = (byte)((Sig_SPS_3R_AcsMdExtRtRclSwActv << 4) | (Sig_SPS_3R_ThdRRtStExpdSwActv << 5) | (Sig_SPS_3R_ThdRwRtStFrwdSwActv << 6) | (Sig_SPS_3R_ThdRwRtStBkwdSwActv << 7) | (Sig_SPS_3R_ThdRwRtStBkReclnUpwdSwActv << 1) | (Sig_SPS_3R_ThdRwRtStBkReclnDnwdSwActv << 2));
                        Peak.Lin.PLinApi.SetFrameEntry(m_hClient, m_hHw, ref tLINFrameEntry[SPS_3R_Req_MSG_Index]);
                        tLINError = Peak.Lin.PLinApi.UpdateByteArray(m_hClient, m_hHw, tLINFrameEntry[SPS_3R_Req_MSG_Index].FrameId, 0, Publisher[SPS_3R_Req_MSG_Index].Length, Publisher[SPS_3R_Req_MSG_Index].Data);
                    }
                    break;
            }
        }

        private void Get_CanData(byte index)
        {
            switch(index)
            {
                case 0:
                    {
                        Msg_To_Send[Mode1_Index].DATA[0] = (byte)((Sig382_2L_SecRwLtStFrwdHMI2LReq << 7) | (Sig382_2L_SecRwLtStBkwdHMI2LReq << 6) | (Sig382_2L_SecRwLtStBkReclnUpwdHMI2LReq << 5) | (Sig382_2L_SecRwLtStBkReclnDnwdHMI2LReq << 4) | (Sig382_2L_SecRwLtStLgrstUpwdHMI2LReq << 3) | (Sig382_2L_SecRwLtStLgrstDnwdHMI2LReq << 2) | (Sig382_2L_SecRwLtStLtwdHMI2LReq << 1) | (Sig382_2L_SecRwLtStRtwdHMI2LReq));
                        Msg_To_Send[Mode1_Index].DATA[1] = (byte)((Sig382_2L_SecRwLtStHdrstUpwdHMI2LReq << 7) | (Sig382_2L_SecRwLtStHdrstDnwdHMI2LReq << 6) | (Sig382_2L_SecRwLtStMemHMI2LReq << 5) | (Sig382_2L_SecRwLtStLmbrHMI2LReq << 2));
                        Msg_To_Send[Mode1_Index].DATA[2] = (byte)((Sig382_2L_SecRwLtStMassMdHMI2LReq << 7) | (Sig382_2L_SecRwLtStMassStrsHMI2LReq << 3));
                        Msg_To_Send[Mode1_Index].DATA[3] = (byte)((Sig_L_LtStFtUpwdHMI2LReq << 7) | (Sig_L_LtStFtDnwdHMI2LReq << 6 ) | (Sig382_2L_SecRwLtStFtUpwdHMI2LReq << 7) | (Sig382_2L_SecRwLtStFtDnwdHMI2LReq << 6) | (Sig382_2L_SecRwLtStArmScrnHMI2LReq << 5)| (Sig_SecRwLtStArmScrnHMI2LReq << 5) | (Sig382_2L_VIPMdHMI2LRclReq << 4) | (Sig382_2L_AcsMdExtMdHMI2LRclReq << 2) | (Sig382_2L_RcvyMdHMI2LRclReq));
                        Msg_To_Send[Mode1_Index].DATA[4] = (byte)(Sig382_2L_SecRwLtStChldLkLReq << 6);
                    }
                    break;
                case 1:
                    {
                        Msg_To_Send[Mode2_Index].DATA[0] = (byte)((Sig383_2R_SecRwRtStFrwdHMI2RReq << 7) | (Sig383_2R_SecRwRtStBkwdHMI2RReq << 6) | (Sig383_2R_SecRwRtStBkReclnUpwdHMI2RReq << 5) | (Sig383_2R_SecRwRtStBkReclnDnwdHMI2RReq << 4) | (Sig383_2R_SecRwRtStLgrstUpwdHMI2RReq << 3) | (Sig383_2R_SecRwRtStLgrstDnwdHMI2RReq << 2) | (Sig383_2R_SecRwRtStLtwdHMI2RReq << 1) | (Sig383_2R_SecRwRtStRtwdHMI2RReq));
                        Msg_To_Send[Mode2_Index].DATA[1] = (byte)((Sig383_2R_SecRwRtStHdrstUpwdHMI2RReq << 7) | (Sig383_2R_SecRwRtStHdrstDnwdHMI2RReq << 6) | (Sig383_2R_SecRwRtStMemHMI2RReq << 5) | (Sig383_2R_SecRwRtStArmScrnHMI2RReq << 2) | (Sig_SecRwRtStArmScrnHMI2RReq << 2) | (Sig383_2R_VIPMdHMI2RRclReq <<1));
                        Msg_To_Send[Mode2_Index].DATA[2] = (byte)((Sig383_2R_SecRwRtStFtUpwdHMI2RReq << 7) | (Sig383_2R_SecRwRtStFtDnwdHMI2RReq << 6) | (Sig383_2R_BosSWFrwdHMI2RReq << 5) | (Sig383_2R_BosSWBkwdHMI2RReq << 4) | (Sig383_2R_BosSWStBkReclnUpwdHMI2RReq << 3) | (Sig383_2R_BosSWStBkReclnDnwdHMI2RReq << 2) | (Sig383_2R_SecRwRtStLmbrHMI2RReq << 1));
                        Msg_To_Send[Mode2_Index].DATA[3] = (byte)((Sig383_2R_SecRwRtStMassMdHMI2RReq << 6) | (Sig383_2R_SecRwRtStMassStrsHMI2RReq << 2));
                        Msg_To_Send[Mode2_Index].DATA[4] = (byte)((Sig383_2R_AcsMdExtMdHMI2RRclReq << 7) | (Sig383_2R_RcvyMdHMI2RRclReq << 5) | (Sig383_2R_SecRwRtStChldLkLReq << 3));
                    }
                    break;
                case 2:
                    {
                        Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control].DATA[0] = (byte)(Sig426_SecRwRtStHtCshnDtyCycl);
                        Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control].DATA[1] = (byte)(Sig426_SecRwRtStHtBkDtyCycl);
                        Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control].DATA[2] = (byte)(Sig426_SecRwRtStVntDtyCycl);
                        Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control].DATA[3] = (byte)(Sig426_SecRwLtStHtCshnDtyCycl);
                        Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control].DATA[4] = (byte)(Sig426_SecRwLtStHtBkDtyCycl);
                        Msg_To_Send[Second_Row_Seat_Heat_Cool_Duty_Cycle_Control].DATA[5] = (byte)(Sig426_SecRwLtStVntDtyCycl);
                    }
                    break;
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

        private void L_SeatFrwdCustSeltn_CheckedChanged(object sender, EventArgs e)
        {
            if(L_SeatFrwdCustSeltn.Checked ==true)
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

        private void SPS_2L_SecRwStLmbrUpwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            Get_LinData(2);
        }

        private void SPS_2L_SecRwStLmbrBkwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            Get_LinData(2);
        }

        private void SPS_2L_SecRwStLmbrFrwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
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

        private void SPS_2L_SecRwStLmbrDnwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            Get_LinData(2);
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

        private void SPS_2R_SecRwStLmbrUpwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            Get_LinData(3);
        }

        private void SPS_2R_SecRwStLmbrBkwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            Get_LinData(3);
        }

        private void SPS_2R_SecRwStLmbrFrwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
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

        private void SPS_2R_SecRwStLmbrDnwdSwActv_CheckedChanged(object sender, EventArgs e)
        {
            Get_LinData(3);
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

        private void SRLSL_HMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SRLSL_HMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStLtwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStLtwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SRLSR_HMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SRLSR_HMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStRtwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStRtwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SRRSL_HMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SRRSL_HMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStLtwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStLtwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SRRSR_HMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SRRSR_HMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStRtwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStRtwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            uint u16_RequestID = (uint)numericUpDown1.Value;

            Msg_To_Send[NetWork_Index] = new TPCANMsg();
            Msg_To_Send[NetWork_Index].ID = u16_RequestID;
            Msg_To_Send[NetWork_Index].LEN = 8;
            Msg_To_Send[NetWork_Index].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Msg_To_Send[NetWork_Index].DATA = new byte[8];

            string str;
            int Len = 0;
            int res = 0;
            Len = textBox1.TextLength / 3;
            res = textBox1.TextLength % 3;

            if (res != 0)
            {
                Len += 1;
            }

            str = textBox1.Text;
            int SendLen = 0;
            int SendedLen = 0;
            for (byte index = 0; index < Len; index++)
            {
                MsgSend_Data[index] = (byte)((chkdatachar(str[index * 3]) << 4) | chkdatachar(str[index * 3 + 1]));
                SendLen += 1;
            }
            Msg_To_Send[NetWork_Index].DATA[0] = MsgSend_Data[SendedLen++];
            Msg_To_Send[NetWork_Index].DATA[1] = MsgSend_Data[SendedLen++];
            Msg_To_Send[NetWork_Index].DATA[2] = MsgSend_Data[SendedLen++];
            Msg_To_Send[NetWork_Index].DATA[3] = MsgSend_Data[SendedLen++];
            Msg_To_Send[NetWork_Index].DATA[4] = MsgSend_Data[SendedLen++];
            Msg_To_Send[NetWork_Index].DATA[5] = MsgSend_Data[SendedLen++];
            Msg_To_Send[NetWork_Index].DATA[6] = MsgSend_Data[SendedLen++];
            Msg_To_Send[NetWork_Index].DATA[7] = MsgSend_Data[SendedLen++];
        }

        private void SecRwLtStFrwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if(SecRwLtStFrwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStFrwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStFrwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStBkwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStBkwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStBkwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStBkwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStBkReclnUpwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStBkReclnUpwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStBkReclnUpwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStBkReclnUpwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStBkReclnDnwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStBkReclnDnwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStBkReclnDnwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStBkReclnDnwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStLgrstUpwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStLgrstUpwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStLgrstUpwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStLgrstUpwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStLgrstDnwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStLgrstDnwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStLgrstDnwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStLgrstDnwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStLtwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStLtwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStLtwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStLtwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStRtwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStRtwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStRtwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStRtwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStHdrstUpwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStHdrstUpwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStHdrstUpwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStHdrstUpwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStHdrstDnwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStHdrstDnwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStHdrstDnwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStHdrstDnwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStMemHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStMemHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStMemHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStMemHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStLmbrHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStLmbrHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStLmbrHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStLmbrHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStMassMdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStMassMdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStMassMdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStMassMdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStMassStrsHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStMassStrsHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStMassStrsHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStMassStrsHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStFtUpwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStFtUpwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStFtUpwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStFtUpwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStFtDnwdHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStFtDnwdHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStFtDnwdHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStFtDnwdHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStArmScrnHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStArmScrnHMI2LReq.Checked == true)
            {
                Sig382_2L_SecRwLtStArmScrnHMI2LReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStArmScrnHMI2LReq = 0;
            }
            Get_CanData(0);
        }

        private void VIPMdHMI2LRclReq_CheckedChanged(object sender, EventArgs e)
        {
            if (VIPMdHMI2LRclReq.Checked == true)
            {
                Sig382_2L_VIPMdHMI2LRclReq = 1;
            }
            else
            {
                Sig382_2L_VIPMdHMI2LRclReq = 0;
            }
            Get_CanData(0);
        }

        private void AcsMdExtMdHMI2LRclReq_CheckedChanged(object sender, EventArgs e)
        {
            if (AcsMdExtMdHMI2LRclReq.Checked == true)
            {
                Sig382_2L_AcsMdExtMdHMI2LRclReq = 1;
            }
            else
            {
                Sig382_2L_AcsMdExtMdHMI2LRclReq = 0;
            }
            Get_CanData(0);
        }

        private void RcvyMdHMI2LRclReq_CheckedChanged(object sender, EventArgs e)
        {
            if (RcvyMdHMI2LRclReq.Checked == true)
            {
                Sig382_2L_RcvyMdHMI2LRclReq = 1;
            }
            else
            {
                Sig382_2L_RcvyMdHMI2LRclReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwLtStChldLkLReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwLtStChldLkLReq.Checked == true)
            {
                Sig382_2L_SecRwLtStChldLkLReq = 1;
            }
            else
            {
                Sig382_2L_SecRwLtStChldLkLReq = 0;
            }
            Get_CanData(0);
        }

        private void SecRwRtStFrwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if(SecRwRtStFrwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStFrwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStFrwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStBkwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStBkwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStBkwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStBkwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStBkReclnUpwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStBkReclnUpwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStBkReclnUpwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStBkReclnUpwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStBkReclnDnwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStBkReclnDnwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStBkReclnDnwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStBkReclnDnwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStLgrstUpwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStLgrstUpwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStLgrstUpwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStLgrstUpwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStLgrstDnwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStLgrstDnwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStLgrstDnwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStLgrstDnwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStLtwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStLtwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStLtwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStLtwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStRtwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStRtwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStRtwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStRtwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStHdrstUpwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStHdrstUpwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStHdrstUpwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStHdrstUpwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStHdrstDnwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStHdrstDnwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStHdrstDnwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStHdrstDnwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStMemHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStMemHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStMemHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStMemHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStArmScrnHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStArmScrnHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStArmScrnHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStArmScrnHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void VIPMdHMI2RRclReq_CheckedChanged(object sender, EventArgs e)
        {
            if (VIPMdHMI2RRclReq.Checked == true)
            {
                Sig383_2R_VIPMdHMI2RRclReq = 1;
            }
            else
            {
                Sig383_2R_VIPMdHMI2RRclReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStFtUpwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStFtUpwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStFtUpwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStFtUpwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStFtDnwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStFtDnwdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStFtDnwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStFtDnwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void BosSWFrwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (BosSWFrwdHMI2RReq.Checked == true)
            {
                Sig383_2R_BosSWFrwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_BosSWFrwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void BosSWBkwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (BosSWBkwdHMI2RReq.Checked == true)
            {
                Sig383_2R_BosSWBkwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_BosSWBkwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void BosSWStBkReclnUpwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (BosSWStBkReclnUpwdHMI2RReq.Checked == true)
            {
                Sig383_2R_BosSWStBkReclnUpwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_BosSWStBkReclnUpwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void BosSWStBkReclnDnwdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (BosSWStBkReclnDnwdHMI2RReq.Checked == true)
            {
                Sig383_2R_BosSWStBkReclnDnwdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_BosSWStBkReclnDnwdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStLmbrHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStLmbrHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStLmbrHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStLmbrHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStMassMdHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStMassMdHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStMassMdHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStMassMdHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStMassStrsHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStMassStrsHMI2RReq.Checked == true)
            {
                Sig383_2R_SecRwRtStMassStrsHMI2RReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStMassStrsHMI2RReq = 0;
            }
            Get_CanData(1);
        }

        private void AcsMdExtMdHMI2RRclReq_CheckedChanged(object sender, EventArgs e)
        {
            if (AcsMdExtMdHMI2RRclReq.Checked == true)
            {
                Sig383_2R_AcsMdExtMdHMI2RRclReq = 1;
            }
            else
            {
                Sig383_2R_AcsMdExtMdHMI2RRclReq = 0;
            }
            Get_CanData(1);
        }

        private void RcvyMdHMI2RRclReq_CheckedChanged(object sender, EventArgs e)
        {
            if (RcvyMdHMI2RRclReq.Checked == true)
            {
                Sig383_2R_RcvyMdHMI2RRclReq = 1;
            }
            else
            {
                Sig383_2R_RcvyMdHMI2RRclReq = 0;
            }
            Get_CanData(1);
        }

        private void SecRwRtStChldLkLReq_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStChldLkLReq.Checked == true)
            {
                Sig383_2R_SecRwRtStChldLkLReq = 1;
            }
            else
            {
                Sig383_2R_SecRwRtStChldLkLReq = 0;
            }
            Get_CanData(1);
        }

        private void L_SecRwLtStArmScrnHMI2LReq_CheckedChanged(object sender, EventArgs e)
        {
            Get_CanData(0);
        }

        private void R_SecRwRtStArmScrnHMI2RReq_CheckedChanged(object sender, EventArgs e)
        {
            Get_CanData(1);
        }

        private void SecRwLtStHtDtyCycl_CheckedChanged(object sender, EventArgs e)
        {
            if(SecRwLtStHtDtyCycl.Checked == true)
            {
                Sig426_SecRwLtStHtCshnDtyCycl = 0xE5;
                Sig426_SecRwLtStHtBkDtyCycl = 0xE5;
            }
            else
            {
                Sig426_SecRwLtStHtCshnDtyCycl = 0x00;
                Sig426_SecRwLtStHtBkDtyCycl = 0x00;
            }
            Get_CanData(2);
        }

        private void SecRwLtStVntDtyCycl_CheckedChanged(object sender, EventArgs e)
        {
            if(SecRwLtStVntDtyCycl.Checked == true)
            {
                Sig426_SecRwLtStVntDtyCycl = 0xE5;
            }
            else
            {
                Sig426_SecRwLtStVntDtyCycl = 0x00;
            }
            Get_CanData(2);
        }

        private void SecRwRtStHtDtyCycl_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStHtDtyCycl.Checked == true)
            {
                Sig426_SecRwRtStHtCshnDtyCycl = 0xE5;
                Sig426_SecRwRtStHtBkDtyCycl = 0xE5;
            }
            else
            {
                Sig426_SecRwRtStHtCshnDtyCycl = 0x00;
                Sig426_SecRwRtStHtBkDtyCycl = 0x00;
            }
            Get_CanData(2);
        }

        private void SecRwRtStVntDtyCycl_CheckedChanged(object sender, EventArgs e)
        {
            if (SecRwRtStVntDtyCycl.Checked == true)
            {
                Sig426_SecRwRtStVntDtyCycl = 0xE5;
            }
            else
            {
                Sig426_SecRwRtStVntDtyCycl = 0x00;
            }
            Get_CanData(2);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void L_CushOpenSeltn_CheckedChanged(object sender, EventArgs e)
        {
            /* TODO */
        }

        private void L_CushCloseSeltn_CheckedChanged(object sender, EventArgs e)
        {
            /* TODO */
        }

        private void R_CushOpenSeltn_CheckedChanged(object sender, EventArgs e)
        {
            /* TODO */
        }

        private void R_CushCloseSeltn_CheckedChanged(object sender, EventArgs e)
        {
            /* TODO */
        }

        private void Row1L_Heat_Req_CheckedChanged(object sender, EventArgs e)
        {
            /* TODO */
        }

        private void Row1L_Vent_Req_CheckedChanged(object sender, EventArgs e)
        {
            /* TODO */
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
