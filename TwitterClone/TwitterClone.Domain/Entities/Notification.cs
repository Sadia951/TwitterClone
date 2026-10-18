
using System;

namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UserId { get; set; }
        public Guid ActorId { get; set; }

        public string Type { get; set; }
        public string Content { get; set; }

        public bool IsRead { get; set; } = false;

        public DateTime CreatedAt { get; set; }
            = DateTime.UtcNow;
    }
}