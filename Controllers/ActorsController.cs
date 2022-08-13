using Microsoft.AspNetCore.Mvc;
using movie_Ecommerce_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Controllers
{
    public class ActorsController : Controller
    {
        //Inject the default AppDbContext which we use to send or receive data from the database
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View(data);
        }
    }
}
