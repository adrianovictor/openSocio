using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSocio.Domain.Model.Account;

namespace OpenSocio.Persistency.Mappings.Account
{
    public class UserMap : EntityMap<User>
    {
        //public void Configure(EntityTypeBuilder<User> entityBuilder)
        //{
        //    entityBuilder.ToTable("Users");

        //    entityBuilder.HasKey(_ => _.Id);
        //    entityBuilder.Property(_ => _.Name).IsRequired().HasMaxLength(128).IsUnicode(false);
        //    entityBuilder.Property
        //}
    }
}
