namespace freelanceMarketPlace.Server.Models
{
        public class Payment
    {
        //internal object Transactions;

        public int PaymentId { get; set; }

                public decimal Amount { get; set; }

                public DateTime PaymentDate { get; set; }

                public string Status { get; set; }

        // Foreign Key

        public int UserId { get; set; }

                public User User { get; set; }

                public int ProjectId { get; set; }

                public Project Projects { get; set; }

                public int ContractId { get; set; }

                public Contract Contracts { get; set; }
    }
}
