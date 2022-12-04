using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTryingFitures
{
    public partial class FormChosingCourse : Form
    {
        List<Panel> coursePanelsList;
        public FormChosingCourse()
        {
            InitializeComponent();




            //panelShowingCourses.AutoScrollPosition = new Point(0, int.MaxValue);




            string[] courseNamesArray = new string[]
            {
            "Биология",
            "Программирование",
            "Философия",
            "География",
            "Автомобили",
            "Биология",
            };

            string[] courseDescriptionArray = new string[]
            {
            "Изучайте биологию! И всё что с ней связано. Это классно" +
            "Изучайте биологию! И всё что с ней связано. Это классно" +
            "Изучайте биологию! И всё что с ней связано. Это классно"+
            "Изучайте биологию! И всё что с ней связано. Это классно" +
            "Изучайте биологию! И всё что с ней связано. Это классно" +
            "Изучайте биологию! И всё что с ней связано. Это классно",

            "Нравится программирование? Всему научим! Присоединяйся!" +
            "Нравится программирование? Всему научим! Присоединяйся!" +
            "Нравится программирование? Всему научим! Присоединяйся!",

            "Изучайте Философия! И всё что с ней связано. Это классно" +
            "Изучайте Философия! И всё что с ней связано. Это классно" +
            "Изучайте Философия! И всё что с ней связано. Это классно",


            "Нравится География? Всему научим! Присоединяйся!" +
            "Нравится География? Всему научим! Присоединяйся!" +
            "Нравится География? Всему научим! Присоединяйся!",

            "Изучайте Автомобили! И всё что с ней связано. Это классно" +
            "Изучайте Автомобили! И всё что с ней связано. Это классно" +
            "Изучайте Автомобили! И всё что с ней связано. Это классно",

            "Изучайте биологию! И всё что с ней связано. Это классно" +
            "Изучайте биологию! И всё что с ней связано. Это классно" +
            "Изучайте биологию! И всё что с ней связано. Это классно"
            };

            coursePanelsList = new List<Panel>();



            showCoursePanels(courseNamesArray, courseDescriptionArray, new PictureBox[] { });



            buttonChoseCourses.Click += (a, b) =>
            {
                string chosenCourses = "";

                for (int i = 0; i < coursePanelsList.Count; i++)
                {
                    CheckBox checkBox = coursePanelsList[i].Controls.OfType<CheckBox>().ToList()[0];

                    if (checkBox.Checked)
                    {
                        chosenCourses += checkBox.Tag + "\n";
                    }
                }

                if(chosenCourses == "")
                {
                    CustomMessageBox.Show("Выберите не менее 1 курса!");
                }
                else
                {
                MessageBox.Show(chosenCourses);
                }
            };


            panelShowingCourses.AutoScroll = false;
            panelShowingCourses.HorizontalScroll.Enabled = false;
            panelShowingCourses.HorizontalScroll.Visible = false;
            panelShowingCourses.HorizontalScroll.Maximum = 0;
            panelShowingCourses.AutoScroll = true;

        }

        void showCoursePanels(string[] courseNamesArray, string[] courseDescriptionArray, PictureBox[] coursePhotosArray)
        {

            #region Объявление


            Panel panelCourse;
            RoundPictureBox pictureBoxCourse;
            Label labelCourseName;
            Label labelcourseDescription;
            CheckBox checkBoxChoose;


            int coordinateY = 20;

            #endregion




            int courseNumber = courseNamesArray.Length;

            for (int i = 0; i < courseNumber; i++)
            {
                #region Инициализация

                panelCourse = new Panel();
                pictureBoxCourse = new RoundPictureBox();
                labelCourseName = new Label();
                labelcourseDescription = new Label();
                checkBoxChoose = new CheckBox();

                #endregion



                #region pictureBoxAvatar

                pictureBoxCourse.Image = Properties.Resources.default_female_photo;
                pictureBoxCourse.Location = new Point(0, 0);
                pictureBoxCourse.Size = new Size(100, 100);
                pictureBoxCourse.SizeMode = PictureBoxSizeMode.StretchImage;

                #endregion





                #region  labelName

                labelCourseName.AutoSize = true;
                labelCourseName.Font = new Font("Century Gothic", 14F, FontStyle.Italic);
                labelCourseName.Location = new Point(108, 9);
                labelCourseName.Size = new Size(206, 24);
                labelCourseName.Text = courseNamesArray[i];
                #endregion






                #region  labelComment

                labelcourseDescription.Font = new Font("Century Gothic", 9.75F);
                labelcourseDescription.Location = new Point(108, 42);
                labelcourseDescription.Text = Convert.ToString(courseDescriptionArray[i]);
                labelcourseDescription.AutoSize = true;
                labelcourseDescription.MaximumSize = new Size(panelShowingCourses.Width - 200, int.MaxValue);

                #endregion










                #region  
                checkBoxChoose.Size = new Size(90, 30);
                checkBoxChoose.Font = new Font("Century Gothic", 9.75F);
                checkBoxChoose.Location = new Point(15, panelCourse.Size.Height + 5);
                checkBoxChoose.Text = "Добавить";
                checkBoxChoose.FlatStyle = FlatStyle.Flat;
                checkBoxChoose.Tag = courseNamesArray[i];

                #endregion





                panelCourse.BackgroundImageLayout = ImageLayout.None;
                panelCourse.Controls.Add(checkBoxChoose);
                panelCourse.Controls.Add(labelcourseDescription);
                panelCourse.Controls.Add(labelCourseName);
                panelCourse.Controls.Add(pictureBoxCourse);
                coursePanelsList.Add(panelCourse);







                int delta = 45;
                panelCourse.Size = new Size(panelShowingCourses.Width - 50, labelcourseDescription.Height /*+ labelDate.Height*/ + labelCourseName.Height + delta);
                panelCourse.Location = new Point(25, coordinateY);
                coordinateY += panelCourse.Height + delta - 20;
                panelCourse.BackColor = Color.Gainsboro;
                panelShowingCourses.Controls.Add(panelCourse);



                typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panelShowingCourses, new object[] { true });



            }





        }
    }
}
