namespace freelanceMarketPlace.Server.Models
{

public class Notification
{
    public int NotificationId { get; set; }
    public string Message { get; set; }
    public DateTime DateCreated { get; set; }
    public bool IsRead { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
