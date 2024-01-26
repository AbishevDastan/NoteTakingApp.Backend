using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NoteTakingApp.Backend.Application.Contracts.Persistence;
using NoteTakingApp.Backend.Application.Contracts.Persistence.Common;
using NoteTakingApp.Backend.Persistence.DatabaseContext;
using NoteTakingApp.Backend.Persistence.Repositories;
using NoteTakingApp.Backend.Persistence.Repositories.Common;

namespace NoteTakingApp.Backend.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<INoteRepository, NoteRepository>();

            return services;
        }
    }
}
