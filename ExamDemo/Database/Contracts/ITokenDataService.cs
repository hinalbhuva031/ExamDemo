using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Models;

namespace ExamDemo.Database.Contracts
{
    public interface ITokenDataService
    {
        GetAuthorizeResult CreateToken(string authorizeUserName, string authorizePassword);
    }
}
