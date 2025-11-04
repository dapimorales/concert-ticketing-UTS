using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcertTicketing.Models
{
    public class Concert
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string ConcertName { get; set; }
        public string Performer { get; set; }
        public string Venue { get; set; }
        public DateTime ConcertDate { get; set; }
        public decimal TicketPrice { get; set; }
        public int Capacity { get; set; }

        // Navigation property
        public ICollection<Ticket> Tickets { get; set; }
    }
}
