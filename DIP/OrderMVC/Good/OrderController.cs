using System;

namespace DIP.OrderMVC.Good;


public class OrderController //: ControllerBase
{

    private readonly IOrderService _OrderService;

    public OrderController(IOrderService OrderService)
    {
       
        _OrderService = OrderService;
    }
}


