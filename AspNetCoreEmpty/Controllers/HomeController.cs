using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        // bu metot Index view'nin dönmesini sağlar.
        // IActionResult  = viewlerin tipi IAction olduğu için bu method çağrılır. Controller'ın içindeki metotlara action denir.
        public IActionResult Index()
        {
            return View();
        }
    }
}
