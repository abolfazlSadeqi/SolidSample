namespace OCP.TrackingPackage.Good;

public  class CalPackagePriceWeightBaseService
{
    private readonly IPackagePriceWeightBaseService _PackagePriceWeightBaseService;
    public CalPackagePriceWeightBaseService(IPackagePriceWeightBaseService PackagePriceWeightBaseService)
    {
        _PackagePriceWeightBaseService = PackagePriceWeightBaseService;
    }
    public long GetPackagePriceWeight(int Weight)
    {
        return _PackagePriceWeightBaseService.GetPackagePriceWeight(Weight);
    }
}