namespace SchoolManagementSystem
{
    partial class Fees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fees));
            label7 = new Label();
            FeesDGV = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            PeriodDate = new DateTimePicker();
            StNameTb = new TextBox();
            label8 = new Label();
            label4 = new Label();
            StdIdCb = new ComboBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            AmountTb = new TextBox();
            BackBtn = new Button();
            AddBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)FeesDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGoldenrod;
            label7.Location = new Point(371, 231);
            label7.Name = "label7";
            label7.Size = new Size(219, 37);
            label7.TabIndex = 66;
            label7.Text = "Ödeme Listesi";
            // 
            // FeesDGV
            // 
            FeesDGV.BackgroundColor = Color.White;
            FeesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FeesDGV.GridColor = Color.DarkGray;
            FeesDGV.Location = new Point(44, 271);
            FeesDGV.Name = "FeesDGV";
            FeesDGV.RowHeadersWidth = 51;
            FeesDGV.RowTemplate.Height = 29;
            FeesDGV.Size = new Size(924, 399);
            FeesDGV.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(519, 91);
            label2.Name = "label2";
            label2.Size = new Size(71, 35);
            label2.TabIndex = 60;
            label2.Text = "Dönem";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(728, 91);
            label1.Name = "label1";
            label1.Size = new Size(56, 35);
            label1.TabIndex = 58;
            label1.Text = "Tutar";
            // 
            // PeriodDate
            // 
            PeriodDate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PeriodDate.Format = DateTimePickerFormat.Short;
            PeriodDate.Location = new Point(519, 129);
            PeriodDate.Name = "PeriodDate";
            PeriodDate.Size = new Size(193, 32);
            PeriodDate.TabIndex = 57;
            // 
            // StNameTb
            // 
            StNameTb.Enabled = false;
            StNameTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StNameTb.Location = new Point(310, 129);
            StNameTb.Name = "StNameTb";
            StNameTb.Size = new Size(192, 32);
            StNameTb.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGoldenrod;
            label8.Location = new Point(310, 91);
            label8.Name = "label8";
            label8.Size = new Size(109, 35);
            label8.TabIndex = 55;
            label8.Text = "Ögrenci Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGoldenrod;
            label4.Location = new Point(115, 91);
            label4.Name = "label4";
            label4.Size = new Size(158, 35);
            label4.TabIndex = 54;
            label4.Text = "Ögrenci Numarası";
            // 
            // StdIdCb
            // 
            StdIdCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StdIdCb.FormattingEnabled = true;
            StdIdCb.Items.AddRange(new object[] { "Kadın", "Erkek" });
            StdIdCb.Location = new Point(115, 129);
            StdIdCb.Name = "StdIdCb";
            StdIdCb.Size = new Size(179, 31);
            StdIdCb.TabIndex = 53;
            StdIdCb.SelectionChangeCommitted += StdIdCb_SelectionChangeCommitted;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 63);
            panel1.TabIndex = 52;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(978, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Location = new Point(68, 21);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 13;
            label3.Text = "Ödemeler";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1105, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // AmountTb
            // 
            AmountTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTb.Location = new Point(728, 128);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(192, 32);
            AmountTb.TabIndex = 67;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Goldenrod;
            BackBtn.BackgroundImageLayout = ImageLayout.Center;
            BackBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.DarkOliveGreen;
            BackBtn.Location = new Point(493, 181);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(202, 36);
            BackBtn.TabIndex = 71;
            BackBtn.Text = "Geri Dön";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Goldenrod;
            AddBtn.BackgroundImageLayout = ImageLayout.Center;
            AddBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.DarkOliveGreen;
            AddBtn.Location = new Point(266, 181);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(200, 36);
            AddBtn.TabIndex = 68;
            AddBtn.Text = "Öde";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // Fees
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 682);
            Controls.Add(BackBtn);
            Controls.Add(AddBtn);
            Controls.Add(AmountTb);
            Controls.Add(label7);
            Controls.Add(FeesDGV);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PeriodDate);
            Controls.Add(StNameTb);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(StdIdCb);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Fees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fees";
            ((System.ComponentModel.ISupportInitialize)FeesDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private DataGridView FeesDGV;
        private Label label2;
        private Label label1;
        private DateTimePicker PeriodDate;
        private TextBox StNameTb;
        private Label label8;
        private Label label4;
        private ComboBox StdIdCb;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox AmountTb;
        private Button BackBtn;
        private Button AddBtn;
        private PictureBox pictureBox3;
    }
}