using Domain.Exceptions.Base;

namespace Domain.Exceptions;

public sealed class UserDetailsNotFoundException : NotFoundException
{
    public UserDetailsNotFoundException(string user_created_id) 
        : base($"The user detail with the identifier {user_created_id} was not found")
    { }
}
