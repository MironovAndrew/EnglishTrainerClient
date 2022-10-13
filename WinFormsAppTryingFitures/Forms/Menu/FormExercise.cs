using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppTryingFitures.CustomClasses;

namespace WinFormsAppTryingFitures
{
    public partial class FormExercise : Form
    {
        public FormExercise(List<string> quastionList, List<string> answersList)
        {
            InitializeComponent();



            int questionNumber = 0;
            int delta = 20;
            int score = 0;





            List<int> randomNumbersArray = new List<int>();



            for (int i = 0; i < quastionList.Count; i++)
            {
                randomNumbersArray.Add(new Random().Next());
            }







            int indexArray = 0;
            quastionList = quastionList.OrderBy(x => randomNumbersArray[indexArray++]).ToList();

            indexArray = 0;
            answersList = answersList.OrderBy(x => randomNumbersArray[indexArray++]).ToList();





            panel1.Layout += (a, b) =>
            {
                layoutControlls();
            };





            buttonAnswer.Click += async (a, b) =>
            {

                if (textBoxAnswer.Text.ToUpper() == answersList[questionNumber].ToUpper())
                {
                    score += 20;
                }
                else
                {
                    CustomMessageBox.Show($"Неверно!\nВопрос: {quastionList[questionNumber]}\nПравильный ответ: {answersList[questionNumber]}");
                }



                questionNumber++;



                if (questionNumber == quastionList.Count)
                {

                    CustomMessageBox.Show("Конец!");


                    textBoxAnswer.Enabled = false;
                    buttonAnswer.Enabled = false;

                    questionNumber = 0;

                    for (int i = 3; i > 0; i--)
                    {
                        textBoxAnswer.Text = $"Переход через {i} сек.";
                        await Task.Delay(1000);
                    }




                    FormOnPanel.Show(panel1, new FormTopics());





                    //panel1.Controls.Clear();

                    //FormTopics form = new FormTopics();
                    //form.TopLevel = false;

                    //panel1.Tag = form;
                    //panel1.Controls.Add(form);

                    //form.Show();

                }
                else
                {
                    layoutControlls();
                }


                textBoxAnswer.Text = "";
            };



            void layoutControlls()
            {

                labelQuestionNumber.Text = $"{questionNumber + 1}/{quastionList.Count}";
                labelQuestion.Text = quastionList[questionNumber];
                labelScore.Text = $"Счёт: {score}";



                labelQuestionNumber.Location = new Point(delta, delta);
                labelQuestionNumber.Anchor = AnchorStyles.Top;

                labelQuestion.Location = new Point(this.Width / 2 - labelQuestion.Width / 2, labelQuestionNumber.Location.Y + labelQuestionNumber.Height + delta);
                labelQuestion.MaximumSize = new Size(panel1.Width - delta, int.MaxValue);
                labelQuestion.Anchor = AnchorStyles.Top;

                textBoxAnswer.Location = new Point(delta, labelQuestion.Location.Y + labelQuestion.Height + delta);
                textBoxAnswer.Size = new Size(panel1.Width - 2 * delta, textBoxAnswer.Height);
                textBoxAnswer.Anchor = AnchorStyles.Top;

                labelScore.Location = new Point(this.Width - labelScore.Width - delta,delta);
                labelScore.Anchor = AnchorStyles.Top;

                buttonAnswer.Location = new Point(this.Width - buttonAnswer.Width - delta, textBoxAnswer.Location.Y + textBoxAnswer.Height + delta);
                buttonAnswer.Anchor = AnchorStyles.Top;


            }






        }
    }
}
