using MediatR;
using NoteTakingApp.Backend.Application.Contracts.Persistence;
using NoteTakingApp.Backend.Application.Features.Note.Shared;
using NoteTakingApp.Backend.Application.Mapping;

namespace NoteTakingApp.Backend.Application.Features.Note.Queries.GetAllNotes
{
    public class GetAllNotesQueryHandler : IRequestHandler<GetAllNotesQuery, List<NoteDto>>
    {
        private readonly INoteRepository _noteRepository;

        public GetAllNotesQueryHandler(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task<List<NoteDto>> Handle(GetAllNotesQuery request, CancellationToken cancellationToken)
        {
            var notes = await _noteRepository.GetAll();

            var notesDto = notes.Select(note => note.AsDto());

            return notesDto.ToList();
        }
    }
}
