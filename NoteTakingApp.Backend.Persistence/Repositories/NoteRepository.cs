using NoteTakingApp.Backend.Application.Contracts.Persistence;
using NoteTakingApp.Backend.Domain.Notes;
using NoteTakingApp.Backend.Persistence.DatabaseContext;
using NoteTakingApp.Backend.Persistence.Repositories.Common;

namespace NoteTakingApp.Backend.Persistence.Repositories
{
    public class NoteRepository : GenericRepository<Note>, INoteRepository
    {
        public NoteRepository(ApplicationDatabaseContext context) : base(context)
        {
        }

        public async Task<List<Note>> GetNotesByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
