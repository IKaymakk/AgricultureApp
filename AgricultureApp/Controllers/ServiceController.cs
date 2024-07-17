using AgricultureApp.Models.ViewModels;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _service;

        public ServiceController(IServiceService service)
        {
            this._service = service;
        }

        public IActionResult Index()
        {
            var values = _service.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel p)
        {
            if (ModelState.IsValid)
            {
                _service.Insert(new Service()
                {
                    ServiceTitle = p.Title,
                    ServiceDescription = p.Description,
                    ServiceImage = p.Image
                });
                return RedirectToAction("Index");
            }
            else
            {

                return View();
            }

        }
        public IActionResult DeleteService(int id)
        {
            var values = _service.GetById(id);
         
            _service.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values = _service.GetById(id);
            ViewBag.ID = values.ServiceId;
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service p)
        {
            _service.Update(p);
            return RedirectToAction("Index");
        }
        public IActionResult test()
        {
            return View();
        }
    }
}
