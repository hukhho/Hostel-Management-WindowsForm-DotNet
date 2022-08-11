using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public IEnumerable<Customer> GetCustomers() => CustomerDAO.Instance.GetCustomerList();
        public Customer GetCustomerByID(int CustomerID) => CustomerDAO.Instance.GetCustomerByID(CustomerID);
        public void InsertCustomer(Customer Customer) => CustomerDAO.Instance.AddNew(Customer);
        public void DeleteCustomer(int CustomerID) => CustomerDAO.Instance.Remove(CustomerID);
        public void UpdateCustomer(Customer Customer) => CustomerDAO.Instance.Update(Customer);
    }
}
