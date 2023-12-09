using DIP.Log.Model;
namespace DIP.Logs;

public class Main
{
    public void Good(User user)
    {
        DIP.Shopping.Good.UserService userService = new DIP.Shopping.Good.UserService(new DIP.Log.Base.FileLogger());
        userService.Insert(user);
    }

    public void Bad(User user)
    {
        DIP.Shopping.Bad.UserService userService = new DIP.Shopping.Bad.UserService();
        userService.Insert(user);
    }
}
