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
    
    public partial class FraisForfait
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FraisForfait()
        {
            this.LigneFraisForfait = new HashSet<LigneFraisForfait>();
        }
    
        public string id { get; set; }
        public string libelle { get; set; }
        public Nullable<decimal> montant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LigneFraisForfait> LigneFraisForfait { get; set; }
    }
}
