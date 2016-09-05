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
    public partial class Category: XPLiteObject
    {
    	//VNB: Category
        public Category()
        {
            //VNB disable: this.ChildCategories = new List<Category>();
            //VNB disable: this.Category_details = new List<Category_detail>();
            //VNB disable: this.Posts = new List<Post>();
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
    
        private string _description;
    	public string description 
    	{ 
    		get { return _description; } 
    		set
    		{
    			if (value != _description) {
    				_description = value;
    				 OndescriptionChanged();
    			}
    		} 
    	}
    	partial void OndescriptionChanged(); 
    
        private Nullable<int> _parent_id;
    	public Nullable<int> parent_id 
    	{ 
    		get { return _parent_id; } 
    		set
    		{
    			if (value != _parent_id) {
    				_parent_id = value;
    				 Onparent_idChanged();
    			}
    		} 
    	}
    	partial void Onparent_idChanged(); 
    
        private int _category_type_id;
    	[Required]
    	public int Category_type_id 
    	{ 
    		get { return _category_type_id; } 
    		set
    		{
    			if (value != _category_type_id) {
    				_category_type_id = value;
    				 OnCategory_type_idChanged();
    			}
    		} 
    	}
    	partial void OnCategory_type_idChanged(); 
    
    
        [Association(@"CategoriesCategoriesReferences", typeof(Category))]
    	public  XPCollection<Category> DanhSachChildCategories { get{{ return GetCollection<Category>("DanhSachChildCategories"); }} }
    
        private Category _CategoryId;
    	[ImmediatePostData]
    	[Association(@"CategoriesCategoriesReferences", typeof(Category))]
    	public  Category ParentCategoryId { get {return _CategoryId;} set{ SetPropertyValue<Category>("CategoryId", ref _CategoryId, value); } }
    
        private Category_type _Category_typeId;
    	[ImmediatePostData]
    	[Association(@"CategoriesCategory_typesReferences", typeof(Category_type))]
    	public  Category_type Category_typeId { get {return _Category_typeId;} set{ SetPropertyValue<Category_type>("Category_typeId", ref _Category_typeId, value); } }
    
        [Association(@"Category_detailsCategoriesReferences", typeof(Category_detail))]
    	public  XPCollection<Category_detail> DanhSachCategory_details { get{{ return GetCollection<Category_detail>("DanhSachCategory_details"); }} }
    
        [Association(@"PostsCategoriesReferences", typeof(Post))]
    	public  XPCollection<Post> DanhSachPosts { get{{ return GetCollection<Post>("DanhSachPosts"); }} }
    
    }
}
