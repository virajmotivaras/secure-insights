namespace SecureInsights.Domain
{
    public class AuditEvent
    {
        public Guid Id { get; private set; }
        public string EventType { get; private set; }
        public string EntityType { get; private set; }
        public string EntityId { get; private set; }
        public Guid TriggeredByUserId { get; private set; }
        public DateTime OccurredAtUtc { get; private set; }

        public AuditEvent(string eventType, string entityType, string entityId, Guid triggeredByUserId)
        {
            if (string.IsNullOrWhiteSpace(eventType))
                throw new ArgumentException("EventType cannot be empty.");

            if (string.IsNullOrWhiteSpace(entityType))
                throw new ArgumentException("EntityType cannot be empty.");

            if (string.IsNullOrWhiteSpace(entityId))
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
