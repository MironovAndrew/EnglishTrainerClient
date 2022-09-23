using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
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
    }
}
