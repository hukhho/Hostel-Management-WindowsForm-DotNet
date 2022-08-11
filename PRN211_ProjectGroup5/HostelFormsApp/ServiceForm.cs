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
    public partial class ServiceForm : Form
    {
        IServiceRepository serviceRepository = new ServiceRepository();
        BindingSource source;
        public ServiceForm()
        {
            InitializeComponent();
        }
        public void LoadServiceList()
        {
            var services = serviceRepository.GetServices();

            try
            {
                source = new BindingSource();
                source.DataSource = services;

                txtServiceID.DataBindings.Clear();
                txtServiceName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();

                txtServiceID.DataBindings.Add("Text", source, "ServiceId");
                txtServiceName.DataBindings.Add("Text", source, "ServiceName");
                txtPrice.DataBindings.Add("Text", source, "Price");

                dgvServiceList.DataSource = null;
                dgvServiceList.DataSource = source;

                //this.dgvServiceList.Columns["UsedServices"].Visible = false;

                if (services.Count() == 0)
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
        private Service GetServiceObject()
        {
            Service service = null;
            try
            {
                service = new Service
                {
                    ServiceId = int.Parse(txtServiceID.Text),
                    Price = int.Parse(txtPrice.Text),
                    ServiceName = txtServiceName.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Service");
            }
            return service;
        }

        private void Service_Load(object sender, EventArgs e)
        {
            LoadServiceList();
        }
        private void ClearText()
        {
            txtServiceID.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtServiceName.Text = string.Empty;
        }

        private void dgvServiceList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceDetails ServiceDetails = new ServiceDetails()
            {
                Text = "Cập nhật",
                InsertOrUpdate = true,
                ServiceInfo = GetServiceObject(),
                ServiceRepository = serviceRepository
            };
            LoadServiceList();
            try
            {
                if (ServiceDetails.ShowDialog() == DialogResult.OK)
                {
                    LoadServiceList();
                    source.Position = source.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Double Click Cell");
            }
            finally
            {
                LoadServiceList();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadServiceList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {         
            ServiceDetails ServiceDetails = new ServiceDetails()
            {
                Text = "Tạo dịch vụ",
                InsertOrUpdate = false,
                ServiceRepository = serviceRepository
            };
            if (ServiceDetails.ShowDialog() == DialogResult.OK)
            {
                LoadServiceList();
                source.Position = source.Count - 1;
            }
            LoadServiceList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Bạn có chắc xoá không?", "Xoá", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var service = GetServiceObject();
                    serviceRepository.DeleteService(service.ServiceId);
                }
                LoadServiceList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Service");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void dgvServiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            LoadServiceList();
        }
    }
}
