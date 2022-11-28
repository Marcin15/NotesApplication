using NotesApplication.UseCases.Extensions;
using NotesApplication.UseCases.Helpers;
using NotesApplication.UseCases.Models;
using NotesApplication.UseCases.Services;
using NotesApplication.UseCases.Stores;
using NotesApplication.UseCases.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace NotesApplication.UseCases.ViewModels
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        private readonly IAccountStore _accountStore;
        private readonly IUserService _userService;
        private readonly INoteService _noteService;

        public INewNoteViewModel NewNoteViewModel { get; }

        public string FirstName { get; set; } = "unknown";
        public string LastName { get; set; } = "unknown";

        public ObservableCollection<NoteDisplayerViewModel> Notes { get; set; } = new();

        private RelayCommand _deleteNoteCommand;
        public ICommand DeleteNoteCommand
        {
            get
            {
                if( _deleteNoteCommand is null ) _deleteNoteCommand = new RelayCommand(DeleteNote);

                return _deleteNoteCommand;
            }
        }

        private void DeleteNote(object obj)
        {
            var note = obj as NoteDisplayerViewModel;

            this.Notes.Remove(note);
        }

        public MainViewModel() { }

        public MainViewModel(
            IAccountStore accountStore,
            IUserService userService,
            INewNoteViewModel newNoteViewModel,
            INoteService noteService)
        {
            _accountStore = accountStore;
            _userService = userService;
            _noteService = noteService;

            this.NewNoteViewModel = newNoteViewModel;

            Task.Run(async () =>
            {
                await SetInitialAccout();
                await GetAllNotes();
            }).Wait();
        }

        private async Task SetInitialAccout()
        {
            var user = await _userService.GetInitialUser();
            var account = new Account
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };

            FirstName = account.FirstName;
            LastName = account.LastName;

            _accountStore.Update(account);
            Debug.WriteLine(user);
        }

        private async Task GetAllNotes()
        {
            var notes = await _noteService.GetAllNotes();

            Notes = notes.ToObservableCollection();
        }
    }
}
