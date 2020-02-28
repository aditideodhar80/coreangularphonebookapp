using Microsoft.AspNetCore.Mvc;
using CoreAngularDemo.Web.Controllers;

namespace CoreAngularDemo.Web.Public.Controllers
{
    public class HomeController : CoreAngularDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}