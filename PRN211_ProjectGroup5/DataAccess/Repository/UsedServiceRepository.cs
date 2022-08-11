using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class UsedServiceRepository : IUsedServiceRepository
    {
        public IEnumerable<UsedService> GetUsedServices() => UsedServiceDAO.Instance.GetUsedServiceList();
        public UsedService GetUsedServiceByID(int UsedServiceID) => UsedServiceDAO.Instance.GetUsedServiceByID(UsedServiceID);
        public void InsertUsedService(UsedService UsedService) => UsedServiceDAO.Instance.AddNew(UsedService);
        public void DeleteUsedService(int UsedServiceID) => UsedServiceDAO.Instance.Remove(UsedServiceID);
        public void UpdateUsedService(UsedService UsedService) => UsedServiceDAO.Instance.Update(UsedService);

      
    }
}
