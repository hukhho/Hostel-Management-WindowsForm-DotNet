
namespace HostelFormsApp
{
    partial class CallBillForm
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
            this.txtInvoiceName = new System.Windows.Forms.TextBox();
            this.lbInvoiceName = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.checkListUsed = new System.Windows.Forms.CheckedListBox();
            this.txtRoomCharge = new System.Windows.Forms.TextBox();
            this.lbRoomCharge = new System.Windows.Forms.Label();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.btnCallBill = new System.Windows.Forms.Button();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSelectAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtInvoiceName
            // 
            this.txtInvoiceName.Location = new System.Drawing.Point(168, 53);
            this.txtInvoiceName.Name = "txtInvoiceName";
            this.txtInvoiceName.Size = new System.Drawing.Size(125, 27);
            this.txtInvoiceName.TabIndex = 147;
            // 
            // lbInvoiceName
            // 
            this.lbInvoiceName.AutoSize = true;
            this.lbInvoiceName.Location = new System.Drawing.Point(49, 52);
            this.lbInvoiceName.Name = "lbInvoiceName";
            this.lbInvoiceName.Size = new System.Drawing.Size(91, 20);
            this.lbInvoiceName.TabIndex = 146;
            this.lbInvoiceName.Text = "Tên hoá đơn";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(168, 231);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(125, 27);
            this.txtNote.TabIndex = 163;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(49, 231);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(58, 20);
            this.lbNote.TabIndex = 162;
            this.lbNote.Text = "Ghi chú";
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Location = new System.Drawing.Point(49, 93);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(51, 20);
            this.lbRoomID.TabIndex = 166;
            this.lbRoomID.Text = "Phòng";
            // 
            // checkListUsed
            // 
            this.checkListUsed.FormattingEnabled = true;
            this.checkListUsed.Location = new System.Drawing.Point(49, 303);
            this.checkListUsed.Name = "checkListUsed";
            this.checkListUsed.Size = new System.Drawing.Size(376, 114);
            this.checkListUsed.TabIndex = 170;
            this.checkListUsed.SelectedIndexChanged += new System.EventHandler(this.checkListUsed_SelectedIndexChanged);
            // 
            // txtRoomCharge
            // 
            this.txtRoomCharge.Location = new System.Drawing.Point(168, 187);
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.Size = new System.Drawing.Size(125, 27);
            this.txtRoomCharge.TabIndex = 172;
            // 
            // lbRoomCharge
            // 
            this.lbRoomCharge.AutoSize = true;
            this.lbRoomCharge.Location = new System.Drawing.Point(49, 187);
            this.lbRoomCharge.Name = "lbRoomCharge";
            this.lbRoomCharge.Size = new System.Drawing.Size(84, 20);
            this.lbRoomCharge.TabIndex = 171;
            this.lbRoomCharge.Text = "Tiền phòng";
            // 
            // comboRoom
            // 
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(168, 93);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(125, 28);
            this.comboRoom.TabIndex = 173;
            this.comboRoom.SelectedIndexChanged += new System.EventHandler(this.comboRoom_SelectedIndexChanged);
            // 
            // btnCallBill
            // 
            this.btnCallBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCallBill.Location = new System.Drawing.Point(374, 52);
            this.btnCallBill.Name = "btnCallBill";
            this.btnCallBill.Size = new System.Drawing.Size(94, 29);
            this.btnCallBill.TabIndex = 174;
            this.btnCallBill.Text = "Tính tiền";
            this.btnCallBill.UseVisualStyleBackColor = true;
            this.btnCallBill.Click += new System.EventHandler(this.btnCallBill_Click);
            // 
            // comboCustomer
            // 
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(168, 136);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(190, 28);
            this.comboCustomer.TabIndex = 176;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(49, 136);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(86, 20);
            this.lbCustomerID.TabIndex = 175;
            this.lbCustomerID.Text = "Khách hàng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(374, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 32);
            this.btnExit.TabIndex = 177;
            this.btnExit.Text = "Huỷ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSelectAll
            // 
            this.txtSelectAll.AutoSize = true;
            this.txtSelectAll.Location = new System.Drawing.Point(49, 267);
            this.txtSelectAll.Name = "txtSelectAll";
            this.txtSelectAll.Size = new System.Drawing.Size(71, 24);
            this.txtSelectAll.TabIndex = 178;
            this.txtSelectAll.Text = "Tất cả";
            this.txtSelectAll.UseVisualStyleBackColor = true;
            this.txtSelectAll.CheckedChanged += new System.EventHandler(this.txtSelectAll_CheckedChanged);
            // 
            // CallBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.txtSelectAll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboCustomer);
            this.Controls.Add(this.lbCustomerID);
            this.Controls.Add(this.btnCallBill);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.txtRoomCharge);
            this.Controls.Add(this.lbRoomCharge);
            this.Controls.Add(this.checkListUsed);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.txtInvoiceName);
            this.Controls.Add(this.lbInvoiceName);
            this.Name = "CallBillForm";
            this.Text = "Xuất hoá đơn";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.CallBillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoiceName;
        private System.Windows.Forms.Label lbInvoiceName;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.CheckedListBox checkListUsed;
        private System.Windows.Forms.TextBox txtRoomCharge;
        private System.Windows.Forms.Label lbRoomCharge;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.Button btnCallBill;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox txtSelectAll;
    }
}