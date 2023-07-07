using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace warehouseproject
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<exchange_permission> exchange_permission { get; set; }
        public virtual DbSet<movemnt> movemnts { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<supply_permission> supply_permission { get; set; }
        public virtual DbSet<warehouse> warehouses { get; set; }
        public virtual DbSet<warehouse_product> warehouse_product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<customer>()
                .Property(e => e.customername)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.productname)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.productunit)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.warehouse_product)
                .WithRequired(e => e.product)
                .HasForeignKey(e => e.productID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.suppliername)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.warehousename)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.supervisor)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.movemnts)
                .WithOptional(e => e.warehouse)
                .HasForeignKey(e => e.fromwarehouseid);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.movemnts1)
                .WithOptional(e => e.warehouse1)
                .HasForeignKey(e => e.towarehouseid);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.warehouse_product)
                .WithRequired(e => e.warehouse)
                .WillCascadeOnDelete(false);
        }
    }
}
