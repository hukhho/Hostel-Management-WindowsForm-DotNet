using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        public IEnumerable<Service> GetServices() => ServiceDAO.Instance.GetServiceList();
        public Service GetServiceByID(int ServiceID) => ServiceDAO.Instance.GetServiceByID(ServiceID);
        public void InsertService(Service Service) => ServiceDAO.Instance.AddNew(Service);
        public void DeleteService(int ServiceID) => ServiceDAO.Instance.Remove(ServiceID);
        public void UpdateService(Service Service) => ServiceDAO.Instance.Update(Service);
        
    }
}
