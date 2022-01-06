using ExamDemo.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Models
{
    public class InstanceExamResult :BaseEntity
    {
       
        public Guid ExamUniqueName { get; set; }
        public int RegistrationId { get; set; }
        public int UserMark { get; set; }
        public int PassMArk { get; set; }
        public int TotalMark { get; set; }
        //public int UserPersantage { get; set; }

    }
}
