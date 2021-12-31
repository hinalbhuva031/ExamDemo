using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Models;
using System;
using System.Collections.Generic;

namespace ExamDemo.Database.Contracts
{
    public interface IExamDataService
    {
        void InsertExams(Exams exam);

        GetExamResult GetExam(Guid examUniqueName);

       List<GetExamsResult> GetExams();
         
    }
}
