//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CC1_API.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proprietaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proprietaire()
        {
            this.Biens = new HashSet<Bien>();
        }
    
        public int Id { get; set; }
        public System.DateTime CreadtedDate { get; set; }
        public string Nom { get; set; }
        public decimal Tel { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bien> Biens { get; set; }
    }
}