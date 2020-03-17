using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SDC_API.Models
{
    public partial class SDCContext : DbContext
    {
        public SDCContext()
        {
        }

        public SDCContext(DbContextOptions<SDCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<CodeCategory> CodeCategory { get; set; }
        public virtual DbSet<CodeList> CodeList { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<JobType> JobType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierLogin> SupplierLogin { get; set; }
        public virtual DbSet<SupplierOrder> SupplierOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=34.73.191.28;Database=SDC;Uid=sqlserver;Password=Conestoga20;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Associations)
                    .HasColumnName("associations")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BizType)
                    .HasColumnName("biz_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BizYear)
                    .HasColumnName("biz_year")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Hst)
                    .HasColumnName("hst")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mailing)
                    .HasColumnName("mailing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Recommender)
                    .HasColumnName("recommender")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasColumnName("reference")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Term)
                    .HasColumnName("term")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("date");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CodeCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("code_category");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CodeList>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.CodeId });

                entity.ToTable("code_list");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CodeId).HasColumnName("code_id");

                entity.Property(e => e.CodeName)
                    .IsRequired()
                    .HasColumnName("code_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CodeList)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__code_list__categ__59FA5E80");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("employee");

                entity.HasIndex(e => e.UserName)
                    .HasName("UQ__employee__7C9273C4276C19F0")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__employee__job_id__4CA06362");
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.ToTable("job_type");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasColumnName("job_title")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => new { e.SupplierId, e.ProductId });

                entity.ToTable("product");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookNumber)
                    .HasColumnName("book_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension)
                    .HasColumnName("dimension")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Finishes)
                    .HasColumnName("finishes")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__product__created__5CD6CB2B");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("supplier");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RepEmail)
                    .HasColumnName("rep_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepName)
                    .HasColumnName("rep_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__supplier__create__4F7CD00D");
            });

            modelBuilder.Entity<SupplierLogin>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("supplier_login");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplier_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Supplier)
                    .WithOne(p => p.SupplierLogin)
                    .HasForeignKey<SupplierLogin>(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__supplier___suppl__52593CB8");
            });

            modelBuilder.Entity<SupplierOrder>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("supplier_order");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplier_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Books).HasColumnName("books");

                entity.Property(e => e.DiscountNotes)
                    .HasColumnName("discount_notes")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountOr)
                    .HasColumnName("discount_or")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountOw)
                    .HasColumnName("discount_ow")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LeadTime)
                    .HasColumnName("lead_time")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OrderingEmail)
                    .HasColumnName("ordering_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderingMethod)
                    .HasColumnName("ordering_method")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("payment_method")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNotes)
                    .HasColumnName("payment_notes")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PriceFound)
                    .HasColumnName("price_found")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReq).HasColumnName("sales_req");

                entity.Property(e => e.Terms)
                    .HasColumnName("terms")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Supplier)
                    .WithOne(p => p.SupplierOrder)
                    .HasForeignKey<SupplierOrder>(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__supplier___suppl__5535A963");
            });
        }
    }
}
