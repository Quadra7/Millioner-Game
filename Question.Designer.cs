namespace main
{
    partial class Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.NumericType = new System.Windows.Forms.NumericUpDown();
            this.TextType = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.NumericCorrectAnswer = new System.Windows.Forms.NumericUpDown();
            this.TextCorrectAnswer = new System.Windows.Forms.Label();
            this.TextBoxFirstAnswer = new System.Windows.Forms.TextBox();
            this.TextBoxFourthAnswer = new System.Windows.Forms.TextBox();
            this.TextFourthAnswer = new System.Windows.Forms.Label();
            this.TextBoxThirdAnswer = new System.Windows.Forms.TextBox();
            this.TextThirdAnswer = new System.Windows.Forms.Label();
            this.TextBoxSecondAnswer = new System.Windows.Forms.TextBox();
            this.TextSecondAnswer = new System.Windows.Forms.Label();
            this.TextFirstAnswer = new System.Windows.Forms.Label();
            this.TextBoxQuestion = new System.Windows.Forms.TextBox();
            this.TextQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCorrectAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericType
            // 
            this.NumericType.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.NumericType.Location = new System.Drawing.Point(405, 392);
            this.NumericType.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericType.Name = "NumericType";
            this.NumericType.Size = new System.Drawing.Size(41, 26);
            this.NumericType.TabIndex = 32;
            this.NumericType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TextType
            // 
            this.TextType.AutoSize = true;
            this.TextType.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.TextType.ForeColor = System.Drawing.Color.White;
            this.TextType.Location = new System.Drawing.Point(333, 392);
            this.TextType.Name = "TextType";
            this.TextType.Size = new System.Drawing.Size(55, 26);
            this.TextType.TabIndex = 31;
            this.TextType.Text = "Type";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.ButtonSave.Location = new System.Drawing.Point(14, 441);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(135, 35);
            this.ButtonSave.TabIndex = 30;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // NumericCorrectAnswer
            // 
            this.NumericCorrectAnswer.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.NumericCorrectAnswer.Location = new System.Drawing.Point(178, 396);
            this.NumericCorrectAnswer.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumericCorrectAnswer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericCorrectAnswer.Name = "NumericCorrectAnswer";
            this.NumericCorrectAnswer.Size = new System.Drawing.Size(41, 26);
            this.NumericCorrectAnswer.TabIndex = 29;
            this.NumericCorrectAnswer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TextCorrectAnswer
            // 
            this.TextCorrectAnswer.AutoSize = true;
            this.TextCorrectAnswer.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.TextCorrectAnswer.ForeColor = System.Drawing.Color.White;
            this.TextCorrectAnswer.Location = new System.Drawing.Point(16, 396);
            this.TextCorrectAnswer.Name = "TextCorrectAnswer";
            this.TextCorrectAnswer.Size = new System.Drawing.Size(147, 26);
            this.TextCorrectAnswer.TabIndex = 28;
            this.TextCorrectAnswer.Text = "Correct answer";
            // 
            // TextBoxFirstAnswer
            // 
            this.TextBoxFirstAnswer.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TextBoxFirstAnswer.Location = new System.Drawing.Point(16, 117);
            this.TextBoxFirstAnswer.Name = "TextBoxFirstAnswer";
            this.TextBoxFirstAnswer.Size = new System.Drawing.Size(458, 26);
            this.TextBoxFirstAnswer.TabIndex = 27;
            // 
            // TextBoxFourthAnswer
            // 
            this.TextBoxFourthAnswer.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TextBoxFourthAnswer.Location = new System.Drawing.Point(14, 346);
            this.TextBoxFourthAnswer.Name = "TextBoxFourthAnswer";
            this.TextBoxFourthAnswer.Size = new System.Drawing.Size(460, 26);
            this.TextBoxFourthAnswer.TabIndex = 26;
            // 
            // TextFourthAnswer
            // 
            this.TextFourthAnswer.AutoSize = true;
            this.TextFourthAnswer.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.TextFourthAnswer.ForeColor = System.Drawing.Color.White;
            this.TextFourthAnswer.Location = new System.Drawing.Point(14, 317);
            this.TextFourthAnswer.Name = "TextFourthAnswer";
            this.TextFourthAnswer.Size = new System.Drawing.Size(139, 26);
            this.TextFourthAnswer.TabIndex = 25;
            this.TextFourthAnswer.Text = "Fourth answer";
            // 
            // TextBoxThirdAnswer
            // 
            this.TextBoxThirdAnswer.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TextBoxThirdAnswer.Location = new System.Drawing.Point(14, 269);
            this.TextBoxThirdAnswer.Name = "TextBoxThirdAnswer";
            this.TextBoxThirdAnswer.Size = new System.Drawing.Size(460, 26);
            this.TextBoxThirdAnswer.TabIndex = 24;
            // 
            // TextThirdAnswer
            // 
            this.TextThirdAnswer.AutoSize = true;
            this.TextThirdAnswer.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.TextThirdAnswer.ForeColor = System.Drawing.Color.White;
            this.TextThirdAnswer.Location = new System.Drawing.Point(14, 240);
            this.TextThirdAnswer.Name = "TextThirdAnswer";
            this.TextThirdAnswer.Size = new System.Drawing.Size(127, 26);
            this.TextThirdAnswer.TabIndex = 23;
            this.TextThirdAnswer.Text = "Third answer";
            // 
            // TextBoxSecondAnswer
            // 
            this.TextBoxSecondAnswer.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TextBoxSecondAnswer.Location = new System.Drawing.Point(14, 192);
            this.TextBoxSecondAnswer.Name = "TextBoxSecondAnswer";
            this.TextBoxSecondAnswer.Size = new System.Drawing.Size(460, 26);
            this.TextBoxSecondAnswer.TabIndex = 22;
            // 
            // TextSecondAnswer
            // 
            this.TextSecondAnswer.AutoSize = true;
            this.TextSecondAnswer.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.TextSecondAnswer.ForeColor = System.Drawing.Color.White;
            this.TextSecondAnswer.Location = new System.Drawing.Point(11, 163);
            this.TextSecondAnswer.Name = "TextSecondAnswer";
            this.TextSecondAnswer.Size = new System.Drawing.Size(144, 26);
            this.TextSecondAnswer.TabIndex = 21;
            this.TextSecondAnswer.Text = "Second answer";
            // 
            // TextFirstAnswer
            // 
            this.TextFirstAnswer.AutoSize = true;
            this.TextFirstAnswer.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.TextFirstAnswer.ForeColor = System.Drawing.Color.White;
            this.TextFirstAnswer.Location = new System.Drawing.Point(14, 88);
            this.TextFirstAnswer.Name = "TextFirstAnswer";
            this.TextFirstAnswer.Size = new System.Drawing.Size(122, 26);
            this.TextFirstAnswer.TabIndex = 20;
            this.TextFirstAnswer.Text = "First answer";
            // 
            // TextBoxQuestion
            // 
            this.TextBoxQuestion.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TextBoxQuestion.Location = new System.Drawing.Point(14, 40);
            this.TextBoxQuestion.Name = "TextBoxQuestion";
            this.TextBoxQuestion.Size = new System.Drawing.Size(460, 26);
            this.TextBoxQuestion.TabIndex = 19;
            // 
            // TextQuestion
            // 
            this.TextQuestion.AutoSize = true;
            this.TextQuestion.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.TextQuestion.ForeColor = System.Drawing.Color.White;
            this.TextQuestion.Location = new System.Drawing.Point(14, 11);
            this.TextQuestion.Name = "TextQuestion";
            this.TextQuestion.Size = new System.Drawing.Size(90, 26);
            this.TextQuestion.TabIndex = 18;
            this.TextQuestion.Text = "Question";
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 486);
            this.Controls.Add(this.NumericType);
            this.Controls.Add(this.TextType);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.NumericCorrectAnswer);
            this.Controls.Add(this.TextCorrectAnswer);
            this.Controls.Add(this.TextBoxFirstAnswer);
            this.Controls.Add(this.TextBoxFourthAnswer);
            this.Controls.Add(this.TextFourthAnswer);
            this.Controls.Add(this.TextBoxThirdAnswer);
            this.Controls.Add(this.TextThirdAnswer);
            this.Controls.Add(this.TextBoxSecondAnswer);
            this.Controls.Add(this.TextSecondAnswer);
            this.Controls.Add(this.TextFirstAnswer);
            this.Controls.Add(this.TextBoxQuestion);
            this.Controls.Add(this.TextQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Question";
            this.Text = "Question";
            ((System.ComponentModel.ISupportInitialize)(this.NumericType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCorrectAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericType;
        private System.Windows.Forms.Label TextType;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.NumericUpDown NumericCorrectAnswer;
        private System.Windows.Forms.Label TextCorrectAnswer;
        private System.Windows.Forms.TextBox TextBoxFirstAnswer;
        private System.Windows.Forms.TextBox TextBoxFourthAnswer;
        private System.Windows.Forms.Label TextFourthAnswer;
        private System.Windows.Forms.TextBox TextBoxThirdAnswer;
        private System.Windows.Forms.Label TextThirdAnswer;
        private System.Windows.Forms.TextBox TextBoxSecondAnswer;
        private System.Windows.Forms.Label TextSecondAnswer;
        private System.Windows.Forms.Label TextFirstAnswer;
        private System.Windows.Forms.TextBox TextBoxQuestion;
        private System.Windows.Forms.Label TextQuestion;
    }
}