using NotesApplication.Domain.Aggregates;
using NotesApplication.UseCases.Repositories;
using NotesApplication.UseCases.Stores;
using NotesApplication.UseCases.ViewModels;

namespace NotesApplication.UseCases.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;
        private readonly IAccountStore _accountStore;

        public NoteService(INoteRepository noteRepository, IAccountStore accountStore)
        {
            _noteRepository = noteRepository;
            _accountStore = accountStore;
        }

        public async Task<Note> AddNewNote(string title, string content)
        {
            var newNote = Note.CreateNote(_accountStore.GetCurrentAccount().Id, title, content);
            await _noteRepository.Add(newNote);
            await _noteRepository.Save();

            return newNote;
        }

        public async Task<IEnumerable<Note>> GetAllNotes()
        {
            var accountId = _accountStore.GetCurrentAccount().Id;

            return await _noteRepository.GetAll(accountId);

            //return notes.Select(x => new NoteDisplayerViewModel
            //{
            //    Title = x.Title,
            //    Content = x.Content,
            //    DateCreated = x.DateCreated
            //});
        }

        public async Task DeleteNote(Note note)
        {
            await _noteRepository.Remove(note);
        }
    }
}
