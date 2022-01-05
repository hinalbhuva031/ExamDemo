using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExamDemo.BusinessEntities.Contracts

{
    public interface IExamRegistrationService
    {
         Response UserExamRegistration(ExamRegistration examRegistration);

        Response InsertUserData(string userEmail);

        Response GetExamRegistrationbyUser(string userEmail);

    }
}
