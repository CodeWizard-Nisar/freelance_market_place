namespace freelanceMarketPlace.Server.Models
{


    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Budget { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime PostedDate { get; set; }
        public string Status { get; set; } // Open, In Progress, Completed, etc.
        public string LocationType { get; set; } // Remote or On-site

         public Contract Contracts { get; set; }

        // Foreign Key to User (User)
        public int UserId { get; set; }
        public User User { get; set; }

      
        
       
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public int? ApprovedByAdminId { get; set; }
        public Admin ApprovedByAdmin { get; set; }

        // Relationships
        public ICollection<Proposal> Proposals { get; set; } // Proposals for this project
    
                                                                                                                 //    public ICollection<Skill> SkillsRequired { get; set; } // Many-to-Many relationship with Skill
        public ICollection<ProjectSkill> ProjectSkills { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        public ICollection<Payment> Payments { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
