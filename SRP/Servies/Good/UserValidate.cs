using SRP.Servies.Models;

namespace SRP.Servies.Good;

public class UserValidate
{

    public void Validate(UserViewModel userViewModel)
    {
        if (string.IsNullOrEmpty(userViewModel.Name))
            throw new InvalidOperationException();

        if (string.IsNullOrEmpty(userViewModel.Family))
            throw new InvalidOperationException();

        if (userViewModel.Age == 0)
            throw new Exception("Age is not valid");
    }
}