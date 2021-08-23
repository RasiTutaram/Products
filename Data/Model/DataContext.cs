using Microsoft.EntityFrameworkCore;
using Products.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Products.DBContext
{
    public class DataContext : DbContext
    {
        DataTableDesign _TableDesign = new DataTableDesign();

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<SecretQuestions> SecretQuestions { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<UserAddress> UserAddress { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }


        public Task<int> SaveChangesAsync(string currentUserName, CancellationToken cancellationToken = default(CancellationToken))
        {
            return SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            _TableDesign.Table_UserProfile(modelBuilder);
            _TableDesign.Table_SecretQuestions(modelBuilder);
            _TableDesign.Table_UserDetails(modelBuilder);
            _TableDesign.Table_UserAddress(modelBuilder);
            _TableDesign.Table_Product(modelBuilder);
            _TableDesign.Table_Customers(modelBuilder);
            _TableDesign.Table_Orders(modelBuilder);
        }
    }
}
