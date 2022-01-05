using ExamDemo.Framework.Infrastructure;

namespace ExamDemo.Database.Models
{
    public class GetExamRegistrationbyUserParam : StoredProcedureParams
    {
        public string UserEmail { get; set; }
    }
}
