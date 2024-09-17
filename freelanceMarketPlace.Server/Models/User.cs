namespace freelanceMarketPlace.Server.Models
{
    public class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; } // Freelancer or User
    public string ProfilePicture { get; set; }
    public string Bio { get; set; }
    public string Location { get; set; }
    public float Rating { get; set; }
    public DateTime DateCreated { get; set; }

        public int? AdminId { get; set; }
        public Admin Admin { get; set; }

        //Foreign key to category 
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

       
        


        // Relationships
        public ICollection<Project> Projects { get; set; } // Projects posted by this user (User)
    public ICollection<Proposal> Proposals { get; set; } // Proposals submitted by this user (Freelancer)
    public ICollection<Contract> Contracts { get; set; } // Contracts for both Freelancer and User
        public ICollection<Payment> Payments { get;set; }//Payments for work
    public ICollection<Review> Reviews { get; set; } // Reviews by this user
        public ICollection<Message> SentMessages { get; set; }
        public ICollection<Message> ReceivedMessages { get; set; }

        public ICollection<UserSkill> UserSkills { get; set; }
        public ICollection<Notification> Notifications { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        //    public object Skills { get; internal set; }
    }

}
