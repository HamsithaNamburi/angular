using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace validationsonmvc.Models
{
    public class login
    {
        [Required(ErrorMessage ="username is required")]
        public string Uname { get; set; }

        [Required(ErrorMessage = "password  is required")]
        public string Pwd { get; set; }
    }
}
