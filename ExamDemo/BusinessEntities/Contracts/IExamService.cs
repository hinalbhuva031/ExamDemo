using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Models;
using System;
using System.Collections.Generic;

namespace ExamDemo.BusinessEntities.Contracts
{
    public interface IExamService
    {
        
        Response AddExam(InsertExam exams);
        Exams GetExam(Guid examUniqueName);
        List<Exams> GetExams();
        Response CreateExamInstance(ExamInstance examInstance);
        // Response CreateExamInstance(Guid examUniqueName);
        GetExamInstanceResult GetExamInstance(Guid examInstanceUniqueName);

        Response EndExam(Guid examInstanceUniqueName, int userMark);
    }
}
