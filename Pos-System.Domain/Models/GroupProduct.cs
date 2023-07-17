using System;
using System.Collections.Generic;

namespace Pos_System.Domain.Models
{
    public partial class GroupProduct
    {
        public GroupProduct()
        {
            ProductInGroups = new HashSet<ProductInGroup>();
        }

        public Guid Id { get; set; }
        public Guid? ComboProductId { get; set; }
        public string Name { get; set; } = null!;
        public string CombinationMode { get; set; } = null!;
        public int Priority { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; } = null!;

        public virtual Product? ComboProduct { get; set; }
        public virtual ICollection<ProductInGroup> ProductInGroups { get; set; }
    }
}
