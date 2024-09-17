namespace freelanceMarketPlace.Server.Models
{
public class Message
{
    public int MessageId { get; set; }
    public string Content { get; set; }
    public DateTime SentDate { get; set; }

        // Foreign Keys
        public int SenderId { get; set; }
        public User Sender { get; set; }

        public int ReceiverId { get; set; }
        public User Receiver { get; set; }

        //public int? ContractId { get; set; }
        //public Contract Contract { get; set; }
    }
}
