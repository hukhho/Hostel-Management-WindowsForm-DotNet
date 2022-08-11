using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class InvoiceDAO
    {
        private static InvoiceDAO instance = null;

        private static readonly object instanceLock = new object();

        public static InvoiceDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new InvoiceDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Invoice> GetInvoiceList()
        {
            var Invoices = new List<Invoice>();
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Invoices = context.Invoices
                                .Include(c => c.UsedServices)
                                .Include(d => d.Customer)
                                .Include(e => e.Room)
                                .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Invoices;
        }


        public Invoice GetInvoiceByID(int InvoiceID)
        {
            Invoice Invoice = null;
            try
            {
                using var context = new Hostel_Management_ProjectContext();
                Invoice = context.Invoices
                    .Include(c => c.UsedServices)
                    .Include(d => d.Customer)
                    .Include(e => e.Room)
                    .SingleOrDefault(m => m.InvoiceId == InvoiceID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Invoice;
        }


        public void AddNew(Invoice Invoice)
        {
            try
            {
                Invoice _Invoice = GetInvoiceByID(Invoice.InvoiceId);
                if (_Invoice == null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Invoices.Add(Invoice);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Invoice is already exist!!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Invoice Invoice)
        {
            try
            {
                Invoice _Invoice = GetInvoiceByID(Invoice.InvoiceId);
                if (Invoice != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Invoices.Update(Invoice);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Invoice does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Remove(int InvoiceID)
        {
            try
            {
                Invoice Invoice = GetInvoiceByID(InvoiceID);
                if (Invoice != null)
                {
                    using var context = new Hostel_Management_ProjectContext();
                    context.Invoices.Remove(Invoice);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Invoice does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
