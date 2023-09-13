using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Product_Test.Models
{
    public class Gender
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Gender, please!")]
        [Display(Name ="Gender")]
        public string GenderName { get; set; }
    }
}