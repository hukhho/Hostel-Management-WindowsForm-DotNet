using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BusinessObject
{
    public partial class Invoice
    {
        public Invoice()
        {
            UsedServices = new HashSet<UsedService>();
        }
        [DisplayName("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }
        [DisplayName("Tên hoá đơn")]
        public string InvoiceName { get; set; }
        public int RoomId { get; set; }

        [DisplayName("Tên phòng")]
        public string RoomName
        {
            get => Room?.RoomName;
        }
        public int CustomerId { get; set; }
        [DisplayName("Tên khách hàng")]
        public string CustomerName
        {
            get => Customer?.CustomerName;
        }
        [DisplayName("Tiền phòng")]
        public double RoomCharge { get; set; }
        [DisplayName("Tiền dịch vụ")]
        public double ServiceCharge { get; set; }
        [DisplayName("Tổng")]
        public double Total { get; set; }

        [DisplayName("Ngày tạo")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm:ss")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CreateDate { get; set; }
        [DisplayName("Ghi chú")]
        public string Note { get; set; }
        public int Status { get; set; }

        [DisplayName("Trạng thái")]
        public string PaymentStatus
        {
            get => Status == 0 ? "Chưa" : "Đã thanh toán";
        }
        [Browsable(false)]
        public virtual Customer Customer { get; set; }
        [Browsable(false)]

        public virtual Room Room { get; set; }
        [Browsable(false)]

        public virtual ICollection<UsedService> UsedServices { get; set; }
    }
}
