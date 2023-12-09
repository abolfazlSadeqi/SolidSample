using System;

namespace ISP.Shoping.Good.Interface;

public interface IPayMobile: IPay
{
   
    // Mobile
    public void PayInstallmentLoan(int InstallmentLoanId);
    public void PayBillWithBarCode(string bankAddress);

}

