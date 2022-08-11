
namespace HostelFormsApp
{
    partial class UsedServiceForm
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUsedServiceID = new System.Windows.Forms.TextBox();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbUsedServiceID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbUsed = new System.Windows.Forms.Label();
            this.dgvUsedServiceList = new System.Windows.Forms.DataGridView();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.lbInvoiceID = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lbServiceID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsedServiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(472, 92);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 27);
            this.txtQuantity.TabIndex = 86;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(364, 92);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 20);
            this.lbQuantity.TabIndex = 85;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(472, 47);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.ReadOnly = true;
            this.txtRoomID.Size = new System.Drawing.Size(125, 27);
            this.txtRoomID.TabIndex = 84;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(197, 92);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 27);
            this.txtPrice.TabIndex = 83;
            // 
            // txtUsedServiceID
            // 
            this.txtUsedServiceID.Location = new System.Drawing.Point(197, 47);
            this.txtUsedServiceID.Name = "txtUsedServiceID";
            this.txtUsedServiceID.ReadOnly = true;
            this.txtUsedServiceID.Size = new System.Drawing.Size(125, 27);
            this.txtUsedServiceID.TabIndex = 82;
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Location = new System.Drawing.Point(364, 47);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(64, 20);
            this.lbRoomID.TabIndex = 81;
            this.lbRoomID.Text = "RoomID";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(46, 92);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 20);
            this.lbPrice.TabIndex = 80;
            this.lbPrice.Text = "Price";
            // 
            // lbUsedServiceID
            // 
            this.lbUsedServiceID.AutoSize = true;
            this.lbUsedServiceID.Location = new System.Drawing.Point(46, 50);
            this.lbUsedServiceID.Name = "lbUsedServiceID";
            this.lbUsedServiceID.Size = new System.Drawing.Size(24, 20);
            this.lbUsedServiceID.TabIndex = 79;
            this.lbUsedServiceID.Text = "ID";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1056, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 78;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1056, 368);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 32);
            this.btnDelete.TabIndex = 77;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1056, 308);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 34);
            this.btnNew.TabIndex = 76;
            this.btnNew.Text = "Thêm";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1056, 243);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 33);
            this.btnLoad.TabIndex = 75;
            this.btnLoad.Text = "Tải lại";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbUsed
            // 
            this.lbUsed.AutoSize = true;
            this.lbUsed.Location = new System.Drawing.Point(12, 186);
            this.lbUsed.Name = "lbUsed";
            this.lbUsed.Size = new System.Drawing.Size(185, 20);
            this.lbUsed.TabIndex = 74;
            this.lbUsed.Text = "Danh sách dịch vụ sử dụng";
            // 
            // dgvUsedServiceList
            // 
            this.dgvUsedServiceList.AllowUserToAddRows = false;
            this.dgvUsedServiceList.AllowUserToDeleteRows = false;
            this.dgvUsedServiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsedServiceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUsedServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsedServiceList.Location = new System.Drawing.Point(12, 222);
            this.dgvUsedServiceList.MultiSelect = false;
            this.dgvUsedServiceList.Name = "dgvUsedServiceList";
            this.dgvUsedServiceList.ReadOnly = true;
            this.dgvUsedServiceList.RowHeadersWidth = 51;
            this.dgvUsedServiceList.RowTemplate.Height = 29;
            this.dgvUsedServiceList.Size = new System.Drawing.Size(1024, 297);
            this.dgvUsedServiceList.TabIndex = 73;
            this.dgvUsedServiceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsedServiceList_CellContentClick);
            this.dgvUsedServiceList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsedServiceList_CellContentDoubleClick);
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(197, 137);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.ReadOnly = true;
            this.txtInvoiceID.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceID.TabIndex = 88;
            // 
            // lbInvoiceID
            // 
            this.lbInvoiceID.AutoSize = true;
            this.lbInvoiceID.Location = new System.Drawing.Point(46, 137);
            this.lbInvoiceID.Name = "lbInvoiceID";
            this.lbInvoiceID.Size = new System.Drawing.Size(71, 20);
            this.lbInvoiceID.TabIndex = 87;
            this.lbInvoiceID.Text = "InvoiceID";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(472, 137);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(125, 27);
            this.txtServiceID.TabIndex = 90;
            // 
            // lbServiceID
            // 
            this.lbServiceID.AutoSize = true;
            this.lbServiceID.Location = new System.Drawing.Point(364, 140);
            this.lbServiceID.Name = "lbServiceID";
            this.lbServiceID.Size = new System.Drawing.Size(71, 20);
            this.lbServiceID.TabIndex = 89;
            this.lbServiceID.Text = "ServiceID";
            // 
            // UsedServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 531);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.lbServiceID);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.lbInvoiceID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtUsedServiceID);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbUsedServiceID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbUsed);
            this.Controls.Add(this.dgvUsedServiceList);
            this.Name = "UsedServiceForm";
            this.Text = "UsedServiceForm";
            this.Load += new System.EventHandler(this.UsedServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsedServiceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUsedServiceID;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbUsedServiceID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbUsed;
        private System.Windows.Forms.DataGridView dgvUsedServiceList;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label lbInvoiceID;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lbServiceID;
    }
}