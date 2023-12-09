namespace ISP.CustomerValidate.Bad;



public class RealCustomer : IValidate
{
    public bool ValidateBalance(long Balance)
    {
        //to do
        return true;
    }

    public bool validatelegalCode(long legalCode)
    {
        //to do
        return true;
    }

    public bool ValidateName(string Name)
    {
        throw new NotImplementedException();
       
    }

    public bool validateRealCode(long RealCode)
    {
        //to do
        return true;
    }
}
