using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.HotelReserve.Good;

public interface IRoomReserveBase
{


    void AddRoom(Room room);
    void RemoveRoom(int Id);


    void SearchRoom(string Name);



}

public interface IRoomReserve: IRoomReserveBase
{

   

    void Reserve(int Id);

}


public interface IRoomReserveTransction: IRoomReserveBase
{

    
    void ReserveWithTranscation(int Id);

    void Cancel(int Id);

}

