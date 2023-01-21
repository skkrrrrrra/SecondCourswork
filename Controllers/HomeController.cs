using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Courswork.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Sell()
		{
			return View();
		}
        public IActionResult Wheat()
        {
            return View("SellPages/Wheat");
        }



        public IActionResult Buy()
        {
            return View();
        }
        public IActionResult WheatListToBuy()
        {
            return View("BuyPages/WheatListToBuy");
        }
    }
}