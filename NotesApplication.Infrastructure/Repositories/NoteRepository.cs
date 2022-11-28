using Microsoft.EntityFrameworkCore;
using NotesApplication.Domain.Aggregates;
using NotesApplication.UseCases.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.Infrastructure.Repositories
{
    public class NoteRepository : RepositoryBase, INoteRepository
    {
        private DbSet<Note> _notes;

        public NoteRepository(DataContext dataContext) : base(dataContext)
        {
            _notes = dataContext.Notes;
        }

        public async Task<IEnumerable<Note>> GetAll(Guid userId) => await _notes.AsNoTracking()
                                                                                .Where(x => x.UserId == userId)
                                                                                .ToListAsync();
        public async Task Add(Note note) => await _notes.AddAsync(note);
    }
}
