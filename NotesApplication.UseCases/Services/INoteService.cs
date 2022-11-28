using NotesApplication.UseCases.ViewModels;

namespace NotesApplication.UseCases.Services
{
    public interface INoteService
    {
        Task AddNewNote(string title, string content);
        Task<IEnumerable<NoteDisplayerViewModel>> GetAllNotes();
    }
}