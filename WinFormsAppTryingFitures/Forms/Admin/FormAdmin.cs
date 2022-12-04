using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppTryingFitures;

namespace WinFormsAppTryingFitures
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();

            buttonTheory.Click += (a, b) => { FormOnPanel.Show(panelShowForm, new FormAdminTheory()); };
            buttonPayment.Click += (a, b) => { FormOnPanel.Show(panelShowForm, new FormAdminPayment()); };
            buttonBranches.Click += (a, b) => { FormOnPanel.Show(panelShowForm, new FormAdminBranches()); };
            buttonWords.Click += (a, b) => { FormOnPanel.Show(panelShowForm, new FormAdminWords()); };

        }

    }
}
