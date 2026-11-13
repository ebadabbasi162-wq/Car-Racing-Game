



using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer gameTimer;

        int score = 0;
        int roadLinePosition = 0;

        public Form1()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, roadPanel, new object[] { true });

            this.KeyPreview = true;

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Save previous enemy positions
            int oldEnemy1Top = enemyCar.Top;
            int oldEnemy2Top = enemyCar2.Top;
            int oldEnemy3Top = enemyCar3.Top;

            // Move enemy cars
            enemyCar.Top += 5;
            enemyCar2.Top += 7;
            enemyCar3.Top += 6;

            // Custom collision areas
            Rectangle playerHitBox = new Rectangle(
                playerCar.Left + 30,
                playerCar.Top + 18,
                playerCar.Width - 60,
                playerCar.Height - 36
            );

            Rectangle enemyHitBox1 = new Rectangle(
                enemyCar.Left + 30,
                enemyCar.Top + 18,
                enemyCar.Width - 60,
                enemyCar.Height - 36
            );

            Rectangle enemyHitBox2 = new Rectangle(
                enemyCar2.Left + 30,
                enemyCar2.Top + 18,
                enemyCar2.Width - 60,
                enemyCar2.Height - 36
            );

            Rectangle enemyHitBox3 = new Rectangle(
                enemyCar3.Left + 30,
                enemyCar3.Top + 18,
                enemyCar3.Width - 60,
                enemyCar3.Height - 36
            );

            // Check collision
            if (playerHitBox.IntersectsWith(enemyHitBox1) ||
                playerHitBox.IntersectsWith(enemyHitBox2) ||
                playerHitBox.IntersectsWith(enemyHitBox3))
            {
                // Restore previous positions
                enemyCar.Top = oldEnemy1Top;
                enemyCar2.Top = oldEnemy2Top;
                enemyCar3.Top = oldEnemy3Top;

                gameTimer.Stop();

                roadPanel.Invalidate();

                MessageBox.Show("GAME OVER!");
                return;
            }

            // Road animation
            roadLinePosition += 2;
            roadPanel.Invalidate();

            // Reset first enemy
            if (enemyCar.Top > roadPanel.Height)
            {
                enemyCar.Top = -enemyCar.Height;
                score += 10;
                lblScore.Text = "Score: " + score;
            }

            // Reset second enemy
            if (enemyCar2.Top > roadPanel.Height)
            {
                enemyCar2.Top = -200;
                score += 10;
                lblScore.Text = "Score: " + score;
            }

            // Reset third enemy
            if (enemyCar3.Top > roadPanel.Height)
            {
                enemyCar3.Top = -300;
                score += 10;
                lblScore.Text = "Score: " + score;
            }
        }

        private void roadPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Pen roadLine = new Pen(Color.White, 5))
            {
                int dashHeight = 40;
                int gap = 30;

                int offset = roadLinePosition % (dashHeight + gap);

                for (int y = offset - 70; y < roadPanel.Height; y += 70)
                {
                    e.Graphics.DrawLine(
                        roadLine, 100, y, 100, y + dashHeight);

                    e.Graphics.DrawLine(
                        roadLine, 200, y, 200, y + dashHeight);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Arrow key movement is handled by ProcessCmdKey.
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                if (playerCar.Left - 20 >= 5)
                    playerCar.Left -= 20;

                return true;
            }

            if (keyData == Keys.Up)
            {
                if (playerCar.Top - 20 >= 5)
                    playerCar.Top -= 20;

                return true;
            }

            if (keyData == Keys.Down)
            {
                if (playerCar.Bottom + 20 <= roadPanel.ClientSize.Height - 5)
                    playerCar.Top += 20;

                return true;
            }

            if (keyData == Keys.Right)
            {
                if (playerCar.Right + 20 <= roadPanel.ClientSize.Width - 5)
                    playerCar.Left += 20;

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            enemyCar.Top = 20;
            enemyCar2.Top = 200;
            enemyCar3.Top = -150;

            playerCar.Left = 130;

            score = 0;
            lblScore.Text = "Score: 0";

            gameTimer.Start();
            this.Focus();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (gameTimer.Enabled)
            {
                gameTimer.Stop();
                btnPause.Text = "RESUME";
            }
            else
            {
                gameTimer.Start();
                btnPause.Text = "PAUSE";
            }
        }

        private void enemyCar2_Click(object sender, EventArgs e)
        {
        }

        private void playerCar_Click(object sender, EventArgs e)
        {

        }
    }
}

