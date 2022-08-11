using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IUsedServiceRepository
    {
        IEnumerable<UsedService> GetUsedServices();
        UsedService GetUsedServiceByID(int UsedServiceID);
        void InsertUsedService(UsedService UsedService);
        void DeleteUsedService(int UsedServiceID);
        void UpdateUsedService(UsedService UsedService);
    }
}
