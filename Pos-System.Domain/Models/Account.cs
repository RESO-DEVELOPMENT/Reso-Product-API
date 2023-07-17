using System;
using System.Collections.Generic;

namespace Pos_System.Domain.Models
{
    public partial class Account
    {
        public Account()
        {
            Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Status { get; set; } = null!;
        public Guid RoleId { get; set; }
        public string Username { get; set; } = null!;

        public virtual Role Role { get; set; } = null!;
        public virtual BrandAccount? BrandAccount { get; set; }
        public virtual StoreAccount? StoreAccount { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
