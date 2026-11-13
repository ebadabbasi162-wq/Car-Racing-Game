namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            roadPanel = new Panel();
            enemyCar3 = new PictureBox();
            enemyCar2 = new PictureBox();
            enemyCar = new PictureBox();
            playerCar = new PictureBox();
            btnRestart = new Button();
            lblScore = new Label();
            btnPause = new Button();
            roadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enemyCar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyCar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCar).BeginInit();
            SuspendLayout();
            // 
            // roadPanel
            // 
            roadPanel.BackColor = Color.DimGray;
            roadPanel.BorderStyle = BorderStyle.FixedSingle;
            roadPanel.Controls.Add(enemyCar3);
            roadPanel.Controls.Add(enemyCar2);
            roadPanel.Controls.Add(enemyCar);
            roadPanel.Controls.Add(playerCar);
            roadPanel.Location = new Point(90, 20);
            roadPanel.Name = "roadPanel";
            roadPanel.Size = new Size(300, 650);
            roadPanel.TabIndex = 0;
            roadPanel.Paint += roadPanel_Paint;
            // 
            // enemyCar3
            // 
            enemyCar3.BackColor = Color.Transparent;
            enemyCar3.Image = (Image)resources.GetObject("enemyCar3.Image");
            enemyCar3.Location = new Point(1, -150);
            enemyCar3.Name = "enemyCar3";
            enemyCar3.Size = new Size(80, 110);
            enemyCar3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyCar3.TabIndex = 3;
            enemyCar3.TabStop = false;
            // 
            // enemyCar2
            // 
            enemyCar2.BackColor = Color.Transparent;
            enemyCar2.Image = (Image)resources.GetObject("enemyCar2.Image");
            enemyCar2.Location = new Point(219, -1);
            enemyCar2.Name = "enemyCar2";
            enemyCar2.Size = new Size(80, 110);
            enemyCar2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyCar2.TabIndex = 2;
            enemyCar2.TabStop = false;
            // 
            // enemyCar
            // 
            enemyCar.BackColor = Color.Transparent;
            enemyCar.Image = (Image)resources.GetObject("enemyCar.Image");
            enemyCar.Location = new Point(111, -1);
            enemyCar.Name = "enemyCar";
            enemyCar.Size = new Size(80, 110);
            enemyCar.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyCar.TabIndex = 1;
            enemyCar.TabStop = false;
            // 
            // playerCar
            // 
            playerCar.BackColor = Color.Transparent;
            playerCar.Image = CarRacingGame.Properties.Resources.Audi_removebg_preview;
            playerCar.Location = new Point(111, 539);
            playerCar.Name = "playerCar";
            playerCar.Size = new Size(80, 110);
            playerCar.SizeMode = PictureBoxSizeMode.StretchImage;
            playerCar.TabIndex = 0;
            playerCar.TabStop = false;
            playerCar.Click += playerCar_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.LightGreen;
            btnRestart.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(90, 676);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(106, 40);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "RESTART";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(396, 41);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(112, 32);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score : 0";
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.Cyan;
            btnPause.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPause.Location = new Point(202, 678);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(106, 40);
            btnPause.TabIndex = 3;
            btnPause.Text = "PAUSE";
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 794);
            Controls.Add(btnPause);
            Controls.Add(lblScore);
            Controls.Add(btnRestart);
            Controls.Add(roadPanel);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Racing Game";
            KeyDown += Form1_KeyDown;
            roadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)enemyCar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyCar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel roadPanel;
        private PictureBox playerCar;
        private PictureBox enemyCar;
        private Button btnRestart;
        private PictureBox enemyCar2;
        private Label lblScore;
        private PictureBox enemyCar3;
        private Button btnPause;
    }
}
