using AgricultureApp.Models.ViewModels;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var values = _service.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAddress()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAddress(Address p)
        {
            _service.Insert(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAddress(int id)
        {
            var values = _service.GetById(id);
            _service.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var values = _service.GetById(id);
            ViewBag.ID = values.AddressID;
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAddress(Address p)
        {
            _service.Update(p);
            return RedirectToAction("Index");
        }
    }
}
