using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaStore.Context
{
    public partial class PizzaAppDBContext : DbContext
    {
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<Slocation> Slocation { get; set; }
        public virtual DbSet<Users> Users { get; set; }

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.DatePlaced).HasColumnType("datetime");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.LoNameNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.LoName)
                    .HasConstraintName("FK_LoName");

                entity.HasOne(d => d.PizzaNameNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PizzaName)
                    .HasConstraintName("FK_PizzaName");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK_UserName");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.Property(e => e.PizzaDesc).HasMaxLength(200);

                entity.Property(e => e.PizzaName).HasMaxLength(20);

                entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<Slocation>(entity =>
            {
                entity.ToTable("SLocation");

                entity.Property(e => e.LoName).HasMaxLength(20);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.Password).HasMaxLength(40);

                entity.Property(e => e.Phone).HasMaxLength(11);

                entity.Property(e => e.UserName).HasMaxLength(20);

                entity.HasOne(d => d.DefaultLoNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DefaultLo)
                    .HasConstraintName("FK_Location");
            });
        }
    }
}
