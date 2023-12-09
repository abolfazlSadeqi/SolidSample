using SRP.HotelReserve.Model;

namespace SRP.HotelReserve.Good;

public class InvoiceService
{

    public void Invoice(RoomBase roomBase)
    {
        if (roomBase.IsAvailable == RoomStatus.Available)
        {
            // to do

        }

    }
}