using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsAppTryingFitures
{
    public partial class FormSettingCards : Form
    {

        public FormSettingCards()
        {
            InitializeComponent();

            foreach (var control in panelSettings.Controls.OfType<Control>())
            {
                control.Click += (a, b) =>
                {
                    fillListView(changeCollections());
                };
            }


            buttonStart.Click += (a, b) =>
            {
                new FormShowingCards(changeCollections()).Show();
                Hide();
            };
        }


        Dictionary<string, string> changeCollections()
        {
            Dictionary<string, string> wordPhraseDictionary = new Dictionary<string, string>();



            if (radioButtonWords.Checked)
            {
                if (checkBoxIsFavorite.Checked)
                {
                    wordPhraseDictionary.Add("FAVORITEapple", "яблоко");
                    wordPhraseDictionary.Add("FAVORITEpear", "груша");
                    wordPhraseDictionary.Add("FAVORITEbear", "медвед");
                }
                else
                {
                    wordPhraseDictionary.Add("apple", "яблоко");
                    wordPhraseDictionary.Add("pear", "груша");
                    wordPhraseDictionary.Add("bear", "медвед");
                }
            }
            else
            {
                if (checkBoxIsFavorite.Checked)
                {
                    wordPhraseDictionary.Add("FAVORITEbe ok", "быть хорошо");
                    wordPhraseDictionary.Add("FAVORITElook for", "искать");
                    wordPhraseDictionary.Add("FAVORITEbe proud of", "быть гордым о");
                }
                else
                {
                    wordPhraseDictionary.Add("be ok", "быть хорошо");
                    wordPhraseDictionary.Add("look for", "искать");
                    wordPhraseDictionary.Add("be proud of", "быть гордым о");
                }
            }



            List<int> randomNumbersArray = new List<int>();

            for (int i = 0; i < wordPhraseDictionary.Count; i++)
            {
                randomNumbersArray.Add(new Random().Next());
            }



            return wordPhraseDictionary.OrderBy(x => new Random().Next()).ToDictionary(item => item.Key, item => item.Value);
        }


        void fillListView(Dictionary<string, string> dict)
        {
            listView.Items.Clear();

            ListViewItem listItem;

            foreach (var item in dict)
            {
                listItem = new ListViewItem(new String[] { item.Key, item.Value });

                listView.Items.Add(listItem);
            }

        }
    }
}
