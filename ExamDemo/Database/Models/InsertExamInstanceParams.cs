using ExamDemo.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Models
{
    public class InsertExamInstanceParams : StoredProcedureParams
    {
        //public Guid ExamInstanceUniqueName { get; set; }
       // public Guid UniqueName { get; set; }
        public Guid ExamRegistrationUniqueName { get; set; }
        
        public int? TotalMark { get; set; }
        public int? PassMark { get; set; }
        //public int? UserPersantage { get; set; }
    }
}
