using MediatR;
using NoteTakingApp.Backend.Application.Contracts.Persistence;
using NoteTakingApp.Backend.Application.Mapping;

namespace NoteTakingApp.Backend.Application.Features.Note.Commands.CreateNote
{
    public class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand, int>
    {
        private readonly INoteRepository _noteRepository;

        public CreateNoteCommandHandler(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task<int> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
        {
            var noteToCreate = request.AsEntity();

            await _noteRepository.Create(noteToCreate);

            return noteToCreate.Id;
        }
    }
}
