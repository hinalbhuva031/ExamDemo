using ExamDemo.Framework.Infrastructure;
using System;

namespace ExamDemo.Database.Models
{
    public class GetExamRegistrationResult : BaseEntity
    {
        public Guid ExamUniqueName { get; set; }
        public int UserId { get; set; }

        public string UserEmail { get; set; }

        public int ExamId { get; set; }

        public string ExamName { get; set; }

    }
}
