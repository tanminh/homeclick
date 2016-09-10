namespace VCMS.Lib.Models.Business
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Reflection;

    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            Product_detail = new HashSet<Product_detail>();
            Categories = new HashSet<Category>();
            Product_Variants = new HashSet<Product_Variant>();
            Files = new HashSet<File>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public string content { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("featured")]
        public bool Featured { get; set; }

        [StringLength(128)]
        public string ImageId { get; set; }

        public string excerpt { get; set; }

        public string CreateUserId { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual ICollection<Product_detail> Product_detail { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Product_Variant> Product_Variants { get; set; }

        [ForeignKey("ImageId")]
        public virtual File Image { get; set; }

        public virtual ICollection<File> Files { get; set; }

        [ForeignKey("CreateUserId")]
        public virtual ApplicationUser CreateUser { get; set; }
    }

    public partial class Product
    {
        public Category Typology {
            get
            {
                var typology = Categories.Where(o => o.Category_typeId == (int)CategoryTypes.Typology).FirstOrDefault();
                return typology;
            }
        }

        public IEnumerable<Category> Rooms
        {
            get
            {
                var room = Categories.Where(o => o.Category_typeId == (int)CategoryTypes.Model);
                return room;
            }
        }

        public IEnumerable<Product_Variant> Materials
        {
            get
            {
                var materials = new List<Product_Variant>();
                foreach (var item in Product_Variants)
                {
                    var material = item.Parent;
                    if (!materials.Contains(material))
                        materials.Add(material);
                }
                return materials;
            }
        }

        public Dictionary<string, object> DetailsToDictionary()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            foreach (var detail in Product_detail)
            {
                if (!dic.ContainsKey(detail.Name))
                    dic.Add(detail.Name, detail.Value);
            }
            return dic;
        }
    }


    /*5205555.
     * 6
    public class ProductEntityConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductEntityConfiguration()
        {
            this.HasMany(e => e.Product_detail)
                .WithOptional(e => e.Product)
                .WillCascadeOnDelete();

            this.HasMany(e => e.Categories)
                .WithMany(e => e.Products)
                .Map(cs =>
                {
                    cs.MapLeftKey("ChildId");
                    cs.MapRightKey("ParentId");
                    cs.ToTable("Category_Product_Link");
                });
        }
    }
    */
}
