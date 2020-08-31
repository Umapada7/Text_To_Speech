namespace Text_To_Speech
{
    partial class textToSpeech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textToSpeech));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.volume = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.listen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Thistle;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(30, 155);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(680, 445);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volumeBar.Location = new System.Drawing.Point(890, 194);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBar.Size = new System.Drawing.Size(56, 300);
            this.volumeBar.TabIndex = 3;
            this.volumeBar.Value = 50;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.BackColor = System.Drawing.Color.LightGray;
            this.volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume.Location = new System.Drawing.Point(952, 325);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(36, 25);
            this.volume.TabIndex = 4;
            this.volume.Text = "50";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Text_To_Speech.Properties.Resources.Media_Controls_Volume_Up_icon;
            this.pictureBox1.Location = new System.Drawing.Point(899, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Image = global::Text_To_Speech.Properties.Resources.home_icon__1_;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(-2, 1);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(115, 55);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.DarkTurquoise;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Image = global::Text_To_Speech.Properties.Resources.Style_Stop_icon;
            this.stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stop.Location = new System.Drawing.Point(824, 628);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(111, 42);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.button4_Click);
            // 
            // resume
            // 
            this.resume.BackColor = System.Drawing.Color.DarkTurquoise;
            this.resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resume.Image = global::Text_To_Speech.Properties.Resources.LHS_resume_icon;
            this.resume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resume.Location = new System.Drawing.Point(523, 628);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(142, 42);
            this.resume.TabIndex = 2;
            this.resume.Text = "Resume";
            this.resume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resume.UseVisualStyleBackColor = false;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.Image = global::Text_To_Speech.Properties.Resources.Pause_icon;
            this.pause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pause.Location = new System.Drawing.Point(255, 628);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(122, 42);
            this.pause.TabIndex = 2;
            this.pause.Text = "Pause";
            this.pause.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // listen
            // 
            this.listen.BackColor = System.Drawing.Color.DarkTurquoise;
            this.listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listen.ForeColor = System.Drawing.Color.Black;
            this.listen.Image = ((System.Drawing.Image)(resources.GetObject("listen.Image")));
            this.listen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listen.Location = new System.Drawing.Point(30, 628);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(114, 42);
            this.listen.TabIndex = 2;
            this.listen.Text = "Play";
            this.listen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listen.UseVisualStyleBackColor = false;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Brown;
            this.textBox1.Location = new System.Drawing.Point(30, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 41);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Enter Your Text Below";
            // 
            // textToSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImage = global::Text_To_Speech.Properties.Resources._257_2579365_high_resolution_purple_gradient_background;
            this.ClientSize = new System.Drawing.Size(1072, 808);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.listen);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "textToSpeech";
            this.Text = "Text To Speech";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

