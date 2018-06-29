namespace OpenSocio.Domain.Common
{
    public interface IEntity<in TEntity> : IAudit
        where TEntity : class
    {
         
    }
}
