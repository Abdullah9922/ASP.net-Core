using Demo.Application.Contracts;
using Demo.Application.Contracts.Repositories;
using Demo.Infrastructure.Data;
using Demo.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Extensions
{
    public static class DependencyInjections
    {
        public static void AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IApplicationUnitOfWork, ApplicationUnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
