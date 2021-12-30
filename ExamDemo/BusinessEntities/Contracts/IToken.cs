using ExamDemo.BusinessEntities.Models;


namespace ExamDemo.BusinessEntities.Contracts

{
    public interface IToken
    {
        Users CreateToken(Users users);
    }
}
