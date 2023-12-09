using ISP.Shopping.Good.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Shopping.Good;

public class MobilePay : IPayMobile
{

    public void Pay(int amount)
    {
        //to do
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
