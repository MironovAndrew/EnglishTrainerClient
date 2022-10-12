using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTryingFitures
{
    public partial class FormTheory : Form
    {
        public FormTheory(string grammarName, Image image, string grammarText)
        {
            InitializeComponent();


            labelName.Text = grammarName.ToUpper();
            labelName.Anchor = AnchorStyles.Top;

            pictureBoxPhoto.Image = image;
            pictureBoxPhoto.Anchor = AnchorStyles.Top;

            labelText.Text = grammarText;
            labelText.Anchor = AnchorStyles.Top;


            buttonBack.Click += (a, b) =>
            {
                panel1.Controls.Clear();

                FormTopics form = new FormTopics();
                form.TopLevel = false;

                panel1.Controls.Add(form);

                form.Show();
            };









            List<string> quastionList = new List<string>()
            {
                "I don't know the answer. How many times ____ to tell you?",
                "I don't know ____ so unhappy.",
                "Do you have any idea when ____?",
                "How many people ____ for the party?"
            };

            List<string> answersList = new List<string>()
            {
                "do I have",
                "why he is always",
                "will be the results published",
                "did you call"
            };






            buttonExercise.Click += (a, b) =>
            {
                panel1.Controls.Clear();

                FormExercise form = new FormExercise(quastionList, answersList);
                form.TopLevel = false;

                panel1.Tag = form;
                panel1.Controls.Add(form);

                form.Show();
            };






            panel1.Layout += (a, b) =>
            {
                int delta = 20;

                buttonBack.Location = new Point(delta, delta);

                buttonExercise.Location = new Point(delta, buttonBack.Location.Y + buttonBack.Height + delta);

                
                labelName.Location = new Point(this.Width / 2 - labelName.Width / 2,  delta);
                labelName.MaximumSize = new Size(panel1.Width, int.MaxValue);

                pictureBoxPhoto.Size = new Size(image.Width, image.Height);
                pictureBoxPhoto.Location = new Point(this.Width / 2 - pictureBoxPhoto.Width / 2, labelName.Location.Y + labelName.Height + delta);
                pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;

                labelText.Location = new Point(10, pictureBoxPhoto.Location.Y + pictureBoxPhoto.Height + delta);
                labelText.MaximumSize = new Size(panel1.Width - 2 * delta, int.MaxValue);

            };








            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;

        }
    }
}
