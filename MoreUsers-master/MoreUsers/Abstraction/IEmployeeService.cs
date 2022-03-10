using MoreUsers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreUsers.Abstraction
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployee(string id);
        public bool Remove(string id);
        public string GetFullName(string id);
        public bool CreateEmployee(string fisrtName, string lastName, string phone, string jobTitlem, string userId);
    }
}
