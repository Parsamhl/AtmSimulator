using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Atm.User.AppService
{
    public interface IUserAppService
    {
        string UserDetails(string cardNumber);
    }
}
