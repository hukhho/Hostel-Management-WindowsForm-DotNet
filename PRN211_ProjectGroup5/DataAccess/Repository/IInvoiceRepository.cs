using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IInvoiceRepository
    {
        IEnumerable<Invoice> GetInvoices();
        Invoice GetInvoiceByID(int InvoiceID);
        void InsertInvoice(Invoice Invoice);
        void DeleteInvoice(int InvoiceID);
        void UpdateInvoice(Invoice book);
    }
}
