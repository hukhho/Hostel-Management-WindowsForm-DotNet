using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EquipmentDAO
    {
        private static EquipmentDAO instance = null;

        private static readonly object instanceLock = new object();

        public static EquipmentDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new EquipmentDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Equipment> GetEquipmentList()
        {
            var Equipments = new List<Equipment>();
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Equipments = context.Equipment
                    .Include(e => e.Room).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Equipments;
        }


        public Equipment GetEquipmentByID(int EquipmentID)
        {
            Equipment Equipment = null;
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Equipment = context.Equipment.Include(e => e.Room).SingleOrDefault(m => m.EquipmentId == EquipmentID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Equipment;
        }


        public void AddNew(Equipment Equipment)
        {
            try
            {
                Equipment _Equipment = GetEquipmentByID(Equipment.EquipmentId);
                if (_Equipment == null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Equipment.Add(Equipment);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Equipment is already exist!!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Equipment Equipment)
        {
            try
            {
                Equipment _Equipment = GetEquipmentByID(Equipment.EquipmentId);
                if (Equipment != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Equipment.Update(Equipment);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Equipment does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Remove(int EquipmentID)
        {
            try
            {
                Equipment Equipment = GetEquipmentByID(EquipmentID);
                if (Equipment != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Equipment.Remove(Equipment);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Equipment does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
