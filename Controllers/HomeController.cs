using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TravelTripProje.Models;
using System.Collections.Generic;
using System.Linq;

namespace TravelTripProje.Controllers
{
    public class HomeController : Controller
    {
        private static List<Destination> destinations = new List<Destination>
        {
            new Destination { Id = 1, Name = "Istanbul", Description = "Experience the rich history and vibrant culture of Istanbul...", Image = "ayasofya.jpeg", Views = 150, Likes = 30, Comments = new List<string> { "Amazing place!", "Must visit!" } },
            new Destination { Id = 2, Name = "Cappadocia", Description = "Marvel at the fairy chimneys and take a hot air balloon ride...", Image = "Peri-Bacalari.jpg", Views = 120, Likes = 25, Comments = new List<string> { "Beautiful!", "Wonderful experience!" } },
            new Destination { Id = 3, Name = "Antalya", Description = "Relax on the stunning beaches of Antalya and explore its historical ruins...", Image = "konyaalti-plaji.jfif", Views = 100, Likes = 20, Comments = new List<string> { "Love it!", "Great place to relax!" } },
            new Destination { Id = 4, Name = "Pamukkale", Description = "Pamukkale is famous for its white travertine terraces and the ancient city of Hierapolis...", Image = "traverten-teraslari.jpg", Views = 80, Likes = 15, Comments = new List<string> { "Stunning!", "Beautiful natural wonder!" } },
            new Destination { Id = 5, Name = "Ephesus", Description = "Ephesus is renowned for its ruins from the Roman period. The Temple of Artemis, one of the Seven Wonders of the Ancient World, is located here...", Image = "Celsus-kutuphanesi.jpg", Views = 90, Likes = 18, Comments = new List<string> { "Historical marvel!", "A must-see!" } },
            new Destination { Id = 6, Name = "Bodrum", Description = "Bodrum is famous for its vibrant nightlife, luxurious marina, and historical ruins...", Image = "bodrum-kalesi.jpg", Views = 110, Likes = 22, Comments = new List<string> { "Amazing nightlife!", "Beautiful place!" } },
            new Destination { Id = 7, Name = "Fethiye", Description = "Fethiye is known for its stunning beaches and natural wonders...", Image = "oludeniz.jpg", Views = 95, Likes = 19, Comments = new List<string> { "Gorgeous beaches!", "Loved it!" } },
            new Destination { Id = 8, Name = "Cesme", Description = "Cesme is one of the popular holiday resorts of the Aegean Region...", Image = "cesme-kalesi-1.jpg", Views = 85, Likes = 17, Comments = new List<string> { "Beautiful beaches!", "Great place to relax!" } },
            new Destination { Id = 9, Name = "Trabzon", Description = "Trabzon is known as the pearl of the Black Sea Region...", Image = "uzungol-gezi-rehberi-600x450.jpg", Views = 70, Likes = 14, Comments = new List<string> { "Beautiful scenery!", "Loved the nature!" } },
            new Destination { Id = 10, Name = "Izmir", Description = "Izmir is Turkey's third-largest city. It stands out with its coastline, historical and cultural richness...", Image = "kordonboyu-izmir.jpg", Views = 105, Likes = 21, Comments = new List<string> { "Vibrant city!", "So much to see!" } }
        };

        public IActionResult Index()
        {
            var topDestinations = destinations.OrderByDescending(d => d.Views).Take(3).ToList();
            return View(topDestinations);
        }

        public IActionResult About()
        {
            var model = new AboutModel
            {
                Title = "About Our Company",
                Description = "Welcome to Easy-Trip! We have compiled the most beautiful and popular holiday destinations, hotels, and restaurants in Turkey for you. As Easy-Trip, we aim to provide you with the most up-to-date and accurate information to help you plan your vacations in the best way possible. Our goal is to offer you an unforgettable travel experience."
            };
            return View(model);
        }

        public IActionResult Guides()
        {
            var guides = new List<TravelGuideModel>
    {
        new TravelGuideModel
        {
            Title = "Guide to Istanbul",
            Description = "Discover the best places to visit in Istanbul, including historical sites, museums, and local food spots.",
            MustVisitAttractions = "Hagia Sophia, Blue Mosque, Topkapi Palace, Grand Bazaar, Bosphorus Cruise",
            Activities = "Doner Kebab, Baklava, Turkish Delight, Meze, Turkish Tea"
        },
        new TravelGuideModel
        {
            Title = "Guide to Cappadocia",
            Description = "Explore the unique landscape of Cappadocia, famous for its fairy chimneys and hot air balloon rides.",
            MustVisitAttractions = "Goreme Open Air Museum, Underground Cities (Derinkuyu, Kaymakli), Fairy Chimneys, Uchisar Castle",
            Activities = "Hot Air Balloon Rides, Hiking, ATV Tours"
        },
        new TravelGuideModel
        {
            Title = "Guide to Antalya",
            Description = "Find out the best beaches, historical ruins, and luxury resorts in Antalya.",
            MustVisitAttractions = "Konyaalti Beach, Kaleici (Old Town), Aspendos Theatre, Duden Waterfalls",
            Activities = "Beach Resorts, Scuba Diving, Historical Tours"
        },
        new TravelGuideModel
        {
            Title = "Guide to Pamukkale",
            Description = "Learn about the stunning travertine terraces and ancient city of Hierapolis in Pamukkale.",
            MustVisitAttractions = "Travertine Terraces, Hierapolis Ancient City, Cleopatra’s Pool",
            Activities = "Thermal Baths, Historical Tours, Photography"
        },
        new TravelGuideModel
        {
            Title = "Guide to Ephesus",
            Description = "Visit the ancient city of Ephesus and discover its rich history and well-preserved ruins.",
            MustVisitAttractions = "Library of Celsus, Great Theatre, Temple of Artemis, House of Virgin Mary",
            Activities = "Historical Tours, Archaeology, Walking Tours"
        },
        new TravelGuideModel
        {
            Title = "Guide to Bodrum",
            Description = "Enjoy the vibrant nightlife, beautiful marinas, and historical sites in Bodrum.",
            MustVisitAttractions = "Bodrum Castle, Marina, Mausoleum at Halicarnassus, Ancient Theatre",
            Activities = "Sailing, Nightlife, Beach Resorts"
        },
        new TravelGuideModel
        {
            Title = "Guide to Fethiye",
            Description = "Explore the beautiful beaches, Butterfly Valley, and the Lycian Way in Fethiye.",
            MustVisitAttractions = "Oludeniz Beach, Butterfly Valley, Saklikent Gorge, Lycian Rock Tombs",
            Activities = "Paragliding, Boat Tours, Hiking"
        },
        new TravelGuideModel
        {
            Title = "Guide to Cesme",
            Description = "Relax on the pristine beaches and enjoy the historic charm of Cesme.",
            MustVisitAttractions = "Cesme Castle, Ilica Beach, Alacati, Cesme Marina",
            Activities = "Windsurfing, Beach Resorts, Historical Tours"
        },
        new TravelGuideModel
        {
            Title = "Guide to Trabzon",
            Description = "Discover the natural beauty and historical sites of Trabzon in the Black Sea region.",
            MustVisitAttractions = "Sumela Monastery, Uzungol, Trabzon Hagia Sophia Museum, Ataturk Mansion",
            Activities = "Hiking, Nature Tours, Historical Tours"
        },
        new TravelGuideModel
        {
            Title = "Guide to Izmir",
            Description = "Explore the vibrant city of Izmir, its coastline, and nearby historical sites like Ephesus.",
            MustVisitAttractions = "Izmir Clock Tower, Kordonboyu, Agora Open Air Museum, Kadifekale",
            Activities = "Historical Tours, Shopping, Dining"
        }
    };
            return View(guides);
        }


        public IActionResult Contact()
        {
            var model = new ContactModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                // You can process the model data here.
                // For example, sending an email, saving to a database, etc.

                // After processing, you can redirect to a thank you page.
                return RedirectToAction("ThankYou");
            }

            return View(model);
        }

        public IActionResult Destinations()
        {
            var topLikedDestinations = destinations.OrderByDescending(d => d.Likes).Take(3).ToList();
            var topCommentedDestinations = destinations.OrderByDescending(d => d.Comments.Count).Take(3).ToList();

            var model = new DestinationsModel
            {
                PopularDestinations = topLikedDestinations.Union(topCommentedDestinations).Distinct().ToList(),
                Hotels = new List<string> { "Hotel Istanbul", "Hotel Cappadocia", "Hotel Antalya", "Hotel Pamukkale", "Hotel Ephesus", "Hotel Bodrum", "Hotel Fethiye", "Hotel Cesme", "Hotel Trabzon", "Hotel Izmir" },
                Activities = new List<string> { "Snorkeling", "City Tours", "Hiking" }
            };
            return View(model);
        }

        public IActionResult DestinationDetails(int id)
        {
            var destination = destinations.FirstOrDefault(d => d.Id == id);
            if (destination != null)
            {
                destination.Views++;
                return View(destination);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult LikeDestination(int id)
        {
            var destination = destinations.FirstOrDefault(d => d.Id == id);
            if (destination != null)
            {
                destination.Likes++;
                return Ok(new { likes = destination.Likes });
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult CommentDestination(int id, string comment)
        {
            var destination = destinations.FirstOrDefault(d => d.Id == id);
            if (destination != null)
            {
                destination.Comments.Add(comment);
                return Ok(new { comments = destination.Comments });
            }
            return NotFound();
        }

        public IActionResult Hotels()
        {
            return View();
        }

        public IActionResult Restaurants()
        {
            return View();
        }

        public IActionResult BeachResorts()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult Error()
        {
            var errorViewModel = new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier };
            return View(errorViewModel);
        }
    }
}
