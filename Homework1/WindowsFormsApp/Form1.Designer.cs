namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.operate = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // operate
            // 
            this.operate.Location = new System.Drawing.Point(388, 174);
            this.operate.Name = "operate";
            this.operate.Size = new System.Drawing.Size(44, 23);
            this.operate.TabIndex = 0;
            this.operate.Text = "=";
            this.operate.UseVisualStyleBackColor = true;
            this.operate.Click += new System.EventHandler(this.operate_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(35, 172);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(122, 25);
            this.input1.TabIndex = 1;
            this.input1.TextChanged += new System.EventHandler(this.input1_TextChanged);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(188, 172);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(29, 25);
            this.input2.TabIndex = 2;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(247, 172);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(109, 25);
            this.input3.TabIndex = 3;
            this.input3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(479, 174);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(143, 25);
            this.output.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.operate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button operate;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox output;
    }
}

