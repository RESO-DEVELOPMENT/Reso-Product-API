using System;
using System.Collections.Generic;

namespace Pos_System.Domain.Models
{
    public partial class BrandAccount
    {
        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public Guid AccountId { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Brand Brand { get; set; } = null!;
    }
}
