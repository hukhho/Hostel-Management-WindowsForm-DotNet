using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class RoomDAO
    {
        private static RoomDAO instance = null;

        private static readonly object instanceLock = new object();

        public static RoomDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new RoomDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Room> GetRoomList()
        {
            var Rooms = new List<Room>();
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Rooms = context.Rooms
                                     .Include(i => i.UsedServices)
                                     .Include(c => c.Invoices)
                                     .ToList() ;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Rooms;
        }


        public Room GetRoomByID(int RoomID)
        {
            Room Room = null;
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Room = context.Rooms
                        .Include(i => i.UsedServices)
                        .Include(c => c.Invoices)
                        .SingleOrDefault(m => m.RoomId == RoomID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Room;
        }


        public void AddNew(Room Room)
        {
            try
            {
                Room _Room = GetRoomByID(Room.RoomId);
                if (_Room == null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Rooms.Add(Room);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Room is already exist!!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Room Room)
        {
            try
            {
                Room _Room = GetRoomByID(Room.RoomId);
                if (Room != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Rooms.Update(Room);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Room does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Remove(int RoomID)
        {
            try
            {
                Room Room = GetRoomByID(RoomID);
                if (Room != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Rooms.Remove(Room);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Room does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
