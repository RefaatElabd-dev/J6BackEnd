using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Product
    {
        public Product()
        {
            ProdCarts = new HashSet<ProdCart>();
            ProdOrders = new HashSet<ProdOrder>();
            ProductBrands = new HashSet<ProductBrand>();
            ProductImages = new HashSet<ProductImage>();
            Reviews = new HashSet<Review>();
            StoreProducts = new HashSet<StoreProduct>();
            Views = new HashSet<View>();
        }

        public int ProductId { get; set; }
        public string Price { get; set; }
        public int? SoldQuantities { get; set; }
        public int? Quantity { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string ProductName { get; set; }
        public string Model { get; set; }
        public int? SubcategoryId { get; set; }
        public double? Rating { get; set; }
        public string Discount { get; set; }
        public string Description { get; set; }
        public string Ship { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? PromotionId { get; set; }

        public virtual Promotion Promotion { get; set; }
        public virtual SubCategory Subcategory { get; set; }
        public virtual ShippingDetail ShippingDetail { get; set; }
        public virtual ICollection<ProdCart> ProdCarts { get; set; }
        public virtual ICollection<ProdOrder> ProdOrders { get; set; }
        public virtual ICollection<ProductBrand> ProductBrands { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<StoreProduct> StoreProducts { get; set; }
        public virtual ICollection<View> Views { get; set; }
    }
}
