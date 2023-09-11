using System.ComponentModel.DataAnnotations;

namespace Demo_Project.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen İsim giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyisim giriniz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı giriniz.")]
     
        public string Gender { get; set; }
        [Required(ErrorMessage = "Lütfen Cinsiyet giriniz.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre giriniz.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar giriniz.")]
        [Compare("Password", ErrorMessage = "Lütfen Şifrelerin Aynı Olduğundan Emin Olun.")]
        public string ConfirmPassword { get; set; }
    }
}
