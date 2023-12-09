using System;

namespace DIP.OrderMVC.Bad;


public class OrderController //: ControllerBase
{

    private readonly OrderService _OrderService;

    public OrderController( OrderService OrderService)
    {
       
        _OrderService = OrderService;
    }
}


