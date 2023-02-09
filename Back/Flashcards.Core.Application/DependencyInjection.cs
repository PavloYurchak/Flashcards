
using Flashcards.Infrastructure.Persistence.Repositories.Home;
using Flashcards.Infrastructure.Persistence.Services.Home;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Flashcards.Core.Application
{
    public static class DependencyInjection
    {
        public static void RegisterServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IHomeService,HomeService>();
            services.AddScoped<IHomeRepository, HomeRepository>();
        }
    }
}
