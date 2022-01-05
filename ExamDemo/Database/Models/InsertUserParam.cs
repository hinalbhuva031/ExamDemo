using ExamDemo.Framework.Infrastructure;

namespace ExamDemo.Database.Models
{
    public class InsertUserParam : StoredProcedureParams
    {
        public string UserEmail { get; set; }
    }
}
