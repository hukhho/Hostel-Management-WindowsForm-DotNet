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
    public partial class ContractFrm : Form
    {
        IContractRepository contractRepository = new ContractRepository();
        BindingSource source;
        public ContractFrm()
        {
            InitializeComponent();
        }

        public void LoadContractList()
        {
            var contracts = contractRepository.GetContracts();

            try
            {
                source = new BindingSource();
                source.DataSource = contracts;

                txtRoomID.DataBindings.Clear();
                txtContractID.DataBindings.Clear();
                txtStartDate.DataBindings.Clear();
                txtEndDate.DataBindings.Clear();
                txtCustomerID.DataBindings.Clear();
                txtDepositMoney.DataBindings.Clear();
                txtDepositMoneyStatus.DataBindings.Clear();

                txtRoomID.DataBindings.Add("Text", source, "RoomId");
                txtContractID.DataBindings.Add("Text", source, "ContractId");
                txtStartDate.DataBindings.Add("Text", source, "StartDate");
                txtEndDate.DataBindings.Add("Text", source, "EndDate");
                txtCustomerID.DataBindings.Add("Text", source, "CustomerId");
                txtDepositMoney.DataBindings.Add("Text", source, "DepositMoney");
                txtDepositMoneyStatus.DataBindings.Add("Text", source, "DepositMoneyStatus");

                dgvContractList.DataSource = null;
                dgvContractList.DataSource = source;

                this.dgvContractList.Columns["RoomId"].Visible = false;
                this.dgvContractList.Columns["CustomerId"].Visible = false;
                this.dgvContractList.Columns["DepositMoneyStatus"].Visible = false;
                //this.dgvContractList.Columns["Room"].Visible = false;

                if (contracts.Count() == 0)
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
        private Contract GetContractObject()
        {
            Contract contract = null;
            try
            {
                contract = new Contract
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                    ContractId = int.Parse(txtContractID.Text),
                    RoomId = int.Parse(txtRoomID.Text),
                    StartDate = txtStartDate.Value,
                    EndDate = txtEndDate.Value,
                    DepositMoney = int.Parse(txtDepositMoney.Text),
                    DepositMoneyStatus = int.Parse(txtDepositMoneyStatus.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Contract");
            }
            return contract;
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            LoadContractList();
        }
        private void ClearText()
        {
            txtRoomID.Text = string.Empty;
            txtCustomerID.Text = string.Empty;
            txtStartDate.Value = DateTime.Today;
            txtEndDate.Value = DateTime.Today;
            txtDepositMoney.Text = string.Empty;
            txtDepositMoneyStatus.Text = string.Empty;
            txtContractID.Text = string.Empty;
        }

        private void dgvContractList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ContractDetails contractDetails = new ContractDetails()
            {
                Text = "Cập nhật",
                InsertOrUpdate = true,
                ContractInfo =  GetContractObject(),
                ContractRepository = contractRepository
            };
            LoadContractList();
            try
            {
                if (contractDetails.ShowDialog() == DialogResult.OK)
                {
                    LoadContractList();
                    source.Position = source.Count - 1;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                LoadContractList();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadContractList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ContractDetails contractDetails = new ContractDetails()
            {
                Text = "Thêm",
                InsertOrUpdate = false,
                ContractRepository = contractRepository
            };
            if (contractDetails.ShowDialog() == DialogResult.OK)
            {
                LoadContractList();
                source.Position = source.Count - 1;
            }
            LoadContractList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Bạn có chắc xoá không?", "Xoá", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var contract = GetContractObject();
                    contractRepository.DeleteContract(contract.ContractId);
                }
                LoadContractList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xoá");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void dgvContractList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDepositMoney_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
