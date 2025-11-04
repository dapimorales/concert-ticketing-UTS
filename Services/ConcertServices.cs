using ConcertTicketing.Data;
using ConcertTicketing.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ConcertTicketing.Services
{
    public class ConcertService
    {
        private readonly ConcertTicketContext _context;

        public ConcertService(ConcertTicketContext context)
        {
            _context = context;
        }

        // Ambil semua konser
        public List<Concert> GetAll()
        {
            return _context.Concerts
                .Include(c => c.Tickets)
                .OrderBy(c => c.ConcertDate)
                .ToList();
        }

        // Tambah konser baru
        public void Add(Concert concert)
        {
            _context.Concerts.Add(concert);
            _context.SaveChanges();
        }

        // Update data konser
        public void Update(Concert concert)
        {
            _context.Concerts.Update(concert);
            _context.SaveChanges();
        }

        // Hapus konser
        public void Delete(int id)
        {
            var data = _context.Concerts.Find(id);
            if (data != null)
            {
                _context.Concerts.Remove(data);
                _context.SaveChanges();
            }
        }

        // Ambil satu konser berdasarkan id
        public Concert GetById(int id)
        {
            return _context.Concerts.FirstOrDefault(c => c.Id == id);
        }
    }
}
