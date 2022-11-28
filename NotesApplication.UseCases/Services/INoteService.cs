using NotesApplication.Domain.Aggregates;
using NotesApplication.UseCases.ViewModels;

namespace NotesApplication.UseCases.Services
{
    public interface INoteService
    {
        Task<Note> AddNewNote(string title, string content);
        Task DeleteNote(Note note);
        Task<IEnumerable<Note>> GetAllNotes();
    }
}