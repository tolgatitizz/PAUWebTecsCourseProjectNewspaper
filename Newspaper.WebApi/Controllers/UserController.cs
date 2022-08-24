using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newspaper.WebApi.Business.Abstract;
using Newspaper.WebApi.Business.Concrete;
using Newspaper.WebApi.Data.Abstract;
using Newspaper.WebApi.Models;

namespace Newspaper.WebApi.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private INewsService _newsService;
        public UserController()
        {
            _newsService = new NewsManager();
        }
        public IActionResult Index()
        {
            var model = _newsService.GetAll();

            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Haber haber)
        {
            _newsService.Add(haber);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            _newsService.Delete(Id);
            return RedirectToAction("Index");
        }
        public IActionResult Put(int Id)
        {
            var model =_newsService.GetById(Id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Put(Haber haber)
        {
            _newsService.Update(haber);
            return RedirectToAction("Index");
        }

    }
}
