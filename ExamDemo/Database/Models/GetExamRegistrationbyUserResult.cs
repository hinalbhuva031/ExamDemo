using System;

namespace ExamDemo.Database.Models
{
    public class GetExamRegistrationbyUserResult : GetExamRegistrationResult
    {
        public Guid ExamregistrationuniqueName { get; set; }
    }
}
