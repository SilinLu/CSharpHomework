
namespace chapter8
{
    partial class FormAdd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxOrange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxOrange = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxWaterMelon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxWatermelon = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPeach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxPeach = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBanana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxbanana = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textApple = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxApple = new System.Windows.Forms.CheckBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.按订单号查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按金额查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按用户名查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按货物名查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.buttonConfirm);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 470);
            this.panel1.TabIndex = 1;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 418);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(37, 20);
            this.labelInfo.TabIndex = 10;
            this.labelInfo.Text = "info";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(246, 381);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(94, 29);
            this.buttonConfirm.TabIndex = 9;
            this.buttonConfirm.Text = "添加订单";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBoxCustomer);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(5, 270);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(588, 71);
            this.panel7.TabIndex = 8;
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(191, 24);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(125, 27);
            this.textBoxCustomer.TabIndex = 1;
            this.textBoxCustomer.Text = "defalut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "请输入顾客的姓名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "请选择要购买的物品：";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxOrange);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.checkBoxOrange);
            this.panel6.Location = new System.Drawing.Point(0, 219);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(594, 45);
            this.panel6.TabIndex = 6;
            // 
            // textBoxOrange
            // 
            this.textBoxOrange.Location = new System.Drawing.Point(330, 12);
            this.textBoxOrange.Name = "textBoxOrange";
            this.textBoxOrange.Size = new System.Drawing.Size(125, 27);
            this.textBoxOrange.TabIndex = 2;
            this.textBoxOrange.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "数量：";
            // 
            // checkBoxOrange
            // 
            this.checkBoxOrange.AutoSize = true;
            this.checkBoxOrange.Location = new System.Drawing.Point(56, 18);
            this.checkBoxOrange.Name = "checkBoxOrange";
            this.checkBoxOrange.Size = new System.Drawing.Size(61, 24);
            this.checkBoxOrange.TabIndex = 0;
            this.checkBoxOrange.Text = "橙子";
            this.checkBoxOrange.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBoxWaterMelon);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.checkBoxWatermelon);
            this.panel5.Location = new System.Drawing.Point(0, 171);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(594, 45);
            this.panel5.TabIndex = 5;
            // 
            // textBoxWaterMelon
            // 
            this.textBoxWaterMelon.Location = new System.Drawing.Point(330, 12);
            this.textBoxWaterMelon.Name = "textBoxWaterMelon";
            this.textBoxWaterMelon.Size = new System.Drawing.Size(125, 27);
            this.textBoxWaterMelon.TabIndex = 2;
            this.textBoxWaterMelon.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "数量：";
            // 
            // checkBoxWatermelon
            // 
            this.checkBoxWatermelon.AutoSize = true;
            this.checkBoxWatermelon.Location = new System.Drawing.Point(56, 18);
            this.checkBoxWatermelon.Name = "checkBoxWatermelon";
            this.checkBoxWatermelon.Size = new System.Drawing.Size(61, 24);
            this.checkBoxWatermelon.TabIndex = 0;
            this.checkBoxWatermelon.Text = "西瓜";
            this.checkBoxWatermelon.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxPeach);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.checkBoxPeach);
            this.panel4.Location = new System.Drawing.Point(0, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 45);
            this.panel4.TabIndex = 4;
            // 
            // textBoxPeach
            // 
            this.textBoxPeach.Location = new System.Drawing.Point(330, 12);
            this.textBoxPeach.Name = "textBoxPeach";
            this.textBoxPeach.Size = new System.Drawing.Size(125, 27);
            this.textBoxPeach.TabIndex = 2;
            this.textBoxPeach.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "数量：";
            // 
            // checkBoxPeach
            // 
            this.checkBoxPeach.AutoSize = true;
            this.checkBoxPeach.Location = new System.Drawing.Point(56, 18);
            this.checkBoxPeach.Name = "checkBoxPeach";
            this.checkBoxPeach.Size = new System.Drawing.Size(61, 24);
            this.checkBoxPeach.TabIndex = 0;
            this.checkBoxPeach.Text = "桃子";
            this.checkBoxPeach.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBanana);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.checkBoxbanana);
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 45);
            this.panel3.TabIndex = 3;
            // 
            // textBanana
            // 
            this.textBanana.Location = new System.Drawing.Point(330, 12);
            this.textBanana.Name = "textBanana";
            this.textBanana.Size = new System.Drawing.Size(125, 27);
            this.textBanana.TabIndex = 2;
            this.textBanana.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "数量：";
            // 
            // checkBoxbanana
            // 
            this.checkBoxbanana.AutoSize = true;
            this.checkBoxbanana.Location = new System.Drawing.Point(56, 18);
            this.checkBoxbanana.Name = "checkBoxbanana";
            this.checkBoxbanana.Size = new System.Drawing.Size(61, 24);
            this.checkBoxbanana.TabIndex = 0;
            this.checkBoxbanana.Text = "香蕉";
            this.checkBoxbanana.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textApple);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBoxApple);
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 45);
            this.panel2.TabIndex = 1;
            // 
            // textApple
            // 
            this.textApple.Location = new System.Drawing.Point(330, 12);
            this.textApple.Name = "textApple";
            this.textApple.Size = new System.Drawing.Size(125, 27);
            this.textApple.TabIndex = 2;
            this.textApple.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "数量：";
            // 
            // checkBoxApple
            // 
            this.checkBoxApple.AutoSize = true;
            this.checkBoxApple.Location = new System.Drawing.Point(56, 18);
            this.checkBoxApple.Name = "checkBoxApple";
            this.checkBoxApple.Size = new System.Drawing.Size(61, 24);
            this.checkBoxApple.TabIndex = 0;
            this.checkBoxApple.Text = "苹果";
            this.checkBoxApple.UseVisualStyleBackColor = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(600, 28);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem1.Text = "增加订单";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem2.Text = "删除订单";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem3.Text = "修改订单";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按订单号查询ToolStripMenuItem,
            this.按金额查询ToolStripMenuItem,
            this.按用户名查询ToolStripMenuItem,
            this.按货物名查询ToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem4.Text = "查询订单";
            // 
            // 按订单号查询ToolStripMenuItem
            // 
            this.按订单号查询ToolStripMenuItem.Name = "按订单号查询ToolStripMenuItem";
            this.按订单号查询ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.按订单号查询ToolStripMenuItem.Text = "按订单号查询";
            this.按订单号查询ToolStripMenuItem.Click += new System.EventHandler(this.按订单号查询ToolStripMenuItem_Click);
            // 
            // 按金额查询ToolStripMenuItem
            // 
            this.按金额查询ToolStripMenuItem.Name = "按金额查询ToolStripMenuItem";
            this.按金额查询ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.按金额查询ToolStripMenuItem.Text = "按金额查询";
            this.按金额查询ToolStripMenuItem.Click += new System.EventHandler(this.按金额查询ToolStripMenuItem_Click);
            // 
            // 按用户名查询ToolStripMenuItem
            // 
            this.按用户名查询ToolStripMenuItem.Name = "按用户名查询ToolStripMenuItem";
            this.按用户名查询ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.按用户名查询ToolStripMenuItem.Text = "按用户名查询";
            this.按用户名查询ToolStripMenuItem.Click += new System.EventHandler(this.按用户名查询ToolStripMenuItem_Click);
            // 
            // 按货物名查询ToolStripMenuItem
            // 
            this.按货物名查询ToolStripMenuItem.Name = "按货物名查询ToolStripMenuItem";
            this.按货物名查询ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.按货物名查询ToolStripMenuItem.Text = "按货物名查询";
            this.按货物名查询ToolStripMenuItem.Click += new System.EventHandler(this.按货物名查询ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem5.Text = "导出订单";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem6.Text = "导入订单";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 499);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdd";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdd_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxApple;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxPeach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxPeach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBanana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxbanana;
        private System.Windows.Forms.TextBox textApple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxOrange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxOrange;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxWaterMelon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxWatermelon;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 按订单号查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按金额查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按用户名查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按货物名查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}

