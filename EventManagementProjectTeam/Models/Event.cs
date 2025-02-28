using System.ComponentModel.DataAnnotations;

namespace EventManagementProjectTeam.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public DateOnly Date { get; set; }
        public int OrganizerId { get; set; }
    }
}
