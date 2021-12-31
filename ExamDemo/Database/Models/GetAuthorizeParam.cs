using ExamDemo.Framework.Infrastructure;

namespace ExamDemo.Database.Models
{
    public class GetAuthorizeParam : StoredProcedureParams
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
