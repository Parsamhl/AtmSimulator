using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.infra.DB.SQLServer.Atm.Configuration.User
{
    public class UserConfiguration : IEntityTypeConfiguration<Domain.Core.Atm.User.Entities.User>
    {
        public void Configure(EntityTypeBuilder<Domain.Core.Atm.User.Entities.User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Users");
            builder.HasMany(u => u.Cards)
                .WithOne(c => c.owner);


            builder.HasData(new List<Domain.Core.Atm.User.Entities.User>()
            {
                new Domain.Core.Atm.User.Entities.User () {Id = 1 , Name = "Ali"} ,
                new Domain.Core.Atm.User.Entities.User () {Id = 2 , Name =  "Reza" }


            });
        }
    }
}
