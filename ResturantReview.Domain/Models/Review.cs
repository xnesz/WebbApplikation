using System;
using System.Collections.Generic;
using System.Text;

namespace ResturantReview.Domain.Models
{
    public class Review
    {
        public Guid ReviewID { get; set; }

        public string Title { get; set; }
        public string Summary { get; set; }

        public string ReviewTest { get; set; }

        public int Rating { get; set; }

        public Guid ResturantID { get; set; }

        public Resturant Resturant { get; set; }

    }
}
