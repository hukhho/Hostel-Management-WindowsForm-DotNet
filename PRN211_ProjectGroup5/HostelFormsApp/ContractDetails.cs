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
    public partial class ContractDetails : Form
    {
        IRoomRepository roomRepository = new RoomRepository();
        ICustomerRepository customerRepository = new CustomerRepository();

        public IContractRepository ContractRepository { get; set; }

        public bool InsertOrUpdate { get; set; }
        public Contract ContractInfo { get; set; }

        public ContractDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int _roomId;
                int _customerId;
                if (comboRoom.SelectedItem != null && comboCustomer.SelectedItem != null)
                {
                    _roomId = (int) (comboRoom.SelectedItem as ComboboxItem).Value;
                    _customerId = (int) (comboCustomer.SelectedItem as ComboboxItem).Value;
                }
                else
                {
                    MessageBox.Show("Chọn phòng hoặc Chọn khách!!");
                    return;
                }
                if (txtEndDate.Value < txtStartDate.Value)
                {
                    MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!");
                    return;
                }
                int _depositStatus;
                if (txtDepositStatus.Checked)
                {
                    _depositStatus = 1;
                } else
                {
                    _depositStatus = 0;
                }
                if (int.Parse(txtDepositMoney.Text.Trim()) < 0 || txtDepositMoney.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Tiền cọc không được bé hơn 0 hoặc trống");
                    return;
                }
                var contract = new Contract
                {
                    CustomerId = _customerId,
                    RoomId = _roomId,
                    StartDate = txtStartDate.Value,
                    EndDate = txtEndDate.Value,
                    DepositMoney = int.Parse(txtDepositMoney.Text),
                    DepositMoneyStatus = _depositStatus,
                };

                if (InsertOrUpdate == false)
                {
                    ContractRepository.InsertContract(contract);
                    MessageBox.Show("Tạo hợp đồng " + contract.ContractId + " thành công!");
                    this.Close();
                }
                else
                {
                    contract.ContractId = int.Parse(txtContractID.Text);
                    ContractRepository.UpdateContract(contract);
                    MessageBox.Show("Cập nhật hợp đồng " + contract.ContractId + " thành cong!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new contract" : "Update contract");
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

        private void ContractDetails_Load(object sender, EventArgs e)
        {
            txtContractID.Enabled = false;
            if (InsertOrUpdate == true)
            {
                txtContractID.Text = ContractInfo.ContractId.ToString();
                //txtCustomerID.Text = ContractInfo.CustomerId.ToString();
                txtDepositMoney.Text = ContractInfo.DepositMoney.ToString();
                //txtDepositMoneyStatus.Text = ContractInfo.DepositMoneyStatus.ToString();
                txtEndDate.Value = ContractInfo.EndDate;
                txtStartDate.Value = ContractInfo.EndDate;
                //txtRoomID.Text = ContractInfo.RoomId.ToString();

                if (ContractInfo.DepositMoneyStatus == 1)
                {
                    txtDepositStatus.Checked = true;
                }
                else
                {
                    txtDepositStatus.Checked = false;
                }    
    
                var rooms = roomRepository.GetRooms();
                rooms.ToList().ForEach(n => 
                {
                    var item = new ComboboxItem(n.RoomName, n.RoomId);
                    comboRoom.Items.Add(item);
                    if(n.RoomId == ContractInfo.RoomId)
                    {
                        comboRoom.SelectedItem = item;
                    }
                });

                var customers = customerRepository.GetCustomers();
                customers.ToList().ForEach(n =>
                {
                    var item = new ComboboxItem(n.CustomerName + " " + n.PhoneNumber, n.CustomerId);
                    comboCustomer.Items.Add(item);
                    if (n.CustomerId == ContractInfo.CustomerId)
                    {
                        comboCustomer.SelectedItem = item;
                    }
                });

            }
            else
            {
                var rooms = roomRepository.GetRooms();
                rooms.ToList().ForEach(n => comboRoom.Items.Add(new ComboboxItem(n.RoomName, n.RoomId)));

                var customers = customerRepository.GetCustomers();
                customers.ToList().ForEach(n => comboCustomer.Items.Add(new ComboboxItem(n.CustomerName + " " + n.PhoneNumber, n.CustomerId)));
                txtContractID.Visible = false;
                txtContractID.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDepositStatus_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
