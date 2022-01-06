using ExamDemo.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Contracts
{
    public interface IExamInstanceDataService
    {
        GetExamInstanceResult GetExamInstance(Guid examInstanceUniqueName);

        void EndExam(Guid examInstanceUniqueName, int userMark);
    }
}
