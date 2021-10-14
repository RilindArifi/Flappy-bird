
namespace flappy_bird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.pipebottom2 = new System.Windows.Forms.PictureBox();
            this.pipebottom3 = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.pipetop2 = new System.Windows.Forms.PictureBox();
            this.pipetop3 = new System.Windows.Forms.PictureBox();
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pipebottom4 = new System.Windows.Forms.PictureBox();
            this.pipetop4 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.score1 = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.startGameagain = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pipebottom
            // 
            this.pipebottom.Image = ((System.Drawing.Image)(resources.GetObject("pipebottom.Image")));
            this.pipebottom.Location = new System.Drawing.Point(660, 487);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(121, 342);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 1;
            this.pipebottom.TabStop = false;
            // 
            // pipebottom2
            // 
            this.pipebottom2.Image = ((System.Drawing.Image)(resources.GetObject("pipebottom2.Image")));
            this.pipebottom2.Location = new System.Drawing.Point(1006, 392);
            this.pipebottom2.Name = "pipebottom2";
            this.pipebottom2.Size = new System.Drawing.Size(121, 348);
            this.pipebottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom2.TabIndex = 2;
            this.pipebottom2.TabStop = false;
            // 
            // pipebottom3
            // 
            this.pipebottom3.Image = ((System.Drawing.Image)(resources.GetObject("pipebottom3.Image")));
            this.pipebottom3.Location = new System.Drawing.Point(1353, 512);
            this.pipebottom3.Name = "pipebottom3";
            this.pipebottom3.Size = new System.Drawing.Size(121, 364);
            this.pipebottom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom3.TabIndex = 3;
            this.pipebottom3.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.BackColor = System.Drawing.Color.Transparent;
            this.pipetop.Image = ((System.Drawing.Image)(resources.GetObject("pipetop.Image")));
            this.pipetop.Location = new System.Drawing.Point(660, -46);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(121, 317);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 4;
            this.pipetop.TabStop = false;
            // 
            // pipetop2
            // 
            this.pipetop2.Image = ((System.Drawing.Image)(resources.GetObject("pipetop2.Image")));
            this.pipetop2.Location = new System.Drawing.Point(1006, -135);
            this.pipetop2.Name = "pipetop2";
            this.pipetop2.Size = new System.Drawing.Size(121, 317);
            this.pipetop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop2.TabIndex = 5;
            this.pipetop2.TabStop = false;
            // 
            // pipetop3
            // 
            this.pipetop3.Image = ((System.Drawing.Image)(resources.GetObject("pipetop3.Image")));
            this.pipetop3.Location = new System.Drawing.Point(1353, -65);
            this.pipetop3.Name = "pipetop3";
            this.pipetop3.Size = new System.Drawing.Size(121, 386);
            this.pipetop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop3.TabIndex = 6;
            this.pipetop3.TabStop = false;
            // 
            // flappybird
            // 
            this.flappybird.BackColor = System.Drawing.Color.Transparent;
            this.flappybird.Image = ((System.Drawing.Image)(resources.GetObject("flappybird.Image")));
            this.flappybird.Location = new System.Drawing.Point(96, 363);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(55, 46);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 7;
            this.flappybird.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 24;
            this.timer1.Tick += new System.EventHandler(this.gametimer);
            // 
            // pipebottom4
            // 
            this.pipebottom4.Image = ((System.Drawing.Image)(resources.GetObject("pipebottom4.Image")));
            this.pipebottom4.Location = new System.Drawing.Point(1698, 314);
            this.pipebottom4.Name = "pipebottom4";
            this.pipebottom4.Size = new System.Drawing.Size(124, 426);
            this.pipebottom4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom4.TabIndex = 10;
            this.pipebottom4.TabStop = false;
            // 
            // pipetop4
            // 
            this.pipetop4.Image = ((System.Drawing.Image)(resources.GetObject("pipetop4.Image")));
            this.pipetop4.Location = new System.Drawing.Point(1698, -233);
            this.pipetop4.Name = "pipetop4";
            this.pipetop4.Size = new System.Drawing.Size(124, 339);
            this.pipetop4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop4.TabIndex = 11;
            this.pipetop4.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-2, 732);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1978, 126);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.score1.ForeColor = System.Drawing.Color.OrangeRed;
            this.score1.Location = new System.Drawing.Point(203, 48);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(0, 41);
            this.score1.TabIndex = 14;
            // 
            // pause
            // 
            this.pause.AutoSize = true;
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pause.ForeColor = System.Drawing.Color.OrangeRed;
            this.pause.Location = new System.Drawing.Point(34, 789);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(150, 31);
            this.pause.TabIndex = 15;
            this.pause.Text = "Pause click P";
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameover.ForeColor = System.Drawing.Color.Red;
            this.gameover.Location = new System.Drawing.Point(287, 238);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(0, 81);
            this.gameover.TabIndex = 16;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start.ForeColor = System.Drawing.Color.OrangeRed;
            this.start.Location = new System.Drawing.Point(203, 789);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(140, 31);
            this.start.TabIndex = 17;
            this.start.Text = "Start click S";
            // 
            // startGameagain
            // 
            this.startGameagain.BackColor = System.Drawing.Color.DarkTurquoise;
            this.startGameagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameagain.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startGameagain.ForeColor = System.Drawing.Color.Yellow;
            this.startGameagain.Location = new System.Drawing.Point(261, 425);
            this.startGameagain.Name = "startGameagain";
            this.startGameagain.Size = new System.Drawing.Size(278, 53);
            this.startGameagain.TabIndex = 19;
            this.startGameagain.Text = "Start Game again";
            this.startGameagain.UseVisualStyleBackColor = false;
            this.startGameagain.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(575, 425);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(159, 53);
            this.exit.TabIndex = 20;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1082, 845);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.startGameagain);
            this.Controls.Add(this.start);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.flappybird);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pipetop4);
            this.Controls.Add(this.pipebottom4);
            this.Controls.Add(this.pipetop3);
            this.Controls.Add(this.pipetop2);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.pipebottom3);
            this.Controls.Add(this.pipebottom2);
            this.Controls.Add(this.pipebottom);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamebirdKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamebirdKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox pipebottom2;
        private System.Windows.Forms.PictureBox pipebottom3;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox pipetop2;
        private System.Windows.Forms.PictureBox pipetop3;
        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pipebottom4;
        private System.Windows.Forms.PictureBox pipetop4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label pause;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Button startGameagain;
        private System.Windows.Forms.Button exit;
    }
}

