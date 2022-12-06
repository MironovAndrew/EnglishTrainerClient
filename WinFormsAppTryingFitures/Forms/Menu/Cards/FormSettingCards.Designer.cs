namespace WinFormsAppTryingFitures
{
    partial class FormSettingCards
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
            this.panelSettings = new System.Windows.Forms.Panel();
            this.checkBoxIsFavorite = new System.Windows.Forms.CheckBox();
            this.radioButtonPrases = new System.Windows.Forms.RadioButton();
            this.radioButtonWords = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSettings.Controls.Add(this.checkBoxIsFavorite);
            this.panelSettings.Controls.Add(this.radioButtonPrases);
            this.panelSettings.Controls.Add(this.radioButtonWords);
            this.panelSettings.Controls.Add(this.buttonStart);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(700, 57);
            this.panelSettings.TabIndex = 0;
            // 
            // checkBoxIsFavorite
            // 
            this.checkBoxIsFavorite.AutoSize = true;
            this.checkBoxIsFavorite.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxIsFavorite.Location = new System.Drawing.Point(407, 20);
            this.checkBoxIsFavorite.Name = "checkBoxIsFavorite";
            this.checkBoxIsFavorite.Size = new System.Drawing.Size(136, 26);
            this.checkBoxIsFavorite.TabIndex = 3;
            this.checkBoxIsFavorite.Text = "Избранное";
            this.checkBoxIsFavorite.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrases
            // 
            this.radioButtonPrases.AutoSize = true;
            this.radioButtonPrases.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPrases.Location = new System.Drawing.Point(213, 19);
            this.radioButtonPrases.Name = "radioButtonPrases";
            this.radioButtonPrases.Size = new System.Drawing.Size(92, 26);
            this.radioButtonPrases.TabIndex = 2;
            this.radioButtonPrases.Text = "Фразы";
            this.radioButtonPrases.UseVisualStyleBackColor = true;
            // 
            // radioButtonWords
            // 
            this.radioButtonWords.AutoSize = true;
            this.radioButtonWords.Checked = true;
            this.radioButtonWords.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonWords.Location = new System.Drawing.Point(25, 19);
            this.radioButtonWords.Name = "radioButtonWords";
            this.radioButtonWords.Size = new System.Drawing.Size(87, 26);
            this.radioButtonWords.TabIndex = 1;
            this.radioButtonWords.TabStop = true;
            this.radioButtonWords.Text = "Слова";
            this.radioButtonWords.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(592, 11);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(96, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 57);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(700, 643);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "English";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Russian";
            this.columnHeader2.Width = 300;
            // 
            // FormSettingCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panelSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettingCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSettingCards";
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxIsFavorite;
        private System.Windows.Forms.RadioButton radioButtonPrases;
        private System.Windows.Forms.RadioButton radioButtonWords;
    }
}