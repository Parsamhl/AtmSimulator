using App.Domain.Core.Atm.User.Data.Repository.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.infra.DataRepo.Ef.Atm.User
{
    public class UserRepository : IUserRepository
    {
        public string GetRecipientName(string destinationCardNumber)
        {
            throw new NotImplementedException();
        }
    }
}
