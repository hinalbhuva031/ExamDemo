using ExamDemo.Contracts;
using ExamDemo.Model;
using System;

namespace ExamDemo.BusinessSevices.Services
{
    public class TokenService : IToken
    {
        public Users CreateToken(Users users)
        {
            try
            {
                var TokenData = _examRegistrationDataService.GetExamRegistration(examRegistrationUniqueName);
                if (TokenData == null)
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }
    }
}
