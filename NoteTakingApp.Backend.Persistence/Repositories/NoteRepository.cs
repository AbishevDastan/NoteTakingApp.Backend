using Microsoft.EntityFrameworkCore;
using NoteTakingApp.Backend.Application.Contracts.Persistence;
using NoteTakingApp.Backend.Domain.Notes;
using NoteTakingApp.Backend.Persistence.DatabaseContext;
using NoteTakingApp.Backend.Persistence.Repositories.Common;

namespace NoteTakingApp.Backend.Persistence.Repositories
{
    public class NoteRepository : GenericRepository<Note>, INoteRepository
    {
        public NoteRepository(ApplicationDatabaseContext context) : base(context) { }

        //public Task<List<Note>> GetNotesByCategoryId(int categoryId)
        //{
        //    return awai
        //}

        public async Task<List<Note>> SearchNotes(string searchText)
        {
            return await _context.Notes
                .Where(n => n.Title.ToLower().Contains(searchText.ToLower()) ||
                       n.Content.ToLower().Contains(searchText.ToLower()))
                .ToListAsync();
        }
    }
}
