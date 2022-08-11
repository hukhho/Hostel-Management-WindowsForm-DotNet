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
    public partial class RoomForm : Form
    {
        IRoomRepository roomRepository = new RoomRepository();

        BindingSource source;
        List<Room> rooms;

        public RoomForm()
        {
            InitializeComponent();
        }
        public void LoadRoomList()
        {
            rooms = (List<Room>) roomRepository.GetRooms();

            try
            {
                source = new BindingSource();
                source.DataSource = rooms;

                txtRoomID.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtRoomName.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtRoomID.DataBindings.Add("Text", source, "RoomID");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtRoomName.DataBindings.Add("Text", source, "RoomName");
                txtStatus.DataBindings.Add("Text", source, "RoomStatus");

                dgvRoomList.DataSource = null;
                dgvRoomList.DataSource = source;

                this.dgvRoomList.Columns["RoomStatus"].Visible = false;
                //this.dgvRoomList.Columns["Customers"].Visible = false;
                //this.dgvRoomList.Columns["Invoices"].Visible = false;
                //this.dgvRoomList.Columns["UsedServices"].Visible = false;
                //this.dgvRoomList.Columns["Equipment"].Visible = false;

                if (rooms.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load room list");
            }
        }
        private Room GetRoomObject()
        {
            Room room = null;
            try
            {
                room = new Room
                {
                    RoomId = int.Parse(txtRoomID.Text),
                    RoomName = txtRoomName.Text,
                    Price = int.Parse(txtPrice.Text),
                    RoomStatus = int.Parse(txtStatus.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Room");
            }
            return room;
        }
        private void dgvRoomList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            LoadRoomList();

            txtStatus.Visible = false;
            lbStatus.Visible = false;

        }
        private void ClearText()
        {
            txtRoomID.Text = string.Empty;
            txtRoomName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStatus.Text = string.Empty;          
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Bạn có chắc xoá không?", "Delete room", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var room = GetRoomObject();
                    roomRepository.DeleteRoom(room.RoomId);
                }
                LoadRoomList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xoá phòng");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            RoomDetails roomDetails = new RoomDetails()
            {
                Text = "Thêm phòng",
                InsertOrUpdate = false,
                RoomRepository = roomRepository
            };
            if (roomDetails.ShowDialog() == DialogResult.OK)
            {
                LoadRoomList();
                source.Position = source.Count - 1;
            }
            LoadRoomList();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadRoomList();
        }

      

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void dgvRoomList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var roomInfo = GetRoomObject();
            if (roomInfo == null)
            {
                MessageBox.Show("Lỗi lấy dữ liệu phòng!");
            }
            RoomDetails roomDetails = new RoomDetails()
            {
                Text = "Cập nhật",
                InsertOrUpdate = true,
                RoomInfo = roomInfo,
                RoomRepository = roomRepository
            };
            LoadRoomList();
            try
            {
                if (roomDetails.ShowDialog() == DialogResult.OK)
                {
                    LoadRoomList();
                    source.Position = source.Count - 1;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                LoadRoomList();
            }
        }
    }
}
