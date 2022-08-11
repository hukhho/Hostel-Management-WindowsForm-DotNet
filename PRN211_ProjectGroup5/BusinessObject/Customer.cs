using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BusinessObject
{
    public partial class Customer
    {
        public Customer()
        {
            Contracts = new HashSet<Contract>();
            Invoices = new HashSet<Invoice>();
        }
        [DisplayName("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [DisplayName("Giới tính")]
        public string Gender { get; set; }
        [DisplayName("Tên")]
        public string CustomerName { get; set; }
        [DisplayName("Ngày sinh")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime? Dob { get; set; }
        [DisplayName("SĐT")]
        public string PhoneNumber { get; set; }
        [DisplayName("Số cmnd")]
        public string DocumentId { get; set; }

        [DisplayName("Tên phòng")]
        public string RoomName
        {
            get => Room?.RoomName;
        }

        [DisplayName("ID Phòng")]
        public int? RoomId { get; set; }
        [DisplayName("Đang thuê")]
        public bool IsRenting { get; set; }

        [Browsable(false)]
        public virtual Room Room { get; set; }
        [Browsable(false)]
        public virtual ICollection<Contract> Contracts { get; set; }
        [Browsable(false)]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
