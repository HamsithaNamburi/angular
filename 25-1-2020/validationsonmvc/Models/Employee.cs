using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace validationsonmvc.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Pls enter ID")]
        [DisplayName("Employee Id")]

        public int ID { get; set; }
        [Required(ErrorMessage = " enter the Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "name should be enter")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "invalid email id")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "invalid mobile number")]
        public string moblie_no { get; set; }

        [Required(ErrorMessage = "enter username")]
        public string Uname { get; set; }

        [Required(ErrorMessage = "enter the password")]
        [RegularExpression(@"[a-z0-9]{6,8}")]
        public string Pwd { get; set; }
        [Compare("Pwd",ErrorMessage ="miss match the password")]
        public string Cpwd { get; set; }
    }
}
