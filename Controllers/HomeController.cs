using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMovieAppRepeat.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieAppRepeat.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? Id)
        {
            var movies = MovieRepository.Movies;
            if (Id != null)
            {
                movies = movies.Where(x => x.CategoryID == Id).ToList();
            }
            return View(movies);
        }

        public IActionResult Details(int Id)
        {
            var movie = MovieRepository.GetByID(Id);
            return View(movie);
        }
    }
}