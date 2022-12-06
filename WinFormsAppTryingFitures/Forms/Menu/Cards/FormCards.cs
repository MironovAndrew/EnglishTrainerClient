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
    public partial class FormCards : Form
    {
        Dictionary<string, string> wordPhraseDictionary;

        public FormCards(Dictionary<string,string> wordPhraseDictionary)
        {
            InitializeComponent();

            this.wordPhraseDictionary = wordPhraseDictionary;

            string words = "";

            foreach (var word in wordPhraseDictionary)
            {
                words += word + "\n";
            }

            MessageBox.Show(words);
        }


    }
}
