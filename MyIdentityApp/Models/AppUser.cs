namespace MyIdentityApp.Models
{
    public class AppUser
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Mobile { get; set; }

        public string? Source { get; set; }
    }
}
