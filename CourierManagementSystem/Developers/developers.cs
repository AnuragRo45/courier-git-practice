using System;

namespace CourierManagementSystem.Models
{
    /// <summary>
    /// Internal developer notes related to customers or orders.
    /// </summary>
    public class DevelopersNotes
    {
        /// <summary>
        /// Primary identifier for the note.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Optional link to a customer.
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// Optional link to an order.
        /// </summary>
        public Guid? OrderId { get; set; }

        /// <summary>
        /// Note content (internal use).
        /// </summary>
        public string Note { get; set; } = string.Empty;

        /// <summary>
        /// Author of the note.
        /// </summary>
        public string Author { get; set; } = string.Empty;

        /// <summary>
        /// When the note was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public string File2 { get; set; } = string.Empty;

        public void AddNote(string noteContent, string author)
        {
            Note = noteContent;
            Author = author;
            CreatedAt = DateTimeOffset.UtcNow;
        }


        public override string ToString()
        {
            return $"Note by {Author} on {CreatedAt}: {Note}";
        }
    }
}