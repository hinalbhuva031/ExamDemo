using ExamDemo.BusinessEntities.Contracts;
using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;
using System;

namespace ExamDemo.BusinessSevices.Services
{
    public class TokenService : ITokenService
    {
        private readonly ITokenDataService _tokenDataService;

        public TokenService(ITokenDataService tokenDataService)
        {
            _tokenDataService = tokenDataService;
        }
        public Response CreateToken(string authorizeUserName, string authorizePassword)
        {
            try
            {
                 var result = _tokenDataService.CreateToken(authorizeUserName,  authorizePassword);
                if(result == null)
                {
                    return null;
                }
                else
                {
                    return new Response { Status = "Success", Content = "Success" };
                }

            }
            catch(Exception ex)
            {
                throw (ex);
            }
            
        }
    }
}
