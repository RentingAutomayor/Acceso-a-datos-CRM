//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class branch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public branch()
        {
            this.Contact = new HashSet<Contact>();
        }
    
        public int bra_id { get; set; }
        public string bra_name { get; set; }
        public string bra_adress { get; set; }
        public string bra_phone { get; set; }
        public Nullable<bool> bra_isMain { get; set; }
        public Nullable<bool> bra_state { get; set; }
        public string cli_document { get; set; }
        public string ally_document { get; set; }
    
        public virtual ally ally { get; set; }
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contact { get; set; }
    }
}
