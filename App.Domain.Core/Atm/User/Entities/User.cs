using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Atm.User.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? CardNumber { get; set; }
        public List<Card.Entities.Card> Cards { get; set; }

    }
}
