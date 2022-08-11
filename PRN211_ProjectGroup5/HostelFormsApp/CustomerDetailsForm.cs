using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelFormsApp
{
    public partial class CustomerDetailsForm : Form
    {
        IRoomRepository roomRepository = new RoomRepository();
        ICustomerRepository customerRepository = new CustomerRepository();

        public ICustomerRepository CustomerRepository { get; set; }

        public bool InsertOrUpdate { get; set; }
        public Customer CustomerInfo { get; set; }

        public CustomerDetailsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtDocumentID.Text = txtDocumentID.Text.Trim();
                txtPhoneNumber.Text = txtPhoneNumber.Text.Trim();
                txtCustomerName.Text = txtCustomerName.Text.Trim();
                
                int _roomId;
                if (comboRoom.SelectedItem != null)
                {
                    _roomId = (int)(comboRoom.SelectedItem as ComboboxItem).Value;
                }
                else
                {
                    MessageBox.Show("Chọn phòng!");
                    return;
                }
                string gender;
                if (rdGender1.Checked)
                {
                    gender = rdGender1.Text;
                }
                else if (rdGender2.Checked)
                {
                    gender = rdGender2.Text;
                }
                else
                {
                    MessageBox.Show("Chọn giới tính!");
                    return;
                }
                if (txtDOB.Value >= DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!");
                    return;
                }
                if (txtCustomerName.Text.Length < 3 || txtCustomerName.Text.Length > 25)
                {
                    MessageBox.Show("Tên từ 3 đến 25 kí tự!");
                    return;
                }
                
                // Validate number
                Regex validateNumberRegex = new Regex("^\\d+$");
                bool check = validateNumberRegex.IsMatch(txtDocumentID.Text);
                if (txtDocumentID.Text.Trim().Length != 9 && txtDocumentID.Text.Trim().Length != 12)
                {
                    MessageBox.Show("CMND chỉ có  9 hoặc 12 số ");
                    return;
                }
                if (!check)
                {
                MessageBox.Show("CMND chỉ có số");
                return;
                }
                
                bool check1 = validateNumberRegex.IsMatch(txtPhoneNumber.Text);
                if (txtPhoneNumber.Text.Trim().Length != 10 && txtDocumentID.Text.Trim().Length != 11)
                {
                    MessageBox.Show("SĐT chỉ có 10 hoặc 11 số");
                    return;
                }
                if (!check1)
                {
                    MessageBox.Show("SĐT Chỉ có số");
                    return;
                }
                if (txtPhoneNumber.Text.Trim().Substring(0,2) != "03" && txtPhoneNumber.Text.Trim().Substring(0, 2) != "09")
                {
                    MessageBox.Show("Sđt sai định dạng");
                    return;
                }


                var customer = new Customer
                {
                    CustomerName = txtCustomerName.Text,
                    Dob = txtDOB.Value,
                    DocumentId = txtDocumentID.Text,
                    RoomId = _roomId,
                    Gender = gender,
                    PhoneNumber = txtPhoneNumber.Text,
                    IsRenting = isRenting.Checked,
            };
                if (InsertOrUpdate == false)
                {
                    var user = customerRepository.GetCustomers().ToList().FirstOrDefault(p => p.DocumentId.Trim().Equals(txtDocumentID.Text));
                    if (user != null)
                    {
                        MessageBox.Show("CMND không được trùng");
                        return;
                    }
                    var user1 = customerRepository.GetCustomers().ToList().FirstOrDefault(p => p.PhoneNumber.Trim().Equals(txtPhoneNumber.Text));
                    if (user1 != null)
                    {
                        MessageBox.Show("SĐT không được trùng");
                        return;
                    }

                    CustomerRepository.InsertCustomer(customer);
                    MessageBox.Show("Tạo khách hàng " + customer.CustomerId + " thành công!");
                    this.Close();
                }
                else
                {
                    customer.CustomerId = int.Parse(txtCustomerID.Text);
                    CustomerRepository.UpdateCustomer(customer);

                    var user = customerRepository.GetCustomers().ToList().FirstOrDefault(p => p.DocumentId.Trim().Equals(txtDocumentID.Text) && p.CustomerId != customer.CustomerId);
                    if (user != null)
                    {
                        MessageBox.Show("CMND không được trùng");
                        return;
                    }
                    var user1 = customerRepository.GetCustomers().ToList().FirstOrDefault(p => p.PhoneNumber.Trim().Equals(txtPhoneNumber.Text) && p.CustomerId != customer.CustomerId);
                    if (user1 != null)
                    {
                        MessageBox.Show("SĐT không được trùng");
                        return;
                    }

                    MessageBox.Show("Cập nhật khách hàng " + customer.CustomerId + " thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Tạo " : "Cập nhật ");
            }
        }
        public class ComboboxItem
        {
            public ComboboxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }

            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void CustomerDetailsForm_Load(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            if (InsertOrUpdate == true)
            {
                txtCustomerID.Text = CustomerInfo.CustomerId.ToString();
                txtCustomerName.Text = CustomerInfo.CustomerName.ToString();
                txtDOB.Value = (DateTime) CustomerInfo.Dob;
                txtDocumentID.Text = CustomerInfo.DocumentId.ToString();
                //txtGender.Text = CustomerInfo.Gender.ToString();            
                txtPhoneNumber.Text = CustomerInfo.PhoneNumber.ToString();
                isRenting.Checked = CustomerInfo.IsRenting;
                //txtRoomID.Text = CustomerInfo.RoomId.ToString();

                if (CustomerInfo.Gender == rdGender1.Text)
                {
                    rdGender1.Checked = true;
                } else if (CustomerInfo.Gender == rdGender2.Text) {
                    rdGender2.Checked = true;
                }

                var rooms = roomRepository.GetRooms();
                rooms.ToList().ForEach(n =>
                {
                    var item = new ComboboxItem(n.RoomName, n.RoomId);
                    comboRoom.Items.Add(item);
                    if (n.RoomId == CustomerInfo.RoomId)
                    {
                        comboRoom.SelectedItem = item;
                    }
                });

            }
            else
            {
                var rooms = roomRepository.GetRooms();
                rooms.ToList().ForEach(n => comboRoom.Items.Add(new ComboboxItem(n.RoomName, n.RoomId)));

                txtCustomerID.Visible = false;
                lbCustomerID.Visible = false;
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void isRenting_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdGender1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGender1.Checked)
            {
                rdGender2.Checked = false;
                rdGender1.Enabled = false;
                rdGender2.Enabled = true;
            }
        }

        private void rdGender2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGender2.Checked)
            {
                rdGender1.Checked = false;
                rdGender2.Enabled = false;
                rdGender1.Enabled = true;

            }
        }
    }
}
