using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;
using ExamDemo.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamDemo.Database.Services
{
    public class ExamDataService : IExamDataService
    {
        private readonly IRepositoryAsync<ExamResult> _repositoryservice;
        private readonly IRepositoryAsync<GetExamResult> _examRepository;
        private readonly IRepositoryAsync<GetExamsResult> _examsRepository;
        public ExamDataService(IRepositoryAsync<ExamResult> repositoryservice, IRepositoryAsync<GetExamResult> examRepository,
          IRepositoryAsync<GetExamsResult> examsRepository)
        {
            _repositoryservice = repositoryservice;
            _examRepository = examRepository;
            _examsRepository = examsRepository;
            
    }
        public void InsertExams(Exams exam)
        {
            InsertExamParam isertExamParam = new InsertExamParam() { 
            ExamName = exam.ExamName,
            PassMark = exam.PassMark,
            TotalMark = exam.TotalMark,
            totalQuestions = exam.totalQuestions
            };
            _repositoryservice.ExecuteStoredProcedure(StoredProcedures.INSERT_EXAM_RECORD, isertExamParam);
        }

        public GetExamResult GetExam(Guid examUniqueName)
        {
            GetExamParams getExamParams = new GetExamParams() { UniqueName = examUniqueName };
            return _examRepository.ExecuteStoredProcedure(StoredProcedures.GET_EXAM, getExamParams).FirstOrDefault();
           
        }

        public List<GetExamsResult> GetExams()
        {
            return _examsRepository.ExecuteStoredProcedure(StoredProcedures.GET_EXAMS);
        }
    }
}
