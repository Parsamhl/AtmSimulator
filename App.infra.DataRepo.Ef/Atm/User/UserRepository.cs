using App.Domain.Core.Atm.User.Data.Repository.cs;
using App.infra.DB.SQLServer.Atm.DataBase;
using Microsoft.EntityFrameworkCore;


namespace App.infra.DataRepo.Ef.Atm.User
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository()
        {
            _context = new AppDbContext();
        }

        public string GetRecipientName(string destinationCardNumber)
        {
            var user = _context.Users
            .Include(u => u.Cards)
            .FirstOrDefault(u => u.Cards.Any(c => c.CardNumber == destinationCardNumber));

            return user?.Name;
        }
    }
}
