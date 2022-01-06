using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;
using ExamDemo.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Services
{
    public class ExamInstanceDataService : IExamInstanceDataService
    {
        private readonly IRepositoryAsync<GetExamInstanceResult> _examInstanceRespository;
        private readonly IRepositoryAsync<NoOutputResult> _emptyResult;

        public ExamInstanceDataService(IRepositoryAsync<GetExamInstanceResult> examInstanceRespository, IRepositoryAsync<NoOutputResult> emptyResult)
        {
            _examInstanceRespository = examInstanceRespository;
            _emptyResult = emptyResult;
        }

        public void EndExam(Guid examInstanceUniqueName, int userMark)
        {
            EndExamParams endExamParams = new EndExamParams()
            {
                ExamInstanceUniqueName = examInstanceUniqueName,
                UserMark = userMark,
            };
            _emptyResult.ExecuteStoredProcedure(StoredProcedures.END_EXAM,endExamParams);
        }

        public GetExamInstanceResult GetExamInstance(Guid examInstanceUniqueName)
        {
            GetExamInstanceParams getExamInstanceParams = new GetExamInstanceParams()
            { ExamInstanceUniqueName = examInstanceUniqueName };
            return _examInstanceRespository.ExecuteStoredProcedure(StoredProcedures.GET_EXAM_INSTANCE, getExamInstanceParams).FirstOrDefault();
        }
       
    }
}
