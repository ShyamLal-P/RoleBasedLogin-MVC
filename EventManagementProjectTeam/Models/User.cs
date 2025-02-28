namespace EventManagementProjectTeam.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }

        // Navigation properties
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        //public ICollection<Feedback> Feedbacks { get; set; }
    }
}
