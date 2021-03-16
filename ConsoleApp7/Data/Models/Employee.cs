using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Data.Models
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public int Age { get; set; } // no under 18, no negative, no over 2000
    }
}
