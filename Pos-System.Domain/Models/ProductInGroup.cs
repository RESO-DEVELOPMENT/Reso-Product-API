using System;
using System.Collections.Generic;

namespace Pos_System.Domain.Models
{
    public partial class ProductInGroup
    {
        public Guid Id { get; set; }
        public Guid GroupProductId { get; set; }
        public Guid ProductId { get; set; }
        public int Priority { get; set; }
        public double AdditionalPrice { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; } = null!;

        public virtual GroupProduct GroupProduct { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
