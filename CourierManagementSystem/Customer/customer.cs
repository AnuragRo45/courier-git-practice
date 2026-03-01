using System;

namespace CourierManagementSystem.Models
{
    /// <summary>
    /// Represents a customer record with order, tracking and developer notes.
    /// Properties are intentionally declared in the order requested:
    /// 1. Order
    /// 2. Tracking
    /// 3. DevelopersNotes
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Primary identifier for the customer.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Order information (kept as a string to be flexible for order id or brief summary).
        /// </summary>
        public string Order { get; set; } = string.Empty;

        /// <summary>
        /// Tracking identifier associated with the customer's order.
        /// </summary>
        public string Tracking { get; set; } = string.Empty;

        /// <summary>
        /// Developer notes related to this customer or order (internal use).
        /// </summary>
        public string DevelopersNotes { get; set; } = string.Empty;
    }
}   