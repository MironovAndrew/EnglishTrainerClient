using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTryingFitures
{
    static class FormOnPanel
    {
        static public void Show(Panel panelShowForm, Form selectedForm)
        {
            panelShowForm.Controls.Clear();

            Form form = selectedForm;
            form.TopLevel = false;

            panelShowForm.Tag = form;
            form.Size = new Size(panelShowForm.Width, panelShowForm.Height);

            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = new Size(panelShowForm.Width, panelShowForm.Height);

            panelShowForm.Controls.Add(form);

            form.Show();
        }
    }
}
