using ExamDemo.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.BusinessEntities.Models
{
    public class ExamInstance:BaseEntity
    {
        public Guid ExamRegistrationUniqueName { get; set; }
        
       public int? TotalMark { get; set; }
        public int? PassMark { get; set; }
    }
}
