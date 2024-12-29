using App.Domain.Core.Atm.User.Data.Repository.cs;
using App.Domain.Core.Atm.User.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Atm.User
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string GetRecipientName(string destinationCardNumber)
        {
            return _userRepository.GetRecipientName(destinationCardNumber);
        }
    }
}
