using System;

namespace ExamDemo.BusinessEntities.Models
{
    public class ExamRegistrationbyUserDto
    {
        public Guid ExamRegistrationUniqueName { get; set; }

        public int UserId { get; set; }

        public string UserEmail { get; set; }

        public int ExamId { get; set; }

        public string ExamName { get; set; }
    }
}
