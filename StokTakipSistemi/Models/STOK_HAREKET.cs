//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakipSistemi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class STOK_HAREKET
    {
        public int HAREKET_ID { get; set; }
        public Nullable<int> STOK_ID { get; set; }
        public Nullable<int> DEPO_ESLESTIRME_ID { get; set; }
        public Nullable<int> SORUMLU_ID { get; set; }
        public Nullable<int> HAREKET_TIP { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<decimal> HAREKET_MIKTAR { get; set; }
        public Nullable<System.DateTime> HAREKET_TARIHI { get; set; }
        public Nullable<int> OLUSTURAN_KULLANICI { get; set; }
        public Nullable<System.DateTime> OLUSTURMA_TARIHI { get; set; }
        public Nullable<int> GUNCELLEYEN_KULLANICI { get; set; }
        public Nullable<System.DateTime> GUNCELLEME_TARIHI { get; set; }
    
        public virtual DEPO_ESLESTIRME DEPO_ESLESTIRME { get; set; }
        public virtual HAREKET_TIP HAREKET_TIP1 { get; set; }
        public virtual SORUMLU SORUMLU { get; set; }
        public virtual STOK STOK { get; set; }
    }
}
