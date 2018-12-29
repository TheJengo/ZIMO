using ZIMO.Entities.Concretes;

namespace ZIMO.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ZimoDbContext : DbContext
    {
        public ZimoDbContext()
            : base("name=ZimoDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Borrow> tbl_Borrow { get; set; }
        public virtual DbSet<Department> tbl_Department { get; set; }
        public virtual DbSet<Employee> tbl_Employee { get; set; }
        public virtual DbSet<Garbage> tbl_Garbage { get; set; }
        public virtual DbSet<Item> tbl_Item { get; set; }
        public virtual DbSet<Role> tbl_Role { get; set; }
        public virtual DbSet<Stock> tbl_Stock { get; set; }
        public virtual DbSet<User> tbl_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("tbl_Department");
            modelBuilder.Entity<Item>().ToTable("tbl_Item");
            modelBuilder.Entity<Borrow>().ToTable("tbl_Borrow");
            modelBuilder.Entity<Role>().ToTable("tbl_Role");
            modelBuilder.Entity<User>().ToTable("tbl_User");
            modelBuilder.Entity<Stock>().ToTable("tbl_Stock");
            modelBuilder.Entity<Garbage>().ToTable("tbl_Garbage");
            modelBuilder.Entity<Employee>().ToTable("tbl_Employee");

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.Department_Id);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Garbages)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.Item_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Stocks)
                .WithOptional(e => e.Item)
                .HasForeignKey(e => e.Item_Id);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Borrows)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.Item_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.Role_Id);

            modelBuilder.Entity<Stock>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock>()
                .HasMany(e => e.Borrows)
                .WithOptional(e => e.Stock)
                .HasForeignKey(e => e.Stock_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stock>()
                .HasMany(e => e.Garbages)
                .WithRequired(e => e.Stock)
                .HasForeignKey(e => e.Stock_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Borrows)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.Employee)
                .WithRequired(e => e.User);

            //modelBuilder.Entity<Borrow>()
            //    .Property(p => p.User_Id).IsOptional();
            modelBuilder.Entity<Borrow>()
                .Property(p => p.Stock_Id).IsOptional();

        }
    }
}
