namespace OCP.EmployeeServ.Good;

public class EmployeeFullTimeService : Employee
{
    public override double GetSalary(int BaseSalary, int Hours_Days)
    {
        return BaseSalary * Hours_Days;
    }
}
