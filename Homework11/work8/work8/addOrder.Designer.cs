namespace work8
{
    partial class AddOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoodPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GoodName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GoodNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GoodID = new System.Windows.Forms.TextBox();
            this.addItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustomerName";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(130, 53);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(96, 25);
            this.CustomerName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CustomerName);
            this.panel1.Location = new System.Drawing.Point(99, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 133);
            this.panel1.TabIndex = 11;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(250, 356);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 32);
            this.add.TabIndex = 13;
            this.add.Text = "addOrder";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GoodPrice);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.GoodName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.GoodNum);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.GoodID);
            this.panel2.Location = new System.Drawing.Point(99, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 184);
            this.panel2.TabIndex = 14;
            // 
            // GoodPrice
            // 
            this.GoodPrice.Location = new System.Drawing.Point(130, 131);
            this.GoodPrice.Name = "GoodPrice";
            this.GoodPrice.Size = new System.Drawing.Size(96, 25);
            this.GoodPrice.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "ProductPrice";
            // 
            // GoodName
            // 
            this.GoodName.Location = new System.Drawing.Point(130, 50);
            this.GoodName.Name = "GoodName";
            this.GoodName.Size = new System.Drawing.Size(96, 25);
            this.GoodName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "ProductName";
            // 
            // GoodNum
            // 
            this.GoodNum.Location = new System.Drawing.Point(130, 85);
            this.GoodNum.Name = "GoodNum";
            this.GoodNum.Size = new System.Drawing.Size(96, 25);
            this.GoodNum.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "ProductNum";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ProductID";
            // 
            // GoodID
            // 
            this.GoodID.Location = new System.Drawing.Point(130, 10);
            this.GoodID.Name = "GoodID";
            this.GoodID.Size = new System.Drawing.Size(96, 25);
            this.GoodID.TabIndex = 1;
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(116, 356);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(75, 32);
            this.addItem.TabIndex = 15;
            this.addItem.Text = "addItem";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 456);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.panel1);
            this.Name = "AddOrder";
            this.Text = "addOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox GoodName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GoodNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GoodID;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.TextBox GoodPrice;
        private System.Windows.Forms.Label label6;
    }
}