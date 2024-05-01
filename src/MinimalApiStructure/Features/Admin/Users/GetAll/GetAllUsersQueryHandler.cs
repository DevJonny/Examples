using Paramore.Darker;

namespace MinimalApiStructure.Features.Admin.Users.GetAll;

public class GetAllUsersQueryHandler : QueryHandler<GetAllUsersQuery, GetAllUsersQuery.Result>
{
    public override GetAllUsersQuery.Result Execute(GetAllUsersQuery query) => new();
}