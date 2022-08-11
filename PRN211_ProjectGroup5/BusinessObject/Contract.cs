using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BusinessObject
{
    public partial class Contract
    {
        [DisplayName("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContractId { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }

        [DisplayName("Tên phòng")]
        public string RoomName
        {
            get => Room?.RoomName;
        }
        [DisplayName("Tên khách hàng")]
        public string CustomerName
        {
            get => Customer?.CustomerName;
        }

        [DisplayName("Ngày bắt đầu")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime StartDate { get; set; }
        [DisplayName("Ngày kết thúc")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime EndDate { get; set; }
        [DisplayName("Tiền Cọc")]
        public int? DepositMoney { get; set; }
        [DisplayName("Trạng thái tiền cọc")]
        public string PaymentStatus
        {
            get => DepositMoneyStatus == 0 ? "Chưa" : "Đã thanh toán";
        }
        [DisplayName("Trạng thái")]
        public int? DepositMoneyStatus { get; set; }
        [Browsable(false)]
        public virtual Customer Customer { get; set; }
        [Browsable(false)]
        public virtual Room Room { get; set; }
    }
}
