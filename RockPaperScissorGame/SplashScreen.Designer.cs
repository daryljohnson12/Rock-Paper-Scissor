namespace RockPaperScissorGame
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.scissorPictureBox = new System.Windows.Forms.PictureBox();
            this.paperPictureBox = new System.Windows.Forms.PictureBox();
            this.rockPictureBox = new System.Windows.Forms.PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scissorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splashTimer
            // 
            this.splashTimer.Enabled = true;
            this.splashTimer.Interval = 5000;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(106, 88);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(598, 76);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Rock, Paper, Scissor Game";
            // 
            // scissorPictureBox
            // 
            this.scissorPictureBox.Image = global::RockPaperScissorGame.Properties.Resources.scissors;
            this.scissorPictureBox.Location = new System.Drawing.Point(460, 181);
            this.scissorPictureBox.Name = "scissorPictureBox";
            this.scissorPictureBox.Size = new System.Drawing.Size(64, 64);
            this.scissorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scissorPictureBox.TabIndex = 2;
            this.scissorPictureBox.TabStop = false;
            // 
            // paperPictureBox
            // 
            this.paperPictureBox.Image = global::RockPaperScissorGame.Properties.Resources.paper;
            this.paperPictureBox.Location = new System.Drawing.Point(363, 181);
            this.paperPictureBox.Name = "paperPictureBox";
            this.paperPictureBox.Size = new System.Drawing.Size(64, 64);
            this.paperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paperPictureBox.TabIndex = 1;
            this.paperPictureBox.TabStop = false;
            // 
            // rockPictureBox
            // 
            this.rockPictureBox.Image = global::RockPaperScissorGame.Properties.Resources.rock1;
            this.rockPictureBox.Location = new System.Drawing.Point(263, 181);
            this.rockPictureBox.Name = "rockPictureBox";
            this.rockPictureBox.Size = new System.Drawing.Size(64, 64);
            this.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rockPictureBox.TabIndex = 0;
            this.rockPictureBox.TabStop = false;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(332, 339);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(130, 20);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "by Daryl Johnson";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.scissorPictureBox);
            this.Controls.Add(this.paperPictureBox);
            this.Controls.Add(this.rockPictureBox);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.scissorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer splashTimer;
        private System.Windows.Forms.PictureBox rockPictureBox;
        private System.Windows.Forms.PictureBox paperPictureBox;
        private System.Windows.Forms.PictureBox scissorPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
    }
}