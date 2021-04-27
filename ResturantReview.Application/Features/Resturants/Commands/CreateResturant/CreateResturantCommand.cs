using ResturantReview.Domain.Models;
using System.Collections.Generic;

namespace ResturantReview.Application.Features.Resturants.Commands.CreateResturant
{
    public class CreateResturantCommand
    {
  
        public string ResturantName { get; set; }
        public string Category { get; set; }


        public string StreetPhoto { get; set; }

        public List<Review> Reviews { get; set; }
    }
}