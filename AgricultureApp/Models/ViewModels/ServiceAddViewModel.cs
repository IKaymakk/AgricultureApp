﻿using System.ComponentModel.DataAnnotations;

namespace AgricultureApp.Models.ViewModels
{
    public class ServiceAddViewModel
    {
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Başlık Boş Geçilemez")]
        public string Title { get; set; }
       
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama Boş Geçilemez")]
        public string Description { get; set; }
      
        [Display(Name = "Resim Yolu")]
        [Required(ErrorMessage = "Resim Yolu Boş Geçilemez")]
        public string Image{ get; set; }
    }
}
