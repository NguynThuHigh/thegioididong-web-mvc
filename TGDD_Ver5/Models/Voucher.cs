//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TGDD_Ver5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Voucher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voucher()
        {
            this.OrderProes = new HashSet<OrderPro>();
        }
    
        public int ID { get; set; }
        public string NameVoucher { get; set; }
        public Nullable<int> Discount { get; set; }
        public string Descript { get; set; }
        public Nullable<int> MinPro { get; set; }
        public Nullable<int> MinTotal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderPro> OrderProes { get; set; }
    }
}
