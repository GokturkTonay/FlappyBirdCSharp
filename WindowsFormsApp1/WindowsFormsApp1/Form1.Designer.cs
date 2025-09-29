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
            this.bird = new DevExpress.XtraEditors.PictureEdit();
            this.pipeTop1 = new DevExpress.XtraEditors.PictureEdit();
            this.pipeBottom1 = new DevExpress.XtraEditors.PictureEdit();
            this.pipeTop2 = new DevExpress.XtraEditors.PictureEdit();
            this.pipeBottom2 = new DevExpress.XtraEditors.PictureEdit();
            this.pipeTop3 = new DevExpress.XtraEditors.PictureEdit();
            this.pipeBottom3 = new DevExpress.XtraEditors.PictureEdit();
            this.gameOverBox = new DevExpress.XtraEditors.PictureEdit();
            this.scoreLabel = new DevExpress.XtraEditors.LabelControl();
            this.startLabel = new DevExpress.XtraEditors.LabelControl();
            this.ground = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bird.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            // 
            // bird
            // 
            this.bird.EditValue = global::WindowsFormsApp1.Properties.Resources.yellowbird_midflap;
            this.bird.Location = new System.Drawing.Point(43, 190);
            this.bird.Name = "bird";
            this.bird.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bird.Properties.Appearance.Options.UseBackColor = true;
            this.bird.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bird.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.bird.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.bird.Size = new System.Drawing.Size(53, 38);
            this.bird.TabIndex = 18;
            // 
            // pipeTop1
            // 
            this.pipeTop1.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeTop1.Location = new System.Drawing.Point(231, -319);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop1.Properties.Appearance.Options.UseBackColor = true;
            this.pipeTop1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeTop1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeTop1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeTop1.Size = new System.Drawing.Size(68, 502);
            this.pipeTop1.TabIndex = 19;
            // 
            // pipeBottom1
            // 
            this.pipeBottom1.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeBottom1.Location = new System.Drawing.Point(231, 317);
            this.pipeBottom1.Name = "pipeBottom1";
            this.pipeBottom1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom1.Properties.Appearance.Options.UseBackColor = true;
            this.pipeBottom1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeBottom1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeBottom1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeBottom1.Size = new System.Drawing.Size(68, 502);
            this.pipeBottom1.TabIndex = 20;
            // 
            // pipeTop2
            // 
            this.pipeTop2.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeTop2.Location = new System.Drawing.Point(482, -319);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop2.Properties.Appearance.Options.UseBackColor = true;
            this.pipeTop2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeTop2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeTop2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeTop2.Size = new System.Drawing.Size(68, 502);
            this.pipeTop2.TabIndex = 21;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeBottom2.Location = new System.Drawing.Point(482, 317);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom2.Properties.Appearance.Options.UseBackColor = true;
            this.pipeBottom2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeBottom2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeBottom2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeBottom2.Size = new System.Drawing.Size(68, 502);
            this.pipeBottom2.TabIndex = 22;
            // 
            // pipeTop3
            // 
            this.pipeTop3.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeTop3.Location = new System.Drawing.Point(625, -319);
            this.pipeTop3.Name = "pipeTop3";
            this.pipeTop3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop3.Properties.Appearance.Options.UseBackColor = true;
            this.pipeTop3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeTop3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeTop3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeTop3.Size = new System.Drawing.Size(68, 502);
            this.pipeTop3.TabIndex = 23;
            // 
            // pipeBottom3
            // 
            this.pipeBottom3.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeBottom3.Location = new System.Drawing.Point(625, 317);
            this.pipeBottom3.Name = "pipeBottom3";
            this.pipeBottom3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom3.Properties.Appearance.Options.UseBackColor = true;
            this.pipeBottom3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeBottom3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeBottom3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeBottom3.Size = new System.Drawing.Size(68, 502);
            this.pipeBottom3.TabIndex = 24;
            // 
            // gameOverBox
            // 
            this.gameOverBox.EditValue = global::WindowsFormsApp1.Properties.Resources.gameover;
            this.gameOverBox.Location = new System.Drawing.Point(161, 215);
            this.gameOverBox.Name = "gameOverBox";
            this.gameOverBox.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gameOverBox.Properties.Appearance.Options.UseBackColor = true;
            this.gameOverBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gameOverBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.gameOverBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.gameOverBox.Size = new System.Drawing.Size(413, 81);
            this.gameOverBox.TabIndex = 25;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Appearance.Font = new System.Drawing.Font("Microsoft PhagsPa", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Appearance.Options.UseFont = true;
            this.scoreLabel.Location = new System.Drawing.Point(291, 37);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(138, 49);
            this.scoreLabel.TabIndex = 26;
            this.scoreLabel.Text = "Score: 0";
            // 
            // startLabel
            // 
            this.startLabel.Appearance.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Appearance.Options.UseFont = true;
            this.startLabel.Location = new System.Drawing.Point(163, 363);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(136, 76);
            this.startLabel.TabIndex = 27;
            this.startLabel.Text = "Start";
            this.startLabel.Click += new System.EventHandler(this.startLabel_Click);
            // 
            // ground
            // 
            this.ground.EditValue = global::WindowsFormsApp1.Properties.Resources._base;
            this.ground.Location = new System.Drawing.Point(-3, 492);
            this.ground.Name = "ground";
            this.ground.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ground.Properties.Appearance.Options.UseBackColor = true;
            this.ground.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ground.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ground.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ground.Size = new System.Drawing.Size(712, 163);
            this.ground.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background_day;
            this.ClientSize = new System.Drawing.Size(700, 597);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameOverBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.bird.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private DevExpress.XtraEditors.PictureEdit bird;
        private DevExpress.XtraEditors.PictureEdit pipeTop1;
        private DevExpress.XtraEditors.PictureEdit pipeBottom1;
        private DevExpress.XtraEditors.PictureEdit pipeTop2;
        private DevExpress.XtraEditors.PictureEdit pipeBottom2;
        private DevExpress.XtraEditors.PictureEdit pipeTop3;
        private DevExpress.XtraEditors.PictureEdit pipeBottom3;
        private DevExpress.XtraEditors.PictureEdit gameOverBox;
        private DevExpress.XtraEditors.LabelControl scoreLabel;
        private DevExpress.XtraEditors.LabelControl startLabel;
        private DevExpress.XtraEditors.PictureEdit ground;
    }
}

