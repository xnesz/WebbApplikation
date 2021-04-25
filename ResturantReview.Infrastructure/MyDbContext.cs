using Microsoft.EntityFrameworkCore;
using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ResturantReview.Infrastructure
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options)
           : base(options)
        {
        }



        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<Review> Reviews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
