namespace main
{
    partial class Type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Type));
            this.TextError = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonSecondType = new System.Windows.Forms.Button();
            this.ButtonFirstType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureSecondWall = new System.Windows.Forms.PictureBox();
            this.PictureFirstWall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSecondWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFirstWall)).BeginInit();
            this.SuspendLayout();
            // 
            // TextError
            // 
            this.TextError.AutoSize = true;
            this.TextError.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.TextError.ForeColor = System.Drawing.Color.Red;
            this.TextError.Location = new System.Drawing.Point(239, 318);
            this.TextError.Name = "TextError";
            this.TextError.Size = new System.Drawing.Size(225, 33);
            this.TextError.TabIndex = 13;
            this.TextError.Text = "Error: Choose type";
            this.TextError.Visible = false;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.ButtonStart.Location = new System.Drawing.Point(278, 372);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(138, 57);
            this.ButtonStart.TabIndex = 12;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonSecondType
            // 
            this.ButtonSecondType.Location = new System.Drawing.Point(422, 146);
            this.ButtonSecondType.Name = "ButtonSecondType";
            this.ButtonSecondType.Size = new System.Drawing.Size(150, 150);
            this.ButtonSecondType.TabIndex = 11;
            this.ButtonSecondType.UseVisualStyleBackColor = true;
            this.ButtonSecondType.Click += new System.EventHandler(this.ButtonSecondType_Click);
            // 
            // ButtonFirstType
            // 
            this.ButtonFirstType.Location = new System.Drawing.Point(122, 146);
            this.ButtonFirstType.Name = "ButtonFirstType";
            this.ButtonFirstType.Size = new System.Drawing.Size(150, 150);
            this.ButtonFirstType.TabIndex = 10;
            this.ButtonFirstType.UseVisualStyleBackColor = true;
            this.ButtonFirstType.Click += new System.EventHandler(this.ButtonFirstType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label1.Location = new System.Drawing.Point(197, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose type of questions ";
            // 
            // PictureSecondWall
            // 
            this.PictureSecondWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.PictureSecondWall.Location = new System.Drawing.Point(417, 141);
            this.PictureSecondWall.Name = "PictureSecondWall";
            this.PictureSecondWall.Size = new System.Drawing.Size(160, 160);
            this.PictureSecondWall.TabIndex = 15;
            this.PictureSecondWall.TabStop = false;
            this.PictureSecondWall.Visible = false;
            // 
            // PictureFirstWall
            // 
            this.PictureFirstWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.PictureFirstWall.Location = new System.Drawing.Point(117, 141);
            this.PictureFirstWall.Name = "PictureFirstWall";
            this.PictureFirstWall.Size = new System.Drawing.Size(160, 160);
            this.PictureFirstWall.TabIndex = 14;
            this.PictureFirstWall.TabStop = false;
            this.PictureFirstWall.Visible = false;
            // 
            // Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(694, 461);
            this.Controls.Add(this.PictureSecondWall);
            this.Controls.Add(this.PictureFirstWall);
            this.Controls.Add(this.TextError);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonSecondType);
            this.Controls.Add(this.ButtonFirstType);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Type";
            this.Text = "Type";
            ((System.ComponentModel.ISupportInitialize)(this.PictureSecondWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFirstWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextError;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonSecondType;
        private System.Windows.Forms.Button ButtonFirstType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureSecondWall;
        private System.Windows.Forms.PictureBox PictureFirstWall;
    }
}