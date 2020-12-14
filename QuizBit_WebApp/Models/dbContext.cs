namespace QuizBit_WebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbContext : DbContext
    {
        public dbContext()
            : base("name=dbContextQuizBit")
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public virtual DbSet<InventoryItem> InventoryItems { get; set; }
        public virtual DbSet<InventoryItemCategory> InventoryItemCategories { get; set; }
        public virtual DbSet<Kitchen> Kitchens { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<PromotionBranchApply> PromotionBranchApplies { get; set; }
        public virtual DbSet<PromotionDetail> PromotionDetails { get; set; }
        public virtual DbSet<PromotionQuantityCondition> PromotionQuantityConditions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SAInvoice> SAInvoices { get; set; }
        public virtual DbSet<SendKitchen> SendKitchens { get; set; }
        public virtual DbSet<TableMapping> TableMappings { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserJoinRole> UserJoinRoles { get; set; }
        public virtual DbSet<SAInvoiceDetail> SAInvoiceDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.SendKitchens)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.SenderID);

            modelBuilder.Entity<InventoryItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.QuantityAddition)
                .IsFixedLength();

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.CookedQuantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.ServedQuantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.CookingQuantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Promotion>()
                .Property(e => e.DiscountRate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Promotion>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Promotion>()
                .Property(e => e.ConditionAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Promotion>()
                .HasMany(e => e.PromotionBranchApplies)
                .WithOptional(e => e.Promotion)
                .HasForeignKey(e => e.PromitionID);

            modelBuilder.Entity<Promotion>()
                .HasMany(e => e.PromotionDetails)
                .WithOptional(e => e.Promotion)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Promotion>()
                .HasMany(e => e.PromotionQuantityConditions)
                .WithOptional(e => e.Promotion)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PromotionDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PromotionDetail>()
                .Property(e => e.ConditionQuantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PromotionDetail>()
                .Property(e => e.DiscountRate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PromotionDetail>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PromotionDetail>()
                .Property(e => e.Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PromotionQuantityCondition>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.UserJoinRoles)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAInvoice>()
                .Property(e => e.TotalSaleAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoice>()
                .Property(e => e.TotalDiscountAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoice>()
                .Property(e => e.ServiceRate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoice>()
                .Property(e => e.ServiceAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoice>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoice>()
                .Property(e => e.VATRate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoice>()
                .Property(e => e.VATAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoice>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoice>()
                .Property(e => e.ReceiveAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoice>()
                .Property(e => e.ReturnAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoice>()
                .Property(e => e.OtherPromotionAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoiceDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoiceDetail>()
                .Property(e => e.QuantityAddition)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoiceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoiceDetail>()
                .Property(e => e.SaleAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoiceDetail>()
                .Property(e => e.DiscountRate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAInvoiceDetail>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(18, 4);
        }
    }
}
