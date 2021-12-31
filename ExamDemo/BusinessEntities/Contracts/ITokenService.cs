using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Models;

namespace ExamDemo.BusinessEntities.Contracts

{
    public interface ITokenService
    {
        Response CreateToken(string authorizeUserName, string authorizePassword);
    }
}
