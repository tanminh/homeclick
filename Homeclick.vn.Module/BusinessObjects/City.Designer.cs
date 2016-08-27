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
    public partial class City: XPLiteObject
    {
    	//VNB: City
        public City()
        {
            //VNB disable: this.Customer = new List<Customer>();
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
    	[Required]
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
    
        private string _ship_price;
    	[Required]
    	public string ship_price 
    	{ 
    		get { return _ship_price; } 
    		set
    		{
    			if (value != _ship_price) {
    				_ship_price = value;
    				 Onship_priceChanged();
    			}
    		} 
    	}
    	partial void Onship_priceChanged(); 
    
        private string _postal_code;
    	[Required]
    	public string postal_code 
    	{ 
    		get { return _postal_code; } 
    		set
    		{
    			if (value != _postal_code) {
    				_postal_code = value;
    				 Onpostal_codeChanged();
    			}
    		} 
    	}
    	partial void Onpostal_codeChanged(); 
    
    
        [Association(@"CustomerCityReferences", typeof(Customer))]
    	public  XPCollection<Customer> DanhSachCustomer { get{{ return GetCollection<Customer>("DanhSachCustomer"); }} }
    
    }
}
