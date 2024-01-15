using System.ComponentModel.DataAnnotations;

namespace UserApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [RegularExpression("[А-Яа-яЁё]{2,20} [А-Яа-я-Ёё]{2,40}", ErrorMessage = "Некорректная информация (используйте кириллицу)")]
        [Display(Name = "Фамилия и имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Дата рождения")]
        [ValidateDate]
        [DataType(DataType.Date)] 
        public DateTime DoB { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Должность")]
        [RegularExpression("[А-Яа-я-Ёё1-9]+", ErrorMessage = "Некорректная информация (используйте кириллицу)")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Введена некорректная информация (не менее 3 симв., не более 30)")]
        public string? Position { get; set; }


    }
}
