using Microsoft.AspNetCore.Mvc;

namespace TxArt.GoldenNews.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
