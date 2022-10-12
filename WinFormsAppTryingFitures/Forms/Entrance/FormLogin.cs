using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTryingFitures
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(string login)
        {
            InitializeComponent();
        }

        private async void FormLogin_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_string_user"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);




            bool isTextOpen = false;

            pictureBoxShowPassword.Click += (a, b) =>
            {

                isTextOpen = !isTextOpen;

                if (isTextOpen)
                {
                    pictureBoxShowPassword.Image = Properties.Resources.eye_hidden;

                    textBoxPassword.PasswordChar = '\0';
                }
                else
                {
                    pictureBoxShowPassword.Image = Properties.Resources.eye;

                    textBoxPassword.PasswordChar = '*';
                }

            };



            buttonEnter.Click += (a, b) =>
            {
                connection.Open();

                SqlDataReader dataReader = null;

                try
                {
                    PictureBox pictureBoxToMainForm = new PictureBox();


                    string sqlCommand = $"SELECT * FROM students WHERE login = N'{textBoxLogin.Text}' AND password = N'{textBoxPassword.Text}'";

                    SqlCommand command = new SqlCommand(sqlCommand, connection);



                    dataReader = command.ExecuteReader();
                    dataReader.Read();






                    if (dataReader.HasRows)
                    {

                        string firstSecondName = dataReader["second_name"].ToString() + " " + dataReader["first_name"].ToString();
                        string login = dataReader["login"].ToString();



                        dataReader.Close();



                        sqlCommand = $"SELECT photo FROM students WHERE login = N'{textBoxLogin.Text}' AND password = N'{textBoxPassword.Text}'";

                        command = new SqlCommand(sqlCommand, connection);



                        string base64FromDataBase = command.ExecuteScalar().ToString();


                        if (base64FromDataBase.Length > 0)
                        {

                            Image image = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64FromDataBase)));


                            pictureBoxToMainForm.Image = image;


                        }
                        else
                        {
                            sqlCommand = $"SELECT gender FROM students WHERE login = N'{textBoxLogin.Text}' AND password = N'{textBoxPassword.Text}'";

                            command = new SqlCommand(sqlCommand, connection);




                            string gender = command.ExecuteScalar().ToString();

                            if (gender == "m")
                            {
                                pictureBoxToMainForm.Image = Properties.Resources.default_male_photo;
                            }
                            else
                            {
                                pictureBoxToMainForm.Image = Properties.Resources.default_female_photo;
                            }
                        }



                        FormMenu form = new FormMenu(firstSecondName, login, pictureBoxToMainForm);
                        form.Show();
                        this.Hide();

                    }
                    else
                    {
                        //MessageBox.Show("Данные введены некорректно!");

                        CustomMessageBox.Show("Данные введены некорректно!");
                    }
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.ToString());

                    CustomMessageBox.Show(ex.Message);
                }
                finally
                {
                    if (dataReader != null && !dataReader.IsClosed)
                    {
                        dataReader.Close();
                    }

                    connection.Close();
                }

            };



            labelButtonRegister.Click += (a, b) =>
            {
                FormRegistration form = new FormRegistration();
                form.Show();
                this.Hide();
            };
        }

    }
}
