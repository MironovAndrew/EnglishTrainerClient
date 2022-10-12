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
    public partial class FormTopics : Form
    {
        public FormTopics()
        {
            InitializeComponent();


            int coordinateY = 30;
            int delta = 30;
            for (int i = 0; i < grammarNameList.Count; i++)
            {
                Label label = new Label();

                label.AutoSize = true;
                label.Font = new Font("Century Gothic", 14.25F);

                label.ForeColor = Color.Red;
                label.Cursor = Cursors.Hand;
                label.Text = grammarNameList[i];

                label.Anchor = AnchorStyles.Top;

                label.Tag = i;

                label.MaximumSize = new Size(panel1.Width - 2 * delta, int.MaxValue);
                label.Location = new Point(delta, coordinateY);
                coordinateY += delta;

                label.Click += (a, b) =>
                {
                    int count = Convert.ToInt32(label.Tag);

                    panel1.Controls.Clear();

                    FormTheory form = new FormTheory(grammarNameList[count], grammarPicturesList[count], grammarTextsList[count]);


                    form.TopLevel = false;

                    panel1.Controls.Add(form);

                    form.Show();
                    

                };



                panel1.Controls.Add(label);

            }



            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
        }




        List<string> grammarNameList = new List<string>()
        {
            "Recent past actions (just, already, yet)",
            "so + adjective or adverb + (that)",
            "Second and third conditionals",
            "I wish"
        };

        List<Image> grammarPicturesList = new List<Image>()
        {
            Properties.Resources.q1,
            Properties.Resources.q2,
            Properties.Resources.q3,
            Properties.Resources.q4,
        };

        List<string> grammarTextsList = new List<string>()
        {
          Properties.Resources.question1,
          Properties.Resources.question2,
          Properties.Resources.question3,
          Properties.Resources.question4,

        };










    }
}
