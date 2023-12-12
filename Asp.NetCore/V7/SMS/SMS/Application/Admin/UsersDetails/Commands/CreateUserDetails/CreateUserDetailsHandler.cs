using Domain.Entities;
using MediatR;

namespace Application.Admin.Commands;

public class CreateUserDetailsHandler : IRequestHandler<CreateUserDetailCommand, User_Details>
{

    public CreateUserDetailsHandler()
    {

    }

    Task<User_Details> IRequestHandler<CreateUserDetailCommand, User_Details>.Handle(CreateUserDetailCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
