using ExamDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Contracts
{
    public interface IExamService
    {
        Exams AddExams(Exams exams);
    }
}
