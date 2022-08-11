using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public IEnumerable<Invoice> GetInvoices() => InvoiceDAO.Instance.GetInvoiceList();
        public Invoice GetInvoiceByID(int InvoiceID) => InvoiceDAO.Instance.GetInvoiceByID(InvoiceID);
        public void InsertInvoice(Invoice Invoice) => InvoiceDAO.Instance.AddNew(Invoice);
        public void DeleteInvoice(int InvoiceID) => InvoiceDAO.Instance.Remove(InvoiceID);
        public void UpdateInvoice(Invoice Invoice) => InvoiceDAO.Instance.Update(Invoice);

      
    }
}
