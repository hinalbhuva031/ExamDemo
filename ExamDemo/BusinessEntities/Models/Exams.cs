using ExamDemo.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.BusinessEntities.Models
{
    public class Exams 
    {
       
        //public int Id { get; set; }
        public Guid ExamUniqueName { get; set; }
        public string ExamName { get; set; }
        public bool IsActive { get; set; }
        public int PassMark { get; set; }
        public int TotalMark { get; set; }
        public int totalQuestions { get; set; }
    }
}
