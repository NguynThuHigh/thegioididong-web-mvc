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
    
    public partial class OrderDetail
    {
        public int ID { get; set; }
        public Nullable<int> ID_Pro { get; set; }
        public Nullable<int> ID_Order { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<bool> Status_Order { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
    
        public virtual OrderPro OrderPro { get; set; }
        public virtual ProDetail ProDetail { get; set; }
    }
}