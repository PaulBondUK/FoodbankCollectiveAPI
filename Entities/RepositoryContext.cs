using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        public virtual DbSet<Foodbank> Foodbanks { get; set; }
        public virtual DbSet<Location> Locations { get; set; }

        // Fluent API configs

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Foodbank>(entity =>
            {
                entity.HasKey(f => f.Id);

                entity.Property(f => f.Id).ValueGeneratedOnAdd();

                entity.Property(f => f.Name).IsRequired().HasMaxLength(100);

                entity.Property(f => f.Website).HasMaxLength(100);

                entity.Property(f => f.EmailAddress).HasMaxLength(100);

                entity.Property(f => f.ContactNumber).IsRequired().HasMaxLength(15);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasOne(l => l.Foodbank)
                    .WithMany(f => f.Locations)
                    .HasForeignKey(l => l.FoodbankId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasKey(l => l.Id);

                entity.Property(l => l.Id).ValueGeneratedOnAdd();

                entity.Property(l => l.AddressLine1).IsRequired().HasMaxLength(100);

                entity.Property(l => l.AddressLine2).HasMaxLength(100);

                entity.Property(l => l.AddressTownOrCity).IsRequired().HasMaxLength(30);

                entity.Property(l => l.AddressCounty).HasMaxLength(30);

                entity.Property(l => l.AddressPostcode).IsRequired().HasMaxLength(10);
            });
        }
    }
}

//modelBuilder.Entity<Student>()
//    .HasOne<Grade>(s => s.Grade)
//    .WithMany(g => g.Students)
//    .HasForeignKey(s => s.CurrentGradeId);

//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    //Write Fluent API configurations here

//    //Property Configurations
//    modelBuilder.Entity<Student>()
//            .Property(s => s.StudentId)
//            .HasColumnName("Id")
//            .HasDefaultValue(0)
//            .IsRequired();
//}

//modelBuilder.Entity<OrderDetails>(entity =>
//{
//    entity.HasKey(e => e.OrderDetailId);

//    entity.HasIndex(e => e.OrderId);

//    entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

//    entity.Property(e => e.OrderId).HasColumnName("OrderID");

//    entity.Property(e => e.ProductId).HasColumnName("ProductID");

//    entity.HasOne(d => d.Order)
//        .WithMany(p => p.OrderDetails)
//        .HasForeignKey(d => d.OrderId);
//});

//modelBuilder.Entity<Orders>(entity =>
//{
//    entity.HasKey(e => e.OrderId);

//    entity.Property(e => e.OrderId).HasColumnName("OrderID");

//    entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

//    entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
//});