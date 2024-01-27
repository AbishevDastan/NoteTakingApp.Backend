using NoteTakingApp.Backend.Domain.Common;
using NoteTakingApp.Backend.Domain.Notes;

namespace NoteTakingApp.Backend.Domain.Categories
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<Note>? Notes { get; set; }
    }
}
