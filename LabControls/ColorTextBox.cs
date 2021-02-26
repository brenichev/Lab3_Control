using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class ColorTextBox : TextBox
    {
        public bool number = true;

        public ColorTextBox()
        {
            InitializeComponent();
        }

        public ColorTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if(number)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar >= 97 && e.KeyChar <= 102))
                    e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        public bool Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            int x;
            if (number)
            {
                if (int.TryParse(this.Text, out x))
                {
                    if (x < 0)
                        this.Text = "0";
                }
                else
                    this.Text = "0";
                if (int.Parse(this.Text) > 255)
                    this.Text = "255";
            }
            else
            {
                if (this.Text.Length > 2) 
                    this.Text = "ff";
                if (this.Text.Length == 0) 
                    this.Text = "0";
            }

            base.OnTextChanged(e);
        }
    }
}
