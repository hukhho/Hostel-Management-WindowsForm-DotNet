
namespace HostelFormsApp
{
    partial class CustomerDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.txtDocumentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbDocumentID = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.isRenting = new System.Windows.Forms.CheckBox();
            this.rdGender1 = new System.Windows.Forms.RadioButton();
            this.rdGender2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Trạng thái thuê";
            // 
            // txtDOB
            // 
            this.txtDOB.CustomFormat = "dd/MM/yyyy";
            this.txtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDOB.Location = new System.Drawing.Point(178, 180);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(125, 27);
            this.txtDOB.TabIndex = 78;
            // 
            // txtDocumentID
            // 
            this.txtDocumentID.Location = new System.Drawing.Point(178, 223);
            this.txtDocumentID.Name = "txtDocumentID";
            this.txtDocumentID.Size = new System.Drawing.Size(125, 27);
            this.txtDocumentID.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "CMND";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(178, 265);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(125, 27);
            this.txtPhoneNumber.TabIndex = 75;
            // 
            // lbDocumentID
            // 
            this.lbDocumentID.AutoSize = true;
            this.lbDocumentID.Location = new System.Drawing.Point(51, 265);
            this.lbDocumentID.Name = "lbDocumentID";
            this.lbDocumentID.Size = new System.Drawing.Size(97, 20);
            this.lbDocumentID.TabIndex = 74;
            this.lbDocumentID.Text = "Số điện thoại";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Location = new System.Drawing.Point(51, 180);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(74, 20);
            this.lbDOB.TabIndex = 73;
            this.lbDOB.Text = "Ngày sinh";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(178, 135);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(172, 27);
            this.txtCustomerName.TabIndex = 72;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(51, 135);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(32, 20);
            this.lbCustomerName.TabIndex = 71;
            this.lbCustomerName.Text = "Tên";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(51, 89);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(65, 20);
            this.lbGender.TabIndex = 69;
            this.lbGender.Text = "Giới tính";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(178, 46);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(125, 27);
            this.txtCustomerID.TabIndex = 68;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(51, 46);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(24, 20);
            this.lbCustomerID.TabIndex = 67;
            this.lbCustomerID.Text = "ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 82;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Location = new System.Drawing.Point(51, 351);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(51, 20);
            this.lbRoomID.TabIndex = 83;
            this.lbRoomID.Text = "Phòng";
            // 
            // comboRoom
            // 
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(178, 351);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(125, 28);
            this.comboRoom.TabIndex = 130;
            // 
            // isRenting
            // 
            this.isRenting.AutoSize = true;
            this.isRenting.Location = new System.Drawing.Point(178, 308);
            this.isRenting.Name = "isRenting";
            this.isRenting.Size = new System.Drawing.Size(100, 24);
            this.isRenting.TabIndex = 131;
            this.isRenting.Text = "Đang thuê";
            this.isRenting.UseVisualStyleBackColor = true;
            this.isRenting.CheckedChanged += new System.EventHandler(this.isRenting_CheckedChanged);
            // 
            // rdGender1
            // 
            this.rdGender1.AutoSize = true;
            this.rdGender1.Location = new System.Drawing.Point(178, 89);
            this.rdGender1.Name = "rdGender1";
            this.rdGender1.Size = new System.Drawing.Size(62, 24);
            this.rdGender1.TabIndex = 132;
            this.rdGender1.TabStop = true;
            this.rdGender1.Text = "Nam";
            this.rdGender1.UseVisualStyleBackColor = true;
            this.rdGender1.CheckedChanged += new System.EventHandler(this.rdGender1_CheckedChanged);
            // 
            // rdGender2
            // 
            this.rdGender2.AutoSize = true;
            this.rdGender2.Location = new System.Drawing.Point(247, 89);
            this.rdGender2.Name = "rdGender2";
            this.rdGender2.Size = new System.Drawing.Size(50, 24);
            this.rdGender2.TabIndex = 133;
            this.rdGender2.TabStop = true;
            this.rdGender2.Text = "Nữ";
            this.rdGender2.UseVisualStyleBackColor = true;
            this.rdGender2.CheckedChanged += new System.EventHandler(this.rdGender2_CheckedChanged);
            // 
            // CustomerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 461);
            this.Controls.Add(this.rdGender2);
            this.Controls.Add(this.rdGender1);
            this.Controls.Add(this.isRenting);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtDocumentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lbDocumentID);
            this.Controls.Add(this.lbDOB);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lbCustomerID);
            this.Name = "CustomerDetailsForm";
            this.Text = "Chi tiết khách hàng";
            this.Load += new System.EventHandler(this.CustomerDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDOB;
        private System.Windows.Forms.TextBox txtDocumentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lbDocumentID;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.CheckBox isRenting;
        private System.Windows.Forms.RadioButton rdGender1;
        private System.Windows.Forms.RadioButton rdGender2;
    }
}