using System;

namespace ExamDemo.Framework.DataContext

{
    public interface IDataContext : IDisposable
    {
        int SaveChanges();
        void SyncObjectState(object entity);
    }
}
