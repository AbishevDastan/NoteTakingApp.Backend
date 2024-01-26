using MediatR;
using NoteTakingApp.Backend.Application.Features.Note.Shared;

namespace NoteTakingApp.Backend.Application.Features.Note.Queries.SearchNotes
{
    public record SearchNotesQuery(string SearchText) : IRequest<List<NoteDto>>;
}
