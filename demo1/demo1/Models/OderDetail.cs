using System;
using System.Collections.Generic;

#nullable disable

namespace demo1.Models
{
    public partial class OderDetail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public int OderId { get; set; }
        public int? Price { get; set; }

        public virtual Order Oder { get; set; }
        public virtual Product Product { get; set; }
    }
}
