using ExamDemo.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Models
{
    public class GetExamResult : BaseEntity
    {
        [Display(Name ="ExamUniqueName")]
       public Guid UniqueName { get; set; }
        public string ExamName { get; set; }
        public bool IsActive { get; set; }
        public int PassMark { get; set; }
        public int TotalMark { get; set; }
        public int totalQuestions { get; set; }
    }
}
