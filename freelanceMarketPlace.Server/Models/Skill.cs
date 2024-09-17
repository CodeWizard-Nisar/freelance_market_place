namespace freelanceMarketPlace.Server.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }

        //ForeignKeys
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        // Many-to-Many Relationships
        public ICollection<ProjectSkill> ProjectSkills { get; set; }

        public ICollection<UserSkill> UserSkills { get; set; }
        //    public ICollection<User> Freelancers { get; set; }
        //    public ICollection<Project> Projects { get; set; }
        //}                                                 
            }
}
