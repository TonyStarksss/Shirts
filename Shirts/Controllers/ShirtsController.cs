using Microsoft.AspNetCore.Mvc;
using Shirts.Models;

namespace Shirts.Controllers
{
    public class ShirtsController : Controller
    {
        public IActionResult Home()
        {

            var shirt = new Shirt() { Name = "Bench" };
            return View(shirt);

        }

        public IActionResult Index()
        {
            //lorem ipsum this is a comment!!
            return View();
        }

    }
}
