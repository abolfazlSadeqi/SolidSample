

using OCP.EmployeeServ.Models;
using OCP.TrackingPackage.Models;

namespace OCP.TrackingPackage.Bad;

public class PackagePriceWeightService
{
  
    public int BasePriceAirplane { get; set; }
    public int BasePricePostimmediate { get; set; }
    public int BasePricePostNormal { get; set; }


    public long GetPackagePriceWeight(SendWayType sendWayType,int Weight)
    {
        if (sendWayType == SendWayType.Airplane)
        {
            return BasePriceAirplane * Weight;
        }
        if (sendWayType == SendWayType.Postimmediate)
        {
            return BasePricePostimmediate * Weight;
        }
        if (sendWayType == SendWayType.PostNormal)
        {
            return (BasePricePostNormal * Weight) ;
        }

        return 0;
    }
}
