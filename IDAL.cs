﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_with_IDI
{
    public interface IDAL
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
    }
}
