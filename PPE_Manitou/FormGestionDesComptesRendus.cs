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
    public partial class FormGestionDesComptesRendus : Form
    {
        public FormGestionDesComptesRendus()
        {
            InitializeComponent();
        }

        private void FormGestionDesComptesRendus_Load(object sender, EventArgs e)
        {

        }

        private void btn_CompteRendus_Click(object sender, EventArgs e)
        {

        }

        private void btn_Frais_Click(object sender, EventArgs e)
        {
            FormFicheFrais F = new FormFicheFrais();
            F.Show();
        }
    }
}
