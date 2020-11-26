using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models {
    public class UsersModel {

        [Display(Name = "Возраст")]
        [Range(7, 70, ErrorMessage = "Возраст от 7 до 70 лет")]
        public int age { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Необходимо заполнить поле")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Необходимо заполнить поле")]
        public string surname { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Эл.почта")]
        [Required(ErrorMessage = "Необходимо заполнить поле")]
        public string email { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Подтверждение Эл.почты")]
        [Compare("email", ErrorMessage = "Поля эл.почты не совпадают")]
        public string confirmEmail { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Необходимо заполнить поле")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Пароль больше 4 символов")]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("password", ErrorMessage = "Поля пароля не совпадают")]
        public string confirmPassword { get; set; }

    }
}