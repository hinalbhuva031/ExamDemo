using ExamDemo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Models
{
    public class GetUserParam : StoredProcedureParams
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
