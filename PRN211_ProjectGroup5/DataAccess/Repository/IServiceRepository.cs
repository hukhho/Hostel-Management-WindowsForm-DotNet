using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IServiceRepository
    {
        IEnumerable<Service> GetServices();
        Service GetServiceByID(int ServiceID);
        void InsertService(Service Service);
        void DeleteService(int ServiceID);
        void UpdateService(Service Service);
    }
}
