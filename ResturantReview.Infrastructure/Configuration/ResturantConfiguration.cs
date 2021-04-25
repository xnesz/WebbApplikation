using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResturantReview.Infrastructure.Configuration
{
    public class ResturantConfiguration : IEntityTypeConfiguration<Resturant>
    {
        public void Configure(EntityTypeBuilder<Resturant> modelBuilder)
        {
            modelBuilder
                   .HasKey(resturant => resturant.ResturantID);

            modelBuilder
                .HasMany(resturant => resturant.Reviews)
                .WithOne(review => review.Resturant)
                .HasForeignKey(review => review.ResturantID);


        }
    }
}
