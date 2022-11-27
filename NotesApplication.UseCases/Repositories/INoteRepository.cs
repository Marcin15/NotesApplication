using NotesApplication.Domain.Aggregates;

namespace NotesApplication.UseCases.Repositories
{
    public interface INoteRepository : IRepository
    {
        Task Add(Note note);
    }
}
