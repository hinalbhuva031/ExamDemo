using ExamDemo.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Models
{
    public class GetExamInstanceResult:BaseEntity
    {
        public Guid ExamInstanceUniqueName { get; set; }
        public int PassMark { get; set; }
        public int TotalMark { get; set; }
        public bool IsCompleted { get; set; }
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public int RegistrationId { get; set; }
    }
}
