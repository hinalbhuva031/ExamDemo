using ExamDemo.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Models
{
    public class GetUserResult : BaseEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
