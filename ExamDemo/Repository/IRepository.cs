using ExamDemo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Repository
{
    public interface IRepository<TEntity> 
    {
        List<TEntity> ExecuteStoredProcedure(string sp, StoredProcedureParams spParams);
    }
}

