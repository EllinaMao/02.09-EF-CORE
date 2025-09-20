using Microsoft.EntityFrameworkCore;
using _02._09_Вступ_EF_CORE.Models;

namespace _02._09_Вступ_EF_CORE
{
    public class ProductsDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public ProductsDbContext()
        {
        }

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=DESKTOP-BDMPPLC\\SQLEXPRESS;Database=ProductsDb;TrustServerCertificate=true;Trusted_Connection=True;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureProduct(modelBuilder);
            ConfigureOrder(modelBuilder);
            ConfigureUser(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
        ///<summary>   
        ///1. Магазин – Product
        ///1) + Id: Guid
        ///2) + Name: string
        ///3) + Cost: double
        ///4) + Description: string
        ///5) + Quantity: int
        ///</summary>
        private void ConfigureProduct(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");
                entity.HasKey(p => p.Id);

                entity.Property(p => p.Name)
                      .HasColumnName("products_name")
                      .HasColumnType("nvarchar(max)")
                      .IsRequired();

                entity.Property(p => p.Cost)
                      .HasColumnName("products_cost")
                      .HasColumnType("float")
                      .IsRequired();

                entity.Property(d => d.Description)
                       .HasColumnName("products_description")
                       .HasColumnType("nvarchar(max)");

                entity.Property(q=> q.Quantity)
                      .HasColumnName("products_quantity")
                      .HasColumnType("int")
                      .IsRequired();
            });
        }
        ///<summary>
        ///3. Замовлення – Order
        ///1) + Id: Guid
        ///2) + Name: string
        ///3) + Create: datetime
        ///4) + Update: datetime
        ///5) + Description: string
        ///</summary>
        private void ConfigureOrder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");
                entity.HasKey(o => o.Id);

                entity.Property(o => o.Name)
                      .HasColumnName("orders_name")
                      .HasColumnType("nvarchar(max)")
                      .IsRequired();

                entity.Property(o => o.Create)
                      .HasColumnName("orders_create")
                      .HasColumnType("datetime2")
                      .IsRequired();

                entity.Property(o => o.Update)
                      .HasColumnName("orders_update")
                      .HasColumnType("datetime2")
                      .IsRequired();

                entity.Property(o => o.Description)
                      .HasColumnName("orders_description")
                      .HasColumnType("nvarchar(max)");
            });
        }
        ///<summary>      
        ///2. Користувач – User
        ///1) + Id: Guid
        ///2) + Name: string
        ///3) + LastName: string
        ///4) + Login: string
        ///5) + Password: string
        ///6) + Email: string
        ///</summary>


        private void ConfigureUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");
                entity.HasKey(u => u.Id);

                entity.Property(u => u.Name)
                      .HasColumnName("users_name")
                      .HasColumnType("nvarchar(max)")
                      .IsRequired();

                entity.Property(u => u.LastName)
                      .HasColumnName("users_lastname")
                      .HasColumnType("nvarchar(max)")
                      .IsRequired();

                entity.Property(u => u.Login)
                      .HasColumnName("users_login")
                      .HasColumnType("nvarchar(20)")
                      .IsRequired();

                entity.Property(u => u.Password)
                      .HasColumnName("users_password")
                      .HasColumnType("nvarchar(30)")
                      .IsRequired();

                entity.Property(u => u.Email)
                      .HasColumnName("users_email")
                      .HasColumnType("nvarchar(200)");
            });
        }
    }
}
