namespace freelanceMarketPlace.Server.Models
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Defines the <see cref="FreelanceMarketPlaceContext" />
    /// </summary>
    public class FreelanceMarketPlaceContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FreelanceMarketPlaceContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions{FreelanceMarketPlaceContext}"/></param>
        public FreelanceMarketPlaceContext(DbContextOptions<FreelanceMarketPlaceContext> options)
        : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Users
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the Projects
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// Gets or sets the Proposals
        /// </summary>
        public DbSet<Proposal> Proposals { get; set; }

        /// <summary>
        /// Gets or sets the Contracts
        /// </summary>
        public DbSet<Contract> Contracts { get; set; }

        /// <summary>
        /// Gets or sets the Payments
        /// </summary>
        public DbSet<Payment> Payments { get; set; }

        /// <summary>
        /// Gets or sets the Reviews
        /// </summary>
        public DbSet<Review> Reviews { get; set; }

        /// <summary>
        /// Gets or sets the Categories
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the Skills
        /// </summary>
        public DbSet<Skill> Skills { get; set; }

        /// <summary>
        /// Gets or sets the Messages
        /// </summary>
        public DbSet<Message> Messages { get; set; }

        /// <summary>
        /// Gets or sets the Notifications
        /// </summary>
        public DbSet<Notification> Notifications { get; set; }

        /// <summary>
        /// Gets or sets the Admins
        /// </summary>
        public DbSet<Admin> Admins { get; set; }

        /// <summary>
        /// Gets or sets the Transactions
        /// </summary>
        public DbSet<Transaction> Transactions { get; set; }

        /// <summary>
        /// The OnModelCreating
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder<see cref="ModelBuilder"/></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many relationship between user and project
            modelBuilder.Entity<User>()
                .HasMany(u => u.Projects)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
            //one to many relationship between user and proposals
            modelBuilder.Entity<User>()
                .HasMany(u => u.Proposals).WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            //one-to many relationship between user and contract
            modelBuilder.Entity<User>()
                .HasMany(u => u.Contracts)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            //one to many relationship between user and payment
            modelBuilder.Entity<User>()
                .HasMany(u => u.Payments)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
            //one to many relationship with user and reviews
            modelBuilder.Entity<User>()
               .HasMany(u => u.Reviews)
               .WithOne(r => r.User)
               .HasForeignKey(r => r.UserId);

            //one to many relationship between user and message both sender and reciever

            modelBuilder.Entity<Message>()
    .HasOne(m => m.Sender)
    .WithMany(u => u.SentMessages)
    .HasForeignKey(m => m.SenderId)
    .OnDelete(DeleteBehavior.Restrict);  // Avoid cascading delete to prevent deleting users when deleting messages

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany(u => u.ReceivedMessages)
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            //one to many relationship with notification 

            modelBuilder.Entity<User>()
             .HasMany(u => u.Notifications)
             .WithOne(n => n.User)
             .HasForeignKey(n => n.UserId);

            //Many to many relationship with user and skill

            modelBuilder.Entity<UserSkill>()
    .HasKey(us => new { us.UserId, us.SkillId });

            modelBuilder.Entity<UserSkill>()
                .HasOne(us => us.User)
                .WithMany(u => u.UserSkills)
                .HasForeignKey(us => us.UserId);

            modelBuilder.Entity<UserSkill>()
                .HasOne(us => us.Skill)
                .WithMany(s => s.UserSkills)
                .HasForeignKey(us => us.SkillId);

            //user and admin
            modelBuilder.Entity<User>()
    .HasOne(u => u.Admin)
    .WithOne(a => a.User)
    .HasForeignKey<Admin>(a => a.UserId);

            //user with transaction one to many

            modelBuilder.Entity<User>()
    .HasMany(u => u.Transactions)
    .WithOne(t => t.User)
    .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<User>()
    .HasOne(u => u.Category)
    .WithMany(c => c.Users)
    .HasForeignKey(u => u.CategoryId)
    .OnDelete(DeleteBehavior.SetNull); // Optional: Allows null to avoid deletion cascade

            // project and user many to one
            modelBuilder.Entity<Project>()
    .HasOne(p => p.User)
    .WithMany(u => u.Projects)
    .HasForeignKey(p => p.UserId);
            //Project to category
            modelBuilder.Entity<Project>()
    .HasOne(p => p.Category)
    .WithMany(c => c.Projects)
    .HasForeignKey(p => p.CategoryId);

            //project and proposals one to many

            modelBuilder.Entity<Project>()
    .HasMany(p => p.Proposals)
    .WithOne(pr => pr.Projects)
    .HasForeignKey(pr => pr.ProjectId)
    .OnDelete(DeleteBehavior.NoAction);

            //Project and skill many to many

            modelBuilder.Entity<ProjectSkill>()
    .HasKey(ps => new { ps.ProjectId, ps.SkillId });

            modelBuilder.Entity<ProjectSkill>()
                .HasOne(ps => ps.Project)
                .WithMany(p => p.ProjectSkills)
                .HasForeignKey(ps => ps.ProjectId);

            modelBuilder.Entity<ProjectSkill>()
                .HasOne(ps => ps.Skill)
                .WithMany(s => s.ProjectSkills)
                .HasForeignKey(ps => ps.SkillId);

            //project and transaction one to many
            modelBuilder.Entity<Project>()
    .HasMany(p => p.Transactions)
    .WithOne(t => t.Projects)
    .HasForeignKey(t => t.ProjectId)
   .OnDelete(DeleteBehavior.NoAction);

            // Disable cascading delete
            modelBuilder.Entity<Project>()
       .HasOne(p => p.Contracts)
       .WithOne(c => c.Projects)
       .HasForeignKey<Contract>(c => c.ProjectId)
       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Proposal>()
    .HasOne(p => p.User)
    .WithMany(u => u.Proposals)
    .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Proposal>()
                .HasOne(p => p.Projects)
                .WithMany(proj => proj.Proposals)
                .HasForeignKey(p => p.ProjectId);

            modelBuilder.Entity<Skill>()
    .HasOne(s => s.Category)
    .WithMany(c => c.Skills)
    .HasForeignKey(s => s.CategoryId)
    .OnDelete(DeleteBehavior.SetNull); // Adjust DeleteBehavior as needed

            modelBuilder.Entity<Transaction>()
    .HasOne(t => t.User)
    .WithMany(u => u.Transactions)
    .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<Transaction>()
    .HasOne(t => t.Projects)
    .WithMany(p => p.Transactions)
    .HasForeignKey(t => t.ProjectId);

            modelBuilder.Entity<Transaction>()
    .HasOne(t => t.Contracts)
    .WithMany(c => c.Transactions)
    .HasForeignKey(t => t.ContractId)
    .OnDelete(DeleteBehavior.NoAction); // Optional to allow transactions to exist if the contract is deleted

    

            modelBuilder.Entity<Payment>()
    .HasOne(p => p.User)
    .WithMany(u => u.Payments)
    .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Payment>()
    .HasOne(p => p.Projects)
    .WithMany(proj => proj.Payments)
    .HasForeignKey(p => p.ProjectId)
             .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Payment>()
    .HasOne(p => p.Contracts)
    .WithMany(c => c.Payments)
    .HasForeignKey(p => p.ContractId)
    .OnDelete(DeleteBehavior.NoAction);
            // Optional: allows contracts to be deleted without affecting payments

            modelBuilder.Entity<Review>()
    .HasOne(r => r.User)
    .WithMany(u => u.Reviews)
    .HasForeignKey(r => r.UserId);
            

            modelBuilder.Entity<Review>()
    .HasOne(r => r.Projects)
    .WithMany(p => p.Reviews)
    .HasForeignKey(r => r.ProjectId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Review>()
    .HasOne(r => r.Transaction)
    .WithOne(t => t.Reviews)
    .HasForeignKey<Review>(r => r.TransactionId)
    .OnDelete(DeleteBehavior.NoAction); // Optional: allows transaction to be deleted without affecting review

           

            // Admin and Project
            modelBuilder.Entity<Project>()
                .HasOne(p => p.ApprovedByAdmin)
                .WithMany(a => a.ApprovedProjects)
                .HasForeignKey(p => p.ApprovedByAdminId)
                .OnDelete(DeleteBehavior.NoAction);

            

           
            // Other configurations...
            base.OnModelCreating(modelBuilder);
        }
    }

}
