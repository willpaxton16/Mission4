using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {

        private UpdateListContext _listContext { get; set; }
        public HomeController(ILogger<HomeController> logger, UpdateListContext appName)
        {
            _listContext = appName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieList ()
        {
            ViewBag.Categories = _listContext.Categories.ToList();
            var application = _listContext.Responses.ToList();
            return View(application);
        }
        //[HttpPost]
        //public IActionResult MovieList(UpdateList DateResponse)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _listContext.Add(DateResponse);
        //        _listContext.SaveChanges();
        //        return View("Confirmation", DateResponse);
        //    }
        //    else
        //    {
        //        ViewBag.Majors = _listContext.Categories.ToList();
        //        return View("MovieList");
        //    }

        
        //public IActionResult MovieUpdate(UpdateList NewMovie)
        //{
        //    _listContext.Add(NewMovie);
        //    _listContext.SaveChanges();
        //    return View("Confirmation");
        //}
        [HttpGet]
        public IActionResult MovieEdit(int movieId)
        {
            ViewBag.Categories = _listContext.Categories.ToList();

            var movie = _listContext.Responses.Single(x => x.MovieId == movieId);
            return View("MovieUpdate", movie);

        }
        [HttpPost]
        public IActionResult MovieEdit(UpdateList ul)
        {
            _listContext.Update(ul);
            _listContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int movieId)
        {
            var application = _listContext.Responses
                .Single(x => x.MovieId == movieId);

            return View(application);
        }
        [HttpPost]
        public IActionResult Delete(UpdateList ar)
        {
            _listContext.Responses.Remove(ar);
            _listContext.SaveChanges();
            return RedirectToAction("MovieList");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
