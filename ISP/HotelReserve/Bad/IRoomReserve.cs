using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.HotelReserve.Bad;

public interface IRoomReserve
{

    void AddRoom(Room room);
    void RemoveRoom(int Id);

    void Reserve(int Id);
    void ReserveWithTranscation(int Id);

    void Cancel(int Id);
    void SearchRoom(string Name);
 
}
