namespace frmPurchaseDiscountItem_1
{
    partial class frmDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.Item_1 = new System.Windows.Forms.TextBox();
            this.Compute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Price_1 = new System.Windows.Forms.TextBox();
            this.Discount_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Quantity_1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Total_1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Recieve = new System.Windows.Forms.TextBox();
            this.Recieve_1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // Item_1
            // 
            this.Item_1.Location = new System.Drawing.Point(32, 81);
            this.Item_1.Name = "Item_1";
            this.Item_1.Size = new System.Drawing.Size(193, 23);
            this.Item_1.TabIndex = 1;
            this.Item_1.TextChanged += new System.EventHandler(this.Item_1_TextChanged);
            // 
            // Compute
            // 
            this.Compute.Location = new System.Drawing.Point(182, 148);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(75, 23);
            this.Compute.TabIndex = 2;
            this.Compute.Text = "Compute";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // Price_1
            // 
            this.Price_1.Location = new System.Drawing.Point(76, 114);
            this.Price_1.Name = "Price_1";
            this.Price_1.Size = new System.Drawing.Size(149, 23);
            this.Price_1.TabIndex = 4;
            // 
            // Discount_1
            // 
            this.Discount_1.Location = new System.Drawing.Point(231, 81);
            this.Discount_1.Name = "Discount_1";
            this.Discount_1.Size = new System.Drawing.Size(124, 23);
            this.Discount_1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discount(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Quantity_1
            // 
            this.Quantity_1.Location = new System.Drawing.Point(284, 119);
            this.Quantity_1.Name = "Quantity_1";
            this.Quantity_1.Size = new System.Drawing.Size(71, 23);
            this.Quantity_1.TabIndex = 8;
            this.Quantity_1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Price: ";
            // 
            // Total_1
            // 
            this.Total_1.AutoSize = true;
            this.Total_1.Location = new System.Drawing.Point(149, 186);
            this.Total_1.Name = "Total_1";
            this.Total_1.Size = new System.Drawing.Size(38, 15);
            this.Total_1.TabIndex = 10;
            this.Total_1.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Payment Recieved: ";
            // 
            // Recieve
            // 
            this.Recieve.Location = new System.Drawing.Point(182, 237);
            this.Recieve.Name = "Recieve";
            this.Recieve.Size = new System.Drawing.Size(96, 23);
            this.Recieve.TabIndex = 12;
            // 
            // Recieve_1
            // 
            this.Recieve_1.Location = new System.Drawing.Point(284, 236);
            this.Recieve_1.Name = "Recieve_1";
            this.Recieve_1.Size = new System.Drawing.Size(71, 23);
            this.Recieve_1.TabIndex = 13;
            this.Recieve_1.Text = "Submit";
            this.Recieve_1.UseVisualStyleBackColor = true;
            this.Recieve_1.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Change:";
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Location = new System.Drawing.Point(187, 277);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(38, 15);
            this.Change.TabIndex = 15;
            this.Change.Text = "label9";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 329);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Recieve_1);
            this.Controls.Add(this.Recieve);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Total_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Quantity_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Discount_1);
            this.Controls.Add(this.Price_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.Item_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDisplay";
            this.Text = "frmDisplay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Item_1;
        private Button Compute;
        private Label label2;
        private TextBox Price_1;
        private TextBox Discount_1;
        private Label label3;
        private Label label4;
        private TextBox Quantity_1;
        private Label label5;
        private Label Total_1;
        private Label label7;
        private TextBox Recieve;
        private Button Recieve_1;
        private Label label8;
        private Label Change;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}