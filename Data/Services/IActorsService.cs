using movie_Ecommerce_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Data.Services
{
    //Services For interacting with the databse using EFC
   public interface IActorsService
    {
        //Method For selecting all the actors from the database, the return type is Ienumarable of actors.
        Task<IEnumerable<Actor>> GetAllAsync();

        //Method for selecting a single actor, the return type is Actor
       Task<Actor> GetByIdAsync(int id);

        //Method to add data to the database, we will return nothing.
       Task  AddAsync(Actor actor);

        //Method to save data to the database, we will return updated data from the dabase in this case the a
        //The Id passed will be used to check to see if the Id of the actor exists or not
        Task<Actor> UpdateAsync(int id, Actor newActor);

        //Method to delete data from the  database, we will return nothing.
        Task DeleteAsync(int id);
    }
}
