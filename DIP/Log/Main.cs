using DIP.Log.Model;
namespace DIP.Logs;

public class Main
{
    public void Good(User user)
    {
        DIP.Shoping.Good.UserService userService = new DIP.Shoping.Good.UserService(new DIP.Log.Base.FileLogger());
        userService.Insert(user);
    }

    public void Bad(User user)
    {
        DIP.Shoping.Bad.UserService userService = new DIP.Shoping.Bad.UserService();
        userService.Insert(user);
    }
}
