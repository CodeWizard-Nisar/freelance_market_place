namespace freelanceMarketPlace.Server.Models
{
    public class Proposal
{
    public int ProposalId { get; set; }
    public string ProposalText { get; set; }
    public decimal ProposedAmount { get; set; }
    public DateTime ProposedDeadline { get; set; }
    public DateTime DateSubmitted { get; set; }
    public string Status { get; set; } // Pending, Accepted, Rejected

        // Foreign Keys
        public int ProjectId { get; set; }
        public Project Projects { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

}