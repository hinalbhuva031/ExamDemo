using ExamDemo.Model;

namespace ExamDemo.Database.Contracts
{
    public interface ITokenDataService
    {
        Users CreateToken(Users users);
    }
}
