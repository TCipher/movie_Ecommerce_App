using Microsoft.AspNetCore.Mvc;
using movie_Ecommerce_App.Data;
using movie_Ecommerce_App.Data.Services;
using movie_Ecommerce_App.Models;
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
        private readonly IProducersService _service;
        public ProducerController(IProducersService service)
        {
            _service = service;
        }
        //using synch
        //public IActionResult Index()
        //using async method
        public async Task<IActionResult> Index()
        {
            //using the synchronous way of getting data from the database
            var allProducers = await _service.GetAllAsync();
            //using async
            //var allProducers = await _context.Producers.ToListAsync();
            //specifying the new veiw to be returned
            return View(allProducers);
        }

        //Get: Producers/details/1
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        //GET: Producers/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePicture, FullName,Bio")]Producer producer)
        {
            if(!ModelState.IsValid) return View(producer);

            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //GET: Producers/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Edit( int id,[Bind("Id, ProfilePicture, FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            if(id == producer.Id)
            {
                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
           
        }
        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Not Found");
            return View(producerDetails);

        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Not Found");
            await _service.DeleteAsync(id);
           
            return RedirectToAction(nameof(Index));

           
            

        }
    }
}
