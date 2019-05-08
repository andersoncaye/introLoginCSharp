using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite Seu E-Mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite Sua Senha!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}