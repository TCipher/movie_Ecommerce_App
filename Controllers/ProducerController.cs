using Microsoft.AspNetCore.Mvc;
using movie_Ecommerce_App.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Controllers
{
    public class ProducerController : Controller
    {
        //Inject the AppDbContext
        private readonly AppDbContext _context;
        public ProducerController(AppDbContext context)
        {
            _context = context;
        }
        //using synch
        public IActionResult Index()
        //using async method
        //public async Task<IActionResult> Index()
        {
            //using the synchronous way of getting data from the database
            var allProducers = _context.Producers.ToList();
            //using async
            //var allProducers = await _context.Producers.ToListAsync();
            //specifying the new veiw to be returned
            return View(allProducers);
        }
    }
}
