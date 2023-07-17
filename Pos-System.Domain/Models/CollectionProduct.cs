using System;
using System.Collections.Generic;

namespace Pos_System.Domain.Models
{
    public partial class CollectionProduct
    {
        public Guid Id { get; set; }
        public Guid CollectionId { get; set; }
        public Guid ProductId { get; set; }
        public string Status { get; set; } = null!;

        public virtual Collection Collection { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
