using ResturantReview.Domain.Models;
using System.Collections.Generic;

namespace ResturantReview.Application.Features.Resturants.Queries.GetResturantQuery
{
    public class ResturantDetalResponse
    {
        //Response klass som innehåller det man vill skicka tillbaka

        public string ResturantName { get; set; }
        public string Category { get; set; }
        public string ResturantLink { get; set; }

        public string GoogleMapsPhoto { get; set; }

        public string StreetPhoto { get; set; }

        public List<Review> Reviews { get; set; }
    }
}