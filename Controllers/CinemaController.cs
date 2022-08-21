using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_Ecommerce_App.Data;
using movie_Ecommerce_App.Data.Services;
using movie_Ecommerce_App.Models;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Controllers
{
    public class CinemaController : Controller
    {
        //Injecting  the ICinemasService
        private readonly ICinemasService _service;
        public CinemaController(ICinemasService service)
        {
            _service = service;
        }
        //using the async method to  import data
        public async Task<IActionResult> Index()
        {
            var allCinema = await _service.GetAllAsync();
            return View(allCinema);
        }
        //Get: Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")]Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        //Get: Cinemas/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("Not Found");
            return View(cinemaDetails);
        }

        //Get:Cinemas/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("Not Found");
            return View(cinemaDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _service.UpdateAsync(id,cinema);
            return RedirectToAction(nameof(Index));
        }
        //Get:Cinemas/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("Not Found");
            return View(cinemaDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("Not Found");


            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
