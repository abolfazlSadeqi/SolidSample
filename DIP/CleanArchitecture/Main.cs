using DIP.Shopping.Good;
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
        DIP.Shopping.Good.UserService userService = new DIP.Shopping.Good.UserService(new DIP.Log.Base.FileLogger());
        userService.Insert(user);
    }

    public void SaveBaduserService(Model.User user)
    {
        DIP.Shopping.Bad.UserService userService = new DIP.Shopping.Bad.UserService();
        userService.Insert(user);
    }
}
