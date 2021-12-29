using ExamDemo.Framework.Infrastructure;
using ExamDemo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Repository
{
    public interface IRepository<TEntity> where TEntity : IObjectState
    {
        List<TEntity> ExecuteStoredProcedure(string sp, StoredProcedureParams spParams);

        List<TEntity> ExecuteStoredProcedure(string sp);
    }
}

