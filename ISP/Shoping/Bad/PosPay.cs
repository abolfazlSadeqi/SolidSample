using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Shoping.Bad;

public class PosPay : IPay
{

    public void Pay(int amount)
    {
        //to do
    }

    //Pos
    public void GetAccountBalance(int AccountNumber)
    {
        throw new NotImplementedException();
    }

   

    // Mobile
    public void PayBillWithBarCode(string bankAddress)
    {
        //to do
    }
    // Mobile
    public void PayInstallmentLoan(int InstallmentLoanId)
    {
        //to do
    }
}
