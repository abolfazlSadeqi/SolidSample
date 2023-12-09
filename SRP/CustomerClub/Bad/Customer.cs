using SRP.HotelReserve.Good;
using SRP.HotelReserve.Model;
using System;

namespace SRP.CustomerClub.Bad;


public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public long Balance { get; set; }

    public void InsertPoint(long Balance)
    {
        if (!Validate(this))
            SaveLog("Balace Not Valid");
        var point = CalcautePoint(Balance);
        if (point == 0)
            SaveLog("point Not Valid");

        //To do
    }

    public bool Validate(Customer Customer)
    {

        return true;
        //to do
    }

    public void SaveLog(string message)
    {
        //to do

    }

    public int CalcautePoint(long Balance)
    {
        //to do
        return 0;
    }

}



