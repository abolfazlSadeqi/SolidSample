namespace LSP.Shopping.Good;

public class PaymentMobileOrderService : PaymentOrderService, ICalDiscount 
{
    public override long Money { get; set; }

    public virtual double CalDiscount()
    {
        return Money * 0.5;
    }
}



