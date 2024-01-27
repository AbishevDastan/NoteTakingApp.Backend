using NoteTakingApp.Backend.Application.Contracts.Persistence;
using NoteTakingApp.Backend.Domain.Categories;
using NoteTakingApp.Backend.Persistence.DatabaseContext;
using NoteTakingApp.Backend.Persistence.Repositories.Common;

namespace NoteTakingApp.Backend.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDatabaseContext context) : base(context) { }
    }
}
