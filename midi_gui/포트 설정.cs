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

namespace midi_gui
{
    public partial class Form1 : Form
    {
        public static int portnum = 0;
        public static bool first = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int device = 0; device < MidiIn.NumberOfDevices; device++)
            {
                comboBox1.Items.Add(MidiIn.DeviceInfo(device).ProductName);
            }
            if(comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int device = 0; device < MidiIn.NumberOfDevices; device++)
            {
                comboBox1.Items.Add(MidiIn.DeviceInfo(device).ProductName);
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("장치가 선택되지 않았습니다!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            portnum = comboBox1.SelectedIndex;
            try { 메인.midiIn = new MidiIn(portnum); }
            catch(Exception)
            {
                MessageBox.Show("장치를 열 수 없습니다!\n이 메세지가 계속 발생한다면, 프로그램을 재시작해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (first)
            {
                메인 f = new 메인();
                f.Show();
                Program.ac.MainForm = f;
                first = false;
            }
            this.Hide();
        }
    }
}
