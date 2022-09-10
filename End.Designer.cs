namespace main
{
    partial class End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(End));
            this.TextIsWin = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextIsWin
            // 
            this.TextIsWin.AutoSize = true;
            this.TextIsWin.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.TextIsWin.ForeColor = System.Drawing.Color.White;
            this.TextIsWin.Location = new System.Drawing.Point(12, 9);
            this.TextIsWin.Name = "TextIsWin";
            this.TextIsWin.Size = new System.Drawing.Size(62, 26);
            this.TextIsWin.TabIndex = 3;
            this.TextIsWin.Text = "label1";
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.ButtonExit.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.ButtonExit.Location = new System.Drawing.Point(295, 372);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(150, 66);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextIsWin);
            this.Controls.Add(this.ButtonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "End";
            this.Text = "End";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextIsWin;
        private System.Windows.Forms.Button ButtonExit;
    }
}