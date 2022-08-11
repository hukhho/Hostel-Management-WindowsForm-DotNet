using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessObject;
using DataAccess.Repository;

namespace HostelFormsApp
{
    public partial class CustomerForm : Form
    {
        ICustomerRepository customerRepository = new CustomerRepository();
        BindingSource source;
        List<Customer> customers;
        public CustomerForm()
        {
            InitializeComponent();
        }
        public void LoadCustomerList()
        {
            customers = (List<Customer>)customerRepository.GetCustomers();

            try
            {
                source = new BindingSource();
                source.DataSource = customers;

                txtRoomID.DataBindings.Clear();
                txtCustomerID.DataBindings.Clear();
                txtCustomerName.DataBindings.Clear();
                txtDOB.DataBindings.Clear();
                txtDocumentID.DataBindings.Clear();
                txtGender.DataBindings.Clear();
                txtIsRenting.DataBindings.Clear();
                txtPhoneNumber.DataBindings.Clear();            

                txtRoomID.DataBindings.Add("Text", source, "RoomId");
                txtCustomerID.DataBindings.Add("Text", source, "CustomerId");
                txtCustomerName.DataBindings.Add("Text", source, "CustomerName");
                txtDOB.DataBindings.Add("Text", source, "Dob");
                txtDocumentID.DataBindings.Add("Text", source, "DocumentId");
                txtGender.DataBindings.Add("Text", source, "Gender");
                txtIsRenting.DataBindings.Add("Text", source, "isRenting");
                txtPhoneNumber.DataBindings.Add("Text", source, "phoneNumber");    

                dgvCustomerList.DataSource = null;
                dgvCustomerList.DataSource = source;

                this.dgvCustomerList.Columns["RoomId"].Visible = false;
                //this.dgvCustomerList.Columns["Invoices"].Visible = false;
                //this.dgvCustomerList.Columns["Room"].Visible = false;

                if (customers.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        private Customer GetCustomerObject()
        {
            Customer customer = null;
            try
            {
                customer = new Customer
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                    CustomerName = txtCustomerName.Text,
                    Dob = txtDOB.Value,
                    DocumentId = txtDocumentID.Text,
                    RoomId = int.Parse(txtRoomID.Text),
                    Gender = txtGender.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    IsRenting = bool.Parse(txtIsRenting.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return customer;
        }
        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ClearText()
        {
            txtRoomID.Text = string.Empty;
            txtCustomerID.Text = string.Empty;
            txtDOB.Value = DateTime.Today;
            txtDocumentID.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtIsRenting.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
            txtRoomID.ReadOnly = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

      

        private void btnNew_Click(object sender, EventArgs e)
        {
            CustomerDetailsForm customerDetailsForm = new CustomerDetailsForm()
            {
                Text = "Tạo phòng",
                InsertOrUpdate = false,
                CustomerRepository = customerRepository
            };
            if (customerDetailsForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomerList();
                source.Position = source.Count - 1;
            }
            LoadCustomerList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Bạn có chắc xoá không?", "Xoá", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var customer = GetCustomerObject();
                    customerRepository.DeleteCustomer(customer.CustomerId);
                }
                LoadCustomerList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xoá");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

   

        private void txtDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbDocumentID_Click(object sender, EventArgs e)
        {

        }

        private void lbDOB_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCustomerName_Click(object sender, EventArgs e)
        {

        }
     
        private void dgvCustomerList_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CustomerDetailsForm customerDetailsForm = new CustomerDetailsForm()
            {
                Text = "Cập nhật",
                InsertOrUpdate = true,
                CustomerInfo = GetCustomerObject(),
                CustomerRepository = customerRepository
            };
            LoadCustomerList();
            try
            {
                if (customerDetailsForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomerList();
                    source.Position = source.Count - 1;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                LoadCustomerList();
            }
        }

        private void dgvCustomerList_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRoomID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
