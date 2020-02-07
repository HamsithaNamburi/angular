using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace mvcexample.Models
{
    public class user
    {
        [Required(ErrorMessage ="Name field is required")]
        [StringLength(maximumLength:20,MinimumLength =5,ErrorMessage ="enter Nmae of string value")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }
        //[Range(1/1/1970,1/1/2020,ErrorMessage =")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage ="please select the country",AllowEmptyStrings =false)]
        public string country { get; set; }
        [Phone(ErrorMessage ="Inavlid Mobile Number")]
        public string mobile_no { get; set; }
        [Required(ErrorMessage = "UserName field is required")]
        [StringLength(maximumLength: 20, MinimumLength = 5, ErrorMessage = "enter Nmae of string value")]
        public string uname { get; set; }
        [Required(ErrorMessage ="Password Field is required")]
        [RegularExpression(@"[a-z0-9]{6,8}",ErrorMessage ="Invalid Password")]
        public string pwd { get; set; }

    }
}
