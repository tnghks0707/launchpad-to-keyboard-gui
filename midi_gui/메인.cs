using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Midi;
using Keyboard;
using System.Threading;
using System.IO;

namespace midi_gui
{
    public partial class 메인 : Form
    {
        public static MidiIn midiIn;
        public static bool running = false;
        public static Lchkey keyfile;
        public static bool isFileChanged;
        public 메인()
        {
            InitializeComponent();
        }

        private void 메인_Load(object sender, EventArgs e)
        {
            keyfile = new Lchkey();
            port.Text = "포트 : " + MidiIn.DeviceInfo(Form1.portnum).ProductName;
            midiIn.MessageReceived += midiIn_MessageReceived;
            midiIn.Start();
            running = true;
            isFileChanged = false;
        }

        void midiIn_MessageReceived(object sender, MidiInMessageEventArgs e)
        {
            if(e.MidiEvent != null && e.MidiEvent.CommandCode == MidiCommandCode.AutoSensing)
            {
                return;
            }
            int rawMessage = e.MidiEvent.GetAsShortMessage();
            int b = rawMessage & 0xFF;
            int data1 = (rawMessage >> 8) & 0xFF;
            int data2 = (rawMessage >> 16) & 0xFF;
        }

        private void 메인_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (running)
            {
                midiIn.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            running = false;
            midiIn.Dispose();
            midiIn.MessageReceived -= midiIn_MessageReceived;
            int lastport = Form1.portnum;
            Form1 portchange = new Form1();
            portchange.ShowDialog();
            midiIn.Dispose();
            try { midiIn = new MidiIn(Form1.portnum); }
            catch (Exception)
            {
                MessageBox.Show("장치를 열 수 없습니다!\n이전 장치를 사용합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                try { midiIn = new MidiIn(lastport); }
                catch (Exception)
                {
                    MessageBox.Show("장치를 열 수 없습니다!\n프로그램을 재시작해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.ExitThread();
                    Environment.Exit(-1);
                }
                Form1.portnum = lastport;
            }
            port.Text = "포트 : " + MidiIn.DeviceInfo(Form1.portnum).ProductName;
            midiIn.MessageReceived += midiIn_MessageReceived;
            midiIn.Start();
            running = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "키파일(*.lchkey)|*.lchkey";
            openFile.ShowDialog();
            if(openFile.FileName.Length > 0)
            {
                try
                {
                    keyfile = new Lchkey(openFile.FileName);
                    for(int c = 0; c < 64; c++)
                    {
                        setLabelName(c);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("파일 형식이 올바르지 않습니다!");
                    keyfile = null;
                }
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "lchpad";
            saveFile.Filter = "키파일(*.lchkey)|*.lchkey";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(saveFile.FileName.ToString());
                foreach (Keys keys in keyfile.KeyCode){
                    stream.WriteLine((int)keys);
                }
                stream.Close();
            }
        }

        public void setKey(int key)
        {
            this.Enabled = false;
            addkey addform = new addkey(key);
            addform.ShowDialog();
            this.Enabled = true;
            if (addform.KeyChanged)
            {
                keyfile.KeyCode[key] = (int)addform.ButtonKeyValue;
                setLabelName(key);
            }
        }

        public void setLabelName(int key)
        {
            string keyname = KeyToStr.KeyToString((Keys)keyfile.KeyCode[key]);
            switch (key)
            {
                case 0:
                    label1.Text = keyname;
                    break;
                case 1:
                    label2.Text = keyname;
                    break;
                case 2:
                    label3.Text = keyname;
                    break;
                case 3:
                    label4.Text = keyname;
                    break;
                case 4:
                    label5.Text = keyname;
                    break;
                case 5:
                    label6.Text = keyname;
                    break;
                case 6:
                    label7.Text = keyname;
                    break;
                case 7:
                    label8.Text = keyname;
                    break;
                case 8:
                    label9.Text = keyname;
                    break;
                case 9:
                    label10.Text = keyname;
                    break;
                case 10:
                    label11.Text = keyname;
                    break;
                case 11:
                    label12.Text = keyname;
                    break;
                case 12:
                    label13.Text = keyname;
                    break;
                case 13:
                    label14.Text = keyname;
                    break;
                case 14:
                    label15.Text = keyname;
                    break;
                case 15:
                    label16.Text = keyname;
                    break;
                case 16:
                    label17.Text = keyname;
                    break;
                case 17:
                    label18.Text = keyname;
                    break;
                case 18:
                    label19.Text = keyname;
                    break;
                case 19:
                    label20.Text = keyname;
                    break;
                case 20:
                    label21.Text = keyname;
                    break;
                case 21:
                    label22.Text = keyname;
                    break;
                case 22:
                    label23.Text = keyname;
                    break;
                case 23:
                    label24.Text = keyname;
                    break;
                case 24:
                    label25.Text = keyname;
                    break;
                case 25:
                    label26.Text = keyname;
                    break;
                case 26:
                    label27.Text = keyname;
                    break;
                case 27:
                    label28.Text = keyname;
                    break;
                case 28:
                    label29.Text = keyname;
                    break;
                case 29:
                    label30.Text = keyname;
                    break;
                case 30:
                    label31.Text = keyname;
                    break;
                case 31:
                    label32.Text = keyname;
                    break;
                case 32:
                    label33.Text = keyname;
                    break;
                case 33:
                    label34.Text = keyname;
                    break;
                case 34:
                    label35.Text = keyname;
                    break;
                case 35:
                    label36.Text = keyname;
                    break;
                case 36:
                    label37.Text = keyname;
                    break;
                case 37:
                    label38.Text = keyname;
                    break;
                case 38:
                    label39.Text = keyname;
                    break;
                case 39:
                    label40.Text = keyname;
                    break;
                case 40:
                    label41.Text = keyname;
                    break;
                case 41:
                    label42.Text = keyname;
                    break;
                case 42:
                    label43.Text = keyname;
                    break;
                case 43:
                    label44.Text = keyname;
                    break;
                case 44:
                    label45.Text = keyname;
                    break;
                case 45:
                    label46.Text = keyname;
                    break;
                case 46:
                    label47.Text = keyname;
                    break;
                case 47:
                    label48.Text = keyname;
                    break;
                case 48:
                    label49.Text = keyname;
                    break;
                case 49:
                    label50.Text = keyname;
                    break;
                case 50:
                    label51.Text = keyname;
                    break;
                case 51:
                    label52.Text = keyname;
                    break;
                case 52:
                    label53.Text = keyname;
                    break;
                case 53:
                    label54.Text = keyname;
                    break;
                case 54:
                    label55.Text = keyname;
                    break;
                case 55:
                    label56.Text = keyname;
                    break;
                case 56:
                    label57.Text = keyname;
                    break;
                case 57:
                    label58.Text = keyname;
                    break;
                case 58:
                    label59.Text = keyname;
                    break;
                case 59:
                    label60.Text = keyname;
                    break;
                case 60:
                    label61.Text = keyname;
                    break;
                case 61:
                    label62.Text = keyname;
                    break;
                case 62:
                    label63.Text = keyname;
                    break;
                case 63:
                    label64.Text = keyname;
                    break;
            }
        }

        #region 레이블에 대한 클릭이밴트

        private void label1_Click(object sender, EventArgs e)
        {
            setKey(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            setKey(1);
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            setKey(2);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            setKey(3);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            setKey(4);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            setKey(5);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            setKey(6);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            setKey(7);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            setKey(8);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            setKey(9);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            setKey(10);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            setKey(11);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            setKey(12);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            setKey(13);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            setKey(14);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            setKey(15);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            setKey(16);
        }

        private void label18_Click(object sender, EventArgs e)
        {
            setKey(17);
        }

        private void label19_Click(object sender, EventArgs e)
        {
            setKey(18);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            setKey(19);
        }

        private void label21_Click(object sender, EventArgs e)
        {
            setKey(20);
        }

        private void label22_Click(object sender, EventArgs e)
        {
            setKey(21);
        }

        private void label23_Click(object sender, EventArgs e)
        {
            setKey(22);
        }

        private void label24_Click(object sender, EventArgs e)
        {
            setKey(23);
        }

        private void label25_Click(object sender, EventArgs e)
        {
            setKey(24);
        }

        private void label26_Click(object sender, EventArgs e)
        {
            setKey(25);
        }

        private void label27_Click(object sender, EventArgs e)
        {
            setKey(26);
        }

        private void label28_Click(object sender, EventArgs e)
        {
            setKey(27);
        }

        private void label29_Click(object sender, EventArgs e)
        {
            setKey(28);
        }

        private void label30_Click(object sender, EventArgs e)
        {
            setKey(29);
        }

        private void label31_Click(object sender, EventArgs e)
        {
            setKey(30);
        }

        private void label32_Click(object sender, EventArgs e)
        {
            setKey(31);
        }

        private void label33_Click(object sender, EventArgs e)
        {
            setKey(32);
        }

        private void label34_Click(object sender, EventArgs e)
        {
            setKey(33);
        }

        private void label35_Click(object sender, EventArgs e)
        {
            setKey(34);
        }

        private void label36_Click(object sender, EventArgs e)
        {
            setKey(35);
        }

        private void label37_Click(object sender, EventArgs e)
        {
            setKey(36);
        }

        private void label38_Click(object sender, EventArgs e)
        {
            setKey(37);
        }

        private void label39_Click(object sender, EventArgs e)
        {
            setKey(38);
        }

        private void label40_Click(object sender, EventArgs e)
        {
            setKey(39);
        }

        private void label41_Click(object sender, EventArgs e)
        {
            setKey(40);
        }

        private void label42_Click(object sender, EventArgs e)
        {
            setKey(41);
        }

        private void label43_Click(object sender, EventArgs e)
        {
            setKey(42);
        }

        private void label44_Click(object sender, EventArgs e)
        {
            setKey(43);
        }

        private void label45_Click(object sender, EventArgs e)
        {
            setKey(44);
        }

        private void label46_Click(object sender, EventArgs e)
        {
            setKey(45);
        }

        private void label47_Click(object sender, EventArgs e)
        {
            setKey(46);
        }

        private void label48_Click(object sender, EventArgs e)
        {
            setKey(47);
        }

        private void label49_Click(object sender, EventArgs e)
        {
            setKey(48);
        }

        private void label50_Click(object sender, EventArgs e)
        {
            setKey(49);
        }

        private void label51_Click(object sender, EventArgs e)
        {
            setKey(50);
        }

        private void label52_Click(object sender, EventArgs e)
        {
            setKey(51);
        }

        private void label53_Click(object sender, EventArgs e)
        {
            setKey(52);
        }

        private void label54_Click(object sender, EventArgs e)
        {
            setKey(53);
        }

        private void label55_Click(object sender, EventArgs e)
        {
            setKey(54);
        }

        private void label56_Click(object sender, EventArgs e)
        {
            setKey(55);
        }

        private void label57_Click(object sender, EventArgs e)
        {
            setKey(56);
        }

        private void label58_Click(object sender, EventArgs e)
        {
            setKey(57);
        }

        private void label59_Click(object sender, EventArgs e)
        {
            setKey(58);
        }

        private void label60_Click(object sender, EventArgs e)
        {
            setKey(59);
        }

        private void label61_Click(object sender, EventArgs e)
        {
            setKey(60);
        }

        private void label62_Click(object sender, EventArgs e)
        {
            setKey(61);
        }

        private void label63_Click(object sender, EventArgs e)
        {
            setKey(62);
        }

        private void label64_Click(object sender, EventArgs e)
        {
            setKey(63);
        }

        #endregion
    }
}

public class Lchkey
{
    public List<int> KeyCode;
    private string FilePath;
    public Lchkey(string FP)
    {
        FilePath = FP;
        string[] texts = File.ReadAllLines(FP);
        KeyCode = new List<int>();
        if(texts.Length == 64)
        {
            foreach (string data in texts)
            {
                KeyCode.Add(Convert.ToInt32(data));
            }
        }
        else
        {
            throw new Exception();
        }
    }

    public Lchkey()
    {
        KeyCode = new List<int>();
        for(int c = 0; c < 64; c++)
        {
            KeyCode.Add(0);
        }
    }
}