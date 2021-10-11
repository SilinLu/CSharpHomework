using Chapter5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace chapter8
{
    public partial class FormChange : Form
    {
        Order order;
        public FormChange()
        {
            InitializeComponent();
            buttonConfirm.Enabled = false;
            textBoxCustomer.Enabled = false;
            textBoxOrange.Enabled = false;
            textBoxPeach.Enabled = false;
            textBoxWaterMelon.Enabled = false;
            textApple.Enabled = false;
            textBanana.Enabled = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBoxNum.Text);
                order = Program.service.SearchByNum(num);
                foreach (OrderDetail orderDetails in order.OrderDetails)
                {
                    if (orderDetails.good.Name == "apple") textApple.Text = orderDetails.Goods_Num.ToString();
                    if (orderDetails.good.Name == "peach") textBoxPeach.Text = orderDetails.Goods_Num.ToString();
                    if (orderDetails.good.Name == "orange") textBoxOrange.Text = orderDetails.Goods_Num.ToString();
                    if (orderDetails.good.Name == "watermelon") textBoxWaterMelon.Text = orderDetails.Goods_Num.ToString();
                    if (orderDetails.good.Name == "banana") textBanana.Text = orderDetails.Goods_Num.ToString();

                }
                textBoxCustomer.Text = order.Customer.Name;
                label14.Text = "查找成功";
                buttonConfirm.Enabled = true;
                textBoxCustomer.Enabled = true;
                textBoxOrange.Enabled = true;
                textBoxPeach.Enabled = true;
                textBoxWaterMelon.Enabled = true;
                textApple.Enabled = true;
                textBanana.Enabled = true;
            }
            catch (Exception ex)
            {

                label14.Text = $"查找失败，{ex}";
            }
        }


        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                buttonConfirm.Enabled = false;
                textBoxCustomer.Enabled = false;
                textBoxOrange.Enabled = false;
                textBoxPeach.Enabled = false;
                textBoxWaterMelon.Enabled = false;
                textApple.Enabled = false;
                textBanana.Enabled = false;

                int appleNum = int.Parse(textApple.Text);
                int peachNum = int.Parse(textBoxPeach.Text);
                int waterNum = int.Parse(textBoxWaterMelon.Text);
                int orangeNum = int.Parse(textBoxOrange.Text);
                int bananaNum = int.Parse(textBanana.Text);
                int numOrder=order.Order_Num;
                order.OrderDetails.Clear();

                if (bananaNum > 0) Program.service.AddOrderDetail(order,bananaNum,1);

                if (appleNum > 0) Program.service.AddOrderDetail(order, appleNum, 0);

                if (peachNum > 0) Program.service.AddOrderDetail(order,  peachNum,2);

                if (waterNum > 0) Program.service.AddOrderDetail(order, waterNum, 3);

                if (orangeNum > 0) Program.service.AddOrderDetail(order,  orangeNum, 4);


                labelInfo.Text = "修改成功";
                buttonConfirm.Enabled = false;

            }
            catch (Exception ex)
            {

                labelInfo.Text = $"修改失败，{ex}";
            }

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



        //private void FormAdd_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Application.Exit();
        //}

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

        private void FormChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
