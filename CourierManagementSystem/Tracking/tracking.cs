using System;

namespace CourierManagementSystem.Models
{
    /// <summary>
    /// Represents tracking information for an order.
    /// </summary>
    public class Tracking
    {
        /// <summary>
        /// Primary identifier for the tracking record.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Associated order identifier.
        /// </summary>
        public Guid OrderId { get; set; }

        /// <summary>
        /// Carrier tracking number.
        /// </summary>
        public string TrackingNumber { get; set; } = string.Empty;

        /// <summary>
        /// Current shipment status (e.g. InTransit, Delivered).
        /// </summary>
        public string CurrentStatus { get; set; } = string.Empty;

        /// <summary>
        /// Current or last known location.
        /// </summary>
        public string CurrentLocation { get; set; } = string.Empty;

        /// <summary>
        /// When the tracking record was last updated.
        /// </summary>
        public DateTimeOffset LastUpdated { get; set; } = DateTimeOffset.UtcNow;
    }
}