namespace freelanceMarketPlace.Server.Models
{
public class Transaction
{
    public int TransactionId { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }
    public string TransactionType { get; set; } // Credit, Debit, Refund, etc.
    public string Status { get; set; } // Completed, Pending, Refunded, etc.

        public Review Reviews { get; set; }
        // Foreign Key to Payment
        
        

        // Foreign Key to User (Optional: tracks who performed the transaction)
        public int UserId { get; set; }
        public User User { get; set; }

        public int ProjectId {  get; set; }
        public Project Projects { get; set; }

        public int? ContractId { get; set; }
        public Contract Contracts { get; set; }


        public int? ReviewedByAdminId { get; set; }
        public Admin ReviewedByAdmin { get; set; }

      
    }                                                               
}