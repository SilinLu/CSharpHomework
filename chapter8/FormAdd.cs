using Chapter5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter8
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            Program.formAdd.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            Program.formDelete.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Hide();
            Program.formChange.Show();
        }



        private void FormAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 按订单号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Program.formSearchNum.Show();
        }

        private void 按金额查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Program.formSearchCost.Show();
        }

        private void 按用户名查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Program.formSearchCustomer.Show();
        }

        private void 按货物名查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Program.formSearchGood.Show();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            
            try
            {
                int appleNum = int.Parse(textApple.Text);
                int bananaNum = int.Parse(textBanana.Text);
                int peachNum = int.Parse(textBoxPeach.Text);
                int watermelonNum = int.Parse(textBoxWaterMelon.Text);
                int orangeNum = int.Parse(textBoxOrange.Text);
                Order order = new Order();
                if (!(checkBoxApple.Checked || checkBoxbanana.Checked || checkBoxPeach.Checked || checkBoxWatermelon.Checked || checkBoxOrange.Checked))
                    throw new MyException("选中为空", 5);
                if (appleNum==0&&bananaNum==0&&peachNum==0&&watermelonNum==0&&orangeNum==0)
                    throw new MyException("选中为空", 5);
                if (checkBoxApple.Checked && appleNum != 0) Program.service.AddOrderDetails(order, appleNum, 0);
                if (checkBoxbanana.Checked && bananaNum != 0) Program.service.AddOrderDetails(order, bananaNum, 1);
                if (checkBoxPeach.Checked && peachNum != 0) Program.service.AddOrderDetails(order, peachNum, 2);
                if (checkBoxWatermelon.Checked && watermelonNum != 0) Program.service.AddOrderDetails(order, watermelonNum, 3);
                if (checkBoxOrange.Checked && orangeNum != 0) Program.service.AddOrderDetails(order, orangeNum, 4);
                Customer customer = new Customer();
                customer.Name = textBoxCustomer.Text;
                Program.service.AddOrder(order, customer);
                labelInfo.Text = "下单成功，订单号为"+ order.Order_Num;
            }
            catch (Exception ex)
            {
                labelInfo.Text = $"下单失败，错误：{ex}";
                
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                Program.service.Export();
                MessageBox.Show("导出成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"导出失败,错误：{ex}");
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                Program.service.Import();
                MessageBox.Show("导入成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"导入失败,错误：{ex}");
            }
        }
    }
}
