using NoteTakingApp.Backend.Application.Features.Note.Commands.CreateNote;
using NoteTakingApp.Backend.Application.Features.Note.Commands.UpdateNote;
using NoteTakingApp.Backend.Application.Features.Note.Shared;
using NoteTakingApp.Backend.Domain.Notes;

namespace NoteTakingApp.Backend.Application.Mapping
{
    public static class NoteMapper
    {
        public static Note AsEntity(this CreateNoteCommand dto)
        {
            var result = new Note
            {
                Title = dto.Title,
                Content = dto.Content
            };
            return result;
        }

        public static Note AsEntity(this NoteDto dto)
        {
            var result = new Note
            {
                Id = dto.Id,
                Title = dto.Title,
                Content = dto.Content
            };
            return result;
        }

        public static NoteDto AsDto(this Note entity)
        {
            var result = new NoteDto
            {
                Id = entity.Id,
                Title = entity.Title,
                Content = entity.Content
            };
            return result;
        }

        public static Note AsDto(this UpdateNoteCommand dto)
        {
            var result = new Note
            {
                Id = dto.Id,
                Title = dto.Title,
                Content = dto.Content
            };
            return result;
        }
    }
}
