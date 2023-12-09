using System;

namespace SRP.UserSending.Bad;

public class UserService
{
    

  
    public bool Send(UserService user)
    {
        SendSms(user);
        SendEmail(user);
        SendFax(user);
       //to do
        return true;
    }
    public bool SendSms(UserService user)
    {
        //to do
        return true;
    }

    public void SendEmail(UserService user)
    {
      //to do
    }

    public void SendFax(UserService user)
    {
        //to do
    }
}


