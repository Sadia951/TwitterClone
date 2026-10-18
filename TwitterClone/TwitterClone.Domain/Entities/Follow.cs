
using System;

namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid FollowerId { get; set; }
        public Guid FollowingId { get; set; }

        public DateTime CreatedAt { get; set; }
            = DateTime.UtcNow;
    }
}