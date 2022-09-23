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
        public FormForum(string login, PictureBox pb)
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["connection_string_user"].ConnectionString;

            showComments();

            labelName.Text = login;
            pictureBox1.Image = pb.Image;


            #region События кнопок для форума
            pictureBoxUpdate.Click += (a, b) => showComments();

            buttonPost.Click += (a, b) =>
            {
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                DateTime dateTimeNow = DateTime.Now;

                SqlCommand command = new SqlCommand("INSERT INTO comments (person, comment, date) VALUES (@person, @comment, @date)", connection);
                command.Parameters.AddWithValue("person", login);
                command.Parameters.AddWithValue("comment", textBox1.Text);
                command.Parameters.AddWithValue("date", dateTimeNow);

                try
                {
                    command.ExecuteNonQuery();
                    showComments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            };
            #endregion



        }


        void showComments()
        {
            listView1.Items.Clear();




            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($"SELECT * FROM students, comments WHERE comments.person = students.Login", connection);
            //  SqlCommand command = new SqlCommand($"SELECT students.Photo, students.Login, comments.comment, comments.date FROM students, comments WHERE comments.person = students.Login", connection);


            SqlDataReader dataReader = command.ExecuteReader();

            ListViewItem item = null;

            while (dataReader.Read())
            {

                #region ---ОПЫТЫ--- изображение
                PictureBox pictureBoxFromDB = new PictureBox();

                if (dataReader.HasRows && dataReader["Photo"] != DBNull.Value)
                {

                    byte[] image = (byte[])(dataReader["Photo"]);

                    if (image == null)
                    {
                        pictureBoxFromDB = null;
                    }
                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(image);
                        pictureBox2.Image = Image.FromStream(memoryStream);
                    }
                }
                else
                {
                    if (Convert.ToString(dataReader["Gender"]) == "m")
                    {
                        pictureBox2.Image = Properties.Resources.default_male_photo;
                    }
                    else
                    {
                        pictureBox2.Image = Properties.Resources.default_female_photo;
                    }
                }
                #endregion




                item = new ListViewItem(
                    new String[]
                    {
                        Convert.ToString(dataReader["Login"]),
                        Convert.ToString(dataReader["comment"]),
                        Convert.ToString(dataReader["date"])
                    });

                listView1.Items.Add(item);
            }






        }



        void showPanels(int count, PictureBox[] pictureBoxesList, string[] namesList, string[] commentsList, DateTime[] dateTimesList)
        {

            #region Объявление

            Panel panelComment;
            PictureBox pictureBoxAvatar;
            Label labelName;
            Label labelComment;
            Label labelDate;

            #endregion




            for (int i = 0; i < 50; i++)
            {
                #region Инициализация

                panelComment = new Panel();
                pictureBoxAvatar = new PictureBox();
                labelName = new Label();
                labelComment = new Label();
                labelDate = new Label();

                // panelComment.SuspendLayout();
                // ((ISupportInitialize)(pictureBoxAvatar)).BeginInit();
                // this.SuspendLayout();

                #endregion



                #region pictureBoxAvatar

                //pictureBoxAvatar.Image = pictureBoxesList[i].Image;
                pictureBoxAvatar.Image = Properties.Resources.default_female_photo;
                pictureBoxAvatar.Location = new Point(1, 1);
                pictureBoxAvatar.Size = new Size(100, 100);
                pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;

                #endregion





                #region  labelName

                labelName.AutoSize = true;
                labelName.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic);
                labelName.Location = new Point(108, 9);
                labelName.Size = new Size(206, 24);
                labelName.Text = "Алёна";
                //labelName.Text = namesList[i];
                #endregion






                #region  labelComment

                labelComment.Font = new Font("Century Gothic", 9.75F);
                labelComment.Location = new Point(108, 42);
                labelComment.Text = "Комментарий мой, да!";
                //labelComment.Text = commentsList[i];
                labelComment.AutoSize = true;
                labelComment.MaximumSize = new Size(700, labelComment.Text.Length);

                #endregion






                #region labelDate

                labelDate.AutoSize = true;
                labelDate.Font = new Font("Century Gothic", 9.75F);
                labelDate.Location = new Point(570, 2);
                labelDate.Size = new Size(220, 17);
                labelDate.Text = DateTime.Now.ToString();
                //labelDate.Text = Convert.ToString(dateTimesList[i]);

                #endregion






                #region PanelComment

                panelComment.BackgroundImageLayout = ImageLayout.Tile;
                panelComment.Controls.Add(labelDate);
                panelComment.Controls.Add(labelComment);
                panelComment.Controls.Add(labelName);
                panelComment.Controls.Add(pictureBoxAvatar);




                int delta = 45;

                panelComment.Location = new Point(25, 25+(labelComment.Height + labelDate.Height + labelName.Height + 25 + delta) * i);

                panelComment.Size = new Size(panel1.Width - 50, labelComment.Height + labelDate.Height + labelName.Height + delta);



                panelComment.BackColor = Color.Orange;

                #endregion




                #region Возобновляем

                // panelComment.ResumeLayout(false);
                // panelComment.PerformLayout();
                // ((ISupportInitialize)(pictureBoxAvatar)).EndInit();
                // this.ResumeLayout(false);

                #endregion


                panel1.Controls.Add(panelComment);


                typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true });

            }
        }

        private void panel1_Layout(object sender, LayoutEventArgs e)
        {
            showPanels(0, null, null, null, null);
        }
    }
}
