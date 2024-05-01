using Paramore.Brighter;

namespace MinimalApiStructure.Features.Admin.Users.CreateUser;

public class CreateUserCommand : Command
{
    public CreateUserCommand() : base(Guid.NewGuid())
    {
    }
}