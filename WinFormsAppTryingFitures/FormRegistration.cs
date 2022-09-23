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

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_string_user"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);



            bool isTextOpen = false;
            pictureBox1.Click += (a, b) =>
            {

                isTextOpen = !isTextOpen;

                if (isTextOpen)
                {
                    pictureBox1.Image = Properties.Resources.eye;

                    textBox2.PasswordChar = '\0';
                    textBox3.PasswordChar = '\0';
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.eye_hidden;

                    textBox2.PasswordChar = '*';
                    textBox3.PasswordChar = '*';
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

            string photoPath = null;
            pictureBoxPhoto.Click += (a, b) =>
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Изображение (*.png; *.jpeg; *.jpg)|*.png; *.jpeg; *.jpg";
                fileDialog.Title = "Выберите фотографию";

                if (fileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                photoPath = fileDialog.FileName;

                pictureBoxPhoto.ImageLocation = photoPath;
            };


















            button1.Click += (a, b) =>
            {

                if (textBox2.Text == textBox3.Text && textBox1.Text.Length > 3)
                {
                    connection.Open();


                    string textCommand = $"INSERT INTO students (Login, Password, Photo, Gender) VALUES (@Login, @Password, @Photo, @Gender)";
                    SqlCommand command; 


                    if (photoPath != null)
                    {
                        command = new SqlCommand(textCommand, connection);

                        byte[] image = null;
                        FileStream fileStream = new FileStream(photoPath, FileMode.Open, FileAccess.Read);
                        BinaryReader binaryReader = new BinaryReader(fileStream);
                        image = binaryReader.ReadBytes((int)fileStream.Length);

                        command.Parameters.Add(new SqlParameter("Photo", image));
                    }
                    else
                    {
                        command = new SqlCommand(textCommand.Replace(" Photo,","").Replace(", @Photo",""), connection);

                    }


                    command.Parameters.AddWithValue("Login", textBox1.Text);
                    command.Parameters.AddWithValue("Password", textBox2.Text);
                    command.Parameters.AddWithValue("Gender", gender);






                    try
                    {
                        command.ExecuteNonQuery();

                        FormMenu form = new FormMenu(textBox1.Text, pictureBoxPhoto);
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
                    MessageBox.Show("Логин слишком короткий или пароли не совпадают!");
                }
            };



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                label3.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                label3.Visible = false;
                textBox3.Visible = false;
                textBox3.Text = "";
            }
        }
    }
}
