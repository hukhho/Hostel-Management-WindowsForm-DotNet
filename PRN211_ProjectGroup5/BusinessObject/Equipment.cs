using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BusinessObject
{
    public partial class Equipment
    {
        [DisplayName("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EquipmentId { get; set; }
        [DisplayName("Tên thiết bị")]
        public string Name { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
        [DisplayName("Giá")]
        public double? Price { get; set; }
        [DisplayName("Id Phòng")]
        public int RoomId { get; set; }
        [DisplayName("Tên phòng")]
        public string RoomName
        {
            get => Room?.RoomName;
        }
        [DisplayName("Trạng thái")]
        public string RoomStatusDisplay
        {
            get => Status == 0 ? "Không hoạt động" : "Hoạt động";
        }
     
        public int Status { get; set; }
        [Browsable(false)]
        public virtual Room Room { get; set; }
    }
}
