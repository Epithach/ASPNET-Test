using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspTest.Models;

/*
 * Action Results - HelperMethod
 * ViewResult - View()
 * PartialViewResult - PartialView()
 * ContentResult - Content()
 * RedirectResult - Redirect()
 * RedirectToRouteResult - RedirectToAction()
 * JsonResult - Json()
 * FileResult - File()
 * HttpNotFoundResult - HttpNotFound()
 * EmptyResult   
 * 
 */


namespace AspTest.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            //return View(movie);
            //return Content("Hello World !");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});

            ViewData["Movie"] = movie;
            ViewBag.Movie = movie;

            return View(movie);

        }

        public ActionResult Edit(int Id)
        {
            return Content("Id = " + Id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy{1}", pageIndex, sortBy));
        }


        /*
         * Constraints List 
         * 
         * min
         * max
         * minlength
         * maxlength
         * int
         * float
         * guid
         */

            /*
                [Route("movies/release/{year}/{month:regex(\\d{2}):range(1, 12)}")]
                public ActionResult ByReleaseDate(int year, int month)
                {
                    return Content("Date : " + month + "/" + year);
                }
            */
    }
}