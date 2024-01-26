using MediatR;

namespace NoteTakingApp.Backend.Application.Features.Note.Commands.UpdateNote
{
    public class UpdateNoteCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
