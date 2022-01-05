using ExamDemo.Framework.Infrastructure;
using System;

namespace ExamDemo.Database.Models
{
    public class InsertExamRegistrationParams : StoredProcedureParams
    {
        public Guid ExamUniqueName { get; set; }

        public string UserEmail { get; set; }
    }
}
