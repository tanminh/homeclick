//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homeclick.vn.Module.BusinessObjects
{
    using System;
    using System.Collections.Generic;
    
    using DevExpress.Xpo;
    using System.ComponentModel.DataAnnotations.Schema;
    using DevExpress.ExpressApp.ConditionalAppearance;
    using DevExpress.ExpressApp.Editors;
    using DevExpress.Persistent.Base;
    using DevExpress.ExpressApp.Model;
    public partial class Category_type: XPLiteObject
    {
    	//VNB: Category_type
        public Category_type()
        {
            //VNB disable: this.Categories = new List<Category>();
        }
    
        private int _id;
    	[DevExpress.Xpo.Key(true)]
    	[Required]
    	public int Id 
    	{ 
    		get { return _id; } 
    		set
    		{
    			if (value != _id) {
    				_id = value;
    				 OnIdChanged();
    			}
    		} 
    	}
    	partial void OnIdChanged(); 
    
        private string _name;
    	[Required]
    	public string name 
    	{ 
    		get { return _name; } 
    		set
    		{
    			if (value != _name) {
    				_name = value;
    				 OnnameChanged();
    			}
    		} 
    	}
    	partial void OnnameChanged(); 
    
        private string _caption;
    	public string caption 
    	{ 
    		get { return _caption; } 
    		set
    		{
    			if (value != _caption) {
    				_caption = value;
    				 OncaptionChanged();
    			}
    		} 
    	}
    	partial void OncaptionChanged(); 
    
        private short _type_for;
    	[Required]
    	public short type_for 
    	{ 
    		get { return _type_for; } 
    		set
    		{
    			if (value != _type_for) {
    				_type_for = value;
    				 Ontype_forChanged();
    			}
    		} 
    	}
    	partial void Ontype_forChanged(); 
    
    
        [Association(@"CategoriesCategory_typesReferences", typeof(Category))]
    	public  XPCollection<Category> DanhSachCategories { get{{ return GetCollection<Category>("DanhSachCategories"); }} }
    
    }
}
