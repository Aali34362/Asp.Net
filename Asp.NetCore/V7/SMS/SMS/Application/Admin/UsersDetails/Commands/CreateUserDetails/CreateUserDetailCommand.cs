using Domain.Entities;
using MediatR;

namespace Application.Admin.Commands;

public sealed class CreateUserDetailCommand : IRequest<User_Details>
{
  public User_Details? details { get; set; }
}


