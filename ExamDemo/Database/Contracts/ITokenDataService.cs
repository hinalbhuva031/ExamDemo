using ExamDemo.Database.Models;

namespace ExamDemo.Database.Contracts
{
    public interface ITokenDataService
    {
        void CreateToken(GetUserParam users);
    }
}
