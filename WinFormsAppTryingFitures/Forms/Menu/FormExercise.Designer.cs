namespace WinFormsAppTryingFitures
{
    partial class FormExercise
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.labelScore);
            this.panel1.Controls.Add(this.textBoxAnswer);
            this.panel1.Controls.Add(this.labelQuestionNumber);
            this.panel1.Controls.Add(this.buttonAnswer);
            this.panel1.Controls.Add(this.labelQuestion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 660);
            this.panel1.TabIndex = 3;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScore.ForeColor = System.Drawing.Color.Green;
            this.labelScore.Location = new System.Drawing.Point(440, 29);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(53, 22);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Счёт";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswer.Location = new System.Drawing.Point(183, 115);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(100, 31);
            this.textBoxAnswer.TabIndex = 3;
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuestionNumber.Location = new System.Drawing.Point(164, 28);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(163, 23);
            this.labelQuestionNumber.TabIndex = 2;
            this.labelQuestionNumber.Text = "Номер вопроса";
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.BackColor = System.Drawing.Color.Green;
            this.buttonAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnswer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnswer.Location = new System.Drawing.Point(379, 208);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(144, 40);
            this.buttonAnswer.TabIndex = 1;
            this.buttonAnswer.Text = "Ответить";
            this.buttonAnswer.UseVisualStyleBackColor = false;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuestion.ForeColor = System.Drawing.Color.Red;
            this.labelQuestion.Location = new System.Drawing.Point(193, 75);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(81, 22);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Вопрос";
            // 
            // FormExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExercise";
            this.Text = "FormExercise";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Label labelQuestion;
    }
}