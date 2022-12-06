namespace WinFormsAppTryingFitures
{
    partial class FormCards
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
            this.panelCondition = new System.Windows.Forms.Panel();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.checkBoxFavorite = new System.Windows.Forms.CheckBox();
            this.radioButtonPhrases = new System.Windows.Forms.RadioButton();
            this.radioButtonWords = new System.Windows.Forms.RadioButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.pictureBoxisFavorite = new System.Windows.Forms.PictureBox();
            this.ButtonShowWordPhrase = new WinFormsAppTryingFitures.RoundButton();
            this.panelCondition.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxisFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCondition
            // 
            this.panelCondition.Controls.Add(this.buttonStartStop);
            this.panelCondition.Controls.Add(this.checkBoxFavorite);
            this.panelCondition.Controls.Add(this.radioButtonPhrases);
            this.panelCondition.Controls.Add(this.radioButtonWords);
            this.panelCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCondition.Location = new System.Drawing.Point(0, 0);
            this.panelCondition.Name = "panelCondition";
            this.panelCondition.Size = new System.Drawing.Size(608, 109);
            this.panelCondition.TabIndex = 2;
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonStartStop.FlatAppearance.BorderSize = 0;
            this.buttonStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartStop.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartStop.Location = new System.Drawing.Point(294, 43);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(302, 28);
            this.buttonStartStop.TabIndex = 6;
            this.buttonStartStop.Text = "Начать";
            this.buttonStartStop.UseVisualStyleBackColor = false;
            // 
            // checkBoxFavorite
            // 
            this.checkBoxFavorite.AutoSize = true;
            this.checkBoxFavorite.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFavorite.Location = new System.Drawing.Point(14, 55);
            this.checkBoxFavorite.Name = "checkBoxFavorite";
            this.checkBoxFavorite.Size = new System.Drawing.Size(262, 26);
            this.checkBoxFavorite.TabIndex = 2;
            this.checkBoxFavorite.Text = "Выбирать из избранного";
            this.checkBoxFavorite.UseVisualStyleBackColor = true;
            // 
            // radioButtonPhrases
            // 
            this.radioButtonPhrases.AutoSize = true;
            this.radioButtonPhrases.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPhrases.Location = new System.Drawing.Point(138, 12);
            this.radioButtonPhrases.Name = "radioButtonPhrases";
            this.radioButtonPhrases.Size = new System.Drawing.Size(92, 26);
            this.radioButtonPhrases.TabIndex = 1;
            this.radioButtonPhrases.Text = "Фразы";
            this.radioButtonPhrases.UseVisualStyleBackColor = true;
            // 
            // radioButtonWords
            // 
            this.radioButtonWords.AutoSize = true;
            this.radioButtonWords.Checked = true;
            this.radioButtonWords.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonWords.Location = new System.Drawing.Point(14, 12);
            this.radioButtonWords.Name = "radioButtonWords";
            this.radioButtonWords.Size = new System.Drawing.Size(87, 26);
            this.radioButtonWords.TabIndex = 0;
            this.radioButtonWords.TabStop = true;
            this.radioButtonWords.Text = "Слова";
            this.radioButtonWords.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelScore);
            this.panelMain.Controls.Add(this.buttonCheck);
            this.panelMain.Controls.Add(this.textBoxAnswer);
            this.panelMain.Controls.Add(this.pictureBoxisFavorite);
            this.panelMain.Controls.Add(this.ButtonShowWordPhrase);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(0, 109);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(608, 406);
            this.panelMain.TabIndex = 1;
            this.panelMain.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScore.Location = new System.Drawing.Point(9, 11);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(40, 22);
            this.labelScore.TabIndex = 10;
            this.labelScore.Text = "0/0";
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCheck.FlatAppearance.BorderSize = 0;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCheck.Location = new System.Drawing.Point(312, 363);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(281, 28);
            this.buttonCheck.TabIndex = 9;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswer.Location = new System.Drawing.Point(23, 363);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(283, 31);
            this.textBoxAnswer.TabIndex = 8;
            // 
            // pictureBoxisFavorite
            // 
            this.pictureBoxisFavorite.Image = global::WinFormsAppTryingFitures.Properties.Resources.unchosenHeart;
            this.pictureBoxisFavorite.Location = new System.Drawing.Point(543, 11);
            this.pictureBoxisFavorite.Name = "pictureBoxisFavorite";
            this.pictureBoxisFavorite.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxisFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxisFavorite.TabIndex = 7;
            this.pictureBoxisFavorite.TabStop = false;
            // 
            // ButtonShowWordPhrase
            // 
            this.ButtonShowWordPhrase.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonShowWordPhrase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowWordPhrase.Enabled = false;
            this.ButtonShowWordPhrase.FlatAppearance.BorderSize = 0;
            this.ButtonShowWordPhrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowWordPhrase.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonShowWordPhrase.Location = new System.Drawing.Point(152, 38);
            this.ButtonShowWordPhrase.Name = "ButtonShowWordPhrase";
            this.ButtonShowWordPhrase.Size = new System.Drawing.Size(300, 300);
            this.ButtonShowWordPhrase.TabIndex = 6;
            this.ButtonShowWordPhrase.Text = "Computer";
            this.ButtonShowWordPhrase.UseVisualStyleBackColor = false;
            // 
            // FormCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 515);
            this.Controls.Add(this.panelCondition);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCards";
            this.panelCondition.ResumeLayout(false);
            this.panelCondition.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxisFavorite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCondition;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.CheckBox checkBoxFavorite;
        private System.Windows.Forms.RadioButton radioButtonPhrases;
        private System.Windows.Forms.RadioButton radioButtonWords;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.PictureBox pictureBoxisFavorite;
        private RoundButton ButtonShowWordPhrase;
    }
}