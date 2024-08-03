using System.Collections.Generic;

namespace TravelTripProje.Models
{
    public class DestinationsModel
    {
        public List<Destination> PopularDestinations { get; set; } = new List<Destination>();
        public List<string> Hotels { get; set; } = new List<string>();
        public List<string> Activities { get; set; } = new List<string>();
    }

    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public List<string> Comments { get; set; } = new List<string>();
    }

}
