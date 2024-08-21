using IsolakwamuNTU.WebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IsolakwamuNTU.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("register")]
        public ActionResult Register(UserProfile userProfile)
        {
            var token = Guid.NewGuid().ToString();
            var response = new
            {
                Token = token,
                Profile = new UserProfile
                {
                    FirstName = userProfile.FirstName,
                    LastName = userProfile.LastName,
                    Email = userProfile.Email,
                    Plan = new SubscriptionPlan
                    {
                        Id = userProfile.Plan.Id,
                        Name = userProfile.Plan.Name
                    },
                    Status = "Active" // You can dynamically set this based on your business logic
                }
            };

            return Ok(response);
        }
        [HttpPost]
        [Route("login")]
        public ActionResult Login(UserLogin userLogin)
        {
            var token = Guid.NewGuid().ToString();
            if (userLogin.Email == "khanyods3@gmail.com")
            {
                var response = new
                {
                    Token = token,
                    Profile = new UserProfile
                    {
                        FirstName = "Nokukhanya",
                        LastName = "Dumakude",
                        Email = "khanyods3@gmail.com",
                        Plan = new SubscriptionPlan
                        {
                            Id = 1,
                            Name = "Test"
                        },
                        Status = "Pending" // You can dynamically set this based on your business logic
                    }
                };
                return Ok(response);
            }
            
            return BadRequest("Invalid Credentails");

        }
    }
}
