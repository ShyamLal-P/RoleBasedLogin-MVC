using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagementProjectTeam.Models
{
    public class Notifications
    {
        [Key]
        public int NotificationId { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }

        [ForeignKey("Event")]
        public int EventID { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime SentTimestamp { get; set; }

        public virtual User User { get; set; }
        public virtual Event Event { get; set; }
    }
}
