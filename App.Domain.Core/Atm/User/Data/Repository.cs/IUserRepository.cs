using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Atm.User.Data.Repository.cs
{
    public interface IUserRepository
    {
        string GetRecipientName(string destinationCardNumber);
    }
}
