using ExamDemo.Database.Models;
using ExamDemo.Model;

namespace ExamDemo.Database.Contracts
{
    public interface ITokenDataService
    {
        void CreateToken(GetUserParam users);
    }
}
