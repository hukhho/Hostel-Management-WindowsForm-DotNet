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
    public partial class UsedServiceDetailForm : Form
    {
        IRoomRepository roomRepository = new RoomRepository();
        IServiceRepository serviceRepository = new ServiceRepository();

        public IUsedServiceRepository UsedServiceRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public UsedService UsedServiceInfo { get; set; }

        public UsedServiceDetailForm()
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtPrice.Text = txtPrice.Text.Trim();
                txtQuantity.Text = txtQuantity.Text.Trim();
                if (int.Parse(txtQuantity.Text) <= 0)
                {
                    MessageBox.Show("Số lượng cần lớn hơn 0");
                    return;
                }
                if (double.Parse(txtPrice.Text) < 0)
                {
                    MessageBox.Show("Giá cần lớn hơn hoặc bằng 0");
                    return;
                }
                int _roomId;
                int _serviceId;
                if (comboRoom.SelectedItem != null && txtPrice.Text != null && txtQuantity.Text != null && comboService.SelectedItem != null)
                {
                    _roomId = (int)(comboRoom.SelectedItem as ComboboxItem).Value;
                    _serviceId = (int)(comboService.SelectedItem as ComboboxItem).Value;
                }
                else
                {
                    MessageBox.Show("Cần điền đủ thông tin");
                    return;
                }

                var usedService = new UsedService
                {
                    ServiceId = _serviceId,
                    RoomId = _roomId,
                    Price = double.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                };
                if (InsertOrUpdate == false)
                {
                    UsedServiceRepository.InsertUsedService(usedService);
                    MessageBox.Show("Tạo dịch vụ sử dụng  " + usedService.UsedServiceId + " thành công!");
                    this.Close();
                }
                else
                {
                    usedService.UsedServiceId = int.Parse(txtUsedServiceID.Text);
                    UsedServiceRepository.UpdateUsedService(usedService);
                    MessageBox.Show("Cập nhật dịch vụ sử dụng " + usedService.UsedServiceId + " thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add New Used Service" : "Update Used Service");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void UsedServiceDetailForm_Load(object sender, EventArgs e)
        {
            txtUsedServiceID.Enabled = false;

            if (InsertOrUpdate == true)
            {
                txtUsedServiceID.Text = UsedServiceInfo.UsedServiceId.ToString();
                txtQuantity.Text = UsedServiceInfo.Quantity.ToString();

                var rooms = roomRepository.GetRooms();
                rooms.ToList().ForEach(n =>
                {
                    var item = new ComboboxItem(n.RoomName, n.RoomId);
                    comboRoom.Items.Add(item);
                    if (n.RoomId == UsedServiceInfo.RoomId)
                    {
                        comboRoom.SelectedItem = item;
                    }
                });

                var services = serviceRepository.GetServices();
                services.ToList().ForEach(n =>
                {
                    var item = new ComboboxItem(n.ServiceName, n.ServiceId);
                    comboService.Items.Add(item);
                    if (n.ServiceId == UsedServiceInfo.ServiceId)
                    {
                        comboService.SelectedItem = item;
                    }
                });

                if (UsedServiceInfo.ServiceId == (int)(comboService?.SelectedItem as ComboboxItem).Value)
                {
                    txtPrice.Text = UsedServiceInfo.Price.ToString();
                }
            }
            else
            {
                var rooms = roomRepository.GetRooms();
                rooms.ToList().ForEach(n => comboRoom.Items.Add(new ComboboxItem(n.RoomName, n.RoomId)));

                var services = serviceRepository.GetServices();
                services.ToList().ForEach(n => comboService.Items.Add(new ComboboxItem(n.ServiceName, n.ServiceId)));

                txtUsedServiceID.Visible = false;
                lbUsedServiceID.Visible = false;          
            }

        }

        private void comboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _serviceId;
            if (comboService.SelectedItem != null)
            {              
                _serviceId = (int)(comboService.SelectedItem as ComboboxItem).Value;
                var service = serviceRepository.GetServiceByID(_serviceId);

                txtPrice.Text = service.Price.ToString();         
            }
           
        }
    }
}
