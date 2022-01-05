using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.BusinessEntities.Models
{
    public class ExamRegistration
    {
        public Guid ExamUniqueName { get; set; }

        public string UserEmail { get; set; }   

    }
}
