using System.Linq;
using System.Web.Mvc;
using IntroMvc3.Models;
using OdeToFood.Models;

namespace IntroMvc3.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly OdeToFoodDB _db = new OdeToFoodDB();

        // GET: Restaurant
        public ActionResult Index(string state)
        {
            ViewBag.States = _db.Restaurants.Select(r => r.Address.State).Distinct();

            IQueryable<Restaurant> model = _db.Restaurants
                .OrderBy(r => r.Address.City)
                .Where(r => r.Address.State == state || (state == null));

            return View(model);
        }
    }
}