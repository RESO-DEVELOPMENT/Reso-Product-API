using System;
using System.Collections.Generic;

namespace Pos_System.Domain.Models
{
    public partial class Session
    {
        public Session()
        {
            Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int NumberOfOrders { get; set; }
        public double? TotalAmount { get; set; }
        public int? TotalPromotion { get; set; }
        public double? TotalChangeCash { get; set; }
        public double? TotalDiscountAmount { get; set; }
        public double? TotalFinalAmount { get; set; }
        public Guid StoreId { get; set; }
        public string? Name { get; set; }

        public virtual Store Store { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
