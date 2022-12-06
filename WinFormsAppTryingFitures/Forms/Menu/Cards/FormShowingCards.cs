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
    public partial class FormShowingCards : Form
    {
        public FormShowingCards(Dictionary<string, string> dict)
        {
            InitializeComponent();

            int questionNumber = 0;
            int rightAnswers = 0;


            ButtonShow.Text = getQuestionAnswer(dict, questionNumber).english;


            ButtonShow.Click += (a, b) =>
            {


                if (textBoxAnswer.Text == getQuestionAnswer(dict, questionNumber).russian)
                {
                    rightAnswers++;
                }
                else
                {
                    MessageBox.Show($"Неверно!\n{getQuestionAnswer(dict, questionNumber).english} = {getQuestionAnswer(dict, questionNumber).russian}");
                }

                ++questionNumber;
                labelScore.Text = $"{rightAnswers}/{questionNumber +1}";


                ButtonShow.Text = getQuestionAnswer(dict, questionNumber).english;
            };
        }


        (string english, string russian) getQuestionAnswer(Dictionary<string, string> dict, int index)
        {
            string english = "";
            string russian = "";


            if (index < dict.Count)
            {
                english = dict.Keys.ElementAt(index);
                russian = dict.Values.ElementAt(index);
            }
            else
            {
                MessageBox.Show("Game over");
                new FormSettingCards().Show();
                this.Hide();
            }


            return (english, russian);

        }
    }
}
