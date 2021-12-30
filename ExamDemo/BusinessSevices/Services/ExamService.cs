using ExamDemo.BusinessEntities.Contracts;
using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;

namespace ExamDemo.BusinessSevices.Services
{
    public class ExamService : IExamService
    {
       
        private readonly IExamDataService _insertExamDataService;
        public ExamService(IExamDataService insertExamDataService)
        {
            _insertExamDataService = insertExamDataService;
        }
        public Response AddExam(Exams exams)
        {
             _insertExamDataService.InsertExams(exams);
            return new Response { Status = "Success", Content = "Success" };

        }
      
    }
}
