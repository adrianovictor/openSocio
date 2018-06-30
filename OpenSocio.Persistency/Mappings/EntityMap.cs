using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSocio.Domain.Common;

namespace OpenSocio.Persistency.Mappings
{
    public class EntityMap<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : class, IEntity<TEntity>
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(_ => _.CreatedAt).IsRequired().HasColumnType("datetime");
            builder.Property(_ => _.CreatedBy).IsRequired();
            builder.Property(_ => _.UpdatedAt).HasColumnType("datetime");
            builder.Property(_ => _.UpdatedBy);
        }
    }
}
