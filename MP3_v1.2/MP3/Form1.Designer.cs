namespace MP3
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
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MP3TrackBar = new System.Windows.Forms.TrackBar();
            this.MP3Timer = new System.Windows.Forms.Timer(this.components);
            this.LB_MusicTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MP3TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(61, 118);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(25, 25);
            this.Play.TabIndex = 1;
            this.Play.Text = "▶";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(122, 118);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(25, 25);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "ll";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(181, 118);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(25, 25);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "■";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(250, 120);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 5;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(250, 154);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 6;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Play       Pause       Stop";
            // 
            // MP3TrackBar
            // 
            this.MP3TrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MP3TrackBar.Location = new System.Drawing.Point(49, 56);
            this.MP3TrackBar.Maximum = 999999;
            this.MP3TrackBar.Name = "MP3TrackBar";
            this.MP3TrackBar.Size = new System.Drawing.Size(285, 45);
            this.MP3TrackBar.TabIndex = 8;
            this.MP3TrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MP3TrackBar_MouseDown);
            this.MP3TrackBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MP3TrackBar_MouseMove);
            this.MP3TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MP3TrackBar_MouseUp);
            // 
            // MP3Timer
            // 
            this.MP3Timer.Interval = 20;
            this.MP3Timer.Tick += new System.EventHandler(this.MP3Timer_Tick);
            // 
            // LB_MusicTimer
            // 
            this.LB_MusicTimer.Location = new System.Drawing.Point(225, 30);
            this.LB_MusicTimer.Name = "LB_MusicTimer";
            this.LB_MusicTimer.Size = new System.Drawing.Size(100, 23);
            this.LB_MusicTimer.TabIndex = 10;
            this.LB_MusicTimer.Text = "00:00";
            this.LB_MusicTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(380, 241);
            this.Controls.Add(this.LB_MusicTimer);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.MP3TrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Name = "Form1";
            this.Text = "MP3 Player";
            ((System.ComponentModel.ISupportInitialize)(this.MP3TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar MP3TrackBar;
        private System.Windows.Forms.Timer MP3Timer;
        private System.Windows.Forms.Label LB_MusicTimer;
    }
}

