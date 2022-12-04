using WinFormsAppTryingFitures;

namespace WinFormsAppTryingFitures
{
    partial class FormRegistration
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
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBoxShowPassword = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordRepeat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.pictureBoxPhoto = new WinFormsAppTryingFitures.RoundPictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelThirdName = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.panelChoosingPost = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxGroupPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRegistration = new System.Windows.Forms.Panel();
            this.buttonShowPostPanel = new System.Windows.Forms.Button();
            this.panelGroup = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.panelChoosingPost.SuspendLayout();
            this.panelRegistration.SuspendLayout();
            this.panelGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(349, 257);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 19);
            this.radioButtonFemale.TabIndex = 23;
            this.radioButtonFemale.Text = "Женский";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(177, 257);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(77, 19);
            this.radioButtonMale.TabIndex = 22;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мужской";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(172, 83);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(250, 31);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Готово!";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // pictureBoxShowPassword
            // 
            this.pictureBoxShowPassword.Image = global::WinFormsAppTryingFitures.Properties.Resources.eye;
            this.pictureBoxShowPassword.Location = new System.Drawing.Point(430, 172);
            this.pictureBoxShowPassword.Name = "pictureBoxShowPassword";
            this.pictureBoxShowPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShowPassword.TabIndex = 19;
            this.pictureBoxShowPassword.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(177, 172);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(247, 24);
            this.textBoxPassword.TabIndex = 16;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxPasswordRepeat
            // 
            this.textBoxPasswordRepeat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPasswordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordRepeat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPasswordRepeat.Location = new System.Drawing.Point(177, 222);
            this.textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
            this.textBoxPasswordRepeat.PasswordChar = '*';
            this.textBoxPasswordRepeat.Size = new System.Drawing.Size(247, 24);
            this.textBoxPasswordRepeat.TabIndex = 17;
            this.textBoxPasswordRepeat.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(576, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Повторите пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogin.Location = new System.Drawing.Point(177, 104);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(247, 24);
            this.textBoxLogin.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Логин";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegistration
            // 
            this.labelRegistration.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRegistration.Location = new System.Drawing.Point(12, 23);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(576, 48);
            this.labelRegistration.TabIndex = 12;
            this.labelRegistration.Text = "Регистрация";
            this.labelRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFirstName.Location = new System.Drawing.Point(180, 367);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(247, 24);
            this.textBoxFirstName.TabIndex = 25;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(15, 344);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(576, 20);
            this.labelFirstName.TabIndex = 24;
            this.labelFirstName.Text = "Имя";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxSecondName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSecondName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSecondName.Location = new System.Drawing.Point(180, 311);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(247, 24);
            this.textBoxSecondName.TabIndex = 27;
            // 
            // labelSecondName
            // 
            this.labelSecondName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSecondName.Location = new System.Drawing.Point(15, 288);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(576, 20);
            this.labelSecondName.TabIndex = 26;
            this.labelSecondName.Text = "Фамилия";
            this.labelSecondName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGroup
            // 
            this.labelGroup.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGroup.Location = new System.Drawing.Point(3, 5);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(253, 20);
            this.labelGroup.TabIndex = 28;
            this.labelGroup.Text = "Группа";
            this.labelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGroups.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(4, 37);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(250, 30);
            this.comboBoxGroups.TabIndex = 29;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto.Image = global::WinFormsAppTryingFitures.Properties.Resources.default_male_photo;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(15, 104);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 30;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(180, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 24);
            this.textBox1.TabIndex = 32;
            // 
            // labelThirdName
            // 
            this.labelThirdName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelThirdName.Location = new System.Drawing.Point(15, 401);
            this.labelThirdName.Name = "labelThirdName";
            this.labelThirdName.Size = new System.Drawing.Size(576, 20);
            this.labelThirdName.TabIndex = 31;
            this.labelThirdName.Text = "Отчество";
            this.labelThirdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(177, 480);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(247, 24);
            this.textBoxPhoneNumber.TabIndex = 34;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneNumber.Location = new System.Drawing.Point(12, 457);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(576, 20);
            this.labelPhoneNumber.TabIndex = 33;
            this.labelPhoneNumber.Text = "Номер телефона";
            this.labelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChoosingPost
            // 
            this.panelChoosingPost.BackColor = System.Drawing.Color.Gainsboro;
            this.panelChoosingPost.Controls.Add(this.panel1);
            this.panelChoosingPost.Controls.Add(this.comboBox1);
            this.panelChoosingPost.Location = new System.Drawing.Point(3, 510);
            this.panelChoosingPost.Name = "panelChoosingPost";
            this.panelChoosingPost.Size = new System.Drawing.Size(594, 10);
            this.panelChoosingPost.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(177, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 99);
            this.panel1.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Клиент",
            "Бухгалтер",
            "Преподаватель"});
            this.comboBox1.Location = new System.Drawing.Point(177, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 30);
            this.comboBox1.TabIndex = 38;
            // 
            // textBoxGroupPassword
            // 
            this.textBoxGroupPassword.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxGroupPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGroupPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGroupPassword.Location = new System.Drawing.Point(336, 43);
            this.textBoxGroupPassword.Name = "textBoxGroupPassword";
            this.textBoxGroupPassword.Size = new System.Drawing.Size(247, 24);
            this.textBoxGroupPassword.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(336, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Пароль группы";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRegistration
            // 
            this.panelRegistration.Controls.Add(this.buttonShowPostPanel);
            this.panelRegistration.Controls.Add(this.pictureBoxPhoto);
            this.panelRegistration.Controls.Add(this.labelRegistration);
            this.panelRegistration.Controls.Add(this.label1);
            this.panelRegistration.Controls.Add(this.panelChoosingPost);
            this.panelRegistration.Controls.Add(this.textBoxLogin);
            this.panelRegistration.Controls.Add(this.textBoxPhoneNumber);
            this.panelRegistration.Controls.Add(this.label2);
            this.panelRegistration.Controls.Add(this.labelPhoneNumber);
            this.panelRegistration.Controls.Add(this.label3);
            this.panelRegistration.Controls.Add(this.textBox1);
            this.panelRegistration.Controls.Add(this.textBoxPasswordRepeat);
            this.panelRegistration.Controls.Add(this.labelThirdName);
            this.panelRegistration.Controls.Add(this.textBoxPassword);
            this.panelRegistration.Controls.Add(this.pictureBoxShowPassword);
            this.panelRegistration.Controls.Add(this.radioButtonMale);
            this.panelRegistration.Controls.Add(this.textBoxSecondName);
            this.panelRegistration.Controls.Add(this.radioButtonFemale);
            this.panelRegistration.Controls.Add(this.labelSecondName);
            this.panelRegistration.Controls.Add(this.labelFirstName);
            this.panelRegistration.Controls.Add(this.textBoxFirstName);
            this.panelRegistration.Controls.Add(this.panelGroup);
            this.panelRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistration.Location = new System.Drawing.Point(0, 0);
            this.panelRegistration.Name = "panelRegistration";
            this.panelRegistration.Size = new System.Drawing.Size(600, 650);
            this.panelRegistration.TabIndex = 38;
            // 
            // buttonShowPostPanel
            // 
            this.buttonShowPostPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonShowPostPanel.FlatAppearance.BorderSize = 0;
            this.buttonShowPostPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowPostPanel.Location = new System.Drawing.Point(563, 479);
            this.buttonShowPostPanel.Name = "buttonShowPostPanel";
            this.buttonShowPostPanel.Size = new System.Drawing.Size(25, 25);
            this.buttonShowPostPanel.TabIndex = 38;
            this.buttonShowPostPanel.Text = "...";
            this.buttonShowPostPanel.UseVisualStyleBackColor = false;
            // 
            // panelGroup
            // 
            this.panelGroup.Controls.Add(this.labelGroup);
            this.panelGroup.Controls.Add(this.buttonAdd);
            this.panelGroup.Controls.Add(this.label4);
            this.panelGroup.Controls.Add(this.comboBoxGroups);
            this.panelGroup.Controls.Add(this.textBoxGroupPassword);
            this.panelGroup.Location = new System.Drawing.Point(3, 526);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(594, 121);
            this.panelGroup.TabIndex = 39;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 650);
            this.Controls.Add(this.panelRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.panelChoosingPost.ResumeLayout(false);
            this.panelRegistration.ResumeLayout(false);
            this.panelRegistration.PerformLayout();
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBoxShowPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPasswordRepeat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private RoundPictureBox pictureBoxPhoto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelThirdName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Panel panelChoosingPost;
        private System.Windows.Forms.TextBox textBoxGroupPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRegistration;
        private System.Windows.Forms.Button buttonShowPostPanel;
        private System.Windows.Forms.Panel panelGroup;
    }
}