using System.ComponentModel.DataAnnotations;

namespace laba_8_MVC.Models
{
    public class Order
    {
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Вам нужно ввести имя")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string Surname { get; set; }

        [Display(Name = "Введите номер телефона")]
        [Required(ErrorMessage = "Вам нужно ввести номер телефона")]
        [StringLength(11, ErrorMessage = "Номер телефона не менее 10 цифр")]
        public string Phonenumber { get; set; }
    }
}
