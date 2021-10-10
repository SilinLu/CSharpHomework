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
    public partial class FormDelete : Form
    {
        public FormDelete()
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



        private void FormDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                Program.service.DeleteOrder(num);
                labelInfo.Text = $"删除订单号为{num}的订单成功";
            }
            catch (Exception ex)
            {

                labelInfo.Text = $"删除失败，{ex}";
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
