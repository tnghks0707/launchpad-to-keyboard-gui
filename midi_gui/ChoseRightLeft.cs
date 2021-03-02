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
    public partial class ChoseRightLeft : Form
    {
        public bool Chosed;
        public bool right;
        public ChoseRightLeft()
        {
            Chosed = false;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            right = false;
            Chosed = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            right = true;
            Chosed = true;
            this.Close();
        }
    }
}
