//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homeclick.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Size { get; set; }
        public string Investor { get; set; }
        public Nullable<int> Apartments { get; set; }
        public string StartYear { get; set; }
        public string CompletedYear { get; set; }
        public string ArchitetualDesignAgency { get; set; }
        public string FurnitureDesignAgency { get; set; }
        public string ViewDesignAgency { get; set; }
        public string Manager { get; set; }
        public string DistributionAgency { get; set; }
        public string HtmlContent { get; set; }
        public string ConstructionAgency { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public Nullable<bool> LockedOut { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual User CreatedByUser { get; set; }
        public virtual User UpdatedByUser { get; set; }
    }
}
