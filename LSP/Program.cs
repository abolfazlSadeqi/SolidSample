
LSP.Shopping.Bad.PaymentOrderService order = new LSP.Shopping.Bad.PaymentPosOrderService { Money = 140 };
//Can't use order.CalDiscount();
//must use 
Bad(order); 

LSP.Shopping.Good.PaymentMobileOrderService ordergood = new LSP.Shopping.Good.PaymentMobileOrderService { Money = 140 };
Good(ordergood); 

Console.ReadKey();

static void Bad(LSP.Shopping.Bad.PaymentOrderService order)
{
    Console.WriteLine($"Discount: {order.CalDiscount()}");
}



 static void Good(LSP.Shopping.Good.ICalDiscount iCalDiscount)
{
    Console.WriteLine($"Discount: {iCalDiscount.CalDiscount()}");
}
