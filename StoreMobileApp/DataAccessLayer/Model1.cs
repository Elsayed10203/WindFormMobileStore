namespace StoreMobileApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Devices> Devices { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersDetails> OrdersDetails { get; set; }
        public virtual DbSet<Retrievals> Retrievals { get; set; }
        public virtual DbSet<RetrievalsDetails> RetrievalsDetails { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Supplies> Supplies { get; set; }
        public virtual DbSet<SuppliesDetails> SuppliesDetails { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>()
                .Property(e => e.BrandNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Devices>()
                .Property(e => e.DeviceBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Devices>()
                .Property(e => e.DevicePrice)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Devices>()
                .Property(e => e.DeviceNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Devices>()
                .HasMany(e => e.OrdersDetails)
                .WithRequired(e => e.Devices)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Devices>()
                .HasMany(e => e.SuppliesDetails)
                .WithRequired(e => e.Devices)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.OrderTotalPrice)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Orders>()
                .Property(e => e.OrderNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrdersDetails)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Retrievals)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdersDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(7, 2);

            modelBuilder.Entity<OrdersDetails>()
                .Property(e => e.SellingPrice)
                .HasPrecision(7, 2);

            modelBuilder.Entity<OrdersDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(7, 2);

            modelBuilder.Entity<OrdersDetails>()
                .Property(e => e.OrderDetailsNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Retrievals>()
                .Property(e => e.RetrievalsNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Retrievals>()
                .HasMany(e => e.RetrievalsDetails)
                .WithRequired(e => e.Retrievals)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RetrievalsDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(7, 2);

            modelBuilder.Entity<RetrievalsDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(7, 2);

            modelBuilder.Entity<RetrievalsDetails>()
                .Property(e => e.RetrievalDetailsNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Roles>()
                .Property(e => e.RoleNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.SupplierPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.SupplierNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Supplies>()
                .Property(e => e.SupplyTotalPrice)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Supplies>()
                .Property(e => e.SupplyNotes)
                .IsUnicode(false);

            modelBuilder.Entity<SuppliesDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(7, 2);

            modelBuilder.Entity<SuppliesDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(7, 2);

            modelBuilder.Entity<SuppliesDetails>()
                .Property(e => e.SpDetailsNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Retrievals)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasOptional(e => e.Roles)
                .WithRequired(e => e.Users);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Supplies)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
