using OCP.CustomerClub.Model;

namespace OCP.CustomerClub.Good;

public class CalPointBase
{
    private readonly ICalPoint _ICalPoint;

    public CalPointBase(ICalPoint iCalPoint)
    {
        _ICalPoint = iCalPoint;
    }

    public long CalcPoint(Customer customer)
    {
       return _ICalPoint.CalcPoint(customer);
    }
}
