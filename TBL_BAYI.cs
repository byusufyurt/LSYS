//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LSYS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_BAYI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_BAYI()
        {
            this.TBL_BAKIM = new HashSet<TBL_BAKIM>();
            this.TBL_MUSTERI = new HashSet<TBL_MUSTERI>();
            this.TBL_ODEME = new HashSet<TBL_ODEME>();
            this.TBL_SATIS = new HashSet<TBL_SATIS>();
            this.TBL_SIPARIS = new HashSet<TBL_SIPARIS>();
        }
    
        public int BAYI_ID { get; set; }
        public string BAYI_ADI { get; set; }
        public string KULLANICI_ADI { get; set; }
        public string SIFRE { get; set; }
        public string TELEFON { get; set; }
        public string ADRES { get; set; }
        public Nullable<int> FIRMA_ID { get; set; }
        public string MAIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_BAKIM> TBL_BAKIM { get; set; }
        public virtual TBL_FIRMA TBL_FIRMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_MUSTERI> TBL_MUSTERI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_ODEME> TBL_ODEME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SATIS> TBL_SATIS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SIPARIS> TBL_SIPARIS { get; set; }
    }
}
