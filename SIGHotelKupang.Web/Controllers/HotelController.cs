using Microsoft.AspNetCore.Mvc;

namespace SIGHotelKupang.Web.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Pencarian()
        {
            return View();
        }

        public async Task<IActionResult> Pemetaan()
        {
            return View();
        }

        public async Task<IActionResult> Detail()
        {
            return View();
        }
    }
}
