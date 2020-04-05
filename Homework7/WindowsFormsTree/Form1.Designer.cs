namespace WindowsFormsTree
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.recurLength = new System.Windows.Forms.ComboBox();
            this.penColor = new System.Windows.Forms.ComboBox();
            this.left_angle = new System.Windows.Forms.TrackBar();
            this.right_angle = new System.Windows.Forms.TrackBar();
            this.mainLength = new System.Windows.Forms.TrackBar();
            this.leftLength = new System.Windows.Forms.TrackBar();
            this.rightLength = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.left_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLength)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 446);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "递归深度";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "左分支角度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "右分支角度";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "主干长度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "左分支长度比";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "右分支长度比";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "画笔颜色";
            // 
            // recurLength
            // 
            this.recurLength.DisplayMember = "1";
            this.recurLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recurLength.FormattingEnabled = true;
            this.recurLength.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.recurLength.Location = new System.Drawing.Point(635, 73);
            this.recurLength.Name = "recurLength";
            this.recurLength.Size = new System.Drawing.Size(75, 20);
            this.recurLength.TabIndex = 16;
            this.recurLength.Tag = "depth";
            this.recurLength.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // penColor
            // 
            this.penColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.penColor.FormattingEnabled = true;
            this.penColor.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Yellow",
            "Green"});
            this.penColor.Location = new System.Drawing.Point(636, 394);
            this.penColor.Name = "penColor";
            this.penColor.Size = new System.Drawing.Size(75, 20);
            this.penColor.TabIndex = 17;
            this.penColor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // left_angle
            // 
            this.left_angle.Location = new System.Drawing.Point(635, 113);
            this.left_angle.Maximum = 45;
            this.left_angle.Minimum = 5;
            this.left_angle.Name = "left_angle";
            this.left_angle.Size = new System.Drawing.Size(117, 45);
            this.left_angle.TabIndex = 18;
            this.left_angle.Value = 20;
            this.left_angle.Scroll += new System.EventHandler(this.left_angle_Scroll);
            // 
            // right_angle
            // 
            this.right_angle.Location = new System.Drawing.Point(636, 177);
            this.right_angle.Maximum = 45;
            this.right_angle.Minimum = 5;
            this.right_angle.Name = "right_angle";
            this.right_angle.Size = new System.Drawing.Size(117, 45);
            this.right_angle.TabIndex = 19;
            this.right_angle.Value = 20;
            // 
            // mainLength
            // 
            this.mainLength.Location = new System.Drawing.Point(635, 228);
            this.mainLength.Maximum = 150;
            this.mainLength.Minimum = 75;
            this.mainLength.Name = "mainLength";
            this.mainLength.Size = new System.Drawing.Size(117, 45);
            this.mainLength.TabIndex = 20;
            this.mainLength.Value = 100;
            // 
            // leftLength
            // 
            this.leftLength.Location = new System.Drawing.Point(636, 279);
            this.leftLength.Maximum = 90;
            this.leftLength.Minimum = 10;
            this.leftLength.Name = "leftLength";
            this.leftLength.Size = new System.Drawing.Size(117, 45);
            this.leftLength.SmallChange = 10;
            this.leftLength.TabIndex = 21;
            this.leftLength.Value = 50;
            // 
            // rightLength
            // 
            this.rightLength.Location = new System.Drawing.Point(636, 330);
            this.rightLength.Maximum = 90;
            this.rightLength.Minimum = 10;
            this.rightLength.Name = "rightLength";
            this.rightLength.Size = new System.Drawing.Size(117, 45);
            this.rightLength.SmallChange = 10;
            this.rightLength.TabIndex = 22;
            this.rightLength.Value = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rightLength);
            this.Controls.Add(this.leftLength);
            this.Controls.Add(this.mainLength);
            this.Controls.Add(this.right_angle);
            this.Controls.Add(this.left_angle);
            this.Controls.Add(this.penColor);
            this.Controls.Add(this.recurLength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.left_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox recurLength;
        private System.Windows.Forms.ComboBox penColor;
        private System.Windows.Forms.TrackBar left_angle;
        private System.Windows.Forms.TrackBar right_angle;
        private System.Windows.Forms.TrackBar mainLength;
        private System.Windows.Forms.TrackBar leftLength;
        private System.Windows.Forms.TrackBar rightLength;
    }
}

