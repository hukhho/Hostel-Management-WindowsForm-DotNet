using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;

        private static readonly object instanceLock = new object();

        public static CustomerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            var Customers = new List<Customer>();
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Customers = context.Customers
                    .Include(e => e.Room)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Customers;
        }


        public Customer GetCustomerByID(int CustomerID)
        {
            Customer Customer = null;
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Customer = context.Customers
                    .Include(e => e.Room)
                    .SingleOrDefault(m => m.CustomerId == CustomerID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Customer;
        }


        public void AddNew(Customer Customer)
        {
            try
            {
                Customer _Customer = GetCustomerByID(Customer.CustomerId);
                if (_Customer == null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Customers.Add(Customer);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Customer is already exist!!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Customer Customer)
        {
            try
            {
                Customer _Customer = GetCustomerByID(Customer.CustomerId);
                if (Customer != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Customers.Update(Customer);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Customer does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Remove(int CustomerID)
        {
            try
            {
                Customer Customer = GetCustomerByID(CustomerID);
                if (Customer != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Customers.Remove(Customer);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Customer does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
