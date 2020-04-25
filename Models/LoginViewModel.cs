using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryWeb.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username required")]
        public string Username { get; set; }
        
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}