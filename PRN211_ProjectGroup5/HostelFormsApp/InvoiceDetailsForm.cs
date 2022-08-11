using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelFormsApp
{
    public partial class InvoiceDetailsForm : Form
    {
        IUsedServiceRepository usedServiceRepository = new UsedServiceRepository();
        public IInvoiceRepository InvoiceRepository { get; set; }
     
        public Invoice InvoiceInfo { get; set; }
        public InvoiceDetailsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int _invoiceId = int.Parse(txtInvoiceID.Text);
                var invoice = InvoiceRepository.GetInvoiceByID(_invoiceId);
                if (invoice is not null)
                {
                    invoice.Note = txtNote.Text;
                    if (txtStatus.Checked)
                    {
                        invoice.Status = 1;
                    } 
                    else
                    {
                        invoice.Status = 0;
                    }
                    InvoiceRepository.UpdateInvoice(invoice);
                    MessageBox.Show("Update success invoice id " + invoice.InvoiceId);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void InvoiceDetailsForm_Load(object sender, EventArgs e)
        {
            disbleTextBox();
            txtInvoiceID.Text = InvoiceInfo.InvoiceId.ToString();
            txtCreateDate.Value = (DateTime) InvoiceInfo.CreateDate;
            txtCustomerID.Text = InvoiceInfo.CustomerId.ToString();
            txtInvoiceName.Text = InvoiceInfo.InvoiceName;
            txtNote.Text = InvoiceInfo.Note;
            txtRoomCharge.Text = InvoiceInfo.RoomCharge.ToString();
            txtRoomID.Text = InvoiceInfo.RoomCharge.ToString();
            txtServiceCharge.Text = InvoiceInfo.ServiceCharge.ToString();         
            txtTotal.Text = InvoiceInfo.Total.ToString();
            if (InvoiceInfo.Status == 1)
            {
                txtStatus.Checked = true;
            } else
            {
                txtStatus.Checked = false;
            }
            int _invocieId = InvoiceInfo.InvoiceId;
            
            var usedServices = usedServiceRepository.GetUsedServices().ToList().Where(p => p.InvoiceId == _invocieId).ToList();
            
            dgvInvoiceDetailsList.DataSource = null;
            dgvInvoiceDetailsList.DataSource = usedServices;

        }

        private void txtStatus_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void disbleTextBox()
        {
            txtInvoiceID.ReadOnly = true;
            txtCreateDate.Enabled = false;
            txtCustomerID.ReadOnly = true;
            txtInvoiceName.ReadOnly = true;
            txtRoomCharge.ReadOnly = true;
            txtRoomID.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtServiceCharge.ReadOnly = true;
        }
        private void dgvInvoiceDetailsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
