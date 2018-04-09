using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioController
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Home");
        }
        [HttpGet]
        [Route("Projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }
        [HttpGet]
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}