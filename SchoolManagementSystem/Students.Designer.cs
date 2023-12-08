namespace SchoolManagementSystem
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            StNameTb = new TextBox();
            label3 = new Label();
            FeesTb = new TextBox();
            label1 = new Label();
            StGenCb = new ComboBox();
            label4 = new Label();
            DOBPicker = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            ClassCb = new ComboBox();
            SaveBtn = new Button();
            EditBtn = new Button();
            BackBtn = new Button();
            DeleteBtn = new Button();
            StudentsDGV = new DataGridView();
            label7 = new Label();
            AddressTb = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentsDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 63);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(978, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(71, 23);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 12;
            label2.Text = "Öğrenciler";
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
            // StNameTb
            // 
            StNameTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StNameTb.Location = new Point(24, 147);
            StNameTb.Name = "StNameTb";
            StNameTb.Size = new Size(148, 32);
            StNameTb.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Location = new Point(24, 111);
            label3.Name = "label3";
            label3.Size = new Size(40, 35);
            label3.TabIndex = 9;
            label3.Text = "Adı";
            // 
            // FeesTb
            // 
            FeesTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FeesTb.Location = new Point(693, 147);
            FeesTb.Name = "FeesTb";
            FeesTb.Size = new Size(142, 32);
            FeesTb.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(693, 107);
            label1.Name = "label1";
            label1.Size = new Size(106, 35);
            label1.TabIndex = 11;
            label1.Text = "Harç Ücreti";
            // 
            // StGenCb
            // 
            StGenCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StGenCb.FormattingEnabled = true;
            StGenCb.Items.AddRange(new object[] { "Kadin", "Erkek" });
            StGenCb.Location = new Point(186, 148);
            StGenCb.Name = "StGenCb";
            StGenCb.Size = new Size(141, 31);
            StGenCb.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGoldenrod;
            label4.Location = new Point(186, 108);
            label4.Name = "label4";
            label4.Size = new Size(75, 35);
            label4.TabIndex = 14;
            label4.Text = "Cinsiyet";
            // 
            // DOBPicker
            // 
            DOBPicker.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DOBPicker.Format = DateTimePickerFormat.Short;
            DOBPicker.Location = new Point(351, 147);
            DOBPicker.Name = "DOBPicker";
            DOBPicker.Size = new Size(152, 32);
            DOBPicker.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGoldenrod;
            label5.Location = new Point(351, 108);
            label5.Name = "label5";
            label5.Size = new Size(125, 35);
            label5.TabIndex = 16;
            label5.Text = "Dogum Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGoldenrod;
            label6.Location = new Point(526, 108);
            label6.Name = "label6";
            label6.Size = new Size(48, 35);
            label6.TabIndex = 18;
            label6.Text = "Sınıf";
            // 
            // ClassCb
            // 
            ClassCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClassCb.FormattingEnabled = true;
            ClassCb.Items.AddRange(new object[] { "9. Sinif", "10. Sinif", "11. Sinif", "12. Sinif" });
            ClassCb.Location = new Point(526, 147);
            ClassCb.Name = "ClassCb";
            ClassCb.Size = new Size(145, 31);
            ClassCb.TabIndex = 17;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Goldenrod;
            SaveBtn.BackgroundImageLayout = ImageLayout.Center;
            SaveBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.DarkOliveGreen;
            SaveBtn.Location = new Point(186, 215);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(125, 36);
            SaveBtn.TabIndex = 19;
            SaveBtn.Text = "Ekle";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Goldenrod;
            EditBtn.BackgroundImageLayout = ImageLayout.Center;
            EditBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.DarkOliveGreen;
            EditBtn.Location = new Point(351, 215);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(125, 36);
            EditBtn.TabIndex = 20;
            EditBtn.Text = "Düzenle";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Goldenrod;
            BackBtn.BackgroundImageLayout = ImageLayout.Center;
            BackBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.DarkOliveGreen;
            BackBtn.Location = new Point(674, 215);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(125, 36);
            BackBtn.TabIndex = 22;
            BackBtn.Text = "Geri Dön";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Goldenrod;
            DeleteBtn.BackgroundImageLayout = ImageLayout.Center;
            DeleteBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.DarkOliveGreen;
            DeleteBtn.Location = new Point(516, 215);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(125, 36);
            DeleteBtn.TabIndex = 21;
            DeleteBtn.Text = "Sil";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // StudentsDGV
            // 
            StudentsDGV.BackgroundColor = Color.White;
            StudentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsDGV.GridColor = Color.DarkGray;
            StudentsDGV.Location = new Point(24, 334);
            StudentsDGV.Name = "StudentsDGV";
            StudentsDGV.RowHeadersWidth = 51;
            StudentsDGV.RowTemplate.Height = 29;
            StudentsDGV.Size = new Size(972, 336);
            StudentsDGV.TabIndex = 23;
            StudentsDGV.CellContentClick += StudentsDGV_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGoldenrod;
            label7.Location = new Point(386, 282);
            label7.Name = "label7";
            label7.Size = new Size(224, 37);
            label7.TabIndex = 24;
            label7.Text = "Öğrenci Listesi";
            // 
            // AddressTb
            // 
            AddressTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTb.Location = new Point(841, 145);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(155, 130);
            AddressTb.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGoldenrod;
            label8.Location = new Point(847, 107);
            label8.Name = "label8";
            label8.Size = new Size(58, 35);
            label8.TabIndex = 25;
            label8.Text = "Adres";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 682);
            Controls.Add(AddressTb);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(StudentsDGV);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label6);
            Controls.Add(ClassCb);
            Controls.Add(label5);
            Controls.Add(DOBPicker);
            Controls.Add(label4);
            Controls.Add(StGenCb);
            Controls.Add(FeesTb);
            Controls.Add(label1);
            Controls.Add(StNameTb);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox StNameTb;
        private Label label3;
        private TextBox FeesTb;
        private Label label1;
        private ComboBox StGenCb;
        private Label label4;
        private DateTimePicker DOBPicker;
        private Label label5;
        private Label label6;
        private ComboBox ClassCb;
        private Button SaveBtn;
        private Button EditBtn;
        private Button BackBtn;
        private Button DeleteBtn;
        private DataGridView StudentsDGV;
        private Label label7;
        private TextBox AddressTb;
        private Label label8;
        private PictureBox pictureBox3;
    }
}