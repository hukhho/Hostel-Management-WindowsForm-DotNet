
namespace HostelFormsApp
{
    partial class UsedServiceDetailForm
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
            this.lbInvoiceID = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUsedServiceID = new System.Windows.Forms.TextBox();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbUsedServiceID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbServiceID = new System.Windows.Forms.Label();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbInvoiceID
            // 
            this.lbInvoiceID.AutoSize = true;
            this.lbInvoiceID.Location = new System.Drawing.Point(45, 236);
            this.lbInvoiceID.Name = "lbInvoiceID";
            this.lbInvoiceID.Size = new System.Drawing.Size(0, 20);
            this.lbInvoiceID.TabIndex = 97;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(164, 198);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 27);
            this.txtQuantity.TabIndex = 96;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(45, 198);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(69, 20);
            this.lbQuantity.TabIndex = 95;
            this.lbQuantity.Text = "Số lượng";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(164, 115);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 27);
            this.txtPrice.TabIndex = 93;
            // 
            // txtUsedServiceID
            // 
            this.txtUsedServiceID.Location = new System.Drawing.Point(164, 40);
            this.txtUsedServiceID.Name = "txtUsedServiceID";
            this.txtUsedServiceID.Size = new System.Drawing.Size(125, 27);
            this.txtUsedServiceID.TabIndex = 92;
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Location = new System.Drawing.Point(45, 153);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(51, 20);
            this.lbRoomID.TabIndex = 91;
            this.lbRoomID.Text = "Phòng";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(45, 115);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 20);
            this.lbPrice.TabIndex = 90;
            this.lbPrice.Text = "Giá";
            // 
            // lbUsedServiceID
            // 
            this.lbUsedServiceID.AutoSize = true;
            this.lbUsedServiceID.Location = new System.Drawing.Point(45, 43);
            this.lbUsedServiceID.Name = "lbUsedServiceID";
            this.lbUsedServiceID.Size = new System.Drawing.Size(24, 20);
            this.lbUsedServiceID.TabIndex = 89;
            this.lbUsedServiceID.Text = "ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 100;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(45, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbServiceID
            // 
            this.lbServiceID.AutoSize = true;
            this.lbServiceID.Location = new System.Drawing.Point(45, 78);
            this.lbServiceID.Name = "lbServiceID";
            this.lbServiceID.Size = new System.Drawing.Size(58, 20);
            this.lbServiceID.TabIndex = 101;
            this.lbServiceID.Text = "Dịch vụ";
            // 
            // comboRoom
            // 
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(164, 153);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(125, 28);
            this.comboRoom.TabIndex = 130;
            // 
            // comboService
            // 
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(164, 78);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(125, 28);
            this.comboService.TabIndex = 131;
            this.comboService.SelectedIndexChanged += new System.EventHandler(this.comboService_SelectedIndexChanged);
            // 
            // UsedServiceDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 370);
            this.Controls.Add(this.comboService);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.lbServiceID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbInvoiceID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtUsedServiceID);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbUsedServiceID);
            this.Name = "UsedServiceDetailForm";
            this.Text = "UsedServiceDetailForm";
            this.Load += new System.EventHandler(this.UsedServiceDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbInvoiceID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUsedServiceID;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbUsedServiceID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbServiceID;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.ComboBox comboService;
    }
}