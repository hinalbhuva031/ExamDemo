using ExamDemo.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Models
{
    public class GetExamInstanceParams :StoredProcedureParams
    {
        public Guid ExamInstanceUniqueName { get; set; }
    }
}
