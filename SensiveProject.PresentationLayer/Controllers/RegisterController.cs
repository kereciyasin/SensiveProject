﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SensiveProject.EntityLayer.Concrete;
using SensiveProject.PresentationLayer.Models;

namespace SensiveProject.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        // Sadece bu sinifin icinden erisilir.
        // UserManager sinifini AspNet de sadece Register yapmak icin kullanilan siniftir.
        // UserManager sinifini kullanabilmek icin IdentityFramework kütüphanesini kullanmamiz gerekiyor.
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                UserName = model.UserName,
                ImageUrl = "test"
            };

            //Sifreyi disardan göndeririz. Sifrelemek icin

            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                    
                }
                return View();
            }
            

        }
    }
}
