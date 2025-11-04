using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcertTicketing.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string TicketNumber { get; set; }
        public string SeatNumber { get; set; }
        public decimal PricePaid { get; set; }
        public DateTime? PurchaseDate { get; set; }

        // Foreign Keys
        public int ConcertId { get; set; }
        public int? AccountId { get; set; }

        // Navigation properties
        public Concert Concert { get; set; }
        public Account Account { get; set; }
    }
}
