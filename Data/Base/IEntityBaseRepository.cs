using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Data.Base
{
     public interface IEntityBaseRepository<T> where T: class, IEntityBase, new()
    {
        //Method For selecting all the actors from the database, the return type is Ienumarable of actors.
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);

        //Method for selecting a single actor, the return type is Actor
        Task<T> GetByIdAsync(int id);

        //Method to add data to the database, we will return nothing.
        Task AddAsync(T entity);

        //Method to save data to the database, we will return updated data from the dabase in this case the a
        //The Id passed will be used to check to see if the Id of the actor exists or not
        Task UpdateAsync(int id, T entity);

        //Method to delete data from the  database, we will return nothing.
        Task DeleteAsync(int id);
    }
}
