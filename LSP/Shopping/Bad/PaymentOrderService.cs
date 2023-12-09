namespace LSP.Shopping.Bad;

public class PaymentOrderService
{
    public virtual long Money { get; set; }

    public virtual double CalDiscount()
    {
        return Money * 0.5;
    }
}
