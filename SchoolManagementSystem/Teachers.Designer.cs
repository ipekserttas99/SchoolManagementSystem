namespace SchoolManagementSystem
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            TeachersDGV = new DataGridView();
            AddBtn = new Button();
            label6 = new Label();
            SubCb = new ComboBox();
            label5 = new Label();
            TDOB = new DateTimePicker();
            label4 = new Label();
            TGenCb = new ComboBox();
            TAddTb = new TextBox();
            label1 = new Label();
            TNameTb = new TextBox();
            label8 = new Label();
            TPhoneTb = new TextBox();
            label9 = new Label();
            EditBtn = new Button();
            DeleteBtn = new Button();
            BackBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TeachersDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 63);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(978, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(71, 23);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 14;
            label3.Text = "Öğretmenler";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(71, 23);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1087, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(397, 325);
            label7.Name = "label7";
            label7.Size = new Size(255, 37);
            label7.TabIndex = 40;
            label7.Text = "Öğretmen Listesi";
            // 
            // TeachersDGV
            // 
            TeachersDGV.BackgroundColor = Color.White;
            TeachersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeachersDGV.GridColor = Color.DarkGray;
            TeachersDGV.Location = new Point(52, 382);
            TeachersDGV.Name = "TeachersDGV";
            TeachersDGV.RowHeadersWidth = 51;
            TeachersDGV.RowTemplate.Height = 29;
            TeachersDGV.Size = new Size(924, 288);
            TeachersDGV.TabIndex = 39;
            TeachersDGV.CellContentClick += TeachersDGV_CellContentClick;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.PeachPuff;
            AddBtn.BackgroundImageLayout = ImageLayout.Center;
            AddBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.OrangeRed;
            AddBtn.Location = new Point(228, 267);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(125, 36);
            AddBtn.TabIndex = 35;
            AddBtn.Text = "Ekle";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(786, 72);
            label6.Name = "label6";
            label6.Size = new Size(71, 35);
            label6.TabIndex = 34;
            label6.Text = "Dersler";
            // 
            // SubCb
            // 
            SubCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubCb.FormattingEnabled = true;
            SubCb.Items.AddRange(new object[] { "Matematik", "Fizik", "Kimya", "Biyoloji", "Tarih", "Edebiyat", "Coğrafya", "Din Kültürü", "İngilizce", "Almanca" });
            SubCb.Location = new Point(786, 110);
            SubCb.Name = "SubCb";
            SubCb.Size = new Size(190, 31);
            SubCb.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(294, 174);
            label5.Name = "label5";
            label5.Size = new Size(125, 35);
            label5.TabIndex = 32;
            label5.Text = "Dogum Tarihi";
            // 
            // TDOB
            // 
            TDOB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TDOB.Format = DateTimePickerFormat.Short;
            TDOB.Location = new Point(294, 212);
            TDOB.Name = "TDOB";
            TDOB.Size = new Size(193, 32);
            TDOB.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(309, 72);
            label4.Name = "label4";
            label4.Size = new Size(75, 35);
            label4.TabIndex = 30;
            label4.Text = "Cinsiyet";
            // 
            // TGenCb
            // 
            TGenCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TGenCb.FormattingEnabled = true;
            TGenCb.Items.AddRange(new object[] { "Kadin", "Erkek" });
            TGenCb.Location = new Point(294, 110);
            TGenCb.Name = "TGenCb";
            TGenCb.Size = new Size(179, 31);
            TGenCb.TabIndex = 29;
            // 
            // TAddTb
            // 
            TAddTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TAddTb.Location = new Point(580, 110);
            TAddTb.Multiline = true;
            TAddTb.Name = "TAddTb";
            TAddTb.Size = new Size(183, 134);
            TAddTb.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(554, 72);
            label1.Name = "label1";
            label1.Size = new Size(58, 35);
            label1.TabIndex = 27;
            label1.Text = "Adres";
            // 
            // TNameTb
            // 
            TNameTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TNameTb.Location = new Point(52, 112);
            TNameTb.Name = "TNameTb";
            TNameTb.Size = new Size(192, 32);
            TNameTb.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.OrangeRed;
            label8.Location = new Point(61, 74);
            label8.Name = "label8";
            label8.Size = new Size(40, 35);
            label8.TabIndex = 25;
            label8.Text = "Adı";
            // 
            // TPhoneTb
            // 
            TPhoneTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TPhoneTb.Location = new Point(52, 212);
            TPhoneTb.Name = "TPhoneTb";
            TPhoneTb.Size = new Size(183, 32);
            TPhoneTb.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.OrangeRed;
            label9.Location = new Point(61, 174);
            label9.Name = "label9";
            label9.Size = new Size(72, 35);
            label9.TabIndex = 41;
            label9.Text = "Telefon";
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.PeachPuff;
            EditBtn.BackgroundImageLayout = ImageLayout.Center;
            EditBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.OrangeRed;
            EditBtn.Location = new Point(374, 267);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(125, 36);
            EditBtn.TabIndex = 43;
            EditBtn.Text = "Düzenle";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.PeachPuff;
            DeleteBtn.BackgroundImageLayout = ImageLayout.Center;
            DeleteBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.OrangeRed;
            DeleteBtn.Location = new Point(513, 267);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(125, 36);
            DeleteBtn.TabIndex = 44;
            DeleteBtn.Text = "Sil";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.PeachPuff;
            BackBtn.BackgroundImageLayout = ImageLayout.Center;
            BackBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.OrangeRed;
            BackBtn.Location = new Point(655, 267);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(125, 36);
            BackBtn.TabIndex = 45;
            BackBtn.Text = "Geri Dön";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // Teachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 682);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(TPhoneTb);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(TeachersDGV);
            Controls.Add(AddBtn);
            Controls.Add(label6);
            Controls.Add(SubCb);
            Controls.Add(label5);
            Controls.Add(TDOB);
            Controls.Add(label4);
            Controls.Add(TGenCb);
            Controls.Add(TAddTb);
            Controls.Add(label1);
            Controls.Add(TNameTb);
            Controls.Add(label8);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teachers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)TeachersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label7;
        private DataGridView TeachersDGV;
        private Button AddBtn;
        private Label label6;
        private ComboBox SubCb;
        private Label label5;
        private DateTimePicker TDOB;
        private Label label4;
        private ComboBox TGenCb;
        private TextBox TAddTb;
        private Label label1;
        private TextBox TNameTb;
        private Label label8;
        private TextBox TPhoneTb;
        private Label label9;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button BackBtn;
        private PictureBox pictureBox1;
    }
}