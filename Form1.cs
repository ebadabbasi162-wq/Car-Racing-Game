

using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer gameTimer;

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;

            gameTimer = new System.Windows.Forms.Timer();

            gameTimer.Interval = 50;

            gameTimer.Tick += GameTimer_Tick;

            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            enemyCar.Top += 5;
            

            // Collision with first enemy
            if (playerCar.Bounds.IntersectsWith(enemyCar.Bounds))
            {
                gameTimer.Stop();

                MessageBox.Show("GAME OVER! You crashed.");

                return;
            }

            // Collision with second enemy
           

            // Reset first enemy
            if (enemyCar.Top > roadPanel.Height)
            {
                enemyCar.Top = -enemyCar.Height;
            }

            // Reset second enemy
           
        }

        private void roadPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen roadLine = new Pen(Color.White, 5);

            roadLine.DashStyle = DashStyle.Dash;

            e.Graphics.DrawLine(roadLine, 100, 0, 100, 650);

            e.Graphics.DrawLine(roadLine, 200, 0, 200, 650);

            roadLine.Dispose();
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
                {
                    playerCar.Left -= 20;
                }

                return true;
            }

            if (keyData == Keys.Right)
            {
                if (playerCar.Right + 20 <= roadPanel.ClientSize.Width - 5)
                {
                    playerCar.Left += 20;
                }

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            enemyCar.Top = 20;

           

            playerCar.Left = 130;

            gameTimer.Start();

            this.Focus();
        }
    }
}

