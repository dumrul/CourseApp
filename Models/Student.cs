using System.ComponentModel.DataAnnotations;

namespace courseapp.Models
{
    public class Student
    {
        [Required(ErrorMessage="İsminizi giriniz!")]
        public string Name { get; set; }

        [Required(ErrorMessage="Email giriniz!")]
        [EmailAddress(ErrorMessage="Doğru format giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage="Telefon giriniz!")]
        public string Phone { get; set; }

        [Required(ErrorMessage="Onay seçiniz!")]
        public bool? Confirm { get; set; }
    }
}