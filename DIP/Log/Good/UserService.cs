using DIP.Log.Base;
using DIP.Log.Model;

namespace DIP.Shopping.Good;

public class UserService
{
    private ILog _log ; 

    public UserService(ILog log)
    {
        _log = log;
    }

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
