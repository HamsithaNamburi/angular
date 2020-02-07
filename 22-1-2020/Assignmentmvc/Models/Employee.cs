using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel; 

namespace Assignmentmvc.Models
{
    public class Employee
    {
        [Required(ErrorMessage =" Employee Id Fieled is required")]
        public string Eid { get; set; }
        [Required(ErrorMessage =" Name Field is required")]
        [StringLength(maximumLength:5,MinimumLength =20,ErrorMessage ="Invalid Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Enter the Designation")]
        [StringLength(maximumLength:5,MinimumLength =3,ErrorMessage ="Enter Designation in correct format")]
        public string Desig { get; set; }
        [Required(ErrorMessage ="Enter the project Name")]
        public string Proname { get; set; }
        [Required(ErrorMessage ="Password Field is Required")]
        [RegularExpression(@"[a-z0-9]{6,8}",ErrorMessage ="Invalid Password")]
       public string Password { get; set; }
    }
}
