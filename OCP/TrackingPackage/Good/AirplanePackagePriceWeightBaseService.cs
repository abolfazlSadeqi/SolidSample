namespace OCP.TrackingPackage.Good;

public class AirplanePackagePriceWeightBaseService : IPackagePriceWeightBaseService
{
    public int BasePriceAirplane { get; set; }
    public long GetPackagePriceWeight(int Weight)
    {
        return BasePriceAirplane * Weight;
    }
}
