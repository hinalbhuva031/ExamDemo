using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Models
{
    public class GetExamsResult : GetExamResult
    {
        public Guid ExamUniqueName { get; set; }
    }
}
