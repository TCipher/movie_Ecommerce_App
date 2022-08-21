using movie_Ecommerce_App.Data.Base;
using movie_Ecommerce_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Data.Services
{
    public interface ICinemasService: IEntityBaseRepository<Cinema>
    {
    }
}
