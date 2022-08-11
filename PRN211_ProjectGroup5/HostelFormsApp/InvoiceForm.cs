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
    public partial class InvoiceForm : Form
    {
        IInvoiceRepository invoiceRepository = new InvoiceRepository();

        BindingSource source;
        public InvoiceForm()
        {
            InitializeComponent();
        }
        public void LoadInvoiceList()
        {
            var invoices = invoiceRepository.GetInvoices();

            try
            {
                source = new BindingSource();
                source.DataSource = invoices;

                txtInvoiceID.DataBindings.Clear();
                txtCreateDate.DataBindings.Clear();
                txtCustomerID.DataBindings.Clear();
                txtInvoiceName.DataBindings.Clear();
                txtNote.DataBindings.Clear();
                txtRoomCharge.DataBindings.Clear();
                txtRoomID.DataBindings.Clear();
                txtServiceCharge.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtTotal.DataBindings.Clear();

                txtInvoiceID.DataBindings.Add("Text", source, "InvoiceID");
                txtCreateDate.DataBindings.Add("Text", source, "CreateDate");
                txtCustomerID.DataBindings.Add("Text", source, "CustomerID");
                txtInvoiceName.DataBindings.Add("Text", source, "InvoiceName");
                txtNote.DataBindings.Add("Text", source, "Note");
                txtRoomCharge.DataBindings.Add("Text", source, "RoomCharge");
                txtRoomID.DataBindings.Add("Text", source, "RoomID");
                txtServiceCharge.DataBindings.Add("Text", source, "ServiceCharge");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtTotal.DataBindings.Add("Text", source, "Total");

                dgvInvoiceList.DataSource = null;
                dgvInvoiceList.DataSource = source;

                this.dgvInvoiceList.Columns["CustomerID"].Visible = false;
                this.dgvInvoiceList.Columns["RoomID"].Visible = false;
                this.dgvInvoiceList.Columns["Status"].Visible = false;

                //this.dgvinvoicelist.columns["contracts"].visible = false;
                //this.dgvinvoicelist.columns["customers"].visible = false;
                //this.dgvroomlist.columns["invoices"].visible = false;
                //this.dgvroomlist.columns["usedservices"].visible = false;
                //this.dgvroomlist.columns["equipment"].visible = false;

                //if (rooms.Count() == 0)
                //{
                //    ClearText();
                //    btnDelete.Enabled = false;
                //}
                //else
                //{
                //    btnDelete.Enabled = true;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load invoice list");
            }
        }
        private void ClearText()
        {
            txtInvoiceID.Text = string.Empty;
            txtCreateDate.Text = string.Empty;
            txtCustomerID.Text = string.Empty;
            txtInvoiceName.Text = string.Empty;
            txtRoomCharge.Text = string.Empty;
            txtRoomID.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtServiceCharge.Text = string.Empty;
            txtNote.Text = string.Empty;
            txtNote.Text = string.Empty;
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
            txtNote.ReadOnly = true;
            txtStatus.ReadOnly = true;
            txtServiceCharge.ReadOnly = true;
        }
        private void dgvInvoiceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private Invoice GetInvoiceObject()
        {
            Invoice invoice = null;
            try
            {
                int _invoiceId = int.Parse(txtInvoiceID.Text);
                invoice = invoiceRepository.GetInvoiceByID(_invoiceId);

                return invoice;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get invoice");
            }
            return invoice;
        }
        private void dgvInvoiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadInvoiceList();
            
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            LoadInvoiceList();
            disbleTextBox();
        }


        private void dgvInvoiceList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InvoiceDetailsForm invoiceDetailsForm = new InvoiceDetailsForm()
            {
                Text = "Detail invoice",
                InvoiceInfo = GetInvoiceObject(),
                InvoiceRepository = invoiceRepository,
            };
            LoadInvoiceList();
            try
            {
                if (invoiceDetailsForm.ShowDialog() == DialogResult.OK)
                {
                    LoadInvoiceList();
                    source.Position = source.Count - 1;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                LoadInvoiceList();
            }
        }

        private void txtStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Are you sure delele this?", "Delete invoice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var invoice = GetInvoiceObject();
                    invoiceRepository.DeleteInvoice(invoice.InvoiceId);
                }
                LoadInvoiceList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete invoice");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
