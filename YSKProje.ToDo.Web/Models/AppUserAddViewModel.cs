using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.ToDo.Web.Models
{
    public class AppUserAddViewModel
    {
        [Display(Name="Kullanıcı Adı:")]
        [Required(ErrorMessage = "Kullanıcı Adı boş geçilemez")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Şifre:")]
        [Required(ErrorMessage = "Parola boş geçilemez")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrarı:")]
        [Compare("Password", ErrorMessage = "Parolalar uyuşmuyor")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Email:")]
        [EmailAddress(ErrorMessage ="Geçersiz Email")]
        [Required(ErrorMessage = "Email boş geçilemez")]
        public string Email { get; set; }


        [Display(Name = "Adınız:")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string Name { get; set; }


        [Display(Name = "Soyadınız:")]
        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        public string Surname { get; set; }
    }
}
