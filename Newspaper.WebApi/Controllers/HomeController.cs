using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newspaper.WebApi.Business.Abstract;
using Newspaper.WebApi.Business.Concrete;
using Newspaper.WebApi.Identity;
using Newspaper.WebApi.Models;

namespace Newspaper.WebApi.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private INewsService _newsService;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _logger = logger;
            this._signInManager = signInManager;
            this._userManager = userManager;
            _newsService = new NewsManager();
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.index = "active";
            var model = _newsService.GetAll();
            return View(model);
        }
        [HttpGet]
        public IActionResult Dunya()
        {
            var model = _newsService.GetAll();
            return View(model);
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var selected = _newsService.GetById(Id);
            var model = _newsService.GetAll();
            ViewBag.Selected =selected;
            return View(model);
        }
        [HttpGet]
        public IActionResult Hayat()
        {
            ViewBag.hayat = "active";
            var model = _newsService.GetAll();
            return View(model);
        }
        [HttpGet]
        public IActionResult Saglik()
        {
            ViewBag.saglik = "active";
            var model = _newsService.GetAll();
            return View(model);
        }
        [HttpGet]
        public IActionResult Ekonomi()
        {
            ViewBag.ekonomi = "active";
            var model = _newsService.GetAll();
            return View(model);
        }
        public IActionResult Seyahat()
        {
            ViewBag.Seyahat = "active";
            var model = _newsService.GetAll();
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new ApplicationUser()
            {
                Email = model.UserMail,
                UserName = model.UserName
            };
            var result = await _userManager.CreateAsync(user, model.UserPassword);
            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.UserMail);
            if(user == null)
            {
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user,model.UserPassword,false,false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
