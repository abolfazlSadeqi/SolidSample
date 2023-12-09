namespace OCP.EmployeeServ.Good;

public class EmployeePartTimeService : Employee
{
    public override double GetSalary(int BaseSalary, int Hours_Days)
    {
        return BaseSalary * (Hours_Days * 8);
    }
}
