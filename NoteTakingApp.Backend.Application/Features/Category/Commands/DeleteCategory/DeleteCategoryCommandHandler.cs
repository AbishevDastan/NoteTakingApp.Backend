using MediatR;
using NoteTakingApp.Backend.Application.Contracts.Persistence;

namespace NoteTakingApp.Backend.Application.Features.Category.Commands.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, Unit>
    {
        private readonly ICategoryRepository _categoryRepository;

        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryToDelete = await _categoryRepository.GetById(request.Id);

            await _categoryRepository.Delete(categoryToDelete);

            return Unit.Value;
        }
    }
}
