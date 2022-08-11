
namespace HostelFormsApp
{
    partial class ServiceForm
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbServiceName = new System.Windows.Forms.Label();
            this.lbServiceID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbRoomList = new System.Windows.Forms.Label();
            this.dgvServiceList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(457, 134);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 27);
            this.txtPrice.TabIndex = 84;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(182, 179);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(125, 27);
            this.txtServiceName.TabIndex = 83;
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(182, 134);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(125, 27);
            this.txtServiceID.TabIndex = 82;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(349, 134);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 20);
            this.lbPrice.TabIndex = 81;
            this.lbPrice.Text = "Giá";
            // 
            // lbServiceName
            // 
            this.lbServiceName.AutoSize = true;
            this.lbServiceName.Location = new System.Drawing.Point(31, 179);
            this.lbServiceName.Name = "lbServiceName";
            this.lbServiceName.Size = new System.Drawing.Size(83, 20);
            this.lbServiceName.TabIndex = 80;
            this.lbServiceName.Text = "Tên dịch vụ";
            // 
            // lbServiceID
            // 
            this.lbServiceID.AutoSize = true;
            this.lbServiceID.Location = new System.Drawing.Point(31, 137);
            this.lbServiceID.Name = "lbServiceID";
            this.lbServiceID.Size = new System.Drawing.Size(24, 20);
            this.lbServiceID.TabIndex = 79;
            this.lbServiceID.Text = "ID";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(599, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 32);
            this.btnExit.TabIndex = 78;
            this.btnExit.Text = "Sửa";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(599, 419);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 35);
            this.btnDelete.TabIndex = 77;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(599, 358);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 38);
            this.btnNew.TabIndex = 76;
            this.btnNew.Text = "Thêm";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(599, 293);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 36);
            this.btnLoad.TabIndex = 75;
            this.btnLoad.Text = "Tải lại";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbRoomList
            // 
            this.lbRoomList.AutoSize = true;
            this.lbRoomList.Location = new System.Drawing.Point(31, 235);
            this.lbRoomList.Name = "lbRoomList";
            this.lbRoomList.Size = new System.Drawing.Size(128, 20);
            this.lbRoomList.TabIndex = 74;
            this.lbRoomList.Text = "Danh sách dịch vụ";
            // 
            // dgvServiceList
            // 
            this.dgvServiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceList.Location = new System.Drawing.Point(31, 258);
            this.dgvServiceList.Name = "dgvServiceList";
            this.dgvServiceList.ReadOnly = true;
            this.dgvServiceList.RowHeadersWidth = 51;
            this.dgvServiceList.RowTemplate.Height = 29;
            this.dgvServiceList.Size = new System.Drawing.Size(536, 280);
            this.dgvServiceList.TabIndex = 73;
            this.dgvServiceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceList_CellContentClick);
            this.dgvServiceList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceList_CellContentDoubleClick);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 557);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbServiceName);
            this.Controls.Add(this.lbServiceID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbRoomList);
            this.Controls.Add(this.dgvServiceList);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbServiceName;
        private System.Windows.Forms.Label lbServiceID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbRoomList;
        private System.Windows.Forms.DataGridView dgvServiceList;
    }
}