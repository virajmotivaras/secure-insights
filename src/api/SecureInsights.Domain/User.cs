using SecureInsights.Common;

namespace SecureInsights.Domain
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }
        public bool IsActive { get; private set; }

        public User(string name, string email, string role)
        {
            if (name.IsNullOrWhiteSpace())
                throw new ArgumentException("Name cannot be empty.");

            if (email.IsNullOrWhiteSpace())
                throw new ArgumentException("Email cannot be empty.");

            if (role.IsNullOrWhiteSpace())
                throw new ArgumentException("Role cannot be empty.");

            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Role = role;
            IsActive = true;
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    }
}
