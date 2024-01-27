using MediatR;
using NoteTakingApp.Backend.Application.Contracts.Persistence;
using NoteTakingApp.Backend.Application.Features.Note.Shared;
using NoteTakingApp.Backend.Application.Mapping;

namespace NoteTakingApp.Backend.Application.Features.Note.Queries.GetNotesByCategoryId
{
    public class GetNotesByCategoryIdQueryHandler : IRequestHandler<GetNotesByCategoryIdQuery, List<NoteDto>>
    {
        private readonly INoteRepository _noteRepository;

        public GetNotesByCategoryIdQueryHandler(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task<List<NoteDto>> Handle(GetNotesByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var notes = await _noteRepository.GetNotesByCategoryId(request.CategoryId);

            var noteDtos = notes.Select(n => n.AsDto()).ToList();

            return noteDtos;
        }
    }
}
