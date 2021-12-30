using ExamDemo.Framework.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamDemo.Framework.Repositories
{
    public interface IRepositoryAsync<TEntity> : IRepository<TEntity> where TEntity : IObjectState
    {
        Task<List<TEntity>> ExecuteStoredProcedureAsync(string sp, StoredProcedureParams spParams);

        Task<List<TEntity>> ExecuteStoredProcedureAsync(string sp);
    }
}
