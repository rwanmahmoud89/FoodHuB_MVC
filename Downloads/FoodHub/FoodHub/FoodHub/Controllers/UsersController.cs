
using Microsoft.AspNetCore.Mvc;
using FoodHub.Models;

namespace FoodHub.Controllers
{
    public class UsersController : Controller
    {
         List<User> users = new List<User>
            {
                new User
                {
                    Id = 1,
                    FullName = "Ahmed Mohamed",
                    Email = "ahmed@gmail.com",
                    PasswordHash = "hashed_password_1",
                    PhoneNumber = "01012345678",
                    Address = "Sohag, Egypt",
                    Role = "Customer",
                    CreatedAt = new DateTime(2026, 1, 10)
                },

                new User
                {
                    Id = 2,
                    FullName = "Sara Ali",
                    Email = "sara@gmail.com",
                    PasswordHash = "hashed_password_2",
                    PhoneNumber = "01112345678",
                    Address = "Cairo, Egypt",
                    Role = "Customer",
                    CreatedAt = new DateTime(2026, 1, 12)
                },

                new User
                {
                    Id = 3,
                    FullName = "Omar Hassan",
                    Email = "omar@gmail.com",
                    PasswordHash = "hashed_password_3",
                    PhoneNumber = "01212345678",
                    Address = "Alexandria, Egypt",
                    Role = "RestaurantOwner",
                    CreatedAt = new DateTime(2026, 1, 15)
                },

                new User
                {
                    Id = 4,
                    FullName = "Mona Ibrahim",
                    Email = "mona@gmail.com",
                    PasswordHash = "hashed_password_4",
                    PhoneNumber = "01512345678",
                    Address = "Giza, Egypt",
                    Role = "Customer",
                    CreatedAt = new DateTime(2026, 1, 18)
                },

                new User
                {
                    Id = 5,
                    FullName = "Admin User",
                    Email = "admin@foodhub.com",
                    PasswordHash = "hashed_password_5",
                    PhoneNumber = "01098765432",
                    Address = "Cairo, Egypt",
                    Role = "Admin",
                    CreatedAt = new DateTime(2026, 1, 20)
                }
            };
        public IActionResult Index()
        {
           

            return View(users);
        }
    }
}
