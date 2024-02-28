using BlazingBlog.Application.Articles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingBlog.Application {
    public static class DepenencyInjection {
        public static IServiceCollection AddApplication(this IServiceCollection services) {

            services.AddMediatR(configuration => {
                configuration.RegisterServicesFromAssembly(typeof(DepenencyInjection).Assembly);
            });

            return services;
        }
    }
}
