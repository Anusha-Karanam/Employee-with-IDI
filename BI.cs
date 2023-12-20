using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_with_IDI
{
    public class BI : IBI
    {
        private IDAL _dataAccess;

        public BI(IDAL dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<Employee> GetEmployees()
        {
            return _dataAccess.GetEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return _dataAccess.GetEmployeeById(id);
        }
    }
}
