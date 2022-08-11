using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BusinessObject
{
    public partial class UsedService
    {
        [DisplayName("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsedServiceId { get; set; }
        public int ServiceId { get; set; }
        public int RoomId { get; set; }
       
        [DisplayName("Tên phòng")]
        public string RoomName
        {
            get => Room?.RoomName;
        }
        [DisplayName("Tên dịch vụ")]
        public string ServiceName
        {
            get => Service?.ServiceName;
        }
        [DisplayName("Giá")]
        public double Price { get; set; }
        [DisplayName("Số lượng sử dụng")]
        public int Quantity { get; set; }

        [DisplayName("Tổng")]
        public double TotalMoney
        {
            get => Price*Quantity;
        }

        [DisplayName("Mã hoá đơn")]
        public int? InvoiceId { get; set; }
        [DisplayName("Tên hoá đơn")]
        public string InvoiceName
        {
            get => Invoice?.InvoiceName == null ? "[Chưa hoá đơn]" : Invoice.InvoiceName;
        }
        [Browsable(false)]
        public virtual Invoice Invoice { get; set; }
        [Browsable(false)]
        public virtual Room Room { get; set; }
        [Browsable(false)]
        public virtual Service Service { get; set; }
    }
}
