using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class RoomRepository : IRoomRepository
    {
        public IEnumerable<Room> GetRooms() => RoomDAO.Instance.GetRoomList();
        public Room GetRoomByID(int RoomID) => RoomDAO.Instance.GetRoomByID(RoomID);
        public void InsertRoom(Room Room) => RoomDAO.Instance.AddNew(Room);
        public void DeleteRoom(int RoomID) => RoomDAO.Instance.Remove(RoomID);
        public void UpdateRoom(Room Room) => RoomDAO.Instance.Update(Room);

      
    }
}
