using ExamDemo.Contracts;
using ExamDemo.Model;
using ExamDemo.StoreProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Services
{
    public class ExamService : IExamService
    {
        private IExamService _examservice;
        public Exams AddExams(Exams exams)
        {
           return  _examservice.ExecuteStoredProcedure(StoredProcedures.INSERT_EXAM_RECORD);
        }
    }
}
