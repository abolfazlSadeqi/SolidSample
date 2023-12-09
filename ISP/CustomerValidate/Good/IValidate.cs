namespace ISP.CustomerValidate.Good;

public interface IValidate
{
    bool ValidateName(string Name);
    bool ValidateBalance(long Balance);


}
