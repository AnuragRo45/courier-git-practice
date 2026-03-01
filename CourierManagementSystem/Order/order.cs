using System;
using System.Collections.Generic;

namespace CourierManagementSystem.Models
{
    /// <summary>
    /// Represents an order placed by a customer.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Primary identifier for the order.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Identifier of the customer who placed the order.
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Human-friendly order number or identifier.
        /// </summary>
        public string OrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// Simple list of item identifiers/descriptions for the order.
        /// </summary>
        public List<string> Items { get; set; } = new();

        /// <summary>
        /// Total amount for the order.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Order status (e.g. Pending, Confirmed, Shipped).
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Timestamp when the order was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}