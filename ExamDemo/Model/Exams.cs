using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Model
{
    public class Exams
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
