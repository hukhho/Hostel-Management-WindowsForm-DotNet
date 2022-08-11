using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BusinessObject
{
    public partial class Service
    {
        public Service()
        {
            UsedServices = new HashSet<UsedService>();
        }
        [DisplayName("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceId { get; set; }

        [DisplayName("Tên dịch vụ")]
        public string ServiceName { get; set; }

        [DisplayName("Giá")]
        public double Price { get; set; }

        [Browsable(false)]
        public virtual ICollection<UsedService> UsedServices { get; set; }
    }
}
