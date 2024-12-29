using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.infra.DB.SQLServer.Atm.Configuration.Card
{
    public class CardConfiguration : IEntityTypeConfiguration<Domain.Core.Atm.Card.Entities.Card>
    {
        public void Configure(EntityTypeBuilder<Domain.Core.Atm.Card.Entities.Card> builder)
        {
            builder.HasKey(x => x.ID);
            builder.ToTable("Cards");



            builder.HasData(new List<Domain.Core.Atm.Card.Entities.Card>()
            {
                new Domain.Core.Atm.Card.Entities.Card() { ID = 1, CardNumber = "6037697604053527" , Password = "3030" , Balance = 65 ,UserID = 1},
                new Domain.Core.Atm.Card.Entities.Card() { ID = 2, CardNumber = "6219861967053066" , Password = "3030" , Balance = 200 ,UserID = 2 },

            });
        }
    }
}
