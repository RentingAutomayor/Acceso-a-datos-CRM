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
    
    public partial class Contact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contact()
        {
            this.additionalInformationByContact = new HashSet<additionalInformationByContact>();
            this.Request = new HashSet<Request>();
        }
    
        public int cnt_id { get; set; }
        public Nullable<int> bra_id { get; set; }
        public string cnt_name { get; set; }
        public string cnt_lastName { get; set; }
        public string cnt_phone { get; set; }
        public string cnt_cellPhone { get; set; }
        public string cnt_email { get; set; }
        public string cnt_adress { get; set; }
        public Nullable<int> jtcl_id { get; set; }
        public string cnt_costCenter { get; set; }
        public Nullable<int> cty_id { get; set; }
        public Nullable<System.DateTime> cnt_registrationDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<additionalInformationByContact> additionalInformationByContact { get; set; }
        public virtual branch branch { get; set; }
        public virtual Cities Cities { get; set; }
        public virtual JobTitlesClient JobTitlesClient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Request { get; set; }
    }
}
