using CleanArchitecture.ApplicationCore.Services.Interfaces;
using System.Linq;
using System.Web.Mvc;

namespace CleanArchitecture.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService service;
        public HomeController(IOrderService service)
        {
            this.service = service;
        }
        public ActionResult Index()
        {
            var allPhones = service.GetPhones().ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}