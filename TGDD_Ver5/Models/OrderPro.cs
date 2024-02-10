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
    
    public partial class OrderPro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderPro()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ID_Pro { get; set; }
        public Nullable<int> PhoneCus { get; set; }
        public Nullable<int> Total_Temp { get; set; }
        public Nullable<int> Point { get; set; }
        public Nullable<int> Total_Price { get; set; }
        public Nullable<System.DateTime> Date_Order { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
        public Nullable<bool> Status_Order { get; set; }
        public Nullable<int> ID_Cart { get; set; }
        public string AddressCus { get; set; }
        public Nullable<int> PaymentID { get; set; }
        public Nullable<int> ID_Voucher { get; set; }
    
        public virtual Cart Cart { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Voucher Voucher { get; set; }
    }
}