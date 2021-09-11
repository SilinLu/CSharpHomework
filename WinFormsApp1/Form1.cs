using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(numText1.Text);
            double b = Double.Parse(numText2.Text);
            if (addButton.Checked)
            {
                double c=a+b ;
                label1.Text = a.ToString();
            }
            else if (subButton.Checked)
            {
                double c = a-b;
                label1.Text = a.ToString();
            }
            else if (multiplyButton.Checked)
            {
                double c = a*b;
                label1.Text = a.ToString();
            }
            else 
            {
                if (b != 0)
                {
                    double c=a/b;
                    label1.Text = a.ToString();
                }
                else
                {
                    label1.Text = "ERROR";
                }

            }

        }

    }
}
