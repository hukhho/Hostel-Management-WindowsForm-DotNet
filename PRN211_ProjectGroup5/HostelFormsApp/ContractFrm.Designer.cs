
namespace HostelFormsApp
{
    partial class ContractFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractFrm));
            this.txtDepositMoney = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.lbContractID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvContractList = new System.Windows.Forms.DataGridView();
            this.lbDepositMoney = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtDepositMoneyStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.lbRoomID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDepositMoney
            // 
            resources.ApplyResources(this.txtDepositMoney, "txtDepositMoney");
            this.txtDepositMoney.Name = "txtDepositMoney";
            this.txtDepositMoney.TextChanged += new System.EventHandler(this.txtDepositMoney_TextChanged);
            // 
            // txtEndDate
            // 
            resources.ApplyResources(this.txtEndDate, "txtEndDate");
            this.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEndDate.Name = "txtEndDate";
            // 
            // txtCustomerID
            // 
            resources.ApplyResources(this.txtCustomerID, "txtCustomerID");
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            // 
            // lbCustomerID
            // 
            resources.ApplyResources(this.lbCustomerID, "lbCustomerID");
            this.lbCustomerID.Name = "lbCustomerID";
            // 
            // lbEndDate
            // 
            resources.ApplyResources(this.lbEndDate, "lbEndDate");
            this.lbEndDate.Name = "lbEndDate";
            // 
            // lbStartDate
            // 
            resources.ApplyResources(this.lbStartDate, "lbStartDate");
            this.lbStartDate.Name = "lbStartDate";
            // 
            // txtContractID
            // 
            resources.ApplyResources(this.txtContractID, "txtContractID");
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.ReadOnly = true;
            // 
            // lbContractID
            // 
            resources.ApplyResources(this.lbContractID, "lbContractID");
            this.lbContractID.Name = "lbContractID";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            resources.ApplyResources(this.btnLoad, "btnLoad");
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvContractList
            // 
            resources.ApplyResources(this.dgvContractList, "dgvContractList");
            this.dgvContractList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContractList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvContractList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvContractList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContractList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvContractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvContractList.Name = "dgvContractList";
            this.dgvContractList.ReadOnly = true;
            this.dgvContractList.RowTemplate.Height = 29;
            this.dgvContractList.RowTemplate.ReadOnly = true;
            this.dgvContractList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractList_CellContentClick_1);
            this.dgvContractList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractList_CellContentDoubleClick);
            // 
            // lbDepositMoney
            // 
            resources.ApplyResources(this.lbDepositMoney, "lbDepositMoney");
            this.lbDepositMoney.Name = "lbDepositMoney";
            // 
            // txtStartDate
            // 
            resources.ApplyResources(this.txtStartDate, "txtStartDate");
            this.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStartDate.Name = "txtStartDate";
            // 
            // txtDepositMoneyStatus
            // 
            resources.ApplyResources(this.txtDepositMoneyStatus, "txtDepositMoneyStatus");
            this.txtDepositMoneyStatus.Name = "txtDepositMoneyStatus";
            this.txtDepositMoneyStatus.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtRoomID
            // 
            resources.ApplyResources(this.txtRoomID, "txtRoomID");
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.ReadOnly = true;
            // 
            // lbRoomID
            // 
            resources.ApplyResources(this.lbRoomID, "lbRoomID");
            this.lbRoomID.Name = "lbRoomID";
            // 
            // ContractFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.txtDepositMoneyStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtDepositMoney);
            this.Controls.Add(this.lbDepositMoney);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lbCustomerID);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.txtContractID);
            this.Controls.Add(this.lbContractID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvContractList);
            this.Name = "ContractFrm";
            this.Load += new System.EventHandler(this.Contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDepositMoney;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label lbContractID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvContractList;
        private System.Windows.Forms.Label lbDepositMoney;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.TextBox txtDepositMoneyStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label lbRoomID;
    }
}