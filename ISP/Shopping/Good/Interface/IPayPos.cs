using System;

namespace ISP.Shopping.Good.Interface;

public interface IPayPos : IPay
{
   
    //Pos
    public void GetAccountBalance(int AccountNumber);


}

