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
    public partial class RoomDetails : Form

    {
        public IRoomRepository RoomRepository { get; set; }

        public bool InsertOrUpdate { get; set; }
        public Room RoomInfo { get; set; }

        public RoomDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtRoomName.Text = txtRoomName.Text.Trim();
                txtPrice.Text = txtPrice.Text.Trim();
                if (double.Parse(txtPrice.Text) <= 0)
                {
                    MessageBox.Show("Tiền phòng cần lớn hơn 0!");
                    return;
                }
                var room = new Room
                {
                    RoomName = txtRoomName.Text,
                    Price = int.Parse(txtPrice.Text),
                    
                };
                if (InsertOrUpdate == false)
                {
                    var room1 = RoomRepository.GetRooms().ToList().FirstOrDefault(p => p.RoomName == room.RoomName);
                    if (room1 != null)
                    {
                        MessageBox.Show("Tên phòng không được trùng!");
                        return;
                    }
                    room.RoomStatus = 1;
                    RoomRepository.InsertRoom(room);

                    MessageBox.Show("Tạo phòng " + room.RoomId + " thành công!");
                    this.Close();
                }
                else
                {
                    if (isActiveRoom.Checked)
                    {
                        room.RoomStatus = 1;
                    } else
                    {
                        room.RoomStatus = 0;
                    }

                    room.RoomId = int.Parse(txtRoomID.Text);
                    var room1 = RoomRepository.GetRooms().ToList().FirstOrDefault(p => p.RoomName == room.RoomName && p.RoomId != room.RoomId);

                    if (room1 != null)
                    {
                        MessageBox.Show("Tên phòng không được trùng!");
                        return;
                    }

                    RoomRepository.UpdateRoom(room);
                    MessageBox.Show("Cập nhật thành công phòng id " + room.RoomId);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Thêm" : "Cập nhật");
            }
        }

        private void RoomDetails_Load(object sender, EventArgs e)
        {
            txtRoomID.Enabled = false;
            if (InsertOrUpdate == true)
            {
                txtRoomID.Text = RoomInfo.RoomId.ToString();
                txtRoomName.Text = RoomInfo.RoomName;
                txtPrice.Text = RoomInfo.Price.ToString();

                if (RoomInfo.RoomStatus == 1)
                {
                    isActiveRoom.Checked = true;
                } else
                {
                    isActiveRoom.Checked = false;
                }

            } else
            {
                txtRoomID.Visible= false;
                lbRoomID.Visible = false;
                isActiveRoom.Visible = false;
                lbStatus.Visible = false;
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void isActiveRoom_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
