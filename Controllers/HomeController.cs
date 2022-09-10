using App.Data;
using App.Models;
using App.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context; 
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BioData()
        {
            var user = _userManager.GetUserId(User);
            var userData = _context.ApplicationUsers.FirstOrDefault(u => u.Id == user);
            var viewModel = new Profile()
            {
                FirstName = userData.FirstName,
                LastName = userData.LastName,
                DateOfBirth = userData.DateOfBirth
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> BioData(Profile model)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserId(User);
                var userData = _context.ApplicationUsers.FirstOrDefault(u=>u.Id == user);
                userData.FirstName = model.FirstName;
                userData.LastName = model.LastName;
                userData.DateOfBirth = model.DateOfBirth;
                _context.ApplicationUsers.Update(userData);
               await _context.SaveChangesAsync();
               return RedirectToAction("Dependent");
                
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Dependent(Profile model)
        {
           
            return View(model);
        }

        [HttpPost]
        public IActionResult DependentPost(Profile model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Education()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Education(string name)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
