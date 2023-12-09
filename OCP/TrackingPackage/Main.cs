using OCP.TrackingPackage.Bad;
using OCP.TrackingPackage.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.TrackingPackage;

public class Main
{
    void Good()
    {
        var cal = new CalPackagePriceWeightBaseService(new AirplanePackagePriceWeightBaseService());
        long PackagePriceWeight = cal.GetPackagePriceWeight(250);
    }

    void Bad()
    {
        var cal = new PackagePriceWeightService();
        long PackagePriceWeight = cal.GetPackagePriceWeight(Models.SendWayType.Airplane, 250);
    }
}
