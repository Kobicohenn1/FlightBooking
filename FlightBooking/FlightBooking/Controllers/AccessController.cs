using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using FlightBooking.Models;



namespace FlightBooking.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult User()
        {
            ClaimsPrincipal claimUser = HttpContext.User;
   
            if(claimUser.Identity.IsAuthenticated)
                return RedirectToAction ("Index", "Home");

            return View();
        }

        [HttpPost]
        public async Task <IActionResult> User(User modelUser)
        {
            if (modelUser.Email == "user@example.com" && modelUser.Password == "123") 
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,modelUser.Email),
                    new Claim("OtherProperties","Example Role")
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh= true,
                    IsPersistent = modelUser.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity),properties);

                return RedirectToAction("Index", "Home");

                
            }

            ViewData["ValidateMessage"] = "user not found";
            return View();

        }

       
    }
}
