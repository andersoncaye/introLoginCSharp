using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Models
{
    public class UserModel
    {

        public int UserId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Preencha o Nome!")]
        [Display(Name = "Nome: ")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Preencha o Sobrenome!")]
        [Display(Name = "Sobrenome: ")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Preencha o E-mail!")]
        [Display(Name = "E-Mail: ")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Preencha Sua Senha!")]
        [Display(Name = "Senha: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirme Sua Senha!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme Sua Senha: ")]
        [Compare("Password", ErrorMessage = "Senha e confirmação de senha devem ser iguais!")]

        public string ConfirmPassword { get; set; }

        public DateTime CreatedOn { get; set; }

        public string SuccessMessage { get; set; }
    }
}