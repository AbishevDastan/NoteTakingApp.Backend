using MediatR;

namespace NoteTakingApp.Backend.Application.Features.Note.Commands.DeleteNote
{
    public class DeleteNoteCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
