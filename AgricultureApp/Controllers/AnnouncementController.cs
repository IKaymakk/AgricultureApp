using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _iservice;

        public AnnouncementController(IAnnouncementService iservice)
        {
            _iservice = iservice;
        }

        public IActionResult Index()
        {
            var values = _iservice.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement p)
        {
            p.Date= DateTime.Now;
            p.Status = true;
            _iservice.Insert(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _iservice.GetById(id);

            _iservice.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {
            var values = _iservice.GetById(id);
            ViewBag.ID = values.AnnouncementID;
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAnnouncement(Announcement p)
        {
            p.Date= DateTime.Now;
            _iservice.Update(p);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeAnnouncementStatus(int id)
        {
            _iservice.ChangeStatus(id);
            return RedirectToAction("Index");
        }
    }
}
