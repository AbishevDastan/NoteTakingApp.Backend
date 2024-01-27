using MediatR;
using NoteTakingApp.Backend.Application.Features.Note.Shared;

namespace NoteTakingApp.Backend.Application.Features.Note.Queries.GetNotesByCategoryId
{
    public record GetNotesByCategoryIdQuery(int CategoryId) : IRequest<List<NoteDto>>;
}
