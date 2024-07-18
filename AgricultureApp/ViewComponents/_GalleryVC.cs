using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _GalleryVC : ViewComponent
    {
        private readonly IImageService _image;

        public _GalleryVC(IImageService image)
        {
            _image = image;
        }

        public IViewComponentResult Invoke()
        {
            var values = _image.GetListAll();
            return View(values);
        }
    }
}
