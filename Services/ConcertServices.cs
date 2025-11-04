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
            // 1. Ambil ID dari objek yang dikirim
            int id = concert.Id;

            // 2. Cari objek yang sudah ada di database (ini akan otomatis dilacak)
            var concertToUpdate = _context.Concerts.Find(id);

            if (concertToUpdate == null)
            {
                // Penanganan jika entitas tidak ditemukan
                throw new KeyNotFoundException($"Konser dengan ID {id} tidak ditemukan.");
            }

            // 3. Modifikasi properti pada objek yang SUDAH DILACAK 
            //    menggunakan data dari objek 'concert' yang dikirim dari form
            concertToUpdate.ConcertName = concert.ConcertName;
            concertToUpdate.Performer = concert.Performer;
            concertToUpdate.Venue = concert.Venue;
            concertToUpdate.ConcertDate = concert.ConcertDate;
            concertToUpdate.TicketPrice = concert.TicketPrice;
            concertToUpdate.Capacity = concert.Capacity;

            // 4. Simpan perubahan. EF Core secara otomatis mendeteksi properti yang berubah, 
            //    tanpa perlu memanggil .Update()
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
