using MailServices.implementationRepository;
using MailServices.InterfaceRepository;
using MailServices.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailServices
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMailService(
            this IServiceCollection services,
            Action<MailSettings> configure)
        {
            services.Configure(configure);
            services.AddTransient<IMailService, MailService>();            
            return services;
        }
    }
}
