using MediatR;
using NoteTakingApp.Backend.Application.Contracts.Persistence;

namespace NoteTakingApp.Backend.Application.Features.Note.Commands.DeleteNote
{
    public class DeleteNodeCommandHandler : IRequestHandler<DeleteNoteCommand, Unit>
    {
        private readonly INoteRepository _noteRepository;

        public DeleteNodeCommandHandler(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task<Unit> Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
        {
            var noteToDelete = await _noteRepository.GetById(request.Id);

            await _noteRepository.Delete(noteToDelete);

            return Unit.Value;
        }
    }
}
