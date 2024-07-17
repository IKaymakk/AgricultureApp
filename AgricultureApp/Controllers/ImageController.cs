using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageservice;

        public ImageController(IImageService imageservice)
        {
            _imageservice = imageservice;
        }

        public IActionResult Index()
        {
            var values = _imageservice.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddImage(Image t)
        {
            ImageValidator ıv = new ImageValidator();
            ValidationResult results = ıv.Validate(t);
            if (results.IsValid)
            {
                _imageservice.Insert(t);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();
            }

        }
        public IActionResult DeleteImage(int id)
        {
            var values = _imageservice.GetById(id);
            _imageservice.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditImage(int id)
        {
            var values = _imageservice.GetById(id);
            ViewBag.ID = values.ImageID;
            return View(values);
        }
        [HttpPost]
        public IActionResult EditImage(Image t)
        {
            ImageValidator ıv = new ImageValidator();
            ValidationResult results = ıv.Validate(t);
            if (results.IsValid)
            {
                _imageservice.Update(t);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();
            }

        }
    }
}
