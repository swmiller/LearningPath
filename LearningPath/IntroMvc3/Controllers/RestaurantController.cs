using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace IntroMvc3.Controllers
{
    public class RestaurantController : Controller
    {
        OdeToFoodDB _db = new OdeToFoodDB();

        // GET: Restaurant
        public ActionResult Index()
        {
            var model = _db.Restaurants;

            return View(model);
        }
    }
}