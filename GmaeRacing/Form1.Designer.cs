namespace GmaeRacing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backGround1 = new PictureBox();
            Car = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            backGround0 = new PictureBox();
            backGround2 = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            LoseLabel = new Label();
            btnRestart = new Button();
            gasPic = new PictureBox();
            gasLabel = new Label();
            labelLoseWhy = new Label();
            CoinPic = new PictureBox();
            CoinsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)backGround1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backGround0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backGround2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gasPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CoinPic).BeginInit();
            SuspendLayout();
            // 
            // backGround1
            // 
            backGround1.BackColor = Color.Transparent;
            backGround1.Image = Properties.Resources._16783640472;
            backGround1.Location = new Point(0, 0);
            backGround1.Name = "backGround1";
            backGround1.Size = new Size(815, 650);
            backGround1.TabIndex = 0;
            backGround1.TabStop = false;
            backGround1.Click += pictureBox1_Click;
            // 
            // Car
            // 
            Car.BackColor = Color.Transparent;
            Car.Image = Properties.Resources.Car_Top_View_PNG_Image;
            Car.Location = new Point(421, 444);
            Car.Name = "Car";
            Car.Size = new Size(115, 102);
            Car.SizeMode = PictureBoxSizeMode.StretchImage;
            Car.TabIndex = 1;
            Car.TabStop = false;
            Car.Click += pictureBox2_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 15;
            timer.Tick += timer_Tick;
            // 
            // backGround0
            // 
            backGround0.Image = (Image)resources.GetObject("backGround0.Image");
            backGround0.Location = new Point(0, -650);
            backGround0.Name = "backGround0";
            backGround0.Size = new Size(815, 558);
            backGround0.TabIndex = 2;
            backGround0.TabStop = false;
            // 
            // backGround2
            // 
            backGround2.BackColor = Color.Transparent;
            backGround2.Image = Properties.Resources._16783640471;
            backGround2.Location = new Point(0, -650);
            backGround2.Name = "backGround2";
            backGround2.Size = new Size(815, 650);
            backGround2.TabIndex = 3;
            backGround2.TabStop = false;
            backGround2.Click += backGround2_Click;
            // 
            // enemy1
            // 
            enemy1.Image = Properties.Resources._146518_car_top_view_download_hd;
            enemy1.Location = new Point(565, 0);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(68, 118);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 4;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.Image = Properties.Resources._146518_car_top_view_download_hd;
            enemy2.Location = new Point(273, 0);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(69, 118);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 5;
            enemy2.TabStop = false;
            // 
            // LoseLabel
            // 
            LoseLabel.AutoSize = true;
            LoseLabel.Font = new Font("Trebuchet MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoseLabel.ForeColor = Color.IndianRed;
            LoseLabel.Location = new Point(250, 216);
            LoseLabel.Name = "LoseLabel";
            LoseLabel.Size = new Size(328, 81);
            LoseLabel.TabIndex = 6;
            LoseLabel.Text = "Проиграл";
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Yu Gothic UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRestart.ForeColor = Color.Coral;
            btnRestart.Location = new Point(294, 317);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(226, 80);
            btnRestart.TabIndex = 7;
            btnRestart.Text = "Играть заново";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // gasPic
            // 
            gasPic.Image = Properties.Resources._2289530;
            gasPic.Location = new Point(421, -700);
            gasPic.Name = "gasPic";
            gasPic.Size = new Size(39, 35);
            gasPic.SizeMode = PictureBoxSizeMode.StretchImage;
            gasPic.TabIndex = 8;
            gasPic.TabStop = false;
            // 
            // gasLabel
            // 
            gasLabel.AutoSize = true;
            gasLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            gasLabel.ForeColor = Color.CornflowerBlue;
            gasLabel.Location = new Point(12, 517);
            gasLabel.Name = "gasLabel";
            gasLabel.Size = new Size(117, 23);
            gasLabel.TabIndex = 9;
            gasLabel.Text = "Бензин: 30";
            // 
            // labelLoseWhy
            // 
            labelLoseWhy.AutoSize = true;
            labelLoseWhy.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoseWhy.ForeColor = Color.Crimson;
            labelLoseWhy.Location = new Point(375, 171);
            labelLoseWhy.Name = "labelLoseWhy";
            labelLoseWhy.Size = new Size(79, 31);
            labelLoseWhy.TabIndex = 10;
            labelLoseWhy.Text = "label1";
            // 
            // CoinPic
            // 
            CoinPic.Image = (Image)resources.GetObject("CoinPic.Image");
            CoinPic.Location = new Point(404, 12);
            CoinPic.Name = "CoinPic";
            CoinPic.Size = new Size(35, 35);
            CoinPic.SizeMode = PictureBoxSizeMode.StretchImage;
            CoinPic.TabIndex = 12;
            CoinPic.TabStop = false;
            // 
            // CoinsLabel
            // 
            CoinsLabel.AutoSize = true;
            CoinsLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CoinsLabel.ForeColor = Color.DarkOrange;
            CoinsLabel.Location = new Point(12, 484);
            CoinsLabel.Name = "CoinsLabel";
            CoinsLabel.Size = new Size(113, 23);
            CoinsLabel.TabIndex = 13;
            CoinsLabel.Text = "Монеты: 0";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(815, 558);
            Controls.Add(labelLoseWhy);
            Controls.Add(btnRestart);
            Controls.Add(CoinsLabel);
            Controls.Add(CoinPic);
            Controls.Add(gasLabel);
            Controls.Add(gasPic);
            Controls.Add(LoseLabel);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(Car);
            Controls.Add(backGround1);
            Controls.Add(backGround0);
            Controls.Add(backGround2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)backGround1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car).EndInit();
            ((System.ComponentModel.ISupportInitialize)backGround0).EndInit();
            ((System.ComponentModel.ISupportInitialize)backGround2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gasPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)CoinPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backGround1;
        private PictureBox Car;
        private System.Windows.Forms.Timer timer;
        private PictureBox backGround0;
        private PictureBox backGround2;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private Label LoseLabel;
        private Button btnRestart;
        private PictureBox gasPic;
        private Label gasLabel;
        private Label labelLoseWhy;
        private PictureBox CoinPic;
        private Label CoinsLabel;
    }
}
