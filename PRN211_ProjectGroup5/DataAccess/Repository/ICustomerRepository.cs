using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerByID(int CustomerID);
        void InsertCustomer(Customer Customer);
        void DeleteCustomer(int CustomerID);
        void UpdateCustomer(Customer book);
    }
}
