using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_with_IDI
{
    public interface IBI
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
    }
}
