using SecureInsights.Common;

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
            if (title.IsNullOrWhiteSpace())
                throw new ArgumentException("Title cannot be empty.");

            if (content.IsNullOrWhiteSpace())
                throw new ArgumentException("Content cannot be empty.");

            if (category.IsNullOrWhiteSpace())
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
            if (title.IsNullOrWhiteSpace())
                throw new ArgumentException("Title cannot be empty.");

            if (content.IsNullOrWhiteSpace())
                throw new ArgumentException("Content cannot be empty.");

            if (category.IsNullOrWhiteSpace())
                throw new ArgumentException("Category cannot be empty.");

            if (this.Title == title && this.Content == content && this.Category == category)
            { 
                throw new Exception("No changes detected. Update operation requires at least one field to be modified.");
            }

            Title = title;
            Content = content;
            Category = category;
            UpdatedAtUtc = DateTime.UtcNow;
        }
    }

    public record CreateNoteRequest(string Title, string Content, string Category);
}
