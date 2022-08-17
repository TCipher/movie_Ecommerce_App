using Microsoft.EntityFrameworkCore;
using movie_Ecommerce_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Data.Services
{
    public class ActorsService : IActorsService
    {
        //Inject the default AppDbContext which we use to send or receive data from the database
        private readonly AppDbContext _context;
        
        //injecting it through the constructor
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
           await _context.Actors.AddAsync(actor);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
             _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

       

        public async Task<Actor>UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
