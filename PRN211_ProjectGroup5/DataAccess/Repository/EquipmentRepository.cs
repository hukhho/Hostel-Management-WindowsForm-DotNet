using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class EquipmentRepository : IEquipmentRepository
    {
        public IEnumerable<Equipment> GetEquipments() => EquipmentDAO.Instance.GetEquipmentList();
        public Equipment GetEquipmentByID(int EquipmentID) => EquipmentDAO.Instance.GetEquipmentByID(EquipmentID);
        public void InsertEquipment(Equipment Equipment) => EquipmentDAO.Instance.AddNew(Equipment);
        public void DeleteEquipment(int EquipmentID) => EquipmentDAO.Instance.Remove(EquipmentID);
        public void UpdateEquipment(Equipment Equipment) => EquipmentDAO.Instance.Update(Equipment);

      
    }
}
