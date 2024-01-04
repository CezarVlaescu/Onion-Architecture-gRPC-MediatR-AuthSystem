using Core_Layer.Entities;
using Infrastructure_Layer.Data;
using Infrastructure_Layer.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Core_Layer.Interfaces.Repository;
using Core_Layer.Interfaces.Repository.Auth;
using Infrastructure_Layer.Repositories.Auth;
using Core_Layer.Interfaces.Services.Auth;
using Infrastructure_Layer.Services.Auth;

namespace Infrastructure_Layer.Injection

{
    // Setup DI for Infrastructure Layer

    // AddScoped: Scoped lifetime services are created once per client request(connection). Use this for services like Entity Framework DbContext or anything related to the request.
    // AddTransient: Transient lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.
    // AddSingleton: Singleton lifetime services are created the first time they are requested (or when Startup.ConfigureServices is run if you specify an instance there) and then every subsequent request will use the same instance.


    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserService, UserService>();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
