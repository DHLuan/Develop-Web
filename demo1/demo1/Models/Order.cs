using System;
using System.Collections.Generic;

#nullable disable

namespace demo1.Models
{
    public partial class Order
    {
        public Order()
        {
            OderDetails = new HashSet<OderDetail>();
        }

        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Total { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPhone { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OderDetail> OderDetails { get; set; }
    }
}
