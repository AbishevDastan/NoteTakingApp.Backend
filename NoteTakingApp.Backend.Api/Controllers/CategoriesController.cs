using MediatR;
using Microsoft.AspNetCore.Mvc;
using NoteTakingApp.Backend.Application.Features.Category.Commands.CreateCategory;
using NoteTakingApp.Backend.Application.Features.Category.Commands.DeleteCategory;
using NoteTakingApp.Backend.Application.Features.Category.Commands.UpdateCategory;
using NoteTakingApp.Backend.Application.Features.Category.Queries.GetAllCategories;
using NoteTakingApp.Backend.Application.Features.Category.Queries.GetCategoryById;
using NoteTakingApp.Backend.Application.Features.Category.Shared;

namespace NoteTakingApp.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<CategoryDto>> Get()
        {
            return await _mediator.Send(new GetAllCategoriesQuery());
        }

        //[HttpGet("{employeeId}/get-by-employee-id")]
        //public async Task<List<NoteDto>> GetByEmployeeId(int employeeId)
        //{
        //    return await _mediator.Send(new Get(employeeId));
        //}

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> Get(int id)
        {
            var note = await _mediator.Send(new GetCategoryByIdQuery(id));
            return Ok(note);
        }

        //[HttpGet("{searchText}/search")]
        //public async Task<ActionResult<List<NoteDto>>> Search(string searchText)
        //{
        //    var notes = await _mediator.Send(new SearchCategoriesQuery(searchText));
        //    return Ok(notes);
        //}

        //[HttpGet("{employeeId}/get-count-by-employee-id")]
        //public async Task<ActionResult<int>> GetCountByEmployeeId(int employeeId)
        //{
        //    var taskItemsCount = await _mediator.Send(new GetEmployeeTaskItemsCountQuery(employeeId));
        //    return Ok(taskItemsCount);
        //}

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> Post(CreateCategoryCommand command)
        {
            var response = await _mediator.Send(command);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateCategoryCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCategoryCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
