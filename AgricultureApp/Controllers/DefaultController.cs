using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IContactService _service;

        public DefaultController(IContactService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SendMessage(Contact c)
        {
            c.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _service.Insert(c);
            return RedirectToAction("Index", "Default");

        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
