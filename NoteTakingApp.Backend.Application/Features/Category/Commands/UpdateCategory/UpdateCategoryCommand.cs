﻿using MediatR;

namespace NoteTakingApp.Backend.Application.Features.Category.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
