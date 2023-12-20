using Employee_with_IDI;

class Program
{
    static void Main(string[] args)
    {
        
        IDAL dataAccess = new DAL();
        IBI businessLogic = new BI(dataAccess);

        
        List<Employee> employees = businessLogic.GetEmployees();
        Employee a = businessLogic.GetEmployeeById(5);
        Console.WriteLine("The details are \n ");
        Console.WriteLine($"Employee ID: {a.EmployeeId}, Name: {a.Name}, Department: {a.Department}");

        foreach (var employee in employees)
        {
            Console.WriteLine($"Employee ID: {employee.EmployeeId}, Name: {employee.Name}, Department: {employee.Department}");
        }





    }
}