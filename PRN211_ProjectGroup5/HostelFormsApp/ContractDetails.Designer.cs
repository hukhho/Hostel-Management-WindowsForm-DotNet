
namespace HostelFormsApp
{
    partial class ContractDetails
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
            this.lbRoomID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtDepositMoney = new System.Windows.Forms.TextBox();
            this.lbDepositMoney = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.lbContractID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.txtDepositStatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Location = new System.Drawing.Point(35, 314);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(51, 20);
            this.lbRoomID.TabIndex = 125;
            this.lbRoomID.Text = "Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 123;
            this.label1.Text = "Trạng thái tiền cọc";
            // 
            // txtStartDate
            // 
            this.txtStartDate.CustomFormat = "dd/MM/yyyy";
            this.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStartDate.Location = new System.Drawing.Point(195, 91);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(125, 27);
            this.txtStartDate.TabIndex = 122;
            // 
            // txtDepositMoney
            // 
            this.txtDepositMoney.Location = new System.Drawing.Point(195, 221);
            this.txtDepositMoney.Name = "txtDepositMoney";
            this.txtDepositMoney.Size = new System.Drawing.Size(125, 27);
            this.txtDepositMoney.TabIndex = 121;
            // 
            // lbDepositMoney
            // 
            this.lbDepositMoney.AutoSize = true;
            this.lbDepositMoney.Location = new System.Drawing.Point(35, 224);
            this.lbDepositMoney.Name = "lbDepositMoney";
            this.lbDepositMoney.Size = new System.Drawing.Size(64, 20);
            this.lbDepositMoney.TabIndex = 120;
            this.lbDepositMoney.Text = "Tiền cọc";
            // 
            // txtEndDate
            // 
            this.txtEndDate.CustomFormat = "dd/MM/yyyy";
            this.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEndDate.Location = new System.Drawing.Point(195, 136);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(125, 27);
            this.txtEndDate.TabIndex = 119;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(35, 181);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(49, 20);
            this.lbCustomerID.TabIndex = 117;
            this.lbCustomerID.Text = "Khách";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(35, 136);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(100, 20);
            this.lbEndDate.TabIndex = 116;
            this.lbEndDate.Text = "Ngày kết thúc";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(35, 93);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(99, 20);
            this.lbStartDate.TabIndex = 115;
            this.lbStartDate.Text = "Ngày bắt đầu";
            // 
            // txtContractID
            // 
            this.txtContractID.Location = new System.Drawing.Point(195, 50);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.ReadOnly = true;
            this.txtContractID.Size = new System.Drawing.Size(125, 27);
            this.txtContractID.TabIndex = 114;
            // 
            // lbContractID
            // 
            this.lbContractID.AutoSize = true;
            this.lbContractID.Location = new System.Drawing.Point(35, 50);
            this.lbContractID.Name = "lbContractID";
            this.lbContractID.Size = new System.Drawing.Size(24, 20);
            this.lbContractID.TabIndex = 113;
            this.lbContractID.Text = "ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 128;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(66, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboRoom
            // 
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(195, 314);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(125, 28);
            this.comboRoom.TabIndex = 129;
            this.comboRoom.SelectedIndexChanged += new System.EventHandler(this.comboRoom_SelectedIndexChanged);
            // 
            // comboCustomer
            // 
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(195, 178);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(267, 28);
            this.comboCustomer.TabIndex = 130;
            // 
            // txtDepositStatus
            // 
            this.txtDepositStatus.AutoSize = true;
            this.txtDepositStatus.Location = new System.Drawing.Point(195, 272);
            this.txtDepositStatus.Name = "txtDepositStatus";
            this.txtDepositStatus.Size = new System.Drawing.Size(89, 24);
            this.txtDepositStatus.TabIndex = 131;
            this.txtDepositStatus.Text = "Đã đóng";
            this.txtDepositStatus.UseVisualStyleBackColor = true;
            this.txtDepositStatus.CheckedChanged += new System.EventHandler(this.txtDepositStatus_CheckedChanged);
            // 
            // ContractDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 447);
            this.Controls.Add(this.txtDepositStatus);
            this.Controls.Add(this.comboCustomer);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtDepositMoney);
            this.Controls.Add(this.lbDepositMoney);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lbCustomerID);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.txtContractID);
            this.Controls.Add(this.lbContractID);
            this.Name = "ContractDetails";
            this.Text = "Chi tiết hợp đồng";
            this.Load += new System.EventHandler(this.ContractDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.TextBox txtDepositMoney;
        private System.Windows.Forms.Label lbDepositMoney;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label lbContractID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.CheckBox txtDepositStatus;
    }
}