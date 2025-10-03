using Phumla.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class RoomController
    {
        RoomDB rdb;
        Collection<Room> rooms;
    


    public RoomController()
        {

            rdb = new RoomDB();
            rooms = rdb.Rooms;
        }
    }
}
