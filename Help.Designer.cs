namespace main
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.ButtonClose = new System.Windows.Forms.Button();
            this.RichTextBoxRules = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(128)))));
            this.ButtonClose.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(12, 389);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(140, 60);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // RichTextBoxRules
            // 
            this.RichTextBoxRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.RichTextBoxRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxRules.ForeColor = System.Drawing.Color.White;
            this.RichTextBoxRules.Location = new System.Drawing.Point(12, 12);
            this.RichTextBoxRules.Name = "RichTextBoxRules";
            this.RichTextBoxRules.Size = new System.Drawing.Size(665, 356);
            this.RichTextBoxRules.TabIndex = 4;
            this.RichTextBoxRules.Text = "";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(694, 461);
            this.Controls.Add(this.RichTextBoxRules);
            this.Controls.Add(this.ButtonClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.RichTextBox RichTextBoxRules;
    }
}