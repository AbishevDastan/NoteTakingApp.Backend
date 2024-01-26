using MediatR;
using NoteTakingApp.Backend.Application.Contracts.Persistence;
using NoteTakingApp.Backend.Application.Features.Note.Shared;
using NoteTakingApp.Backend.Application.Mapping;

namespace NoteTakingApp.Backend.Application.Features.Note.Queries.SearchNotes
{
    public class SearchNotesQueryHandler : IRequestHandler<SearchNotesQuery, List<NoteDto>>
    {
        private readonly INoteRepository _noteRepository;

        public SearchNotesQueryHandler(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task<List<NoteDto>> Handle(SearchNotesQuery request, CancellationToken cancellationToken)
        {
            var notes = await _noteRepository.SearchNotes(request.SearchText);

            return notes.Select(n => n.AsDto()).ToList();
        }
    }
}
