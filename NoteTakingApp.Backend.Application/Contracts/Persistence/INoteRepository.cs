﻿using NoteTakingApp.Backend.Application.Contracts.Persistence.Common;
using NoteTakingApp.Backend.Domain.Notes;

namespace NoteTakingApp.Backend.Application.Contracts.Persistence
{
    public interface INoteRepository : IGenericRepository<Note>
    {
        Task<List<Note>> SearchNotes(string searchText);
        Task<List<Note>> GetNotesByCategoryId(int categoryId);
    }
}
