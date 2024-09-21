namespace freelanceMarketPlace.Server.Models
{
    public class User
    {
        public int UserId { get; set; }  // Primary Key
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        // Distinguish between Freelancer and Client
        public string Role { get; set; }  // Either "Freelancer" or "Client"

        // Navigation properties for relationships
        public ICollection<Project> Projects { get; set; }  // Only applicable if the user is a Client
        public ICollection<Bid> Bids { get; set; }  // Only applicable if the us
    }
}
