using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class ColorControl : UserControl
    {
        private bool Changing = false;

        public Color MyColor
        {
            get
            {
                return pictureBox1.BackColor;
            }
            set
            {
                pictureBox1.BackColor = value;
            }
        }

        public ColorControl()
        {
            InitializeComponent();
            MyColor = Color.FromArgb(0, 0, 0);
        }

        private void colorTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Changing)
                if (!radioButton1.Checked)
                {
                    pictureBox1.BackColor = Color.FromArgb(Convert.ToInt32(colorTextBox1.Text, 16), Convert.ToInt32(colorTextBox2.Text, 16), Convert.ToInt32(colorTextBox3.Text, 16));
                }
                else
                {
                    pictureBox1.BackColor = Color.FromArgb(int.Parse(colorTextBox1.Text), int.Parse(colorTextBox2.Text), int.Parse(colorTextBox3.Text));
                }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Changing = true;
                colorTextBox1.Number = true;
                colorTextBox2.Number = true;
                colorTextBox3.Number = true;
                colorTextBox1.Text = Convert.ToInt32(colorTextBox1.Text, 16).ToString();
                colorTextBox2.Text = Convert.ToInt32(colorTextBox2.Text, 16).ToString();
                colorTextBox3.Text = Convert.ToInt32(colorTextBox3.Text, 16).ToString();
                Changing = false;
            }
            else
            {
                Changing = true;
                colorTextBox1.Number = false;
                colorTextBox2.Number = false;
                colorTextBox3.Number = false;
                colorTextBox1.Text = Convert.ToString(int.Parse(colorTextBox1.Text), 16);
                colorTextBox2.Text = Convert.ToString(int.Parse(colorTextBox2.Text), 16);
                colorTextBox3.Text = Convert.ToString(int.Parse(colorTextBox3.Text), 16);
                Changing = false;
            }

        }
    }
}
