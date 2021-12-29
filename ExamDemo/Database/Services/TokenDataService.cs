using ExamDemo.Database.Contracts;
using ExamDemo.Model;
using ExamDemo.StoreProcedures;

namespace ExamDemo.Database.Services
{
    public class TokenDataService : ITokenDataService
    {
        private readonly ITokenDataService  _tokenDataService;

        public TokenDataService(ITokenDataService tokenDataService)
        {
            _tokenDataService = tokenDataService;
        }

        public Users CreateToken(Users users)
        {
            return _tokenDataService.ExecuteStoredProcedure(StoredProcedures.CREATE_TOKEN);
        }
    }
}
