using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _MapVC : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgricultureContext c = new AgricultureContext();
            var mapvalue = c.Addresses.Select(x => x.Mapinfo).FirstOrDefault();
            ViewBag.Src = mapvalue;
            return View();
        }
    }
}
