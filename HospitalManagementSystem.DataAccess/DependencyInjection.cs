using HospitalManagementSystem.DataAccess.Context;
using HospitalManagementSystem.DataAccess.Repositories;
using HospitalManagementSystem.Entities.Models;
using HospitalManagementSystem.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataAccess;
public static class DependencyInjection
{
    public static IServiceCollection AddDataAccess(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        //DbContext
        string connectionString = configuration.GetConnectionString("SqlServer");
        services.AddDbContext<ApplicationDbContext>(opt =>
        {
            opt.UseSqlServer(connectionString);
        });
        //Identity
        services.AddIdentityCore<AppUser>(cfr =>
        {
            cfr.Password.RequiredLength = 6;
            cfr.Password.RequireNonAlphanumeric = false;
        }).AddEntityFrameworkStores<ApplicationDbContext>();

        //IUnitOfWork
        services.AddScoped<IUnitOfWork>(sv => sv.GetRequiredService<ApplicationDbContext>());

        //with Scrutor Library Dpendency Injection
        services.Scan(selector => selector
            .FromAssemblies(
                typeof(DependencyInjection).Assembly)
            .AddClasses(publicOnly: false)
            .UsingRegistrationStrategy(RegistrationStrategy.Skip)
            .AsMatchingInterface()
            .WithScopedLifetime());

        return services;
    }
}
