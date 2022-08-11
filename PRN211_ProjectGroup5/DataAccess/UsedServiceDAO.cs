using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class UsedServiceDAO
    {
        private static UsedServiceDAO instance = null;

        private static readonly object instanceLock = new object();

        public static UsedServiceDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UsedServiceDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<UsedService> GetUsedServiceList()
        {
            var UsedServices = new List<UsedService>();
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                UsedServices = context.UsedServices
                                            .Include(c => c.Invoice)
                                            .Include(d => d.Room)
                                            .Include(e => e.Service)
                                            .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return UsedServices;
        }


        public UsedService GetUsedServiceByID(int UsedServiceID)
        {
            UsedService UsedService = null;
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                UsedService = context.UsedServices
                                    .Include(c => c.Invoice)
                                    .Include(d => d.Room)
                                    .Include(e => e.Service)
                                    .SingleOrDefault(m => m.UsedServiceId == UsedServiceID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return UsedService;
        }


        public void AddNew(UsedService UsedService)
        {
            try
            {
                UsedService _UsedService = GetUsedServiceByID(UsedService.UsedServiceId);
                if (_UsedService == null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.UsedServices.Add(UsedService);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("UsedService is already exist!!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(UsedService UsedService)
        {
            try
            {
                UsedService _UsedService = GetUsedServiceByID(UsedService.UsedServiceId);
                if (UsedService != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.UsedServices.Update(UsedService);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("UsedService does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Remove(int UsedServiceID)
        {
            try
            {
                UsedService UsedService = GetUsedServiceByID(UsedServiceID);
                if (UsedService != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.UsedServices.Remove(UsedService);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("UsedService does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
