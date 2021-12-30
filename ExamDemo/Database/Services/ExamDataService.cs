using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;
using ExamDemo.Framework.Repositories;

namespace ExamDemo.Database.Services
{
    public class ExamDataService : IExamDataService
    {
        private IRepositoryAsync<ExamResult> _repositoryservice;
        public ExamDataService(IRepositoryAsync<ExamResult> repositoryservice)
        {
            _repositoryservice = repositoryservice;
        }
        public void InsertExams(Exams exam)
        {
            InsertExamParam isertExamParam = new InsertExamParam() { 
            ExamName = exam.ExamName,
            ToatalQuestion = exam.ToatalQuestion,
            PassMark = exam.PassMark,
            TotalMark = exam.TotalMark,
            };
            _repositoryservice.ExecuteStoredProcedure(StoredProcedures.INSERT_EXAM_RECORD, isertExamParam);
        }
    }
}
