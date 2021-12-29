using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;
using ExamDemo.Framework.Repositories;
using ExamDemo.Model;
using ExamDemo.StoreProcedures;

namespace ExamDemo.Database.Services
{
    public class TokenDataService : ITokenDataService
    {
        //private readonly ITokenDataService  _tokenDataService;
        private readonly IRepositoryAsync<GetUserResult> _tokenDataService;
        public TokenDataService(IRepositoryAsync<GetUserResult> tokenDataService)
        {
            _tokenDataService = tokenDataService;
        }
       

        public void CreateToken(GetUserParam users)
        {
             _tokenDataService.ExecuteStoredProcedure(StoredProcedures.CREATE_TOKEN , users);
        }
    }
}
