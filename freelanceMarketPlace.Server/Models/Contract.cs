
namespace freelanceMarketPlace.Server.Models
{
public class Contract
{
    public int ContractId { get; set; }
    public decimal AgreedAmount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; } // Active, Completed, Cancelled

        // Foreign Keys
        public int ProjectId { get; set; }
        public Project Projects { get; set; }

        

        public int UserId { get; set; }
        public User User { get; set; }

        // Relationships
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
