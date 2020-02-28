using Microsoft.AspNetCore.Mvc;
using CoreAngularDemo.Web.Controllers;

namespace CoreAngularDemo.Web.Public.Controllers
{
    public class AboutController : CoreAngularDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}