//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProducts.AdminSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        public int ImagesId { get; set; }
        public string ImagesDescription { get; set; }
        public string ImagesURL { get; set; }
        public Nullable<bool> ImagesActive { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<System.DateTime> ImageDate { get; set; }
        public Nullable<System.DateTime> ImageDateUpdate { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
