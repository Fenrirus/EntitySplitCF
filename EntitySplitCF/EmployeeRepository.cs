using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntitySplitCF
{
    public class EmployeeRepository
    {
        EmployeeDbContext employeeDbContext = new EmployeeDbContext();
        public List<Employee> GetEmployees()
        {
            return employeeDbContext.Employees.ToList();
        }
        public void Insert(Employee employee)
        {
            employeeDbContext.Employees.Add(employee);
            employeeDbContext.SaveChanges();
        }
        public void Update(Employee employee)
        {
            Employee upadateEmployee = employeeDbContext.Employees.SingleOrDefault(p => p.EmployeeId == employee.EmployeeId);
            upadateEmployee.FirstName = employee.FirstName;
            upadateEmployee.FirstName = employee.FirstName;
            upadateEmployee.Gender = employee.Gender;
            upadateEmployee.Email = employee.Email;
            upadateEmployee.Mobile = employee.Mobile;
            upadateEmployee.Landline = employee.Landline;
            employeeDbContext.SaveChanges();
        }
        public void Delete(Employee employee)
        {
            Employee deleteEmployee = employeeDbContext.Employees.SingleOrDefault(p => p.EmployeeId == employee.EmployeeId);
            employeeDbContext.Employees.Remove(deleteEmployee);
            employeeDbContext.SaveChanges();
        }
    }

}