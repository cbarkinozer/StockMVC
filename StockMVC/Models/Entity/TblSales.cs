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
    
    public partial class TblSales
    {
        public int saleID { get; set; }
        public Nullable<int> saleProduct { get; set; }
        public Nullable<int> saleCustomer { get; set; }
        public Nullable<byte> saleAmount { get; set; }
        public Nullable<decimal> salePrice { get; set; }
    
        public virtual TblCustomers TblCustomers { get; set; }
        public virtual TblProducts TblProducts { get; set; }
    }
}
