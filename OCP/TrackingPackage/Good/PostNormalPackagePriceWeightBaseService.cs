namespace OCP.TrackingPackage.Good;

public class PostNormalPackagePriceWeightBaseService : IPackagePriceWeightBaseService
{
    public int BasePricePostNormal { get; set; }
    public  long GetPackagePriceWeight(int Weight)
    {
        return BasePricePostNormal * Weight;
    }
}
