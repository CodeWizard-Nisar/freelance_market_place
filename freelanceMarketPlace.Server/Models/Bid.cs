namespace freelanceMarketPlace.Server.Models
{

    public class Bid
    {
        public int BidId { get; set; }
        public decimal BidAmount { get; set; }
        public string Proposal { get; set; }
        public DateTime BidDate { get; set; }

        // Foreign keys
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int UserId { get; set; }  // The freelancer who placed the bid
        public User Freelancer { get; set; }  // Navigation property
    }

}
