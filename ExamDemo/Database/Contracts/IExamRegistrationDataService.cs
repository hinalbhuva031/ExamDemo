using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Models;
using System.Collections.Generic;

namespace ExamDemo.Database.Contracts
{
    public interface IExamRegistrationDataService
    {
        InsertUserResult InsertUserData(string userEmail);

        void  InsertExamRegistration(InsertExamRegistrationParams insertExamRegistrationParams);

        List<GetExamRegistrationbyUserResult> GetExamRegistrationbyUser(string userEmail);
    }
}
