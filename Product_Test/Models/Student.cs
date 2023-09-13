using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_Test.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        //public string LG { get; set; }
    }
}