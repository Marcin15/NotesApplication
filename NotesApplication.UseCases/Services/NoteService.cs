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

        public async Task AddNewNote(string title, string content)
        {
            var newNote = Note.CreateNote(_accountStore.GetCurrentAccount().Id, title, content);
            await _noteRepository.Add(newNote);
            await _noteRepository.Save();
        }

        public async Task<IEnumerable<NoteDisplayerViewModel>> GetAllNotes()
        {
            var accountId = _accountStore.GetCurrentAccount().Id;

            var notes = await _noteRepository.GetAll(accountId);

            return notes.Select(x => new NoteDisplayerViewModel
            {
                Title = x.Title,
                Content = x.Content,
                DateCreated = x.DateCreated
            });
        }
    }
}
