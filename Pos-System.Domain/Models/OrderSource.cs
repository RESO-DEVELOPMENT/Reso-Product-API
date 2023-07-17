using System;
using System.Collections.Generic;

namespace Pos_System.Domain.Models
{
    public partial class OrderSource
    {
        public OrderSource()
        {
            Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Url { get; set; }
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? PicUrl { get; set; }
        public Guid BrandId { get; set; }

        public virtual Brand Brand { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
