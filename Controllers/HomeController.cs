using App.Data;
using App.Models;
using App.Models.ViewModels;
using App.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
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
        public IActionResult Dependent()
        {
            var user = _userManager.GetUserId(User);
            var userData = _context.ApplicationUsers.FirstOrDefault(u => u.Id == user);
            var viewModel = new DependentViewModel()
            {
                NextOfKinAddress = userData.NextOfKinAddress,
                NextOfKinDateOfBirth = userData.NextOfKinDateOfBirth,
                NextOfKinEmail= userData.NextOfKinEmail,
                NextOfKinName = userData.NextOfKinName,
                NextOfKinPhone= userData.NextOfKinPhone,
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Dependent(DependentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserId(User);
                var userData = _context.ApplicationUsers.FirstOrDefault(u => u.Id == user);
                userData.NextOfKinAddress = model.NextOfKinAddress;
                userData.NextOfKinDateOfBirth = model.NextOfKinDateOfBirth;
                userData.NextOfKinEmail = model.NextOfKinEmail;
                userData.NextOfKinName = model.NextOfKinName;
                userData.NextOfKinPhone = model.NextOfKinPhone;
                _context.ApplicationUsers.Update(userData);
                await _context.SaveChangesAsync();
                return RedirectToAction("Education");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Education()
        {
            var user = _userManager.GetUserId(User);
            var userData = _context.ApplicationUsers.FirstOrDefault(u => u.Id == user);
            var viewModel = new EducationViewModel()
            {
                StartYear = userData.StartDate,
           EndYear = userData.EndDate,
           Instituition = userData.Instituition
        };
            ViewBag.Degrees = new SelectList(MyConstants.Educations);
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Education(EducationViewModel model)
        {
            var user = _userManager.GetUserId(User);
            var userData = _context.ApplicationUsers.FirstOrDefault(u => u.Id == user);
            userData.StartDate = model.StartYear;
            userData.EndDate = model.EndYear;
            userData.HighestQualification = model.Education;
            userData.Instituition = model.Instituition;
            ViewBag.Degrees = new SelectList(MyConstants.Educations);
            _context.ApplicationUsers.Update(userData);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
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
