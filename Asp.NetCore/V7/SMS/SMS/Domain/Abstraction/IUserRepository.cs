using Domain.Entities;

namespace Domain.Abstraction;

public interface IUserRepository
{
    void Insert(User_Details user_Details);
}
