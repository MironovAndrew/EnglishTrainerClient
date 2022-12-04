using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTryingFitures
{
    public static class CustomMessageBox
    {
        public static void Show(string message)
        {
            if (Application.OpenForms["FormShowMessage"] == null)
            {
                FormShowMessage formMessage = new FormShowMessage(message);
                formMessage.Show();
            }
        }
    }
}
