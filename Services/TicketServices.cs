using ConcertTicketing.Data;
using ConcertTicketing.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ConcertTicketing.Services
{
    public class TicketService
    {
        private readonly ConcertTicketContext _context;

        public TicketService(ConcertTicketContext context)
        {
            _context = context;
        }

        // Ambil semua tiket (include Concert & Account)
        public List<Ticket> GetAll()
        {
            return _context.Tickets
                .Include(t => t.Concert)
                .Include(t => t.Account)
                .ToList();
        }

        public void Add(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        public void Update(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.Tickets.Find(id);
            if (data != null)
            {
                _context.Tickets.Remove(data);
                _context.SaveChanges();
            }
        }

        public Ticket GetById(int id)
        {
            return _context.Tickets
                .Include(t => t.Concert)
                .Include(t => t.Account)
                .FirstOrDefault(t => t.Id == id);
        }
    }
}
