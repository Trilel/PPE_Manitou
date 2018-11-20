using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_Manitou
{
    public partial class FormPracticiens : Form
    {
        public FormPracticiens()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGestionDesComptesRendus f = new FormGestionDesComptesRendus();
            f.Show();
        }

        private void cbo_Chercher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
