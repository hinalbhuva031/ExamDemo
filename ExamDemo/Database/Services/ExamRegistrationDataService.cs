using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;
using ExamDemo.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamDemo.Database.Services
{

    public class ExamRegistrationDataService : IExamRegistrationDataService
    {
        private readonly IRepositoryAsync<InsertUserResult> _insertUserDataService;
        private readonly IRepositoryAsync<NoOutputResult> _emptyResult;
        private readonly IRepositoryAsync<GetExamRegistrationbyUserResult> _examRegistrationbyUserRepository;

        public ExamRegistrationDataService(IRepositoryAsync<InsertUserResult> insertUserDataService, IRepositoryAsync<NoOutputResult> emptyResult, IRepositoryAsync<GetExamRegistrationbyUserResult> examRegistrationbyUserRepository)
        {
            _insertUserDataService = insertUserDataService;
            _emptyResult = emptyResult;
            _examRegistrationbyUserRepository = examRegistrationbyUserRepository;
        }

        public InsertUserResult InsertUserData(string userEmail)
        {
             var result = _insertUserDataService.ExecuteStoredProcedure(StoredProcedures.INSERT_USER, new InsertUserParam
            {
                UserEmail = userEmail
            }) .FirstOrDefault();
            if (result.DataInserted  != 1)
            {
                return null;
            }
            return result;
        }

        public void  InsertExamRegistration(InsertExamRegistrationParams insertExamRegistrationParams)
        {
            
             _emptyResult.ExecuteStoredProcedure(StoredProcedures.INSERT_EXAM_REGISTRATION, insertExamRegistrationParams);
            
        }

        public List<GetExamRegistrationbyUserResult> GetExamRegistrationbyUser(string userEmail)
        {
            return _examRegistrationbyUserRepository.ExecuteStoredProcedure(StoredProcedures.GET_EXAM_REGISTRATION_FOR_USER, new GetExamRegistrationbyUserParam
            {
                UserEmail = userEmail
            });
        }

    }
}
