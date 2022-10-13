namespace WinFormsAppTryingFitures
{
    partial class FormAdminWords
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxRussianWord = new System.Windows.Forms.TextBox();
            this.textBoxEnglishWord = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEnglishWord = new System.Windows.Forms.Label();
            this.labelRussina = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(133, 178);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(226, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxRussianWord
            // 
            this.textBoxRussianWord.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRussianWord.Location = new System.Drawing.Point(12, 115);
            this.textBoxRussianWord.Name = "textBoxRussianWord";
            this.textBoxRussianWord.Size = new System.Drawing.Size(347, 31);
            this.textBoxRussianWord.TabIndex = 1;
            // 
            // textBoxEnglishWord
            // 
            this.textBoxEnglishWord.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEnglishWord.Location = new System.Drawing.Point(12, 51);
            this.textBoxEnglishWord.Name = "textBoxEnglishWord";
            this.textBoxEnglishWord.Size = new System.Drawing.Size(347, 31);
            this.textBoxEnglishWord.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.labelEnglishWord);
            this.panel1.Controls.Add(this.textBoxEnglishWord);
            this.panel1.Controls.Add(this.labelRussina);
            this.panel1.Controls.Add(this.textBoxRussianWord);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 3;
            // 
            // labelEnglishWord
            // 
            this.labelEnglishWord.AutoSize = true;
            this.labelEnglishWord.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnglishWord.Location = new System.Drawing.Point(12, 26);
            this.labelEnglishWord.Name = "labelEnglishWord";
            this.labelEnglishWord.Size = new System.Drawing.Size(123, 22);
            this.labelEnglishWord.TabIndex = 3;
            this.labelEnglishWord.Text = "Английский";
            // 
            // labelRussina
            // 
            this.labelRussina.AutoSize = true;
            this.labelRussina.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRussina.Location = new System.Drawing.Point(12, 90);
            this.labelRussina.Name = "labelRussina";
            this.labelRussina.Size = new System.Drawing.Size(90, 22);
            this.labelRussina.TabIndex = 4;
            this.labelRussina.Text = "Русский";
            // 
            // FormAdminWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdminWords";
            this.Text = "FormAdminWords";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxRussianWord;
        private System.Windows.Forms.TextBox textBoxEnglishWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRussina;
        private System.Windows.Forms.Label labelEnglishWord;
    }
}