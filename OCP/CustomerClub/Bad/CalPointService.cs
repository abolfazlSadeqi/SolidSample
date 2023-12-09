using OCP.CustomerClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.CustomerClub.Bad;

public class CalPointService
{


    public long CalcPoint(PointsPeriod pointsperiod, Customer customer)
    {

        return pointsperiod switch
        {
            PointsPeriod.Day => CalPointDay(customer),
            PointsPeriod.Month => CalPointMonth(customer),
            PointsPeriod.Week => CalPointWeek(customer),
            _ => 0,
        };


    }
    public long CalPointDay(Customer customer)
    {
        //to do
        return 0;
    }

    public long CalPointMonth(Customer customer)
    {
        //to do
        return 0;
    }
    public long CalPointWeek(Customer customer)
    {
        //to do
        return 0;
    }
}
