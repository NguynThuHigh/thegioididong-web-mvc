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
    
    public partial class AddressCu
    {
        public int ID { get; set; }
        public Nullable<int> PhoneCus { get; set; }
        public string AddressCus { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}