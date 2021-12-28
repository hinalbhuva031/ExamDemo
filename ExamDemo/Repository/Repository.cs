using ExamDemo.DataContext;
using ExamDemo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ExamDemo.Repository
{
    public class Repository<TEntity> : IRepositoryAsync<TEntity> where TEntity : BaseEntity
    {
        private readonly IDataContextAsync _context;
        public List<TEntity> ExecuteStoredProcedure(string sp, StoredProcedureParams spParams)
        {
            var sqlParams = spParams.AsSqlParameters();

            // construct list of parameters required by sp with name used to get parameter object from passed parameters
            var paramNames = (from p in sqlParams
                              select $"@{p.ParameterName} = @{p.ParameterName}").ToArray();

            var data = (_context as DataContext).Database.SqlQuery<TEntity>($"EXEC {sp} {string.Join(",", paramNames)}", sqlParams).ToList();
            return data;
        }
    }
}
