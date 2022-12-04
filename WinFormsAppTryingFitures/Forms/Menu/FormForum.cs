using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTryingFitures
{


    public partial class FormForum : Form
    {
        public FormForum()
        {
            InitializeComponent();
        }

        string connectionString;
        SqlConnection connection;
        SqlCommand command;


        public FormForum(string firstSecondName,string login, PictureBox pb)
        {
            InitializeComponent();


            connectionString = ConfigurationManager.ConnectionStrings["connection_string_user"].ConnectionString;

            showComments();

            labelName.Text = firstSecondName;
            pictureBoxOwnPhoto.Image = pb.Image;


            #region События кнопок для форума
            pictureBoxUpdate.Click += (a, b) => showComments();

            buttonPost.Click += (a, b) =>
            {

                panel1.Controls.Clear();








                connection = new SqlConnection(connectionString);

                connection.Open();

                DateTime dateTimeNow = DateTime.Now;

                command = new SqlCommand("INSERT INTO comments (user_login, comment, date) VALUES (@user_login, @comment, @date)", connection);
                command.Parameters.AddWithValue("user_login", login);
                command.Parameters.AddWithValue("comment", textBox1.Text);
                command.Parameters.AddWithValue("date", dateTimeNow);


                try
                {
                    command.ExecuteNonQuery();

                    showComments();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);

                    CustomMessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();

                    textBox1.Text = "";
                }

            };


            #endregion


        }

        PictureBox pictureBoxExtra = new PictureBox();
        int count = 0;
        void showComments()
        {
            #region Обнуление

            dateTimesList = new List<DateTime>();
            namesList = new List<string>();
            commentsList = new List<string>();
            photosList = new List<Image>();

            count = 0;
            #endregion


            connection = new SqlConnection(connectionString);
            connection.Open();

            command = new SqlCommand($"SELECT * FROM students, comments WHERE comments.user_login = students.login", connection);


            SqlDataReader dataReader = command.ExecuteReader();

            ListViewItem item = null;

            while (dataReader.Read())
            {
                string base64FromDataBase = Convert.ToString(dataReader["photo"]);


                if (base64FromDataBase.Length > 0)
                {

                    Image image = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64FromDataBase)));

                    pictureBoxExtra.Image = image;

                }
                else
                {

                    if (Convert.ToString(dataReader["gender"]) == "m")
                    {
                        pictureBoxExtra.Image = Properties.Resources.default_male_photo;
                    }
                    else
                    {
                        pictureBoxExtra.Image = Properties.Resources.default_female_photo;
                    }
                }


                photosList.Add(pictureBoxExtra.Image);



























                #region Добавление имён, фото, коментов в массивы
                item = new ListViewItem(
                    new String[]
                    {
                        Convert.ToString(dataReader["Login"]),
                        Convert.ToString(dataReader["comment"]),
                        Convert.ToString(dataReader["date"])
                    });
                            
                //namesList.Add(Convert.ToString(dataReader["Login"]));
                namesList.Add(Convert.ToString(dataReader["second_name"]) + " " + Convert.ToString(dataReader["first_name"]));
                commentsList.Add(Convert.ToString(dataReader["comment"]));
                dateTimesList.Add(Convert.ToDateTime(dataReader["date"]));

                count++;
                #endregion
            }

            showPanels();

        }





        List<string> namesList;
        List<string> commentsList;
        List<Image> photosList;
        List<DateTime> dateTimesList;

        void showPanels()
        {
            #region Объявление

            Panel panelComment;
            //PictureBox pictureBoxAvatar;
            RoundPictureBox pictureBoxAvatar;
            Label labelName;
            Label labelComment;
            Label labelDate;


            int coordinateY = 20;

            #endregion




            for (int i = 0; i < count; i++)
            {
                #region Инициализация

                panelComment = new Panel();
                //pictureBoxAvatar = new PictureBox();
                pictureBoxAvatar = new RoundPictureBox();
                labelName = new Label();
                labelComment = new Label();
                labelDate = new Label();

                #endregion



                #region pictureBoxAvatar

                pictureBoxAvatar.Image = photosList[i];
                //pictureBoxAvatar.Image = Properties.Resources.default_female_photo;
                pictureBoxAvatar.Location = new Point(0, 0);
                pictureBoxAvatar.Size = new Size(100, 100);
                pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;

                #endregion





                #region  labelName

                labelName.AutoSize = true;
                labelName.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic);
                labelName.Location = new Point(108, 9);
                labelName.Size = new Size(206, 24);
                //labelName.Text = "Алёна";
                labelName.Text = namesList[i];
                #endregion






                #region  labelComment

                labelComment.Font = new Font("Century Gothic", 9.75F);
                labelComment.Location = new Point(108, 42);
                //labelComment.Text = "Комментарий мой, да!";
                labelComment.Text = Convert.ToString(commentsList[i]);
                labelComment.AutoSize = true;
                //labelComment.MaximumSize = new Size(panelComment.Width, int.MaxValue);
                labelComment.MaximumSize = new Size(panel1.Width - 200, int.MaxValue);

                #endregion






                #region labelDate

                labelDate.AutoSize = true;
                labelDate.Font = new Font("Century Gothic", 9.75F);
                labelDate.Location = new Point(panel1.Size.Width - panelComment.Size.Width - 75, 2);
                labelDate.Size = new Size(220, 17);
                //labelDate.Text = DateTime.Now.ToString();
                labelDate.Text = $"Отправлено в {Convert.ToDateTime(dateTimesList[i]).ToString()}";

                #endregion




                

                panelComment.BackgroundImageLayout = ImageLayout.None;
                panelComment.Controls.Add(labelDate);
                panelComment.Controls.Add(labelComment);
                panelComment.Controls.Add(labelName);
                panelComment.Controls.Add(pictureBoxAvatar);




                int delta = 45;



                panelComment.Size = new Size(panel1.Width - 50, labelComment.Height + labelDate.Height + labelName.Height + delta);




                panelComment.Location = new Point(25, coordinateY);
               
                coordinateY += panelComment.Height + delta - 20;





                panelComment.BackColor = Color.Gainsboro;

                panel1.Controls.Add(panelComment);


                typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true });

            }


            panel1.AutoScrollPosition = new Point(0,int.MaxValue);
        }

    }
}
