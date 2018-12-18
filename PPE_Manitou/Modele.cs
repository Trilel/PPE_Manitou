using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PPE_Manitou
{
    class Modele
    {
        private static ManitouEntities1 maConnexion;
        //private static VISITEUR utilisateurConnecte;

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new ManitouEntities1();
        }
        public static Visiteur VisiteurChoisi { get => VisiteurChoisi; set => VisiteurChoisi = value; }
        public static fichefrais UneFichefrais { get => UneFichefrais; set => UneFichefrais = value; }
        public static LigneFraisForfait UneLigneFraisForfait { get => UneLigneFraisForfait; set => UneLigneFraisForfait = value; }
        public static LigneFraisHorsForfait UneLigneFraisHorsForfait { get => UneLigneFraisHorsForfait; set => UneLigneFraisHorsForfait = value; }
        public static FraisForfait unFraisForfait { get => unFraisForfait; set => unFraisForfait = value; }
        public static int idHorsforfait;
        public static List<Visiteur> listeVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
        public static List<Region> listeRegion()
        {
            return maConnexion.Region.ToList();
        }
        public static List<fichefrais> listeFicheFrais()
        {
            return maConnexion.fichefrais.ToList();
        }
        /*public static List<FraisForfait> listeVehicule()
        {
            var LQuery = maConnexion.FraisForfait.ToList()
                            .Where(x => x.TypeForfait == "KM")
                           .Select(x => new { x.id, x.libelle, x.montant, x.TypeForfait, x.idRegion });
            return LQuery.ToList();
        }*/
        public static bool connection(string id, string mp)
        {
            bool vretour = false;
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.identifiant == id)
                           .Select(x => new { x.identifiant, x.password });
            foreach (var v in LQuery)
            {
                string mdp = GetMd5Hash(mp);
                if (v.password.Substring(2) == mdp)
                {
                    vretour = true;
                }
            }
            return vretour;
        }
        public static Object VisiteurConnecte(string identifiant)
        {
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.identifiant == identifiant)
                           .Select(x => new { x.idVisiteur, x.idLabo, x.nom, x.prenom, x.rue, x.cp, x.ville, x.dateEmbauche, x.identifiant, x.password });
            return LQuery.ToList();
        }
        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString().ToUpper();
        }
        public static bool soumettreFiche(string unIdVisiteur, string unMois, int uneAnnee, int unNbJustificatifs = 0, decimal unMontantValide = 0 ,string unIdEtat = "CR")
        {
            bool vretour = false;
            try
            {
                UneFichefrais = new fichefrais();
                UneFichefrais.idVisiteur = unIdVisiteur;
                UneFichefrais.mois = unIdVisiteur;
                UneFichefrais.annee = uneAnnee;
                UneFichefrais.nbJustificatifs = unNbJustificatifs;
                UneFichefrais.montantValide = unMontantValide;
                UneFichefrais.idEtat = unIdEtat;
                maConnexion.fichefrais.Add(UneFichefrais);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = true;
            }
            return vretour;
        }
        public static bool AjoutLigneFraisForfait(string unIdVisiteur, string unMois, int uneAnnee, string unIdFraisForfait, int uneQuantite)
        {
            bool vretour = false;
            try
            {
                UneLigneFraisForfait = new LigneFraisForfait();
                UneLigneFraisForfait.idVisiteur = unIdVisiteur;
                UneLigneFraisForfait.mois = unMois;
                UneLigneFraisForfait.annee = uneAnnee;
                UneLigneFraisForfait.idFraisForfait = unIdFraisForfait;
                UneLigneFraisForfait.quantite = uneQuantite;
                maConnexion.LigneFraisForfait.Add(UneLigneFraisForfait);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = true;
            }
            return vretour;
        }
        public static bool AjoutLigneFraisHorsForfait(int unId, string unIdVisiteur,string unMois, int uneAnnee, string unLibelle, DateTime uneDate, Decimal unMontant)
        {
            bool vretour = false;
            try
            {
                UneLigneFraisHorsForfait = new LigneFraisHorsForfait();
                idHorsforfait += 1;
                UneLigneFraisHorsForfait.idVisiteur = unIdVisiteur;
                UneLigneFraisHorsForfait.mois = unMois;
                UneLigneFraisHorsForfait.annee = uneAnnee;
                UneLigneFraisHorsForfait.libelle = unLibelle;
                UneLigneFraisHorsForfait.date = uneDate;
                UneLigneFraisHorsForfait.montant = unMontant;
                maConnexion.LigneFraisHorsForfait.Add(UneLigneFraisHorsForfait);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = true;
            }
            return vretour;
        }
    }
}
