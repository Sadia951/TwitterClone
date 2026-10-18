
using System;

namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UserId { get; set; }
        public Guid PostId { get; set; }

        public DateTime CreatedAt { get; set; }
            = DateTime.UtcNow;
    }
}