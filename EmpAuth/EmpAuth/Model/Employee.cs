using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmpAuth.Model
{
    public class Employee
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long PhoneNo { get; set; }
        public DateTime DOB { get; set; }
    }    
}
