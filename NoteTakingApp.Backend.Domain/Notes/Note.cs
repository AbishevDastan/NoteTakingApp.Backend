using NoteTakingApp.Backend.Domain.Common;

namespace NoteTakingApp.Backend.Domain.Notes
{
    public class Note : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
