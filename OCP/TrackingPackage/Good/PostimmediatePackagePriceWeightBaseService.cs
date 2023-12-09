namespace OCP.TrackingPackage.Good;

public class PostimmediatePackagePriceWeightBaseService : IPackagePriceWeightBaseService
{
    public int BasePricePostimmediate { get; set; }
    public  long GetPackagePriceWeight(int Weight)
    {
        return BasePricePostimmediate * Weight;
    }
}
