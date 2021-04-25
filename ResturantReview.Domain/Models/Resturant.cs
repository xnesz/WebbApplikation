using System;
using System.Collections.Generic;
using System.Text;

namespace ResturantReview.Domain.Models
{
    public class Resturant
    {
        public Guid ResturantID { get; set; }
        public string ResturantName { get; set; }
        public string Category { get; set; }
        public string ResturantLink { get; set; }

        public string GoogleMapsPhoto { get; set; }

        public string StreetPhoto { get; set; }

        public List<Review> Reviews { get; set; }



    }
}
