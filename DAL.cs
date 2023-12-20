using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_with_IDI
{
    public class DAL : IDAL
    {
        //IList − A generic interface implemented by the arrays and the list type.
        private List<Employee> employees = new List<Employee>();

        public DAL()
        {
         
            employees.Add(new Employee { EmployeeId = 1, Name = "Anusha", Department = "HR" });
            employees.Add(new Employee { EmployeeId = 2, Name = "Bhoomika", Department = "IT" });
            employees.Add(new Employee { EmployeeId = 3, Name = "Chaithra", Department = "BFS" });
            employees.Add(new Employee { EmployeeId = 4, Name = "Darshana", Department = "SPE" });
            employees.Add(new Employee { EmployeeId = 5, Name = "Eva", Department = "REM" });
            employees.Add(new Employee { EmployeeId = 6, Name = "Farheen", Department = "Health Care" });


        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.EmployeeId == id);
        }
    }
}
