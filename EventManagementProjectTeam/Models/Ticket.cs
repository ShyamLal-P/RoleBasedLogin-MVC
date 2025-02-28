using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagementProjectTeam.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }

        [ForeignKey("User")]
        public int Id { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }
       
    }
}
