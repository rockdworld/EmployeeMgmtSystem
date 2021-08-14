using EmployeeService.Models;
using EmployeeService.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Repository
{

    public class EmployeeRepo : IEmployeeRepo
    {

        List<Employee> employees = new List<Employee>{
            new Employee{  Id = 01, FName="Smith", LName="John", Department="Electric", JobTitle="Electrician", DOB="02 Oct 1978", Manager="Clark J James", Salary="$1000", Phone="001 234 22342", Email="smith@gmail.com", Nationality="USA"},
            new Employee{  Id = 02, FName="Joe", LName="Neil", Department="Electric", JobTitle="Electrician", DOB="02 Oct 1978", Manager="Clark J James", Salary="$2500", Phone="001 234 22342", Email="smith@gmail.com", Nationality="USA"},
            new Employee{  Id = 03, FName="Kayal", LName="Kim", Department="House Keeping", JobTitle="Head Staff", DOB="02 Oct 1978", Manager="Clark J James", Salary="$1500", Phone="001 234 22342", Email="smith@gmail.com", Nationality="USA"},
            new Employee{  Id = 04, FName="Brasto", LName="B", Department="House Keeping", JobTitle="Sweeper", DOB="02 Oct 1978", Manager="Clark J James", Salary="$1200", Phone="001 234 22342", Email="smith@gmail.com", Nationality="USA"},
            new Employee{  Id = 05, FName="Jhonty", LName="Rodes", Department="IT", JobTitle="Developer", DOB="02 Oct 1978", Manager="Nency", Salary="$1000", Phone="001 234 22342", Email="smith@gmail.com", Nationality="USA"},
            new Employee{  Id = 06, FName="Kamala", LName="Harish", Department="IT", JobTitle="Developer", DOB="02 Oct 1978", Manager="Nency", Salary="$800", Phone="001 234 22342", Email="smith@gmail.com", Nationality="USA"},
            new Employee{  Id = 07, FName="Harry", LName="Poter", Department="IT", JobTitle="Tester", DOB="02 Oct 1978", Manager="Clark J James", Salary="$1100", Phone="001 234 22342", Email="smith@gmail.com", Nationality="USA"},
            new Employee{  Id = 08, FName="Nency", LName="Luther", Department="IT", JobTitle="Manager", DOB="02 Oct 1978", Manager="Clark J James", Salary="$1000", Phone="001 234 22342", Email="smith@gmail.com", Nationality="USA"},
            new Employee{  Id = 09, FName="Holly", LName="Happy", Department="Sales", JobTitle="Marketing", DOB="22 Apr 1998", Manager="Clark J James", Salary="$1300", Phone="001 234 22342", Email="smith@gmail.com", Nationality="USA"},
            new Employee{  Id = 10, FName="Bright", LName="Luck", Department="Sales", JobTitle="Marketing", DOB="15 Oct 1988", Manager="Holly", Salary="$1300", Phone="001 234 22342", Email="smith@gmail.com", Nationality="USA"}
        };

        public Employee DeleteEmployee(int Id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == Id);
            employees.Remove(employee);
            return employee;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee GetEmployeesById(int Id)
        {
            var employee = employees.FirstOrDefault(e=>e.Id == Id);
            return employee;
        }

        public Employee AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employee;
        }

    }
}
