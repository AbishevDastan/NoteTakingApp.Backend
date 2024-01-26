using MediatR;
using NoteTakingApp.Backend.Application.Features.Note.Shared;

namespace NoteTakingApp.Backend.Application.Features.Note.Queries.GetNoteById
{
    public record GetNoteByIdQuery(int Id) : IRequest<NoteDto> { }
}
