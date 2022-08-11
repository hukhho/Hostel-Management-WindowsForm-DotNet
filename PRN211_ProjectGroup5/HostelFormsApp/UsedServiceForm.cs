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
    public partial class UsedServiceForm : Form
    {
        IUsedServiceRepository usedServiceRepository = new UsedServiceRepository();

        BindingSource source;
        List<UsedService> usedServices;

        public UsedServiceForm()
        {
            InitializeComponent();
        }
        public void LoadUsedServiceList()
        {
            usedServices = (List<UsedService>) usedServiceRepository.GetUsedServices();

            try
            {
                source = new BindingSource();
                source.DataSource = usedServices;

                txtRoomID.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtUsedServiceID.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtInvoiceID.DataBindings.Clear();
                txtServiceID.DataBindings.Clear();

                txtRoomID.DataBindings.Add("Text", source, "RoomId");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtServiceID.DataBindings.Add("Text", source, "ServiceId");
                txtUsedServiceID.DataBindings.Add("Text", source, "UsedServiceId");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtInvoiceID.DataBindings.Add("Text", source, "InvoiceId");

                dgvUsedServiceList.DataSource = null;
                dgvUsedServiceList.DataSource = source;

                this.dgvUsedServiceList.Columns["RoomId"].Visible = false;
                this.dgvUsedServiceList.Columns["ServiceId"].Visible = false;
                //this.dgvUsedServiceList.Columns["Service"].Visible = false;

                if (usedServices.Count() == 0)
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
        private UsedService GetUsedService()
        {
            UsedService usedService = null;
            try
            {
                usedService = new UsedService
                {
                    UsedServiceId = int.Parse(txtUsedServiceID.Text),
                    ServiceId = int.Parse(txtServiceID.Text),
                    RoomId = int.Parse(txtRoomID.Text),
                    Price = double.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    InvoiceId = Utils.ToNullableInt(txtInvoiceID.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Used Service");
            }
            return usedService;
        }
        
        private void ClearText()
        {
            txtRoomID.Text = string.Empty;
            txtUsedServiceID.Text = string.Empty;
            txtServiceID.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtInvoiceID.Text = string.Empty;           
        }
        private void ReadOnyTextBox()
        {
            txtRoomID.ReadOnly = true;
            txtUsedServiceID.ReadOnly = true;
            txtServiceID.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtInvoiceID.ReadOnly = true;
        }
        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void dgvUsedServiceList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
       
            UsedServiceDetailForm usedServiceDetailForm = new UsedServiceDetailForm()
            {
                Text = "Update",
                InsertOrUpdate = true,
                UsedServiceInfo = GetUsedService(),
                UsedServiceRepository = usedServiceRepository,
            };
            LoadUsedServiceList();
            try
            {
                if (usedServiceDetailForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsedServiceList();
                    source.Position = source.Count - 1;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                LoadUsedServiceList();
            }
        }

        private void dgvUsedServiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsedServiceForm_Load(object sender, EventArgs e)
        {
            LoadUsedServiceList();
            ReadOnyTextBox();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadUsedServiceList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UsedServiceDetailForm usedServiceDetailForm = new UsedServiceDetailForm()
            {
                Text = "Add used service",
                InsertOrUpdate = false,
                UsedServiceRepository = usedServiceRepository
            };
            if (usedServiceDetailForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsedServiceList();
                source.Position = source.Count - 1;
            }
            LoadUsedServiceList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Are you sure delele this?", "Delete used service", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var usedService = GetUsedService();
                    usedServiceRepository.DeleteUsedService(usedService.UsedServiceId);
                }
                LoadUsedServiceList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete used service");
            }
        }
       

    }

}
