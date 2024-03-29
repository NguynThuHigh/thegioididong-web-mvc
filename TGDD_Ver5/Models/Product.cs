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
    using System.Web.Mvc;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Comments = new HashSet<Comment>();
            this.ListImages = new HashSet<ListImage>();
            this.ProDetails = new HashSet<ProDetail>();
            ImagePro = "~/Content/images/logo.png";
        }
    
        public int ID { get; set; }
        public string NamePro { get; set; }
        public string ImagePro { get; set; }
        public string ImageDetail { get; set; }
        public Nullable<int> Installment { get; set; }
        public string Title_Discount { get; set; }
        [AllowHtml]
        public string Info { get; set; }
        [AllowHtml]
        public string Promotion { get; set; }
        [AllowHtml]
        public string PromoAdd { get; set; }
        [AllowHtml]
        public string PolicyPro { get; set; }
        public string Screen { get; set; }
        public string Type_Product { get; set; }
        public string Graphics_Card { get; set; }
        public string Connector { get; set; }
        public string OS { get; set; }
        public string Design { get; set; }
        public string Size { get; set; }
        public string Mass { get; set; }
        public string Special { get; set; }
        public string CameraSau { get; set; }
        public string CameraTruoc { get; set; }
        public string Chip { get; set; }
        public string Sim { get; set; }
        public string Pin { get; set; }
        public Nullable<int> DateRelease { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> TradeMarkID { get; set; }
        public Nullable<int> PromotionID { get; set; }
        public Nullable<int> PolicyProID { get; set; }
        public Nullable<int> ServiceID { get; set; }
        public Nullable<decimal> Rating { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListImage> ListImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProDetail> ProDetails { get; set; }
        public virtual TradeMark TradeMark { get; set; }
    }
}
