//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Meow
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uye()
        {
            this.Mesaj = new HashSet<Mesaj>();
        }
    
        public int UyeId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Resim { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string Okul { get; set; }
        public string Şehir { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mesaj> Mesaj { get; set; }
    }
}
