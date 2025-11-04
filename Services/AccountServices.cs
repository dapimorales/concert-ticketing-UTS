using ConcertTicketing.Data;
using ConcertTicketing.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ConcertTicketing.Services
{
    public class AccountService
    {
        private readonly ConcertTicketContext _context;

        public AccountService(ConcertTicketContext context)
        {
            _context = context;
        }

        public List<Account> GetAll()
        {
            return _context.Accounts.Include(a => a.Tickets).ToList();
        }

        public void Add(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void Update(Account account)
        {
            var existing = _context.Accounts.Find(account.Id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(account);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var data = _context.Accounts.Find(id);
            if (data != null)
            {
                _context.Accounts.Remove(data);
                _context.SaveChanges();
            }
        }

        public Account GetById(int id)
        {
            return _context.Accounts.FirstOrDefault(a => a.Id == id);
        }
    }
}
