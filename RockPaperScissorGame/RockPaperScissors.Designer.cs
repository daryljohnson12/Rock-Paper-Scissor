namespace RockPaperScissorGame
{
    partial class RockPaperScissors
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerPickTextBox = new System.Windows.Forms.TextBox();
            this.computerLabel = new System.Windows.Forms.Label();
            this.computerTextBox = new System.Windows.Forms.TextBox();
            this.winnerTextBox = new System.Windows.Forms.TextBox();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.pickLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.playerScoreTextBox = new System.Windows.Forms.TextBox();
            this.computerScoreTextBox = new System.Windows.Forms.TextBox();
            this.rockPictureBox = new System.Windows.Forms.PictureBox();
            this.paperPictureBox = new System.Windows.Forms.PictureBox();
            this.scissorPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(54, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(121, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Please enter your name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(289, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(54, 108);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(76, 13);
            this.playerLabel.TabIndex = 5;
            this.playerLabel.Text = "Players choice";
            // 
            // playerPickTextBox
            // 
            this.playerPickTextBox.Location = new System.Drawing.Point(289, 101);
            this.playerPickTextBox.Name = "playerPickTextBox";
            this.playerPickTextBox.ReadOnly = true;
            this.playerPickTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerPickTextBox.TabIndex = 6;
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Location = new System.Drawing.Point(59, 173);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(108, 13);
            this.computerLabel.TabIndex = 7;
            this.computerLabel.Text = "The computer choice";
            // 
            // computerTextBox
            // 
            this.computerTextBox.Location = new System.Drawing.Point(289, 166);
            this.computerTextBox.Name = "computerTextBox";
            this.computerTextBox.ReadOnly = true;
            this.computerTextBox.Size = new System.Drawing.Size(100, 20);
            this.computerTextBox.TabIndex = 8;
            // 
            // winnerTextBox
            // 
            this.winnerTextBox.Location = new System.Drawing.Point(161, 228);
            this.winnerTextBox.Name = "winnerTextBox";
            this.winnerTextBox.Size = new System.Drawing.Size(228, 20);
            this.winnerTextBox.TabIndex = 9;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(59, 231);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(45, 13);
            this.winnerLabel.TabIndex = 10;
            this.winnerLabel.Text = "Results ";
            // 
            // pickLabel
            // 
            this.pickLabel.AutoSize = true;
            this.pickLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickLabel.Location = new System.Drawing.Point(469, 24);
            this.pickLabel.Name = "pickLabel";
            this.pickLabel.Size = new System.Drawing.Size(273, 22);
            this.pickLabel.TabIndex = 14;
            this.pickLabel.Text = "Please click Rock Paper or Scissor";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(197, 297);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "&Clear";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(385, 297);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Location = new System.Drawing.Point(97, 384);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(70, 13);
            this.playerScoreLabel.TabIndex = 19;
            this.playerScoreLabel.Text = "Player Score:";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.Location = new System.Drawing.Point(357, 381);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(86, 13);
            this.computerScoreLabel.TabIndex = 20;
            this.computerScoreLabel.Text = "Computer Score:";
            // 
            // playerScoreTextBox
            // 
            this.playerScoreTextBox.Location = new System.Drawing.Point(197, 377);
            this.playerScoreTextBox.Name = "playerScoreTextBox";
            this.playerScoreTextBox.ReadOnly = true;
            this.playerScoreTextBox.Size = new System.Drawing.Size(110, 20);
            this.playerScoreTextBox.TabIndex = 21;
            // 
            // computerScoreTextBox
            // 
            this.computerScoreTextBox.Location = new System.Drawing.Point(473, 377);
            this.computerScoreTextBox.Name = "computerScoreTextBox";
            this.computerScoreTextBox.ReadOnly = true;
            this.computerScoreTextBox.Size = new System.Drawing.Size(111, 20);
            this.computerScoreTextBox.TabIndex = 22;
            // 
            // rockPictureBox
            // 
            this.rockPictureBox.Image = global::RockPaperScissorGame.Properties.Resources.rock1;
            this.rockPictureBox.Location = new System.Drawing.Point(570, 67);
            this.rockPictureBox.Name = "rockPictureBox";
            this.rockPictureBox.Size = new System.Drawing.Size(64, 64);
            this.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rockPictureBox.TabIndex = 23;
            this.rockPictureBox.TabStop = false;
            this.rockPictureBox.Click += new System.EventHandler(this.rockPictureBox_Click);
            // 
            // paperPictureBox
            // 
            this.paperPictureBox.Image = global::RockPaperScissorGame.Properties.Resources.paper;
            this.paperPictureBox.Location = new System.Drawing.Point(570, 155);
            this.paperPictureBox.Name = "paperPictureBox";
            this.paperPictureBox.Size = new System.Drawing.Size(64, 64);
            this.paperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paperPictureBox.TabIndex = 24;
            this.paperPictureBox.TabStop = false;
            this.paperPictureBox.Click += new System.EventHandler(this.paperPictureBox_Click);
            // 
            // scissorPictureBox
            // 
            this.scissorPictureBox.Image = global::RockPaperScissorGame.Properties.Resources.scissors;
            this.scissorPictureBox.Location = new System.Drawing.Point(570, 242);
            this.scissorPictureBox.Name = "scissorPictureBox";
            this.scissorPictureBox.Size = new System.Drawing.Size(64, 64);
            this.scissorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.scissorPictureBox.TabIndex = 25;
            this.scissorPictureBox.TabStop = false;
            this.scissorPictureBox.Click += new System.EventHandler(this.scissorPictureBox_Click);
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scissorPictureBox);
            this.Controls.Add(this.paperPictureBox);
            this.Controls.Add(this.rockPictureBox);
            this.Controls.Add(this.computerScoreTextBox);
            this.Controls.Add(this.playerScoreTextBox);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pickLabel);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.winnerTextBox);
            this.Controls.Add(this.computerTextBox);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.playerPickTextBox);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "RockPaperScissors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock, Paper, Scissor Game";
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.TextBox playerPickTextBox;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.TextBox computerTextBox;
        private System.Windows.Forms.TextBox winnerTextBox;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label pickLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.TextBox playerScoreTextBox;
        private System.Windows.Forms.TextBox computerScoreTextBox;
        private System.Windows.Forms.PictureBox rockPictureBox;
        private System.Windows.Forms.PictureBox paperPictureBox;
        private System.Windows.Forms.PictureBox scissorPictureBox;
    }
}

