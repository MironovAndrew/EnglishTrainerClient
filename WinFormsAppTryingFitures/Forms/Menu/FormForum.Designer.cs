namespace WinFormsAppTryingFitures
{
    partial class FormForum
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelComment = new System.Windows.Forms.Label();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.pictureBoxOwnPhoto = new WinFormsAppTryingFitures.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwnPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(126, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(156, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Фамилия Имя";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(126, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(721, 26);
            this.textBox1.TabIndex = 3;
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPost.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPost.Location = new System.Drawing.Point(865, 77);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(171, 35);
            this.buttonPost.TabIndex = 4;
            this.buttonPost.Text = "Комментировать";
            this.buttonPost.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 173);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25, 25, 25, 20);
            this.panel1.Size = new System.Drawing.Size(1058, 487);
            this.panel1.TabIndex = 5;
            // 
            // labelComment
            // 
            this.labelComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComment.Location = new System.Drawing.Point(449, 127);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(161, 24);
            this.labelComment.TabIndex = 6;
            this.labelComment.Text = "Комментарии";
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUpdate.Image = global::WinFormsAppTryingFitures.Properties.Resources.update;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(1001, 12);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpdate.TabIndex = 7;
            this.pictureBoxUpdate.TabStop = false;
            // 
            // pictureBoxOwnPhoto
            // 
            this.pictureBoxOwnPhoto.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxOwnPhoto.Name = "pictureBoxOwnPhoto";
            this.pictureBoxOwnPhoto.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxOwnPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOwnPhoto.TabIndex = 8;
            this.pictureBoxOwnPhoto.TabStop = false;
            // 
            // FormForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(1058, 660);
            this.Controls.Add(this.pictureBoxOwnPhoto);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForum";
            this.Text = "FormForum";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwnPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private RoundPictureBox pictureBoxOwnPhoto;
    }
}