namespace Snake_2D
{
    partial class frmSnake
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
            btnStart = new Button();
            btnScrnSave = new Button();
            lblScore = new Label();
            lblHighScore = new Label();
            picCanvas = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Chartreuse;
            btnStart.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(636, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 44);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += StartGame;
            // 
            // btnScrnSave
            // 
            btnScrnSave.BackColor = Color.FromArgb(128, 255, 255);
            btnScrnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScrnSave.Location = new Point(636, 62);
            btnScrnSave.Name = "btnScrnSave";
            btnScrnSave.Size = new Size(100, 44);
            btnScrnSave.TabIndex = 1;
            btnScrnSave.Text = "Share Score";
            btnScrnSave.UseVisualStyleBackColor = false;
            btnScrnSave.Click += TakeScrnShot;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(636, 109);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(63, 20);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score: 0";
            // 
            // lblHighScore
            // 
            lblHighScore.AutoSize = true;
            lblHighScore.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHighScore.Location = new Point(636, 153);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(100, 20);
            lblHighScore.TabIndex = 3;
            lblHighScore.Text = "High Score: 0";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.FromArgb(0, 64, 64);
            picCanvas.Location = new Point(12, 12);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(580, 680);
            picCanvas.TabIndex = 4;
            picCanvas.TabStop = false;
            picCanvas.Paint += UpdatePictureBoxDisplay;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 40;
            gameTimer.Tick += GameTimerEvent;
            // 
            // frmSnake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 725);
            Controls.Add(picCanvas);
            Controls.Add(lblHighScore);
            Controls.Add(lblScore);
            Controls.Add(btnScrnSave);
            Controls.Add(btnStart);
            Name = "frmSnake";
            Text = " Snake 2D - TNL";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnScrnSave;
        private Label lblScore;
        private Label lblHighScore;
        private PictureBox picCanvas;
        private System.Windows.Forms.Timer gameTimer;
    }
}
