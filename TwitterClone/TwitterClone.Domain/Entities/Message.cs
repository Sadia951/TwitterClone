
using System;

namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }

        public string Content { get; set; }

        public bool IsRead { get; set; } = false;

        public DateTime CreatedAt { get; set; }
            = DateTime.UtcNow;
    }
}
