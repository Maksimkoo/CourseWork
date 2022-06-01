namespace CarsShopTuto
{
    partial class CarsShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsShop));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.CatCbSearchCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CarsDGV = new System.Windows.Forms.DataGridView();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.CCatCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CProducerTb = new System.Windows.Forms.TextBox();
            this.CTitleTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.CatCbSearchCb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CarsDGV);
            this.panel2.Controls.Add(this.ResetBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.PriceTb);
            this.panel2.Controls.Add(this.QtyTb);
            this.panel2.Controls.Add(this.CCatCb);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.SaveBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CProducerTb);
            this.panel2.Controls.Add(this.CTitleTb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(255, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 746);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.ForestGreen;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(720, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 41);
            this.button5.TabIndex = 24;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CatCbSearchCb
            // 
            this.CatCbSearchCb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatCbSearchCb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CatCbSearchCb.FormattingEnabled = true;
            this.CatCbSearchCb.Items.AddRange(new object[] {
            "Filters",
            "Oils and lubricants",
            "Candles",
            "Brake pads and pads",
            "Wipers and wiper blades"});
            this.CatCbSearchCb.Location = new System.Drawing.Point(491, 293);
            this.CatCbSearchCb.Name = "CatCbSearchCb";
            this.CatCbSearchCb.Size = new System.Drawing.Size(223, 29);
            this.CatCbSearchCb.TabIndex = 22;
            this.CatCbSearchCb.Text = "Filter By Category";
            this.CatCbSearchCb.SelectedIndexChanged += new System.EventHandler(this.CatCbSearchCb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(294, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 34);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cars Parts List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CarsDGV
            // 
            this.CarsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsDGV.Location = new System.Drawing.Point(166, 332);
            this.CarsDGV.Name = "CarsDGV";
            this.CarsDGV.RowHeadersWidth = 51;
            this.CarsDGV.RowTemplate.Height = 29;
            this.CarsDGV.Size = new System.Drawing.Size(800, 399);
            this.CarsDGV.TabIndex = 20;
            this.CarsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsDGV_CellContentClick);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.ResetBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(778, 199);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(154, 46);
            this.ResetBtn.TabIndex = 19;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(598, 199);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(154, 46);
            this.DeleteBtn.TabIndex = 18;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(414, 199);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(154, 46);
            this.EditBtn.TabIndex = 17;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(1007, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 27);
            this.label12.TabIndex = 16;
            this.label12.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(838, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 27);
            this.label13.TabIndex = 15;
            this.label13.Text = "Quantity";
            // 
            // PriceTb
            // 
            this.PriceTb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceTb.Location = new System.Drawing.Point(1007, 119);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(124, 36);
            this.PriceTb.TabIndex = 14;
            // 
            // QtyTb
            // 
            this.QtyTb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QtyTb.Location = new System.Drawing.Point(838, 119);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(128, 36);
            this.QtyTb.TabIndex = 13;
            // 
            // CCatCb
            // 
            this.CCatCb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CCatCb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CCatCb.FormattingEnabled = true;
            this.CCatCb.Items.AddRange(new object[] {
            "Filters",
            "Oils and lubricants",
            "Candles",
            "Brake pads and pads",
            "Wipers and wiper blades"});
            this.CCatCb.Location = new System.Drawing.Point(598, 123);
            this.CCatCb.Name = "CCatCb";
            this.CCatCb.Size = new System.Drawing.Size(217, 29);
            this.CCatCb.TabIndex = 12;
            this.CCatCb.Text = "Select Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(598, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 27);
            this.label11.TabIndex = 11;
            this.label11.Text = "Categories";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1058, 603);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 128);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(1182, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(229, 199);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(154, 46);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(331, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Producer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(53, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cars Parts Title";
            // 
            // CProducerTb
            // 
            this.CProducerTb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CProducerTb.Location = new System.Drawing.Point(331, 119);
            this.CProducerTb.Name = "CProducerTb";
            this.CProducerTb.Size = new System.Drawing.Size(237, 36);
            this.CProducerTb.TabIndex = 4;
            // 
            // CTitleTb
            // 
            this.CTitleTb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CTitleTb.Location = new System.Drawing.Point(53, 119);
            this.CTitleTb.Name = "CTitleTb";
            this.CTitleTb.Size = new System.Drawing.Size(237, 36);
            this.CTitleTb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(491, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cars Parts Shop ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 746);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(17, 373);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 46);
            this.panel6.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(58, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 27);
            this.label10.TabIndex = 11;
            this.label10.Text = "Logout";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(17, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 46);
            this.panel5.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(37, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 27);
            this.label9.TabIndex = 11;
            this.label9.Text = "Dashboard";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(17, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 46);
            this.panel4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(69, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Users";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(17, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 46);
            this.panel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cars Parts Shop ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(26, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cars Parts Shop ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // CarsShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1481, 770);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarsShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarsShop";
            this.Load += new System.EventHandler(this.CarsShop_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label8;
        private Button SaveBtn;
        private Label label3;
        private Label label2;
        private TextBox CProducerTb;
        private TextBox CTitleTb;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Panel panel5;
        private Label label9;
        private Panel panel4;
        private Label label7;
        private ComboBox CCatCb;
        private Label label11;
        private Panel panel6;
        private Label label10;
        private Label label4;
        private DataGridView CarsDGV;
        private Button ResetBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private Label label12;
        private Label label13;
        private TextBox PriceTb;
        private TextBox QtyTb;
        private Button button5;
        private ComboBox CatCbSearchCb;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}