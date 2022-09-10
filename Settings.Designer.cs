namespace main
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.ButtonQuestions = new System.Windows.Forms.Button();
            this.CheckIsDeveloperMode = new System.Windows.Forms.CheckBox();
            this.TextDeveloperMode = new System.Windows.Forms.Label();
            this.CheckIsSounds = new System.Windows.Forms.CheckBox();
            this.TextSounds = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonQuestions
            // 
            this.ButtonQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(128)))));
            this.ButtonQuestions.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonQuestions.ForeColor = System.Drawing.Color.White;
            this.ButtonQuestions.Location = new System.Drawing.Point(542, 371);
            this.ButtonQuestions.Name = "ButtonQuestions";
            this.ButtonQuestions.Size = new System.Drawing.Size(140, 60);
            this.ButtonQuestions.TabIndex = 14;
            this.ButtonQuestions.Text = "Questions";
            this.ButtonQuestions.UseVisualStyleBackColor = false;
            this.ButtonQuestions.Click += new System.EventHandler(this.ButtonQuestions_Click);
            // 
            // CheckIsDeveloperMode
            // 
            this.CheckIsDeveloperMode.AutoSize = true;
            this.CheckIsDeveloperMode.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.CheckIsDeveloperMode.Location = new System.Drawing.Point(12, 200);
            this.CheckIsDeveloperMode.Name = "CheckIsDeveloperMode";
            this.CheckIsDeveloperMode.Size = new System.Drawing.Size(66, 30);
            this.CheckIsDeveloperMode.TabIndex = 13;
            this.CheckIsDeveloperMode.Text = "Off";
            this.CheckIsDeveloperMode.UseVisualStyleBackColor = true;
            this.CheckIsDeveloperMode.CheckedChanged += new System.EventHandler(this.CheckIsDeveloperMode_CheckedChanged);
            // 
            // TextDeveloperMode
            // 
            this.TextDeveloperMode.AutoSize = true;
            this.TextDeveloperMode.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.TextDeveloperMode.ForeColor = System.Drawing.Color.White;
            this.TextDeveloperMode.Location = new System.Drawing.Point(12, 149);
            this.TextDeveloperMode.Name = "TextDeveloperMode";
            this.TextDeveloperMode.Size = new System.Drawing.Size(199, 33);
            this.TextDeveloperMode.TabIndex = 12;
            this.TextDeveloperMode.Text = "Developer mode:";
            // 
            // CheckIsSounds
            // 
            this.CheckIsSounds.AutoSize = true;
            this.CheckIsSounds.Checked = true;
            this.CheckIsSounds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckIsSounds.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.CheckIsSounds.Location = new System.Drawing.Point(12, 81);
            this.CheckIsSounds.Name = "CheckIsSounds";
            this.CheckIsSounds.Size = new System.Drawing.Size(56, 30);
            this.CheckIsSounds.TabIndex = 11;
            this.CheckIsSounds.Text = "On";
            this.CheckIsSounds.UseVisualStyleBackColor = true;
            this.CheckIsSounds.CheckedChanged += new System.EventHandler(this.CheckIsSounds_CheckedChanged);
            // 
            // TextSounds
            // 
            this.TextSounds.AutoSize = true;
            this.TextSounds.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.TextSounds.ForeColor = System.Drawing.Color.White;
            this.TextSounds.Location = new System.Drawing.Point(12, 30);
            this.TextSounds.Name = "TextSounds";
            this.TextSounds.Size = new System.Drawing.Size(103, 33);
            this.TextSounds.TabIndex = 10;
            this.TextSounds.Text = "Sounds:";
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(128)))));
            this.ButtonClose.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(12, 371);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(140, 60);
            this.ButtonClose.TabIndex = 9;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(694, 461);
            this.Controls.Add(this.ButtonQuestions);
            this.Controls.Add(this.CheckIsDeveloperMode);
            this.Controls.Add(this.TextDeveloperMode);
            this.Controls.Add(this.CheckIsSounds);
            this.Controls.Add(this.TextSounds);
            this.Controls.Add(this.ButtonClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonQuestions;
        private System.Windows.Forms.CheckBox CheckIsDeveloperMode;
        private System.Windows.Forms.Label TextDeveloperMode;
        private System.Windows.Forms.CheckBox CheckIsSounds;
        private System.Windows.Forms.Label TextSounds;
        private System.Windows.Forms.Button ButtonClose;
    }
}