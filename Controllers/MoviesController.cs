using Microsoft.AspNetCore.Mvc;
using movie_Ecommerce_App.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Controllers
{
    public class MoviesController : Controller
    {
        //Inject the AppDb context
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public  async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
