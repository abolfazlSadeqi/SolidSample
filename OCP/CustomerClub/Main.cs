using OCP.CustomerClub.Bad;
using OCP.CustomerClub.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.CustomerClub;

public class Main
{
    public void Good()
    {

        var CalPointBase = new CalPointBase(new CalcDayPoint());
        CalPointBase.CalcPoint(new Model.Customer() { Id = 1, Name = "dd", Balance = 100 });
    }

    public void Bad()
    {

        var CalPointService = new CalPointService();
        CalPointService.CalcPoint(PointsPeriod.Day, new Model.Customer() { Id = 1, Name = "dd", Balance = 100 });
    }
}
