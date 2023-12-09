using DIP.Shoping.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Log;

public class Main
{
    public void SaveGooduserService(Model.User user)
    {
        DIP.Shoping.Good.UserService userService = new DIP.Shoping.Good.UserService(new DIP.Log.Base.FileLogger());
        userService.Insert(user);
    }

    public void SaveBaduserService(Model.User user)
    {
        DIP.Shoping.Bad.UserService userService = new DIP.Shoping.Bad.UserService();
        userService.Insert(user);
    }
}
