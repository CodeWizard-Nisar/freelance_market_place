namespace freelanceMarketPlace.Server.Models
{
public class Review
{
    public int ReviewId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime Date { get; set; }

        // Foreign Keys
       

        public int UserId { get; set; }
        public User User { get; set; }

        public int ProjectId { get; set; }
        public Project Projects { get; set; }

        public int? TransactionId { get; set; }
        public Transaction Transaction { get; set; }
    }
}
