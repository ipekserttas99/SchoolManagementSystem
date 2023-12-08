namespace SchoolManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            UNameTb = new TextBox();
            PasswordTb = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 57);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(728, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Juice ITC", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 34);
            label1.TabIndex = 1;
            label1.Text = "NET Anadolu Lisesi";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Location = new Point(54, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 31);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT Ext Condensed Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(419, 104);
            label2.Name = "label2";
            label2.Size = new Size(92, 38);
            label2.TabIndex = 4;
            label2.Text = "GİRİŞ YAP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Location = new Point(291, 172);
            label3.Name = "label3";
            label3.Size = new Size(116, 35);
            label3.TabIndex = 5;
            label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGoldenrod;
            label4.Location = new Point(291, 246);
            label4.Name = "label4";
            label4.Size = new Size(49, 35);
            label4.TabIndex = 6;
            label4.Text = "Şifre";
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkOliveGreen;
            button1.Location = new Point(386, 312);
            button1.Name = "button1";
            button1.Size = new Size(125, 36);
            button1.TabIndex = 7;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UNameTb
            // 
            UNameTb.Location = new Point(436, 176);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(240, 27);
            UNameTb.TabIndex = 8;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(436, 254);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(240, 27);
            PasswordTb.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGoldenrod;
            label5.Location = new Point(414, 351);
            label5.Name = "label5";
            label5.Size = new Size(52, 27);
            label5.TabIndex = 10;
            label5.Text = "Sıfırla";
            label5.Click += label5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 405);
            Controls.Add(label5);
            Controls.Add(PasswordTb);
            Controls.Add(UNameTb);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox UNameTb;
        private TextBox PasswordTb;
        private Label label5;
        private PictureBox pictureBox2;
    }
}