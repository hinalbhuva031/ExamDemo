using ExamDemo.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Models
{
    public class GetExamRegistrationParam :StoredProcedureParams
    {
        public Guid UniqueName { get; set; }
    }
}
