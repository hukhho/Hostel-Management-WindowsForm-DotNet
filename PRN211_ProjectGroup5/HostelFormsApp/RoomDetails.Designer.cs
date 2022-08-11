
namespace HostelFormsApp
{
    partial class RoomDetails
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
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.isActiveRoom = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(43, 185);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(75, 20);
            this.lbStatus.TabIndex = 69;
            this.lbStatus.Text = "Trạng thái";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(151, 140);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(125, 27);
            this.txtRoomName.TabIndex = 68;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(151, 95);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 27);
            this.txtPrice.TabIndex = 67;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(151, 50);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(125, 27);
            this.txtRoomID.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tên phòng";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(43, 92);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 20);
            this.lbPrice.TabIndex = 64;
            this.lbPrice.Text = "Giá";
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Location = new System.Drawing.Point(43, 50);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(24, 20);
            this.lbRoomID.TabIndex = 63;
            this.lbRoomID.Text = "ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(182, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // isActiveRoom
            // 
            this.isActiveRoom.AutoSize = true;
            this.isActiveRoom.Location = new System.Drawing.Point(151, 185);
            this.isActiveRoom.Name = "isActiveRoom";
            this.isActiveRoom.Size = new System.Drawing.Size(103, 24);
            this.isActiveRoom.TabIndex = 132;
            this.isActiveRoom.Text = "Hoạt động";
            this.isActiveRoom.UseVisualStyleBackColor = true;
            this.isActiveRoom.CheckedChanged += new System.EventHandler(this.isActiveRoom_CheckedChanged);
            // 
            // RoomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 362);
            this.Controls.Add(this.isActiveRoom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbRoomID);
            this.Name = "RoomDetails";
            this.Text = "Chi tiết Phòng";
            this.Load += new System.EventHandler(this.RoomDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox isActiveRoom;
    }
}