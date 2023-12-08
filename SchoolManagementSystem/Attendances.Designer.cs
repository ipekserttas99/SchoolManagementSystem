namespace SchoolManagementSystem
{
    partial class Attendances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendances));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            StIdCb = new ComboBox();
            StNameTb = new TextBox();
            label8 = new Label();
            label1 = new Label();
            AttDatePicker = new DateTimePicker();
            label2 = new Label();
            AttStatusCb = new ComboBox();
            BackBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            label7 = new Label();
            AttendancesDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AttendancesDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 63);
            panel1.TabIndex = 3;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(68, 22);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 12;
            label5.Text = "Yoklama";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(95, 85);
            label4.Name = "label4";
            label4.Size = new Size(158, 35);
            label4.TabIndex = 32;
            label4.Text = "Ögrenci Numarası";
            // 
            // StIdCb
            // 
            StIdCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StIdCb.FormattingEnabled = true;
            StIdCb.Items.AddRange(new object[] { "Kadın", "Erkek" });
            StIdCb.Location = new Point(95, 123);
            StIdCb.Name = "StIdCb";
            StIdCb.Size = new Size(179, 31);
            StIdCb.TabIndex = 31;
            StIdCb.SelectionChangeCommitted += StIdCb_SelectionChangeCommitted;
            // 
            // StNameTb
            // 
            StNameTb.Enabled = false;
            StNameTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StNameTb.Location = new Point(290, 123);
            StNameTb.Name = "StNameTb";
            StNameTb.Size = new Size(192, 32);
            StNameTb.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(290, 85);
            label8.Name = "label8";
            label8.Size = new Size(109, 35);
            label8.TabIndex = 33;
            label8.Text = "Ögrenci Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(499, 85);
            label1.Name = "label1";
            label1.Size = new Size(55, 35);
            label1.TabIndex = 36;
            label1.Text = "Tarih";
            // 
            // AttDatePicker
            // 
            AttDatePicker.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AttDatePicker.Format = DateTimePickerFormat.Short;
            AttDatePicker.Location = new Point(499, 123);
            AttDatePicker.Name = "AttDatePicker";
            AttDatePicker.Size = new Size(193, 32);
            AttDatePicker.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(708, 85);
            label2.Name = "label2";
            label2.Size = new Size(79, 35);
            label2.TabIndex = 38;
            label2.Text = "Durumu";
            // 
            // AttStatusCb
            // 
            AttStatusCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AttStatusCb.FormattingEnabled = true;
            AttStatusCb.Items.AddRange(new object[] { "Katildi", "Katilmadi", "Izinli" });
            AttStatusCb.Location = new Point(708, 123);
            AttStatusCb.Name = "AttStatusCb";
            AttStatusCb.Size = new Size(179, 31);
            AttStatusCb.TabIndex = 37;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Khaki;
            BackBtn.BackgroundImageLayout = ImageLayout.Center;
            BackBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.Maroon;
            BackBtn.Location = new Point(631, 173);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(125, 36);
            BackBtn.TabIndex = 49;
            BackBtn.Text = "Geri Dön";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Khaki;
            DeleteBtn.BackgroundImageLayout = ImageLayout.Center;
            DeleteBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.Maroon;
            DeleteBtn.Location = new Point(489, 173);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(125, 36);
            DeleteBtn.TabIndex = 48;
            DeleteBtn.Text = "Sıfırla";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Khaki;
            EditBtn.BackgroundImageLayout = ImageLayout.Center;
            EditBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.Maroon;
            EditBtn.Location = new Point(350, 173);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(125, 36);
            EditBtn.TabIndex = 47;
            EditBtn.Text = "Düzenle";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Khaki;
            AddBtn.BackgroundImageLayout = ImageLayout.Center;
            AddBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.Maroon;
            AddBtn.Location = new Point(204, 173);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(125, 36);
            AddBtn.TabIndex = 46;
            AddBtn.Text = "Ekle";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(369, 222);
            label7.Name = "label7";
            label7.Size = new Size(233, 37);
            label7.TabIndex = 51;
            label7.Text = "Yoklama Listesi";
            // 
            // AttendancesDGV
            // 
            AttendancesDGV.BackgroundColor = Color.White;
            AttendancesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendancesDGV.GridColor = Color.DarkGray;
            AttendancesDGV.Location = new Point(44, 262);
            AttendancesDGV.Name = "AttendancesDGV";
            AttendancesDGV.RowHeadersWidth = 51;
            AttendancesDGV.RowTemplate.Height = 29;
            AttendancesDGV.Size = new Size(924, 408);
            AttendancesDGV.TabIndex = 50;
            AttendancesDGV.CellContentClick += AttendancesDGV_CellContentClick;
            // 
            // Attendances
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 682);
            Controls.Add(label7);
            Controls.Add(AttendancesDGV);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(label2);
            Controls.Add(AttStatusCb);
            Controls.Add(label1);
            Controls.Add(AttDatePicker);
            Controls.Add(StNameTb);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(StIdCb);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Attendances";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendances";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AttendancesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private ComboBox StIdCb;
        private TextBox StNameTb;
        private Label label8;
        private Label label1;
        private DateTimePicker AttDatePicker;
        private Label label2;
        private ComboBox AttStatusCb;
        private Button BackBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private Label label7;
        private DataGridView AttendancesDGV;
        private PictureBox pictureBox3;
    }
}