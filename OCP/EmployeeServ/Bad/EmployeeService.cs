

using OCP.EmployeeServ.Models;

namespace OCP.EmployeeServ.Bad;

public class EmployeeService
{
    public EmployeeType employeeType { get; set; }

    public double GetSalary(int BaseSalary, int Hours_Days)
    {
        if (employeeType == EmployeeType.PartTime)
        {
            return BaseSalary * (Hours_Days * 8);
        }
        if (employeeType == EmployeeType.FullTime)
        {
            return BaseSalary * Hours_Days;
        }

        return 0;
    }
}
