using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Shoping.Bad;

public class MobilePay : IPay
{

    public void Pay(int amount)
    {
        //to do
    }
    public void GetAccountBalance(int AccountNumber)
    {
        //to do
    }

    

    // Mobile
    public void PayBillWithBarCode(string bankAddress)
    {
        throw new NotImplementedException();
    }
    // Mobile
    public void PayInstallmentLoan(int InstallmentLoanId)
    {
        throw new NotImplementedException();
    }
{
}
