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
            roadPanel = new Panel();
            enemyCar = new PictureBox();
            playerCar = new PictureBox();
            btnRestart = new Button();
            
            roadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enemyCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCar).BeginInit();
            
            SuspendLayout();
            // 
            // roadPanel
            // 
            roadPanel.BackColor = Color.DimGray;
            roadPanel.BorderStyle = BorderStyle.FixedSingle;
           
            roadPanel.Controls.Add(enemyCar);
            roadPanel.Controls.Add(playerCar);
            roadPanel.Location = new Point(90, 20);
            roadPanel.Name = "roadPanel";
            roadPanel.Size = new Size(300, 650);
            roadPanel.TabIndex = 0;
            roadPanel.Paint += roadPanel_Paint;
            // 
            // enemyCar
            // 
            enemyCar.BackColor = Color.Blue;
            enemyCar.Location = new Point(130, 20);
            enemyCar.Name = "enemyCar";
            enemyCar.Size = new Size(40, 70);
            enemyCar.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyCar.TabIndex = 1;
            enemyCar.TabStop = false;
            // 
            // playerCar
            // 
            playerCar.BackColor = Color.Red;
            playerCar.Location = new Point(130, 560);
            playerCar.Name = "playerCar";
            playerCar.Size = new Size(40, 70);
            playerCar.SizeMode = PictureBoxSizeMode.StretchImage;
            playerCar.TabIndex = 0;
            playerCar.TabStop = false;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.LightGreen;
            btnRestart.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(190, 690);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(100, 40);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "RESTART";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 794);
            Controls.Add(btnRestart);
            Controls.Add(roadPanel);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Racing Game";
            KeyDown += Form1_KeyDown;
            roadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)enemyCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCar).EndInit();
            
            ResumeLayout(false);
        }

        #endregion

        private Panel roadPanel;
        private PictureBox playerCar;
        private PictureBox enemyCar;
        private Button btnRestart;
       
    }
}
