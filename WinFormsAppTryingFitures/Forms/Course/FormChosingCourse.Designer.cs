namespace WinFormsAppTryingFitures
{
    partial class FormChosingCourse
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
            this.panelShowingCourses = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChoseCourses = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShowingCourses
            // 
            this.panelShowingCourses.BackColor = System.Drawing.Color.White;
            this.panelShowingCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowingCourses.Location = new System.Drawing.Point(0, 0);
            this.panelShowingCourses.Name = "panelShowingCourses";
            this.panelShowingCourses.Size = new System.Drawing.Size(600, 628);
            this.panelShowingCourses.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.buttonChoseCourses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 72);
            this.panel1.TabIndex = 1;
            // 
            // buttonChoseCourses
            // 
            this.buttonChoseCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChoseCourses.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonChoseCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoseCourses.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChoseCourses.Location = new System.Drawing.Point(175, 20);
            this.buttonChoseCourses.Name = "buttonChoseCourses";
            this.buttonChoseCourses.Size = new System.Drawing.Size(250, 31);
            this.buttonChoseCourses.TabIndex = 21;
            this.buttonChoseCourses.Text = "Выбрать курсы";
            this.buttonChoseCourses.UseVisualStyleBackColor = false;
            // 
            // FormChosingCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelShowingCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChosingCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChosingCourse";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShowingCourses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonChoseCourses;
    }
}