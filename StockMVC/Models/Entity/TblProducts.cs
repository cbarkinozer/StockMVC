//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockMVC.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblProducts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblProducts()
        {
            this.TblSales = new HashSet<TblSales>();
        }
    
        public int productID { get; set; }
        public string productName { get; set; }
        public string productBrand { get; set; }
        public Nullable<short> productCategory { get; set; }
        public Nullable<decimal> productCost { get; set; }
        public Nullable<byte> productStock { get; set; }
    
        public virtual TblCategories TblCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSales> TblSales { get; set; }
    }
}