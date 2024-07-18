using AgricultureApp.Models;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductChart()
        {
            AgricultureContext c = new AgricultureContext();
            var regions = c.Regions
                .Select(x => new { productname = x.RegionName, productvalue = x.RegionValue })
                .ToList();
            return Json(new { jsonlist = regions });

        }
    }
}
