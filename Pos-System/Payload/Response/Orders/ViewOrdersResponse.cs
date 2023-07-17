﻿using Pos_System.API.Enums;

namespace Pos_System.API.Payload.Response.Orders
{
    public class ViewOrdersResponse
    {
        public Guid Id { get; set; }
        public string InvoiceId { get; set; }
        public string StaffName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double FinalAmount { get; set; }
        public OrderType OrderType { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }

    }
}
