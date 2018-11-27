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
    public partial class FormFicheFrais : Form
    {
        public FormFicheFrais()
        {
            InitializeComponent();
        }

        private void txtBoxNuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnF_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGestionDesComptesRendus f = new FormGestionDesComptesRendus();
            f.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Ligne frais forfait 
            Modele.AjoutLigneFraisForfait(txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), cbRegion.ValueMember, Convert.ToInt32(txtBoxNuit));
            Modele.AjoutLigneFraisForfait(txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), cbRegion.ValueMember, Convert.ToInt32(txtBoxRepas));
            Modele.AjoutLigneFraisForfait(txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), cbVehicule.ValueMember, Convert.ToInt32(txtBoxKM));
            //Ligne hors forfait
            Modele.AjoutLigneFraisHorsForfait(Modele.idHorsforfait, txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), txtBoxLibel1.Text, Convert.ToDateTime(txtBoxD1.Text), Convert.ToDecimal(txtBoxMontant1.Text));
            Modele.AjoutLigneFraisHorsForfait(Modele.idHorsforfait, txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), txtBoxLibel2.Text, Convert.ToDateTime(txtBoxD2.Text), Convert.ToDecimal(txtBoxMontant2.Text));
            Modele.AjoutLigneFraisHorsForfait(Modele.idHorsforfait, txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), txtBoxLibel3.Text, Convert.ToDateTime(txtBoxD3.Text), Convert.ToDecimal(txtBoxMontant3.Text));
            Modele.AjoutLigneFraisHorsForfait(Modele.idHorsforfait, txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), txtBoxLibel4.Text, Convert.ToDateTime(txtBoxD4.Text), Convert.ToDecimal(txtBoxMontant4.Text));
            Modele.AjoutLigneFraisHorsForfait(Modele.idHorsforfait, txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), txtBoxLibel5.Text, Convert.ToDateTime(txtBoxD5.Text), Convert.ToDecimal(txtBoxMontant5.Text));          
            //Création Fiche de Frais
            // soumettreFiche( txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), int unNbJustificatifs = 0, decimal unMontantValide = 0)
        }

        private void FormFicheFrais_Load(object sender, EventArgs e)
        {
            cbRegion.ValueMember = "idRegion";//permet de stocker l'identifiant
            cbRegion.DisplayMember = "libRegion";
            bsRegion.DataSource = Modele.listeRegion();
            cbRegion.DataSource = bsRegion;
        }
    }
}
