using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoreUsers.Abstraction;
using MoreUsers.Domain;
using MoreUsers.Data;

namespace MoreUsers.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext context;

        public EmployeeService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool CreateEmployee(string fisrtName, string lastName, string phone, string jobTitle, string userId)
        {
            if (context.Employees.Any(p => p.UserId == userId))
            {
                throw new InvalidOperationException("Employee already exist.");
            }

            Employee employee = new Employee
            {
                FirstName = fisrtName,
                LastName = lastName,
                Phone = phone,
                JobTitle = jobTitle,
                UserId = userId
            };

            context.Employees.Add(employee);

            return context.SaveChanges() != 0;
        }

        public Employee GetEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public string GetFullName(string id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id)
        {
            throw new NotImplementedException();
        }
    }
}
