using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections;

using Peak.Can.Basic;
using TPCANHandle = System.UInt16;
using TPCANBitrateFD = System.String;
using TPCANTimestampFD = System.UInt64;
using System.Data.OleDb;

namespace Can_Basic_Model
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceCounter(ref long x);
        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceFrequency(ref long x);

        bool Is_Exit_Flag = false;

        string txtBitrate = "f_clock_mhz=20, nom_brp=5, nom_tseg1=2, nom_tseg2=1, nom_sjw=1, data_brp=2, data_tseg1=3, data_tseg2=1, data_sjw=1";
        string path = AppDomain.CurrentDomain.BaseDirectory;
        string fileType;
        string fileName = "生产工具详细步骤.xlsx";
        string connStr;
        StringBuilder arr = new StringBuilder();

        DataSet dataset = new DataSet();//用来存放数据 用来存放DataTable

        TPCANMsg[] TPCANMsg = new TPCANMsg[7];

        UInt16 network = 6;

        string ExcelData;

        bool KeepMdFlag = false;
        bool SeedMdFlag = false;
        bool FCFlag = true;
        bool LongFlag = false;

        int Step3_SingleFlag = 0;
        int Flag = 0;
        int TimerKeep5sCnt = 0;
        int SendLen = 0;
        int SendedLen = 0;
        int TimerKeep4sCnt = 0;
        int Send10Timer = 0;
        int timer_counter = 0;
        int boot_counter = 0;
        int app_counter = 0;

        byte year;
        byte month;
        byte day;
            

        double seatPlace = 0;
        byte posInfo = (byte)0;

        byte FRAME2;
        byte FCCnt = 0;
        byte data;
        byte[] MsgSend_Data = new byte[80];
        uint ReceiveID;


        private void Form1_Load(object sender, EventArgs e)
        {
            
            Excelinput();
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    TPCANMsg[i].ID = (uint)(Int32.Parse(dataset.Tables[0].Rows[i + 1][1].ToString(), System.Globalization.NumberStyles.HexNumber));
                    //TPCANMsg[i].ID = (uint)(System.Text.Encoding(dataset.Tables[0].Rows[i+1][1].ToString());
                    TPCANMsg[i].LEN = 8;
                    TPCANMsg[i].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_EXTENDED;
                    TPCANMsg[i].DATA = new byte[8] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, };
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("tx" + ex.Message);
                System.Environment.Exit(0);
                Is_Exit_Flag = true;
            }

            PCANBasic.Initialize(PCANBasic.PCAN_USBBUS1, TPCANBaudrate.PCAN_BAUD_500K);
            
            TPCANMsg[network].ID = 0x65E;
            TPCANMsg[network].LEN = 8;
            TPCANMsg[network].MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            TPCANMsg[network].DATA = new byte[8] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, };

            //System.DateTime currentTime = new System.DateTime();
            year = hexToBCD(Convert.ToByte(DateTime.Today.ToString("yy")));
            month = hexToBCD(Convert.ToByte(DateTime.Today.ToString("MM")));
            day = hexToBCD(Convert.ToByte(DateTime.Today.ToString("dd")));

            Thread Write_th = new Thread(Write_Function);
            Thread Read_th = new Thread(Read_Function);
            Write_th.Start();
            Read_th.Start();
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

        static void delay_1ms()
        {
            bool flag = true;
            long a = 0;
            QueryPerformanceFrequency(ref a);
            long b = 0, c = 0;
            QueryPerformanceCounter(ref b);
            while (flag)
            {
                QueryPerformanceCounter(ref c);
                double f = (c - b) / (double)a;
                if (f > 0.001)//0.001:1ms
                {
                    flag = false;
                }
            }
            QueryPerformanceCounter(ref c);
        }

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Init_CheckedChanged(object sender, EventArgs e)
        {
            
            /*
            if (Init.Checked == true)
            {
                if (Can_FD.Checked == false)
                {
                    PCANBasic.Initialize(PCANBasic.PCAN_USBBUS1, TPCANBaudrate.PCAN_BAUD_500K);
                }
                else
                {
                    PCANBasic.InitializeFD(PCANBasic.PCAN_USBBUS1, txtBitrate);
                }
                Can_FD.Enabled = false;
                
            }
            else
            {
                Write_th.Abort();
                Read_th.Abort();
                PCANBasic.Uninitialize(PCANBasic.PCAN_USBBUS1);
                Can_FD.Enabled = true;
            }
            */
        }

        void Write_Function()
        {
            while (Is_Exit_Flag == false)
            {
                delay_10ms();
                timer_counter++;
                if (timer_counter == 5 )
                {
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref TPCANMsg[network]);
                    timer_counter = 0;
                }
                if (KeepMdFlag == true)
                {
                    TimerKeep4sCnt++;
                    if (TimerKeep4sCnt >= 3950)
                    {
                        TimerKeep4sCnt = 0;
                        TPCANMsg[Seat.SelectedIndex].DATA[0] = 0x3E;
                        TPCANMsg[Seat.SelectedIndex].DATA[1] = 0x80;
                        TPCANMsg[Seat.SelectedIndex].DATA[2] = 0x00;
                        TPCANMsg[Seat.SelectedIndex].DATA[3] = 0x00;
                        TPCANMsg[Seat.SelectedIndex].DATA[4] = 0x00;
                        TPCANMsg[Seat.SelectedIndex].DATA[5] = 0x00;
                        TPCANMsg[Seat.SelectedIndex].DATA[6] = 0x00;
                        TPCANMsg[Seat.SelectedIndex].DATA[7] = 0x00;
                        PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref TPCANMsg[Seat.SelectedIndex]);
                        richTextBox1.Text += TPCANMsg[Seat.SelectedIndex].ID.ToString("X2") + " " + "Tx" + " " + DATAShown(TPCANMsg[Seat.SelectedIndex].DATA) + "\n";
                    }
                }
                if ((SeedMdFlag == true) && (FCFlag == false))
                {
                    if ((SendLen > SendedLen) && (TimerKeep5sCnt >= 10))
                    {
                        TimerKeep5sCnt = 0;
                        if (SendedLen == 0)
                        {
                            FCFlag = true;
                            FCCnt = 0x20;
                            TPCANMsg[Seat.SelectedIndex].DATA[0] = MsgSend_Data[SendedLen++];
                        }
                        else
                        {
                            FCCnt += 1;
                            TPCANMsg[Seat.SelectedIndex].DATA[0] = (byte)FCCnt;
                        }

                        TPCANMsg[Seat.SelectedIndex].DATA[1] = MsgSend_Data[SendedLen++];
                        TPCANMsg[Seat.SelectedIndex].DATA[2] = MsgSend_Data[SendedLen++];
                        TPCANMsg[Seat.SelectedIndex].DATA[3] = MsgSend_Data[SendedLen++];
                        TPCANMsg[Seat.SelectedIndex].DATA[4] = MsgSend_Data[SendedLen++];
                        TPCANMsg[Seat.SelectedIndex].DATA[5] = MsgSend_Data[SendedLen++];
                        TPCANMsg[Seat.SelectedIndex].DATA[6] = MsgSend_Data[SendedLen++];
                        TPCANMsg[Seat.SelectedIndex].DATA[7] = MsgSend_Data[SendedLen++];
                        PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref TPCANMsg[Seat.SelectedIndex]);
                        richTextBox1.Text += TPCANMsg[Seat.SelectedIndex].ID.ToString("X2") + " " + "Tx" + " " + DATAShown(TPCANMsg[Seat.SelectedIndex].DATA) + "\n";
                        
                    }
                    else if (SendLen <= SendedLen)
                    {
                        SeedMdFlag = false;
                    }
                    if (TimerKeep5sCnt <= 10)
                    {
                        TimerKeep5sCnt++;
                    }
                }
            }
        }

        void Read_Function()
        {
            while(Is_Exit_Flag == false)
            {
                ReadMessages();
            }
            
        }

        private void analyzeMessageFD(TPCANMsgFD CANMsg)
        {

        }

        private void analyzeMessage(TPCANMsg CANMsg)
        {
            if(CANMsg.ID == ReceiveID)
            {
                richTextBox1.Text += CANMsg.ID.ToString("X2") + " " + "Rx" + " " + DATAShown(CANMsg.DATA) + "\n";
                if (CANMsg.DATA[0] == 0x10)
                {
                    FRAME2 = CANMsg.DATA[1];
                    TPCANMsg[(int)Seat.SelectedIndex].DATA[0] = 0x30;
                    TPCANMsg[(int)Seat.SelectedIndex].DATA[1] = 0x08;
                    TPCANMsg[(int)Seat.SelectedIndex].DATA[2] = 0x14;
                    TPCANMsg[(int)Seat.SelectedIndex].DATA[3] = 0x00;
                    TPCANMsg[(int)Seat.SelectedIndex].DATA[4] = 0x00;
                    TPCANMsg[(int)Seat.SelectedIndex].DATA[5] = 0x00;
                    TPCANMsg[(int)Seat.SelectedIndex].DATA[6] = 0x00;
                    TPCANMsg[(int)Seat.SelectedIndex].DATA[7] = 0x00;
                    PCANBasic.Write(PCANBasic.PCAN_USBBUS1,ref TPCANMsg[(int)Seat.SelectedIndex]);
                    richTextBox1.Text += TPCANMsg[Seat.SelectedIndex].ID.ToString("X2") + " " + "Tx" + " " + DATAShown(TPCANMsg[Seat.SelectedIndex].DATA) + "\n";
                    
                }
                else if (CANMsg.DATA[0] == 0x30)
                {
                    FCFlag = false;
                }
                if ((Flag == 1) && (CANMsg.DATA[1] == 0x50))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    KeepMdFlag = true;
                    Step();
                }
                if((Flag == 2) && ((CANMsg.DATA[2] & 0x07) == 0x07))
                {
                    FRAME2 = CANMsg.DATA[1];
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                }
                if((Flag == 3) && ((CANMsg.DATA[0] == 0x24) || (Math.Ceiling(((decimal)FRAME2 - 6) / 7) == (int)(CANMsg.DATA[0] - 0x20))))
                {
                    LongdataStep();//等待第二帧反馈完成
                }
                if((Flag == 3) && (CANMsg.DATA[0] == 0x02) && (CANMsg.DATA[1] == 0x67)) //&& (CANMsg.DATA[2] == 0x0E))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    Step();
                }
                if ((Flag == 4) && (CANMsg.DATA[0] == 0x02) && (CANMsg.DATA[1] == 0x68)) //&& (CANMsg.DATA[2] == 0x0E))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    Send10Timer = 15;
                    Step();
                }
                if ((Flag ==5) && (CANMsg.DATA[0] == 0x03) && (CANMsg.DATA[1] == 0x6E) && (Send10Timer != 0))
                {
                    Send10Timer--;
                    Step();//写10次
                }
                else if((Flag == 5) && (CANMsg.DATA[2] == 0xF1) && (CANMsg.DATA[3] == 0xA0) && (Send10Timer == 0))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    Step();//读63
                }
                if((Flag == 6) && (CANMsg.DATA[0] == 0x04) && (CANMsg.DATA[1] == 0x62) && (CANMsg.DATA[4] == 0x00) && (Send10Timer == 0))
                {
                    Flag--;
                    Send10Timer = 15;
                    Step();//写10次
                }
                if((Flag == 6) && (CANMsg.DATA[0] == 0x04) && (CANMsg.DATA[1] == 0x62) && (CANMsg.DATA[4] == 0x63) && (Send10Timer == 0))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    Send10Timer = 15;
                    Step();//写FE
                }
                if((Flag == 7) && (CANMsg.DATA[0] == 0x03) && (CANMsg.DATA[1] == 0x6E) && (Send10Timer != 0))
                {
                    Send10Timer--;
                    Step();//写10次
                }
                else if((Flag == 7) && (CANMsg.DATA[2] == 0xF1) && (CANMsg.DATA[3] == 0xA0) && (Send10Timer == 0))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    Step();
                }
                if ((Flag == 8) && (CANMsg.DATA[1] == 0x62) && (CANMsg.DATA[4] == 0x00) && (Send10Timer == 0))
                {
                    Flag--;
                    Send10Timer = 15;
                    Step();//写10次
                }
                if ((Flag == 8) && (CANMsg.DATA[0] == 0x04) && (CANMsg.DATA[1] == 0x62) && (CANMsg.DATA[4] == 0xFE) && (Send10Timer == 0))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    Step();
                }
                if((Flag == 9) && (CANMsg.DATA[2] == 0xF1) && (CANMsg.DATA[3] == 0x99))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    Step();
                }
                if ((Flag == 10) && (CANMsg.DATA[4] == 0x20) && (CANMsg.DATA[5] == year) && (CANMsg.DATA[6] == month) && (CANMsg.DATA[7] == day))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    Step();
                }
                else if((Flag >= 11) && (Flag < 20))
                {
                    if(Flag == 11)
                    {
                        byte[] arr = new byte[16];
                        byte[] data = new byte[16] { 0x43, 0x41, 0x4E, 0x4F, 0x45, 0x20, 0x44, 0x49, 0x56, 0x41, 0x20, 0x45, 0x43, 0x55, 0x49, 0x44 };
                        if (CANMsg.DATA[0] == 0x10)
                        {
                            for (int i = 5; i < 8; i++)
                            {
                                arr[i] = CANMsg.DATA[i];
                            }
                        }
                        if (CANMsg.DATA[0] == 0x21)
                        {
                            
                            for (int i = 1; i < 8; i++)
                            {
                                arr[i] = CANMsg.DATA[i];
                            }
                        }
                        if (CANMsg.DATA[0] == 0x22)
                        {
                            
                            for (int i = 1; i < 7; i++)
                            {
                                arr[i] = CANMsg.DATA[i];
                            }
                            if(arr.SequenceEqual(data)==true)
                            {
                                richTextBox2.Text += "ECUID正确";
                            }
                        }
                        
                    }
                    if(Flag == 12)
                    {
                        // string data = "544309015";
                        string data = "654573229";
                        
                        string arr1 = "";
                        string arr2 = "";
                        string ARR = "";
                        if (CANMsg.DATA[0] == 0x10)
                        {
                            arr1 = CANMsg.DATA[5].ToString("X2") + " " + CANMsg.DATA[6].ToString("X2") + " " + CANMsg.DATA[7].ToString("X2") + " ";
                            arr.Append(HexStringToASCII(arr1));
                        }
                        if (CANMsg.DATA[0] == 0x21)
                        {
                            arr2 = CANMsg.DATA[1].ToString("X2") + " " + CANMsg.DATA[2].ToString("X2") + " " + CANMsg.DATA[3].ToString("X2") + " " + CANMsg.DATA[4].ToString("X2") + " " + CANMsg.DATA[5].ToString("X2") + " " + CANMsg.DATA[6].ToString("X2");
                            arr.Append(HexStringToASCII(arr2));
                            ARR = arr.ToString();
                            if (ARR.SequenceEqual(data) == true)
                            {
                                richTextBox2.Text += "供应商邓氏编码正确" + "\n";
                                
                            }
                            arr.Remove(0, arr.Length);
                        }
                        
                        /*if (CANMsg.DATA[0] == 0x22)
                        {
                            arr3 = CANMsg.DATA[1].ToString("X2") + " " + CANMsg.DATA[2].ToString("X2") + " " + CANMsg.DATA[3].ToString("X2") + " " + CANMsg.DATA[4].ToString("X2") + " " + CANMsg.DATA[5].ToString("X2") + " " + CANMsg.DATA[6].ToString("X2");
                            arr += HexStringToASCII(arr3);
                            
                        }*/
                    }
                    if(Flag == 13)
                    {
                        string data = "";
                        string ARR = "";
                        string arr1 = "";
                        string arr2 = "";
                        string arr3 = "";
                        /*
                        switch (Seat.SelectedIndex)
                        {
                            case 0:
                                data = "8370200000000U";
                                break;
                            case 1:
                                data = "8370200000000W";
                                break;
                            case 2:
                                data = "8370200000000P";
                                break;
                            case 3:
                                data = "8370200000000S";
                                break;
                            case 4:
                                data = "8370200000000T";
                                break;
                            case 5:
                                data = "8370200000000V";
                                break;

                        }
                        */
                        switch (seatPlace)
                        {
                            case 1.11:
                                data = "8370200000000U";
                                break;
                            case 1.12:
                                data = "8370200000000U";
                                break;
                            case 1.21:
                                data = "8370200000000W";
                                break;
                            case 2.11:
                                data = "8370200000000P";
                                break;
                            case 2.12:
                                data = "8370200000000P";
                                break;
                            case 2.21:
                                data = "8370200000000S";
                                break;
                            case 2.22:
                                data = "8370200000000S";
                                break;
                            case 3.11:
                                data = "8370200000000T";
                                break;
                            case 3.12:
                                data = "8370200000000T";
                                break;
                            case 3.21:
                                data = "8370200000000V";
                                break;
                            case 3.22:
                                data = "8370200000000V";
                                break;
                        }

                        if (CANMsg.DATA[0] == 0x10)
                        {
                            arr1 = CANMsg.DATA[5].ToString("X2") + " " + CANMsg.DATA[6].ToString("X2") + " " + CANMsg.DATA[7].ToString("X2") + " ";
                            arr.Append(HexStringToASCII(arr1));
                            


                        }
                        if (CANMsg.DATA[0] == 0x21)
                        {
                            arr2 = CANMsg.DATA[1].ToString("X2") + " " + CANMsg.DATA[2].ToString("X2") + " " + CANMsg.DATA[3].ToString("X2") + " " + CANMsg.DATA[4].ToString("X2") + " " + CANMsg.DATA[5].ToString("X2") + " " + CANMsg.DATA[6].ToString("X2") + " " + CANMsg.DATA[7].ToString("X2") + " ";
                            arr.Append(HexStringToASCII(arr2));
                            
                        }
                        if (CANMsg.DATA[0] == 0x22)
                        {
                            arr3 = CANMsg.DATA[1].ToString("X2") + " " + CANMsg.DATA[2].ToString("X2") + " " + CANMsg.DATA[3].ToString("X2") + " " + CANMsg.DATA[4].ToString("X2");
                            arr.Append(HexStringToASCII(arr3));
                            ARR = arr.ToString();
                            vppsInfo.Text = ARR;
                            if (ARR.SequenceEqual(data) == true)
                            {
                                richTextBox2.Text += "VPPS码正确" + "\n";
                            }
                            else if ((CANMsg.DATA[1] == 0xFF) || (CANMsg.DATA[2] == 0xFF) || (CANMsg.DATA[3] == 0xFF) || (CANMsg.DATA[4] == 0xFF) || (CANMsg.DATA[5] == 0xFF) || (CANMsg.DATA[6] == 0xFF) || (CANMsg.DATA[7] == 0xFF))
                            {
                                Step();
                            }
                            else
                            {
                                richTextBox2.Text += "VPPS码错误" + "\n";
                                Is_Exit_Flag = true;
                            }
                            arr.Remove(0, arr.Length);
                        }
                        
                    }
                    if (Flag == 14)
                    {
                        if(CANMsg.DATA[0] == 0x10)
                        {
                            string arr = CANMsg.DATA[5].ToString("X2")  + " " + CANMsg.DATA[6].ToString("X2") + " " + CANMsg.DATA[7].ToString("X2");
                            textBox1.Text = HexStringToASCII(arr);
                        }
                        if(CANMsg.DATA[0] == 0x21)
                        {
                            string arr = CANMsg.DATA[1].ToString("X2") + " " + CANMsg.DATA[2].ToString("X2") + " " + CANMsg.DATA[3].ToString("X2") + " " + CANMsg.DATA[4].ToString("X2") + " " + CANMsg.DATA[5].ToString("X2") + " " + CANMsg.DATA[6].ToString("X2") + " " + CANMsg.DATA[7].ToString("X2");
                            textBox1.Text += HexStringToASCII(arr);
                        }
                        if(CANMsg.DATA[0] == 0x22)
                        {
                            string arr = CANMsg.DATA[1].ToString("X2") + " " + CANMsg.DATA[2].ToString("X2") + " " + CANMsg.DATA[3].ToString("X2") + " " + CANMsg.DATA[4].ToString("X2") + " " + CANMsg.DATA[5].ToString("X2") + " " + CANMsg.DATA[6].ToString("X2");
                            textBox1.Text += HexStringToASCII(arr);
                        }
                        
                    }
                    if (Flag == 15)
                    {
                        string data = "";
                        switch (seatPlace)
                        {
                            case 1.11:
                                data = "26369039";
                                break;
                            case 1.12:
                                data = "26369040";
                                break;
                            case 1.21:
                                data = "26369040";
                                break;
                            case 2.11:
                                data = "20369041";
                                break;
                            case 2.12:
                                data = "20369042";
                                break;
                            case 2.21:
                                data = "20369042";
                                break;
                            case 2.22:
                                data = "20369041";
                                break;
                            case 3.11:
                                data = "20369043";
                                break;
                            case 3.12:
                                data = "20369044";
                                break;
                            case 3.21:
                                data = "20369043";
                                break;
                            case 3.22:
                                data = "20369044";
                                break;
                        }
                        string arr = (Convert.ToInt32((CANMsg.DATA[4] << 24) | (CANMsg.DATA[5] << 16) | (CANMsg.DATA[6] << 8) | (CANMsg.DATA[7]))).ToString();
                        partNumBase.Text = arr;
                        if (arr == data)
                        {
                            richTextBox2.Text += "Base零件号正确" + "\n";
                        }
                        else
                        {
                            richTextBox2.Text += "Base零件号错误" + "\n";
                            Is_Exit_Flag = true;
                        }
                    }
                    if (Flag == 16)
                    {
                        // if ((CANMsg.DATA[4] == CANMsg.DATA[5]) && (CANMsg.DATA[4] == 0x41))
                        if ((CANMsg.DATA[4] == 0x41) && (CANMsg.DATA[5] == 0x42))
                        {
                            richTextBox2.Text += "Base零件号Alpha正确" + "\n";
                        }
                        else
                        {
                            richTextBox2.Text += "Base零件号Alpha错误" + "\n";
                            Is_Exit_Flag = true;
                        }
                    }
                    if (Flag == 17)
                    {
                        string data = "";
                        switch(seatPlace)
                        {
                            case 1.11:
                                data = "26369006";
                                break;
                            case 1.12:
                                data = "26369007";
                                break;
                            case 1.21:
                                data = "11111111";
                                break;
                            case 2.11:
                                data = "26369008";
                                break;
                            case 2.12:
                                data = "26369009";
                                break;
                            case 2.21:
                                data = "22222222";
                                break;
                            case 2.22:
                                data = "22222221";
                                break;
                            case 3.11:
                                data = "26369010";
                                break;
                            case 3.12:
                                data = "26369011";
                                break;
                            case 3.21:
                                data = "33333331";
                                break;
                            case 3.22:
                                data = "33333332";
                                break;
                        }
                        string arr = ((CANMsg.DATA[4] << 24) | (CANMsg.DATA[5] << 16) | (CANMsg.DATA[6] << 8) | (CANMsg.DATA[7])).ToString("D");
                        partNumEnd.Text = arr;
                        if (arr == data)
                        {
                            richTextBox2.Text += "End零件号正确" + "\n";
                        }
                        else
                        {
                            richTextBox2.Text += "End零件号错误" + "\n";
                            Is_Exit_Flag = true;
                        }
                    }
                    if(Flag == 18)
                    {
                        // if ((CANMsg.DATA[4] == 0x41) && (CANMsg.DATA[5] == 0x42))
                        if ((CANMsg.DATA[4] == 0x41) && (CANMsg.DATA[5] == 0x43))
                        {
                            richTextBox2.Text += "End零件号Alpha正确" + "\n";
                        }
                        else
                        {
                            richTextBox2.Text += "End零件号Alpha错误" + "\n";
                            Is_Exit_Flag = true;
                        }
                    }
                    if(Flag == 19)
                    {
                        
                        if (CANMsg.DATA[0] == 0x10)
                        {
                            boot_counter = (CANMsg.DATA[5] + CANMsg.DATA[6] + CANMsg.DATA[7]);
                        }
                        if (CANMsg.DATA[0] == 0x21)
                        {
                            boot_counter = boot_counter + CANMsg.DATA[1] + CANMsg.DATA[2] + CANMsg.DATA[3];
                            boot.Text = boot_counter.ToString("D");
                            string arr1 = CANMsg.DATA[4].ToString("X2") + " " + CANMsg.DATA[5].ToString("X2");
                            boot.Text += HexStringToASCII(arr1);
                        }

                    }

                    if(CANMsg.DATA[0] <= 0x07)
                    {
                        richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                        Flag++;
                        Step();
                    }
                    if ((CANMsg.DATA[0] != 0x10) && (Math.Ceiling(((decimal)FRAME2 - 6) / 7) == (int)(CANMsg.DATA[0] - 0x20)))
                    {
                        richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                        Flag++;
                        Step();
                    }
                }
                else if(Flag == 20)
                {
                    if (CANMsg.DATA[0] == 0x10)
                    {
                        FRAME2 = CANMsg.DATA[1];
                        app_counter = (CANMsg.DATA[5] + CANMsg.DATA[6] + CANMsg.DATA[7]);
                    }
                    if (CANMsg.DATA[0] == 0x21)
                    {
                        app_counter = (app_counter + (CANMsg.DATA[1] + CANMsg.DATA[2] + CANMsg.DATA[3]));
                        app.Text = app_counter.ToString("D");
                        string arr1 = CANMsg.DATA[4].ToString("X2") + " " + CANMsg.DATA[5].ToString("X2");
                        app.Text += HexStringToASCII(arr1);
                    }
                    if((CANMsg.DATA[0] != 0x10) && (Math.Ceiling(((decimal)FRAME2 - 6) / 7) == (int)(CANMsg.DATA[0] - 0x20)))
                    {
                        richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                        Flag++;
                        LongdataStep();
                    }
                    
                }
                if (((Flag >= 21) && (Flag < 41)) && (CANMsg.DATA[0] == 0x10) && (CANMsg.DATA[2] == 0x71) && ((CANMsg.DATA[6] == 0x00)||(CANMsg.DATA[6] == 0x03)))
                {
                    LongFlag = true;
                }
                if (((Flag >= 21) && (Flag < 41)) && (LongFlag == true) && (Math.Ceiling(((decimal)FRAME2 - 6) / 7) == (int)(CANMsg.DATA[0] - 0x20)))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    LongFlag = false;
                    LongdataStep();
                }
                if ((Flag == 41) && (CANMsg.DATA[0] == 0x10) && (CANMsg.DATA[2] == 0x71) && ((CANMsg.DATA[6] == 0x00) || (CANMsg.DATA[6] == 0x03)))
                {
                    LongFlag = true;
                }
                if((Flag == 41) && (LongFlag == true) && (CANMsg.DATA[0] != 0x10) && (Math.Ceiling(((decimal)FRAME2 - 6) / 7) == (int)(CANMsg.DATA[0] - 0x20)))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    LongFlag = false;
                    Step();
                }
                if((Flag ==42) && (CANMsg.DATA[1] == 0x6E))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    Step();
                }
                if ((Flag == 43) && (CANMsg.DATA[0] == 0x03) && (CANMsg.DATA[1] == 0x6E) && (CANMsg.DATA[2] == 0xFD))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;
                    Step();
                }
                if ((Flag == 44) && (CANMsg.DATA[0] == 0x02) && (CANMsg.DATA[1] == 0x51))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    Flag++;

                    // wait for ecu reset
                    Thread.Sleep(2000);

                    Step();
                }
                if ((Flag == 45) && (CANMsg.DATA[0] == 0x04) && (CANMsg.DATA[1] == 0x62) && (CANMsg.DATA[4] == posInfo))
                {
                    richTextBox1.Text += "烧录完成" + "\n";
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "完成" + "\n";
                    richTextBox2.Text += "烧录完成!!!!!!!!!!!!!!!!!!!!!!!!!!!" + "\n";
                    Is_Exit_Flag = true;
                }

                if (((Flag >= 21) && (Flag < 41)) && (CANMsg.DATA[0] == 0x03) && (CANMsg.DATA[1] == 0x7F) && (CANMsg.DATA[2] == 0x31))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "失败，跳过！！！" + "\n";
                    Flag++;
                    LongdataStep();
                }
                if ((Flag == 41) && (CANMsg.DATA[0] == 0x03) && (CANMsg.DATA[1] == 0x7F) && (CANMsg.DATA[2] == 0x31))
                {
                    richTextBox2.Text += "第" + Flag.ToString() + "步:" + dataset.Tables[1].Rows[Flag][1].ToString() + "失败，跳过！！！" + "\n";
                    Flag++;
                    LongFlag = false;
                    Step();
                }

                progressBar1.Value = Flag;
            }
            else
            {
                if (Flag == 45 && Is_Exit_Flag == false)
                {
                    Step();
                }
            }
        }

        private void ReadMessages()
        {
            TPCANStatus stsResult;

            // We read at least one time the queue looking for messages.
            // If a message is found, we look again trying to find more.
            // If the queue is empty or an error occurr, we get out from
            // the dowhile statement.
            //			
            do
            {
                //stsResult = Can_FD.Checked ? ReadMessageFD() : ReadMessage();
                stsResult = ReadMessage();
                if (stsResult == TPCANStatus.PCAN_ERROR_ILLOPERATION)
                    break;
            } while ((Is_Exit_Flag == true) && (!Convert.ToBoolean(stsResult & TPCANStatus.PCAN_ERROR_QRCVEMPTY)));
        }

        /// <summary>
        /// Function for reading messages on FD devices
        /// </summary>
        /// <returns>A TPCANStatus error code</returns>
        private TPCANStatus ReadMessageFD()
        {
            TPCANMsgFD CANMsg;
            TPCANTimestampFD CANTimeStamp;
            TPCANStatus stsResult;

            // We execute the "Read" function of the PCANBasic                
            //
            stsResult = PCANBasic.ReadFD(PCANBasic.PCAN_USBBUS1, out CANMsg, out CANTimeStamp);
            if (stsResult != TPCANStatus.PCAN_ERROR_QRCVEMPTY)
            // We process the received message
            //
                analyzeMessageFD(CANMsg);

            return stsResult;
        }

        private TPCANStatus ReadMessage()
        {
            TPCANMsg CANMsg;
            //TPCANTimestamp CANTimeStamp;
            TPCANStatus stsResult;

            // We execute the "Read" function of the PCANBasic                
            //
            stsResult = PCANBasic.Read(PCANBasic.PCAN_USBBUS1, out CANMsg);
            if (stsResult != TPCANStatus.PCAN_ERROR_QRCVEMPTY)
                // We process the received message
                //
                analyzeMessage(CANMsg);

            return stsResult;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Is_Exit_Flag = true;
            System.Environment.Exit(0);
            PCANBasic.Uninitialize(PCANBasic.PCAN_USBBUS1);

        }

        private DataSet Excelinput()
        {
            string extension = path.Substring(path.LastIndexOf(".") + 1, path.Length - (path.LastIndexOf(".") + 1));
            if (extension != "xlsx")
            {
                fileType = ".xlsx";
            }
            else
            {
                fileType = ".xls";
            }
            if (fileType == ".xls")
            {
                connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1\"";
            }

            else
            {
                connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1\"";
            }


            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            string sql = "select* from [诊断ID$]";
            //适配器 需要两个参数 一个是sql语句 一个是连接字符串
            OleDbDataAdapter adapater = new OleDbDataAdapter(sql, conn);
            adapater.Fill(dataset, "[诊断ID$]");//把查询到的结果放到dataset里面
            sql = "select* from [测试项$]";
            OleDbDataAdapter adapater2 = new OleDbDataAdapter(sql, conn);
            adapater2.Fill(dataset, "[测试项$]");//把查询到的结果放到dataset里面
            conn.Close();
            return dataset;
        }

        private TPCANMsg MsgToSet(double StepFlag)
        {
            TPCANMsg[Seat.SelectedIndex].DATA = LongData(dataset.Tables[1].Rows[Flag][2].ToString());
            return TPCANMsg[Seat.SelectedIndex];
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            
            Thread Write_th = new Thread(Write_Function);
            Thread Read_th = new Thread(Read_Function);
            Write_th.Start();
            Read_th.Start();
            Is_Exit_Flag = false;
            boot_counter = 0;
            app_counter = 0;
            textBox1.Text = "";
            partNumBase.Text = "";
            partNumEnd.Text = "";
            vppsInfo.Text = "";
            boot.Text = "";
            app.Text = "";
            Flag = 1;
            MsgToSet(Flag);
            PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref TPCANMsg[Seat.SelectedIndex]);
            richTextBox1.Text += DATAShown(TPCANMsg[Seat.SelectedIndex].DATA) + "\n";

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Is_Exit_Flag = true;
        }

        private void Step()
        {
            MsgToSet(Flag);
            if(Flag == 8)
            {
                System.DateTime currentTime = new System.DateTime();
                currentTime = System.DateTime.Now;
                TPCANMsg[Seat.SelectedIndex].DATA[5] = year;
                TPCANMsg[Seat.SelectedIndex].DATA[6] = month;
                TPCANMsg[Seat.SelectedIndex].DATA[7] = day;
            }

            if (Flag == 43)
            {
                TPCANMsg[Seat.SelectedIndex].DATA[4] = posInfo;
            }

            if (Flag == 45)
            {
                if (posInfo == (byte)1)
                {
                    Seat.SelectedIndex = 0;
                }
                else if (posInfo == (byte)2)
                {
                    Seat.SelectedIndex = 1;
                }
                else if (posInfo == (byte)3)
                {
                    Seat.SelectedIndex = 2;
                }
                else if (posInfo == (byte)4)
                {
                    Seat.SelectedIndex = 3;
                }
                else if (posInfo == (byte)5)
                {
                    Seat.SelectedIndex = 4;
                }
                else if (posInfo == (byte)6)
                {
                    Seat.SelectedIndex = 5;
                }
            }

            PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref TPCANMsg[Seat.SelectedIndex]);
            richTextBox1.Text += TPCANMsg[Seat.SelectedIndex].ID.ToString("X2") + " " + "Tx" + " " + DATAShown(TPCANMsg[Seat.SelectedIndex].DATA) + "\n";
            
        }

        private void LongdataStep()
        {
            ExcelData = dataset.Tables[1].Rows[Flag][2].ToString();
            LongData(ExcelData);
            SeedMdFlag = true;
            TimerKeep5sCnt = 10;
            FCFlag = false;
        }
        
        private byte[] LongData(string Longdata)
        {

            string str;
            int Len = 0;
            int res = 0;
            Len = Longdata.Length / 3;
            res = Longdata.Length % 3;

            if (res != 0)
            {
                Len += 1;
            }

            
            str = Longdata;
            SendLen = 0;
            SendedLen = 0;
            
            for (byte index = 0; index < Len; index++)
            {

                MsgSend_Data[index] = (byte)((chkdatachar(str[index * 3]) << 4) | chkdatachar(str[index * 3 + 1]));
                SendLen += 1;
            }
            return MsgSend_Data;
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
        
        private string DATAShown(byte[] a)
        {

            string text = "";
            for (int i = 0; i < a.Length; i++)
            {
                text += a[i].ToString("X2")+ " ";
            }
            return text;
        }

        private void Seat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string byteString = dataset.Tables[0].Rows[(int)Seat.SelectedIndex + 1][2].ToString();
            
            ReceiveID = UInt32.Parse(byteString, System.Globalization.NumberStyles.HexNumber);
        }

        private void Send10Times(TPCANMsg msg)
        {
            KeepMdFlag = false;
            while(Send10Timer > 0)
            {
                delay_10ms();
                PCANBasic.Write(PCANBasic.PCAN_USBBUS1, ref TPCANMsg[Seat.SelectedIndex]);
                richTextBox1.Text += TPCANMsg[Seat.SelectedIndex].ID.ToString("X2") + " " + "Tx" + " " + DATAShown(TPCANMsg[Seat.SelectedIndex].DATA) + "\n";
                Send10Timer--;
                if (Send10Timer < 0)
                {
                    KeepMdFlag = true;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionStart = this.richTextBox1.TextLength;
            this.richTextBox1.ScrollToCaret();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            this.richTextBox2.SelectionStart = this.richTextBox2.TextLength;
            this.richTextBox2.ScrollToCaret();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SigleCheck(sender);
            // Seat.SelectedIndex = 0;
            Seat.SelectedIndex = 2;
            seatPlace = 1.11;
            posInfo = (byte)1;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SigleCheck(sender);
            // Seat.SelectedIndex = 0;
            Seat.SelectedIndex = 2;
            seatPlace = 1.12;
            posInfo = (byte)1;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SigleCheck(sender);
            // Seat.SelectedIndex = 1;
            Seat.SelectedIndex = 2;
            seatPlace = 1.21;
            posInfo = (byte)2;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SigleCheck(sender);
            Seat.SelectedIndex = 2;
            seatPlace = 2.11;
            posInfo = (byte)3;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SigleCheck(sender);
            Seat.SelectedIndex = 2;
            seatPlace = 2.12;
            posInfo = (byte)3;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SigleCheck(sender);
            // Seat.SelectedIndex = 3;
            Seat.SelectedIndex = 2;
            seatPlace = 2.21;
            posInfo = (byte)4;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SigleCheck(sender);
            // Seat.SelectedIndex = 3;
            Seat.SelectedIndex = 2;
            seatPlace = 2.22;
            posInfo = (byte)4;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            SigleCheck(sender);
            // Seat.SelectedIndex = 4;
            Seat.SelectedIndex = 2;
            seatPlace = 3.11;
            posInfo = (byte)5;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            SigleCheck(sender);
            // Seat.SelectedIndex = 4;
            Seat.SelectedIndex = 2;
            seatPlace = 3.12;
            posInfo = (byte)5;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            SigleCheck(sender);
            // Seat.SelectedIndex = 5;
            Seat.SelectedIndex = 2;
            seatPlace = 3.21;
            posInfo = (byte)6;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            SigleCheck(sender);
            // Seat.SelectedIndex = 5;
            Seat.SelectedIndex = 2;
            seatPlace = 3.22;
            posInfo = (byte)6;
        }

        private void SigleCheck(object sender)
        {
            toolStripMenuItem1.Checked = false;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
        }

        /// <summary>
        /// 将一条十进制字符串转换为BCD码
        /// </summary>
        /// <param name="hex">一个十进制数</param>
        /// <returns>返回一条十六进制BCD码</returns>
        private byte hexToBCD(byte hex)
        {
            byte BCD = 0x00;
            BCD |= (byte)((hex / 10) << 4);
            BCD |= (byte)(hex % 10);
            return BCD;
        }

        /// <summary>
        /// 将一条十六进制字符串转换为ASCII
        /// </summary>
        /// <param name="hexstring">一条十六进制字符串</param>
        /// <returns>返回一条ASCII码</returns>
        public static string HexStringToASCII(string hexstring)
        {
            byte[] bt = HexStringToBinary(hexstring);
            string lin = "";
            for (int i = 0; i < bt.Length; i++)
            {
                lin = lin + bt[i] + " ";
            }


            string[] ss = lin.Trim().Split(new char[] { ' ' });
            char[] c = new char[ss.Length];
            int a;
            for (int i = 0; i < c.Length; i++)
            {
                a = Convert.ToInt32(ss[i]);
                c[i] = Convert.ToChar(a);
            }

            string b = new string(c);
            return b;
        }

        /// <summary>
        /// 16进制字符串转换为二进制数组
        /// </summary>
        /// <param name="hexstring">字符串每个字节之间都应该有空格，大多数的串口通讯资料上面的16进制都是字节之间都是用空格来分割的。</param>
        /// <returns>返回一个二进制字符串</returns>
        public static byte[] HexStringToBinary(string hexstring)
        {
            string[] tmpary = hexstring.Trim().Split(' ');
            byte[] buff = new byte[tmpary.Length];
            for (int i = 0; i < buff.Length; i++)
            {
                buff[i] = Convert.ToByte(tmpary[i], 16);
            }
            return buff;
        }


    }
}
