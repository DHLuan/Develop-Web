using System;
using System.Collections.Generic;

#nullable disable

namespace demo1.Models
{
    public partial class Product
    {
        public Product()
        {
            OderDetails = new HashSet<OderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public string ImageUrl { get; set; }
        public int? Quantity { get; set; }
        public int? PromotionPrice { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OderDetail> OderDetails { get; set; }
    }
}
