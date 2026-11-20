
using Microsoft.AspNetCore.Mvc;
using FoodHub.Models;

namespace FoodHub.Controllers
{
    public class RestaurantsController : Controller
    {
          List<Restourants> restaurants = new List<Restourants>
            {
                new Restourants
                {
                    Id = 1,
                    Name = "Burger House",
                    Description = "Delicious burgers made with fresh ingredients.",
                    Address = "Nasr City, Cairo",
                    PhoneNumber = "01012345678",
                    ImageUrl = "/images/burger.jpg",
                    IsActive = true,
                    CreatedAt = new DateTime(2026, 1, 1)
                },

                new Restourants
                {
                    Id = 2,
                    Name = "Pizza Corner",
                    Description = "Fresh Italian pizza with different toppings.",
                    Address = "Dokki, Giza",
                    PhoneNumber = "01112345678",
                    ImageUrl = "/images/pizza.jpg",
                    IsActive = true,
                    CreatedAt = new DateTime(2026, 1, 2)
                },

                new Restourants
                {
                    Id = 3,
                    Name = "Sushi World",
                    Description = "Authentic Japanese sushi and Asian dishes.",
                    Address = "New Cairo, Cairo",
                    PhoneNumber = "01212345678",
                    ImageUrl = "/images/sushi.jpg",
                    IsActive = true,
                    CreatedAt = new DateTime(2026, 1, 3)
                },

                new Restourants
                {
                    Id = 4,
                    Name = "Sweet Treats",
                    Description = "Cakes, desserts and freshly baked sweets.",
                    Address = "Smouha, Alexandria",
                    PhoneNumber = "01512345678",
                    ImageUrl = "/images/desserts.jpg",
                    IsActive = false,
                    CreatedAt = new DateTime(2026, 1, 4)
                },

                new Restourants
                {
                    Id = 5,
                    Name = "Healthy Bites",
                    Description = "Healthy meals, salads and fresh juices.",
                    Address = "Sheikh Zayed, Giza",
                    PhoneNumber = "01098765432",
                    ImageUrl = "/images/healthy.jpg",
                    IsActive = true,
                    CreatedAt = new DateTime(2026, 1, 5)
                }
            };
        public IActionResult Index()
        {
            return View(restaurants);
        }
    }
}
