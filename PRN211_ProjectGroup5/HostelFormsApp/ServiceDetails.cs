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
    public partial class ServiceDetails : Form
    {
        public IServiceRepository ServiceRepository { get; set; }

        public bool InsertOrUpdate { get; set; }
        public Service ServiceInfo { get; set; }
        public ServiceDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtServiceName.Text = txtServiceName.Text.Trim();
                txtPrice.Text = txtPrice.Text.Trim();

                if (double.Parse(txtPrice.Text) < 0)
                {
                    MessageBox.Show("Giá không được là số âm!");
                    return;
                }
                var service = new Service
                {
                    ServiceName = txtServiceName.Text,
                    Price = int.Parse(txtPrice.Text), 
                };
                if (InsertOrUpdate == false)
                {
                    var ser1 = ServiceRepository.GetServices().ToList().FirstOrDefault(p => p.ServiceName == service.ServiceName);
                    if (ser1 != null)
                    {
                        MessageBox.Show("Tên dịch vụ không được trùng!");
                        return;
                    }

                    ServiceRepository.InsertService(service);
                    MessageBox.Show("Tạo dịch vụ " + service.ServiceId + " thành công!");
                    this.Close();
                }
                else
                {

                    service.ServiceId = int.Parse(txtServiceID.Text);
                    ServiceRepository.UpdateService(service);
                    var ser1 = ServiceRepository.GetServices().ToList().FirstOrDefault(p => p.ServiceName == service.ServiceName && service.ServiceId != p.ServiceId);
                    if (ser1 != null)
                    {
                        MessageBox.Show("Tên dịch vụ không được trùng!");
                        return;
                    }
                    MessageBox.Show("Cập nhật dịch vụ  " + service.ServiceId + " thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new Service" : "Update Service");
            }
        }

        private void ServiceDetails_Load(object sender, EventArgs e)
        {
            txtServiceID.Enabled = false;
            if (InsertOrUpdate == true) //true is update
            {
                txtServiceID.Text = ServiceInfo.ServiceId.ToString();
                txtPrice.Text = ServiceInfo.Price.ToString();
                txtServiceName.Text = ServiceInfo.ServiceName.ToString();           
            }
            else 
            {
                txtServiceID.Visible = false;
                lbServiceID.Visible = false;        
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
