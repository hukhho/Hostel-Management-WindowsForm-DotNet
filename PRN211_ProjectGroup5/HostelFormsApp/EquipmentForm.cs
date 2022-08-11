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
    public partial class EquipmentForm : Form
    {
        IEquipmentRepository equipmentRepository = new EquipmentRepository();
        BindingSource source;
        
        public EquipmentForm()
        {
            InitializeComponent();
        }

        public void LoadEquipmentList()
        {
            var equipments = equipmentRepository.GetEquipments();

            try
            {
                source = new BindingSource();
                source.DataSource = equipments;

                txtEquipmentID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtRoomID.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtEquipmentID.DataBindings.Add("Text", source, "EquipmentId");
                txtName.DataBindings.Add("Text", source, "Name");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtRoomID.DataBindings.Add("Text", source, "RoomId");
                txtStatus.DataBindings.Add("Text", source, "Status");

                dgvEquipmentList.DataSource = null;
                dgvEquipmentList.DataSource = source;

                this.dgvEquipmentList.Columns["RoomId"].Visible = false;
                this.dgvEquipmentList.Columns["Status"].Visible = false;
                if (equipments.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load list");
            }
        }
        private Equipment GetEquipmentObject()
        {
            Equipment equipment = null;
            try
            {
                equipment = new Equipment
                {
                    EquipmentId = int.Parse(txtEquipmentID.Text),
                    RoomId = int.Parse(txtRoomID.Text),
                    Name = txtName.Text,
                    Quantity = int.Parse(txtQuantity.Text),
                    Price = Utils.ToNullableDouble(txtPrice.Text),
                    Status = int.Parse(txtStatus.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Equipment");
            }
            return equipment;
        }
        private void dgvEquipmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            LoadEquipmentList();
        }
        private void ClearText()
        {
            txtEquipmentID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtRoomID.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }
        private void dgvEquipmentList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EquipmentDetailsForm equipmentDetailsForm = new EquipmentDetailsForm()
            {
                Text = "Cập nhật",
                InsertOrUpdate = true,
                EquipmentInfo = GetEquipmentObject(),
                EquipmentRepository = equipmentRepository
            };
            LoadEquipmentList();
            try
            {
                if (equipmentDetailsForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEquipmentList();
                    source.Position = source.Count - 1;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                LoadEquipmentList();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EquipmentDetailsForm equipmentDetailsForm = new EquipmentDetailsForm()
            {
                Text = "Tạo mới",
                InsertOrUpdate = false,
                EquipmentRepository = equipmentRepository
            };
            if (equipmentDetailsForm.ShowDialog() == DialogResult.OK)
            {
                LoadEquipmentList();
                source.Position = source.Count - 1;
            }
            LoadEquipmentList();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Bạn có chắc xoá không?", "Xoá", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var equipment = GetEquipmentObject();
                    equipmentRepository.DeleteEquipment(equipment.EquipmentId);
                }
                LoadEquipmentList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xoá");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEquipmentList();
        }
    }
}
