using Microsoft.EntityFrameworkCore;

namespace OpenSocio.Persistency.DataContexts
{
    public abstract class BaseContext<TContext> : DbContext, IDataContext, IQueryDataContext
        where TContext : DbContext
    {
        protected BaseContext()
            : base()
        {
        }
    }    
}