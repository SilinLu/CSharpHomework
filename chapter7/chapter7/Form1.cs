using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            foreach (var item in typeof(Color).GetMembers())
            {
                if (item.MemberType == System.Reflection.MemberTypes.Property && System.Drawing.Color.FromName(item.Name).IsKnownColor)
                {
                    Color color = Color.FromName(item.Name);
                    comboBox1.Items.Add(color);
                }
            }
            comboBox1.SelectedIndex = 0;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "0";
        }

        private Graphics graphics;
        Pen pen;
        int n;
        double leng;
        double per1;
        double per2;
        double th1;
        double th2;



        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th + th2);

        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void textBox1_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen = new Pen((Color)comboBox1.SelectedItem);
            n = int.Parse(textBox1.Text);
            leng = double.Parse(textBox2.Text);
            per1 = double.Parse(textBox3.Text);
            per2 = double.Parse(textBox4.Text);
            th1 = double.Parse(textBox5.Text);
            th2 = double.Parse(textBox6.Text);
            if (graphics == null) graphics = this.CreateGraphics();

            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
        }
    }
}
