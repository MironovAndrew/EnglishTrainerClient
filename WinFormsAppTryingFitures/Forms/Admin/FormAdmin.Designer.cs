namespace WinFormsAppTryingFitures
{
    partial class FormAdmin
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonWords = new System.Windows.Forms.Button();
            this.buttonBranches = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonTheory = new System.Windows.Forms.Button();
            this.panelShowForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Green;
            this.panelMenu.Controls.Add(this.buttonWords);
            this.panelMenu.Controls.Add(this.buttonBranches);
            this.panelMenu.Controls.Add(this.buttonPayment);
            this.panelMenu.Controls.Add(this.buttonTheory);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1149, 80);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonWords
            // 
            this.buttonWords.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonWords.FlatAppearance.BorderSize = 0;
            this.buttonWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWords.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonWords.Location = new System.Drawing.Point(480, 0);
            this.buttonWords.Name = "buttonWords";
            this.buttonWords.Size = new System.Drawing.Size(160, 80);
            this.buttonWords.TabIndex = 4;
            this.buttonWords.Text = "Слова";
            this.buttonWords.UseVisualStyleBackColor = true;
            // 
            // buttonBranches
            // 
            this.buttonBranches.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBranches.FlatAppearance.BorderSize = 0;
            this.buttonBranches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBranches.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBranches.Location = new System.Drawing.Point(320, 0);
            this.buttonBranches.Name = "buttonBranches";
            this.buttonBranches.Size = new System.Drawing.Size(160, 80);
            this.buttonBranches.TabIndex = 3;
            this.buttonBranches.Text = "Филиалы";
            this.buttonBranches.UseVisualStyleBackColor = true;
            // 
            // buttonPayment
            // 
            this.buttonPayment.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPayment.FlatAppearance.BorderSize = 0;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPayment.Location = new System.Drawing.Point(160, 0);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(160, 80);
            this.buttonPayment.TabIndex = 2;
            this.buttonPayment.Text = "Задолжности";
            this.buttonPayment.UseVisualStyleBackColor = true;
            // 
            // buttonTheory
            // 
            this.buttonTheory.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTheory.FlatAppearance.BorderSize = 0;
            this.buttonTheory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTheory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTheory.Location = new System.Drawing.Point(0, 0);
            this.buttonTheory.Name = "buttonTheory";
            this.buttonTheory.Size = new System.Drawing.Size(160, 80);
            this.buttonTheory.TabIndex = 1;
            this.buttonTheory.Text = "Теория";
            this.buttonTheory.UseVisualStyleBackColor = true;
            // 
            // panelShowForm
            // 
            this.panelShowForm.BackColor = System.Drawing.Color.ForestGreen;
            this.panelShowForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowForm.Location = new System.Drawing.Point(0, 80);
            this.panelShowForm.Name = "panelShowForm";
            this.panelShowForm.Size = new System.Drawing.Size(1149, 620);
            this.panelShowForm.TabIndex = 1;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 700);
            this.Controls.Add(this.panelShowForm);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonWords;
        private System.Windows.Forms.Button buttonBranches;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button buttonTheory;
        private System.Windows.Forms.Panel panelShowForm;
    }
}