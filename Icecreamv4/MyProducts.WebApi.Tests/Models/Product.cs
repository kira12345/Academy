//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProducts.WebApi.Tests.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductsId { get; set; }
        public string ProductsName { get; set; }
        public string ProductsDescription { get; set; }
        public string ProductModel { get; set; }
        public Nullable<decimal> ProductPrice { get; set; }
        public string ProductKeywords { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<bool> ProductActive { get; set; }
        public Nullable<System.DateTime> ProductDate { get; set; }
        public Nullable<System.DateTime> ProductDateUpdate { get; set; }
    }
}
