
namespace NotesApplication.UseCases.Services
{
    public interface INoteService
    {
        Task AddNewNote(string title, string content);
    }
}