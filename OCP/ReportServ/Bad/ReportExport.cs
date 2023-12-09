
using OCP.ReportServ.Models;

namespace OCP.ReportServ.Bad;

public class ReportExport<T>
{
    public ReportType Type { get; set; }

    public void GenerateReport(string Title, string ReportName, List<T> data)
    {
        if (Type == ReportType.PDF)
        {
            // to do
        }
        if (Type == ReportType.Doc)
        {
            // to do
        }
    }
}
