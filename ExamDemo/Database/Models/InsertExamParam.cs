using ExamDemo.Framework.Infrastructure;
using System;

namespace ExamDemo.Database.Models
{
    public class InsertExamParam : StoredProcedureParams
    {
        public int Id { get; set; }
        public Guid UniqueName { get; set; }
        public string ExamName { get; set; }
        public DateTime? InsertDate { get; set; }
        //  public BitConverter IsActive { get; set; }
        public int PassMark { get; set; }
        public int TotalMark { get; set; }
        public int ToatalQuestion { get; set; }
    }
}
