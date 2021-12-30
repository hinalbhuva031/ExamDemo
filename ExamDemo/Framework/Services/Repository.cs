using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamDemo.Framework.Repositories;
using ExamDemo.Framework.Infrastructure;
using ExamDemo.Framework.DataContext;

namespace ExamDemo.Framework.Services
{
    public class Repository<TEntity> : IRepositoryAsync<TEntity> where TEntity : BaseEntity
    {
        private readonly IDataContextAsync _context;
        public Repository(IDataContextAsync context)
        {
            _context = context;
        }
        public Task<List<TEntity>> ExecuteStoredProcedureAsync(string sp, StoredProcedureParams spParams)
        {
            var sqlParams = spParams.AsSqlParameters();

            // construct list of parameters required by sp with name used to get parameter object from passed parameters
            var paramNames = (from p in sqlParams
                              select $"@{p.ParameterName} = @{p.ParameterName}").ToArray();

            return (_context as DataContext).Database.SqlQuery<TEntity>($"EXEC {sp} {string.Join(",", paramNames)}", sqlParams).ToListAsync();

        }

        public Task<List<TEntity>> ExecuteStoredProcedureAsync(string sp)
        {
            return (_context as DataContext).Database.SqlQuery<TEntity>("EXEC " + sp).ToListAsync();
        }
        public List<TEntity> ExecuteStoredProcedure(string sp, StoredProcedureParams spParams)
        {
            var sqlParams = spParams.AsSqlParameters();

            // construct list of parameters required by sp with name used to get parameter object from passed parameters
            var paramNames = (from p in sqlParams
                              select $"@{p.ParameterName} = @{p.ParameterName}").ToArray();

            var data = (_context as DataContext).Database.SqlQuery<TEntity>($"EXEC {sp} {string.Join(",", paramNames)}", sqlParams).ToList();
            return data;
        }

        public List<TEntity> ExecuteStoredProcedure(string sp)
        {
            return (_context as DataContext).Database.SqlQuery<TEntity>("EXEC " + sp).ToList();
        }
    }
}
