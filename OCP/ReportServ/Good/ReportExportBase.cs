namespace OCP.ReportServ.Good;

public abstract class ReportExportBase<T>
{
    public abstract void GenerateReport(string Title, string ReportName, List<T> data);
}