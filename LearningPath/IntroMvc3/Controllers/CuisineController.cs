using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using IntroMvc3.Infrasctructure;

namespace IntroMvc3.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        // GET: Cuisine
        [HttpGet]
        public ActionResult Search(string name = "*")
        {
            throw new Exception("Blam!");

            //if (name == "*")
            //{
            //    return Json(new {cuisineName = name }, JsonRequestBehavior.AllowGet);
            //    //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            //    //return RedirectToAction("Search", "Cuisine", new {name = "french"});
            //}

            name = Server.HtmlEncode(name);
            return Content(name);
        }
    }
}