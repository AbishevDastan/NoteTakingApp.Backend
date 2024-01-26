using MediatR;

namespace NoteTakingApp.Backend.Application.Features.Note.Commands.CreateNote
{
    public class CreateNoteCommand : IRequest<int>
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
