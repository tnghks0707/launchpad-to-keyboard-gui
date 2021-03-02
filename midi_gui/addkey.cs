using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midi_gui
{
    public partial class addkey : Form
    {
        public int ButtonNum;
        public Keys ButtonKeyValue;
        public bool KeyChanged;
        public addkey(int bn)
        {
            ButtonNum = bn;
            KeyChanged = false;
            InitializeComponent();
        }

        private void addkey_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keys = e.KeyCode;
            
            if (keys == Keys.ControlKey || keys == Keys.ShiftKey || keys == Keys.Menu)
            {
                this.Enabled = false;
                ChoseRightLeft chose = new ChoseRightLeft();
                chose.ShowDialog();
                this.Enabled = true;
                if (chose.Chosed)
                {
                    if (chose.right)
                    {//오른쪽
                        switch (keys)
                        {
                            case Keys.ControlKey:
                                keys = Keys.RControlKey;
                                break;
                            case Keys.ShiftKey:
                                keys = Keys.RShiftKey;
                                break;
                            case Keys.Menu:
                                keys = Keys.RMenu;
                                break;
                        }
                    }
                    else
                    {//왼쪽
                        switch (keys)
                        {
                            case Keys.ControlKey:
                                keys = Keys.LControlKey;
                                break;
                            case Keys.ShiftKey:
                                keys = Keys.LShiftKey;
                                break;
                            case Keys.Menu:
                                keys = Keys.LMenu;
                                break;
                        }
                    }
                }
                else return;
            }
            label3.Text = "다음과 같이 키가 변경됩니다.";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            label4.Text = KeyToStr.KeyToString(keys);
            ButtonKeyValue = keys;
            button1.Focus();
        }

        private void addkey_Load(object sender, EventArgs e)
        {
            label2.Text = KeyToStr.KeyToString((Keys)메인.keyfile.KeyCode[ButtonNum]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonKeyValue = (Keys)0;
            label4.Text = "";
            label3.Text = "다음과 같이 키가 변경됩니다.";
            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KeyChanged = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "변경할 키를 눌러주세요.";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
    }
}
