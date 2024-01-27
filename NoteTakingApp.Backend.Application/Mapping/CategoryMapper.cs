using NoteTakingApp.Backend.Application.Features.Category.Commands.CreateCategory;
using NoteTakingApp.Backend.Application.Features.Category.Commands.UpdateCategory;
using NoteTakingApp.Backend.Application.Features.Category.Shared;
using NoteTakingApp.Backend.Domain.Categories;

namespace NoteTakingApp.Backend.Application.Mapping
{
    public static class CategoryMapper
    {
        public static Category AsEntity(this CreateCategoryCommand dto)
        {
            var result = new Category
            {
                Name = dto.Name,
            };
            return result;
        }

        public static Category AsEntity(this CategoryDto dto)
        {
            var result = new Category
            {
                Id = dto.Id,
                Name = dto.Name
            };
            return result;
        }

        public static CategoryDto AsDto(this Category entity)
        {
            var result = new CategoryDto
            {
                Id = entity.Id,
                Name = entity.Name
            };
            return result;
        }

        public static Category AsDto(this UpdateCategoryCommand dto)
        {
            var result = new Category
            {
                Id = dto.Id,
                Name = dto.Name
            };
            return result;
        }
    }
}
