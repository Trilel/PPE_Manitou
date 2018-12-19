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
            bool erreur = false;
            int unNbJustificatifs = 0;
            decimal unMontantValide = 0;
            if (txtId.TextLength > 0 && txtMois.TextLength > 0 && txtNom.TextLength > 0 && txtAnnee.TextLength > 0)
            {
                //Ligne frais forfait 
                bool erreurLigneNuit = Modele.AjoutLigneFraisForfait(txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), cbRegion.ValueMember, Convert.ToInt32(txtBoxNuit));
                unMontantValide = Convert.ToInt32(lbTotalNuit);
                bool erreurLigneRepas = Modele.AjoutLigneFraisForfait(txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), cbRegion.ValueMember, Convert.ToInt32(txtBoxRepas));
                unMontantValide += Convert.ToInt32(lbtotalRepas);
                bool erreurLigneKm = Modele.AjoutLigneFraisForfait(txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), cbVehicule.ValueMember, Convert.ToInt32(txtBoxKM));
                unMontantValide += Convert.ToInt32(lbTotalKm);
                bool erreurLigneRelais = Modele.AjoutLigneFraisForfait(txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), cbRegion.ValueMember, Convert.ToInt32(txtBoxEtape));
                unMontantValide += Convert.ToInt32(lbtotalRelais);
                //Ligne hors forfait
                bool erreurLigneHorsForfait1 = Modele.AjoutLigneFraisHorsForfait(Modele.idHorsforfait, txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), txtBoxLibel1.Text, Convert.ToDateTime(txtBoxD1.Text), Convert.ToDecimal(txtBoxMontant1.Text));
                unMontantValide += Convert.ToInt32(txtBoxD1);
                bool erreurLigneHorsForfait2 = Modele.AjoutLigneFraisHorsForfait(Modele.idHorsforfait, txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), txtBoxLibel2.Text, Convert.ToDateTime(txtBoxD2.Text), Convert.ToDecimal(txtBoxMontant2.Text));
                unMontantValide += Convert.ToInt32(txtBoxD2);
                bool erreurLigneHorsForfait3 = Modele.AjoutLigneFraisHorsForfait(Modele.idHorsforfait, txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), txtBoxLibel3.Text, Convert.ToDateTime(txtBoxD3.Text), Convert.ToDecimal(txtBoxMontant3.Text));
                unMontantValide += Convert.ToInt32(txtBoxD3);
                bool erreurLigneHorsForfait4 = Modele.AjoutLigneFraisHorsForfait(Modele.idHorsforfait, txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), txtBoxLibel4.Text, Convert.ToDateTime(txtBoxD4.Text), Convert.ToDecimal(txtBoxMontant4.Text));
                unMontantValide += Convert.ToInt32(txtBoxD4);
                bool erreurLigneHorsForfait5 = Modele.AjoutLigneFraisHorsForfait(Modele.idHorsforfait, txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), txtBoxLibel5.Text, Convert.ToDateTime(txtBoxD5.Text), Convert.ToDecimal(txtBoxMontant5.Text));
                unMontantValide += Convert.ToInt32(txtBoxD5);
                //Création Fiche de Frais
                bool erreurFiche = Modele.soumettreFiche(txtId.Text, txtMois.Text, Convert.ToInt32(txtAnnee.Text), unNbJustificatifs, unMontantValide);
                if(erreurLigneNuit && erreurLigneRepas && erreurLigneKm && erreurLigneRelais && erreurLigneHorsForfait1 && erreurLigneHorsForfait2 && erreurLigneHorsForfait3 && erreurLigneHorsForfait4)
                {
                    MessageBox.Show("Aucun Frais à été correctement rempli");
                }
                else
                {
                    MessageBox.Show("La fiche a correctement été rempli");
                }
            }else
            {
                erreur = true;
            }
            if(erreur)
            {
                MessageBox.Show("Le Matricule, nom, mois et année doivent être remplis");
            }
        }

        private void FormFicheFrais_Load(object sender, EventArgs e)
        {
            cbRegion.ValueMember = "idRegion";//permet de stocker l'identifiant
            cbRegion.DisplayMember = "libRegion";
            bsRegion.DataSource = Modele.listeRegion();
            cbRegion.DataSource = bsRegion;

            cbListeFicheVue.ValueMember = "idVisiteur mois annee";
            cbListeFicheVue.DisplayMember = "mois";
            bsFicheFrais.DataSource = Modele.listeFicheFrais();
            cbListeFicheVue.DataSource = bsFicheFrais;

            cbListeFicheModif.ValueMember = "idVisiteur mois annee";
            cbListeFicheModif.DisplayMember = "mois";
            bsFicheFrais.DataSource = Modele.listeFicheFrais();
            cbListeFicheModif.DataSource = bsFicheFrais;

            cbVehicule.ValueMember = "id";
            cbVehicule.DisplayMember = "libelle";
            //bsVehicule.DataSource = Modele.listeVehicule();
            cbVehicule.DataSource = bsVehicule;



        }

        private void btnModif_Click(object sender, EventArgs e)
        {

        }

        private void btn_vueFicheFrais_Click(object sender, EventArgs e)
        {
            FormVueFicheFrais f = new FormVueFicheFrais();
            f.Show();
        }
    }
}
