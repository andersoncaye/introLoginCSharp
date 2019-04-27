using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSharpWithEntityLogin.Models
{
    public class Usuario
    {
        [Key]
        public int Codigo { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }
    }
}