using System;

namespace ISP.Shopping.Good.Interface;

public interface IPayMobile: IPay
{
   
    // Mobile
    public void PayInstallmentLoan(int InstallmentLoanId);
    public void PayBillWithBarCode(string bankAddress);

}

