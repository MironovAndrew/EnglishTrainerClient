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
    public partial class FormShowMessage : Form
    {
        public FormShowMessage(string message)
        {
            InitializeComponent();


            labelMessage.Text = message;


            labelMessage.MaximumSize = new Size(this.Width, Screen.PrimaryScreen.WorkingArea.Height);

            this.Size = new Size(this.Size.Width, labelMessage.Size.Height);













            //Начальное положение формы задаётся вручную
            this.StartPosition = FormStartPosition.Manual;
            //Верхний левый угол экрана
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;
            //Перенос в нижний правый угол экрана без панели задач
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            //Перенос в местоположение верхнего левого угла формы, чтобы её правый нижний угол попал в правый нижний угол экрана
            pt.Offset(-this.Width, -this.Height);
            //Новое положение формы
            this.Location = pt;





            formDisappearance();
        }

        async void formDisappearance()
        {


            for (Opacity = 0; Opacity  < 1; Opacity+=0.01)
            {
                await Task.Delay(1);
            }



            await Task.Delay(2000);




            for (Opacity = 1; Opacity > .01; Opacity -= 0.01)
            {
                await Task.Delay(30);
            }

            Close();
        }

    }
}
