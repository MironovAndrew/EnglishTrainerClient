namespace WinFormsAppTryingFitures.Forms.Menu.Cards
{
    partial class FormShowingCards
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.ButtonShowWordPhrase = new WinFormsAppTryingFitures.RoundButton();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelScore);
            this.panelMain.Controls.Add(this.buttonCheck);
            this.panelMain.Controls.Add(this.textBoxAnswer);
            this.panelMain.Controls.Add(this.ButtonShowWordPhrase);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 450);
            this.panelMain.TabIndex = 2;
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
            this.buttonCheck.Location = new System.Drawing.Point(188, 429);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(232, 28);
            this.buttonCheck.TabIndex = 9;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswer.Location = new System.Drawing.Point(188, 392);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(232, 31);
            this.textBoxAnswer.TabIndex = 8;
            // 
            // ButtonShowWordPhrase
            // 
            this.ButtonShowWordPhrase.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonShowWordPhrase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowWordPhrase.Enabled = false;
            this.ButtonShowWordPhrase.FlatAppearance.BorderSize = 0;
            this.ButtonShowWordPhrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowWordPhrase.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonShowWordPhrase.Location = new System.Drawing.Point(154, 86);
            this.ButtonShowWordPhrase.Name = "ButtonShowWordPhrase";
            this.ButtonShowWordPhrase.Size = new System.Drawing.Size(300, 300);
            this.ButtonShowWordPhrase.TabIndex = 6;
            this.ButtonShowWordPhrase.Text = "Computer";
            this.ButtonShowWordPhrase.UseVisualStyleBackColor = false;
            // 
            // FormShowingCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "FormShowingCards";
            this.Text = "FormShowingCards";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private RoundButton ButtonShowWordPhrase;
    }
}