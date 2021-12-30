using ExamDemo.Framework.Infrastructure;

namespace ExamDemo.Database.Models
{
    public class GetUserParam : StoredProcedureParams
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
