using ResturantReview.Domain.Infreastructure;
using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResturantReview.Infrastructure.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(MyDbContext dbContext) : base(dbContext)
        {

        }
    }
}