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
    
    public partial class TBL_BAKIM
    {
        public int BAKIM_ID { get; set; }
        public Nullable<int> MUSTERI_ID { get; set; }
        public Nullable<int> URUN_ID { get; set; }
        public string BAKIM_ISLEMI { get; set; }
        public Nullable<System.DateTime> BAKIM_TARIHI { get; set; }
        public Nullable<int> BAYI_ID { get; set; }
    
        public virtual TBL_BAYI TBL_BAYI { get; set; }
        public virtual TBL_MUSTERI TBL_MUSTERI { get; set; }
        public virtual TBL_URUN TBL_URUN { get; set; }
    }
}
