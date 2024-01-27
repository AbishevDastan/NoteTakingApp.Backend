using NoteTakingApp.Backend.Domain.Categories;
using NoteTakingApp.Backend.Domain.Common;

namespace NoteTakingApp.Backend.Domain.Notes
{
    public class Note : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
