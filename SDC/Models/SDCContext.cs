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
        public virtual DbSet<Drapery> Drapery { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<JobType> JobType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<PurchaseOrderdetail> PurchaseOrderdetail { get; set; }
        public virtual DbSet<PurchaseStock> PurchaseStock { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierLogin> SupplierLogin { get; set; }
        public virtual DbSet<SupplierOrder> SupplierOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
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

            modelBuilder.Entity<Drapery>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.RoomId, e.DraperyId });

                entity.ToTable("drapery");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.RoomId)
                    .HasColumnName("room_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DraperyId).HasColumnName("drapery_id");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesignedBy).HasColumnName("designed_by");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("type_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeValue)
                    .IsRequired()
                    .HasColumnName("type_value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.DesignedByNavigation)
                    .WithMany(p => p.DraperyDesignedByNavigation)
                    .HasForeignKey(d => d.DesignedBy)
                    .HasConstraintName("FK__drapery__designe__6B24EA82");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.DraperyUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__drapery__updated__6C190EBB");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Drapery)
                    .HasForeignKey(d => new { d.ProjectId, d.RoomId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__drapery__6A30C649");
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

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("invoice");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BillAddress)
                    .IsRequired()
                    .HasColumnName("bill_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillEmail)
                    .HasColumnName("bill_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillPhone)
                    .HasColumnName("bill_phone")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillPlace)
                    .IsRequired()
                    .HasColumnName("bill_place")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Hst).HasColumnName("hst");

                entity.Property(e => e.InvoiceBy).HasColumnName("invoice_by");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasColumnType("date");

                entity.Property(e => e.ShipAddress)
                    .IsRequired()
                    .HasColumnName("ship_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPlace)
                    .IsRequired()
                    .HasColumnName("ship_place")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shipping).HasColumnName("shipping");

                entity.Property(e => e.Subtotal).HasColumnName("subtotal");

                entity.Property(e => e.Terms).HasColumnName("terms");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.InvoiceByNavigation)
                    .WithMany(p => p.InvoiceInvoiceByNavigation)
                    .HasForeignKey(d => d.InvoiceBy)
                    .HasConstraintName("FK__invoice__invoice__03F0984C");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.Invoice)
                    .HasForeignKey<Invoice>(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__invoice__project__02FC7413");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.InvoiceUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__invoice__updated__04E4BC85");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.RoomId, e.ProductId });

                entity.ToTable("items");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.RoomId)
                    .HasColumnName("room_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Colour).HasColumnName("colour");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesignedBy).HasColumnName("designed_by");

                entity.Property(e => e.Dimension)
                    .HasColumnName("dimension")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pattern).HasColumnName("pattern");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RetailAmount)
                    .HasColumnName("retail_amount")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RetailPrice)
                    .HasColumnName("retail_price")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.DesignedByNavigation)
                    .WithMany(p => p.ItemsDesignedByNavigation)
                    .HasForeignKey(d => d.DesignedBy)
                    .HasConstraintName("FK__items__designed___6FE99F9F");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ItemsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__items__updated_b__70DDC3D8");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => new { d.ProjectId, d.RoomId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__items__6EF57B66");
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

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("project");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesignedBy).HasColumnName("designed_by");

                entity.Property(e => e.ProjectTag)
                    .IsRequired()
                    .HasColumnName("project_tag")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__project__client___60A75C0F");

                entity.HasOne(d => d.DesignedByNavigation)
                    .WithMany(p => p.ProjectDesignedByNavigation)
                    .HasForeignKey(d => d.DesignedBy)
                    .HasConstraintName("FK__project__designe__619B8048");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ProjectUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__project__updated__628FA481");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.OrderId });

                entity.ToTable("purchase_order");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EstimatedShipdate)
                    .HasColumnName("estimated_shipdate")
                    .HasColumnType("date");

                entity.Property(e => e.OrderedBy).HasColumnName("ordered_by");

                entity.Property(e => e.ShippingAddress)
                    .IsRequired()
                    .HasColumnName("shipping_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPhone)
                    .HasColumnName("shipping_phone")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPlace)
                    .IsRequired()
                    .HasColumnName("shipping_place")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.OrderedByNavigation)
                    .WithMany(p => p.PurchaseOrderOrderedByNavigation)
                    .HasForeignKey(d => d.OrderedBy)
                    .HasConstraintName("FK__purchase___order__75A278F5");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__purchase___proje__73BA3083");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__purchase___suppl__74AE54BC");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.PurchaseOrderUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__purchase___updat__76969D2E");
            });

            modelBuilder.Entity<PurchaseOrderdetail>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.OrderId, e.ProductId });

                entity.ToTable("purchase_orderdetail");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Colour).HasColumnName("colour");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryStatus)
                    .HasColumnName("delivery_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension)
                    .HasColumnName("dimension")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderedBy).HasColumnName("ordered_by");

                entity.Property(e => e.Pattern).HasColumnName("pattern");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.OrderedByNavigation)
                    .WithMany(p => p.PurchaseOrderdetailOrderedByNavigation)
                    .HasForeignKey(d => d.OrderedBy)
                    .HasConstraintName("FK__purchase___order__7A672E12");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.PurchaseOrderdetailUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__purchase___updat__7B5B524B");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderdetail)
                    .HasForeignKey(d => new { d.ProjectId, d.OrderId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__purchase_orderde__797309D9");
            });

            modelBuilder.Entity<PurchaseStock>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.OrderId, e.ProductId });

                entity.ToTable("purchase_stock");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Colour).HasColumnName("colour");

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

                entity.Property(e => e.Pattern).HasColumnName("pattern");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ReceivedBy).HasColumnName("received_by");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.ReceivedByNavigation)
                    .WithMany(p => p.PurchaseStockReceivedByNavigation)
                    .HasForeignKey(d => d.ReceivedBy)
                    .HasConstraintName("FK__purchase___recei__7F2BE32F");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.PurchaseStockUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__purchase___updat__00200768");

                entity.HasOne(d => d.PurchaseOrderdetail)
                    .WithOne(p => p.PurchaseStock)
                    .HasForeignKey<PurchaseStock>(d => new { d.ProjectId, d.OrderId, d.ProductId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__purchase_stock__7E37BEF6");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.RoomId });

                entity.ToTable("room");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.RoomId)
                    .HasColumnName("room_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BotFloor)
                    .HasColumnName("bot_floor")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Control)
                    .HasColumnName("control")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesignedBy).HasColumnName("designed_by");

                entity.Property(e => e.FloorCeiling)
                    .HasColumnName("floor_ceiling")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.InsideDepth)
                    .HasColumnName("inside_depth")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.InsideHorizontal)
                    .HasColumnName("inside_horizontal")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.InsideVertical)
                    .HasColumnName("inside_vertical")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.LootObject)
                    .HasColumnName("loot_object")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OutsideHorizontal)
                    .HasColumnName("outside_horizontal")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.OutsideVertical)
                    .HasColumnName("outside_vertical")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.RootObject)
                    .HasColumnName("root_object")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Sill)
                    .HasColumnName("sill")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotCeiling)
                    .HasColumnName("tot_ceiling")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.TrimDepth)
                    .HasColumnName("trim_depth")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.DesignedByNavigation)
                    .WithMany(p => p.RoomDesignedByNavigation)
                    .HasForeignKey(d => d.DesignedBy)
                    .HasConstraintName("FK__room__designed_b__66603565");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Room)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__room__project_id__656C112C");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.RoomUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__room__updated_by__6754599E");
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
                    .HasMaxLength(50)
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
