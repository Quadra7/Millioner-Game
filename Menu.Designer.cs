namespace main
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.PanelEmpty = new System.Windows.Forms.Panel();
            this.PanelWindow = new System.Windows.Forms.Panel();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.TimerIsPlay = new System.Windows.Forms.Timer(this.components);
            this.PanelButtons.SuspendLayout();
            this.PanelWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.PanelButtons.Controls.Add(this.ButtonExit);
            this.PanelButtons.Controls.Add(this.ButtonSettings);
            this.PanelButtons.Controls.Add(this.ButtonHelp);
            this.PanelButtons.Controls.Add(this.ButtonPlay);
            this.PanelButtons.Controls.Add(this.PanelEmpty);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelButtons.Location = new System.Drawing.Point(0, 0);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(210, 460);
            this.PanelButtons.TabIndex = 1;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(128)))));
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonExit.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Location = new System.Drawing.Point(0, 400);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(210, 60);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(128)))));
            this.ButtonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonSettings.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonSettings.ForeColor = System.Drawing.Color.White;
            this.ButtonSettings.Location = new System.Drawing.Point(0, 240);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(210, 60);
            this.ButtonSettings.TabIndex = 3;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(128)))));
            this.ButtonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHelp.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonHelp.ForeColor = System.Drawing.Color.White;
            this.ButtonHelp.Location = new System.Drawing.Point(0, 180);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(210, 60);
            this.ButtonHelp.TabIndex = 2;
            this.ButtonHelp.Text = "Help";
            this.ButtonHelp.UseVisualStyleBackColor = false;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(128)))));
            this.ButtonPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPlay.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonPlay.ForeColor = System.Drawing.Color.White;
            this.ButtonPlay.Location = new System.Drawing.Point(0, 120);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(210, 60);
            this.ButtonPlay.TabIndex = 1;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // PanelEmpty
            // 
            this.PanelEmpty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.PanelEmpty.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEmpty.Location = new System.Drawing.Point(0, 0);
            this.PanelEmpty.Name = "PanelEmpty";
            this.PanelEmpty.Size = new System.Drawing.Size(210, 120);
            this.PanelEmpty.TabIndex = 0;
            // 
            // PanelWindow
            // 
            this.PanelWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.PanelWindow.Controls.Add(this.PictureLogo);
            this.PanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWindow.Location = new System.Drawing.Point(210, 0);
            this.PanelWindow.Name = "PanelWindow";
            this.PanelWindow.Size = new System.Drawing.Size(690, 460);
            this.PanelWindow.TabIndex = 2;
            // 
            // PictureLogo
            // 
            this.PictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureLogo.Image = global::main.Properties.Resources.logo;
            this.PictureLogo.Location = new System.Drawing.Point(170, 55);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(340, 340);
            this.PictureLogo.TabIndex = 0;
            this.PictureLogo.TabStop = false;
            // 
            // TimerIsPlay
            // 
            this.TimerIsPlay.Tick += new System.EventHandler(this.TimerIsPlay_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 460);
            this.Controls.Add(this.PanelWindow);
            this.Controls.Add(this.PanelButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Millioner-Game";
            this.PanelButtons.ResumeLayout(false);
            this.PanelWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Panel PanelEmpty;
        private System.Windows.Forms.Panel PanelWindow;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.Timer TimerIsPlay;
    }
}

