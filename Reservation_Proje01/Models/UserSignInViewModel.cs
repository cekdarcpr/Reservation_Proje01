using System.ComponentModel.DataAnnotations;

namespace Reservation_Proje01.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı adınızı giriniz...")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz...")]
        public string Password { get; set; }
    }
}
