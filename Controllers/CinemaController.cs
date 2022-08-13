using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_Ecommerce_App.Data;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Controllers
{
    public class CinemaController : Controller
    {
        //Injecting  the AppDbContext
        private readonly AppDbContext _context;
        public CinemaController(AppDbContext context)
        {
            _context = context;
        }
        //using the async method to  import data
        public async Task<IActionResult> Index()
        {
            var allCinema = await _context.Cinemas.ToListAsync();
            return View(allCinema);
        }
    }
}
