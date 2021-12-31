using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Models;
using System;
using System.Collections.Generic;

namespace ExamDemo.BusinessEntities.Contracts
{
    public interface IExamService
    {
        
        Response AddExam(Exams exams);
        Response GetExam(Guid examUniqueName);
        List<Exams> GetExams();
        ExamInstanceResponse CreateExamInstance(Guid examUniqueName);

    }
}
