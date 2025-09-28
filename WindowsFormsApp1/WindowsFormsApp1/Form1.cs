using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int gravity = 2;         // Kuşun düşme hızı
        int jumpForce = -15;      // Space basınca yukarı hareket
        int pipeSpeed = 8;       // Boruların hızı
        int score = 0;
        int birdSpeed = 0;     // Kuşun anlık hızı
        int maxFallSpeed = 6;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            gameTimer.Stop(); // oyun başlamasın
            startLabel.Visible = true; // start yazısı görünsün

            gameOverBox.BackColor = Color.Transparent;
            bird.BackColor = Color.Transparent;
            pipeTop1.BackColor = Color.Transparent;
            pipeBottom1.BackColor = Color.Transparent;
            pipeTop2.BackColor = Color.Transparent;
            pipeBottom2.BackColor = Color.Transparent;
            pipeTop3.BackColor = Color.Transparent;
            pipeBottom3.BackColor = Color.Transparent;
            scoreLabel.BackColor = Color.Transparent;

            gameOverBox.Visible = false;

            gameTimer.Tick += GameTimerEvent;
            this.KeyDown += KeyIsDown;
            this.KeyUp += KeyIsUp;

            // pipeTop'u ters çevir
            pipeTop1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pipeTop2.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pipeTop3.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            // Boruların başlangıç konumu
            ResetPipes(pipeTop1, pipeBottom1);
            ResetPipes(pipeTop2, pipeBottom2);
            ResetPipes(pipeTop3, pipeBottom3);

            // İkinci boru setini biraz daha ileriye kaydır
            pipeTop2.Left += 230;
            pipeBottom2.Left += 230;

            pipeTop3.Left += 450;
            pipeBottom3.Left += 450;

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // Kuşu aşağı doğru hareket ettir
            birdSpeed += gravity;

            // Maksimum düşme hızını aşma
            if (birdSpeed > maxFallSpeed)
                birdSpeed = maxFallSpeed;

            // Kuşun konumunu anlık hızına göre değiştir
            bird.Top += birdSpeed;

            // Boruları sola kaydır
            pipeBottom1.Left -= pipeSpeed;
            pipeTop1.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;
            pipeBottom3.Left -= pipeSpeed;
            pipeTop3.Left -= pipeSpeed;

            // Eğer borular ekran dışına çıkarsa tekrar sağdan getir
            if (pipeBottom1.Left < -pipeBottom1.Width)
            {
                ResetPipes(pipeTop1, pipeBottom1);
                score++;
                scoreLabel.Text = "Score: " + score;
            }

            if (pipeTop2.Left < -pipeTop2.Width)
            {
                ResetPipes(pipeTop2, pipeBottom2);
                score++;
                scoreLabel.Text = "Score: " + score;
            }

            if (pipeTop3.Left < -pipeTop3.Width)
            {
                ResetPipes(pipeTop3, pipeBottom3);
                score++;
                scoreLabel.Text = "Score: " + score;
            }

            // Çarpışma kontrolü
            if (bird.Bounds.IntersectsWith(pipeBottom1.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTop1.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -25)
            {
                EndGame();
            }
        }

        private void ResetGame()
        {
            gameTimer.Stop();

            score = 0;
            scoreLabel.Text = "Score: " + score;

            bird.Top = this.ClientSize.Height / 2;

            ResetPipes(pipeTop1, pipeBottom1);
            ResetPipes(pipeTop2, pipeBottom2);
            ResetPipes(pipeTop3, pipeBottom3);

            pipeTop2.Left += 230;
            pipeBottom2.Left += 230;
            pipeTop3.Left += 450;
            pipeBottom3.Left += 450;

            gameOverBox.Visible = false;
            startLabel.Visible = false;

            gameTimer.Start();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                birdSpeed = jumpForce; // Space basıldığında yukarı çıkar
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // Space bırakıldığında tekrar düşer
            }
        }

        private void ResetPipes(PictureBox topPipe, PictureBox bottomPipe)
        {
            int gap = 150; // Üst ve alt boru arası boşluk
            int minY = 4;
            int maxY = this.ClientSize.Height - ground.Height - gap - 10;

            int pipeTopY = rand.Next(minY, maxY);

            topPipe.Top = pipeTopY - topPipe.Height;
            bottomPipe.Top = pipeTopY + gap;

            // Bu boru setini ekranın en sağından biraz daha ileri başlat
            topPipe.Left = this.ClientSize.Width + 100;
            bottomPipe.Left = this.ClientSize.Width + 100;
        }

        private void EndGame()
        {
            gameTimer.Stop();
            gameOverBox.Visible = true;
            startLabel.Visible = true; // yeniden başlatma butonu gibi görünür
            startLabel.Text = "PLAY AGAIN";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            startLabel.Visible = false; // start yazısını gizle
            ResetGame(); // oyun nesnelerini başa sar
            gameTimer.Start(); // oyun başlasın
        }
    }
}
