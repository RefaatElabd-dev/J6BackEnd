using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Jumia1Context : DbContext
    {
        public Jumia1Context()
        {
        }

        public Jumia1Context(DbContextOptions<Jumia1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerPhone> CustomerPhones { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Government> Governments { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<ProdCart> ProdCarts { get; set; }
        public virtual DbSet<ProdOrder> ProdOrders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductBrand> ProductBrands { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<ShippingDetail> ShippingDetails { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreProduct> StoreProducts { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAddress> UserAddresses { get; set; }
        public virtual DbSet<UserPhone> UserPhones { get; set; }
        public virtual DbSet<View> Views { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Jumia1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("brand");

                entity.Property(e => e.BrandId)
                    .ValueGeneratedNever()
                    .HasColumnName("brandId");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(60)
                    .HasColumnName("brandName");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("date")
                    .HasColumnName("createdAt");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("date")
                    .HasColumnName("updatedAt");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("cart");

                entity.Property(e => e.Cartid)
                    .ValueGeneratedNever()
                    .HasColumnName("cartid");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("orderDate");

                entity.Property(e => e.Paymentid)
                    .HasMaxLength(50)
                    .HasColumnName("paymentid");

                entity.Property(e => e.ShippingDate)
                    .HasColumnType("date")
                    .HasColumnName("shippingDate");

                entity.Property(e => e.ShippingDetailsId).HasColumnName("shippingDetailsId");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_cart_customer");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_cart_Employees");

                entity.HasOne(d => d.ShippingDetails)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.ShippingDetailsId)
                    .HasConstraintName("FK_cart_ShippingDetails");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("categoryName");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("date")
                    .HasColumnName("createdAt");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("date")
                    .HasColumnName("updatedAt");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cityName");

                entity.Property(e => e.GovernmentId).HasColumnName("governmentId");

                entity.HasOne(d => d.Government)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.GovernmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_city_government");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("customerId");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithOne(p => p.Customer)
                    .HasForeignKey<Customer>(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customer_User");
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.AddressId });

                entity.ToTable("customerAddress");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(25)
                    .HasColumnName("country");

                entity.Property(e => e.PostalCode).HasColumnName("postalCode");

                entity.Property(e => e.Street).HasColumnName("street");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customerAddress_User");
            });

            modelBuilder.Entity<CustomerPhone>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PhoneNumber });

                entity.ToTable("customerPhone");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CustomerPhones)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customerPhone_User");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.HireDate)
                    .HasColumnType("date")
                    .HasColumnName("hireDate");

                entity.Property(e => e.Salary)
                    .HasMaxLength(50)
                    .HasColumnName("salary");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_User");
            });

            modelBuilder.Entity<Government>(entity =>
            {
                entity.ToTable("government");

                entity.Property(e => e.GovernmentId).HasColumnName("governmentId");

                entity.Property(e => e.GovernmentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("governmentName");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("orderId");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_customer");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("payment");

                entity.Property(e => e.PaymentId)
                    .ValueGeneratedNever()
                    .HasColumnName("paymentId");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Paymenttype)
                    .HasMaxLength(50)
                    .HasColumnName("paymenttype")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ProdCart>(entity =>
            {
                entity.HasKey(e => new { e.CartId, e.ProductId });

                entity.ToTable("prod_Cart");

                entity.Property(e => e.CartId).HasColumnName("cartId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.ProdCarts)
                    .HasForeignKey(d => d.CartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prod_Cart_cart");

                entity.HasOne(d => d.CartNavigation)
                    .WithMany(p => p.ProdCarts)
                    .HasForeignKey(d => d.CartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prod_Cart_product");
            });

            modelBuilder.Entity<ProdOrder>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId });

                entity.ToTable("prod_order");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(10)
                    .HasColumnName("productId")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ProdOrders)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prod_order_Orders");

                entity.HasOne(d => d.OrderNavigation)
                    .WithMany(p => p.ProdOrders)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prod_order_product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("productId");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("date")
                    .HasColumnName("createdAt");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("date")
                    .HasColumnName("deletedAt");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Discount)
                    .HasMaxLength(50)
                    .HasColumnName("discount");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.Property(e => e.Price)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("price");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Ship)
                    .HasMaxLength(50)
                    .HasColumnName("ship");

                entity.Property(e => e.Size)
                    .HasMaxLength(10)
                    .HasColumnName("size")
                    .IsFixedLength(true);

                entity.Property(e => e.SoldQuantities).HasColumnName("soldQuantities");

                entity.Property(e => e.SubcategoryId).HasColumnName("subcategoryId");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("date")
                    .HasColumnName("updatedAt");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.PromotionId)
                    .HasConstraintName("FK_product_Promotions");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_product_subCategory");
            });

            modelBuilder.Entity<ProductBrand>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.BrandId });

                entity.ToTable("productBrand");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.BrandId).HasColumnName("brandId");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.ProductBrands)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_productBrand_brand");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductBrands)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_productBrand_product");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ImageId });

                entity.ToTable("ProductImage");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.ImageId).HasColumnName("imageId");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductImage_product");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.SellerId).HasColumnName("sellerId");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Promotions)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK_Promotions_Promotions");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => new { e.CustimerId, e.ProductId });

                entity.Property(e => e.CustimerId).HasColumnName("custimerId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Rating)
                    .HasMaxLength(50)
                    .HasColumnName("rating");

                entity.HasOne(d => d.Custimer)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.CustimerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reviews_customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reviews_product");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.ToTable("seller");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Seller)
                    .HasForeignKey<Seller>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_seller_User");
            });

            modelBuilder.Entity<ShippingDetail>(entity =>
            {
                entity.HasKey(e => e.ShippingDetailsId);

                entity.Property(e => e.ShippingDetailsId)
                    .ValueGeneratedNever()
                    .HasColumnName("shippingDetailsId");

                entity.Property(e => e.PaymentId).HasColumnName("paymentId");

                entity.Property(e => e.PurshesCost)
                    .HasMaxLength(50)
                    .HasColumnName("purshesCost");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.ShippingDetails)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_ShippingDetails_payment");

                entity.HasOne(d => d.ShippingDetails)
                    .WithOne(p => p.ShippingDetail)
                    .HasForeignKey<ShippingDetail>(d => d.ShippingDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShippingDetails_product");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("statusId");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .HasColumnName("statusName");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.StoreId)
                    .ValueGeneratedNever()
                    .HasColumnName("storeId");

                entity.Property(e => e.BuildingNumber)
                    .HasMaxLength(50)
                    .HasColumnName("buildingNumber");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.SellerId).HasColumnName("sellerId");

                entity.Property(e => e.Street)
                    .HasMaxLength(50)
                    .HasColumnName("street");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK_Stores_seller");
            });

            modelBuilder.Entity<StoreProduct>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StoreId });

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                entity.Property(e => e.Quantities).HasColumnName("quantities");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StoreProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreProducts_product");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreProducts)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreProducts_Stores");
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.ToTable("subCategory");

                entity.Property(e => e.SubcategoryId).HasColumnName("subcategoryId");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("date")
                    .HasColumnName("createdAt");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.SubcategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("subcategoryName");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("date")
                    .HasColumnName("updatedAt");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_subCategory_category");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("roleId");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.AddressId });

                entity.ToTable("userAddress");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(25)
                    .HasColumnName("country");

                entity.Property(e => e.PostalCode).HasColumnName("postalCode");

                entity.Property(e => e.Street).HasColumnName("street");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userAddress_User");
            });

            modelBuilder.Entity<UserPhone>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PhoneNumber });

                entity.ToTable("userPhone");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPhones)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userPhone_User");
            });

            modelBuilder.Entity<View>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ProductId });

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.IsFar)
                    .HasMaxLength(10)
                    .HasColumnName("isFar");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Views)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Views_customer1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Views)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Views_product");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
