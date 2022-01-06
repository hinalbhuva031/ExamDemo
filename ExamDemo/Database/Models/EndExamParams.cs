using ExamDemo.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Models
{
    public class EndExamParams : StoredProcedureParams
    {
        public Guid ExamInstanceUniqueName { get; set; }
        public int UserMark { get; set; }
    }
}
