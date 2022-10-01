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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private async void FormRegistration_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_string_user"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);






            bool isTextOpen = false;
            pictureBoxShowPassword.Click += (a, b) =>
            {

                isTextOpen = !isTextOpen;

                if (isTextOpen)
                {
                    pictureBoxShowPassword.Image = Properties.Resources.eye;

                    textBoxPassword.PasswordChar = '\0';
                    textBoxPasswordRepeat.PasswordChar = '\0';
                }
                else
                {
                    pictureBoxShowPassword.Image = Properties.Resources.eye_hidden;

                    textBoxPassword.PasswordChar = '*';
                    textBoxPasswordRepeat.PasswordChar = '*';
                }

            };








            string gender = "m";
            foreach (RadioButton rb in Controls.OfType<RadioButton>())
            {
                rb.CheckedChanged += (a, b) =>
                {
                    if (rb == radioButtonFemale)
                    {
                        gender = "f";
                        pictureBoxPhoto.Image = Properties.Resources.default_female_photo;
                    }
                    else if (rb == radioButtonMale)
                    {
                        gender = "m";
                        pictureBoxPhoto.Image = Properties.Resources.default_male_photo;
                    }
                };
            }






            OpenFileDialog fileDialog = null;
            string photoPath = null;
            pictureBoxPhoto.Click += (a, b) =>
            {
                fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Изображение (*.png; *.jpeg; *.jpg)|*.png; *.jpeg; *.jpg";
                fileDialog.Title = "Выберите фотографию";

                if (fileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                photoPath = fileDialog.FileName;

                pictureBoxPhoto.ImageLocation = photoPath;
            };





            string photoBase64 = "error";

            buttonAdd.Click += async (a, b) =>
            {
                bool requirement = textBoxPassword.Text == textBoxPasswordRepeat.Text && textBoxLogin.Text.Length > 3
                && textBoxFirstName.Text.Length > 3 && textBoxSecondName.Text.Length > 3;

                if (requirement)
                {
                    connection.Open();


                    string textCommand = $"INSERT INTO students (Login, Password, FirstName, SecondName, Photo, Gender) VALUES (@Login, @Password, @FirstName, @SecondName, @Photo, @Gender)";
                    SqlCommand command;


                    if (photoPath != null)
                    {
                        command = new SqlCommand(textCommand, connection);

                        #region Старое копирование ПУТИ в БД

                        //  byte[] image = null;
                        //  FileStream fileStream = new FileStream(photoPath, FileMode.Open, FileAccess.Read);
                        //  BinaryReader binaryReader = new BinaryReader(fileStream);
                        //  image = binaryReader.ReadBytes((int)fileStream.Length);

                        #endregion




                        await Task.Run(() =>
                        {
                            photoBase64 = Convert.ToBase64String(File.ReadAllBytes(photoPath));
                        });

                        command.Parameters.Add(new SqlParameter("Photo", photoBase64));
                    }
                    else
                    {
                        command = new SqlCommand(textCommand.Replace(" Photo,", "").Replace(" @Photo,", ""), connection);
                    }


                    command.Parameters.AddWithValue("Login", textBoxLogin.Text);
                    command.Parameters.AddWithValue("Password", textBoxPassword.Text);
                    command.Parameters.AddWithValue("FirstName", textBoxFirstName.Text);
                    command.Parameters.AddWithValue("SecondName", textBoxSecondName.Text);
                    command.Parameters.AddWithValue("Gender", gender);






                    try
                    {
                        command.ExecuteNonQuery();


                        FormMenu form = new FormMenu(textBoxSecondName.Text + " "+ textBoxFirstName.Text, pictureBoxPhoto);
                        form.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Проверьте введенные данные! Поля должны иметь длину более 3 символов!");
                }
            };



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length > 0)
            {
                label3.Visible = true;
                textBoxPasswordRepeat.Visible = true;
            }
            else
            {
                label3.Visible = false;
                textBoxPasswordRepeat.Visible = false;
                textBoxPasswordRepeat.Text = "";
            }
        }
    }
}
