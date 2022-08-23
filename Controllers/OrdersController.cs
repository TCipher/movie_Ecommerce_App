using Microsoft.AspNetCore.Mvc;
using movie_Ecommerce_App.Data.Cart;
using movie_Ecommerce_App.Data.Services;
using movie_Ecommerce_App.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_Ecommerce_App.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMoviesService _movieservice;
        private readonly ShoppingCart _shoppingCart;
        public OrdersController(IMoviesService movieservice, ShoppingCart shoppingCart)
        {
            _movieservice = movieservice;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }
    }
}
