using ExamDemo.Framework.Infrastructure;
using System;

namespace ExamDemo.Database.Models
{
    public class InsertExamParam : StoredProcedureParams
    {
       
        public string ExamName { get; set; }
      
        //  public BitConverter IsActive { get; set; }
        public int PassMark { get; set; }
        public int TotalMark { get; set; }
        public int totalQuestions { get; set; }
    }
}
