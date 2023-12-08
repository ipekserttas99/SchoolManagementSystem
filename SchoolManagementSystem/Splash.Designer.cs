namespace SchoolManagementSystem
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            MyProgressBar = new ProgressBar();
            label2 = new Label();
            Percentage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Juice ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(210, 25);
            label1.Name = "label1";
            label1.Size = new Size(273, 53);
            label1.TabIndex = 0;
            label1.Text = "NET Anadolu Lisesi";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(274, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MyProgressBar
            // 
            MyProgressBar.ForeColor = Color.DarkGoldenrod;
            MyProgressBar.Location = new Point(12, 316);
            MyProgressBar.Name = "MyProgressBar";
            MyProgressBar.Size = new Size(715, 15);
            MyProgressBar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Juice ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(12, 281);
            label2.Name = "label2";
            label2.Size = new Size(160, 32);
            label2.TabIndex = 3;
            label2.Text = "Modul yükleniyor...";
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Juice ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Percentage.ForeColor = Color.YellowGreen;
            Percentage.Location = new Point(178, 281);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(30, 32);
            Percentage.TabIndex = 4;
            Percentage.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(739, 343);
            Controls.Add(Percentage);
            Controls.Add(label2);
            Controls.Add(MyProgressBar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar MyProgressBar;
        private Label label2;
        private Label Percentage;
        private System.Windows.Forms.Timer timer1;
    }
}