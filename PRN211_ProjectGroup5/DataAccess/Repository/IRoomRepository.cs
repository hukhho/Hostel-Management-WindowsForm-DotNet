using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetRooms();
        Room GetRoomByID(int roomID);
        void InsertRoom(Room room);
        void DeleteRoom(int roomID);
        void UpdateRoom(Room book);
    }
}
