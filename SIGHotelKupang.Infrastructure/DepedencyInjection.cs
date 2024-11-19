using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SIGHotelKupang.Infrastructure.Database;

namespace SIGHotelKupang.Infrastructure;

public static class DepedencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Default") ?? throw new ArgumentNullException("connection string 'default' is null");

        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(
            connectionString,
            o => o.UseNetTopologySuite()));

        return services;
    }
}
