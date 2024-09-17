
namespace freelanceMarketPlace.Server.Models
{

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }


        

        // Relationships

        public ICollection<Project> Projects { get; set; }
        public ICollection<Skill> Skills { get; set; }

        public ICollection<User> Users { get; set; }

        public int? ManagedByAdminId { get; set; }
        public Admin ManagedByAdmin { get; set; }
    }
}