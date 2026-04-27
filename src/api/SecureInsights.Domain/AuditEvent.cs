using SecureInsights.Common;

namespace SecureInsights.Domain
{
    public class AuditEvent
    {
        public Guid Id { get; private set; }
        public string EventType { get; private set; }
        public string EntityType { get; private set; }
        public Guid EntityId { get; private set; }
        public Guid TriggeredByUserId { get; private set; }
        public DateTime OccurredAtUtc { get; private set; }

        public AuditEvent(string eventType, string entityType, Guid entityId, Guid triggeredByUserId)
        {
            if (eventType.IsNullOrWhiteSpace())
                throw new ArgumentException("EventType cannot be empty.");

            if (entityType.IsNullOrWhiteSpace())
                throw new ArgumentException("EntityType cannot be empty.");

            if (entityId.IsGuidEmpty())
                throw new ArgumentException("EntityId cannot be empty.");

            Id = Guid.NewGuid();
            EventType = eventType;
            EntityType = entityType;
            EntityId = entityId;
            TriggeredByUserId = triggeredByUserId;
            OccurredAtUtc = DateTime.UtcNow;
        }
    }
}
