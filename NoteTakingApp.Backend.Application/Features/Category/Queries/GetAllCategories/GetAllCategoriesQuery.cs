using MediatR;
using NoteTakingApp.Backend.Application.Features.Category.Shared;

namespace NoteTakingApp.Backend.Application.Features.Category.Queries.GetAllCategories
{
    public record GetAllCategoriesQuery : IRequest<List<CategoryDto>>;
}
