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
    public partial class FormRapportVisite : Form
    {
        public FormRapportVisite()
        {
            InitializeComponent();
        }

        private void FormRapportVisite_Load(object sender, EventArgs e)
        {
            cbo_Practicien.ValueMember = "idMedecin";//permet de stocker l'identifiant
            cbo_Practicien.DisplayMember = "nom";
            cbo_Practicien.DataSource = Modele.listeMedecins();
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGestionDesComptesRendus f = new FormGestionDesComptesRendus();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le rapport a bien été ajouté !");
        }
    }
}
