//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homeclick.Models.test
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post_detail
    {
        public int Id { get; set; }
        public Nullable<int> post_id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string caption { get; set; }
        public Nullable<int> PostId { get; set; }
        public Nullable<short> type { get; set; }
        public Nullable<int> typeEnum { get; set; }
    
        public virtual Post Post { get; set; }
    }
}
