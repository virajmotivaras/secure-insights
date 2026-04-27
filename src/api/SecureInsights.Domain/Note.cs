namespace SecureInsights.Domain
{
    public class Note
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Category { get; private set; }
        public DateTime CreatedAtUtc { get; private set; }
        public DateTime UpdatedAtUtc { get; private set; }
        public Guid CreatedByUserId { get; private set; }

        public Note(string title, string content, string category, Guid createdByUserId)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty.");

            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Content cannot be empty.");

            if (string.IsNullOrWhiteSpace(category))
                throw new ArgumentException("Category cannot be empty.");

            Id = Guid.NewGuid();
            Title = title;
            Content = content;
            Category = category;
            CreatedByUserId = createdByUserId;
            CreatedAtUtc = DateTime.UtcNow;
            UpdatedAtUtc = DateTime.UtcNow;
        }

        public void Update(string title, string content, string category)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty.");

            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Content cannot be empty.");

            if (string.IsNullOrWhiteSpace(category))
                throw new ArgumentException("Category cannot be empty.");

            Title = title;
            Content = content;
            Category = category;
            UpdatedAtUtc = DateTime.UtcNow;
        }
    }
}
