using Microsoft.EntityFrameworkCore;
using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.DBContext
{
    public class DataTableDesign
    {
        public void Table_UserProfile(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>().ToTable("UserProfile", "dbo").HasKey(a => a.UserProfileId);
        }
        public void Table_SecretQuestions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SecretQuestions>().ToTable("SecretQuestions", "dbo").HasKey(a => a.SecretQuestionId);
        }
        public void Table_UserDetails(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDetails>().ToTable("UserDetails", "dbo").HasKey(a => a.UserDetailsId);
        }
        public void Table_UserAddress(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAddress>().ToTable("UserAddress", "dbo").HasKey(a => a.AddressId);
        }
        public void Table_Product(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product", "dbo").HasKey(a => a.ProductId);
        }
        public void Table_Customers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>().ToTable("Customers", "dbo").HasKey(a => a.CustomerId);
        }
        public void Table_Orders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>().ToTable("Orders", "dbo").HasKey(a => a.OrderId);
        }
    }
}
