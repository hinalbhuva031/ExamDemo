using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;
using ExamDemo.Framework.Repositories;
using System.Linq;

namespace ExamDemo.Database.Services
{
    public class TokenDataService : ITokenDataService
    {
        private readonly IRepositoryAsync<GetAuthorizeResult> _tokenDataService;
        public TokenDataService(IRepositoryAsync<GetAuthorizeResult> tokenDataService)
        {
            _tokenDataService = tokenDataService;
        }
       

        public GetAuthorizeResult CreateToken(string authorizeUserName, string authorizePassword)
        {           
            var result =  _tokenDataService.ExecuteStoredProcedure(StoredProcedures.CREATE_TOKEN , new GetAuthorizeParam
            {
                UserName = authorizeUserName,
                Password = authorizePassword
            }).FirstOrDefault();
            if (result.IsAuthorize != 1)
            {
                return null;
            } 
            return result;
        }
    }
}
