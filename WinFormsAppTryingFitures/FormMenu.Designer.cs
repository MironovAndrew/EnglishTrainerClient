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
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonData = new System.Windows.Forms.Button();
            this.buttonTrainer = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonForum = new System.Windows.Forms.Button();
            this.panelShowForm = new System.Windows.Forms.Panel();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelShowForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInfo.Location = new System.Drawing.Point(0, 220);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(110, 110);
            this.buttonInfo.TabIndex = 7;
            this.buttonInfo.Text = "Подробнее";
            this.buttonInfo.UseVisualStyleBackColor = false;
            // 
            // buttonData
            // 
            this.buttonData.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonData.FlatAppearance.BorderSize = 0;
            this.buttonData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonData.Location = new System.Drawing.Point(0, 0);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(110, 110);
            this.buttonData.TabIndex = 6;
            this.buttonData.Text = "Филиалы";
            this.buttonData.UseVisualStyleBackColor = false;
            // 
            // buttonTrainer
            // 
            this.buttonTrainer.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonTrainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTrainer.FlatAppearance.BorderSize = 0;
            this.buttonTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrainer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTrainer.Location = new System.Drawing.Point(0, 330);
            this.buttonTrainer.Name = "buttonTrainer";
            this.buttonTrainer.Size = new System.Drawing.Size(110, 110);
            this.buttonTrainer.TabIndex = 5;
            this.buttonTrainer.Text = "Тренажёр";
            this.buttonTrainer.UseVisualStyleBackColor = false;
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAccount.Location = new System.Drawing.Point(0, 110);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(110, 110);
            this.buttonAccount.TabIndex = 4;
            this.buttonAccount.Text = "Учётная запись";
            this.buttonAccount.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            this.panelMenu.CausesValidation = false;
            this.panelMenu.Controls.Add(this.buttonForum);
            this.panelMenu.Controls.Add(this.buttonTrainer);
            this.panelMenu.Controls.Add(this.buttonInfo);
            this.panelMenu.Controls.Add(this.buttonAccount);
            this.panelMenu.Controls.Add(this.buttonData);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(110, 550);
            this.panelMenu.TabIndex = 8;
            // 
            // buttonForum
            // 
            this.buttonForum.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonForum.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonForum.FlatAppearance.BorderSize = 0;
            this.buttonForum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonForum.Location = new System.Drawing.Point(0, 440);
            this.buttonForum.Name = "buttonForum";
            this.buttonForum.Size = new System.Drawing.Size(110, 110);
            this.buttonForum.TabIndex = 8;
            this.buttonForum.Text = "Форум";
            this.buttonForum.UseVisualStyleBackColor = false;
            // 
            // panelShowForm
            // 
            this.panelShowForm.Controls.Add(this.pictureBoxPhoto);
            this.panelShowForm.Controls.Add(this.labelTest);
            this.panelShowForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowForm.Location = new System.Drawing.Point(110, 0);
            this.panelShowForm.Name = "panelShowForm";
            this.panelShowForm.Size = new System.Drawing.Size(1090, 550);
            this.panelShowForm.TabIndex = 9;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto.Image = global::WinFormsAppTryingFitures.Properties.Resources.default_male_photo;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(22, 80);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 22;
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
            this.ClientSize = new System.Drawing.Size(1200, 550);
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

        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.Button buttonTrainer;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelShowForm;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonForum;
    }
}
