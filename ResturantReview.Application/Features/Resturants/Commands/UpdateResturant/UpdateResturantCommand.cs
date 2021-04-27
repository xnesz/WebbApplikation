namespace ResturantReview.Application.Features.Resturants.Commands.UpdateResturant
{
    public class UpdateResturantCommand
    {
        public string ResturantName { get; set; }
        public string Category { get; set; }
        public string ResturantLink { get; set; }

        public string GoogleMapsPhoto { get; set; }

        public string StreetPhoto { get; set; }
    }
}