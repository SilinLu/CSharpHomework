using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter12
{
   
    public class OrderContext:DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            //this.Database.EnsureCreated();
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Good> Goods { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
