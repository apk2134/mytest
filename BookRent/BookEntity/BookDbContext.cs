namespace BookEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookDbContext : DbContext
    {
        public BookDbContext()
            : base("name=BookDbContext")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<BookCategory> BookCategories { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BooksAuthor> BooksAuthors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CoustomerDetail> CoustomerDetails { get; set; }
        public virtual DbSet<CoustomerOrder> CoustomerOrders { get; set; }
        public virtual DbSet<CoustomerSubscription> CoustomerSubscriptions { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.AddressId)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.House)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Locality)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.pin)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.landmark)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.CoustomerDetails)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.AuthorId)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.AuthorName)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.BooksAuthors)
                .WithRequired(e => e.Author)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.BillId)
                .IsUnicode(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.CoustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.SubscriptionId)
                .IsUnicode(false);

            modelBuilder.Entity<BookCategory>()
                .Property(e => e.CategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<BookCategory>()
                .Property(e => e.BookId)
                .IsUnicode(false);

            modelBuilder.Entity<BookCategory>()
                .Property(e => e.BookCategory1)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.BookId)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.BookName)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Publisher_)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.BookCategories)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.BooksAuthors)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BooksAuthor>()
                .Property(e => e.AuthorId)
                .IsUnicode(false);

            modelBuilder.Entity<BooksAuthor>()
                .Property(e => e.BookId)
                .IsUnicode(false);

            modelBuilder.Entity<BooksAuthor>()
                .Property(e => e.BookAuthorid)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.BookCategories)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoustomerDetail>()
                .Property(e => e.CoustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<CoustomerDetail>()
                .Property(e => e.AddressId)
                .IsUnicode(false);

            modelBuilder.Entity<CoustomerDetail>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<CoustomerDetail>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<CoustomerDetail>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.CoustomerDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoustomerDetail>()
                .HasMany(e => e.CoustomerOrders)
                .WithRequired(e => e.CoustomerDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoustomerDetail>()
                .HasMany(e => e.CoustomerSubscriptions)
                .WithRequired(e => e.CoustomerDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoustomerDetail>()
                .HasMany(e => e.PaymentDetails)
                .WithRequired(e => e.CoustomerDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoustomerOrder>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<CoustomerOrder>()
                .Property(e => e.CoustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<CoustomerSubscription>()
                .Property(e => e.CoustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<CoustomerSubscription>()
                .Property(e => e.SubscriptionId)
                .IsUnicode(false);

            modelBuilder.Entity<CoustomerSubscription>()
                .Property(e => e.CustomerSubscription)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.BookId)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentDetail>()
                .Property(e => e.PaymentId)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentDetail>()
                .Property(e => e.CoustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentDetail>()
                .Property(e => e.PaymentSatus)
                .IsUnicode(false);

            modelBuilder.Entity<Subscription>()
                .Property(e => e.SubscriptionID)
                .IsUnicode(false);

            modelBuilder.Entity<Subscription>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.Subscription)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscription>()
                .HasMany(e => e.CoustomerSubscriptions)
                .WithRequired(e => e.Subscription)
                .WillCascadeOnDelete(false);
        }
    }
}
