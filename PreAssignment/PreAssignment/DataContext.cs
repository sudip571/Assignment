using PreAssignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PreAssignment
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions<DataContext> options)
        // : base(options)
        //{
        //}
        public DataContext() : base("DataContext")
        {
        }
        //public DataContext() : base("DataContext") => Database.SetInitializer<DataContext>(null);

        public DbSet<Product> Products { get; set; }
        public DbSet<Href> Hrefs { get; set; }
        public DbSet<Customerr> Customerrs { get; set; }
        public DbSet<CustomerrOrder> CustomerrOrders { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}