using SRP.HotelReserve.Model;

namespace SRP.HotelReserve.Good;

public class RoomBase
{
    public int Id { get; set; }
    public string RoomName { get; set; }
    public RoomStatus IsAvailable { get; set; }
}