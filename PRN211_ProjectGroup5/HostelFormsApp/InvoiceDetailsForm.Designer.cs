
namespace HostelFormsApp
{
    partial class InvoiceDetailsForm
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtServiceCharge = new System.Windows.Forms.TextBox();
            this.lbServiceCharge = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.txtRoomCharge = new System.Windows.Forms.TextBox();
            this.lbRoomCharge = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.txtInvoiceName = new System.Windows.Forms.TextBox();
            this.lbInvoiceName = new System.Windows.Forms.Label();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.lbInvoiceID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvInvoiceDetailsList = new System.Windows.Forms.DataGridView();
            this.txtStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetailsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(600, 80);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(75, 20);
            this.lbStatus.TabIndex = 160;
            this.lbStatus.Text = "Trạng thái";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(662, 35);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(125, 27);
            this.txtNote.TabIndex = 159;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(600, 38);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(58, 20);
            this.lbNote.TabIndex = 158;
            this.lbNote.Text = "Ghi chú";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.CustomFormat = "dd/MM/yyy HH:mm:ss";
            this.txtCreateDate.Enabled = false;
            this.txtCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtCreateDate.Location = new System.Drawing.Point(427, 168);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(185, 27);
            this.txtCreateDate.TabIndex = 157;
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(308, 170);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(84, 20);
            this.lbCreateDate.TabIndex = 156;
            this.lbCreateDate.Text = "CreateDate";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(427, 122);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(125, 27);
            this.txtTotal.TabIndex = 155;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(308, 122);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(43, 20);
            this.lbTotal.TabIndex = 154;
            this.lbTotal.Text = "Tổng";
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.Location = new System.Drawing.Point(427, 80);
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.ReadOnly = true;
            this.txtServiceCharge.Size = new System.Drawing.Size(125, 27);
            this.txtServiceCharge.TabIndex = 153;
            // 
            // lbServiceCharge
            // 
            this.lbServiceCharge.AutoSize = true;
            this.lbServiceCharge.Location = new System.Drawing.Point(308, 80);
            this.lbServiceCharge.Name = "lbServiceCharge";
            this.lbServiceCharge.Size = new System.Drawing.Size(88, 20);
            this.lbServiceCharge.TabIndex = 152;
            this.lbServiceCharge.Text = "Tiền dịch vụ";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(149, 80);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.ReadOnly = true;
            this.txtRoomID.Size = new System.Drawing.Size(125, 27);
            this.txtRoomID.TabIndex = 151;
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Location = new System.Drawing.Point(22, 83);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(64, 20);
            this.lbRoomID.TabIndex = 150;
            this.lbRoomID.Text = "RoomID";
            // 
            // txtRoomCharge
            // 
            this.txtRoomCharge.Location = new System.Drawing.Point(149, 170);
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.ReadOnly = true;
            this.txtRoomCharge.Size = new System.Drawing.Size(125, 27);
            this.txtRoomCharge.TabIndex = 149;
            // 
            // lbRoomCharge
            // 
            this.lbRoomCharge.AutoSize = true;
            this.lbRoomCharge.Location = new System.Drawing.Point(22, 173);
            this.lbRoomCharge.Name = "lbRoomCharge";
            this.lbRoomCharge.Size = new System.Drawing.Size(84, 20);
            this.lbRoomCharge.TabIndex = 148;
            this.lbRoomCharge.Text = "Tiền phòng";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(149, 122);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(125, 27);
            this.txtCustomerID.TabIndex = 147;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(22, 125);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(87, 20);
            this.lbCustomerID.TabIndex = 146;
            this.lbCustomerID.Text = "CustomerID";
            // 
            // txtInvoiceName
            // 
            this.txtInvoiceName.Location = new System.Drawing.Point(427, 39);
            this.txtInvoiceName.Name = "txtInvoiceName";
            this.txtInvoiceName.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceName.TabIndex = 145;
            // 
            // lbInvoiceName
            // 
            this.lbInvoiceName.AutoSize = true;
            this.lbInvoiceName.Location = new System.Drawing.Point(308, 38);
            this.lbInvoiceName.Name = "lbInvoiceName";
            this.lbInvoiceName.Size = new System.Drawing.Size(91, 20);
            this.lbInvoiceName.TabIndex = 144;
            this.lbInvoiceName.Text = "Tên hoá đơn";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(149, 38);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.ReadOnly = true;
            this.txtInvoiceID.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceID.TabIndex = 143;
            // 
            // lbInvoiceID
            // 
            this.lbInvoiceID.AutoSize = true;
            this.lbInvoiceID.Location = new System.Drawing.Point(22, 42);
            this.lbInvoiceID.Name = "lbInvoiceID";
            this.lbInvoiceID.Size = new System.Drawing.Size(24, 20);
            this.lbInvoiceID.TabIndex = 142;
            this.lbInvoiceID.Text = "ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(834, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 163;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(834, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 162;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvInvoiceDetailsList
            // 
            this.dgvInvoiceDetailsList.AllowUserToAddRows = false;
            this.dgvInvoiceDetailsList.AllowUserToDeleteRows = false;
            this.dgvInvoiceDetailsList.AllowUserToOrderColumns = true;
            this.dgvInvoiceDetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceDetailsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInvoiceDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetailsList.Location = new System.Drawing.Point(22, 232);
            this.dgvInvoiceDetailsList.Name = "dgvInvoiceDetailsList";
            this.dgvInvoiceDetailsList.ReadOnly = true;
            this.dgvInvoiceDetailsList.RowHeadersWidth = 51;
            this.dgvInvoiceDetailsList.RowTemplate.Height = 29;
            this.dgvInvoiceDetailsList.Size = new System.Drawing.Size(983, 375);
            this.dgvInvoiceDetailsList.TabIndex = 164;
            this.dgvInvoiceDetailsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceDetailsList_CellContentClick);
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(681, 79);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(125, 24);
            this.txtStatus.TabIndex = 165;
            this.txtStatus.Text = "Đã thanh toán";
            this.txtStatus.UseVisualStyleBackColor = true;
            this.txtStatus.CheckedChanged += new System.EventHandler(this.txtStatus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 166;
            this.label1.Text = "Danh sách dịch vụ sử dụng";
            // 
            // InvoiceDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.dgvInvoiceDetailsList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.txtServiceCharge);
            this.Controls.Add(this.lbServiceCharge);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.txtRoomCharge);
            this.Controls.Add(this.lbRoomCharge);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lbCustomerID);
            this.Controls.Add(this.txtInvoiceName);
            this.Controls.Add(this.lbInvoiceName);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.lbInvoiceID);
            this.Name = "InvoiceDetailsForm";
            this.Text = "InvoiceDetailsForm";
            this.Load += new System.EventHandler(this.InvoiceDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetailsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.DateTimePicker txtCreateDate;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtServiceCharge;
        private System.Windows.Forms.Label lbServiceCharge;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.TextBox txtRoomCharge;
        private System.Windows.Forms.Label lbRoomCharge;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.TextBox txtInvoiceName;
        private System.Windows.Forms.Label lbInvoiceName;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label lbInvoiceID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvInvoiceDetailsList;
        private System.Windows.Forms.CheckBox txtStatus;
        private System.Windows.Forms.Label label1;
    }
}