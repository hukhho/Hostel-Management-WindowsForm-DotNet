using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IEquipmentRepository
    {
        IEnumerable<Equipment> GetEquipments();
        Equipment GetEquipmentByID(int EquipmentID);
        void InsertEquipment(Equipment Equipment);
        void DeleteEquipment(int EquipmentID);
        void UpdateEquipment(Equipment Equipment);
    }
}
