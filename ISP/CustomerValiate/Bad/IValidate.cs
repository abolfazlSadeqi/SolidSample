namespace ISP.CustomerValiate.Bad;

public interface IValidate
{
    bool ValidateName(string Name);
    bool ValidateBalance(long Balance);
    bool validatelegalCode(long legalCode);
    bool validateRealCode(long RealCode);

}
