using System;

namespace WinFormsAppTryingFitures
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTranslator = new System.Windows.Forms.Button();
            this.buttonData = new System.Windows.Forms.Button();
            this.buttonTrainer = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonTopics = new System.Windows.Forms.Button();
            this.buttonForum = new System.Windows.Forms.Button();
            this.panelShowForm = new System.Windows.Forms.Panel();
            this.pictureBoxPhoto = new WinFormsAppTryingFitures.RoundPictureBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelShowForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTranslator
            // 
            this.buttonTranslator.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonTranslator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTranslator.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTranslator.FlatAppearance.BorderSize = 0;
            this.buttonTranslator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTranslator.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTranslator.Location = new System.Drawing.Point(0, 220);
            this.buttonTranslator.Name = "buttonTranslator";
            this.buttonTranslator.Size = new System.Drawing.Size(126, 110);
            this.buttonTranslator.TabIndex = 7;
            this.buttonTranslator.Text = "Переводчик";
            this.buttonTranslator.UseVisualStyleBackColor = false;
            // 
            // buttonData
            // 
            this.buttonData.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonData.FlatAppearance.BorderSize = 0;
            this.buttonData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonData.Location = new System.Drawing.Point(0, 0);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(126, 110);
            this.buttonData.TabIndex = 6;
            this.buttonData.Text = "Филиалы";
            this.buttonData.UseVisualStyleBackColor = false;
            // 
            // buttonTrainer
            // 
            this.buttonTrainer.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonTrainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTrainer.FlatAppearance.BorderSize = 0;
            this.buttonTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrainer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTrainer.Location = new System.Drawing.Point(0, 330);
            this.buttonTrainer.Name = "buttonTrainer";
            this.buttonTrainer.Size = new System.Drawing.Size(126, 110);
            this.buttonTrainer.TabIndex = 5;
            this.buttonTrainer.Text = "Тренажёр";
            this.buttonTrainer.UseVisualStyleBackColor = false;
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAccount.Location = new System.Drawing.Point(0, 110);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(126, 110);
            this.buttonAccount.TabIndex = 4;
            this.buttonAccount.Text = "Учётная запись";
            this.buttonAccount.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenu.CausesValidation = false;
            this.panelMenu.Controls.Add(this.buttonTopics);
            this.panelMenu.Controls.Add(this.buttonForum);
            this.panelMenu.Controls.Add(this.buttonTrainer);
            this.panelMenu.Controls.Add(this.buttonTranslator);
            this.panelMenu.Controls.Add(this.buttonAccount);
            this.panelMenu.Controls.Add(this.buttonData);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(126, 660);
            this.panelMenu.TabIndex = 8;
            // 
            // buttonTopics
            // 
            this.buttonTopics.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonTopics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTopics.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTopics.FlatAppearance.BorderSize = 0;
            this.buttonTopics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTopics.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTopics.Location = new System.Drawing.Point(0, 550);
            this.buttonTopics.Name = "buttonTopics";
            this.buttonTopics.Size = new System.Drawing.Size(126, 110);
            this.buttonTopics.TabIndex = 9;
            this.buttonTopics.Text = "Темы";
            this.buttonTopics.UseVisualStyleBackColor = false;
            // 
            // buttonForum
            // 
            this.buttonForum.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonForum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForum.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonForum.FlatAppearance.BorderSize = 0;
            this.buttonForum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonForum.Location = new System.Drawing.Point(0, 440);
            this.buttonForum.Name = "buttonForum";
            this.buttonForum.Size = new System.Drawing.Size(126, 110);
            this.buttonForum.TabIndex = 8;
            this.buttonForum.Text = "Форум";
            this.buttonForum.UseVisualStyleBackColor = false;
            // 
            // panelShowForm
            // 
            this.panelShowForm.Controls.Add(this.pictureBoxPhoto);
            this.panelShowForm.Controls.Add(this.labelTest);
            this.panelShowForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowForm.Location = new System.Drawing.Point(126, 0);
            this.panelShowForm.Name = "panelShowForm";
            this.panelShowForm.Size = new System.Drawing.Size(1074, 660);
            this.panelShowForm.TabIndex = 9;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Image = global::WinFormsAppTryingFitures.Properties.Resources.default_male_photo;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(22, 80);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 23;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTest.Location = new System.Drawing.Point(22, 22);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(0, 39);
            this.labelTest.TabIndex = 0;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 660);
            this.Controls.Add(this.panelShowForm);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelShowForm.ResumeLayout(false);
            this.panelShowForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTranslator;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.Button buttonTrainer;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button buttonForum;
        private RoundPictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonTopics;
        public System.Windows.Forms.Panel panelShowForm;
    }
}
