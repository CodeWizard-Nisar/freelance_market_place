namespace freelanceMarketPlace.Server.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Budget { get; set; }
        public DateTime Deadline { get; set; }

        // Foreign key
        public int ClientId { get; set; }  // Client who posted the project
        public User Client { get; set; }  // Navigation property (only for Clients)

        // Navigation property
        public ICollection<Bid> Bids { get; set; }
    }

}
