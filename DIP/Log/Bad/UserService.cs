using DIP.Log.Base;
using DIP.Log.Model;

namespace DIP.Shoping.Bad;

public class UserService
{
    private ILog _log = new FileLogger(); 

    public void Insert(User user)
    {
        try
        {
            // to do
        }
        catch (Exception ex)
        {
            _log.Log(ex);
        }
    }
}
