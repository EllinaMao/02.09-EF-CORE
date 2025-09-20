using System;
using System.Collections.Generic;
using DtabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DtabaseFirst;

public partial class ProductsDbContext : DbContext
{
    public ProductsDbContext()
    {
    }

    public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-BDMPPLC\\SQLEXPRESS;Database=ProductsDb;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("orders");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.OrdersCreate).HasColumnName("orders_create");
            entity.Property(e => e.OrdersDescription).HasColumnName("orders_description");
            entity.Property(e => e.OrdersName).HasColumnName("orders_name");
            entity.Property(e => e.OrdersUpdate).HasColumnName("orders_update");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("products");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ProductsCost).HasColumnName("products_cost");
            entity.Property(e => e.ProductsDescription).HasColumnName("products_description");
            entity.Property(e => e.ProductsName).HasColumnName("products_name");
            entity.Property(e => e.ProductsQuantity).HasColumnName("products_quantity");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.UsersEmail)
                .HasMaxLength(200)
                .HasColumnName("users_email");
            entity.Property(e => e.UsersLastname).HasColumnName("users_lastname");
            entity.Property(e => e.UsersLogin)
                .HasMaxLength(20)
                .HasColumnName("users_login");
            entity.Property(e => e.UsersName).HasColumnName("users_name");
            entity.Property(e => e.UsersPassword)
                .HasMaxLength(30)
                .HasColumnName("users_password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
