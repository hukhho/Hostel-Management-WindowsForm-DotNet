using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;


namespace DataAccess
{
    public class ServiceDAO
    {
        private static ServiceDAO instance = null;

        private static readonly object instanceLock = new object();

        public static ServiceDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ServiceDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Service> GetServiceList()
        {
            var Services = new List<Service>();
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Services = context.Services.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Services;
        }


        public Service GetServiceByID(int ServiceID)
        {
            Service Service = null;
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Service = context.Services.SingleOrDefault(m => m.ServiceId == ServiceID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Service;
        }


        public void AddNew(Service Service)
        {
            try
            {
                Service _Service = GetServiceByID(Service.ServiceId);
                if (_Service == null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Services.Add(Service);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Service is already exist!!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Service Service)
        {
            try
            {
                Service _Service = GetServiceByID(Service.ServiceId);
                if (Service != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Services.Update(Service);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Service does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Remove(int ServiceID)
        {
            try
            {
                Service Service = GetServiceByID(ServiceID);
                if (Service != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Services.Remove(Service);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Service does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
