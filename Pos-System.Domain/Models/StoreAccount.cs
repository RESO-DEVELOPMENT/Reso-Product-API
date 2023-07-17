using System;
using System.Collections.Generic;

namespace Pos_System.Domain.Models
{
    public partial class StoreAccount
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public Guid AccountId { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
    }
}
