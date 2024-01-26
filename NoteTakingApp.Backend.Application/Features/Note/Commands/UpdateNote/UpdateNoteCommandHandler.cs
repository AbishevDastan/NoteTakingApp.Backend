using MediatR;
using NoteTakingApp.Backend.Application.Contracts.Persistence;
using NoteTakingApp.Backend.Application.Mapping;

namespace NoteTakingApp.Backend.Application.Features.Note.Commands.UpdateNote
{
    public class UpdateNoteCommandHandler : IRequestHandler<UpdateNoteCommand, Unit>
    {
        private readonly INoteRepository _noteRepository;

        public UpdateNoteCommandHandler(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task<Unit> Handle(UpdateNoteCommand request, CancellationToken cancellationToken)
        {
            var noteToUpdate = request.AsDto();

            await _noteRepository.Update(noteToUpdate);

            return Unit.Value;
        }
    }
}
