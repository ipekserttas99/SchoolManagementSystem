namespace SchoolManagementSystem
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            button3 = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            EDurationTb = new TextBox();
            label7 = new Label();
            EventsDGV = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            EDate = new DateTimePicker();
            EDescTb = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)EventsDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkOliveGreen;
            button3.Location = new Point(666, 187);
            button3.Name = "button3";
            button3.Size = new Size(125, 36);
            button3.TabIndex = 86;
            button3.Text = "Geri Dön";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Goldenrod;
            DeleteBtn.BackgroundImageLayout = ImageLayout.Center;
            DeleteBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.DarkOliveGreen;
            DeleteBtn.Location = new Point(508, 187);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(125, 36);
            DeleteBtn.TabIndex = 85;
            DeleteBtn.Text = "Sil";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Goldenrod;
            EditBtn.BackgroundImageLayout = ImageLayout.Center;
            EditBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.DarkOliveGreen;
            EditBtn.Location = new Point(343, 187);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(125, 36);
            EditBtn.TabIndex = 84;
            EditBtn.Text = "Düzenle";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Goldenrod;
            AddBtn.BackgroundImageLayout = ImageLayout.Center;
            AddBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.DarkOliveGreen;
            AddBtn.Location = new Point(178, 187);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(125, 36);
            AddBtn.TabIndex = 83;
            AddBtn.Text = "Ekle";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EDurationTb
            // 
            EDurationTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EDurationTb.Location = new Point(686, 132);
            EDurationTb.Name = "EDurationTb";
            EDurationTb.Size = new Size(192, 27);
            EDurationTb.TabIndex = 82;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGoldenrod;
            label7.Location = new Point(366, 247);
            label7.Name = "label7";
            label7.Size = new Size(165, 30);
            label7.TabIndex = 81;
            label7.Text = "Etkinlik Listesi";
            // 
            // EventsDGV
            // 
            EventsDGV.BackgroundColor = Color.White;
            EventsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventsDGV.GridColor = Color.DarkGray;
            EventsDGV.Location = new Point(44, 297);
            EventsDGV.Name = "EventsDGV";
            EventsDGV.RowHeadersWidth = 51;
            EventsDGV.RowTemplate.Height = 29;
            EventsDGV.Size = new Size(924, 373);
            EventsDGV.TabIndex = 80;
            EventsDGV.CellContentClick += EventsDGV_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(398, 94);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 79;
            label2.Text = "Tarih";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(686, 94);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 78;
            label1.Text = "Süre (saat cinsinden)";
            // 
            // EDate
            // 
            EDate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EDate.Format = DateTimePickerFormat.Short;
            EDate.Location = new Point(398, 132);
            EDate.Name = "EDate";
            EDate.Size = new Size(193, 27);
            EDate.TabIndex = 77;
            // 
            // EDescTb
            // 
            EDescTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EDescTb.Location = new Point(92, 136);
            EDescTb.Name = "EDescTb";
            EDescTb.Size = new Size(192, 27);
            EDescTb.TabIndex = 76;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGoldenrod;
            label8.Location = new Point(92, 98);
            label8.Name = "label8";
            label8.Size = new Size(61, 28);
            label8.TabIndex = 75;
            label8.Text = "Etkinlik";
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
            panel1.TabIndex = 72;
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
            label3.Size = new Size(79, 21);
            label3.TabIndex = 13;
            label3.Text = "Etkinlikler";
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
            // Events
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 682);
            Controls.Add(button3);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(EDurationTb);
            Controls.Add(label7);
            Controls.Add(EventsDGV);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EDate);
            Controls.Add(EDescTb);
            Controls.Add(label8);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Events";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Events";
            ((System.ComponentModel.ISupportInitialize)EventsDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private TextBox EDurationTb;
        private Label label7;
        private DataGridView EventsDGV;
        private Label label2;
        private Label label1;
        private DateTimePicker EDate;
        private TextBox EDescTb;
        private Label label8;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}