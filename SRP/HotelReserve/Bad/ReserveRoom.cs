using SRP.HotelReserve.Good;
using SRP.HotelReserve.Model;
using System;

namespace SRP.HotelReserve.Bad;


public class Customer
{
    public int Id { get; set; }
    public string RoomName { get; set; }
    public RoomStatus IsAvailable { get; set; }

    public void Reserve()
    {
        if (CheckStatus())
        {
            IsAvailable = RoomStatus.NotAvailable;
            Invoice();
        }

        //to do
    }

    public bool CheckStatus()
          => IsAvailable == RoomStatus.Available ? true : false;


    public void Invoice()
    {
        if (IsAvailable == RoomStatus.Available)
        {
            // to do

        }

    }

}



