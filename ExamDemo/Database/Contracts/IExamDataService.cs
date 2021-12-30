using ExamDemo.BusinessEntities.Models;

namespace ExamDemo.Database.Contracts
{
    public interface IExamDataService
    {
        void InsertExams(Exams exam);
    }
}
