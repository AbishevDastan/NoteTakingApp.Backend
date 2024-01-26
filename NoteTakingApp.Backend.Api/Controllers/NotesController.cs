﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using NoteTakingApp.Backend.Application.Features.Note.Commands.CreateNote;
using NoteTakingApp.Backend.Application.Features.Note.Commands.DeleteNote;
using NoteTakingApp.Backend.Application.Features.Note.Commands.UpdateNote;
using NoteTakingApp.Backend.Application.Features.Note.Queries.GetAllNotes;
using NoteTakingApp.Backend.Application.Features.Note.Queries.GetNoteById;
using NoteTakingApp.Backend.Application.Features.Note.Shared;

namespace NoteTakingApp.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-all")]
        public async Task<List<NoteDto>> Get()
        {
            return await _mediator.Send(new GetAllNotesQuery());
        }

        //[HttpGet("{employeeId}/get-by-employee-id")]
        //public async Task<List<NoteDto>> GetByEmployeeId(int employeeId)
        //{
        //    return await _mediator.Send(new Get(employeeId));
        //}

        [HttpGet("{id}/get-by-id")]
        public async Task<ActionResult<NoteDto>> Get(int id)
        {
            var note = await _mediator.Send(new GetNoteByIdQuery(id));
            return Ok(note);
        }

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
        public async Task<ActionResult> Post(CreateNoteCommand command)
        {
            var response = await _mediator.Send(command);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateNoteCommand command)
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
            var command = new DeleteNoteCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}