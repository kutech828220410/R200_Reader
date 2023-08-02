using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basic;
using System.Runtime.InteropServices;
namespace R200_Reader
{
    public partial class Form1 : Form
    {
        bool flag_SendKey = false;
        private string keyData_buf = "";
        private void Hook_KeyUp(int nCode, IntPtr wParam, Keys Keys)
        {
            if (keyData_buf != Keys.ToString())
            {
                keyData_buf = Keys.ToString();
                if (Keys.ToString().ToUpper().Contains("F2"))
                {
                    flag_SendKey = true;
                }

            }
        }
        private void Hook_KeyDown(int nCode, IntPtr wParam, Keys Keys)
        {
            keyData_buf = "";
        }

        public const int RFID_RX_SIZE = 256;
        public byte[] RFID_RX = new byte[RFID_RX_SIZE];
        public int RFID_len;
        public string Card_00
        {
            set
            {
                this.Invoke(new Action(delegate 
                {
                    label_Card_01.Text = value;
                }));
            }
            get
            {
                return label_Card_01.Text;
            }
        }
        public string Card_01
        {
            set
            {
                this.Invoke(new Action(delegate
                {
                    label_Card_02.Text = value;
                }));
            }
            get
            {
                return label_Card_02.Text;
            }
        }
        public string Card_02
        {
            set
            {
                this.Invoke(new Action(delegate
                {
                    label_Card_03.Text = value;
                }));
            }
            get
            {
                return label_Card_03.Text;
            }
        }
        public string Card_03
        {
            set
            {
                this.Invoke(new Action(delegate
                {
                    label_Card_04.Text = value;
                }));
            }
            get
            {
                return label_Card_04.Text;
            }
        }
        public string Card_04
        {
            set
            {
                this.Invoke(new Action(delegate
                {
                    label_Card_05.Text = value;
                }));
            }
            get
            {
                return label_Card_05.Text;
            }
        }

        public string Card_00_buf = "";
        public string Card_01_buf = "";
        public string Card_02_buf = "";
        public string Card_03_buf = "";
        public string Card_04_buf = "";

        public ulong RSSI_00 = 0;
        public ulong RSSI_01 = 0;
        public ulong RSSI_02 = 0;
        public ulong RSSI_03 = 0;
        public ulong RSSI_04 = 0;

        public string COMPort
        {
            get
            {
                string temp = "";
                this.Invoke(new Action(delegate
                {
                    temp = comboBox_COM.Text;
                }));
                return temp;
            }
        }
        MyThread MyThread;
        MySerialPort MySerialPort = new MySerialPort();
        Keyboard keyboard = new Keyboard();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.button_Open.Click += Button_Open_Click;
            this.rJ_Button_讀取卡片.MouseDownEvent += RJ_Button_讀取卡片_MouseDownEvent;
            Basic.Keyboard.Hook.KeyDown += Hook_KeyDown;
            Basic.Keyboard.Hook.KeyUp += Hook_KeyUp;
        }

        private void RJ_Button_讀取卡片_MouseDownEvent(MouseEventArgs mevent)
        {
            if (MySerialPort.IsConnected != true) return;
            Get_CardID();
            Card_00 = Card_00_buf;
            Card_01 = Card_01_buf;
            Card_02 = Card_02_buf;
            Card_03 = Card_03_buf;
            Card_04 = Card_04_buf;
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            string com = comboBox_COM.Text;
            if (com.StringIsEmpty())
            {
                MyMessageBox.ShowDialog("未選取COM");
                return;
            }
            MySerialPort.Init(com, 115200, 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One);
            MySerialPort.SerialPortOpen();
            if (MySerialPort.IsConnected)
            {
                Set_RF_Power();
            }
            else
            {
            }
            this.button_Open.Text = (MySerialPort.IsConnected ? "Close" : "Open");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MyMessageBox.音效 = false;
            comboBox_COM.DataSource = MySerialPort.GetPortNames();

            MyThread = new MyThread();
            MyThread.Add_Method(sub_MyThread);
            MyThread.AutoRun(true);
            MyThread.SetSleepTime(10);
            MyThread.Trigger();


        }
        byte cnt = 0;
        bool flag_IsPress = false;
        void sub_MyThread()
        {
            if(flag_SendKey)
            {
                RJ_Button_讀取卡片_MouseDownEvent(null);
                string targetLanguageCode = "en-US"; // 英文輸入法代碼
                                                     //string targetLanguageCode = "zh-TW"; // 中文(台灣)輸入法代碼

                // 列出目前系統支援的輸入法
                InputLanguageCollection installedInputLanguages = InputLanguage.InstalledInputLanguages;
                foreach (InputLanguage lang in installedInputLanguages)
                {
                    Console.WriteLine($"Language: {lang.LayoutName}, Code: {lang.Culture.Name}");
                }

                // 搜尋並切換至目標輸入法
                InputLanguage targetInputLanguage = FindInputLanguageByCode(targetLanguageCode);
                if (targetInputLanguage != null)
                {
                    InputLanguage.CurrentInputLanguage = targetInputLanguage;
                    Console.WriteLine($"已切換至語言: {targetInputLanguage.LayoutName}, 代碼: {targetInputLanguage.Culture.Name}");
                }
                else
                {
                    Console.WriteLine($"找不到指定的語言代碼: {targetLanguageCode}");
                }

                SimulateKeyPress($"{Card_00}");
                SimulateKeyPress("\r");
                Console.WriteLine($"鍵盤輸入: {Card_00}    {DateTime.Now.ToDateTimeString()}");
                flag_SendKey = false;
            }
        }
        public void Set_RF_Power()
        {
            // BB 00 B6 00 02 05 DC 99 7E -> 15 dbm
            // BB 00 B6 00 02 03 E8 A3 7E -> 10 dbm
            byte[] tx = new byte[9] { 0xBB, 0x00, 0xB6, 0x00, 0x02, 0x03, 0xE8, 0xA3, 0x7E };
            MySerialPort.WriteByte(tx);
        }
        public void Get_CardID()
        {
            if (MySerialPort.IsConnected != true) return;
            int Card_index = 0;
            byte[] tx = new byte[7] { 0xBB, 0x00, 0x22, 0x00, 0x00, 0x22, 0x7E };

            RFID_len = 0;
            for (int i = 0; i < RFID_RX_SIZE; i++)
            {
                RFID_RX[i] = 0;
            }
            MyTimerBasic MyTimer_RFID = new MyTimerBasic();
    
            int retry = 0;
            bool flag_OK = false;
            int cnt = 0;
            while (true)
            {
                if (cnt == 0)
                {
                    MyTimer_RFID.TickStop();
                    MyTimer_RFID.StartTickTime(100);
                    MySerialPort.ClearReadByte();
                    MySerialPort.WriteByte(tx);

                    Console.WriteLine("寫入 R200 讀取指令...");
                    cnt++;
                }
                if (MySerialPort.ReadByte() != null && MyTimer_RFID.IsTimeOut() && cnt == 1)
                {
                    RFID_RX = MySerialPort.ReadByte();
                    RFID_len = MySerialPort.BytesToRead;
                    cnt++;
                }
                if (MyTimer_RFID.IsTimeOut() && cnt == 1)
                {
                    retry++;
                    cnt = 0;
                }
                if (cnt == 2)
                {
                    Console.WriteLine("讀取 R200 長度: " + RFID_len);
                    if (RFID_len >= 8)
                    {
                        Card_00_buf = "";
                        Card_01_buf = "";
                        Card_02_buf = "";
                        Card_03_buf = "";
                        Card_04_buf = "";
                        RSSI_00 = 0;
                        RSSI_01 = 0;
                        RSSI_02 = 0;
                        RSSI_03 = 0;
                        RSSI_04 = 0;
                   
                    }
                    for (int i = 0; i < RFID_len; i++)
                    {
                        if (RFID_RX[i] == 0xBB && RFID_RX[i + 1] == 0x02)
                        {
                            if ((i + 19) >= RFID_len) i = RFID_len;
                            else
                            {
                                byte _RSSI = RFID_RX[i + 5];
                                string HEX_0 = RFID_RX[i + 8].ToString("X2");
                                string HEX_1 = RFID_RX[i + 9].ToString("X2");
                                string HEX_2 = RFID_RX[i + 10].ToString("X2");
                                string HEX_3 = RFID_RX[i + 11].ToString("X2");
                                string HEX_4 = RFID_RX[i + 12].ToString("X2");
                                string HEX_5 = RFID_RX[i + 13].ToString("X2");
                                string HEX_6 = RFID_RX[i + 14].ToString("X2");
                                string HEX_7 = RFID_RX[i + 15].ToString("X2");
                                string HEX_8 = RFID_RX[i + 16].ToString("X2");
                                string HEX_9 = RFID_RX[i + 17].ToString("X2");
                                string HEX_10 = RFID_RX[i + 18].ToString("X2");
                                string HEX_11 = RFID_RX[i + 19].ToString("X2");

                                HEX_0 = HEX_0.ToUpper();
                                HEX_1 = HEX_1.ToUpper();
                                HEX_2 = HEX_2.ToUpper();
                                HEX_3 = HEX_3.ToUpper();
                                HEX_4 = HEX_4.ToUpper();
                                HEX_5 = HEX_5.ToUpper();
                                HEX_6 = HEX_6.ToUpper();
                                HEX_7 = HEX_7.ToUpper();
                                HEX_8 = HEX_8.ToUpper();
                                HEX_9 = HEX_9.ToUpper();
                                HEX_10 = HEX_10.ToUpper();

                                string Card = HEX_0 + HEX_1 + HEX_2 + HEX_3 + HEX_4 + HEX_5 + HEX_6 + HEX_7 + HEX_8 + HEX_9 + HEX_10;
                                if (Card_index == 0)
                                {
                                    Card_00_buf = Card;
                                    RSSI_00 = 0xFFFFFFFFFFFFFF00 | _RSSI;
                                    Console.WriteLine("讀取 R200 卡片 00 : " + Card_00 + ", RSSI : " + RSSI_00);
                                    flag_OK = true;
                                }
                                else if (Card_index == 1)
                                {
                                    Card_01_buf = Card;
                                    RSSI_01 = 0xFFFFFFFFFFFFFF00 | _RSSI;
                                    Console.WriteLine("讀取 R200 卡片 01 : " + Card_01 + ", RSSI : " + RSSI_01);
                                    flag_OK = true;
                                }
                                else if (Card_index == 2)
                                {
                                    Card_02_buf = Card;
                                    RSSI_02 = 0xFFFFFFFFFFFFFF00 | _RSSI;
                                    Console.WriteLine("讀取 R200 卡片 02 : " + Card_02 + ", RSSI : " + RSSI_02);
                                    flag_OK = true;
                                }
                                else if (Card_index == 3)
                                {
                                    Card_03_buf = Card;
                                    RSSI_03 = 0xFFFFFFFFFFFFFF00 | _RSSI;
                                    Console.WriteLine("讀取 R200 卡片 03 : " + Card_03 + ", RSSI : " + RSSI_03);
                                    flag_OK = true;
                                }
                                else if (Card_index == 4)
                                {
                                    Card_04_buf = Card;
                                    RSSI_04 = 0xFFFFFFFFFFFFFF00 | _RSSI;
                                    Console.WriteLine("讀取 R200 卡片 04 : " + Card_04 + ", RSSI : " + RSSI_04);
                                    flag_OK = true;
                                }
                                Card_index++;
                                i += 23;
                            }
                        }
                    }
                    retry++;
                    System.Threading.Thread.Sleep(10);
                    if(retry >= 3 || flag_OK) break;
                    cnt = 0;
                }
            }
        }

        private static InputLanguage FindInputLanguageByCode(string languageCode)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.Name.Equals(languageCode, StringComparison.OrdinalIgnoreCase))
                {
                    return lang;
                }
            }
            return null;
        }
        private const int KEYEVENTF_KEYDOWN = 0x0000; // Key down flag
        private const int KEYEVENTF_KEYUP = 0x0002;   // Key up flag

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        private static void SimulateKeyPress(string keys)
        {
            char[] keys_char = keys.ToCharArray();
            for (int i = 0; i < keys_char.Length; i++)
            {
                // 轉換字元為虛擬鍵碼
                byte virtualKeyCode = (byte)keys_char[i];

                // 模擬按下按鍵
                keybd_event(virtualKeyCode, 0, KEYEVENTF_KEYDOWN, 0);

                // 模擬釋放按鍵
                keybd_event(virtualKeyCode, 0, KEYEVENTF_KEYUP, 0);
            }
         
        }
    }
}
