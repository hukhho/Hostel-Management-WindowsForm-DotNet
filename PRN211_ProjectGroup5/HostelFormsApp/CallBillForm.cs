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
    public partial class CallBillForm : Form
    {
        IRoomRepository roomRepository = new RoomRepository();
        IUsedServiceRepository usedServiceRepository = new UsedServiceRepository();
        IServiceRepository serviceRepository = new ServiceRepository();
        IInvoiceRepository invoiceRepository = new InvoiceRepository();
        ICustomerRepository customerRepository = new CustomerRepository();

        BindingSource source;
        public CallBillForm()
        {
            InitializeComponent();
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
        private void checkListUsed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CallBillForm_Load(object sender, EventArgs e)
        {
            var rooms = roomRepository.GetRooms();
            rooms.ToList().ForEach(n => comboRoom.Items.Add(new ComboboxItem(n.RoomName, n.RoomId)));
        }
        void SelectDeselectAll(bool Selected)
        {
            for (int i = 0; i < checkListUsed.Items.Count; i++) // loop to set all items checked or unchecked
            {
                checkListUsed.SetItemChecked(i, Selected);
            }
        }
        private void comboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show((comboRoom.SelectedItem as ComboboxItem).Value.ToString());
            try
            {
                txtRoomCharge.Text = string.Empty;
                
                int _roomId = (int)(comboRoom.SelectedItem as ComboboxItem).Value;
                Room _room = roomRepository.GetRoomByID(_roomId);
                if (_room == null)
                {
                    MessageBox.Show("Lỗi tìm phòng");
                    return;
                }
                txtRoomCharge.Text = _room.Price.ToString();

                var usedServices = _room.UsedServices;

                checkListUsed.Items.Clear();

                usedServices.ToList().ForEach(u =>
                {
                    Service service = serviceRepository.GetServiceByID(u.ServiceId);
                    string total = ((double)u.Price * (double)u.Quantity).ToString();
                    string text = service.ServiceName + " - " + total;
                    if (u.InvoiceId == null)
                    {
                        ComboboxItem item = new ComboboxItem(text, u.UsedServiceId);
                        checkListUsed.Items.Insert(0, item);
                    }
                });

                var customers = customerRepository.GetCustomers();
                customers.ToList().ForEach(c => {
                    if (c.IsRenting && c.RoomId == _roomId)
                    {
                        string text = c.CustomerName + " - " + c.PhoneNumber;
                        ComboboxItem item = new ComboboxItem(text, c.CustomerId);

                        comboCustomer.Items.Add(item);
                    }
                });

                SelectDeselectAll(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Select");
            }
        }

        private void btnCallBill_Click(object sender, EventArgs e)
        {
            txtInvoiceName.Text = txtInvoiceName.Text.Trim();
            txtRoomCharge.Text = txtRoomCharge.Text.Trim();
            txtNote.Text = txtNote.Text.Trim(); 

            int _roomId;
            int _customerId;
            if (comboRoom.SelectedItem is not null && comboCustomer.SelectedItem is not null && txtInvoiceName.Text is not null && txtRoomCharge.Text is not null)
            {
                _roomId = int.Parse((comboRoom.SelectedItem as ComboboxItem).Value.ToString());
                _customerId = int.Parse((comboCustomer.SelectedItem as ComboboxItem).Value.ToString());
            } else
            {
                MessageBox.Show("Cần điền đủ thông tin!");
                return;             
            }
            if (double.Parse(txtRoomCharge.Text) < 0)
            {
                MessageBox.Show("Tiền phòng không được nhỏ hơn 0!");
                return;
            }
            if (txtInvoiceName.Text.Length < 3 || txtInvoiceName.Text.Length > 20)
            {
                MessageBox.Show("Tên hoá đơn từ 3 - 20 kí tự!");
                return;
            }

            try
            {
                Invoice invoice = new Invoice()
                {
                    InvoiceName = txtInvoiceName.Text,
                    RoomId = _roomId,
                    CustomerId = _customerId,
                    RoomCharge = double.Parse(txtRoomCharge.Text),
                    Note = txtNote.Text,
                    Status = 0,
                };
                invoiceRepository.InsertInvoice(invoice);
                MessageBox.Show("Tạo thành công hoá đơn có id : " + invoice.InvoiceId.ToString());
                double totalServiceCharge = 0;
                foreach (ComboboxItem item in checkListUsed.CheckedItems)
                {
                    int _usedServiceId = (int) item.Value;
                    var usedService = usedServiceRepository.GetUsedServiceByID(_usedServiceId);
                    if (usedService is not null)
                    {
                        usedService.InvoiceId = invoice.InvoiceId;
                        totalServiceCharge += (double)usedService.Price * (double)usedService.Quantity;
                        usedServiceRepository.UpdateUsedService(usedService);
                    }
                }
                invoice.ServiceCharge = totalServiceCharge;
                invoice.Total = totalServiceCharge + invoice.RoomCharge;
                invoiceRepository.UpdateInvoice(invoice);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Call Bill");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void txtSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSelectAll.Checked)
            {
                SelectDeselectAll(true);
            }
            else
            {
                SelectDeselectAll(false);
            }
        }
    }
}
