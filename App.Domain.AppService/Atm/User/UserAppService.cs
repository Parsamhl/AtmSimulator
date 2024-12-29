using App.Domain.Core.Atm.User.AppService;
using App.Domain.Core.Atm.User.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Atm.User
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
        {
            _userService = userService;
        }

        public string UserDetails(string cardNumber)
        {
            var userName = _userService.GetRecipientName(cardNumber);
            if (string.IsNullOrEmpty(userName))
                throw new Exception("Destination card number not found.");

            return userName;
        }
    }
}
