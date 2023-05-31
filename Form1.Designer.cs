namespace game1
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
            bg1 = new PictureBox();
            player = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            bg2 = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            labelLose = new Label();
            btnRestart = new Button();
            coin = new PictureBox();
            cointimer = new System.Windows.Forms.Timer(components);
            labelCoins = new Label();
            labelRecord = new Label();
            labelChoose = new Label();
            btnBlue = new Button();
            btnGreen = new Button();
            btnYellow = new Button();
            btnOrange = new Button();
            btnWhite = new Button();
            ((System.ComponentModel.ISupportInitialize)bg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            SuspendLayout();
            // 
            // bg1
            // 
            bg1.BackColor = SystemColors.Control;
            bg1.Image = (Image)resources.GetObject("bg1.Image");
            bg1.Location = new Point(0, 0);
            bg1.Name = "bg1";
            bg1.Size = new Size(840, 650);
            bg1.TabIndex = 0;
            bg1.TabStop = false;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.yellow_car;
            player.Location = new Point(394, 506);
            player.Name = "player";
            player.Size = new Size(50, 100);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 15;
            timer.Tick += timer_Tick;
            // 
            // bg2
            // 
            bg2.BackColor = SystemColors.Control;
            bg2.Image = (Image)resources.GetObject("bg2.Image");
            bg2.Location = new Point(0, -650);
            bg2.Name = "bg2";
            bg2.Size = new Size(840, 650);
            bg2.TabIndex = 2;
            bg2.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(183, -400);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(50, 100);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 3;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(567, -200);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(50, 100);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 4;
            enemy2.TabStop = false;
            // 
            // labelLose
            // 
            labelLose.AutoSize = true;
            labelLose.BackColor = Color.Transparent;
            labelLose.Font = new Font("Cooper Black", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            labelLose.ForeColor = Color.Red;
            labelLose.Location = new Point(346, 228);
            labelLose.Name = "labelLose";
            labelLose.Size = new Size(136, 31);
            labelLose.TabIndex = 5;
            labelLose.Text = "You lost!";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Transparent;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestart.ForeColor = Color.Red;
            btnRestart.Location = new Point(358, 262);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(110, 44);
            btnRestart.TabIndex = 6;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // coin
            // 
            coin.Image = Properties.Resources.coin_1;
            coin.Location = new Point(429, -600);
            coin.Name = "coin";
            coin.Size = new Size(30, 30);
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.TabIndex = 7;
            coin.TabStop = false;
            // 
            // cointimer
            // 
            cointimer.Interval = 200;
            cointimer.Tick += cointimer_Tick;
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.BackColor = Color.Tomato;
            labelCoins.Font = new Font("Cooper Black", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            labelCoins.ForeColor = Color.Snow;
            labelCoins.Location = new Point(680, 575);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(121, 31);
            labelCoins.TabIndex = 8;
            labelCoins.Text = "Coins: 0";
            // 
            // labelRecord
            // 
            labelRecord.AutoSize = true;
            labelRecord.BackColor = Color.Tomato;
            labelRecord.Font = new Font("Cooper Black", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            labelRecord.ForeColor = Color.Snow;
            labelRecord.Location = new Point(650, 533);
            labelRecord.Name = "labelRecord";
            labelRecord.Size = new Size(178, 31);
            labelRecord.TabIndex = 9;
            labelRecord.Text = "Max score: 0";
            // 
            // labelChoose
            // 
            labelChoose.AutoSize = true;
            labelChoose.BackColor = Color.Transparent;
            labelChoose.Font = new Font("Cooper Black", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            labelChoose.ForeColor = Color.White;
            labelChoose.Location = new Point(297, 116);
            labelChoose.Name = "labelChoose";
            labelChoose.Size = new Size(237, 31);
            labelChoose.TabIndex = 11;
            labelChoose.Text = "Choose car color";
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Transparent;
            btnBlue.FlatStyle = FlatStyle.Flat;
            btnBlue.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBlue.ForeColor = Color.Blue;
            btnBlue.Location = new Point(358, 150);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(110, 42);
            btnBlue.TabIndex = 12;
            btnBlue.Text = "Blue";
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Transparent;
            btnGreen.FlatStyle = FlatStyle.Flat;
            btnGreen.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGreen.ForeColor = Color.Green;
            btnGreen.Location = new Point(358, 198);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(110, 42);
            btnGreen.TabIndex = 13;
            btnGreen.Text = "Green";
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Transparent;
            btnYellow.FlatStyle = FlatStyle.Flat;
            btnYellow.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnYellow.ForeColor = Color.Yellow;
            btnYellow.Location = new Point(358, 246);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(110, 42);
            btnYellow.TabIndex = 14;
            btnYellow.Text = "Yellow";
            btnYellow.UseVisualStyleBackColor = false;
            btnYellow.Click += btnYellow_Click;
            // 
            // btnOrange
            // 
            btnOrange.BackColor = Color.Transparent;
            btnOrange.FlatStyle = FlatStyle.Flat;
            btnOrange.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrange.ForeColor = Color.Orange;
            btnOrange.Location = new Point(358, 294);
            btnOrange.Name = "btnOrange";
            btnOrange.Size = new Size(110, 42);
            btnOrange.TabIndex = 15;
            btnOrange.Text = "Orange";
            btnOrange.UseVisualStyleBackColor = false;
            btnOrange.Click += btnOrange_Click;
            // 
            // btnWhite
            // 
            btnWhite.BackColor = Color.Transparent;
            btnWhite.FlatStyle = FlatStyle.Flat;
            btnWhite.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnWhite.ForeColor = Color.White;
            btnWhite.Location = new Point(358, 342);
            btnWhite.Name = "btnWhite";
            btnWhite.Size = new Size(110, 42);
            btnWhite.TabIndex = 16;
            btnWhite.Text = "White";
            btnWhite.UseVisualStyleBackColor = false;
            btnWhite.Click += btnWhite_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(840, 650);
            Controls.Add(btnWhite);
            Controls.Add(btnOrange);
            Controls.Add(btnYellow);
            Controls.Add(btnGreen);
            Controls.Add(btnBlue);
            Controls.Add(labelChoose);
            Controls.Add(labelRecord);
            Controls.Add(labelCoins);
            Controls.Add(coin);
            Controls.Add(btnRestart);
            Controls.Add(labelLose);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(player);
            Controls.Add(bg1);
            Controls.Add(bg2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)bg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bg1;
        private PictureBox player;
        private System.Windows.Forms.Timer timer;
        private PictureBox bg2;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private Label labelLose;
        private Button btnRestart;
        private PictureBox coin;
        private System.Windows.Forms.Timer cointimer;
        private Label labelCoins;
        private Label labelRecord;
        private Label labelChoose;
        private Button btnBlue;
        private Button btnGreen;
        private Button btnYellow;
        private Button btnOrange;
        private Button btnWhite;
    }
}