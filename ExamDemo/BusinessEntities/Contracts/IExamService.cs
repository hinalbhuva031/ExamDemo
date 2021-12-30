using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Models;

namespace ExamDemo.BusinessEntities.Contracts
{
    public interface IExamService
    {
        
        Response AddExam(Exams exams);
       
    }
}
