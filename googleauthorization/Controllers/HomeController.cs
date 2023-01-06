using googleauthorization.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GoogleAuthentication.Services;

namespace googleauthorization.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var clientId = "164794501167-ct7gf8aioq248nh9c882iks3dp685o9u.apps.googleusercontent.com";
            var url = "https://localhost:7235/Login/GoogleLoginCallback";
            var response = GoogleAuth.GetAuthUrl(clientId,url);
            ViewBag.response = response;
            return View();
        }

  
    }
}