using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Repository.Interfaces
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeesById(int Id);
        Employee AddEmployee(Employee employee);
        Employee DeleteEmployee(int Id);

    }
}
