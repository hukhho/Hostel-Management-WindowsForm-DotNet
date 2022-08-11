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
    public partial class EquipmentDetailsForm : Form
    {
        IRoomRepository roomRepository = new RoomRepository();
        public IEquipmentRepository EquipmentRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Equipment EquipmentInfo { get; set; }
        public EquipmentDetailsForm()
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
                int _roomId;
                
                if (comboRoom.SelectedItem != null && txtName.Text.Length > 1 && int.Parse(txtQuantity.Text) >= 0)
                {
                    _roomId = (int)(comboRoom.SelectedItem as ComboboxItem).Value;
                }
                else
                {
                    MessageBox.Show("Cần điền tất cả ô!");
                    return;
                }

                if(Utils.ToNullableDouble(txtPrice.Text) < 0)
                {
                    MessageBox.Show("Giá phải lớn hơn hoặc bằng 0!");
                    return;
                }
                int status;
                if (txtStatus.Checked)
                {
                    status = 1;
                }
                else
                {
                    status = 0;
                }

                var equipment = new Equipment
                {
                    Name = txtName.Text,
                    Quantity = int.Parse(txtQuantity.Text),
                    Price = Utils.ToNullableDouble(txtPrice.Text),
                    RoomId = _roomId,
                    Status = status,
                };
                if (InsertOrUpdate == false)
                {
                    EquipmentRepository.InsertEquipment(equipment);
                    MessageBox.Show("Tạo  " + equipment.EquipmentId + " thành công!");
                    this.Close();
                }
                else
                {
                    equipment.EquipmentId = int.Parse(txtEquipmentID.Text);
                    EquipmentRepository.UpdateEquipment(equipment);
                    MessageBox.Show("Cập nhật " + equipment.EquipmentId + " thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Thêm vật dụng" : "Cập nhật vật dụng");
            }

        }

        private void EquipmentDetailsForm_Load(object sender, EventArgs e)
        {
            txtEquipmentID.Enabled = false;
            if (InsertOrUpdate == true)
            {
                txtEquipmentID.Text = EquipmentInfo.EquipmentId.ToString();
                txtName.Text = EquipmentInfo.Name.ToString();
                txtPrice.Text = EquipmentInfo.Price.ToString();
                txtQuantity.Text = EquipmentInfo.Quantity.ToString();
                //txtRoomID.Text = EquipmentInfo.RoomId.ToString();          
                if (EquipmentInfo.Status == 1)
                {
                    txtStatus.Checked = true;
                }
                else
                {
                    txtStatus.Checked = false;
                }

                var rooms = roomRepository.GetRooms();
                rooms.ToList().ForEach(n =>
                {
                    var item = new ComboboxItem(n.RoomName, n.RoomId);
                    comboRoom.Items.Add(item);
                    if (n.RoomId == EquipmentInfo.RoomId)
                    {
                        comboRoom.SelectedItem = item;
                    }
                });
            }
            else
            {
                var rooms = roomRepository.GetRooms();
                rooms.ToList().ForEach(n => comboRoom.Items.Add(new ComboboxItem(n.RoomName, n.RoomId)));

                txtEquipmentID.Visible = false;
                lbEquipmentID.Visible = false; 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void txtStatus_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
