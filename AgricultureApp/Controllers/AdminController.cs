using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;

namespace AgricultureApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminservice;

        public AdminController(IAdminService adminservice)
        {
            _adminservice = adminservice;
        }

        public IActionResult Index()
        {
            var values = _adminservice.GetListAll();
            return View(values);
        }
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin t)
        {
            _adminservice.Insert(t);
            return RedirectToAction("Index");

        }
        public IActionResult DeleteAdmin(int id)
        {
            var values = _adminservice.GetById(id);
            _adminservice.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAdmin(int id)
        {
            var values = _adminservice.GetById(id);
            ViewBag.ID = values.AdminID;
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAdmin(Admin t)
        {
            _adminservice.Update(t);
            return RedirectToAction("Index");

        }
    }
}
