using NotesApplication.Domain.Aggregates;

namespace NotesApplication.UseCases.Repositories
{
    public interface INoteRepository : IRepository
    {
        Task Add(Note note);
        Task<IEnumerable<Note>> GetAll(Guid userId);
        Task Remove(Note note);
    }
}
