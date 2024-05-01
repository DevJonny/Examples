using MinimalApiStructure.Features.Admin.Teams;
using MinimalApiStructure.Features.Admin.Users;
using MinimalApiStructure.Features.Customer.Basket;
using MinimalApiStructure.Features.Customer.Products;

namespace MinimalApiStructure;

public static class AdminEndpoints
{
    public static WebApplication AddAdminEndpoints(this WebApplication app)
    {
        app.AddUserEndpoints();
        app.AddTeamEndpoints();
        return app;
    }
}

public static class CustomerEndpoints
{
    public static WebApplication AddCustomerEndpoints(this WebApplication app)
    {
        app.AddProductEndpoints();
        app.AddBasketEndpoints();
        return app;
    }
}