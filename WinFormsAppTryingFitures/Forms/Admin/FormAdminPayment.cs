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
    public partial class FormAdminPayment : Form
    {
        public FormAdminPayment()
        {
            InitializeComponent();




            int delta = listView1.Height;

            foreach (var control in panel1.Controls)
            {
                if (control is Label label)
                {
                    label.Location = new Point(this.Width / 2 - label.Width / 2, delta);
                    label.Anchor = AnchorStyles.Top;
                }
                else if (control is TextBox textBox)
                {
                    textBox.Location = new Point(this.Width / 2 - textBox.Width / 2, delta);
                    textBox.Anchor = AnchorStyles.Top;
                    delta += 15;
                }
                else if (control is Button button)
                {
                    button.Location = new Point(this.Width / 2 - button.Width / 2, delta);
                    button.Anchor = AnchorStyles.Top;
                }

                delta += 30;
            }



            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;


        }


    }
}
