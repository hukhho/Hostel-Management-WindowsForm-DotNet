
namespace HostelFormsApp
{
    partial class InvoiceForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvInvoiceList = new System.Windows.Forms.DataGridView();
            this.txtServiceCharge = new System.Windows.Forms.TextBox();
            this.lbServiceCharge = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(177, 201);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.ReadOnly = true;
            this.txtRoomID.Size = new System.Drawing.Size(125, 27);
            this.txtRoomID.TabIndex = 131;
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Location = new System.Drawing.Point(50, 204);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(64, 20);
            this.lbRoomID.TabIndex = 130;
            this.lbRoomID.Text = "RoomID";
            // 
            // txtRoomCharge
            // 
            this.txtRoomCharge.Location = new System.Drawing.Point(455, 239);
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.ReadOnly = true;
            this.txtRoomCharge.Size = new System.Drawing.Size(125, 27);
            this.txtRoomCharge.TabIndex = 129;
            // 
            // lbRoomCharge
            // 
            this.lbRoomCharge.AutoSize = true;
            this.lbRoomCharge.Location = new System.Drawing.Point(336, 243);
            this.lbRoomCharge.Name = "lbRoomCharge";
            this.lbRoomCharge.Size = new System.Drawing.Size(84, 20);
            this.lbRoomCharge.TabIndex = 128;
            this.lbRoomCharge.Text = "Tiền phòng";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(177, 243);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(125, 27);
            this.txtCustomerID.TabIndex = 126;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(50, 246);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(87, 20);
            this.lbCustomerID.TabIndex = 125;
            this.lbCustomerID.Text = "CustomerID";
            // 
            // txtInvoiceName
            // 
            this.txtInvoiceName.Location = new System.Drawing.Point(455, 160);
            this.txtInvoiceName.Name = "txtInvoiceName";
            this.txtInvoiceName.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceName.TabIndex = 123;
            // 
            // lbInvoiceName
            // 
            this.lbInvoiceName.AutoSize = true;
            this.lbInvoiceName.Location = new System.Drawing.Point(336, 159);
            this.lbInvoiceName.Name = "lbInvoiceName";
            this.lbInvoiceName.Size = new System.Drawing.Size(91, 20);
            this.lbInvoiceName.TabIndex = 122;
            this.lbInvoiceName.Text = "Tên hoá đơn";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(177, 159);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.ReadOnly = true;
            this.txtInvoiceID.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceID.TabIndex = 119;
            // 
            // lbInvoiceID
            // 
            this.lbInvoiceID.AutoSize = true;
            this.lbInvoiceID.Location = new System.Drawing.Point(50, 163);
            this.lbInvoiceID.Name = "lbInvoiceID";
            this.lbInvoiceID.Size = new System.Drawing.Size(24, 20);
            this.lbInvoiceID.TabIndex = 118;
            this.lbInvoiceID.Text = "ID";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1063, 481);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 117;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1063, 423);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 116;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1063, 356);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 114;
            this.btnLoad.Text = "Tải lại";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvInvoiceList
            // 
            this.dgvInvoiceList.AllowUserToAddRows = false;
            this.dgvInvoiceList.AllowUserToDeleteRows = false;
            this.dgvInvoiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceList.Location = new System.Drawing.Point(40, 336);
            this.dgvInvoiceList.MultiSelect = false;
            this.dgvInvoiceList.Name = "dgvInvoiceList";
            this.dgvInvoiceList.ReadOnly = true;
            this.dgvInvoiceList.RowHeadersWidth = 51;
            this.dgvInvoiceList.RowTemplate.Height = 29;
            this.dgvInvoiceList.Size = new System.Drawing.Size(988, 300);
            this.dgvInvoiceList.TabIndex = 113;
            this.dgvInvoiceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceList_CellContentClick);
            this.dgvInvoiceList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceList_CellContentDoubleClick);
            this.dgvInvoiceList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceList_CellDoubleClick);
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.Location = new System.Drawing.Point(455, 201);
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.ReadOnly = true;
            this.txtServiceCharge.Size = new System.Drawing.Size(125, 27);
            this.txtServiceCharge.TabIndex = 133;
            // 
            // lbServiceCharge
            // 
            this.lbServiceCharge.AutoSize = true;
            this.lbServiceCharge.Location = new System.Drawing.Point(336, 201);
            this.lbServiceCharge.Name = "lbServiceCharge";
            this.lbServiceCharge.Size = new System.Drawing.Size(88, 20);
            this.lbServiceCharge.TabIndex = 132;
            this.lbServiceCharge.Text = "Tiền dịch vụ";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(455, 281);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(125, 27);
            this.txtTotal.TabIndex = 135;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(336, 281);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(43, 20);
            this.lbTotal.TabIndex = 134;
            this.lbTotal.Text = "Tổng";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(628, 246);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(70, 20);
            this.lbCreateDate.TabIndex = 136;
            this.lbCreateDate.Text = "Ngày tạo";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.CustomFormat = "dd/MM/yyy HH:mm:ss";
            this.txtCreateDate.Enabled = false;
            this.txtCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtCreateDate.Location = new System.Drawing.Point(709, 241);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(198, 27);
            this.txtCreateDate.TabIndex = 137;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(709, 156);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(125, 27);
            this.txtNote.TabIndex = 139;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(628, 159);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(58, 20);
            this.lbNote.TabIndex = 138;
            this.lbNote.Text = "Ghi chú";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(628, 201);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(75, 20);
            this.lbStatus.TabIndex = 140;
            this.lbStatus.Text = "Trạng thái";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(709, 197);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(106, 27);
            this.txtStatus.TabIndex = 141;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 648);
            this.Controls.Add(this.txtStatus);
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
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvInvoiceList);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvInvoiceList;
        private System.Windows.Forms.TextBox txtServiceCharge;
        private System.Windows.Forms.Label lbServiceCharge;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.DateTimePicker txtCreateDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtStatus;
    }
}