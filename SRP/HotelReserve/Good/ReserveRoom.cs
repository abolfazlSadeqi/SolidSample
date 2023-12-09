using SRP.HotelReserve.Model;
using System;

namespace SRP.HotelReserve.Good;


public class ReserveRoom
{
    private InvoiceService invoiceService;
    public ReserveRoom(InvoiceService invoiceService)
    {
        this.invoiceService = invoiceService;
    }
    public void Reserve(RoomBase roomBase)
    {
        if (CheckStatus(roomBase))
        {
            roomBase.IsAvailable = RoomStatus.NotAvailable;
            invoiceService.Invoice(roomBase);
        }
        //to do
    }

    public bool CheckStatus(RoomBase roomBase)
          => roomBase.IsAvailable == RoomStatus.Available ? true : false;
}



