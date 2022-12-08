using OrderProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProject
{
    public class Person : EntityBase
    {
 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
