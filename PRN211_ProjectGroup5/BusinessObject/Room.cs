using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BusinessObject
{
    public partial class Room
    {

        public Room()
        {
            Contracts = new HashSet<Contract>();
            Customers = new HashSet<Customer>();
            Equipment = new HashSet<Equipment>();
            Invoices = new HashSet<Invoice>();
            UsedServices = new HashSet<UsedService>();
        }

        [DisplayName("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get; set; }
        [DisplayName("Giá")]
        public double Price { get; set; }
        [DisplayName("Tên Phòng")]
        public string RoomName { get; set; }
        public int RoomStatus { get; set; }

        [DisplayName("Trạng thái")]
        public string RoomStatusDisplay
        {
            get => RoomStatus == 0 ? "Không hoạt động" : "Hoạt động";
        }

        [Browsable(false)]
        public virtual ICollection<Contract> Contracts { get; set; }
        [Browsable(false)]
        public virtual ICollection<Customer> Customers { get; set; }
        [Browsable(false)]
        public virtual ICollection<Equipment> Equipment { get; set; }
        [Browsable(false)]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [Browsable(false)]
        public virtual ICollection<UsedService> UsedServices { get; set; }
       
    }
}
