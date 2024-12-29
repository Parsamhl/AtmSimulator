using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Atm.Transaction.Dtos
{
    public class TransactionDto
    {
        public string SourceCardNumber { get; set; }
        public string DestinationsCardNumber { get; set; }
        public DateTime TransavtionDate { get; set; }
        public float Amount { get; set; }
        public bool IsSuccess { get; set; }
    }
}
