using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.DataContext
{
    public interface IDataContext
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
        void SyncObjectState(object entity);
    }
}
