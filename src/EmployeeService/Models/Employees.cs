using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string Salary { get; set; }
        public string Manager { get; set; }
        public string Phone { get; set; }
        public string DOB { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
    }
}
