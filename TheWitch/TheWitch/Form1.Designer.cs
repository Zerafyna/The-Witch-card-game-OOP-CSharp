namespace TheWitch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreLabel = new System.Windows.Forms.Label();
            this.grpGameOver = new System.Windows.Forms.GroupBox();
            this.lblLooser = new System.Windows.Forms.Label();
            this.picPlayAgain = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picPair = new System.Windows.Forms.PictureBox();
            this.picCard = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblTurnLabel = new System.Windows.Forms.Label();
            this.grpGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Pattaya", 14F);
            this.lblPlayer1.ForeColor = System.Drawing.Color.Snow;
            this.lblPlayer1.Location = new System.Drawing.Point(21, 171);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(59, 26);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Vlada";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Pattaya", 14F);
            this.lblPlayer2.ForeColor = System.Drawing.Color.Snow;
            this.lblPlayer2.Location = new System.Drawing.Point(21, 556);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(50, 26);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "Erica";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(175, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 167);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(175, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 167);
            this.panel1.TabIndex = 5;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("PT Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(25, 375);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(118, 22);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "Vlada 0/0 Erica";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreLabel
            // 
            this.lblScoreLabel.AutoSize = true;
            this.lblScoreLabel.Font = new System.Drawing.Font("Noto Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLabel.ForeColor = System.Drawing.Color.White;
            this.lblScoreLabel.Location = new System.Drawing.Point(52, 350);
            this.lblScoreLabel.Name = "lblScoreLabel";
            this.lblScoreLabel.Size = new System.Drawing.Size(57, 23);
            this.lblScoreLabel.TabIndex = 14;
            this.lblScoreLabel.Text = "Score";
            this.lblScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpGameOver
            // 
            this.grpGameOver.Controls.Add(this.lblLooser);
            this.grpGameOver.Controls.Add(this.picPlayAgain);
            this.grpGameOver.Location = new System.Drawing.Point(175, 30);
            this.grpGameOver.Margin = new System.Windows.Forms.Padding(0);
            this.grpGameOver.Name = "grpGameOver";
            this.grpGameOver.Size = new System.Drawing.Size(1146, 693);
            this.grpGameOver.TabIndex = 0;
            this.grpGameOver.TabStop = false;
            // 
            // lblLooser
            // 
            this.lblLooser.AutoSize = true;
            this.lblLooser.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLooser.ForeColor = System.Drawing.Color.White;
            this.lblLooser.Location = new System.Drawing.Point(350, 224);
            this.lblLooser.Name = "lblLooser";
            this.lblLooser.Size = new System.Drawing.Size(414, 50);
            this.lblLooser.TabIndex = 16;
            this.lblLooser.Text = "Vlada is The Witch!";
            // 
            // picPlayAgain
            // 
            this.picPlayAgain.Image = global::TheWitch.Properties.Resources.playGameAgain;
            this.picPlayAgain.Location = new System.Drawing.Point(295, 313);
            this.picPlayAgain.Name = "picPlayAgain";
            this.picPlayAgain.Size = new System.Drawing.Size(505, 120);
            this.picPlayAgain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayAgain.TabIndex = 15;
            this.picPlayAgain.TabStop = false;
            this.picPlayAgain.Click += new System.EventHandler(this.picPlayAgain_Click);
            // 
            // picPlay
            // 
            this.picPlay.Image = global::TheWitch.Properties.Resources.startTheGame;
            this.picPlay.Location = new System.Drawing.Point(404, 317);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(505, 120);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlay.TabIndex = 12;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // picPair
            // 
            this.picPair.Location = new System.Drawing.Point(682, 298);
            this.picPair.Name = "picPair";
            this.picPair.Size = new System.Drawing.Size(107, 165);
            this.picPair.TabIndex = 10;
            this.picPair.TabStop = false;
            // 
            // picCard
            // 
            this.picCard.Location = new System.Drawing.Point(540, 298);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(107, 165);
            this.picCard.TabIndex = 9;
            this.picCard.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("picPlayer2.Image")));
            this.picPlayer2.Location = new System.Drawing.Point(25, 603);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(120, 120);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer2.TabIndex = 8;
            this.picPlayer2.TabStop = false;
            // 
            // picPlayer1
            // 
            this.picPlayer1.Image = ((System.Drawing.Image)(resources.GetObject("picPlayer1.Image")));
            this.picPlayer1.Location = new System.Drawing.Point(25, 30);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(120, 120);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer1.TabIndex = 7;
            this.picPlayer1.TabStop = false;
            // 
            // lblTurnLabel
            // 
            this.lblTurnLabel.AutoSize = true;
            this.lblTurnLabel.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnLabel.ForeColor = System.Drawing.Color.White;
            this.lblTurnLabel.Location = new System.Drawing.Point(531, 352);
            this.lblTurnLabel.Name = "lblTurnLabel";
            this.lblTurnLabel.Size = new System.Drawing.Size(277, 50);
            this.lblTurnLabel.TabIndex = 17;
            this.lblTurnLabel.Text = "Vlada\'s Turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1333, 757);
            this.Controls.Add(this.grpGameOver);
            this.Controls.Add(this.lblTurnLabel);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.lblScoreLabel);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picPair);
            this.Controls.Add(this.picCard);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Witch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGameOver.ResumeLayout(false);
            this.grpGameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.PictureBox picPair;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreLabel;
        private System.Windows.Forms.GroupBox grpGameOver;
        private System.Windows.Forms.PictureBox picPlayAgain;
        private System.Windows.Forms.Label lblLooser;
        private System.Windows.Forms.Label lblTurnLabel;
    }
}

