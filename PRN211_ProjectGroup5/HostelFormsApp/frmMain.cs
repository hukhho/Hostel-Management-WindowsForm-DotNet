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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        RoomForm roomForm;
        CustomerForm customerForm;
        InvoiceForm invoiceForm;
        EquipmentForm equipmentForm;
        ContractFrm contractFrm;
        CallBillForm CallBillForm;
        ServiceForm serviceForm;
        UsedServiceForm usedServiceForm;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

      
      
        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMain;
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;        

            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabMain.SelectedTab != null && this.tabMain.SelectedTab.Tag != null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.roomForm is null || this.roomForm.IsDisposed)
            {
                this.roomForm = new RoomForm();
                this.roomForm.MdiParent = this;
                this.ShowInTaskbar = false;
                this.roomForm.Show();
            }
            else
            {
                this.roomForm.Select();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.customerForm is null || this.customerForm.IsDisposed)
            {
                this.customerForm = new CustomerForm();
                this.customerForm.MdiParent = this;
                this.ShowInTaskbar = false;
                this.customerForm.Show();
            }
            else
            {
                this.customerForm.Select();
            }
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.equipmentForm is null || this.equipmentForm.IsDisposed)
            {
                this.equipmentForm = new EquipmentForm();
                this.equipmentForm.MdiParent = this;
                this.ShowInTaskbar = false;
                this.equipmentForm.Show();
            }
            else
            {
                this.equipmentForm.Select();
            }
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void invoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.invoiceForm is null || this.invoiceForm.IsDisposed)
            {
                this.invoiceForm = new InvoiceForm();
                this.invoiceForm.MdiParent = this;
                this.ShowInTaskbar = false;
                this.invoiceForm.Show();
            }
            else
            {
                this.invoiceForm.Select();
            }
        }

        private void contractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.contractFrm is null || this.contractFrm.IsDisposed)
            {
                this.contractFrm = new ContractFrm();
                this.contractFrm.MdiParent = this;
                this.ShowInTaskbar = false;
                this.contractFrm.Show();
            }
            else
            {
                this.contractFrm.Select();
            }
        }

        private void callBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CallBillForm is null || this.CallBillForm.IsDisposed)
            {
                this.CallBillForm = new CallBillForm();
                this.CallBillForm.MdiParent = this;
                this.CallBillForm.Show();
            }
            else
            {
                this.CallBillForm.Select();
            }
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.serviceForm is null || this.serviceForm.IsDisposed)
            {
                this.serviceForm = new ServiceForm();
                this.serviceForm.MdiParent = this;
                this.serviceForm.Show();
            }
            else
            {
                this.serviceForm.Select();
            }
        }

        private void usedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.usedServiceForm is null || this.usedServiceForm.IsDisposed)
            {
                this.usedServiceForm = new UsedServiceForm();
                this.usedServiceForm.MdiParent = this;
                this.usedServiceForm.Show();
            }
            else
            {
                this.usedServiceForm.Select();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
