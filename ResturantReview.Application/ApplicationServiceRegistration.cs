using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResturantReview.Domain.Infreastructure;
using ResturantReview.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ResturantReview.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {



            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
           // services.AddScoped<IModelRepository, ModelRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IResturantRepository, ResturantRepository>();


            //Aktiverar automapper i Core
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
