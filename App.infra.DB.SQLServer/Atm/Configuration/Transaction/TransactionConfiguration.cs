using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.infra.DB.SQLServer.Atm.Configuration.Transaction
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Domain.Core.Atm.Transaction.Entities.Transaction>
    {
        public void Configure(EntityTypeBuilder<Domain.Core.Atm.Transaction.Entities.Transaction> builder)
        {
            builder.HasKey(x => x.TransactionsId);
            builder.ToTable("Transaction");

            builder.Property(x => x.TransactionsId)
                .ValueGeneratedOnAdd();

            builder.HasOne(a => a.SourceCard)
                .WithMany(a => a.SentTransaction)
                .HasForeignKey(a => a.SourceCardNumberId)
             .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.DestinationCard)
                .WithMany(a => a.RecivedTransaction)
                .HasForeignKey(a => a.DestinationCardNumberID)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
