using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsAppTryingFitures
{
    public partial class FormMenu : Form
    {

        List<Button> btnsList;
        string firstSecondName;

        public FormMenu(string firstSecondName, string login, PictureBox pb)
        {
            InitializeComponent();

            this.firstSecondName = firstSecondName;

            labelTest.Text = $"Добрый день, {firstSecondName}";
            pictureBoxPhoto.Image = pb.Image;


            //Добавляем кнопки в список напрямую, потому что при размещении кнопок на панели к ним нельзя
            //обращаться через foreach( )
            btnsList = new List<Button>()
            {
                buttonAccount,buttonData,buttonTranslator,buttonTrainer
            };


            #region События кнопок для меню
            buttonAccount.Click += (a, b) => { FormOnPanel.Show(panelShowForm, new FormAccount()); };
            buttonData.Click += (a, b) => { FormOnPanel.Show(panelShowForm, new FormMap()); };
            buttonForum.Click += (a, b) => { FormOnPanel.Show(panelShowForm, new FormForum(firstSecondName, login, pb)); };
            buttonTopics.Click += (a, b) => { FormOnPanel.Show(panelShowForm, new FormTopics()); };
            #endregion


        }


    }
}
