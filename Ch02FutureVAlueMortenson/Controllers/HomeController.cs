using Microsoft.AspNetCore.Mvc;
using Ch02FutureVAlueMortenson;
using Ch02FutureVAlueMortenson.Models;

namespace Ch02FutureVAlueMortenson.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            
            ViewBag.FV = 0;
            return View();
        }
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else
            {
                ViewBag.Fv = 0;
            }
                return View(model);
        }

    }
}
