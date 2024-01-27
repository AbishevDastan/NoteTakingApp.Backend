using MediatR;
using NoteTakingApp.Backend.Application.Features.Category.Shared;

namespace NoteTakingApp.Backend.Application.Features.Category.Queries.GetCategoryById
{
    public record GetCategoryByIdQuery(int Id) : IRequest<CategoryDto> { }
}
