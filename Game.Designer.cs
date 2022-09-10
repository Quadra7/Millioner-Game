namespace main
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.GroupBoxPeople = new System.Windows.Forms.GroupBox();
            this.TextFourthAnswerPercent = new System.Windows.Forms.Label();
            this.TextThirdAnswerPercent = new System.Windows.Forms.Label();
            this.TextSecondAnswerPercent = new System.Windows.Forms.Label();
            this.TextFirstAnswerPercent = new System.Windows.Forms.Label();
            this.ProgressBarFourthAnswer = new System.Windows.Forms.ProgressBar();
            this.TextFourthAnswer = new System.Windows.Forms.Label();
            this.ProgressBarThirdAnswer = new System.Windows.Forms.ProgressBar();
            this.TextThirdAnswer = new System.Windows.Forms.Label();
            this.ProgressBarSecondAnswer = new System.Windows.Forms.ProgressBar();
            this.TextSecondAnswer = new System.Windows.Forms.Label();
            this.ProgressBarFirstAnswer = new System.Windows.Forms.ProgressBar();
            this.TextFirstAnswer = new System.Windows.Forms.Label();
            this.TextCorrectAnswer = new System.Windows.Forms.Label();
            this.TextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.show_answer_color = new System.Windows.Forms.Timer(this.components);
            this.human_thinking = new System.Windows.Forms.Timer(this.components);
            this.PictureCallingMan = new System.Windows.Forms.PictureBox();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.ButtonCall = new System.Windows.Forms.Button();
            this.ButtonPeople = new System.Windows.Forms.Button();
            this.ButtonFiftyFifty = new System.Windows.Forms.Button();
            this.GroupBoxPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCallingMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxPeople
            // 
            this.GroupBoxPeople.Controls.Add(this.TextFourthAnswerPercent);
            this.GroupBoxPeople.Controls.Add(this.TextThirdAnswerPercent);
            this.GroupBoxPeople.Controls.Add(this.TextSecondAnswerPercent);
            this.GroupBoxPeople.Controls.Add(this.TextFirstAnswerPercent);
            this.GroupBoxPeople.Controls.Add(this.ProgressBarFourthAnswer);
            this.GroupBoxPeople.Controls.Add(this.TextFourthAnswer);
            this.GroupBoxPeople.Controls.Add(this.ProgressBarThirdAnswer);
            this.GroupBoxPeople.Controls.Add(this.TextThirdAnswer);
            this.GroupBoxPeople.Controls.Add(this.ProgressBarSecondAnswer);
            this.GroupBoxPeople.Controls.Add(this.TextSecondAnswer);
            this.GroupBoxPeople.Controls.Add(this.ProgressBarFirstAnswer);
            this.GroupBoxPeople.Controls.Add(this.TextFirstAnswer);
            this.GroupBoxPeople.ForeColor = System.Drawing.Color.Yellow;
            this.GroupBoxPeople.Location = new System.Drawing.Point(434, 13);
            this.GroupBoxPeople.Name = "GroupBoxPeople";
            this.GroupBoxPeople.Size = new System.Drawing.Size(200, 127);
            this.GroupBoxPeople.TabIndex = 16;
            this.GroupBoxPeople.TabStop = false;
            this.GroupBoxPeople.Text = "Помощь зала";
            // 
            // TextFourthAnswerPercent
            // 
            this.TextFourthAnswerPercent.AutoSize = true;
            this.TextFourthAnswerPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextFourthAnswerPercent.ForeColor = System.Drawing.Color.FloralWhite;
            this.TextFourthAnswerPercent.Location = new System.Drawing.Point(142, 100);
            this.TextFourthAnswerPercent.Name = "TextFourthAnswerPercent";
            this.TextFourthAnswerPercent.Size = new System.Drawing.Size(49, 18);
            this.TextFourthAnswerPercent.TabIndex = 14;
            this.TextFourthAnswerPercent.Text = "100%";
            // 
            // TextThirdAnswerPercent
            // 
            this.TextThirdAnswerPercent.AutoSize = true;
            this.TextThirdAnswerPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextThirdAnswerPercent.ForeColor = System.Drawing.Color.FloralWhite;
            this.TextThirdAnswerPercent.Location = new System.Drawing.Point(142, 72);
            this.TextThirdAnswerPercent.Name = "TextThirdAnswerPercent";
            this.TextThirdAnswerPercent.Size = new System.Drawing.Size(49, 18);
            this.TextThirdAnswerPercent.TabIndex = 13;
            this.TextThirdAnswerPercent.Text = "100%";
            // 
            // TextSecondAnswerPercent
            // 
            this.TextSecondAnswerPercent.AutoSize = true;
            this.TextSecondAnswerPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextSecondAnswerPercent.ForeColor = System.Drawing.Color.FloralWhite;
            this.TextSecondAnswerPercent.Location = new System.Drawing.Point(142, 44);
            this.TextSecondAnswerPercent.Name = "TextSecondAnswerPercent";
            this.TextSecondAnswerPercent.Size = new System.Drawing.Size(49, 18);
            this.TextSecondAnswerPercent.TabIndex = 12;
            this.TextSecondAnswerPercent.Text = "100%";
            // 
            // TextFirstAnswerPercent
            // 
            this.TextFirstAnswerPercent.AutoSize = true;
            this.TextFirstAnswerPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextFirstAnswerPercent.ForeColor = System.Drawing.Color.FloralWhite;
            this.TextFirstAnswerPercent.Location = new System.Drawing.Point(142, 16);
            this.TextFirstAnswerPercent.Name = "TextFirstAnswerPercent";
            this.TextFirstAnswerPercent.Size = new System.Drawing.Size(49, 18);
            this.TextFirstAnswerPercent.TabIndex = 11;
            this.TextFirstAnswerPercent.Text = "100%";
            // 
            // ProgressBarFourthAnswer
            // 
            this.ProgressBarFourthAnswer.Location = new System.Drawing.Point(36, 100);
            this.ProgressBarFourthAnswer.Name = "ProgressBarFourthAnswer";
            this.ProgressBarFourthAnswer.Size = new System.Drawing.Size(100, 18);
            this.ProgressBarFourthAnswer.TabIndex = 10;
            // 
            // TextFourthAnswer
            // 
            this.TextFourthAnswer.AutoSize = true;
            this.TextFourthAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TextFourthAnswer.Location = new System.Drawing.Point(6, 100);
            this.TextFourthAnswer.Name = "TextFourthAnswer";
            this.TextFourthAnswer.Size = new System.Drawing.Size(24, 18);
            this.TextFourthAnswer.TabIndex = 9;
            this.TextFourthAnswer.Text = "4: ";
            // 
            // ProgressBarThirdAnswer
            // 
            this.ProgressBarThirdAnswer.Location = new System.Drawing.Point(36, 72);
            this.ProgressBarThirdAnswer.Name = "ProgressBarThirdAnswer";
            this.ProgressBarThirdAnswer.Size = new System.Drawing.Size(100, 18);
            this.ProgressBarThirdAnswer.TabIndex = 8;
            // 
            // TextThirdAnswer
            // 
            this.TextThirdAnswer.AutoSize = true;
            this.TextThirdAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TextThirdAnswer.Location = new System.Drawing.Point(6, 72);
            this.TextThirdAnswer.Name = "TextThirdAnswer";
            this.TextThirdAnswer.Size = new System.Drawing.Size(24, 18);
            this.TextThirdAnswer.TabIndex = 7;
            this.TextThirdAnswer.Text = "3: ";
            // 
            // ProgressBarSecondAnswer
            // 
            this.ProgressBarSecondAnswer.Location = new System.Drawing.Point(36, 44);
            this.ProgressBarSecondAnswer.Name = "ProgressBarSecondAnswer";
            this.ProgressBarSecondAnswer.Size = new System.Drawing.Size(100, 18);
            this.ProgressBarSecondAnswer.TabIndex = 6;
            // 
            // TextSecondAnswer
            // 
            this.TextSecondAnswer.AutoSize = true;
            this.TextSecondAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TextSecondAnswer.Location = new System.Drawing.Point(6, 44);
            this.TextSecondAnswer.Name = "TextSecondAnswer";
            this.TextSecondAnswer.Size = new System.Drawing.Size(24, 18);
            this.TextSecondAnswer.TabIndex = 5;
            this.TextSecondAnswer.Text = "2: ";
            // 
            // ProgressBarFirstAnswer
            // 
            this.ProgressBarFirstAnswer.Location = new System.Drawing.Point(36, 16);
            this.ProgressBarFirstAnswer.Name = "ProgressBarFirstAnswer";
            this.ProgressBarFirstAnswer.Size = new System.Drawing.Size(100, 18);
            this.ProgressBarFirstAnswer.TabIndex = 4;
            // 
            // TextFirstAnswer
            // 
            this.TextFirstAnswer.AutoSize = true;
            this.TextFirstAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TextFirstAnswer.Location = new System.Drawing.Point(6, 16);
            this.TextFirstAnswer.Name = "TextFirstAnswer";
            this.TextFirstAnswer.Size = new System.Drawing.Size(24, 18);
            this.TextFirstAnswer.TabIndex = 0;
            this.TextFirstAnswer.Text = "1: ";
            // 
            // TextCorrectAnswer
            // 
            this.TextCorrectAnswer.AutoSize = true;
            this.TextCorrectAnswer.BackColor = System.Drawing.Color.SteelBlue;
            this.TextCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextCorrectAnswer.Location = new System.Drawing.Point(169, 29);
            this.TextCorrectAnswer.Name = "TextCorrectAnswer";
            this.TextCorrectAnswer.Size = new System.Drawing.Size(60, 24);
            this.TextCorrectAnswer.TabIndex = 15;
            this.TextCorrectAnswer.Text = "label1";
            this.TextCorrectAnswer.Visible = false;
            // 
            // TextBoxQuestion
            // 
            this.TextBoxQuestion.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.TextBoxQuestion.Location = new System.Drawing.Point(16, 194);
            this.TextBoxQuestion.Name = "TextBoxQuestion";
            this.TextBoxQuestion.Size = new System.Drawing.Size(618, 103);
            this.TextBoxQuestion.TabIndex = 12;
            this.TextBoxQuestion.Text = "";
            // 
            // show_answer_color
            // 
            this.show_answer_color.Interval = 1000;
            this.show_answer_color.Tick += new System.EventHandler(this.show_answer_color_Tick);
            // 
            // human_thinking
            // 
            this.human_thinking.Interval = 1000;
            this.human_thinking.Tick += new System.EventHandler(this.human_thinking_Tick);
            // 
            // PictureCallingMan
            // 
            this.PictureCallingMan.Image = global::main.Properties.Resources.human;
            this.PictureCallingMan.Location = new System.Drawing.Point(16, 29);
            this.PictureCallingMan.Name = "PictureCallingMan";
            this.PictureCallingMan.Size = new System.Drawing.Size(147, 111);
            this.PictureCallingMan.TabIndex = 14;
            this.PictureCallingMan.TabStop = false;
            this.PictureCallingMan.Visible = false;
            // 
            // PictureLogo
            // 
            this.PictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureLogo.Image = global::main.Properties.Resources.logo;
            this.PictureLogo.Location = new System.Drawing.Point(129, -1);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(340, 340);
            this.PictureLogo.TabIndex = 13;
            this.PictureLogo.TabStop = false;
            // 
            // ButtonCall
            // 
            this.ButtonCall.FlatAppearance.BorderSize = 0;
            this.ButtonCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCall.Image = global::main.Properties.Resources.call;
            this.ButtonCall.Location = new System.Drawing.Point(749, 29);
            this.ButtonCall.Name = "ButtonCall";
            this.ButtonCall.Size = new System.Drawing.Size(58, 46);
            this.ButtonCall.TabIndex = 11;
            this.ButtonCall.UseVisualStyleBackColor = true;
            this.ButtonCall.Click += new System.EventHandler(this.ButtonCall_Click);
            // 
            // ButtonPeople
            // 
            this.ButtonPeople.FlatAppearance.BorderSize = 0;
            this.ButtonPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPeople.Image = global::main.Properties.Resources.people;
            this.ButtonPeople.Location = new System.Drawing.Point(813, 29);
            this.ButtonPeople.Name = "ButtonPeople";
            this.ButtonPeople.Size = new System.Drawing.Size(63, 46);
            this.ButtonPeople.TabIndex = 10;
            this.ButtonPeople.UseVisualStyleBackColor = true;
            this.ButtonPeople.Click += new System.EventHandler(this.ButtonPeople_Click);
            // 
            // ButtonFiftyFifty
            // 
            this.ButtonFiftyFifty.FlatAppearance.BorderSize = 0;
            this.ButtonFiftyFifty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFiftyFifty.Image = global::main.Properties.Resources._50_50;
            this.ButtonFiftyFifty.Location = new System.Drawing.Point(680, 29);
            this.ButtonFiftyFifty.Name = "ButtonFiftyFifty";
            this.ButtonFiftyFifty.Size = new System.Drawing.Size(63, 46);
            this.ButtonFiftyFifty.TabIndex = 9;
            this.ButtonFiftyFifty.UseVisualStyleBackColor = true;
            this.ButtonFiftyFifty.Click += new System.EventHandler(this.ButtonFiftyFifty_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.GroupBoxPeople);
            this.Controls.Add(this.TextCorrectAnswer);
            this.Controls.Add(this.PictureCallingMan);
            this.Controls.Add(this.PictureLogo);
            this.Controls.Add(this.TextBoxQuestion);
            this.Controls.Add(this.ButtonCall);
            this.Controls.Add(this.ButtonPeople);
            this.Controls.Add(this.ButtonFiftyFifty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.GroupBoxPeople.ResumeLayout(false);
            this.GroupBoxPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCallingMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxPeople;
        private System.Windows.Forms.Label TextFourthAnswerPercent;
        private System.Windows.Forms.Label TextThirdAnswerPercent;
        private System.Windows.Forms.Label TextSecondAnswerPercent;
        private System.Windows.Forms.Label TextFirstAnswerPercent;
        private System.Windows.Forms.ProgressBar ProgressBarFourthAnswer;
        private System.Windows.Forms.Label TextFourthAnswer;
        private System.Windows.Forms.ProgressBar ProgressBarThirdAnswer;
        private System.Windows.Forms.Label TextThirdAnswer;
        private System.Windows.Forms.ProgressBar ProgressBarSecondAnswer;
        private System.Windows.Forms.Label TextSecondAnswer;
        private System.Windows.Forms.ProgressBar ProgressBarFirstAnswer;
        private System.Windows.Forms.Label TextFirstAnswer;
        private System.Windows.Forms.Label TextCorrectAnswer;
        private System.Windows.Forms.PictureBox PictureCallingMan;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.RichTextBox TextBoxQuestion;
        private System.Windows.Forms.Button ButtonCall;
        private System.Windows.Forms.Button ButtonPeople;
        private System.Windows.Forms.Button ButtonFiftyFifty;
        private System.Windows.Forms.Timer show_answer_color;
        private System.Windows.Forms.Timer human_thinking;
    }
}