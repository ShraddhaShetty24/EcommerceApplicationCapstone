using MediatR;
using Products.Models;

namespace Users.Commands.UserCommands
{
    public record UpdateUserCommand(Tuser user) : IRequest<List<Tuser>>
    {
    }
}
