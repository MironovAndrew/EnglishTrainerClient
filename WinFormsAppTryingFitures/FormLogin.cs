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

        private void FormLogin_Load(object sender, EventArgs e)
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
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.eye_hidden;

                    textBox2.PasswordChar = '*';
                }

            };

            button1.Click += (a, b) =>
            {
                connection.Open();

                SqlDataReader dataReader = null;

                try
                {
                    SqlCommand command = new SqlCommand($"SELECT * FROM students WHERE Login = N'{textBox1.Text}' AND Password = N'{textBox2.Text}'", connection);

                    dataReader = command.ExecuteReader();
                    dataReader.Read();

                    PictureBox pictureBoxToMainForm = new PictureBox();

                    if (dataReader.HasRows)
                    {

                        byte[] image = (byte[])(dataReader["Photo"]);

                        if(image == null)
                        {
                            pictureBoxToMainForm = null;
                        }
                        else
                        {
                            
                            MemoryStream memoryStream = new MemoryStream(image);
                            pictureBoxToMainForm.Image = Image.FromStream(memoryStream);
                        }

                         FormMenu form = new FormMenu(textBox1.Text, pictureBoxToMainForm);
                         form.Show();
                         this.Hide();


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
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
