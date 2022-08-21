﻿using movie_Ecommerce_App.Data.Base;
using movie_Ecommerce_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Data.Services
{
    //Services For interacting with the databse using EFC
   public interface IActorsService : IEntityBaseRepository<Actor>
    {
        
    }
}
