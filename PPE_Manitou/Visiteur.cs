//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE_Manitou
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visiteur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visiteur()
        {
            this.fichefrais = new HashSet<fichefrais>();
            this.RAPPORT = new HashSet<RAPPORT>();
            this.Region = new HashSet<Region>();
            this.Secteur = new HashSet<Secteur>();
            this.Region1 = new HashSet<Region>();
        }
    
        public string idVisiteur { get; set; }
        public int idLabo { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string rue { get; set; }
        public string cp { get; set; }
        public string ville { get; set; }
        public string dateEmbauche { get; set; }
        public string identifiant { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fichefrais> fichefrais { get; set; }
        public virtual Laboratoire Laboratoire { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RAPPORT> RAPPORT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Region> Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Secteur> Secteur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Region> Region1 { get; set; }
    }
}
