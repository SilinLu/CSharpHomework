
namespace chapter8
{
    partial class FormSearchCost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelException = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonLess = new System.Windows.Forms.RadioButton();
            this.radioButtonMore = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(578, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 415);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelException);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(4, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 360);
            this.panel3.TabIndex = 1;
            // 
            // labelException
            // 
            this.labelException.AutoSize = true;
            this.labelException.Location = new System.Drawing.Point(6, 338);
            this.labelException.Name = "labelException";
            this.labelException.Size = new System.Drawing.Size(0, 20);
            this.labelException.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonLess);
            this.panel2.Controls.Add(this.radioButtonMore);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.buttonConfirm);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 41);
            this.panel2.TabIndex = 0;
            // 
            // radioButtonLess
            // 
            this.radioButtonLess.AutoSize = true;
            this.radioButtonLess.Location = new System.Drawing.Point(373, 10);
            this.radioButtonLess.Name = "radioButtonLess";
            this.radioButtonLess.Size = new System.Drawing.Size(41, 24);
            this.radioButtonLess.TabIndex = 5;
            this.radioButtonLess.Text = "<";
            this.radioButtonLess.UseVisualStyleBackColor = true;
            // 
            // radioButtonMore
            // 
            this.radioButtonMore.AutoSize = true;
            this.radioButtonMore.Checked = true;
            this.radioButtonMore.Location = new System.Drawing.Point(307, 10);
            this.radioButtonMore.Name = "radioButtonMore";
            this.radioButtonMore.Size = new System.Drawing.Size(41, 24);
            this.radioButtonMore.TabIndex = 4;
            this.radioButtonMore.TabStop = true;
            this.radioButtonMore.Text = ">";
            this.radioButtonMore.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(122, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Text = "0";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(460, 7);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(94, 29);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "查询";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入金额：";
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
            this.menuStrip2.Size = new System.Drawing.Size(592, 28);
            this.menuStrip2.TabIndex = 8;
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
            // FormSearchCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 453);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSearchCost";
            this.Text = "FormSearchCost";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSearchCost_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonLess;
        private System.Windows.Forms.RadioButton radioButtonMore;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label labelException;
    }
}