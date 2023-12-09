using System;

namespace ISP.Shoping.Bad;

public interface IPay
{
    public void Pay(int amount);

    //Pos
    public void GetAccountBalance(int AccountNumber);

    // Mobile
    public void PayInstallmentLoan(int InstallmentLoanId);
    public void PayBillWithBarCode(string bankAddress);
    
}

