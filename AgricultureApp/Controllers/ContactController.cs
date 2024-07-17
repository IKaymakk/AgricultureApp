using AgricultureApp.Models.ViewModels;
using BusinessLayer.Abstract;
using DataAccessLayer.Migrations;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _icontactservice;

        public ContactController(IContactService icontactservice)
        {
            _icontactservice = icontactservice;
        }

        public IActionResult Index()
        {
            var values = _icontactservice.GetListAll();
            return View(values);
        }
        public IActionResult DeleteMessage(int id)
        {
            var values = _icontactservice.GetById(id);
            _icontactservice.Delete(values);
            return RedirectToAction("Index");
        }
        public IActionResult MessageDetails(int id)
        {
            var values = _icontactservice.GetById(id);
            ViewBag.ID = values.ContactID;
            return View (values);
        }
    }

}
