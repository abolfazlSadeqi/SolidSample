using System;

namespace ISP.Shoping.Good.Interface;

public interface IPayPos : IPay
{
   
    //Pos
    public void GetAccountBalance(int AccountNumber);


}

