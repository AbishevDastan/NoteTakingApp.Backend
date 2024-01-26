using MediatR;
using NoteTakingApp.Backend.Application.Features.Note.Shared;

namespace NoteTakingApp.Backend.Application.Features.Note.Queries.GetAllNotes
{
    public record GetAllNotesQuery : IRequest<List<NoteDto>>;
}
