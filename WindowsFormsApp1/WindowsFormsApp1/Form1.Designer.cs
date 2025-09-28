namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeBottom1 = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom3 = new System.Windows.Forms.PictureBox();
            this.pipeTop3 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameOverBox = new System.Windows.Forms.PictureBox();
            this.startLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            // 
            // pipeTop1
            // 
            this.pipeTop1.Image = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeTop1.Location = new System.Drawing.Point(231, -319);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(63, 502);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 1;
            this.pipeTop1.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.SystemColors.Menu;
            this.bird.Image = global::WindowsFormsApp1.Properties.Resources.yellowbird_midflap;
            this.bird.Location = new System.Drawing.Point(43, 115);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(53, 38);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipeBottom1
            // 
            this.pipeBottom1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pipeBottom1.Image = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeBottom1.Location = new System.Drawing.Point(231, 317);
            this.pipeBottom1.Name = "pipeBottom1";
            this.pipeBottom1.Size = new System.Drawing.Size(63, 502);
            this.pipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom1.TabIndex = 5;
            this.pipeBottom1.TabStop = false;
            this.pipeBottom1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pipeBottom2.Image = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeBottom2.Location = new System.Drawing.Point(482, 317);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(63, 502);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 8;
            this.pipeBottom2.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.Image = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeTop2.Location = new System.Drawing.Point(482, -319);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(63, 502);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 7;
            this.pipeTop2.TabStop = false;
            // 
            // pipeBottom3
            // 
            this.pipeBottom3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pipeBottom3.Image = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeBottom3.Location = new System.Drawing.Point(625, 317);
            this.pipeBottom3.Name = "pipeBottom3";
            this.pipeBottom3.Size = new System.Drawing.Size(63, 502);
            this.pipeBottom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom3.TabIndex = 13;
            this.pipeBottom3.TabStop = false;
            // 
            // pipeTop3
            // 
            this.pipeTop3.Image = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeTop3.Location = new System.Drawing.Point(625, -319);
            this.pipeTop3.Name = "pipeTop3";
            this.pipeTop3.Size = new System.Drawing.Size(63, 502);
            this.pipeTop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop3.TabIndex = 12;
            this.pipeTop3.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::WindowsFormsApp1.Properties.Resources._base;
            this.ground.Location = new System.Drawing.Point(-7, 484);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(712, 182);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 14;
            this.ground.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(275, 33);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(162, 50);
            this.scoreLabel.TabIndex = 15;
            this.scoreLabel.Text = "Score: 0";
            // 
            // gameOverBox
            // 
            this.gameOverBox.Image = global::WindowsFormsApp1.Properties.Resources.gameover;
            this.gameOverBox.Location = new System.Drawing.Point(149, 210);
            this.gameOverBox.Name = "gameOverBox";
            this.gameOverBox.Size = new System.Drawing.Size(413, 82);
            this.gameOverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameOverBox.TabIndex = 16;
            this.gameOverBox.TabStop = false;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.startLabel.Location = new System.Drawing.Point(148, 350);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(169, 76);
            this.startLabel.TabIndex = 17;
            this.startLabel.Text = "Start";
            this.startLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background_day;
            this.ClientSize = new System.Drawing.Size(700, 597);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.gameOverBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom3);
            this.Controls.Add(this.pipeTop3);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeBottom1);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.bird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeBottom1;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeBottom3;
        private System.Windows.Forms.PictureBox pipeTop3;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox gameOverBox;
        private System.Windows.Forms.Label startLabel;
    }
}

