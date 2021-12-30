using ExamDemo.Framework.Infrastructure;
using System.Collections.Generic;

namespace ExamDemo.Framework.Repositories
{
    public interface IRepository<TEntity> where TEntity : IObjectState
    {
        List<TEntity> ExecuteStoredProcedure(string sp, StoredProcedureParams spParams);

        List<TEntity> ExecuteStoredProcedure(string sp);
    }
}

