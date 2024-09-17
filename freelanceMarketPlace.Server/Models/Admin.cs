namespace freelanceMarketPlace.Server.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } = "Administrator"; // Admin role

        // Foreign Key and Navigation property
        public int UserId { get; set; }
        public User User { get; set; }

        // Relationships (if any, e.g., tracking or auditing actions)
        public ICollection<User> ManagedUsers { get; set; }
        public ICollection<Project> ApprovedProjects { get; set; }
        public ICollection<Transaction> ReviewedTransactions { get; set; }
        public ICollection<Category> ManagedCategories { get; set; }
        //    public ICollection<Notification> Notifications { get; set; } // Notifications for admin (optional)
        //}
    }
}
