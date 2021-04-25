using Microsoft.EntityFrameworkCore;
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

        public DbSet<Model> Models { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
