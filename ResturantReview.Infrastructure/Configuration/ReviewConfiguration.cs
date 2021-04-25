using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ResturantReview.Infrastructure.Configuration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> modelBuilder)
        {
            modelBuilder
                 .HasKey(review => review.ReviewID);


            modelBuilder
                .HasOne(review => review.Resturant)
                .WithMany(resturant => resturant.Reviews)
                .HasForeignKey(review => review.ResturantID);

        }
    }
}