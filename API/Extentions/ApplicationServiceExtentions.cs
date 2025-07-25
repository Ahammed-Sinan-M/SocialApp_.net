using System;
using API.Data;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extentions;

public static class ApplicationServiceExtentions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {

        services.AddControllers();
        services.AddDbContext<DataContext>(options =>
            {

                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
        services.AddCors();
        services.AddScoped<ITokenService, TokenService>();
        return services;

    }




}
