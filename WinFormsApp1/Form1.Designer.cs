
namespace WinFormsApp1
{
    partial class Form1
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
            this.numText1 = new System.Windows.Forms.TextBox();
            this.numText2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.RadioButton();
            this.subButton = new System.Windows.Forms.RadioButton();
            this.multiplyButton = new System.Windows.Forms.RadioButton();
            this.divideButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numText1
            // 
            this.numText1.Location = new System.Drawing.Point(55, 32);
            this.numText1.Name = "numText1";
            this.numText1.Size = new System.Drawing.Size(125, 27);
            this.numText1.TabIndex = 0;
            // 
            // numText2
            // 
            this.numText2.Location = new System.Drawing.Point(55, 207);
            this.numText2.Name = "numText2";
            this.numText2.Size = new System.Drawing.Size(125, 27);
            this.numText2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Checked = true;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(41, 24);
            this.addButton.TabIndex = 5;
            this.addButton.TabStop = true;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // subButton
            // 
            this.subButton.AutoSize = true;
            this.subButton.Location = new System.Drawing.Point(3, 33);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(36, 24);
            this.subButton.TabIndex = 6;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            this.multiplyButton.AutoSize = true;
            this.multiplyButton.Location = new System.Drawing.Point(3, 63);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(37, 24);
            this.multiplyButton.TabIndex = 7;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            this.divideButton.AutoSize = true;
            this.divideButton.Location = new System.Drawing.Point(3, 93);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(36, 24);
            this.divideButton.TabIndex = 8;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.divideButton);
            this.panel1.Controls.Add(this.subButton);
            this.panel1.Controls.Add(this.multiplyButton);
            this.panel1.Location = new System.Drawing.Point(55, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 126);
            this.panel1.TabIndex = 9;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 271);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numText2);
            this.Controls.Add(this.numText1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numText1;
        private System.Windows.Forms.TextBox numText2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton addButton;
        private System.Windows.Forms.RadioButton subButton;
        private System.Windows.Forms.RadioButton multiplyButton;
        private System.Windows.Forms.RadioButton divideButton;
        private System.Windows.Forms.Panel panel1;
    }
}

