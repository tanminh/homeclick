
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
    
public partial class ProjectItem
{

    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Image { get; set; }

    public Nullable<int> Order { get; set; }

    public Nullable<int> ProjectId { get; set; }

    public Nullable<bool> LockedOut { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<int> CreatedBy { get; set; }

    public Nullable<System.DateTime> UpdatedDate { get; set; }

    public Nullable<int> UpdatedBy { get; set; }



    public virtual Project Project { get; set; }

    public virtual User CreatedByUser { get; set; }

    public virtual User UpdatedByUser { get; set; }

}

}
