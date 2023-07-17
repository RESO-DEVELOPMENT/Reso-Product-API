using System;
using System.Collections.Generic;

namespace Pos_System.Domain.Models
{
    public partial class Menu
    {
        public Menu()
        {
            MenuProducts = new HashSet<MenuProduct>();
            MenuStores = new HashSet<MenuStore>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Priority { get; set; }
        public int DateFilter { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string Status { get; set; } = null!;
        public Guid BrandId { get; set; }

        public virtual Brand Brand { get; set; } = null!;
        public virtual ICollection<MenuProduct> MenuProducts { get; set; }
        public virtual ICollection<MenuStore> MenuStores { get; set; }
    }
}
