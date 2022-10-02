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
    public partial class FormMenu : Form
    {

        List<Button> btnsList;
        string firstSecondName;

        public FormMenu(string firstSecondName,string login, PictureBox pb)
        {
            InitializeComponent();

            this.firstSecondName = firstSecondName;

            labelTest.Text = $"Добрый день, {firstSecondName}";
            pictureBoxPhoto.Image = pb.Image;

            #region ---ОПЫТЫ---     Обработка события через foreach( )

            //Добавляем кнопки в список напрямую, потому что при размещении кнопок на панели к ним нельзя
            //обращаться через foreach( )
            btnsList = new List<Button>()
            {
                buttonAccount,buttonData,buttonInfo,buttonTrainer
            };

            //foreach (Button btn in btnsList)
            //{
            //    btn.Click += (a, b) =>
            //    {
            //        MessageBox.Show(btn.Name);
            //    };
            //}

            #endregion


            #region События кнопок для меню
            buttonAccount.Click += (a, b) => { showForm(new FormAccount()); };
            buttonData.Click += (a, b) => { showForm(new FormMap()); };
            buttonInfo.Click += (a, b) => { showForm(new FormInfo()); };
            buttonTrainer.Click += (a, b) => { showForm(new FormTrainer()); };
            buttonForum.Click += (a, b) => { showForm(new FormForum(firstSecondName, login, pb)); };
            #endregion



        }

        void showForm(Form selectedForm, string login = null, PictureBox pictureBox = null)
        {
            panelMenu.Focus();

            panelShowForm.Controls.Clear();
            
            Form form = selectedForm;
            form.TopLevel = false;

            panelShowForm.Tag = form;
            form.Size = new Size(panelShowForm.Width,panelShowForm.Height);
            panelShowForm.Controls.Add(form);

            form.Show();
        }

    }
}
