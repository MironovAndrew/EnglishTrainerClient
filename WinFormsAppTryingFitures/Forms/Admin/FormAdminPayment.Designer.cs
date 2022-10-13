namespace WinFormsAppTryingFitures
{
    partial class FormAdminPayment
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderLogin = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFirstName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSecondName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDoubt = new System.Windows.Forms.ColumnHeader();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelDoubt = new System.Windows.Forms.Label();
            this.textBoxDoubt = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.labelSecondName);
            this.panel1.Controls.Add(this.textBoxSecondName);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.labelDoubt);
            this.panel1.Controls.Add(this.textBoxDoubt);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonErase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 566);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLogin,
            this.columnHeaderFirstName,
            this.columnHeaderSecondName,
            this.columnHeaderDoubt});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(747, 441);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderLogin
            // 
            this.columnHeaderLogin.Text = "Логин";
            this.columnHeaderLogin.Width = 150;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "Имя";
            this.columnHeaderFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderFirstName.Width = 150;
            // 
            // columnHeaderSecondName
            // 
            this.columnHeaderSecondName.Text = "Фамилия";
            this.columnHeaderSecondName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSecondName.Width = 150;
            // 
            // columnHeaderDoubt
            // 
            this.columnHeaderDoubt.Text = "Задолжность";
            this.columnHeaderDoubt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDoubt.Width = 150;
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSecondName.Location = new System.Drawing.Point(162, 467);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(99, 22);
            this.labelSecondName.TabIndex = 5;
            this.labelSecondName.Text = "Фамилия";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSecondName.Location = new System.Drawing.Point(162, 492);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(220, 30);
            this.textBoxSecondName.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(405, 467);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(65, 22);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogin.Location = new System.Drawing.Point(405, 492);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(220, 30);
            this.textBoxLogin.TabIndex = 8;
            // 
            // labelDoubt
            // 
            this.labelDoubt.AutoSize = true;
            this.labelDoubt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDoubt.Location = new System.Drawing.Point(31, 444);
            this.labelDoubt.Name = "labelDoubt";
            this.labelDoubt.Size = new System.Drawing.Size(83, 22);
            this.labelDoubt.TabIndex = 6;
            this.labelDoubt.Text = "Сумма";
            // 
            // textBoxDoubt
            // 
            this.textBoxDoubt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDoubt.Location = new System.Drawing.Point(31, 469);
            this.textBoxDoubt.Name = "textBoxDoubt";
            this.textBoxDoubt.Size = new System.Drawing.Size(125, 30);
            this.textBoxDoubt.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(30, 505);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonErase
            // 
            this.buttonErase.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonErase.Location = new System.Drawing.Point(30, 542);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(126, 30);
            this.buttonErase.TabIndex = 4;
            this.buttonErase.Text = "-";
            this.buttonErase.UseVisualStyleBackColor = true;
            // 
            // FormAdminPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(747, 566);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdminPayment";
            this.Text = "FormAdminPayment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderLogin;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderSecondName;
        private System.Windows.Forms.ColumnHeader columnHeaderDoubt;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxDoubt;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labelDoubt;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
    }
}