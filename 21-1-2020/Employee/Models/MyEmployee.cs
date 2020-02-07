using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Models
{
    public class MyEmployee
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Name Field is required")]
       
        [StringLength(maximumLength:15,MinimumLength =4,ErrorMessage ="name lenght should be 4 to 15")]
        public string name { get; set; }
        [Required(ErrorMessage = "Email Field is required")]
        [EmailAddress(ErrorMessage ="invalid email address")]
        [ValidateDomain(allowdomain:"cts.com")]
        [Remote(action:"IsEmailExist",controller:"Employee")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Dept Field is required")]
        public Dept Dept { get; set; }
        public MyEmployee(int id,string name,string Email,Dept Dept)
        {
            this.id = id;
            this.name = name;
            this.Email = Email;
            this.Dept = Dept;

        }
        public MyEmployee()
        {

        }
        
    }
}
