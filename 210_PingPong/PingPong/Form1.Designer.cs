namespace PingPong
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
            this.components = new System.ComponentModel.Container();
            this.background = new System.Windows.Forms.Panel();
            this.gameBall = new System.Windows.Forms.PictureBox();
            this.gamePanel = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.background.Controls.Add(this.gameBall);
            this.background.Controls.Add(this.gamePanel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(800, 450);
            this.background.TabIndex = 0;
            // 
            // gameBall
            // 
            this.gameBall.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameBall.Location = new System.Drawing.Point(157, 184);
            this.gameBall.Name = "gameBall";
            this.gameBall.Size = new System.Drawing.Size(30, 30);
            this.gameBall.TabIndex = 1;
            this.gameBall.TabStop = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gamePanel.Location = new System.Drawing.Point(310, 418);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(180, 20);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "PingPong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox gameBall;
        private System.Windows.Forms.PictureBox gamePanel;
        private System.Windows.Forms.Timer timer;
    }
}

